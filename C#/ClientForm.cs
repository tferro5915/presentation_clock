using System.Drawing;
using System.Windows.Forms;

namespace presentation_clock
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        public void Toc(int progress, string time, Color prog_color, Color fg_color, Color bg_color)
        {
            progress_bar.Value = progress;
            current.Text = time;
            progress_bar.ForeColor = prog_color;
            this.BackColor = bg_color;
            this.ForeColor = fg_color;
        }
    }
}
