namespace DDZProj
{
    partial class ConsoleMain
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
            this.bn_Reset = new System.Windows.Forms.Button();
            this.Bn_Begin = new System.Windows.Forms.Button();
            this.bn_APost = new System.Windows.Forms.Button();
            this.bn_PostB = new System.Windows.Forms.Button();
            this.bn_PostC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bn_CallBoss = new System.Windows.Forms.Button();
            this.bn_One = new System.Windows.Forms.Button();
            this.bn_Two = new System.Windows.Forms.Button();
            this.bn_Three = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bn_Reset
            // 
            this.bn_Reset.Location = new System.Drawing.Point(12, 12);
            this.bn_Reset.Name = "bn_Reset";
            this.bn_Reset.Size = new System.Drawing.Size(75, 23);
            this.bn_Reset.TabIndex = 0;
            this.bn_Reset.Text = "重新开始";
            this.bn_Reset.UseVisualStyleBackColor = true;
            this.bn_Reset.Click += new System.EventHandler(this.bn_Reset_Click);
            // 
            // Bn_Begin
            // 
            this.Bn_Begin.Location = new System.Drawing.Point(109, 12);
            this.Bn_Begin.Name = "Bn_Begin";
            this.Bn_Begin.Size = new System.Drawing.Size(75, 23);
            this.Bn_Begin.TabIndex = 1;
            this.Bn_Begin.Text = "开始发牌";
            this.Bn_Begin.UseVisualStyleBackColor = true;
            this.Bn_Begin.Click += new System.EventHandler(this.Bn_Begin_Click);
            // 
            // bn_APost
            // 
            this.bn_APost.Location = new System.Drawing.Point(13, 61);
            this.bn_APost.Name = "bn_APost";
            this.bn_APost.Size = new System.Drawing.Size(75, 23);
            this.bn_APost.TabIndex = 2;
            this.bn_APost.Text = "A出牌";
            this.bn_APost.UseVisualStyleBackColor = true;
            // 
            // bn_PostB
            // 
            this.bn_PostB.Location = new System.Drawing.Point(109, 60);
            this.bn_PostB.Name = "bn_PostB";
            this.bn_PostB.Size = new System.Drawing.Size(75, 23);
            this.bn_PostB.TabIndex = 3;
            this.bn_PostB.Text = "B出牌";
            this.bn_PostB.UseVisualStyleBackColor = true;
            // 
            // bn_PostC
            // 
            this.bn_PostC.Location = new System.Drawing.Point(209, 60);
            this.bn_PostC.Name = "bn_PostC";
            this.bn_PostC.Size = new System.Drawing.Size(75, 23);
            this.bn_PostC.TabIndex = 4;
            this.bn_PostC.Text = "C出牌";
            this.bn_PostC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "结束";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bn_CallBoss
            // 
            this.bn_CallBoss.Location = new System.Drawing.Point(209, 13);
            this.bn_CallBoss.Name = "bn_CallBoss";
            this.bn_CallBoss.Size = new System.Drawing.Size(75, 23);
            this.bn_CallBoss.TabIndex = 6;
            this.bn_CallBoss.Text = "Call Boss";
            this.bn_CallBoss.UseVisualStyleBackColor = true;
            this.bn_CallBoss.Click += new System.EventHandler(this.bn_CallBoss_Click);
            // 
            // bn_One
            // 
            this.bn_One.Location = new System.Drawing.Point(12, 106);
            this.bn_One.Name = "bn_One";
            this.bn_One.Size = new System.Drawing.Size(75, 23);
            this.bn_One.TabIndex = 7;
            this.bn_One.Text = "1 分";
            this.bn_One.UseVisualStyleBackColor = true;
            this.bn_One.Click += new System.EventHandler(this.bn_One_Click);
            // 
            // bn_Two
            // 
            this.bn_Two.Location = new System.Drawing.Point(109, 105);
            this.bn_Two.Name = "bn_Two";
            this.bn_Two.Size = new System.Drawing.Size(75, 23);
            this.bn_Two.TabIndex = 8;
            this.bn_Two.Text = "2 分";
            this.bn_Two.UseVisualStyleBackColor = true;
            this.bn_Two.Click += new System.EventHandler(this.bn_Two_Click);
            // 
            // bn_Three
            // 
            this.bn_Three.Location = new System.Drawing.Point(209, 106);
            this.bn_Three.Name = "bn_Three";
            this.bn_Three.Size = new System.Drawing.Size(75, 23);
            this.bn_Three.TabIndex = 9;
            this.bn_Three.Text = "3 分";
            this.bn_Three.UseVisualStyleBackColor = true;
            this.bn_Three.Click += new System.EventHandler(this.bn_Three_Click);
            // 
            // ConsoleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 218);
            this.Controls.Add(this.bn_Three);
            this.Controls.Add(this.bn_Two);
            this.Controls.Add(this.bn_One);
            this.Controls.Add(this.bn_CallBoss);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bn_PostC);
            this.Controls.Add(this.bn_PostB);
            this.Controls.Add(this.bn_APost);
            this.Controls.Add(this.Bn_Begin);
            this.Controls.Add(this.bn_Reset);
            this.Name = "ConsoleMain";
            this.Text = "Console";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_Reset;
        private System.Windows.Forms.Button Bn_Begin;
        private System.Windows.Forms.Button bn_APost;
        private System.Windows.Forms.Button bn_PostB;
        private System.Windows.Forms.Button bn_PostC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bn_CallBoss;
        private System.Windows.Forms.Button bn_One;
        private System.Windows.Forms.Button bn_Two;
        private System.Windows.Forms.Button bn_Three;
    }
}