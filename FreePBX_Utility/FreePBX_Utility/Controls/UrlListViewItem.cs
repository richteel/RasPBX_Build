using System.Windows.Forms;

namespace FreePBX_Utility.Controls
{
    public enum UrlListViewItemLocations
    {
        LocalFile = 0,
        Resource = 1,
        Web = 2
    };

    public class UrlListViewItem : ListViewItem
    {
        public string Location { get; set; }

        public UrlListViewItemLocations LocationType { get; set; }

        public UrlListViewItem(string location, UrlListViewItemLocations locationType, string displayText)
        {
            Location = location;
            LocationType = locationType;
            Text = displayText;
        }
    }
}
