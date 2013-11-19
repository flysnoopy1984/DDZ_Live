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
            this.ddZ_TimeCount = new DDZProj.PainterControl.DDZ_TimeCount();
            this.ddZ_RemainPokerPortrait1 = new DDZProj.PainterControl.DDZ_RemainPokerPortrait();
            this.ddZ_CallScorePortrait1 = new DDZProj.PainterControl.DDZ_CallScorePortrait();
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
            // ddZ_TimeCount
            // 
            this.ddZ_TimeCount.Location = new System.Drawing.Point(295, 3);
            this.ddZ_TimeCount.Name = "ddZ_TimeCount";
            this.ddZ_TimeCount.Size = new System.Drawing.Size(90, 84);
            this.ddZ_TimeCount.TabIndex = 3;
            // 
            // ddZ_RemainPokerPortrait1
            // 
            this.ddZ_RemainPokerPortrait1.Location = new System.Drawing.Point(7, 41);
            this.ddZ_RemainPokerPortrait1.Name = "ddZ_RemainPokerPortrait1";
            this.ddZ_RemainPokerPortrait1.Size = new System.Drawing.Size(109, 46);
            this.ddZ_RemainPokerPortrait1.TabIndex = 2;
            // 
            // ddZ_CallScorePortrait1
            // 
            this.ddZ_CallScorePortrait1.BackColor = System.Drawing.Color.Black;
            this.ddZ_CallScorePortrait1.BossCall = 0;
            this.ddZ_CallScorePortrait1.Location = new System.Drawing.Point(9, 4);
            this.ddZ_CallScorePortrait1.Name = "ddZ_CallScorePortrait1";
            this.ddZ_CallScorePortrait1.Size = new System.Drawing.Size(108, 37);
            this.ddZ_CallScorePortrait1.TabIndex = 1;
            // 
            // AreaCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ddZ_TimeCount);
            this.Controls.Add(this.ddZ_RemainPokerPortrait1);
            this.Controls.Add(this.ddZ_CallScorePortrait1);
            this.Controls.Add(this.p_PokerInfo);
            this.Name = "AreaCtrl";
            this.Size = new System.Drawing.Size(411, 378);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaCtrl_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_PokerInfo;
        private PainterControl.DDZ_CallScorePortrait ddZ_CallScorePortrait1;
        private PainterControl.DDZ_RemainPokerPortrait ddZ_RemainPokerPortrait1;
        private PainterControl.DDZ_TimeCount ddZ_TimeCount;

    }
}
