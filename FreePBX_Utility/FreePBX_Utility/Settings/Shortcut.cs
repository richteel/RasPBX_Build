using System;

namespace FreePBX_Utility.Settings
{
    [Serializable]
    public class Shortcut
    {
        /*** Fields and Constants ***/
        #region
        #endregion

        /*** Properties ***/
        #region
        public string Description { get; set; }

        public string Key { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public string URL { get; set; }
        #endregion
    }
}
