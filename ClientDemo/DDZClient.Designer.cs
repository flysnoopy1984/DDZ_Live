namespace ClientDemo
{
    partial class DDZClient
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bn_Connect = new System.Windows.Forms.Button();
            this.bn_Send = new System.Windows.Forms.Button();
            this.tb_SendInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(712, 244);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bn_Connect
            // 
            this.bn_Connect.Location = new System.Drawing.Point(31, 389);
            this.bn_Connect.Name = "bn_Connect";
            this.bn_Connect.Size = new System.Drawing.Size(75, 23);
            this.bn_Connect.TabIndex = 1;
            this.bn_Connect.Text = "Connect";
            this.bn_Connect.UseVisualStyleBackColor = true;
            this.bn_Connect.Click += new System.EventHandler(this.bn_Connect_Click);
            // 
            // bn_Send
            // 
            this.bn_Send.Location = new System.Drawing.Point(625, 280);
            this.bn_Send.Name = "bn_Send";
            this.bn_Send.Size = new System.Drawing.Size(75, 23);
            this.bn_Send.TabIndex = 2;
            this.bn_Send.Text = "Send";
            this.bn_Send.UseVisualStyleBackColor = true;
            this.bn_Send.Click += new System.EventHandler(this.bn_Send_Click);
            // 
            // tb_SendInfo
            // 
            this.tb_SendInfo.Location = new System.Drawing.Point(12, 267);
            this.tb_SendInfo.Multiline = true;
            this.tb_SendInfo.Name = "tb_SendInfo";
            this.tb_SendInfo.Size = new System.Drawing.Size(599, 61);
            this.tb_SendInfo.TabIndex = 3;
            // 
            // DDZClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 455);
            this.Controls.Add(this.tb_SendInfo);
            this.Controls.Add(this.bn_Send);
            this.Controls.Add(this.bn_Connect);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DDZClient";
            this.Text = "ClientConsole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bn_Connect;
        private System.Windows.Forms.Button bn_Send;
        private System.Windows.Forms.TextBox tb_SendInfo;
    }
}

