using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using FreePBX_Utility.Controls;

namespace FreePBX_Utility.Settings
{
    [Serializable]
    public class AppSettings
    {
        /*** Fields and Constants ***/
        #region
        const string CURRENTVERSION = "1.0.0.0";

        [OptionalField(VersionAdded = 1)]
        private Dictionary<string, QuickLaunch_Setting> m_QuickLaunch_Setting_Dict = null;

        [OptionalField(VersionAdded = 1)]
        private Dictionary<string, UrlConfigSetting_Setting> m_UrlConfigSetting_Setting_Dict = null;
        #endregion

        /*** Properties ***/
        #region
        public Dictionary<string, QuickLaunch_Setting> QuickLaunch_Setting_Dict
        {
            get { return m_QuickLaunch_Setting_Dict; }
            set { m_QuickLaunch_Setting_Dict = value; }
        }

        public Dictionary<string, UrlConfigSetting_Setting> UrlConfigSetting_Setting_Dict
        {
            get { return m_UrlConfigSetting_Setting_Dict; }
            set { m_UrlConfigSetting_Setting_Dict = value; }
        }

        public string SettingsVersion { get; set; }
        #endregion

        /*** Constructor ***/
        #region
        public AppSettings()
        {
            SettingsVersion = CURRENTVERSION;
        }
        #endregion
    }
}