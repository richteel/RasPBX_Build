using System;
using System.Collections.Generic;


namespace FreePBX_Utility.Settings
{
    public class Settings
    {
        /*** Fields ***/
        #region
        private const string CALLINGREF = "Self";

        private readonly SettingsHelper settingsHelper;
        private AppSettings m_ApplicationSettings;
        #endregion

        /*** Properties ***/
        #region
        public AppSettings ApplicationSettings
        {
            get { return m_ApplicationSettings; }
            set { m_ApplicationSettings = value; }
        }
        #endregion

        /*** Constructor ***/
        #region
        public Settings()
        {
            settingsHelper = new SettingsHelper(SettingFileTypes.User);

            m_ApplicationSettings = new AppSettings
            {
                QuickLaunch_Setting_Dict = new Dictionary<string, Controls.QuickLaunch_Setting>(),
                UrlConfigSetting_Setting_Dict = new Dictionary<string, Controls.UrlConfigSetting_Setting>()
            };

            // Assign default values
            m_ApplicationSettings.UrlConfigSetting_Setting_Dict.Add(SettingKeys.FREEPBX_URL, new Controls.UrlConfigSetting_Setting()
            {
                Key = SettingKeys.FREEPBX_URL,
                Title = "FreePBX URL:",
                Url = ""
            });
            m_ApplicationSettings.UrlConfigSetting_Setting_Dict.Add(SettingKeys.INBOUND_URL, new Controls.UrlConfigSetting_Setting()
            {
                Key = SettingKeys.INBOUND_URL,
                Title = "Inbound Calls URL:",
                Url = "/utility/inbound.php"
            });
            m_ApplicationSettings.UrlConfigSetting_Setting_Dict.Add(SettingKeys.OUTBOUND_URL, new Controls.UrlConfigSetting_Setting()
            {
                Key = SettingKeys.OUTBOUND_URL,
                Title = "Outbound Calls URL:",
                Url = "/utility/outbound.php"
            });
            m_ApplicationSettings.UrlConfigSetting_Setting_Dict.Add(SettingKeys.DIRECTORY_URL, new Controls.UrlConfigSetting_Setting()
            {
                Key = SettingKeys.DIRECTORY_URL,
                Title = "Directory URL:",
                Url = "/cisco/directory/"
            });
            m_ApplicationSettings.UrlConfigSetting_Setting_Dict.Add(SettingKeys.CALLERID_URL, new Controls.UrlConfigSetting_Setting()
            {
                Key = SettingKeys.CALLERID_URL,
                Title = "CallerId URL:",
                Url = "/utility/callerid.php?format=text&inc_headers=no"
            });

            // If there is a config file, overwrite the values with the contents of the config file
            // If the config file does not exist, the dbSettings object is not created so create it
            if (!LoadSettings(CALLINGREF))
            {
                SaveSettings(CALLINGREF);
            }
        }
        #endregion

        /*** Public Events ***/
        #region
        public event EventHandler<SettingsEventArgs> Changed;

        public void Setting_Changed(object sender, SettingsEventArgs e)
        {
            Changed?.Invoke(sender, e);
        }
        #endregion

        /*** Public Methods ***/
        #region
        // Creates the dbSettings object if the config file exists and assigns properties from config file
        public bool LoadSettings(string callingRef)
        {
            AppSettings tempSettings = (AppSettings)settingsHelper.LoadSettings(typeof(AppSettings));

            if (tempSettings == null)
            {
                return false;
            }

            m_ApplicationSettings.QuickLaunch_Setting_Dict = tempSettings.QuickLaunch_Setting_Dict;
            m_ApplicationSettings.UrlConfigSetting_Setting_Dict = tempSettings.UrlConfigSetting_Setting_Dict;

            Setting_Changed(this, new SettingsEventArgs(SettingsEventActions.Load, callingRef));

            return true;
        }

        // Saves the properties to the config file
        public bool SaveSettings(string callingRef)
        {
            if (m_ApplicationSettings == null)
            {
                return false;
            }

            try
            {
                settingsHelper.SaveSettings(m_ApplicationSettings);

                Setting_Changed(this, new SettingsEventArgs(SettingsEventActions.Save, callingRef));

                return true;
            }
            catch (System.Runtime.Serialization.SerializationException e)
            {
                System.Windows.Forms.MessageBox.Show("Error loading configuration file. Default values will be used.\n\n" + e.Message);
                // Most likely, the configuraton properties have changed so delete the configuration files
                settingsHelper.DeleteSettingsFile();
                return false;
            }
        }
        #endregion

        /*** Event Handlers ***/
        #region
        #endregion

        /*** Protected Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        #endregion
    }
}
