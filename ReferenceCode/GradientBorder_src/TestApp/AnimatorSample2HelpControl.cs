using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace TestApp
{
	public class AnimatorSample2HelpControl : System.Windows.Forms.UserControl
	{
		private Gradients.GradientBorderButton _gb1;
		private Gradients.GradientBorderButton _gb3;
		private Gradients.GradientBorderButton _gb2;
		private Gradients.GradientBorderButton _gb4;
		private Gradients.GradientBorderButton _gb5;
		private Animations.ControlBoundsAnimator _animator1;
		private Animations.ControlBoundsAnimator _animator2;
		private Animations.ControlBoundsAnimator _animator3;
		private Animations.ControlBoundsAnimator _animator4;
		private Animations.ControlBoundsAnimator _animator5;
		private System.ComponentModel.IContainer components;

		public AnimatorSample2HelpControl()
		{
			InitializeComponent();

			_gb1.InnerColorFocused = Color.DarkGreen;
			_gb2.InnerColorFocused = Animations.AnimatorBase.InterpolateColors(Color.DarkGreen, Color.LightGreen, 25.0);
			_gb3.InnerColorFocused = Animations.AnimatorBase.InterpolateColors(Color.DarkGreen, Color.LightGreen, 50.0);
			_gb4.InnerColorFocused = Animations.AnimatorBase.InterpolateColors(Color.DarkGreen, Color.LightGreen, 75.0);
			_gb5.InnerColorFocused = Color.LightGreen;
		}

		public void SetCurrentValuesToStartValues()
		{
			_animator1.SetCurrentValuesToStartValues();
			_animator2.SetCurrentValuesToStartValues();
			_animator3.SetCurrentValuesToStartValues();
			_animator4.SetCurrentValuesToStartValues();
			_animator5.SetCurrentValuesToStartValues();
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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._gb1 = new Gradients.GradientBorderButton();
			this._gb3 = new Gradients.GradientBorderButton();
			this._gb2 = new Gradients.GradientBorderButton();
			this._gb4 = new Gradients.GradientBorderButton();
			this._gb5 = new Gradients.GradientBorderButton();
			this._animator1 = new Animations.ControlBoundsAnimator(this.components);
			this._animator2 = new Animations.ControlBoundsAnimator(this.components);
			this._animator3 = new Animations.ControlBoundsAnimator(this.components);
			this._animator4 = new Animations.ControlBoundsAnimator(this.components);
			this._animator5 = new Animations.ControlBoundsAnimator(this.components);
			((System.ComponentModel.ISupportInitialize)(this._animator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator5)).BeginInit();
			this.SuspendLayout();
			// 
			// _gb1
			// 
			this._gb1.AnimationIntervall = 10;
			this._gb1.AnimationStepSize = 10;
			this._gb1.BackColor = System.Drawing.Color.Transparent;
			this._gb1.BorderWidthFocused = 10;
			this._gb1.BorderWidthUnfocused = 20;
			this._gb1.Dock = System.Windows.Forms.DockStyle.Top;
			this._gb1.DockPadding.All = 20;
			this._gb1.ForeColorFocused = System.Drawing.Color.White;
			this._gb1.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gb1.InnerColor = System.Drawing.Color.Maroon;
			this._gb1.InnerColorFocused = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb1.InnerColorUnfocused = System.Drawing.Color.Maroon;
			this._gb1.IsAnimationEnabled = true;
			this._gb1.Location = new System.Drawing.Point(0, 0);
			this._gb1.Name = "_gb1";
			this._gb1.Size = new System.Drawing.Size(112, 72);
			this._gb1.TabIndex = 4;
			this._gb1.Text = "Submenu1";
			this._gb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb3
			// 
			this._gb3.AnimationIntervall = 10;
			this._gb3.AnimationStepSize = 10;
			this._gb3.BackColor = System.Drawing.Color.Transparent;
			this._gb3.BorderWidthFocused = 10;
			this._gb3.BorderWidthUnfocused = 20;
			this._gb3.Dock = System.Windows.Forms.DockStyle.Top;
			this._gb3.DockPadding.All = 20;
			this._gb3.ForeColorFocused = System.Drawing.Color.White;
			this._gb3.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gb3.InnerColor = System.Drawing.Color.Red;
			this._gb3.InnerColorFocused = System.Drawing.Color.Green;
			this._gb3.InnerColorUnfocused = System.Drawing.Color.Red;
			this._gb3.IsAnimationEnabled = true;
			this._gb3.Location = new System.Drawing.Point(0, 144);
			this._gb3.Name = "_gb3";
			this._gb3.Size = new System.Drawing.Size(112, 72);
			this._gb3.TabIndex = 5;
			this._gb3.Text = "Submenu3";
			this._gb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb2
			// 
			this._gb2.AnimationIntervall = 10;
			this._gb2.AnimationStepSize = 10;
			this._gb2.BackColor = System.Drawing.Color.Transparent;
			this._gb2.BorderWidthFocused = 10;
			this._gb2.BorderWidthUnfocused = 20;
			this._gb2.Dock = System.Windows.Forms.DockStyle.Top;
			this._gb2.DockPadding.All = 20;
			this._gb2.ForeColorFocused = System.Drawing.Color.White;
			this._gb2.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gb2.InnerColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this._gb2.InnerColorFocused = System.Drawing.Color.Green;
			this._gb2.InnerColorUnfocused = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this._gb2.IsAnimationEnabled = true;
			this._gb2.Location = new System.Drawing.Point(0, 72);
			this._gb2.Name = "_gb2";
			this._gb2.Size = new System.Drawing.Size(112, 72);
			this._gb2.TabIndex = 3;
			this._gb2.Text = "Submenu2";
			this._gb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb4
			// 
			this._gb4.AnimationIntervall = 10;
			this._gb4.AnimationStepSize = 10;
			this._gb4.BackColor = System.Drawing.Color.Transparent;
			this._gb4.BorderWidthFocused = 10;
			this._gb4.BorderWidthUnfocused = 20;
			this._gb4.Dock = System.Windows.Forms.DockStyle.Top;
			this._gb4.DockPadding.All = 20;
			this._gb4.ForeColorFocused = System.Drawing.Color.White;
			this._gb4.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gb4.InnerColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._gb4.InnerColorFocused = System.Drawing.Color.Green;
			this._gb4.InnerColorUnfocused = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			this._gb4.IsAnimationEnabled = true;
			this._gb4.Location = new System.Drawing.Point(0, 216);
			this._gb4.Name = "_gb4";
			this._gb4.Size = new System.Drawing.Size(112, 72);
			this._gb4.TabIndex = 1;
			this._gb4.Text = "Submenu4";
			this._gb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb5
			// 
			this._gb5.AnimationIntervall = 10;
			this._gb5.AnimationStepSize = 10;
			this._gb5.BackColor = System.Drawing.Color.Transparent;
			this._gb5.BorderWidthFocused = 10;
			this._gb5.BorderWidthUnfocused = 20;
			this._gb5.Dock = System.Windows.Forms.DockStyle.Top;
			this._gb5.DockPadding.All = 20;
			this._gb5.ForeColorFocused = System.Drawing.Color.White;
			this._gb5.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gb5.InnerColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this._gb5.InnerColorFocused = System.Drawing.Color.Green;
			this._gb5.InnerColorUnfocused = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this._gb5.IsAnimationEnabled = true;
			this._gb5.Location = new System.Drawing.Point(0, 288);
			this._gb5.Name = "_gb5";
			this._gb5.Size = new System.Drawing.Size(112, 72);
			this._gb5.TabIndex = 2;
			this._gb5.Text = "Submenu5";
			this._gb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _animator1
			// 
			this._animator1.AnimateWidth = false;
			this._animator1.AnimateX = false;
			this._animator1.AnimateY = false;
			this._animator1.Control = this._gb1;
			this._animator1.EndBounds = new System.Drawing.Rectangle(0, 0, 112, 72);
			this._animator1.StartBounds = new System.Drawing.Rectangle(0, 0, 112, 0);
			// 
			// _animator2
			// 
			this._animator2.AnimateWidth = false;
			this._animator2.AnimateX = false;
			this._animator2.AnimateY = false;
			this._animator2.Control = this._gb2;
			this._animator2.EndBounds = new System.Drawing.Rectangle(0, 72, 112, 72);
			this._animator2.StartBounds = new System.Drawing.Rectangle(0, 72, 112, 0);
			this._animator2.TriggerAnimator = this._animator1;
			// 
			// _animator3
			// 
			this._animator3.AnimateWidth = false;
			this._animator3.AnimateX = false;
			this._animator3.AnimateY = false;
			this._animator3.Control = this._gb3;
			this._animator3.EndBounds = new System.Drawing.Rectangle(0, 144, 112, 72);
			this._animator3.StartBounds = new System.Drawing.Rectangle(0, 144, 112, 0);
			this._animator3.TriggerAnimator = this._animator2;
			// 
			// _animator4
			// 
			this._animator4.AnimateWidth = false;
			this._animator4.AnimateX = false;
			this._animator4.AnimateY = false;
			this._animator4.Control = this._gb4;
			this._animator4.EndBounds = new System.Drawing.Rectangle(0, 216, 112, 72);
			this._animator4.StartBounds = new System.Drawing.Rectangle(0, 216, 112, 0);
			this._animator4.TriggerAnimator = this._animator3;
			// 
			// _animator5
			// 
			this._animator5.AnimateWidth = false;
			this._animator5.AnimateX = false;
			this._animator5.AnimateY = false;
			this._animator5.Control = this._gb5;
			this._animator5.EndBounds = new System.Drawing.Rectangle(0, 288, 112, 72);
			this._animator5.StartBounds = new System.Drawing.Rectangle(0, 288, 112, 0);
			this._animator5.TriggerAnimator = this._animator4;
			// 
			// AnimatorSample2HelpControl
			// 
			this.Controls.Add(this._gb5);
			this.Controls.Add(this._gb4);
			this.Controls.Add(this._gb3);
			this.Controls.Add(this._gb2);
			this.Controls.Add(this._gb1);
			this.Name = "AnimatorSample2HelpControl";
			this.Size = new System.Drawing.Size(112, 360);
			((System.ComponentModel.ISupportInitialize)(this._animator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator5)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public Color InnerColorTop 
		{
			get { return _gb1.InnerColorUnfocused; }
			set 
			{
				_gb1.InnerColorUnfocused = value;
				RecalcColors();
			}
		}

		public Color InnerColorBottom
		{
			get { return _gb5.InnerColorUnfocused; }
			set 
			{
				_gb5.InnerColorUnfocused = value;
				RecalcColors();
			}
		}

		public void Animate()
		{
			_animator1.SetCurrentValuesToStartValues();
			_animator2.SetCurrentValuesToStartValues();
			_animator3.SetCurrentValuesToStartValues();
			_animator4.SetCurrentValuesToStartValues();
			_animator5.SetCurrentValuesToStartValues();

			_animator1.Start();
		}

		public int AnimationIntervall 
		{
			get { return _animator1.Intervall; }
			set 
			{
				_animator1.Intervall = value;
				_animator2.Intervall = value;
				_animator3.Intervall = value;
				_animator4.Intervall = value;
				_animator5.Intervall = value;
			}
		}

		public double AnimationStepSize 
		{
			get { return _animator1.StepSize; }
			set 
			{
				_animator1.StepSize = value;
				_animator2.StepSize = value;
				_animator3.StepSize = value;
				_animator4.StepSize = value;
				_animator5.StepSize = value;
			}
		}

		private void RecalcColors()
		{
			_gb2.InnerColorUnfocused = Animations.AnimatorBase.InterpolateColors(InnerColorTop, InnerColorBottom, 25.0);
			_gb3.InnerColorUnfocused = Animations.AnimatorBase.InterpolateColors(InnerColorTop, InnerColorBottom, 50.0);
			_gb4.InnerColorUnfocused = Animations.AnimatorBase.InterpolateColors(InnerColorTop, InnerColorBottom, 75.0);
		}
	}
}
