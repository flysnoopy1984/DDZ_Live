namespace DDZProj
{
    partial class AreaCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p_PokerInfo = new System.Windows.Forms.Panel();
            this.pl_UserInfo = new System.Windows.Forms.Panel();
            this.pb_Portrait = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Portrait)).BeginInit();
            this.SuspendLayout();
            // 
            // p_PokerInfo
            // 
            this.p_PokerInfo.BackColor = System.Drawing.Color.Transparent;
            this.p_PokerInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_PokerInfo.Location = new System.Drawing.Point(0, 278);
            this.p_PokerInfo.Name = "p_PokerInfo";
            this.p_PokerInfo.Size = new System.Drawing.Size(411, 100);
            this.p_PokerInfo.TabIndex = 0;
            // 
            // pl_UserInfo
            // 
            this.pl_UserInfo.Controls.Add(this.label1);
            this.pl_UserInfo.Controls.Add(this.pb_Portrait);
            this.pl_UserInfo.Location = new System.Drawing.Point(4, 4);
            this.pl_UserInfo.Name = "pl_UserInfo";
            this.pl_UserInfo.Size = new System.Drawing.Size(100, 100);
            this.pl_UserInfo.TabIndex = 1;
            // 
            // pb_Portrait
            // 
            this.pb_Portrait.Location = new System.Drawing.Point(4, 4);
            this.pb_Portrait.Name = "pb_Portrait";
            this.pb_Portrait.Size = new System.Drawing.Size(28, 25);
            this.pb_Portrait.TabIndex = 0;
            this.pb_Portrait.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 1;
            // 
            // AreaCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pl_UserInfo);
            this.Controls.Add(this.p_PokerInfo);
            this.Name = "AreaCtrl";
            this.Size = new System.Drawing.Size(411, 378);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaCtrl_Paint);
            this.pl_UserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Portrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_PokerInfo;
        private System.Windows.Forms.Panel pl_UserInfo;
        private System.Windows.Forms.PictureBox pb_Portrait;
        private System.Windows.Forms.Label label1;

    }
}
