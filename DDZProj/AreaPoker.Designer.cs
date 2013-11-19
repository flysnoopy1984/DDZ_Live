namespace DDZProj
{
    partial class AreaPoker
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
            this.p_right = new System.Windows.Forms.Panel();
            this.p_Top = new System.Windows.Forms.Panel();
            this.p_left = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // p_right
            // 
            this.p_right.BackColor = System.Drawing.Color.Transparent;
            this.p_right.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_right.Location = new System.Drawing.Point(0, 100);
            this.p_right.Name = "p_right";
            this.p_right.Size = new System.Drawing.Size(367, 112);
            this.p_right.TabIndex = 0;
            this.p_right.Paint += new System.Windows.Forms.PaintEventHandler(this.p_right_Paint);
            // 
            // p_Top
            // 
            this.p_Top.BackColor = System.Drawing.Color.Transparent;
            this.p_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Top.Location = new System.Drawing.Point(0, 0);
            this.p_Top.Name = "p_Top";
            this.p_Top.Size = new System.Drawing.Size(367, 100);
            this.p_Top.TabIndex = 1;
            this.p_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Top_Paint);
            // 
            // p_left
            // 
            this.p_left.BackColor = System.Drawing.Color.Transparent;
            this.p_left.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_left.Location = new System.Drawing.Point(0, 209);
            this.p_left.Name = "p_left";
            this.p_left.Size = new System.Drawing.Size(367, 100);
            this.p_left.TabIndex = 2;
            this.p_left.Paint += new System.Windows.Forms.PaintEventHandler(this.p_left_Paint);
            // 
            // AreaPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.p_left);
            this.Controls.Add(this.p_right);
            this.Controls.Add(this.p_Top);
            this.Name = "AreaPoker";
            this.Size = new System.Drawing.Size(367, 309);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_right;
        private System.Windows.Forms.Panel p_Top;
        private System.Windows.Forms.Panel p_left;
    }
}
