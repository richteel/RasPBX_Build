
namespace FreePBX_Utility.Controls
{
    partial class WebPortal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRefreshed = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(5);
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRefreshed
            // 
            this.lblRefreshed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRefreshed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRefreshed.Location = new System.Drawing.Point(0, 120);
            this.lblRefreshed.Name = "lblRefreshed";
            this.lblRefreshed.Size = new System.Drawing.Size(150, 30);
            this.lblRefreshed.TabIndex = 2;
            this.lblRefreshed.Text = "Status";
            this.lblRefreshed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 25);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(150, 95);
            this.webView21.TabIndex = 3;
            this.webView21.Text = "webView21";
            this.webView21.ZoomFactor = 1D;
            this.webView21.CoreWebView2Ready += new System.EventHandler<System.EventArgs>(this.WebView21_CoreWebView2Ready);
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebView21_NavigationCompleted);
            // 
            // WebPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lblRefreshed);
            this.Controls.Add(this.lblTitle);
            this.Name = "WebPortal";
            this.Load += new System.EventHandler(this.TsWebView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRefreshed;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
