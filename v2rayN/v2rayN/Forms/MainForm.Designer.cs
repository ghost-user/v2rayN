﻿namespace v2rayN.Forms
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvServers = new v2rayN.Base.ListViewFlickerFree();
            this.cmsLv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAddVmessServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddShadowsocksServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSocksServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddCustomServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddServers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoveServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoveDuplicateServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetDefaultServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTcpingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealPingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpeedServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbTestMe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ClientConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ServerConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ShareUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2SubContent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbServer = new System.Windows.Forms.ToolStripDropDownButton();
            this.qrCodeControl = new v2rayN.Forms.QRCodeControl();
            this.notifyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSysAgentMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotEnabledHttp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGlobal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGlobalPAC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeep = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeepPAC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeepNothing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeepPACNothing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddServers2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanScreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyPACUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateSubscriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwScan = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMsgBox = new System.Windows.Forms.TextBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolSslSocksPortLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslSocksPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslHttpPortLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslHttpPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslPacPortLab = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslPacPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslServerSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSub = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbSubSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSubUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbOptionSetting = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.cmsLv.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            resources.ApplyResources(this.scMain, "scMain");
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lvServers);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.qrCodeControl);
            this.scMain.TabStop = false;
            // 
            // lvServers
            // 
            this.lvServers.ContextMenuStrip = this.cmsLv;
            resources.ApplyResources(this.lvServers, "lvServers");
            this.lvServers.FullRowSelect = true;
            this.lvServers.GridLines = true;
            this.lvServers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvServers.HideSelection = false;
            this.lvServers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvServers.Items")))});
            this.lvServers.MultiSelect = false;
            this.lvServers.Name = "lvServers";
            this.lvServers.UseCompatibleStateImageBehavior = false;
            this.lvServers.View = System.Windows.Forms.View.Details;
            this.lvServers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvServers_ColumnClick);
            this.lvServers.SelectedIndexChanged += new System.EventHandler(this.lvServers_SelectedIndexChanged);
            this.lvServers.Click += new System.EventHandler(this.lvServers_Click);
            this.lvServers.DoubleClick += new System.EventHandler(this.lvServers_DoubleClick);
            this.lvServers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvServers_KeyDown);
            // 
            // cmsLv
            // 
            this.cmsLv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddVmessServer,
            this.menuAddShadowsocksServer,
            this.menuAddSocksServer,
            this.menuAddCustomServer,
            this.menuAddServers,
            this.menuScanScreen,
            this.menuRemoveServer,
            this.menuRemoveDuplicateServer,
            this.menuCopyServer,
            this.menuSetDefaultServer,
            this.menuMoveTop,
            this.menuMoveUp,
            this.menuMoveDown,
            this.menuMoveBottom,
            this.menuSelectAll,
            this.menuPingServer,
            this.menuTcpingServer,
            this.menuRealPingServer,
            this.menuSpeedServer,
            this.tsbTestMe,
            this.menuExport2ClientConfig,
            this.menuExport2ServerConfig,
            this.menuExport2ShareUrl,
            this.menuExport2SubContent});
            this.cmsLv.Name = "cmsLv";
            this.cmsLv.OwnerItem = this.tsbServer;
            resources.ApplyResources(this.cmsLv, "cmsLv");
            // 
            // menuAddVmessServer
            // 
            this.menuAddVmessServer.Name = "menuAddVmessServer";
            resources.ApplyResources(this.menuAddVmessServer, "menuAddVmessServer");
            this.menuAddVmessServer.Click += new System.EventHandler(this.menuAddVmessServer_Click);
            // 
            // menuAddShadowsocksServer
            // 
            this.menuAddShadowsocksServer.Name = "menuAddShadowsocksServer";
            resources.ApplyResources(this.menuAddShadowsocksServer, "menuAddShadowsocksServer");
            this.menuAddShadowsocksServer.Click += new System.EventHandler(this.menuAddShadowsocksServer_Click);
            // 
            // menuAddSocksServer
            // 
            this.menuAddSocksServer.Name = "menuAddSocksServer";
            resources.ApplyResources(this.menuAddSocksServer, "menuAddSocksServer");
            this.menuAddSocksServer.Click += new System.EventHandler(this.menuAddSocksServer_Click);
            // 
            // menuAddCustomServer
            // 
            this.menuAddCustomServer.Name = "menuAddCustomServer";
            resources.ApplyResources(this.menuAddCustomServer, "menuAddCustomServer");
            this.menuAddCustomServer.Click += new System.EventHandler(this.menuAddCustomServer_Click);
            // 
            // menuAddServers
            // 
            this.menuAddServers.Name = "menuAddServers";
            resources.ApplyResources(this.menuAddServers, "menuAddServers");
            this.menuAddServers.Click += new System.EventHandler(this.menuAddServers_Click);
            // 
            // menuScanScreen
            // 
            this.menuScanScreen.Name = "menuScanScreen";
            resources.ApplyResources(this.menuScanScreen, "menuScanScreen");
            this.menuScanScreen.Click += new System.EventHandler(this.menuScanScreen_Click);
            // 
            // menuRemoveServer
            // 
            this.menuRemoveServer.Name = "menuRemoveServer";
            resources.ApplyResources(this.menuRemoveServer, "menuRemoveServer");
            this.menuRemoveServer.Click += new System.EventHandler(this.menuRemoveServer_Click);
            // 
            // menuRemoveDuplicateServer
            // 
            this.menuRemoveDuplicateServer.Name = "menuRemoveDuplicateServer";
            resources.ApplyResources(this.menuRemoveDuplicateServer, "menuRemoveDuplicateServer");
            this.menuRemoveDuplicateServer.Click += new System.EventHandler(this.menuRemoveDuplicateServer_Click);
            // 
            // menuCopyServer
            // 
            this.menuCopyServer.Name = "menuCopyServer";
            resources.ApplyResources(this.menuCopyServer, "menuCopyServer");
            this.menuCopyServer.Click += new System.EventHandler(this.menuCopyServer_Click);
            // 
            // menuSetDefaultServer
            // 
            this.menuSetDefaultServer.Name = "menuSetDefaultServer";
            resources.ApplyResources(this.menuSetDefaultServer, "menuSetDefaultServer");
            this.menuSetDefaultServer.Click += new System.EventHandler(this.menuSetDefaultServer_Click);
            // 
            // menuMoveTop
            // 
            this.menuMoveTop.Name = "menuMoveTop";
            resources.ApplyResources(this.menuMoveTop, "menuMoveTop");
            this.menuMoveTop.Click += new System.EventHandler(this.menuMoveTop_Click);
            // 
            // menuMoveUp
            // 
            this.menuMoveUp.Name = "menuMoveUp";
            resources.ApplyResources(this.menuMoveUp, "menuMoveUp");
            this.menuMoveUp.Click += new System.EventHandler(this.menuMoveUp_Click);
            // 
            // menuMoveDown
            // 
            this.menuMoveDown.Name = "menuMoveDown";
            resources.ApplyResources(this.menuMoveDown, "menuMoveDown");
            this.menuMoveDown.Click += new System.EventHandler(this.menuMoveDown_Click);
            // 
            // menuMoveBottom
            // 
            this.menuMoveBottom.Name = "menuMoveBottom";
            resources.ApplyResources(this.menuMoveBottom, "menuMoveBottom");
            this.menuMoveBottom.Click += new System.EventHandler(this.menuMoveBottom_Click);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.Name = "menuSelectAll";
            resources.ApplyResources(this.menuSelectAll, "menuSelectAll");
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // menuPingServer
            // 
            this.menuPingServer.Name = "menuPingServer";
            resources.ApplyResources(this.menuPingServer, "menuPingServer");
            this.menuPingServer.Click += new System.EventHandler(this.menuPingServer_Click);
            // 
            // menuTcpingServer
            // 
            this.menuTcpingServer.Name = "menuTcpingServer";
            resources.ApplyResources(this.menuTcpingServer, "menuTcpingServer");
            this.menuTcpingServer.Click += new System.EventHandler(this.menuTcpingServer_Click);
            // 
            // menuRealPingServer
            // 
            this.menuRealPingServer.Name = "menuRealPingServer";
            resources.ApplyResources(this.menuRealPingServer, "menuRealPingServer");
            this.menuRealPingServer.Click += new System.EventHandler(this.menuRealPingServer_Click);
            // 
            // menuSpeedServer
            // 
            this.menuSpeedServer.Name = "menuSpeedServer";
            resources.ApplyResources(this.menuSpeedServer, "menuSpeedServer");
            this.menuSpeedServer.Click += new System.EventHandler(this.menuSpeedServer_Click);
            // 
            // tsbTestMe
            // 
            this.tsbTestMe.Name = "tsbTestMe";
            resources.ApplyResources(this.tsbTestMe, "tsbTestMe");
            this.tsbTestMe.Click += new System.EventHandler(this.tsbTestMe_Click);
            // 
            // menuExport2ClientConfig
            // 
            this.menuExport2ClientConfig.Name = "menuExport2ClientConfig";
            resources.ApplyResources(this.menuExport2ClientConfig, "menuExport2ClientConfig");
            this.menuExport2ClientConfig.Click += new System.EventHandler(this.menuExport2ClientConfig_Click);
            // 
            // menuExport2ServerConfig
            // 
            this.menuExport2ServerConfig.Name = "menuExport2ServerConfig";
            resources.ApplyResources(this.menuExport2ServerConfig, "menuExport2ServerConfig");
            this.menuExport2ServerConfig.Click += new System.EventHandler(this.menuExport2ServerConfig_Click);
            // 
            // menuExport2ShareUrl
            // 
            this.menuExport2ShareUrl.Name = "menuExport2ShareUrl";
            resources.ApplyResources(this.menuExport2ShareUrl, "menuExport2ShareUrl");
            this.menuExport2ShareUrl.Click += new System.EventHandler(this.menuExport2ShareUrl_Click);
            // 
            // menuExport2SubContent
            // 
            this.menuExport2SubContent.Name = "menuExport2SubContent";
            resources.ApplyResources(this.menuExport2SubContent, "menuExport2SubContent");
            this.menuExport2SubContent.Click += new System.EventHandler(this.menuExport2SubContent_Click);
            // 
            // tsbServer
            // 
            this.tsbServer.DropDown = this.cmsLv;
            this.tsbServer.Image = global::v2rayN.Properties.Resources.server;
            resources.ApplyResources(this.tsbServer, "tsbServer");
            this.tsbServer.Name = "tsbServer";
            // 
            // qrCodeControl
            // 
            resources.ApplyResources(this.qrCodeControl, "qrCodeControl");
            this.qrCodeControl.Name = "qrCodeControl";
            // 
            // notifyMain
            // 
            this.notifyMain.ContextMenuStrip = this.cmsMain;
            resources.ApplyResources(this.notifyMain, "notifyMain");
            this.notifyMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyMain_MouseClick);
            // 
            // cmsMain
            // 
            resources.ApplyResources(this.cmsMain, "cmsMain");
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSysAgentMode,
            this.menuServers,
            this.menuAddServers2,
            this.menuScanScreen2,
            this.menuCopyPACUrl,
            this.menuUpdateSubscriptions,
            this.menuExit});
            this.cmsMain.Name = "contextMenuStrip1";
            this.cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMain.ShowCheckMargin = true;
            this.cmsMain.ShowImageMargin = false;
            // 
            // menuSysAgentMode
            // 
            this.menuSysAgentMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNotEnabledHttp,
            this.menuGlobal,
            this.menuGlobalPAC,
            this.menuKeep,
            this.menuKeepPAC,
            this.menuKeepNothing,
            this.menuKeepPACNothing});
            this.menuSysAgentMode.Name = "menuSysAgentMode";
            resources.ApplyResources(this.menuSysAgentMode, "menuSysAgentMode");
            // 
            // menuNotEnabledHttp
            // 
            this.menuNotEnabledHttp.Name = "menuNotEnabledHttp";
            resources.ApplyResources(this.menuNotEnabledHttp, "menuNotEnabledHttp");
            this.menuNotEnabledHttp.Click += new System.EventHandler(this.menuNotEnabledHttp_Click);
            // 
            // menuGlobal
            // 
            this.menuGlobal.Name = "menuGlobal";
            resources.ApplyResources(this.menuGlobal, "menuGlobal");
            this.menuGlobal.Click += new System.EventHandler(this.menuGlobal_Click);
            // 
            // menuGlobalPAC
            // 
            this.menuGlobalPAC.Name = "menuGlobalPAC";
            resources.ApplyResources(this.menuGlobalPAC, "menuGlobalPAC");
            this.menuGlobalPAC.Click += new System.EventHandler(this.menuGlobalPAC_Click);
            // 
            // menuKeep
            // 
            this.menuKeep.Name = "menuKeep";
            resources.ApplyResources(this.menuKeep, "menuKeep");
            this.menuKeep.Click += new System.EventHandler(this.menuKeep_Click);
            // 
            // menuKeepPAC
            // 
            this.menuKeepPAC.Name = "menuKeepPAC";
            resources.ApplyResources(this.menuKeepPAC, "menuKeepPAC");
            this.menuKeepPAC.Click += new System.EventHandler(this.menuKeepPAC_Click);
            // 
            // menuKeepNothing
            // 
            this.menuKeepNothing.Name = "menuKeepNothing";
            resources.ApplyResources(this.menuKeepNothing, "menuKeepNothing");
            this.menuKeepNothing.Click += new System.EventHandler(this.menuKeepNothing_Click);
            // 
            // menuKeepPACNothing
            // 
            this.menuKeepPACNothing.Name = "menuKeepPACNothing";
            resources.ApplyResources(this.menuKeepPACNothing, "menuKeepPACNothing");
            this.menuKeepPACNothing.Click += new System.EventHandler(this.menuKeepPACNothing_Click);
            // 
            // menuServers
            // 
            this.menuServers.Name = "menuServers";
            resources.ApplyResources(this.menuServers, "menuServers");
            // 
            // menuAddServers2
            // 
            this.menuAddServers2.Name = "menuAddServers2";
            resources.ApplyResources(this.menuAddServers2, "menuAddServers2");
            this.menuAddServers2.Click += new System.EventHandler(this.menuAddServers_Click);
            // 
            // menuScanScreen2
            // 
            this.menuScanScreen2.Name = "menuScanScreen2";
            resources.ApplyResources(this.menuScanScreen2, "menuScanScreen2");
            this.menuScanScreen2.Click += new System.EventHandler(this.menuScanScreen_Click);
            // 
            // menuCopyPACUrl
            // 
            this.menuCopyPACUrl.Name = "menuCopyPACUrl";
            resources.ApplyResources(this.menuCopyPACUrl, "menuCopyPACUrl");
            this.menuCopyPACUrl.Click += new System.EventHandler(this.menuCopyPACUrl_Click);
            // 
            // menuUpdateSubscriptions
            // 
            this.menuUpdateSubscriptions.Name = "menuUpdateSubscriptions";
            resources.ApplyResources(this.menuUpdateSubscriptions, "menuUpdateSubscriptions");
            this.menuUpdateSubscriptions.Click += new System.EventHandler(this.menuUpdateSubscriptions_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            resources.ApplyResources(this.menuExit, "menuExit");
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // bgwScan
            // 
            this.bgwScan.WorkerReportsProgress = true;
            this.bgwScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
            this.bgwScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwScan_ProgressChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scMain);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMsgBox);
            this.groupBox2.Controls.Add(this.ssMain);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtMsgBox, "txtMsgBox");
            this.txtMsgBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.ReadOnly = true;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSslSocksPortLab,
            this.toolSslSocksPort,
            this.toolSslBlank1,
            this.toolSslHttpPortLab,
            this.toolSslHttpPort,
            this.toolSslBlank2,
            this.toolSslPacPortLab,
            this.toolSslPacPort,
            this.toolSslBlank3,
            this.toolSslServerSpeed,
            this.toolSslBlank4});
            resources.ApplyResources(this.ssMain, "ssMain");
            this.ssMain.Name = "ssMain";
            this.ssMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssMain_ItemClicked);
            // 
            // toolSslSocksPortLab
            // 
            this.toolSslSocksPortLab.Name = "toolSslSocksPortLab";
            resources.ApplyResources(this.toolSslSocksPortLab, "toolSslSocksPortLab");
            // 
            // toolSslSocksPort
            // 
            this.toolSslSocksPort.Name = "toolSslSocksPort";
            resources.ApplyResources(this.toolSslSocksPort, "toolSslSocksPort");
            // 
            // toolSslBlank1
            // 
            this.toolSslBlank1.Name = "toolSslBlank1";
            resources.ApplyResources(this.toolSslBlank1, "toolSslBlank1");
            this.toolSslBlank1.Spring = true;
            // 
            // toolSslHttpPortLab
            // 
            this.toolSslHttpPortLab.Name = "toolSslHttpPortLab";
            resources.ApplyResources(this.toolSslHttpPortLab, "toolSslHttpPortLab");
            // 
            // toolSslHttpPort
            // 
            this.toolSslHttpPort.Name = "toolSslHttpPort";
            resources.ApplyResources(this.toolSslHttpPort, "toolSslHttpPort");
            // 
            // toolSslBlank2
            // 
            this.toolSslBlank2.Name = "toolSslBlank2";
            resources.ApplyResources(this.toolSslBlank2, "toolSslBlank2");
            this.toolSslBlank2.Spring = true;
            // 
            // toolSslPacPortLab
            // 
            this.toolSslPacPortLab.Name = "toolSslPacPortLab";
            resources.ApplyResources(this.toolSslPacPortLab, "toolSslPacPortLab");
            // 
            // toolSslPacPort
            // 
            this.toolSslPacPort.Name = "toolSslPacPort";
            resources.ApplyResources(this.toolSslPacPort, "toolSslPacPort");
            // 
            // toolSslBlank3
            // 
            this.toolSslBlank3.Name = "toolSslBlank3";
            resources.ApplyResources(this.toolSslBlank3, "toolSslBlank3");
            this.toolSslBlank3.Spring = true;
            // 
            // toolSslServerSpeed
            // 
            resources.ApplyResources(this.toolSslServerSpeed, "toolSslServerSpeed");
            this.toolSslServerSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSslServerSpeed.Name = "toolSslServerSpeed";
            // 
            // toolSslBlank4
            // 
            this.toolSslBlank4.Name = "toolSslBlank4";
            resources.ApplyResources(this.toolSslBlank4, "toolSslBlank4");
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbServer,
            this.tsbSub,
            this.tsbOptionSetting});
            resources.ApplyResources(this.tsMain, "tsMain");
            this.tsMain.Name = "tsMain";
            this.tsMain.TabStop = true;
            // 
            // tsbSub
            // 
            this.tsbSub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSubSetting,
            this.tsbSubUpdate});
            this.tsbSub.Image = global::v2rayN.Properties.Resources.sub;
            resources.ApplyResources(this.tsbSub, "tsbSub");
            this.tsbSub.Name = "tsbSub";
            // 
            // tsbSubSetting
            // 
            this.tsbSubSetting.Name = "tsbSubSetting";
            resources.ApplyResources(this.tsbSubSetting, "tsbSubSetting");
            this.tsbSubSetting.Click += new System.EventHandler(this.tsbSubSetting_Click);
            // 
            // tsbSubUpdate
            // 
            this.tsbSubUpdate.Name = "tsbSubUpdate";
            resources.ApplyResources(this.tsbSubUpdate, "tsbSubUpdate");
            this.tsbSubUpdate.Click += new System.EventHandler(this.tsbSubUpdate_Click);
            // 
            // tsbOptionSetting
            // 
            this.tsbOptionSetting.Image = global::v2rayN.Properties.Resources.option;
            resources.ApplyResources(this.tsbOptionSetting, "tsbOptionSetting");
            this.tsbOptionSetting.Name = "tsbOptionSetting";
            this.tsbOptionSetting.Click += new System.EventHandler(this.tsbOptionSetting_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tsMain);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.cmsLv.ResumeLayout(false);
            this.cmsMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMsgBox;
        private v2rayN.Base.ListViewFlickerFree lvServers;
        private System.Windows.Forms.NotifyIcon notifyMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuServers;
        private System.Windows.Forms.ContextMenuStrip cmsLv;
        private System.Windows.Forms.ToolStripMenuItem menuAddVmessServer;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveServer;
        private System.Windows.Forms.ToolStripMenuItem menuSetDefaultServer;
        private System.Windows.Forms.ToolStripMenuItem menuCopyServer;
        private System.Windows.Forms.ToolStripMenuItem menuPingServer;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ClientConfig;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ServerConfig;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsbServer;
        private System.Windows.Forms.ToolStripButton tsbOptionSetting;
        private System.Windows.Forms.ToolStripMenuItem menuMoveTop;
        private System.Windows.Forms.ToolStripMenuItem menuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem menuMoveDown;
        private System.Windows.Forms.ToolStripMenuItem menuMoveBottom;
        private System.Windows.Forms.ToolStripMenuItem menuSysAgentMode;
        private System.Windows.Forms.ToolStripMenuItem menuGlobal;
        private System.Windows.Forms.ToolStripMenuItem menuGlobalPAC;
        private System.Windows.Forms.ToolStripMenuItem menuKeep;
        private System.Windows.Forms.ToolStripMenuItem menuCopyPACUrl;
        private System.Windows.Forms.ToolStripMenuItem menuAddCustomServer;
        private System.Windows.Forms.ToolStripMenuItem menuAddShadowsocksServer;
        private System.Windows.Forms.SplitContainer scMain;
        private QRCodeControl qrCodeControl;
        private System.Windows.Forms.ToolStripMenuItem menuAddServers;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ShareUrl;
        private System.Windows.Forms.ToolStripMenuItem menuSpeedServer;
        private System.Windows.Forms.ToolStripMenuItem menuAddServers2;
        private System.ComponentModel.BackgroundWorker bgwScan;
        private System.Windows.Forms.ToolStripMenuItem menuScanScreen;
        private System.Windows.Forms.ToolStripMenuItem menuScanScreen2;
        private System.Windows.Forms.ToolStripDropDownButton tsbSub;
        private System.Windows.Forms.ToolStripMenuItem tsbSubSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbSubUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuKeepPAC;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuExport2SubContent;
        private System.Windows.Forms.ToolStripMenuItem menuAddSocksServer;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolSslSocksPort;
        private System.Windows.Forms.ToolStripStatusLabel toolSslHttpPort;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank2;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank1;
        private System.Windows.Forms.ToolStripStatusLabel toolSslPacPort;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank3;
        private System.Windows.Forms.ToolStripStatusLabel toolSslSocksPortLab;
        private System.Windows.Forms.ToolStripStatusLabel toolSslHttpPortLab;
        private System.Windows.Forms.ToolStripStatusLabel toolSslPacPortLab;
        private System.Windows.Forms.ToolStripStatusLabel toolSslServerSpeed;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank4;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveDuplicateServer;
        private System.Windows.Forms.ToolStripMenuItem menuTcpingServer;
        private System.Windows.Forms.ToolStripMenuItem menuRealPingServer;
        private System.Windows.Forms.ToolStripMenuItem menuNotEnabledHttp;
        private System.Windows.Forms.ToolStripMenuItem menuUpdateSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem menuKeepNothing;
        private System.Windows.Forms.ToolStripMenuItem menuKeepPACNothing;
        private System.Windows.Forms.ToolStripMenuItem tsbTestMe;
    }
}

