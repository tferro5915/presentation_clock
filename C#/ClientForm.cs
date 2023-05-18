using System;
using System.Drawing;
using System.Windows.Forms;

namespace presentation_clock
{
    public partial class ClientForm : Form
    {
        private int original_width, original_height;
        private double original_font_size;

        public ClientForm()
        {
            InitializeComponent();
            original_width = Width;
            original_height = Height;
            original_font_size = current.Font.Size;
        }

        public void Toc(int progress, string time, Color prog_color, Color fg_color, Color bg_color)
        {
            progress_bar.Value = progress;
            current.Text = time;
            progress_bar.ForeColor = prog_color;
            this.BackColor = bg_color;
            this.ForeColor = fg_color;
        }

        private void ClientForm_Resize(object sender, System.EventArgs e)
        {
            double width_resize = Width / (float) original_width;
            double height_resize = Height / (float) original_height;
            double resize = Math.Sqrt(width_resize * height_resize);  // Geometric mean
            float new_size = (float)(original_font_size * resize);
            current.Font = new Font(current.Font.FontFamily, new_size, current.Font.Style, current.Font.Unit);
        }
    }
}
