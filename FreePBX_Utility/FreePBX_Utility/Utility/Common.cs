using System;
using System.Windows.Forms;

namespace FreePBX_Utility.Utility
{
    public static class Common
    {
        /*** Constants and Fields ***/
        #region
        public static DateTime NULL_DATE = DateTime.Parse("1/1/1753 12:00:00 AM");
        #endregion

        /*** Public Methods ***/
        #region
        public static string AppendLineToString(string toAddTo, string textToAdd)
        {
            string retval = toAddTo;

            if (!string.IsNullOrEmpty(retval))
                retval += "\n";

            retval += textToAdd;

            return retval;
        }

        private static string BytesToString(long filebytes)
        {
            string retVal = string.Empty;

            if (filebytes > (long)1E+12)
            {
                retVal = (Math.Floor(filebytes / (decimal)1E+10) / 100).ToString("N2") + " TB";
            }
            else if (filebytes > (long)1E+9)
            {
                retVal = (Math.Floor(filebytes / (decimal)1E+7) / 100).ToString("N2") + " GB";
            }
            else if (filebytes > (long)1E+6)
            {
                retVal = (Math.Floor(filebytes / (decimal)1E+4) / 100).ToString("N2") + " MB";
            }
            else if (filebytes > (long)1E+3)
            {
                retVal = (Math.Floor(filebytes / (decimal)1E+1) / 100).ToString("N2") + " KB";
            }
            else
            {
                retVal = filebytes.ToString() + " Bytes";
            }

            return retVal;
        }

        public static void MoveItemInListBox(ListBox lstBox, int FromIndex, int ToIndex)
        {
            // Put item at end of list
            object tmpItem0 = lstBox.Items[FromIndex];
            lstBox.Items.RemoveAt(FromIndex);
            lstBox.Items.Add(tmpItem0);

            // Move down to final location
            for (int i = lstBox.Items.Count - 1; i > ToIndex; i--)
            {
                object tmpItem = lstBox.Items[ToIndex];
                lstBox.Items.RemoveAt(ToIndex);
                lstBox.Items.Add(tmpItem);
            }

            lstBox.SelectedIndex = ToIndex;
        }
        #endregion
    }
}
