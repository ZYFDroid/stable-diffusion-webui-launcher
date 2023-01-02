using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDLauncher
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 

        public static int AvailablePort = 32409;

        [STAThread]
        static void Main()
        {
            PrepareWebview2RuntimeEnvironment();
            FindAvailablePorts();
            if(AvailablePort < 0)
            {
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void FindAvailablePorts()
        {
            int count = 0;
            Random rnd = new Random();
            while(!IsPortAvailable(AvailablePort))
            {
                AvailablePort = rnd.Next(32000, 38999);
                count++;
                if(count > 1024)
                {
                    MessageBox.Show("启动失败，没有可用的端口（你是怎么做到的）");
                    AvailablePort = -1;
                    return;
                }
            }
        }

        private static bool IsPortAvailable(int port)
        {
            try
            {
                var x = new TcpListener(IPAddress.Loopback, port);
                x.Start();
                x.Stop();
                return true;
            }
            catch(Exception ex) {
                return false;
            }
        }

        private static void PrepareWebview2RuntimeEnvironment()
        {
            string baseDir = Path.Combine(Environment.GetEnvironmentVariable("LOCALAPPDATA"),"SDWebuiLauncher","wvruntime_0");
            if(!Directory.Exists(baseDir)) {Directory.CreateDirectory(baseDir);}
            string flagFile = Path.Combine(baseDir, "runtime.ok");
            if(!File.Exists(flagFile))
            {
                using (ZipArchive zipArchive = new ZipArchive(new MemoryStream(Properties.Resources.webviewRuntimeBinary), ZipArchiveMode.Read, false))
                {
                    foreach (var item in zipArchive.Entries)
                    {
                        if (item.FullName.EndsWith("/"))
                        {

                        }
                        else
                        {
                            string fileName = Path.Combine(baseDir, item.FullName);
                            string fileDir = Path.GetDirectoryName(fileName);
                            if (!Directory.Exists(fileDir)) { Directory.CreateDirectory(fileDir); }
                            using(FileStream fs = File.Create(fileName))
                            {
                                using(Stream s = item.Open())
                                {
                                    s.CopyTo(fs);
                                }
                            }
                        }
                    }
                    File.Create(flagFile).Close();
                }

            }

            if (Environment.Is64BitProcess)
            {
                CoreWebView2Environment.SetLoaderDllFolderPath(Path.Combine(baseDir, "runtimes", "win-x64", "native"));
            }
            else
            {

                CoreWebView2Environment.SetLoaderDllFolderPath(Path.Combine(baseDir, "runtimes", "win-x86", "native"));
            }

        }

    }
}
