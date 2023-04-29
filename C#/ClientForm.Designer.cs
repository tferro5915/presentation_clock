namespace presentation_clock
{
    partial class ClientForm
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
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.current = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress_bar
            // 
            this.progress_bar.BackColor = System.Drawing.Color.LightGray;
            this.progress_bar.Location = new System.Drawing.Point(12, 764);
            this.progress_bar.Maximum = 1000;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(1840, 185);
            this.progress_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_bar.TabIndex = 20;
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 450F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.Location = new System.Drawing.Point(53, 9);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(1787, 679);
            this.current.TabIndex = 19;
            this.current.Text = "00:00";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 961);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.current);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.Label current;
    }
}