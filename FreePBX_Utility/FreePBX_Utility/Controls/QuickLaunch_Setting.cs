namespace FreePBX_Utility.Controls
{
    public class QuickLaunch_Setting
    {
        /*** Properties ***/
        #region
        public string Description { get; set; }

        public string Key { get; set; }

        public string ImageFileName { get; set; }

        public string Title { get; set; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public QuickLaunch_Setting()
        {
            // Default Values
            Description = "";
            Key = "QuickLaunch_Setting";
            ImageFileName = "unknown.png";
            Title = "";
        }
        #endregion
    }
}
