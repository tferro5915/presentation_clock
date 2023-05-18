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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.current = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress_bar
            // 
            this.progress_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress_bar.BackColor = System.Drawing.Color.LightGray;
            this.progress_bar.Location = new System.Drawing.Point(3, 283);
            this.progress_bar.Maximum = 1000;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(554, 62);
            this.progress_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress_bar.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.current, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progress_bar, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 348);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // current
            // 
            this.current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.current.AutoSize = true;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.Location = new System.Drawing.Point(3, 0);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(554, 280);
            this.current.TabIndex = 19;
            this.current.Text = " 00:00";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.ClientForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label current;
    }
}