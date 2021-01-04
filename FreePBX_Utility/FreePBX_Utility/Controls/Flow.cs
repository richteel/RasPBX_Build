using System.Linq;
using System.Windows.Forms;

namespace FreePBX_Utility.Controls
{
    public static class Flow
    {
        public static void LayoutControls(Control containerControl)
        {
            int nextTop = 0;
            int nextLeft = 0;


            foreach (Control statDisp in containerControl.Controls.OfType<UserControl>())
            {
                statDisp.Top = nextTop;
                statDisp.Left = nextLeft;

                int newTop = statDisp.Top + statDisp.Height;
                int newLeft = statDisp.Left + statDisp.Width;

                // Position Control
                if (newLeft + statDisp.Width < containerControl.Width)
                {
                    nextTop = statDisp.Top;
                    nextLeft = newLeft;
                }
                else   // New row of controls
                {
                    nextTop = newTop;
                    nextLeft = 0;
                }
            }
        }

        public static void LayoutControlsReversed(Control containerControl)
        {
            int nextTop = 0;
            int nextLeft = 0;


            foreach (Control statDisp in Enumerable.Reverse(containerControl.Controls.OfType<UserControl>()))
            {
                statDisp.Top = nextTop;
                statDisp.Left = nextLeft;

                int newTop = statDisp.Top + statDisp.Height;
                int newLeft = statDisp.Left + statDisp.Width;

                // Position Control
                if (newLeft + statDisp.Width < containerControl.Width)
                {
                    nextTop = statDisp.Top;
                    nextLeft = newLeft;
                }
                else   // New row of controls
                {
                    nextTop = newTop;
                    nextLeft = 0;
                }
            }
        }
    }
}
