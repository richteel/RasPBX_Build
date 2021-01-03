
namespace FreePBX_Utility.Controls
{
    partial class UrlConfigSetting
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
            this.components = new System.ComponentModel.Container();
            this.panUrl = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pictureBoxValidState = new System.Windows.Forms.PictureBox();
            this.cmdValidate = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panUrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValidState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // panUrl
            // 
            this.panUrl.Controls.Add(this.txtUrl);
            this.panUrl.Controls.Add(this.pictureBoxValidState);
            this.panUrl.Controls.Add(this.cmdValidate);
            this.panUrl.Controls.Add(this.picHelp);
            this.panUrl.Controls.Add(this.lblTitle);
            this.panUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panUrl.Location = new System.Drawing.Point(0, 0);
            this.panUrl.Name = "panUrl";
            this.panUrl.Padding = new System.Windows.Forms.Padding(5);
            this.panUrl.Size = new System.Drawing.Size(500, 30);
            this.panUrl.TabIndex = 4;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Location = new System.Drawing.Point(144, 5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(242, 20);
            this.txtUrl.TabIndex = 14;
            this.txtUrl.TextChanged += new System.EventHandler(this.TxtUrl_TextChanged);
            // 
            // pictureBoxValidState
            // 
            this.pictureBoxValidState.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxValidState.Image = global::FreePBX_Utility.Properties.Resources.Question;
            this.pictureBoxValidState.Location = new System.Drawing.Point(386, 5);
            this.pictureBoxValidState.Name = "pictureBoxValidState";
            this.pictureBoxValidState.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxValidState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxValidState.TabIndex = 13;
            this.pictureBoxValidState.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxValidState, "Validation Status\r\n? - Not Validated\r\nX - Not Valid\r\nCheck - Valid");
            // 
            // cmdValidate
            // 
            this.cmdValidate.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdValidate.Location = new System.Drawing.Point(406, 5);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(69, 20);
            this.cmdValidate.TabIndex = 12;
            this.cmdValidate.Text = "Validate";
            this.cmdValidate.UseVisualStyleBackColor = true;
            this.cmdValidate.Click += new System.EventHandler(this.CmdValidate_Click);
            // 
            // picHelp
            // 
            this.picHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.picHelp.Image = global::FreePBX_Utility.Properties.Resources.help2;
            this.picHelp.Location = new System.Drawing.Point(475, 5);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(20, 20);
            this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHelp.TabIndex = 11;
            this.picHelp.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Location = new System.Drawing.Point(5, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 20);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // UrlConfigSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panUrl);
            this.Name = "UrlConfigSetting";
            this.Size = new System.Drawing.Size(500, 30);
            this.panUrl.ResumeLayout(false);
            this.panUrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxValidState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panUrl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.PictureBox pictureBoxValidState;
        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Label lblTitle;
    }
}
