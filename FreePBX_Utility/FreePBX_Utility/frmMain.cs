using FreePBX_Utility.Controls;
using FreePBX_Utility.Settings;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FreePBX_Utility
{
    public enum Tabs
    {
        QuickAccess = 0,
        InboundCalls = 1,
        OutboundCalls = 2,
        Directory = 3,
        Configuration = 4
    };

    public partial class FrmMain : Form
    {
        /*** Fields and Constants ***/
        #region
        private Settings.Settings configSettings;
        private const string CALLINGREF = "frmMain";
        private AboutBox1 aboutBox;
        #endregion

        /*** Properties ***/
        #region
        public Settings.Settings ConfigSettings
        {
            get { return configSettings; }
            set
            {
                configSettings = value;

                if (configSettings != null)
                {
                    UpdateFromSettings();
                }
            }
        }

        public string Status
        {
            set { lblStatus.Text = string.Format("Status: {0} ({1:h:mm:ss.fff tt})", value, DateTime.Now); }
            get { return lblStatus.Text; }
        }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        /*** Public Events ***/
        #region
        public event EventHandler<EventArgs> ExitRequested;

        protected void FrmMain_ExitRequested(object sender, EventArgs e)
        {
            ExitRequested?.Invoke(sender, e);
        }
        #endregion

        /*** Public Methods ***/
        #region
        public void OpenTab(Tabs tab)
        {
            tabControl1.SelectedIndex = (int)tab;
        }
        #endregion

        /*** Protected Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        private void LayoutButtons()
        {
            cmdRevertConfig.Top = (panConfigurationButtons.Height - cmdRevertConfig.Height) / 2;
            cmdRevertConfig.Left = (panConfigurationButtons.Width - cmdRevertConfig.Width) / 2;
            cmdSaveConfig.Top = cmdValidateConfig.Top = cmdRevertConfig.Top;
            cmdSaveConfig.Left = cmdRevertConfig.Left - cmdSaveConfig.Width - 10;
            cmdValidateConfig.Left = cmdRevertConfig.Left + cmdRevertConfig.Width + 10;
        }

        private void UpdateFromSettings()
        {
            urlFreePbx.Url = configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.FREEPBX_URL].Url;
            urlInbound.Url = configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.INBOUND_URL].Url;
            urlOutbound.Url = configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.OUTBOUND_URL].Url;
            urlDirectory.Url = configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.DIRECTORY_URL].Url;
            urlCallerId.Url = configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.CALLERID_URL].Url;
            UrlFreePbx_ValueChanged(null, new EventArgs());

            webPortalIncoming.NavigateTo(urlInbound.UrlComplete);
            webPortalOutgoing.NavigateTo(urlOutbound.UrlComplete);
            webPortalDirectory.NavigateTo(urlDirectory.UrlComplete);
        }
        #endregion

        /*** Event Handlers ***/
        #region
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutBox == null || aboutBox.IsDisposed)
            {
                aboutBox = new AboutBox1();
            }

            // If we are already showing the window, merely focus it.
            if (aboutBox.Visible)
            {
                aboutBox.Activate();
            }
            else
            {
                aboutBox.ShowDialog();
            }
        }

        private void CmdRevertConfig_Click(object sender, EventArgs e)
        {
            UpdateFromSettings();
        }

        private void CmdSaveConfig_Click(object sender, EventArgs e)
        {
            configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.FREEPBX_URL].Url = urlFreePbx.Url;
            configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.INBOUND_URL].Url = urlInbound.Url;
            configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.OUTBOUND_URL].Url = urlOutbound.Url;
            configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.DIRECTORY_URL].Url = urlDirectory.Url;
            configSettings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.CALLERID_URL].Url = urlCallerId.Url;

            configSettings.SaveSettings(CALLINGREF);
        }

        private void CmdValidateConfig_Click(object sender, EventArgs e)
        {
            string validationMessages = "";

            foreach (Control ctrl in Enumerable.Reverse(tabPgConfig.Controls.OfType<UrlConfigSetting>()))
            {
                UrlConfigSetting urlCtrl = (UrlConfigSetting)ctrl;
                urlCtrl.Validate();
                if (!urlCtrl.IsUrlValid)
                {
                    if (validationMessages.Length > 0)
                        validationMessages += "\r\n\r\n";

                    validationMessages += string.Format("{0} {1}", urlCtrl.Title, urlCtrl.ValidationMessage.Replace("\t", " - "));
                }
            }

            if (validationMessages.Length > 0)
            {
                MessageBox.Show(this, "Validation failed with the following:\r\n\r\n" + validationMessages, "Validation Summary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(this, "Completed", "Validation Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMain_ExitRequested(this, e);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LayoutButtons();
            UpdateFromSettings();
            timer1.Start();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            LayoutButtons();
        }

        private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OnHelpRequested(new HelpEventArgs(new Point(0, 0)));
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (this.Visible)
            {
                if (!string.IsNullOrEmpty(webPortalIncoming.Url))
                    webPortalIncoming.Refresh();

                if (!string.IsNullOrEmpty(webPortalOutgoing.Url))
                    webPortalOutgoing.Refresh();

                if (!string.IsNullOrEmpty(webPortalDirectory.Url))
                    webPortalDirectory.Refresh();
            }


            timer1.Start();
        }

        private void Url_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UrlFreePbx_ValueChanged(object sender, EventArgs e)
        {
            urlInbound.BaseUrl = urlFreePbx.Url;
            urlOutbound.BaseUrl = urlFreePbx.Url;
            urlDirectory.BaseUrl = urlFreePbx.Url;
            urlCallerId.BaseUrl = urlFreePbx.Url;

            Url_ValueChanged(sender, e);
        }
        #endregion
    }
}
