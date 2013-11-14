namespace DDZProj.PainterControl
{
    partial class DDZ_RemainPokerPortrait
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
            this.pl_RemainPokerBK = new System.Windows.Forms.Panel();
            this.pl_RemainPokerNumBK = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pl_RemainPokerBK
            // 
            this.pl_RemainPokerBK.Location = new System.Drawing.Point(4, 8);
            this.pl_RemainPokerBK.Name = "pl_RemainPokerBK";
            this.pl_RemainPokerBK.Size = new System.Drawing.Size(64, 29);
            this.pl_RemainPokerBK.TabIndex = 2;
            this.pl_RemainPokerBK.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_RemainPokerBK_Paint);
            // 
            // pl_RemainPokerNumBK
            // 
            this.pl_RemainPokerNumBK.Location = new System.Drawing.Point(60, 3);
            this.pl_RemainPokerNumBK.Name = "pl_RemainPokerNumBK";
            this.pl_RemainPokerNumBK.Size = new System.Drawing.Size(45, 45);
            this.pl_RemainPokerNumBK.TabIndex = 3;
            this.pl_RemainPokerNumBK.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_RemainPokerNumBK_Paint);
            // 
            // DDZ_RemainPokerPortrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_RemainPokerNumBK);
            this.Controls.Add(this.pl_RemainPokerBK);
            this.Name = "DDZ_RemainPokerPortrait";
            this.Size = new System.Drawing.Size(138, 60);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DDZ_RemainPokerPortrait_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_RemainPokerBK;
        private System.Windows.Forms.Panel pl_RemainPokerNumBK;
    }
}
