
namespace FreePBX_Utility
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPgQuickAccess = new System.Windows.Forms.TabPage();
            this.tabPgInboundCalls = new System.Windows.Forms.TabPage();
            this.webPortalIncoming = new FreePBX_Utility.Controls.WebPortal();
            this.tabPgOutboundCalls = new System.Windows.Forms.TabPage();
            this.webPortalOutgoing = new FreePBX_Utility.Controls.WebPortal();
            this.tabPgDirectory = new System.Windows.Forms.TabPage();
            this.webPortalDirectory = new FreePBX_Utility.Controls.WebPortal();
            this.tabPgConfig = new System.Windows.Forms.TabPage();
            this.panConfigurationButtons = new System.Windows.Forms.Panel();
            this.cmdValidateConfig = new System.Windows.Forms.Button();
            this.cmdRevertConfig = new System.Windows.Forms.Button();
            this.cmdSaveConfig = new System.Windows.Forms.Button();
            this.urlCallerId = new FreePBX_Utility.Controls.UrlConfigSetting();
            this.urlDirectory = new FreePBX_Utility.Controls.UrlConfigSetting();
            this.urlOutbound = new FreePBX_Utility.Controls.UrlConfigSetting();
            this.urlInbound = new FreePBX_Utility.Controls.UrlConfigSetting();
            this.urlFreePbx = new FreePBX_Utility.Controls.UrlConfigSetting();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPgInboundCalls.SuspendLayout();
            this.tabPgOutboundCalls.SuspendLayout();
            this.tabPgDirectory.SuspendLayout();
            this.tabPgConfig.SuspendLayout();
            this.panConfigurationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.HelpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.Text = "Status";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPgQuickAccess);
            this.tabControl1.Controls.Add(this.tabPgInboundCalls);
            this.tabControl1.Controls.Add(this.tabPgOutboundCalls);
            this.tabControl1.Controls.Add(this.tabPgDirectory);
            this.tabControl1.Controls.Add(this.tabPgConfig);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 500);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPgQuickAccess
            // 
            this.tabPgQuickAccess.Location = new System.Drawing.Point(4, 25);
            this.tabPgQuickAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPgQuickAccess.Name = "tabPgQuickAccess";
            this.tabPgQuickAccess.Size = new System.Drawing.Size(1059, 471);
            this.tabPgQuickAccess.TabIndex = 0;
            this.tabPgQuickAccess.Text = "Quick Access";
            this.tabPgQuickAccess.UseVisualStyleBackColor = true;
            // 
            // tabPgInboundCalls
            // 
            this.tabPgInboundCalls.Controls.Add(this.webPortalIncoming);
            this.tabPgInboundCalls.Location = new System.Drawing.Point(4, 25);
            this.tabPgInboundCalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPgInboundCalls.Name = "tabPgInboundCalls";
            this.tabPgInboundCalls.Size = new System.Drawing.Size(1059, 468);
            this.tabPgInboundCalls.TabIndex = 1;
            this.tabPgInboundCalls.Text = "Inbound Calls";
            this.tabPgInboundCalls.UseVisualStyleBackColor = true;
            // 
            // webPortalIncoming
            // 
            this.webPortalIncoming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPortalIncoming.LastRefreshed = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.webPortalIncoming.Location = new System.Drawing.Point(0, 0);
            this.webPortalIncoming.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.webPortalIncoming.Name = "webPortalIncoming";
            this.webPortalIncoming.Size = new System.Drawing.Size(1059, 468);
            this.webPortalIncoming.StatusText = "Not Loaded";
            this.webPortalIncoming.TabIndex = 0;
            this.webPortalIncoming.Title = "Incoming Calls - Most Recent First";
            this.webPortalIncoming.Url = null;
            // 
            // tabPgOutboundCalls
            // 
            this.tabPgOutboundCalls.Controls.Add(this.webPortalOutgoing);
            this.tabPgOutboundCalls.Location = new System.Drawing.Point(4, 25);
            this.tabPgOutboundCalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPgOutboundCalls.Name = "tabPgOutboundCalls";
            this.tabPgOutboundCalls.Size = new System.Drawing.Size(1059, 468);
            this.tabPgOutboundCalls.TabIndex = 2;
            this.tabPgOutboundCalls.Text = "Outgoing Calls";
            this.tabPgOutboundCalls.UseVisualStyleBackColor = true;
            // 
            // webPortalOutgoing
            // 
            this.webPortalOutgoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPortalOutgoing.LastRefreshed = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.webPortalOutgoing.Location = new System.Drawing.Point(0, 0);
            this.webPortalOutgoing.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.webPortalOutgoing.Name = "webPortalOutgoing";
            this.webPortalOutgoing.Size = new System.Drawing.Size(1059, 468);
            this.webPortalOutgoing.StatusText = "Not Loaded";
            this.webPortalOutgoing.TabIndex = 0;
            this.webPortalOutgoing.Title = "Outgoing Calls - Most Recent First";
            this.webPortalOutgoing.Url = null;
            // 
            // tabPgDirectory
            // 
            this.tabPgDirectory.Controls.Add(this.webPortalDirectory);
            this.tabPgDirectory.Location = new System.Drawing.Point(4, 25);
            this.tabPgDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPgDirectory.Name = "tabPgDirectory";
            this.tabPgDirectory.Size = new System.Drawing.Size(1059, 468);
            this.tabPgDirectory.TabIndex = 3;
            this.tabPgDirectory.Text = "Directory";
            this.tabPgDirectory.UseVisualStyleBackColor = true;
            // 
            // webPortalDirectory
            // 
            this.webPortalDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPortalDirectory.LastRefreshed = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.webPortalDirectory.Location = new System.Drawing.Point(0, 0);
            this.webPortalDirectory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.webPortalDirectory.Name = "webPortalDirectory";
            this.webPortalDirectory.Size = new System.Drawing.Size(1059, 468);
            this.webPortalDirectory.StatusText = "Not Loaded";
            this.webPortalDirectory.TabIndex = 0;
            this.webPortalDirectory.Title = "Cisco Directory (XML)";
            this.webPortalDirectory.Url = null;
            // 
            // tabPgConfig
            // 
            this.tabPgConfig.Controls.Add(this.panConfigurationButtons);
            this.tabPgConfig.Controls.Add(this.urlCallerId);
            this.tabPgConfig.Controls.Add(this.urlDirectory);
            this.tabPgConfig.Controls.Add(this.urlOutbound);
            this.tabPgConfig.Controls.Add(this.urlInbound);
            this.tabPgConfig.Controls.Add(this.urlFreePbx);
            this.tabPgConfig.Location = new System.Drawing.Point(4, 25);
            this.tabPgConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPgConfig.Name = "tabPgConfig";
            this.tabPgConfig.Size = new System.Drawing.Size(1059, 471);
            this.tabPgConfig.TabIndex = 4;
            this.tabPgConfig.Text = "Configuration";
            this.tabPgConfig.UseVisualStyleBackColor = true;
            // 
            // panConfigurationButtons
            // 
            this.panConfigurationButtons.Controls.Add(this.cmdValidateConfig);
            this.panConfigurationButtons.Controls.Add(this.cmdRevertConfig);
            this.panConfigurationButtons.Controls.Add(this.cmdSaveConfig);
            this.panConfigurationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panConfigurationButtons.Location = new System.Drawing.Point(0, 348);
            this.panConfigurationButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panConfigurationButtons.Name = "panConfigurationButtons";
            this.panConfigurationButtons.Size = new System.Drawing.Size(1059, 123);
            this.panConfigurationButtons.TabIndex = 5;
            // 
            // cmdValidateConfig
            // 
            this.cmdValidateConfig.Location = new System.Drawing.Point(312, 91);
            this.cmdValidateConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdValidateConfig.Name = "cmdValidateConfig";
            this.cmdValidateConfig.Size = new System.Drawing.Size(100, 28);
            this.cmdValidateConfig.TabIndex = 2;
            this.cmdValidateConfig.Text = "Check URLs";
            this.toolTip1.SetToolTip(this.cmdValidateConfig, "Check that the Settings are valid");
            this.cmdValidateConfig.UseVisualStyleBackColor = true;
            this.cmdValidateConfig.Click += new System.EventHandler(this.CmdValidateConfig_Click);
            // 
            // cmdRevertConfig
            // 
            this.cmdRevertConfig.Location = new System.Drawing.Point(164, 91);
            this.cmdRevertConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdRevertConfig.Name = "cmdRevertConfig";
            this.cmdRevertConfig.Size = new System.Drawing.Size(100, 28);
            this.cmdRevertConfig.TabIndex = 1;
            this.cmdRevertConfig.Text = "Revert";
            this.toolTip1.SetToolTip(this.cmdRevertConfig, "Revert to Saved Settings");
            this.cmdRevertConfig.UseVisualStyleBackColor = true;
            this.cmdRevertConfig.Click += new System.EventHandler(this.CmdRevertConfig_Click);
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.Location = new System.Drawing.Point(15, 91);
            this.cmdSaveConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Size = new System.Drawing.Size(100, 28);
            this.cmdSaveConfig.TabIndex = 0;
            this.cmdSaveConfig.Text = "Save";
            this.toolTip1.SetToolTip(this.cmdSaveConfig, "Save Current Settings");
            this.cmdSaveConfig.UseVisualStyleBackColor = true;
            this.cmdSaveConfig.Click += new System.EventHandler(this.CmdSaveConfig_Click);
            // 
            // urlCallerId
            // 
            this.urlCallerId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlCallerId.BaseUrl = null;
            this.urlCallerId.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlCallerId.Location = new System.Drawing.Point(0, 148);
            this.urlCallerId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.urlCallerId.Name = "urlCallerId";
            this.urlCallerId.SettingKey = null;
            this.urlCallerId.ShowValidateButton = false;
            this.urlCallerId.Size = new System.Drawing.Size(1059, 37);
            this.urlCallerId.TabIndex = 4;
            this.urlCallerId.Title = "CallerId URL:";
            this.urlCallerId.ToolTip = "Enter the URL for the CallerId page.\r\nThe URL may relative to the FreePBX URL\r\n\r\n" +
    "Default Value: /utility/callerid.php?format=text&inc_headers=no\r\n";
            this.urlCallerId.Url = "";
            this.urlCallerId.ValueChanged += new System.EventHandler<System.EventArgs>(this.Url_ValueChanged);
            // 
            // urlDirectory
            // 
            this.urlDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlDirectory.BaseUrl = null;
            this.urlDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlDirectory.Location = new System.Drawing.Point(0, 111);
            this.urlDirectory.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.urlDirectory.Name = "urlDirectory";
            this.urlDirectory.SettingKey = null;
            this.urlDirectory.ShowValidateButton = false;
            this.urlDirectory.Size = new System.Drawing.Size(1059, 37);
            this.urlDirectory.TabIndex = 3;
            this.urlDirectory.Title = "Directory URL:";
            this.urlDirectory.ToolTip = "Enter the URL for the Directory page.\r\nThe URL may relative to the FreePBX URL\r\n\r" +
    "\nDefault Value: /cisco/directory/\r\n";
            this.urlDirectory.Url = "";
            this.urlDirectory.ValueChanged += new System.EventHandler<System.EventArgs>(this.Url_ValueChanged);
            // 
            // urlOutbound
            // 
            this.urlOutbound.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlOutbound.BaseUrl = null;
            this.urlOutbound.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlOutbound.Location = new System.Drawing.Point(0, 74);
            this.urlOutbound.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.urlOutbound.Name = "urlOutbound";
            this.urlOutbound.SettingKey = null;
            this.urlOutbound.ShowValidateButton = false;
            this.urlOutbound.Size = new System.Drawing.Size(1059, 37);
            this.urlOutbound.TabIndex = 2;
            this.urlOutbound.Title = "Outbound Calls URL:";
            this.urlOutbound.ToolTip = "Enter the URL for the outgoing Calls page.\r\nThe URL may relative to the FreePBX U" +
    "RL\r\n\r\nDefault Value: /utility/outbound.php\r\n";
            this.urlOutbound.Url = "";
            this.urlOutbound.ValueChanged += new System.EventHandler<System.EventArgs>(this.Url_ValueChanged);
            // 
            // urlInbound
            // 
            this.urlInbound.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlInbound.BaseUrl = null;
            this.urlInbound.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlInbound.Location = new System.Drawing.Point(0, 37);
            this.urlInbound.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.urlInbound.Name = "urlInbound";
            this.urlInbound.SettingKey = null;
            this.urlInbound.ShowValidateButton = false;
            this.urlInbound.Size = new System.Drawing.Size(1059, 37);
            this.urlInbound.TabIndex = 1;
            this.urlInbound.Title = "Inbound Calls URL:";
            this.urlInbound.ToolTip = "Enter the URL for the Incoming Calls page.\r\nThe URL may relative to the FreePBX U" +
    "RL\r\n\r\nDefault Value: /utility/inbound.php\r\n";
            this.urlInbound.Url = "";
            this.urlInbound.ValueChanged += new System.EventHandler<System.EventArgs>(this.Url_ValueChanged);
            // 
            // urlFreePbx
            // 
            this.urlFreePbx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlFreePbx.BaseUrl = null;
            this.urlFreePbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.urlFreePbx.Location = new System.Drawing.Point(0, 0);
            this.urlFreePbx.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.urlFreePbx.Name = "urlFreePbx";
            this.urlFreePbx.SettingKey = null;
            this.urlFreePbx.ShowValidateButton = false;
            this.urlFreePbx.Size = new System.Drawing.Size(1059, 37);
            this.urlFreePbx.TabIndex = 0;
            this.urlFreePbx.Title = "FreePBX URL:";
            this.urlFreePbx.ToolTip = "Enter the URL for your FreePBX installation in the form of http://<IP Address>/\r\n" +
    "Default is NONE";
            this.urlFreePbx.Url = "";
            this.urlFreePbx.ValueChanged += new System.EventHandler<System.EventArgs>(this.UrlFreePbx_ValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "FreePBX Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPgInboundCalls.ResumeLayout(false);
            this.tabPgOutboundCalls.ResumeLayout(false);
            this.tabPgDirectory.ResumeLayout(false);
            this.tabPgConfig.ResumeLayout(false);
            this.panConfigurationButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPgQuickAccess;
        private System.Windows.Forms.TabPage tabPgInboundCalls;
        private System.Windows.Forms.TabPage tabPgOutboundCalls;
        private System.Windows.Forms.TabPage tabPgDirectory;
        private System.Windows.Forms.TabPage tabPgConfig;
        private Controls.WebPortal webPortalIncoming;
        private Controls.WebPortal webPortalOutgoing;
        private Controls.WebPortal webPortalDirectory;
        private Controls.UrlConfigSetting urlDirectory;
        private Controls.UrlConfigSetting urlOutbound;
        private Controls.UrlConfigSetting urlInbound;
        private Controls.UrlConfigSetting urlFreePbx;
        private Controls.UrlConfigSetting urlCallerId;
        private System.Windows.Forms.Panel panConfigurationButtons;
        private System.Windows.Forms.Button cmdRevertConfig;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdSaveConfig;
        private System.Windows.Forms.Button cmdValidateConfig;
        private System.Windows.Forms.Timer timer1;
    }
}

