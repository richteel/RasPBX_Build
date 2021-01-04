using FreePBX_Utility.Controls;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FreePBX_Utility
{
    public partial class FrmHelp : Form
    {
        /*** Fields and Constants ***/
        #region
        private string rootLocation = "";
        bool webViewReady = false;
        string _url = "";
        #endregion

        /*** Properties ***/
        #region
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public FrmHelp()
        {
            InitializeComponent();
        }
        #endregion

        /*** Public Events ***/
        #region
        #endregion

        /*** Public Methods ***/
        #region
        #endregion

        /*** Protected Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        private async void InitializeAsync()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
            }
            catch (Exception e)
            {
                Debug.WriteLine(string.Format("FreePBX_QuickAccess.frmHelp.InitializeAsync()\r\nError: {0}\r\nDesign: {1}\r\nName: {2}",
                    e.Message, LicenseManager.UsageMode == LicenseUsageMode.Designtime, this.Name));

                // Missing WebView2 Runtime?
                // https://go.microsoft.com/fwlink/p/?LinkId=2124703
            }
        }

        private void LoadTopics()
        {
            string contentsFile = Path.Combine(rootLocation, @"help\contents.txt");

            if (File.Exists(contentsFile))
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(contentsFile);

                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');

                    if (parts.Length != 3)
                        continue;

                    string name = parts[0];
                    string loc = parts[1];

                    if (!Enum.TryParse(parts[2], true, out UrlListViewItemLocations locType))
                        continue;

                    UrlListViewItem newItem;

                    switch (locType)
                    {
                        case UrlListViewItemLocations.Web:
                            newItem = new UrlListViewItem(loc, locType, name);
                            break;
                        case UrlListViewItemLocations.Resource:
                            throw new NotImplementedException("UrlListViewItemLocations.Resource not implemented");
                        default:
                            loc = loc.Replace('/', '\\');
                            if (loc.StartsWith(@"\"))
                            {
                                loc = loc.Substring(1);
                            }

                            string localFile = Path.Combine(rootLocation, loc);

                            if (!File.Exists(localFile))
                                continue;

                            newItem = new UrlListViewItem(localFile, locType, name);

                            if (string.IsNullOrEmpty(_url))
                                BrowseTo(localFile);

                            break;
                    }

                    lstTopics.Items.Add(newItem);
                }

                file.Close();
            }
        }
        #endregion

        /*** Event Handlers ***/
        #region
        private void BrowseTo(string url)
        {
            _url = url;

            if (!webViewReady || webView21.CoreWebView2 == null)
                return;

            webView21.CoreWebView2.Navigate(_url);
        }

        private void FrmHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            rootLocation = Path.GetDirectoryName(Application.ExecutablePath);

            LoadTopics();

            InitializeAsync();
        }

        private void LstTopics_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstTopics.SelectedItems.Count < 1)
                return;

            UrlListViewItem selItem = (UrlListViewItem)lstTopics.SelectedItems[0];

            switch (selItem.LocationType)
            {
                case UrlListViewItemLocations.Resource:
                    throw new NotImplementedException("UrlListViewItemLocations.Resource not implemented");
                default:
                    BrowseTo(selItem.Location);

                    break;
            }
        }

        private void WebView21_CoreWebView2Ready(object sender, EventArgs e)
        {
            webViewReady = true;

            try
            {
                if (_url != string.Empty)
                    webView21.CoreWebView2.Navigate(_url);
                else
                    webView21.CoreWebView2.Navigate("https://www.msn.com/");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("FreePBX_QuickAccess.frmHelp.webView21_CoreWebView2Ready()\r\nError: {0}\r\nName: {1}",
                    ex.Message, this.Name));
            }
        }
        #endregion

        private void LstTopics_Click(object sender, EventArgs e)
        {
            LstTopics_ItemSelectionChanged(sender, null);
        }
    }
}
