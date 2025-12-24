using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

//using Timers = System.Timers;  // Avoid conflict with System.Windows.Form.Timer, and with short name

namespace presentation_clock
{
    public partial class HostForm : Form
    {

        // Constants 
        //private const double interval = 1000;
        private readonly TimeSpan interval = TimeSpan.FromSeconds(1);
        private readonly Color[] bg = { Color.LightGray, Color.Black };  // Normal, inverted (for flashing)
        private readonly Color[] fg = { Color.Black, Color.LightGray };
        private readonly Color[] bar = { Color.Red, Color.Black };

        // Globals
        private bool needs_reset = true;
        private string time_display;
        private TimeSpan time;
        private int progress;  // 0-1000 (because 0-100 was too jumpy)
        private Color current_bg, current_fg, current_bar;
        private Timer timer;
        private ClientForm client;
        private WidgetForm widget;


        public HostForm()
        {
            InitializeComponent();

            // Create subforms
            client = new ClientForm();
            widget = new WidgetForm();
            client.Show();
            widget.Show();

            // Init timmer
            timer = new Timer();
            timer.Interval = (int) interval.TotalMilliseconds;
            timer.Tick += new EventHandler(Tic);
        }

        private void Tic(object sender, EventArgs e)
        {
            time = time - interval;
            Toc();
        }

        public void Toc()
        {
            double t;
            try
            {
                t = double.Parse(total.Text);
            }
            catch (System.FormatException e)
            {
                return;
            }

            // Update Progress
            time_display = (time < TimeSpan.Zero ? "-" : "") + $"{time:mm\\:ss}";
            progress = (int)(1000 - time.TotalSeconds / (t * 60) * 1000);
            progress = Math.Min(Math.Max(0, progress), 1000);

            if (time <= TimeSpan.FromMinutes(double.Parse(flash.Text)))
            {
                if (current_bg == Color.LightGray)
                {
                    current_bg = bg[1];
                    current_fg = fg[1];
                    current_bar = bar[1];
                }
                else
                {
                    current_bg = bg[0];
                    current_fg = fg[0];
                    current_bar = bar[0];
                }
            }
            else if (time <= TimeSpan.FromMinutes(double.Parse(red.Text)))
            {
                current_bg = Color.LightGray;
                current_fg = Color.Black;
                current_bar = Color.Red;
            }
            else if (time <= TimeSpan.FromMinutes(double.Parse(yellow.Text)))
            {
                current_bg = Color.LightGray;
                current_fg = Color.Black;
                current_bar = Color.Yellow;
            }
            else if (time <= TimeSpan.FromMinutes(double.Parse(green.Text)))
            {
                current_bg = Color.LightGray;
                current_fg = Color.Black;
                current_bar = Color.Green;
            }
            else
            {
                current_bg = Color.LightGray;
                current_fg = Color.Black;
                current_bar = Color.Gray;
            }

            // Update Displays
            widget.Toc(progress, current_bar);
            client.Toc(progress, time_display, current_bar, current_fg, current_bg);
            progress_bar.Value = progress;
            current.Text = time_display;
            progress_bar.ForeColor = current_bar;
        }

        private void play(object sender, EventArgs e)
        {
            if (timer.Enabled || needs_reset)
            {
                timer.Stop();
                reset();
            }
            timer.Start();
        }

        private void pause(object sender = null, EventArgs e = null)
        {
            timer.Stop();
        }

        private void reset(object sender = null, EventArgs e = null)
        {
            time = TimeSpan.FromMinutes(double.Parse(total.Text));
            needs_reset = false;
            Toc();

            current_bg = Color.LightGray;
            current_fg = Color.Black;
            current_bar = Color.Gray;
        }

        private void stop(object sender, EventArgs e)
        {
            pause();
            reset();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            needs_reset = true;
        }

        private void plus(object sender, EventArgs e)
        {
            time = time + TimeSpan.FromMinutes(double.Parse(shim.Text));
            Toc();
        }

        private void minus(object sender, EventArgs e)
        {
            time = time - TimeSpan.FromMinutes(double.Parse(shim.Text));
            Toc();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            client.Close();
            widget.Close();
            base.OnFormClosing(e);
        }
    }
}
