
namespace FreePBX_Utility
{
    partial class FrmHelp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstTopics = new System.Windows.Forms.ListView();
            this.lblHelpTopics = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstTopics);
            this.splitContainer1.Panel1.Controls.Add(this.lblHelpTopics);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webView21);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstTopics
            // 
            this.lstTopics.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstTopics.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTopics.HideSelection = false;
            this.lstTopics.Location = new System.Drawing.Point(0, 31);
            this.lstTopics.Margin = new System.Windows.Forms.Padding(4);
            this.lstTopics.MultiSelect = false;
            this.lstTopics.Name = "lstTopics";
            this.lstTopics.Size = new System.Drawing.Size(216, 523);
            this.lstTopics.TabIndex = 1;
            this.lstTopics.UseCompatibleStateImageBehavior = false;
            this.lstTopics.View = System.Windows.Forms.View.List;
            this.lstTopics.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstTopics_ItemSelectionChanged);
            this.lstTopics.Click += new System.EventHandler(this.LstTopics_Click);
            // 
            // lblHelpTopics
            // 
            this.lblHelpTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHelpTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTopics.Location = new System.Drawing.Point(0, 0);
            this.lblHelpTopics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelpTopics.Name = "lblHelpTopics";
            this.lblHelpTopics.Size = new System.Drawing.Size(216, 31);
            this.lblHelpTopics.TabIndex = 0;
            this.lblHelpTopics.Text = "Topics";
            this.lblHelpTopics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webView21
            // 
            this.webView21.CreationProperties = null;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 31);
            this.webView21.Margin = new System.Windows.Forms.Padding(4);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(846, 523);
            this.webView21.TabIndex = 3;
            this.webView21.Text = "webView21";
            this.webView21.ZoomFactor = 1D;
            this.webView21.CoreWebView2Ready += new System.EventHandler<System.EventArgs>(this.WebView21_CoreWebView2Ready);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 31);
            this.panel1.TabIndex = 0;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHelp";
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHelp_FormClosing);
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstTopics;
        private System.Windows.Forms.Label lblHelpTopics;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}