using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestApp
{
	public class AnimationsSampleSelector : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private Gradients.GradientBorderButton _buttonSample1;
		private Gradients.GradientBorderButton _buttonSample2;
		private Gradients.GradientBorderButton _buttonSample3;
		private Animations.FormOpacityAnimator _opacityAnimator;
		private Animations.ControlBoundsAnimator _formBoundsAnimator;
		private Animations.ControlBoundsAnimator _sample1BoundsAnimator;
		private Animations.ControlBoundsAnimator _sample2BoundsAnimator;
		private Animations.ControlBoundsAnimator _sample3BoundsAnimator;
		private Animations.ControlBoundsAnimator _sample4BoundsAnimator;
		private Gradients.GradientBorderButton _buttonSample4;

		public AnimationsSampleSelector()
		{
			InitializeComponent();

//			_sample1BoundsController.EndBounds = _buttonSample1.Bounds;
//			_sample2BoundsController.EndBounds = _buttonSample2.Bounds;
//			_sample3BoundsController.EndBounds = _buttonSample3.Bounds;
//			_sample4BoundsController.EndBounds = _buttonSample4.Bounds;
//
//			_buttonSample1.Bounds = new Rectangle(_buttonSample1.Left, _buttonSample1.Top, 0, 0);
//			_buttonSample2.Bounds = new Rectangle(_buttonSample2.Right, _buttonSample2.Top, 0, 0);
//			_buttonSample3.Bounds = new Rectangle(_buttonSample3.Right, _buttonSample3.Bottom, 0, 0);
//			_buttonSample4.Bounds = new Rectangle(_buttonSample4.Left, _buttonSample4.Bottom, 0, 0);
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AnimationsSampleSelector));
			this._buttonSample1 = new Gradients.GradientBorderButton();
			this._buttonSample2 = new Gradients.GradientBorderButton();
			this._buttonSample3 = new Gradients.GradientBorderButton();
			this._buttonSample4 = new Gradients.GradientBorderButton();
			this._opacityAnimator = new Animations.FormOpacityAnimator(this.components);
			this._formBoundsAnimator = new Animations.ControlBoundsAnimator(this.components);
			this._sample1BoundsAnimator = new Animations.ControlBoundsAnimator(this.components);
			this._sample2BoundsAnimator = new Animations.ControlBoundsAnimator(this.components);
			this._sample3BoundsAnimator = new Animations.ControlBoundsAnimator(this.components);
			this._sample4BoundsAnimator = new Animations.ControlBoundsAnimator(this.components);
			((System.ComponentModel.ISupportInitialize)(this._opacityAnimator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._formBoundsAnimator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._sample1BoundsAnimator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._sample2BoundsAnimator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._sample3BoundsAnimator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._sample4BoundsAnimator)).BeginInit();
			this.SuspendLayout();
			// 
			// _buttonSample1
			// 
			this._buttonSample1.AnimationIntervall = 10;
			this._buttonSample1.AnimationStepSize = 5;
			this._buttonSample1.BackColor = System.Drawing.Color.Transparent;
			this._buttonSample1.BorderWidthFocused = 10;
			this._buttonSample1.BorderWidthUnfocused = 20;
			this._buttonSample1.DockPadding.All = 20;
			this._buttonSample1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._buttonSample1.ForeColor = System.Drawing.Color.White;
			this._buttonSample1.ForeColorFocused = System.Drawing.Color.Black;
			this._buttonSample1.ForeColorUnfocused = System.Drawing.Color.White;
			this._buttonSample1.InnerColor = System.Drawing.Color.DarkGreen;
			this._buttonSample1.InnerColorFocused = System.Drawing.Color.LawnGreen;
			this._buttonSample1.InnerColorUnfocused = System.Drawing.Color.DarkGreen;
			this._buttonSample1.IsAnimationEnabled = true;
			this._buttonSample1.Location = new System.Drawing.Point(0, 88);
			this._buttonSample1.Name = "_buttonSample1";
			this._buttonSample1.Size = new System.Drawing.Size(0, 0);
			this._buttonSample1.TabIndex = 0;
			this._buttonSample1.Text = "Sample 1";
			this._buttonSample1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._buttonSample1.InnerAreaClick += new System.EventHandler(this.OnSample1InnerAreaClick);
			// 
			// _buttonSample2
			// 
			this._buttonSample2.AnimationIntervall = 10;
			this._buttonSample2.AnimationStepSize = 5;
			this._buttonSample2.BackColor = System.Drawing.Color.Transparent;
			this._buttonSample2.BorderWidthFocused = 10;
			this._buttonSample2.BorderWidthUnfocused = 20;
			this._buttonSample2.DockPadding.All = 20;
			this._buttonSample2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._buttonSample2.ForeColor = System.Drawing.Color.White;
			this._buttonSample2.ForeColorFocused = System.Drawing.Color.Black;
			this._buttonSample2.ForeColorUnfocused = System.Drawing.Color.White;
			this._buttonSample2.InnerColor = System.Drawing.Color.DarkGreen;
			this._buttonSample2.InnerColorFocused = System.Drawing.Color.LawnGreen;
			this._buttonSample2.InnerColorUnfocused = System.Drawing.Color.DarkGreen;
			this._buttonSample2.IsAnimationEnabled = true;
			this._buttonSample2.Location = new System.Drawing.Point(208, 88);
			this._buttonSample2.Name = "_buttonSample2";
			this._buttonSample2.Size = new System.Drawing.Size(0, 0);
			this._buttonSample2.TabIndex = 0;
			this._buttonSample2.Text = "Sample 2";
			this._buttonSample2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._buttonSample2.InnerAreaClick += new System.EventHandler(this.OnSample2InnerAreaClick);
			// 
			// _buttonSample3
			// 
			this._buttonSample3.AnimationIntervall = 10;
			this._buttonSample3.AnimationStepSize = 5;
			this._buttonSample3.BackColor = System.Drawing.Color.Transparent;
			this._buttonSample3.BorderWidthFocused = 10;
			this._buttonSample3.BorderWidthUnfocused = 20;
			this._buttonSample3.DockPadding.All = 20;
			this._buttonSample3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._buttonSample3.ForeColor = System.Drawing.Color.White;
			this._buttonSample3.ForeColorFocused = System.Drawing.Color.Black;
			this._buttonSample3.ForeColorUnfocused = System.Drawing.Color.White;
			this._buttonSample3.InnerColor = System.Drawing.Color.DarkGreen;
			this._buttonSample3.InnerColorFocused = System.Drawing.Color.LawnGreen;
			this._buttonSample3.InnerColorUnfocused = System.Drawing.Color.DarkGreen;
			this._buttonSample3.IsAnimationEnabled = true;
			this._buttonSample3.Location = new System.Drawing.Point(320, 136);
			this._buttonSample3.Name = "_buttonSample3";
			this._buttonSample3.Size = new System.Drawing.Size(0, 0);
			this._buttonSample3.TabIndex = 0;
			this._buttonSample3.Text = "Sample 3";
			this._buttonSample3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._buttonSample3.InnerAreaClick += new System.EventHandler(this.OnSample3InnerAreaClick);
			// 
			// _buttonSample4
			// 
			this._buttonSample4.AnimationIntervall = 10;
			this._buttonSample4.AnimationStepSize = 5;
			this._buttonSample4.BackColor = System.Drawing.Color.Transparent;
			this._buttonSample4.BorderWidthFocused = 10;
			this._buttonSample4.BorderWidthUnfocused = 20;
			this._buttonSample4.DockPadding.All = 20;
			this._buttonSample4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._buttonSample4.ForeColor = System.Drawing.Color.White;
			this._buttonSample4.ForeColorFocused = System.Drawing.Color.Black;
			this._buttonSample4.ForeColorUnfocused = System.Drawing.Color.White;
			this._buttonSample4.InnerColor = System.Drawing.Color.DarkGreen;
			this._buttonSample4.InnerColorFocused = System.Drawing.Color.LawnGreen;
			this._buttonSample4.InnerColorUnfocused = System.Drawing.Color.DarkGreen;
			this._buttonSample4.IsAnimationEnabled = true;
			this._buttonSample4.Location = new System.Drawing.Point(336, 136);
			this._buttonSample4.Name = "_buttonSample4";
			this._buttonSample4.Size = new System.Drawing.Size(0, 0);
			this._buttonSample4.TabIndex = 0;
			this._buttonSample4.Text = "Sample 4";
			this._buttonSample4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._buttonSample4.InnerAreaClick += new System.EventHandler(this.OnSample4InnerAreaClick);
			// 
			// _opacityAnimator
			// 
			this._opacityAnimator.Form = this;
			this._opacityAnimator.NeverEndingTimer = false;
			this._opacityAnimator.StartOpacity = 0;
			// 
			// _formBoundsAnimator
			// 
			this._formBoundsAnimator.Control = this;
			this._formBoundsAnimator.EndBounds = new System.Drawing.Rectangle(13, 13, 448, 168);
			this._formBoundsAnimator.NeverEndingTimer = false;
			this._formBoundsAnimator.ParentAnimator = this._opacityAnimator;
			this._formBoundsAnimator.StartBounds = new System.Drawing.Rectangle(13, 13, 8, 8);
			// 
			// _sample1BoundsAnimator
			// 
			this._sample1BoundsAnimator.Control = this._buttonSample1;
			this._sample1BoundsAnimator.EndBounds = new System.Drawing.Rectangle(0, 88, 104, 56);
			this._sample1BoundsAnimator.NeverEndingTimer = false;
			this._sample1BoundsAnimator.StartBounds = new System.Drawing.Rectangle(0, 88, 8, 8);
			this._sample1BoundsAnimator.TriggerAnimator = this._opacityAnimator;
			// 
			// _sample2BoundsAnimator
			// 
			this._sample2BoundsAnimator.Control = this._buttonSample2;
			this._sample2BoundsAnimator.EndBounds = new System.Drawing.Rectangle(112, 88, 104, 56);
			this._sample2BoundsAnimator.NeverEndingTimer = false;
			this._sample2BoundsAnimator.ParentAnimator = this._sample1BoundsAnimator;
			this._sample2BoundsAnimator.StartBounds = new System.Drawing.Rectangle(208, 88, 8, 8);
			// 
			// _sample3BoundsAnimator
			// 
			this._sample3BoundsAnimator.Control = this._buttonSample3;
			this._sample3BoundsAnimator.EndBounds = new System.Drawing.Rectangle(224, 88, 104, 56);
			this._sample3BoundsAnimator.NeverEndingTimer = false;
			this._sample3BoundsAnimator.ParentAnimator = this._sample1BoundsAnimator;
			this._sample3BoundsAnimator.StartBounds = new System.Drawing.Rectangle(320, 136, 8, 8);
			// 
			// _sample4BoundsAnimator
			// 
			this._sample4BoundsAnimator.Control = this._buttonSample4;
			this._sample4BoundsAnimator.EndBounds = new System.Drawing.Rectangle(336, 88, 104, 56);
			this._sample4BoundsAnimator.NeverEndingTimer = false;
			this._sample4BoundsAnimator.ParentAnimator = this._sample1BoundsAnimator;
			this._sample4BoundsAnimator.StartBounds = new System.Drawing.Rectangle(336, 136, 8, 8);
			// 
			// AnimationsSampleSelector
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(442, 143);
			this.Controls.Add(this._buttonSample1);
			this.Controls.Add(this._buttonSample2);
			this.Controls.Add(this._buttonSample3);
			this.Controls.Add(this._buttonSample4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AnimationsSampleSelector";
			this.Opacity = 0;
			this.Text = "AnimationsSampleSelector";
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this._opacityAnimator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._formBoundsAnimator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._sample1BoundsAnimator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._sample2BoundsAnimator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._sample3BoundsAnimator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._sample4BoundsAnimator)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void OnSample1InnerAreaClick(object sender, System.EventArgs e)
		{
			new AnimationsSample1().Show();
		}

		private void OnSample2InnerAreaClick(object sender, System.EventArgs e)
		{
			new AnimationsSample2().Show();
		}

		private void OnLoad(object sender, System.EventArgs e)
		{
//			_opacityAnimator.SetCurrentValuesToStartValues();
//			_opacityAnimator.Start();
			_formBoundsAnimator.EndBounds = this.Bounds;
			this.Bounds = new Rectangle(this.Location, new Size(216, 24));
			_opacityAnimator.Start();
		}

		private void OnSample3InnerAreaClick(object sender, System.EventArgs e)
		{
			new AnimationsSample3().Show();
		}

		private void OnSample4InnerAreaClick(object sender, System.EventArgs e)
		{
			new AnimationsSample4().Show();
		}
	}
}
