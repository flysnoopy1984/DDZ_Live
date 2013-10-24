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
            this.bn_End = new System.Windows.Forms.Button();
            this.bn_CallBoss = new System.Windows.Forms.Button();
            this.bn_One = new System.Windows.Forms.Button();
            this.bn_Two = new System.Windows.Forms.Button();
            this.bn_Three = new System.Windows.Forms.Button();
            this.tb_pokerInfo = new System.Windows.Forms.TextBox();
            this.p_pokerbutton = new System.Windows.Forms.Panel();
            this.bn_ChangePoker = new System.Windows.Forms.Button();
            this.bn_Start = new System.Windows.Forms.Button();
            this.bn_PostPoker = new System.Windows.Forms.Button();
            this.bn_CurrentArea = new System.Windows.Forms.Button();
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
            this.bn_APost.Location = new System.Drawing.Point(561, 57);
            this.bn_APost.Name = "bn_APost";
            this.bn_APost.Size = new System.Drawing.Size(75, 23);
            this.bn_APost.TabIndex = 2;
            this.bn_APost.Text = "A牌";
            this.bn_APost.UseVisualStyleBackColor = true;
            this.bn_APost.Click += new System.EventHandler(this.bn_APost_Click);
            // 
            // bn_PostB
            // 
            this.bn_PostB.Location = new System.Drawing.Point(561, 105);
            this.bn_PostB.Name = "bn_PostB";
            this.bn_PostB.Size = new System.Drawing.Size(75, 23);
            this.bn_PostB.TabIndex = 3;
            this.bn_PostB.Text = "B牌";
            this.bn_PostB.UseVisualStyleBackColor = true;
            this.bn_PostB.Click += new System.EventHandler(this.bn_PostB_Click);
            // 
            // bn_PostC
            // 
            this.bn_PostC.Location = new System.Drawing.Point(561, 150);
            this.bn_PostC.Name = "bn_PostC";
            this.bn_PostC.Size = new System.Drawing.Size(75, 23);
            this.bn_PostC.TabIndex = 4;
            this.bn_PostC.Text = "C牌";
            this.bn_PostC.UseVisualStyleBackColor = true;
            this.bn_PostC.Click += new System.EventHandler(this.bn_PostC_Click);
            // 
            // bn_End
            // 
            this.bn_End.Location = new System.Drawing.Point(393, 12);
            this.bn_End.Name = "bn_End";
            this.bn_End.Size = new System.Drawing.Size(75, 23);
            this.bn_End.TabIndex = 5;
            this.bn_End.Text = "结束";
            this.bn_End.UseVisualStyleBackColor = true;
            this.bn_End.Click += new System.EventHandler(this.bn_End_Click);
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
            this.bn_One.Location = new System.Drawing.Point(11, 57);
            this.bn_One.Name = "bn_One";
            this.bn_One.Size = new System.Drawing.Size(75, 23);
            this.bn_One.TabIndex = 7;
            this.bn_One.Text = "1 分";
            this.bn_One.UseVisualStyleBackColor = true;
            this.bn_One.Click += new System.EventHandler(this.bn_One_Click);
            // 
            // bn_Two
            // 
            this.bn_Two.Location = new System.Drawing.Point(108, 56);
            this.bn_Two.Name = "bn_Two";
            this.bn_Two.Size = new System.Drawing.Size(75, 23);
            this.bn_Two.TabIndex = 8;
            this.bn_Two.Text = "2 分";
            this.bn_Two.UseVisualStyleBackColor = true;
            this.bn_Two.Click += new System.EventHandler(this.bn_Two_Click);
            // 
            // bn_Three
            // 
            this.bn_Three.Location = new System.Drawing.Point(208, 57);
            this.bn_Three.Name = "bn_Three";
            this.bn_Three.Size = new System.Drawing.Size(75, 23);
            this.bn_Three.TabIndex = 9;
            this.bn_Three.Text = "3 分";
            this.bn_Three.UseVisualStyleBackColor = true;
            this.bn_Three.Click += new System.EventHandler(this.bn_Three_Click);
            // 
            // tb_pokerInfo
            // 
            this.tb_pokerInfo.Location = new System.Drawing.Point(12, 232);
            this.tb_pokerInfo.Multiline = true;
            this.tb_pokerInfo.Name = "tb_pokerInfo";
            this.tb_pokerInfo.Size = new System.Drawing.Size(445, 40);
            this.tb_pokerInfo.TabIndex = 10;
            // 
            // p_pokerbutton
            // 
            this.p_pokerbutton.Location = new System.Drawing.Point(13, 150);
            this.p_pokerbutton.Name = "p_pokerbutton";
            this.p_pokerbutton.Size = new System.Drawing.Size(444, 76);
            this.p_pokerbutton.TabIndex = 11;
            // 
            // bn_ChangePoker
            // 
            this.bn_ChangePoker.Location = new System.Drawing.Point(547, 12);
            this.bn_ChangePoker.Name = "bn_ChangePoker";
            this.bn_ChangePoker.Size = new System.Drawing.Size(89, 23);
            this.bn_ChangePoker.TabIndex = 12;
            this.bn_ChangePoker.Text = "ChangePoker";
            this.bn_ChangePoker.UseVisualStyleBackColor = true;
            this.bn_ChangePoker.Click += new System.EventHandler(this.bn_ChangePoker_Click);
            // 
            // bn_Start
            // 
            this.bn_Start.Location = new System.Drawing.Point(301, 13);
            this.bn_Start.Name = "bn_Start";
            this.bn_Start.Size = new System.Drawing.Size(75, 23);
            this.bn_Start.TabIndex = 13;
            this.bn_Start.Text = "Start";
            this.bn_Start.UseVisualStyleBackColor = true;
            this.bn_Start.Click += new System.EventHandler(this.bn_Start_Click);
            // 
            // bn_PostPoker
            // 
            this.bn_PostPoker.Location = new System.Drawing.Point(493, 230);
            this.bn_PostPoker.Name = "bn_PostPoker";
            this.bn_PostPoker.Size = new System.Drawing.Size(75, 23);
            this.bn_PostPoker.TabIndex = 14;
            this.bn_PostPoker.Text = "出牌";
            this.bn_PostPoker.UseVisualStyleBackColor = true;
            this.bn_PostPoker.Click += new System.EventHandler(this.bn_PostPoker_Click);
            // 
            // bn_CurrentArea
            // 
            this.bn_CurrentArea.Location = new System.Drawing.Point(13, 105);
            this.bn_CurrentArea.Name = "bn_CurrentArea";
            this.bn_CurrentArea.Size = new System.Drawing.Size(75, 23);
            this.bn_CurrentArea.TabIndex = 15;
            this.bn_CurrentArea.Text = "当前出牌者";
            this.bn_CurrentArea.UseVisualStyleBackColor = true;
            this.bn_CurrentArea.Click += new System.EventHandler(this.bn_CurrentArea_Click);
            // 
            // ConsoleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 310);
            this.Controls.Add(this.bn_CurrentArea);
            this.Controls.Add(this.bn_PostPoker);
            this.Controls.Add(this.bn_Start);
            this.Controls.Add(this.bn_ChangePoker);
            this.Controls.Add(this.p_pokerbutton);
            this.Controls.Add(this.tb_pokerInfo);
            this.Controls.Add(this.bn_Three);
            this.Controls.Add(this.bn_Two);
            this.Controls.Add(this.bn_One);
            this.Controls.Add(this.bn_CallBoss);
            this.Controls.Add(this.bn_End);
            this.Controls.Add(this.bn_PostC);
            this.Controls.Add(this.bn_PostB);
            this.Controls.Add(this.bn_APost);
            this.Controls.Add(this.Bn_Begin);
            this.Controls.Add(this.bn_Reset);
            this.Name = "ConsoleMain";
            this.Text = "Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_Reset;
        private System.Windows.Forms.Button Bn_Begin;
        private System.Windows.Forms.Button bn_APost;
        private System.Windows.Forms.Button bn_PostB;
        private System.Windows.Forms.Button bn_PostC;
        private System.Windows.Forms.Button bn_End;
        private System.Windows.Forms.Button bn_CallBoss;
        private System.Windows.Forms.Button bn_One;
        private System.Windows.Forms.Button bn_Two;
        private System.Windows.Forms.Button bn_Three;
        private System.Windows.Forms.TextBox tb_pokerInfo;
        private System.Windows.Forms.Panel p_pokerbutton;
        private System.Windows.Forms.Button bn_ChangePoker;
        private System.Windows.Forms.Button bn_Start;
        private System.Windows.Forms.Button bn_PostPoker;
        private System.Windows.Forms.Button bn_CurrentArea;
    }
}