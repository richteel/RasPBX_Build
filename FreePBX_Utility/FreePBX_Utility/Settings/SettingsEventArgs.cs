using System;

namespace FreePBX_Utility.Settings
{
    public enum SettingsEventActions
    {
        Load,
        Save
    };

    public class SettingsEventArgs : EventArgs
    {
        public SettingsEventActions ChangeAction { get; set; }
        public string ActionFrom { get; set; }

        public SettingsEventArgs(SettingsEventActions changeAction, string actionFrom)
        {
            ChangeAction = changeAction;
            ActionFrom = actionFrom;
        }
    }
}
