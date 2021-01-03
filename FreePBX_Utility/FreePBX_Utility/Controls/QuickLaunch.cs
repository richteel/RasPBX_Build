using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreePBX_Utility.Controls
{
    public partial class QuickLaunch : UserControl
    {
        /*** Fields ***/
        #region

        #endregion

        /*** Properties ***/
        #region
        public Image ButtonImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string Url { get; set; }
        #endregion

        /*** Constructor ***/
        #region
        public QuickLaunch()
        {
            InitializeComponent();
        }
        #endregion

        /*** Public Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        #endregion

        /*** Event Handlers ***/
        #region
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Url != string.Empty)
                System.Diagnostics.Process.Start(Url);
        }
        #endregion
    }
}
