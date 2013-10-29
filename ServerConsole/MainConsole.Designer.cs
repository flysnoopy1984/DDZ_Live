namespace ServerConsole
{
    partial class MainConsole
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
            this.bn_Start = new System.Windows.Forms.Button();
            this.tb_Info = new System.Windows.Forms.RichTextBox();
            this.bn_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bn_Start
            // 
            this.bn_Start.Location = new System.Drawing.Point(12, 396);
            this.bn_Start.Name = "bn_Start";
            this.bn_Start.Size = new System.Drawing.Size(75, 23);
            this.bn_Start.TabIndex = 0;
            this.bn_Start.Text = "Start";
            this.bn_Start.UseVisualStyleBackColor = true;
            this.bn_Start.Click += new System.EventHandler(this.bn_Start_Click);
            // 
            // tb_Info
            // 
            this.tb_Info.BackColor = System.Drawing.Color.Black;
            this.tb_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Info.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Info.Location = new System.Drawing.Point(0, 0);
            this.tb_Info.Name = "tb_Info";
            this.tb_Info.Size = new System.Drawing.Size(649, 347);
            this.tb_Info.TabIndex = 1;
            this.tb_Info.Text = "";
            // 
            // bn_End
            // 
            this.bn_End.Location = new System.Drawing.Point(114, 395);
            this.bn_End.Name = "bn_End";
            this.bn_End.Size = new System.Drawing.Size(75, 23);
            this.bn_End.TabIndex = 2;
            this.bn_End.Text = "End";
            this.bn_End.UseVisualStyleBackColor = true;
            this.bn_End.Click += new System.EventHandler(this.bn_End_Click);
            // 
            // MainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 431);
            this.Controls.Add(this.bn_End);
            this.Controls.Add(this.tb_Info);
            this.Controls.Add(this.bn_Start);
            this.Name = "MainConsole";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_Start;
        private System.Windows.Forms.RichTextBox tb_Info;
        private System.Windows.Forms.Button bn_End;
    }
}

