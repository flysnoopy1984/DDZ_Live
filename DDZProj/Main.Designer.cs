namespace DDZProj
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.animator1 = new AnimatorNS.Animator(this.components);
            this._Begin_YXKS = new DDZProj.Effect.Begin_YXKS();
            this._Begin_DXJ = new DDZProj.Effect.Begin_DXJ();
            this.SuspendLayout();
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
            this.animator1.Interval = 1;
            this.animator1.TimeStep = 0.006F;
            this.animator1.AnimationCompleted += new System.EventHandler<AnimatorNS.AnimationCompletedEventArg>(this.animator1_AnimationCompleted);
            // 
            // _Begin_YXKS
            // 
            this._Begin_YXKS.BackColor = System.Drawing.Color.Transparent;
            this._Begin_YXKS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_Begin_YXKS.BackgroundImage")));
            this._Begin_YXKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this._Begin_YXKS, AnimatorNS.DecorationType.None);
            this._Begin_YXKS.Location = new System.Drawing.Point(30, 311);
            this._Begin_YXKS.Name = "_Begin_YXKS";
            this._Begin_YXKS.Size = new System.Drawing.Size(660, 154);
            this._Begin_YXKS.TabIndex = 2;
            this._Begin_YXKS.Visible = false;
            this._Begin_YXKS.Move += new System.EventHandler(this._Begin_YXKS_Move);
            // 
            // _Begin_DXJ
            // 
            this._Begin_DXJ.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this._Begin_DXJ, AnimatorNS.DecorationType.None);
            this._Begin_DXJ.Location = new System.Drawing.Point(461, 484);
            this._Begin_DXJ.Name = "_Begin_DXJ";
            this._Begin_DXJ.Size = new System.Drawing.Size(560, 200);
            this._Begin_DXJ.TabIndex = 1;
            this._Begin_DXJ.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1171, 696);
            this.Controls.Add(this._Begin_YXKS);
            this.Controls.Add(this._Begin_DXJ);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private AnimatorNS.Animator animator1;
        private Effect.Begin_DXJ _Begin_DXJ;
        private Effect.Begin_YXKS _Begin_YXKS;

    }
}

