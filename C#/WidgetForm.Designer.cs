namespace presentation_clock
{
    partial class WidgetForm
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
            //this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.progress_bar = new CustomizableProgressBar();
            this.SuspendLayout();
            // 
            // progress_bar
            // 
            this.progress_bar.BackColor = System.Drawing.Color.LightGray;
            this.progress_bar.Location = new System.Drawing.Point(12, 12);
            this.progress_bar.Maximum = 1000;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(276, 26);
            this.progress_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_bar.TabIndex = 21;
            this.progress_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDown);
            // 
            // WidgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 50);
            this.ControlBox = false;
            this.Controls.Add(this.progress_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WidgetForm";
            this.ShowIcon = false;
            this.Text = "WidgetForm";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.ProgressBar progress_bar;
        private CustomizableProgressBar progress_bar;
    }
}