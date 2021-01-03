namespace FreePBX_Utility.Controls
{
    public class UrlConfigSetting_Setting
    {
        /*** Properties ***/
        #region
        public string Key { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public UrlConfigSetting_Setting()
        {
            // Default Values
            Key = "UrlConfigSetting_Setting";
            Title = "";
            Url = "";
        }
        #endregion
    }
}
