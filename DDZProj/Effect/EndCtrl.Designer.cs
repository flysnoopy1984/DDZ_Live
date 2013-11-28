namespace DDZProj.Effect
{
    partial class EndCtrl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndCtrl));
            this.lb_Player1 = new DDZProj.PainterControl.LabelScoreInfo(this.components);
            this.lb_Player2 = new DDZProj.PainterControl.LabelScoreInfo(this.components);
            this.lb_Player3 = new DDZProj.PainterControl.LabelScoreInfo(this.components);
            this.SuspendLayout();
            // 
            // lb_Player1
            // 
            this.lb_Player1.AutoSize = true;
            this.lb_Player1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Player1.ForeColor = System.Drawing.Color.White;
            this.lb_Player1.Location = new System.Drawing.Point(119, 154);
            this.lb_Player1.Name = "lb_Player1";
            this.lb_Player1.Size = new System.Drawing.Size(48, 19);
            this.lb_Player1.TabIndex = 0;
            this.lb_Player1.Text = "选手A";
            // 
            // lb_Player2
            // 
            this.lb_Player2.AutoSize = true;
            this.lb_Player2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Player2.ForeColor = System.Drawing.Color.White;
            this.lb_Player2.Location = new System.Drawing.Point(119, 210);
            this.lb_Player2.Name = "lb_Player2";
            this.lb_Player2.Size = new System.Drawing.Size(47, 19);
            this.lb_Player2.TabIndex = 1;
            this.lb_Player2.Text = "选手B";
            // 
            // lb_Player3
            // 
            this.lb_Player3.AutoSize = true;
            this.lb_Player3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Player3.ForeColor = System.Drawing.Color.White;
            this.lb_Player3.Location = new System.Drawing.Point(119, 274);
            this.lb_Player3.Name = "lb_Player3";
            this.lb_Player3.Size = new System.Drawing.Size(46, 19);
            this.lb_Player3.TabIndex = 2;
            this.lb_Player3.Text = "选手C";
            // 
            // EndCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lb_Player3);
            this.Controls.Add(this.lb_Player2);
            this.Controls.Add(this.lb_Player1);
            this.Name = "EndCtrl";
            this.Size = new System.Drawing.Size(567, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PainterControl.LabelScoreInfo lb_Player1;
        private PainterControl.LabelScoreInfo lb_Player2;
        private PainterControl.LabelScoreInfo lb_Player3;

    }
}
