namespace ShadowPanelTest
{
    partial class Form1
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
            this.shadowPanel1 = new ShadowPanel.ShadowPanel();
            this.SuspendLayout();
            // 
            // shadowPanel1
            // 
            this.shadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.shadowPanel1.BorderColor = System.Drawing.Color.Black;
            this.shadowPanel1.Location = new System.Drawing.Point(12, 12);
            this.shadowPanel1.Name = "shadowPanel1";
            this.shadowPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.shadowPanel1.Size = new System.Drawing.Size(282, 131);
            this.shadowPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 160);
            this.Controls.Add(this.shadowPanel1);
            this.Name = "Form1";
            this.Text = "Drop shadow";
            this.ResumeLayout(false);

        }

        #endregion

        private ShadowPanel.ShadowPanel shadowPanel1;
    }
}

