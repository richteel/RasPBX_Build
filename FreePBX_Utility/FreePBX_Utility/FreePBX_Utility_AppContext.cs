using System;
using System.Windows.Forms;
using FreePBX_Utility.CallerId;
using FreePBX_Utility.Controls;
using FreePBX_Utility.Settings;

namespace FreePBX_Utility
{
    public class FreePBX_Utility_AppContext : ApplicationContext
    {
        /*** Fields and Constants ***/
        #region
        private const string CALLINGREF = "ApplicationContext";

        readonly frmMain configWindow;
        readonly NotifyIcon notifyIcon;
        readonly Timer updateTimer;
        readonly CallerIdUpdater callerIdUpdater;
        private CallerIdResult previousResult;
        private readonly Settings.Settings settings;
        bool callerId_Initialized = false;
        string callerIdUrl = "";
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public FreePBX_Utility_AppContext()
        {
            settings = new Settings.Settings();
            settings.LoadSettings(CALLINGREF);

            UpdateFromSettings();

            settings.Changed += Settings_OnChanged;

            if (settings == null)
            {
                settings = new Settings.Settings();
            }

            updateTimer = new Timer();
            previousResult = new CallerIdResult();

            updateTimer.Interval = 1000;
            updateTimer.Tick += UpdateTimer_Tick;
            configWindow = new frmMain();
            configWindow.Status = "Not Connected";
            configWindow.ExitRequested += Exit;
            configWindow.ConfigSettings = settings;

            MenuItem quickAccessMenuItem = new MenuItem("Quick Access", new EventHandler(ShowQuickAccessg));
            MenuItem inboundMenuItem = new MenuItem("Inbound Calls", new EventHandler(ShowInbound));
            MenuItem outboundMenuItem = new MenuItem("Outbound Calls", new EventHandler(ShowOutbound));
            MenuItem directoryMenuItem = new MenuItem("Directory", new EventHandler(ShowDirectory));
            MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon = new NotifyIcon
            {
                Icon = FreePBX_Utility.Properties.Resources.Cisco7941G_icon,
                ContextMenu = new ContextMenu(new MenuItem[]
                { 
                    quickAccessMenuItem,
                    inboundMenuItem,
                    outboundMenuItem,
                    directoryMenuItem,
                    configMenuItem, 
                    exitMenuItem 
                })
            };

            notifyIcon.BalloonTipClicked += NotifyIcon_BalloonTipClicked;
            notifyIcon.Visible = true;

            callerIdUpdater = new CallerIdUpdater();

            callerIdUpdater.Updated += CallerId_Updated;
            updateTimer.Start();
        }
        #endregion

        /*** Private Methods ***/
        #region
        private void UpdateFromSettings()
        {
            string freePbxUrl = ((UrlConfigSetting_Setting)settings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.FREEPBX_URL]).Url;
            callerIdUrl = ((UrlConfigSetting_Setting)settings.ApplicationSettings.UrlConfigSetting_Setting_Dict[SettingKeys.CALLERID_URL]).Url;

            if (!callerIdUrl.StartsWith("http"))
            {
                callerIdUrl = Web.WebHelper.UrlCombine(freePbxUrl, callerIdUrl);
            }

            if (!callerIdUrl.StartsWith("http"))
            {
                callerIdUrl = "";

            }
        }
        #endregion

        /*** Event Handlers ***/
        #region
        private void CallerId_Updated(object sender, EventArgs e)
        {
            CallerIdResult currentResult = callerIdUpdater.LastCall;

            if (currentResult != null)
            {
                configWindow.Status = "Updated";

                if (previousResult.CallStart != currentResult.CallStart)
                {
                    if (callerId_Initialized)
                    {
                        string messageText = string.Format("Date Time: {0}\nCaller: {1}\nNumber: {2}",
                            currentResult.CallStart, currentResult.Caller, currentResult.Number);

                        notifyIcon.ShowBalloonTip(10000, "New Call", messageText, ToolTipIcon.Info);
                    }

                    previousResult = currentResult;
                    callerId_Initialized = true;
                }
            }
            else
            {
                configWindow.Status = "Update Failed";
            }

            updateTimer.Enabled = true;
        }

        private void Exit(object sender, EventArgs e)
        {
            settings.SaveSettings(CALLINGREF);

            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Yep, you had to click me!\r\n\r\n" + notifyIcon.Text);
        }

        private void Settings_OnChanged(object sender, SettingsEventArgs e)
        {
            if(e.ActionFrom != CALLINGREF && e.ChangeAction == SettingsEventActions.Save)
            {
                UpdateFromSettings();
            }
        }

        private void ShowQuickAccessg(object sender, EventArgs e)
        {
            ShowMain(Tabs.QuickAccess);
        }

        private void ShowInbound(object sender, EventArgs e)
        {
            ShowMain(Tabs.InboundCalls);
        }

        private void ShowOutbound(object sender, EventArgs e)
        {
            ShowMain(Tabs.OutboundCalls);
        }

        private void ShowDirectory(object sender, EventArgs e)
        {
            ShowMain(Tabs.Directory);
        }

        private void ShowConfig(object sender, EventArgs e)
        {
            ShowMain(Tabs.Configuration);
        }

        private void ShowMain(Tabs tab)
        {
            configWindow.OpenTab(tab);

            // If we are already showing the window, merely focus it.
            if (configWindow.Visible)
            {
                configWindow.Activate();
            }
            else
            {
                configWindow.Show();
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            updateTimer.Enabled = false;

            configWindow.Status = "Updating";

            callerIdUpdater.SourceUrl = callerIdUrl;

            callerIdUpdater.Update();
        }
        #endregion
    }
}