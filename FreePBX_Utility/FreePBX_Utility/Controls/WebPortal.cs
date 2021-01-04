using FreePBX_Utility.Utility;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace FreePBX_Utility.Controls
{
    public partial class WebPortal : UserControl
    {
        string _url;
        bool webViewReady = false;

        #region Constructor and Initialization
        public WebPortal()
        {
            InitializeComponent();

            Title = "Title";
            LastRefreshed = Common.NULL_DATE;
        }
        #endregion

        #region Properties
        public DateTime LastRefreshed { get; set; }

        public string StatusText { get; set; }

        public string Title
        {
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value;
            }
        }

        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;

                if (!webViewReady || webView21.CoreWebView2 == null)
                    return;

                webView21.CoreWebView2.Navigate(_url);
            }
        }
        #endregion

        #region Public Methods
        public void NavigateTo(string url)
        {
            _url = url;

            if (!webViewReady || webView21.CoreWebView2 == null)
                return;

            webView21.CoreWebView2.Navigate(_url);
        }

        public void RefreshWebView()
        {
            if (!webViewReady || webView21.CoreWebView2 == null)
                return;

            webView21.CoreWebView2.Reload();
        }
        #endregion


        #region Private Methods
        private async void InitializeAsync()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
            }
            catch (Exception e)
            {
                Debug.WriteLine(string.Format("FreePBX_QuickAccess.AppControls.tsWebView.InitializeAsync()\r\nError: {0}\r\nDesign: {1}\r\nName: {2}",
                    e.Message, LicenseManager.UsageMode == LicenseUsageMode.Designtime, this.Name));

                //if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                //    return;

                //if (MessageBox.Show(this, "Missing WebView2 Runtime\nGo to Microsoft to download?",
                //    "Download Missing WebView2 Runtime?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                //{
                //    System.Diagnostics.Process.Start("https://go.microsoft.com/fwlink/p/?LinkId=2124703");
                //}
            }
        }

        private void UpdateLastRefreshed()
        {
            lblRefreshed.Text = string.Format("Updated: {0:ddd d MMM yyyy h:mm:ss tt} - Status: {1}", LastRefreshed, StatusText);
        }
        #endregion

        #region Event Handlers
        private void TsWebView_Load(object sender, EventArgs e)
        {
            InitializeAsync();
            UpdateLastRefreshed();
            StatusText = "Not Loaded";
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
                Debug.WriteLine(string.Format("FreePBX_QuickAccess.AppControls.tsWebView.webView21_CoreWebView2Ready()\r\nError: {0}\r\nName: {1}",
                    ex.Message, this.Name));
            }
        }

        private void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            LastRefreshed = DateTime.Now;
            StatusText = e.IsSuccess ? "Success" : "Error";
            UpdateLastRefreshed();
        }
        #endregion
    }
}
