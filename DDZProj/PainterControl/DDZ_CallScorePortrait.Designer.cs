namespace DDZProj.PainterControl
{
    partial class DDZ_CallScorePortrait
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
            this.pb_Portrait = new System.Windows.Forms.PictureBox();
            this.pb_CallBossNum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Portrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CallBossNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Portrait
            // 
            this.pb_Portrait.Location = new System.Drawing.Point(4, 2);
            this.pb_Portrait.Name = "pb_Portrait";
            this.pb_Portrait.Size = new System.Drawing.Size(33, 34);
            this.pb_Portrait.TabIndex = 2;
            this.pb_Portrait.TabStop = false;
            // 
            // pb_CallBossNum
            // 
            this.pb_CallBossNum.BackColor = System.Drawing.Color.Transparent;
            this.pb_CallBossNum.Location = new System.Drawing.Point(50, 5);
            this.pb_CallBossNum.Name = "pb_CallBossNum";
            this.pb_CallBossNum.Size = new System.Drawing.Size(33, 34);
            this.pb_CallBossNum.TabIndex = 3;
            this.pb_CallBossNum.TabStop = false;
            // 
            // DDZ_CallScorePortrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pb_CallBossNum);
            this.Controls.Add(this.pb_Portrait);
            this.Name = "DDZ_CallScorePortrait";
            this.Size = new System.Drawing.Size(228, 96);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DDZ_CallScorePortrait_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Portrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CallBossNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Portrait;
        private System.Windows.Forms.PictureBox pb_CallBossNum;
    }
}
