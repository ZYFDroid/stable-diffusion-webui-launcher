using ConsoleControlCommon;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string webviewDataPath = Path.Combine(Environment.GetEnvironmentVariable("LOCALAPPDATA"), "SDWebuiLauncher", "WebViewData"); ;
            Task<CoreWebView2Environment> createEnvTask = CoreWebView2Environment.CreateAsync(userDataFolder: webviewDataPath);
            createEnvTask.Wait();
            CoreWebView2Environment env = createEnvTask.Result;
            webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
            webView.EnsureCoreWebView2Async(env);
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {
                MessageBox.Show("未安装 WebView2 组件");
                Environment.Exit(-1);
            }
            else
            {
                webView.CoreWebView2.Navigate("about:blank");
                StartServer(customArgs);
                initWebView2();
            }
        }
        void initWebView2()
        {
            webView.CoreWebView2.Settings.IsSwipeNavigationEnabled = false;
        }
        private void mnuShowConsole_Click(object sender, EventArgs e)
        {
            if(tblMain.SelectedPage == pageWebView)
            {

                tblMain.SelectedPage = pageConsole;
            }
            else
            {

                tblMain.SelectedPage = pageWebView;
            }
        }


        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!confirm("是否刷新 WebUI 页面？ 现有的任务不会中止，您可以在控制台中查看进度，并稍后于 WebUI 的图库浏览器中查看结果。"))
            {
                return;
            }
            webView.CoreWebView2?.Reload();

        }

        private bool confirm(string msg)
        {
            return MessageBox.Show(msg,Text,MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        private void mnuLaunch_Click(object sender, EventArgs e)
        {
            StartServer(customArgs);
        }

        private void mnuRelaunch_Click(object sender, EventArgs e)
        {
            if (!confirm("是否重启？当前正在进行的任务会丢失。"))
            {
                return;
            }
            shouldRelaunch = true;
            StopServer();
        }

        private void mnuSetArgs_Click(object sender, EventArgs e)
        {

        }

        //  --medvram --xformers --deepdanbooru 
        //  --port xxx

        string defaultBaseArgs = "--deepdanbooru ";
        string customArgs = "--medvram --xformers --max-batch-count 50 ";

        private void StartServer(string args)
        {
            string finalArgs = defaultBaseArgs + args + "--port " + Program.AvailablePort;
            ConsoleStartArgs consoleStartArgs = new ConsoleStartArgs();
            string basedir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "stable-diffusion-webui");
            string pythonExe = Path.Combine(basedir, "python", "python.exe");
            consoleStartArgs.WorkingDirectory = basedir;
            consoleStartArgs.FileName = pythonExe;
            consoleStartArgs.Arguments = "webui.py " + finalArgs;
            consoleControl.StartConsole(consoleStartArgs);
            if (!checkWebuiWorker.IsBusy)
            {
                checkWebuiWorker.RunWorkerAsync();
            }
        }

        private void StopServer() {
            consoleControl.SendControlC();
            if (checkWebuiWorker.IsBusy)
            {
                checkWebuiWorker.CancelAsync();
            }
        }

        bool shouldRelaunch = false;
        private void consoleControl_ConsoleExited(object sender, EventArgs e)
        {
            if(shouldRelaunch)
            {
                shouldRelaunch = false;
                StartServer(customArgs);
            }
        }

        int MsgWebuiOk = 34;



        private void checkWebuiWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void checkWebuiWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!e.Cancel)
            {
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                
                try
                {
                    client.Connect(IPAddress.Loopback, Program.AvailablePort);
                    client.Close();
                    client.Dispose();
                    checkWebuiWorker.ReportProgress(MsgWebuiOk);
                    return;
                }catch(Exception ex)
                {

                }
            }
        }

        bool loadedWebContent = false;

        private void checkWebuiWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == MsgWebuiOk)
            {
                tblMain.SelectedPage = pageWebView;
                if (!loadedWebContent)
                {
                    loadedWebContent = true;
                    webView.CoreWebView2.Navigate("http://localhost:" + Program.AvailablePort);
                }
                
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.None || e.CloseReason == CloseReason.MdiFormClosing)
            {
                e.Cancel = true;
                if (confirm("是否退出？"))
                {
                    e.Cancel = false;
                    consoleControl.ForceCloseConsole();
                }
            }
        }

        private void 打开模型目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string basedir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "stable-diffusion-webui");
            Process.Start("explorer","\""+Path.Combine(basedir, "models"));
        }

        private void 打开输出目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string basedir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "stable-diffusion-webui");
            Process.Start("explorer", "\"" + Path.Combine(basedir, "outputs"));
        }

        private void tblMain_SelectedPageChanged(object sender, EventArgs e)
        {
            if(tblMain.SelectedPage == pageWebView)
            {
                mnuSwitchConsole.Text = "显示控制台";

            }
            else
            {
                mnuSwitchConsole.Text = "显示 WebUI";
            }
        }
    }
}
