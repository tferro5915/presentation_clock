namespace presentation_clock
{
    partial class HostForm
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
            this.button_play = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.TextBox();
            this.label_yellow = new System.Windows.Forms.Label();
            this.yellow = new System.Windows.Forms.TextBox();
            this.label_red = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.TextBox();
            this.label_flash = new System.Windows.Forms.Label();
            this.flash = new System.Windows.Forms.TextBox();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.shim = new System.Windows.Forms.TextBox();
            this.current = new System.Windows.Forms.Label();
            //this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.progress_bar = new CustomizableProgressBar();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Image = global::presentation_clock.Properties.Resources.play;
            this.button_play.Location = new System.Drawing.Point(13, 36);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(37, 34);
            this.button_play.TabIndex = 0;
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.play);
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(49, 4);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(30, 22);
            this.total.TabIndex = 1;
            this.total.Text = "00.0";
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(10, 6);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(38, 16);
            this.label_total.TabIndex = 2;
            this.label_total.Text = "Total";
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_green.Location = new System.Drawing.Point(88, 6);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(44, 16);
            this.label_green.TabIndex = 4;
            this.label_green.Text = "Green";
            // 
            // green
            // 
            this.green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.green.Location = new System.Drawing.Point(134, 4);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(30, 22);
            this.green.TabIndex = 3;
            this.green.Text = "00.0";
            // 
            // label_yellow
            // 
            this.label_yellow.AutoSize = true;
            this.label_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_yellow.Location = new System.Drawing.Point(172, 6);
            this.label_yellow.Name = "label_yellow";
            this.label_yellow.Size = new System.Drawing.Size(47, 16);
            this.label_yellow.TabIndex = 6;
            this.label_yellow.Text = "Yellow";
            // 
            // yellow
            // 
            this.yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow.Location = new System.Drawing.Point(220, 4);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(30, 22);
            this.yellow.TabIndex = 5;
            this.yellow.Text = "00.0";
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_red.Location = new System.Drawing.Point(262, 6);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(33, 16);
            this.label_red.TabIndex = 8;
            this.label_red.Text = "Red";
            // 
            // red
            // 
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red.Location = new System.Drawing.Point(297, 4);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(30, 22);
            this.red.TabIndex = 7;
            this.red.Text = "00.0";
            // 
            // label_flash
            // 
            this.label_flash.AutoSize = true;
            this.label_flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_flash.Location = new System.Drawing.Point(335, 6);
            this.label_flash.Name = "label_flash";
            this.label_flash.Size = new System.Drawing.Size(40, 16);
            this.label_flash.TabIndex = 10;
            this.label_flash.Text = "Flash";
            // 
            // flash
            // 
            this.flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash.Location = new System.Drawing.Point(376, 4);
            this.flash.Name = "flash";
            this.flash.Size = new System.Drawing.Size(30, 22);
            this.flash.TabIndex = 9;
            this.flash.Text = "00.0";
            // 
            // button_pause
            // 
            this.button_pause.Image = global::presentation_clock.Properties.Resources.pause;
            this.button_pause.Location = new System.Drawing.Point(61, 36);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(37, 34);
            this.button_pause.TabIndex = 11;
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.pause);
            // 
            // button_minus
            // 
            this.button_minus.Image = global::presentation_clock.Properties.Resources.minus;
            this.button_minus.Location = new System.Drawing.Point(369, 36);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(37, 34);
            this.button_minus.TabIndex = 12;
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.minus);
            // 
            // button_plus
            // 
            this.button_plus.Image = global::presentation_clock.Properties.Resources.plus;
            this.button_plus.Location = new System.Drawing.Point(280, 36);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(37, 34);
            this.button_plus.TabIndex = 13;
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.plus);
            // 
            // button_stop
            // 
            this.button_stop.Image = global::presentation_clock.Properties.Resources.stop;
            this.button_stop.Location = new System.Drawing.Point(157, 36);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(37, 34);
            this.button_stop.TabIndex = 14;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.stop);
            // 
            // button_reset
            // 
            this.button_reset.Image = global::presentation_clock.Properties.Resources.reset;
            this.button_reset.Location = new System.Drawing.Point(109, 36);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(37, 34);
            this.button_reset.TabIndex = 15;
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.reset);
            // 
            // shim
            // 
            this.shim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shim.Location = new System.Drawing.Point(328, 42);
            this.shim.Name = "shim";
            this.shim.Size = new System.Drawing.Size(30, 22);
            this.shim.TabIndex = 16;
            this.shim.Text = "00.0";
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.Location = new System.Drawing.Point(12, 85);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(98, 37);
            this.current.TabIndex = 17;
            this.current.Text = "00:00";
            // 
            // progress_bar
            // 
            this.progress_bar.BackColor = System.Drawing.Color.LightGray;
            this.progress_bar.Location = new System.Drawing.Point(119, 85);
            this.progress_bar.Maximum = 1000;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(287, 37);
            this.progress_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_bar.TabIndex = 18;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 133);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.current);
            this.Controls.Add(this.shim);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.label_flash);
            this.Controls.Add(this.flash);
            this.Controls.Add(this.label_red);
            this.Controls.Add(this.red);
            this.Controls.Add(this.label_yellow);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.label_green);
            this.Controls.Add(this.green);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button_play);
            this.Name = "HostForm";
            this.Text = "Presentation Timer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_green;
        private System.Windows.Forms.TextBox green;
        private System.Windows.Forms.Label label_yellow;
        private System.Windows.Forms.TextBox yellow;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.TextBox red;
        private System.Windows.Forms.Label label_flash;
        private System.Windows.Forms.TextBox flash;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox shim;
        private System.Windows.Forms.Label current;
        //private System.Windows.Forms.ProgressBar progress_bar;
        private CustomizableProgressBar progress_bar;
    }
}

