using FreePBX_Utility.Web;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace FreePBX_Utility.Controls
{
    public partial class UrlConfigSetting : UserControl
    {
        /*** Fields and Constants ***/
        #region
        private bool isUrlValidated = false;
        private bool isUrlValid = false;
        private string validationMessage = "";
        #endregion

        /*** Properties ***/
        #region
        public string BaseUrl { get; set; }

        public bool IsUrlValid
        {
            get { return isUrlValid; }
        }

        public bool IsUrlValidated
        {
            get { return isUrlValidated; }
        }

        public string SettingKey { get; set; }

        public bool ShowValidateButton
        {
            get { return cmdValidate.Visible; }
            set { cmdValidate.Visible = value; }
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        [EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string ToolTip
        {
            get { return toolTip1.GetToolTip(picHelp); }
            set
            {
                toolTip1.SetToolTip(picHelp, value);
            }
        }

        public string Url
        {
            get { return txtUrl.Text; }
            set { txtUrl.Text = value; }
        }

        public string UrlComplete
        {
            get
            {
                if (Url.StartsWith("http"))
                    return Url;

                return Web.WebHelper.UrlCombine(BaseUrl, Url);
            }
        }

        public string ValidationMessage
        {
            get { return validationMessage; }
        }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public UrlConfigSetting()
        {
            InitializeComponent();
        }
        #endregion

        /*** Public Events ***/
        #region
        public event EventHandler<EventArgs> ValueChanged;

        public void Value_Changed(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(sender, e);
        }

        private bool DoValidation(bool ShowMessageBox, bool MessageBoxWarningOnly = false)
        {
            validationMessage = "";
            isUrlValidated = true;
            isUrlValid = false;

            string msgTitle = "URL Validation";
            string msgTxt = "";

            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                msgTxt = "Required value missing. Enter a valid URL.";
            }
            else if (!txtUrl.Text.StartsWith("http") && string.IsNullOrEmpty(BaseUrl))
            {
                msgTxt = "Invaild URL Entered. Enter a valid URL.";
            }
            else
            {
                string webText = WebContent.GetResponseText(UrlComplete);

                if (!string.IsNullOrEmpty(webText))
                    isUrlValid = true;
                else
                    msgTxt = "No content found, access denied, or page unavailable.";
            }

            if (msgTxt.Length > 0)
                validationMessage = msgTitle + "\t" + msgTxt;

            pictureBoxValidState.Image = isUrlValid ? FreePBX_Utility.Properties.Resources.check : FreePBX_Utility.Properties.Resources.X;

            if (ShowMessageBox && (!isUrlValid || !MessageBoxWarningOnly))
            {
                if (isUrlValid)
                    MessageBox.Show(this, "Validation Complete", msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, msgTxt, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isUrlValid;
        }
        #endregion

        /*** Public Methods ***/
        #region
        public new bool Validate()
        {
            return DoValidation(false);
        }
        #endregion

        /*** Event Handlers ***/
        #region
        private void CmdValidate_Click(object sender, EventArgs e)
        {
            DoValidation(true);
        }

        private void TxtUrl_TextChanged(object sender, EventArgs e)
        {
            if (isUrlValidated)
            {
                pictureBoxValidState.Image = FreePBX_Utility.Properties.Resources.Question;
                isUrlValidated = false;
                isUrlValid = false;
            }
            Value_Changed(this, e);
        }
        #endregion
    }
}
