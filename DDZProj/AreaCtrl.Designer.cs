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
            this.SuspendLayout();
            // 
            // p_PokerInfo
            // 
            this.p_PokerInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_PokerInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_PokerInfo.Location = new System.Drawing.Point(0, 274);
            this.p_PokerInfo.Name = "p_PokerInfo";
            this.p_PokerInfo.Size = new System.Drawing.Size(407, 100);
            this.p_PokerInfo.TabIndex = 0;
            // 
            // AreaCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.p_PokerInfo);
            this.Name = "AreaCtrl";
            this.Size = new System.Drawing.Size(407, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_PokerInfo;

    }
}
