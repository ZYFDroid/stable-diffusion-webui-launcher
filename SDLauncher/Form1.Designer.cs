namespace SDLauncher
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetArgs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelaunch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSwitchConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenDir = new System.Windows.Forms.ToolStripMenuItem();
            this.打开模型目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开输出目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMain = new Creek.UI.MultiPanel.MultiPaneControl();
            this.pageConsole = new Creek.UI.MultiPanel.MultiPanePage();
            this.consoleControl = new ConsoleControl.ConsoleControl();
            this.pageWebView = new Creek.UI.MultiPanel.MultiPanePage();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.checkWebuiWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.pageConsole.SuspendLayout();
            this.pageWebView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动ToolStripMenuItem,
            this.mnuSwitchConsole,
            this.mnuOpenDir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1360, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 启动ToolStripMenuItem
            // 
            this.启动ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLaunch,
            this.mnuSetArgs,
            this.mnuRelaunch,
            this.toolStripSeparator2,
            this.mnuRefresh,
            this.toolStripSeparator1,
            this.mnuExit});
            this.启动ToolStripMenuItem.Name = "启动ToolStripMenuItem";
            this.启动ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.启动ToolStripMenuItem.Text = "启动";
            // 
            // mnuLaunch
            // 
            this.mnuLaunch.Name = "mnuLaunch";
            this.mnuLaunch.Size = new System.Drawing.Size(172, 22);
            this.mnuLaunch.Text = "启动";
            this.mnuLaunch.Click += new System.EventHandler(this.mnuLaunch_Click);
            // 
            // mnuSetArgs
            // 
            this.mnuSetArgs.Name = "mnuSetArgs";
            this.mnuSetArgs.Size = new System.Drawing.Size(172, 22);
            this.mnuSetArgs.Text = "设置启动参数";
            this.mnuSetArgs.Click += new System.EventHandler(this.mnuSetArgs_Click);
            // 
            // mnuRelaunch
            // 
            this.mnuRelaunch.Name = "mnuRelaunch";
            this.mnuRelaunch.Size = new System.Drawing.Size(172, 22);
            this.mnuRelaunch.Text = "重启";
            this.mnuRelaunch.Click += new System.EventHandler(this.mnuRelaunch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(172, 22);
            this.mnuRefresh.Text = "刷新 WebUI 页面";
            this.mnuRefresh.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(172, 22);
            this.mnuExit.Text = "退出";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuSwitchConsole
            // 
            this.mnuSwitchConsole.Name = "mnuSwitchConsole";
            this.mnuSwitchConsole.Size = new System.Drawing.Size(88, 21);
            this.mnuSwitchConsole.Text = "显示 WebUI";
            this.mnuSwitchConsole.Click += new System.EventHandler(this.mnuShowConsole_Click);
            // 
            // mnuOpenDir
            // 
            this.mnuOpenDir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开模型目录ToolStripMenuItem,
            this.打开输出目录ToolStripMenuItem});
            this.mnuOpenDir.Name = "mnuOpenDir";
            this.mnuOpenDir.Size = new System.Drawing.Size(53, 21);
            this.mnuOpenDir.Text = "浏览...";
            // 
            // 打开模型目录ToolStripMenuItem
            // 
            this.打开模型目录ToolStripMenuItem.Name = "打开模型目录ToolStripMenuItem";
            this.打开模型目录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开模型目录ToolStripMenuItem.Text = "打开模型目录";
            this.打开模型目录ToolStripMenuItem.Click += new System.EventHandler(this.打开模型目录ToolStripMenuItem_Click);
            // 
            // 打开输出目录ToolStripMenuItem
            // 
            this.打开输出目录ToolStripMenuItem.Name = "打开输出目录ToolStripMenuItem";
            this.打开输出目录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开输出目录ToolStripMenuItem.Text = "打开输出目录";
            this.打开输出目录ToolStripMenuItem.Click += new System.EventHandler(this.打开输出目录ToolStripMenuItem_Click);
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.Controls.Add(this.pageConsole);
            this.tblMain.Controls.Add(this.pageWebView);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 25);
            this.tblMain.Name = "tblMain";
            this.tblMain.SelectedPage = this.pageConsole;
            this.tblMain.Size = new System.Drawing.Size(1360, 767);
            this.tblMain.TabIndex = 1;
            this.tblMain.Text = "multiPaneControl1";
            this.tblMain.SelectedPageChanged += new System.EventHandler(this.tblMain_SelectedPageChanged);
            // 
            // pageConsole
            // 
            this.pageConsole.Controls.Add(this.consoleControl);
            this.pageConsole.Name = "pageConsole";
            this.pageConsole.Size = new System.Drawing.Size(1360, 767);
            this.pageConsole.TabIndex = 0;
            // 
            // consoleControl
            // 
            this.consoleControl.BackColor = System.Drawing.Color.Black;
            this.consoleControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleControl.Location = new System.Drawing.Point(0, 0);
            this.consoleControl.Name = "consoleControl";
            this.consoleControl.Size = new System.Drawing.Size(1360, 767);
            this.consoleControl.TabIndex = 0;
            this.consoleControl.ConsoleExited += new System.EventHandler<System.EventArgs>(this.consoleControl_ConsoleExited);
            // 
            // pageWebView
            // 
            this.pageWebView.Controls.Add(this.webView);
            this.pageWebView.Name = "pageWebView";
            this.pageWebView.Size = new System.Drawing.Size(1360, 767);
            this.pageWebView.TabIndex = 1;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1360, 767);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // checkWebuiWorker
            // 
            this.checkWebuiWorker.WorkerReportsProgress = true;
            this.checkWebuiWorker.WorkerSupportsCancellation = true;
            this.checkWebuiWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkWebuiWorker_DoWork);
            this.checkWebuiWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.checkWebuiWorker_ProgressChanged);
            this.checkWebuiWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkWebuiWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 792);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stable Diffusion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.pageConsole.ResumeLayout(false);
            this.pageWebView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 启动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLaunch;
        private System.Windows.Forms.ToolStripMenuItem mnuSetArgs;
        private System.Windows.Forms.ToolStripMenuItem mnuRelaunch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSwitchConsole;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenDir;
        private System.Windows.Forms.ToolStripMenuItem 打开模型目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开输出目录ToolStripMenuItem;
        private Creek.UI.MultiPanel.MultiPaneControl tblMain;
        private Creek.UI.MultiPanel.MultiPanePage pageConsole;
        private Creek.UI.MultiPanel.MultiPanePage pageWebView;
        private ConsoleControl.ConsoleControl consoleControl;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.ComponentModel.BackgroundWorker checkWebuiWorker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
    }
}

