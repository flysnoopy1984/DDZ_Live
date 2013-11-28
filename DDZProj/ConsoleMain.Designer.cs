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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleMain));
            this.bn_Reset = new System.Windows.Forms.Button();
            this.Bn_Begin = new System.Windows.Forms.Button();
            this.bn_APost = new System.Windows.Forms.Button();
            this.bn_PostB = new System.Windows.Forms.Button();
            this.bn_PostC = new System.Windows.Forms.Button();
            this.bn_End = new System.Windows.Forms.Button();
            this.bn_One = new System.Windows.Forms.Button();
            this.bn_Two = new System.Windows.Forms.Button();
            this.bn_Three = new System.Windows.Forms.Button();
            this.tb_pokerInfo = new System.Windows.Forms.TextBox();
            this.p_pokerbutton = new System.Windows.Forms.Panel();
            this.bn_ChangePoker = new System.Windows.Forms.Button();
            this.bn_PostPoker = new System.Windows.Forms.Button();
            this.bn_CurrentArea = new System.Windows.Forms.Button();
            this.bn_Pass = new System.Windows.Forms.Button();
            this.lb_A = new System.Windows.Forms.ListBox();
            this.lb_B = new System.Windows.Forms.ListBox();
            this.lb_C = new System.Windows.Forms.ListBox();
            this.bn_Boom = new System.Windows.Forms.Button();
            this.bn_Test = new System.Windows.Forms.Button();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.bn_1n = new System.Windows.Forms.Button();
            this.bn_2n = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.animator1 = new AnimatorNS.Animator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_Reset
            // 
            this.animator1.SetDecoration(this.bn_Reset, AnimatorNS.DecorationType.None);
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
            this.animator1.SetDecoration(this.Bn_Begin, AnimatorNS.DecorationType.None);
            this.Bn_Begin.Location = new System.Drawing.Point(301, 56);
            this.Bn_Begin.Name = "Bn_Begin";
            this.Bn_Begin.Size = new System.Drawing.Size(75, 23);
            this.Bn_Begin.TabIndex = 1;
            this.Bn_Begin.Text = "开始";
            this.Bn_Begin.UseVisualStyleBackColor = true;
            this.Bn_Begin.Click += new System.EventHandler(this.Bn_Begin_Click);
            // 
            // bn_APost
            // 
            this.animator1.SetDecoration(this.bn_APost, AnimatorNS.DecorationType.None);
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
            this.animator1.SetDecoration(this.bn_PostB, AnimatorNS.DecorationType.None);
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
            this.animator1.SetDecoration(this.bn_PostC, AnimatorNS.DecorationType.None);
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
            this.animator1.SetDecoration(this.bn_End, AnimatorNS.DecorationType.None);
            this.bn_End.Location = new System.Drawing.Point(301, 105);
            this.bn_End.Name = "bn_End";
            this.bn_End.Size = new System.Drawing.Size(75, 23);
            this.bn_End.TabIndex = 5;
            this.bn_End.Text = "结束";
            this.bn_End.UseVisualStyleBackColor = true;
            this.bn_End.Click += new System.EventHandler(this.bn_End_Click);
            // 
            // bn_One
            // 
            this.animator1.SetDecoration(this.bn_One, AnimatorNS.DecorationType.None);
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
            this.animator1.SetDecoration(this.bn_Two, AnimatorNS.DecorationType.None);
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
            this.animator1.SetDecoration(this.bn_Three, AnimatorNS.DecorationType.None);
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
            this.animator1.SetDecoration(this.tb_pokerInfo, AnimatorNS.DecorationType.None);
            this.tb_pokerInfo.Location = new System.Drawing.Point(12, 341);
            this.tb_pokerInfo.Multiline = true;
            this.tb_pokerInfo.Name = "tb_pokerInfo";
            this.tb_pokerInfo.Size = new System.Drawing.Size(445, 83);
            this.tb_pokerInfo.TabIndex = 10;
            // 
            // p_pokerbutton
            // 
            this.animator1.SetDecoration(this.p_pokerbutton, AnimatorNS.DecorationType.None);
            this.p_pokerbutton.Location = new System.Drawing.Point(13, 259);
            this.p_pokerbutton.Name = "p_pokerbutton";
            this.p_pokerbutton.Size = new System.Drawing.Size(444, 76);
            this.p_pokerbutton.TabIndex = 11;
            // 
            // bn_ChangePoker
            // 
            this.animator1.SetDecoration(this.bn_ChangePoker, AnimatorNS.DecorationType.None);
            this.bn_ChangePoker.Location = new System.Drawing.Point(547, 12);
            this.bn_ChangePoker.Name = "bn_ChangePoker";
            this.bn_ChangePoker.Size = new System.Drawing.Size(89, 23);
            this.bn_ChangePoker.TabIndex = 12;
            this.bn_ChangePoker.Text = "ChangePoker";
            this.bn_ChangePoker.UseVisualStyleBackColor = true;
            this.bn_ChangePoker.Click += new System.EventHandler(this.bn_ChangePoker_Click);
            // 
            // bn_PostPoker
            // 
            this.animator1.SetDecoration(this.bn_PostPoker, AnimatorNS.DecorationType.None);
            this.bn_PostPoker.Location = new System.Drawing.Point(108, 169);
            this.bn_PostPoker.Name = "bn_PostPoker";
            this.bn_PostPoker.Size = new System.Drawing.Size(75, 23);
            this.bn_PostPoker.TabIndex = 14;
            this.bn_PostPoker.Text = "出牌";
            this.bn_PostPoker.UseVisualStyleBackColor = true;
            this.bn_PostPoker.Click += new System.EventHandler(this.bn_PostPoker_Click);
            // 
            // bn_CurrentArea
            // 
            this.animator1.SetDecoration(this.bn_CurrentArea, AnimatorNS.DecorationType.None);
            this.bn_CurrentArea.Location = new System.Drawing.Point(13, 169);
            this.bn_CurrentArea.Name = "bn_CurrentArea";
            this.bn_CurrentArea.Size = new System.Drawing.Size(75, 23);
            this.bn_CurrentArea.TabIndex = 15;
            this.bn_CurrentArea.Text = "当前出牌者";
            this.bn_CurrentArea.UseVisualStyleBackColor = true;
            this.bn_CurrentArea.Click += new System.EventHandler(this.bn_CurrentArea_Click);
            // 
            // bn_Pass
            // 
            this.animator1.SetDecoration(this.bn_Pass, AnimatorNS.DecorationType.None);
            this.bn_Pass.Location = new System.Drawing.Point(394, 57);
            this.bn_Pass.Name = "bn_Pass";
            this.bn_Pass.Size = new System.Drawing.Size(75, 23);
            this.bn_Pass.TabIndex = 16;
            this.bn_Pass.Text = "Pass";
            this.bn_Pass.UseVisualStyleBackColor = true;
            this.bn_Pass.Click += new System.EventHandler(this.bn_Pass_Click);
            // 
            // lb_A
            // 
            this.animator1.SetDecoration(this.lb_A, AnimatorNS.DecorationType.None);
            this.lb_A.FormattingEnabled = true;
            this.lb_A.Location = new System.Drawing.Point(12, 438);
            this.lb_A.Name = "lb_A";
            this.lb_A.Size = new System.Drawing.Size(272, 251);
            this.lb_A.TabIndex = 17;
            // 
            // lb_B
            // 
            this.animator1.SetDecoration(this.lb_B, AnimatorNS.DecorationType.None);
            this.lb_B.FormattingEnabled = true;
            this.lb_B.Location = new System.Drawing.Point(301, 438);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(272, 355);
            this.lb_B.TabIndex = 18;
            // 
            // lb_C
            // 
            this.animator1.SetDecoration(this.lb_C, AnimatorNS.DecorationType.None);
            this.lb_C.FormattingEnabled = true;
            this.lb_C.Location = new System.Drawing.Point(584, 438);
            this.lb_C.Name = "lb_C";
            this.lb_C.Size = new System.Drawing.Size(272, 355);
            this.lb_C.TabIndex = 19;
            // 
            // bn_Boom
            // 
            this.animator1.SetDecoration(this.bn_Boom, AnimatorNS.DecorationType.None);
            this.bn_Boom.Location = new System.Drawing.Point(681, 11);
            this.bn_Boom.Name = "bn_Boom";
            this.bn_Boom.Size = new System.Drawing.Size(75, 23);
            this.bn_Boom.TabIndex = 20;
            this.bn_Boom.Text = "Boom";
            this.bn_Boom.UseVisualStyleBackColor = true;
            this.bn_Boom.Click += new System.EventHandler(this.bn_Boom_Click);
            // 
            // bn_Test
            // 
            this.animator1.SetDecoration(this.bn_Test, AnimatorNS.DecorationType.None);
            this.bn_Test.Location = new System.Drawing.Point(692, 56);
            this.bn_Test.Name = "bn_Test";
            this.bn_Test.Size = new System.Drawing.Size(75, 23);
            this.bn_Test.TabIndex = 21;
            this.bn_Test.Text = "Test";
            this.bn_Test.UseVisualStyleBackColor = true;
            this.bn_Test.Click += new System.EventHandler(this.bn_Test_Click);
            // 
            // pb_Image
            // 
            this.animator1.SetDecoration(this.pb_Image, AnimatorNS.DecorationType.None);
            this.pb_Image.Location = new System.Drawing.Point(681, 123);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(133, 130);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 22;
            this.pb_Image.TabStop = false;
            // 
            // bn_1n
            // 
            this.animator1.SetDecoration(this.bn_1n, AnimatorNS.DecorationType.None);
            this.bn_1n.Location = new System.Drawing.Point(11, 105);
            this.bn_1n.Name = "bn_1n";
            this.bn_1n.Size = new System.Drawing.Size(75, 23);
            this.bn_1n.TabIndex = 23;
            this.bn_1n.Text = "1号";
            this.bn_1n.UseVisualStyleBackColor = true;
            this.bn_1n.Click += new System.EventHandler(this.bn_1n_Click);
            // 
            // bn_2n
            // 
            this.animator1.SetDecoration(this.bn_2n, AnimatorNS.DecorationType.None);
            this.bn_2n.Location = new System.Drawing.Point(108, 105);
            this.bn_2n.Name = "bn_2n";
            this.bn_2n.Size = new System.Drawing.Size(75, 23);
            this.bn_2n.TabIndex = 24;
            this.bn_2n.Text = "2号";
            this.bn_2n.UseVisualStyleBackColor = true;
            this.bn_2n.Click += new System.EventHandler(this.bn_2n_Click);
            // 
            // button3
            // 
            this.animator1.SetDecoration(this.button3, AnimatorNS.DecorationType.None);
            this.button3.Location = new System.Drawing.Point(208, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "3号";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // ConsoleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 393);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bn_2n);
            this.Controls.Add(this.bn_1n);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.bn_Test);
            this.Controls.Add(this.bn_Boom);
            this.Controls.Add(this.lb_C);
            this.Controls.Add(this.lb_B);
            this.Controls.Add(this.lb_A);
            this.Controls.Add(this.bn_Pass);
            this.Controls.Add(this.bn_CurrentArea);
            this.Controls.Add(this.bn_PostPoker);
            this.Controls.Add(this.bn_ChangePoker);
            this.Controls.Add(this.p_pokerbutton);
            this.Controls.Add(this.tb_pokerInfo);
            this.Controls.Add(this.bn_Three);
            this.Controls.Add(this.bn_Two);
            this.Controls.Add(this.bn_One);
            this.Controls.Add(this.bn_End);
            this.Controls.Add(this.bn_PostC);
            this.Controls.Add(this.bn_PostB);
            this.Controls.Add(this.bn_APost);
            this.Controls.Add(this.Bn_Begin);
            this.Controls.Add(this.bn_Reset);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "ConsoleMain";
            this.Text = "Console";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
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
        private System.Windows.Forms.Button bn_One;
        private System.Windows.Forms.Button bn_Two;
        private System.Windows.Forms.Button bn_Three;
        private System.Windows.Forms.TextBox tb_pokerInfo;
        private System.Windows.Forms.Panel p_pokerbutton;
        private System.Windows.Forms.Button bn_ChangePoker;
        private System.Windows.Forms.Button bn_PostPoker;
        private System.Windows.Forms.Button bn_CurrentArea;
        private System.Windows.Forms.Button bn_Pass;
        private System.Windows.Forms.ListBox lb_A;
        private System.Windows.Forms.ListBox lb_B;
        private System.Windows.Forms.ListBox lb_C;
        private System.Windows.Forms.Button bn_Boom;
        private System.Windows.Forms.Button bn_Test;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button bn_1n;
        private System.Windows.Forms.Button bn_2n;
        private System.Windows.Forms.Button button3;
        private AnimatorNS.Animator animator1;
    }
}