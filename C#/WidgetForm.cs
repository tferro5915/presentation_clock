using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace presentation_clock
{
    public partial class WidgetForm : Form
    {
        // Setup to move window without boarder/titlebar
        // https://www.codeproject.com/Articles/11114/Move-window-form-without-Titlebar-in-C
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public WidgetForm()
        {
            InitializeComponent();
        }

        public void Toc(int progress, Color color)
        {
            progress_bar.Value = progress;
            progress_bar.ForeColor = color;
        }

        private void Widget_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
