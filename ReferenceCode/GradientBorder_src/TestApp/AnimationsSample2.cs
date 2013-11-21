using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestApp
{
	public class AnimationsSample2 : System.Windows.Forms.Form
	{
		private Gradients.GradientBorderButton _gb1;
		private Gradients.GradientBorderButton _gb2;
		private Gradients.GradientBorderButton _gb3;
		private Gradients.GradientBorderButton _gb5;
		private Gradients.GradientBorderButton _gb4;
		private Gradients.GradientBorderInnerColorAnimator _animator1;
		private Gradients.GradientBorderInnerColorAnimator _animator2;
		private Gradients.GradientBorderInnerColorAnimator _animator3;
		private Gradients.GradientBorderInnerColorAnimator _animator4;
		private Gradients.GradientBorderInnerColorAnimator _animator5;
		private TestApp.AnimatorSample2HelpControl _submenus1;
		private TestApp.AnimatorSample2HelpControl _submenus2;
		private TestApp.AnimatorSample2HelpControl _submenus4;
		private TestApp.AnimatorSample2HelpControl _submenus3;
		private TestApp.AnimatorSample2HelpControl _submenus5;
		private System.ComponentModel.IContainer components;

		public AnimationsSample2()
		{
			InitializeComponent();

			_animator1.StartColor = Color.FromArgb(0, _animator1.EndColor);
			_animator2.StartColor = Color.FromArgb(0, _animator2.EndColor);
			_animator3.StartColor = Color.FromArgb(0, _animator3.EndColor);
			_animator4.StartColor = Color.FromArgb(0, _animator4.EndColor);
			_animator5.StartColor = Color.FromArgb(0, _animator5.EndColor);

			_animator1.SetCurrentValuesToStartValues();
			_animator2.SetCurrentValuesToStartValues();
			_animator3.SetCurrentValuesToStartValues();
			_animator4.SetCurrentValuesToStartValues();
			_animator5.SetCurrentValuesToStartValues();

			_submenus1.SetCurrentValuesToStartValues();
			_submenus2.SetCurrentValuesToStartValues();
			_submenus3.SetCurrentValuesToStartValues();
			_submenus4.SetCurrentValuesToStartValues();
			_submenus5.SetCurrentValuesToStartValues();
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
			this._submenus1 = new TestApp.AnimatorSample2HelpControl();
			this._submenus2 = new TestApp.AnimatorSample2HelpControl();
			this._submenus4 = new TestApp.AnimatorSample2HelpControl();
			this._submenus3 = new TestApp.AnimatorSample2HelpControl();
			this._submenus5 = new TestApp.AnimatorSample2HelpControl();
			this._gb1 = new Gradients.GradientBorderButton();
			this._gb2 = new Gradients.GradientBorderButton();
			this._gb3 = new Gradients.GradientBorderButton();
			this._gb5 = new Gradients.GradientBorderButton();
			this._gb4 = new Gradients.GradientBorderButton();
			this._animator1 = new Gradients.GradientBorderInnerColorAnimator(this.components);
			this._animator2 = new Gradients.GradientBorderInnerColorAnimator(this.components);
			this._animator3 = new Gradients.GradientBorderInnerColorAnimator(this.components);
			this._animator4 = new Gradients.GradientBorderInnerColorAnimator(this.components);
			this._animator5 = new Gradients.GradientBorderInnerColorAnimator(this.components);
			((System.ComponentModel.ISupportInitialize)(this._animator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator5)).BeginInit();
			this.SuspendLayout();
			// 
			// _submenus1
			// 
			this._submenus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._submenus1.AnimationIntervall = 10;
			this._submenus1.AnimationStepSize = 2;
			this._submenus1.InnerColorBottom = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this._submenus1.InnerColorTop = System.Drawing.Color.Red;
			this._submenus1.Location = new System.Drawing.Point(8, 64);
			this._submenus1.Name = "_submenus1";
			this._submenus1.Size = new System.Drawing.Size(112, 360);
			this._submenus1.TabIndex = 0;
			// 
			// _submenus2
			// 
			this._submenus2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._submenus2.AnimationIntervall = 10;
			this._submenus2.AnimationStepSize = 3;
			this._submenus2.InnerColorBottom = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this._submenus2.InnerColorTop = System.Drawing.Color.Blue;
			this._submenus2.Location = new System.Drawing.Point(120, 64);
			this._submenus2.Name = "_submenus2";
			this._submenus2.Size = new System.Drawing.Size(112, 360);
			this._submenus2.TabIndex = 1;
			// 
			// _submenus4
			// 
			this._submenus4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._submenus4.AnimationIntervall = 10;
			this._submenus4.AnimationStepSize = 5;
			this._submenus4.InnerColorBottom = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(255)));
			this._submenus4.InnerColorTop = System.Drawing.Color.Magenta;
			this._submenus4.Location = new System.Drawing.Point(344, 64);
			this._submenus4.Name = "_submenus4";
			this._submenus4.Size = new System.Drawing.Size(112, 360);
			this._submenus4.TabIndex = 1;
			// 
			// _submenus3
			// 
			this._submenus3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._submenus3.AnimationIntervall = 10;
			this._submenus3.AnimationStepSize = 4;
			this._submenus3.InnerColorBottom = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this._submenus3.InnerColorTop = System.Drawing.Color.Yellow;
			this._submenus3.Location = new System.Drawing.Point(232, 64);
			this._submenus3.Name = "_submenus3";
			this._submenus3.Size = new System.Drawing.Size(112, 360);
			this._submenus3.TabIndex = 0;
			// 
			// _submenus5
			// 
			this._submenus5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._submenus5.AnimationIntervall = 10;
			this._submenus5.AnimationStepSize = 6;
			this._submenus5.InnerColorBottom = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this._submenus5.InnerColorTop = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this._submenus5.Location = new System.Drawing.Point(456, 64);
			this._submenus5.Name = "_submenus5";
			this._submenus5.Size = new System.Drawing.Size(112, 360);
			this._submenus5.TabIndex = 1;
			// 
			// _gb1
			// 
			this._gb1.AnimationIntervall = 20;
			this._gb1.AnimationStepSize = 20;
			this._gb1.BackColor = System.Drawing.Color.Transparent;
			this._gb1.BorderWidth = 15;
			this._gb1.BorderWidthFocused = 5;
			this._gb1.BorderWidthUnfocused = 15;
			this._gb1.DockPadding.All = 15;
			this._gb1.ForeColor = System.Drawing.SystemColors.Control;
			this._gb1.ForeColorFocused = System.Drawing.Color.White;
			this._gb1.ForeColorUnfocused = System.Drawing.SystemColors.Control;
			this._gb1.InnerColor = System.Drawing.Color.Maroon;
			this._gb1.InnerColorFocused = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb1.InnerColorUnfocused = System.Drawing.Color.Maroon;
			this._gb1.IsAnimationEnabled = false;
			this._gb1.Location = new System.Drawing.Point(8, 0);
			this._gb1.Name = "_gb1";
			this._gb1.Size = new System.Drawing.Size(112, 48);
			this._gb1.TabIndex = 2;
			this._gb1.Text = "Topmenu 1";
			this._gb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb2
			// 
			this._gb2.AnimationIntervall = 20;
			this._gb2.AnimationStepSize = 20;
			this._gb2.BackColor = System.Drawing.Color.Transparent;
			this._gb2.BorderWidth = 15;
			this._gb2.BorderWidthFocused = 5;
			this._gb2.BorderWidthUnfocused = 15;
			this._gb2.DockPadding.All = 15;
			this._gb2.ForeColor = System.Drawing.SystemColors.Control;
			this._gb2.ForeColorFocused = System.Drawing.Color.White;
			this._gb2.ForeColorUnfocused = System.Drawing.SystemColors.Control;
			this._gb2.InnerColor = System.Drawing.Color.Navy;
			this._gb2.InnerColorFocused = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb2.InnerColorUnfocused = System.Drawing.Color.Navy;
			this._gb2.IsAnimationEnabled = false;
			this._gb2.Location = new System.Drawing.Point(120, 0);
			this._gb2.Name = "_gb2";
			this._gb2.Size = new System.Drawing.Size(112, 48);
			this._gb2.TabIndex = 3;
			this._gb2.Text = "Topmenu 2";
			this._gb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb3
			// 
			this._gb3.AnimationIntervall = 20;
			this._gb3.AnimationStepSize = 20;
			this._gb3.BackColor = System.Drawing.Color.Transparent;
			this._gb3.BorderWidth = 15;
			this._gb3.BorderWidthFocused = 5;
			this._gb3.BorderWidthUnfocused = 15;
			this._gb3.DockPadding.All = 15;
			this._gb3.ForeColor = System.Drawing.SystemColors.Control;
			this._gb3.ForeColorFocused = System.Drawing.Color.White;
			this._gb3.ForeColorUnfocused = System.Drawing.SystemColors.Control;
			this._gb3.InnerColor = System.Drawing.Color.Olive;
			this._gb3.InnerColorFocused = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb3.InnerColorUnfocused = System.Drawing.Color.Olive;
			this._gb3.IsAnimationEnabled = false;
			this._gb3.Location = new System.Drawing.Point(232, 0);
			this._gb3.Name = "_gb3";
			this._gb3.Size = new System.Drawing.Size(112, 48);
			this._gb3.TabIndex = 4;
			this._gb3.Text = "Topmenu 3";
			this._gb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb5
			// 
			this._gb5.AnimationIntervall = 20;
			this._gb5.AnimationStepSize = 20;
			this._gb5.BackColor = System.Drawing.Color.Transparent;
			this._gb5.BorderWidth = 15;
			this._gb5.BorderWidthFocused = 5;
			this._gb5.BorderWidthUnfocused = 15;
			this._gb5.DockPadding.All = 15;
			this._gb5.ForeColor = System.Drawing.SystemColors.Control;
			this._gb5.ForeColorFocused = System.Drawing.Color.White;
			this._gb5.ForeColorUnfocused = System.Drawing.SystemColors.Control;
			this._gb5.InnerColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb5.InnerColorFocused = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb5.InnerColorUnfocused = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb5.IsAnimationEnabled = false;
			this._gb5.Location = new System.Drawing.Point(456, 0);
			this._gb5.Name = "_gb5";
			this._gb5.Size = new System.Drawing.Size(112, 48);
			this._gb5.TabIndex = 5;
			this._gb5.Text = "Topmenu 5";
			this._gb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gb4
			// 
			this._gb4.AnimationIntervall = 20;
			this._gb4.AnimationStepSize = 20;
			this._gb4.BackColor = System.Drawing.Color.Transparent;
			this._gb4.BorderWidth = 15;
			this._gb4.BorderWidthFocused = 5;
			this._gb4.BorderWidthUnfocused = 15;
			this._gb4.DockPadding.All = 15;
			this._gb4.ForeColor = System.Drawing.SystemColors.Control;
			this._gb4.ForeColorFocused = System.Drawing.Color.White;
			this._gb4.ForeColorUnfocused = System.Drawing.SystemColors.Control;
			this._gb4.InnerColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(64)));
			this._gb4.InnerColorFocused = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._gb4.InnerColorUnfocused = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(64)));
			this._gb4.IsAnimationEnabled = false;
			this._gb4.Location = new System.Drawing.Point(344, 0);
			this._gb4.Name = "_gb4";
			this._gb4.Size = new System.Drawing.Size(112, 48);
			this._gb4.TabIndex = 6;
			this._gb4.Text = "Topmenu 4";
			this._gb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _animator1
			// 
			this._animator1.EndColor = System.Drawing.Color.Maroon;
			this._animator1.GradientBorder = this._gb1;
			this._animator1.StartColor = System.Drawing.Color.Maroon;
			this._animator1.AnimationFinished += new System.EventHandler(this.OnAnimatorFinished);
			// 
			// _animator2
			// 
			this._animator2.EndColor = System.Drawing.Color.Navy;
			this._animator2.GradientBorder = this._gb2;
			this._animator2.StartColor = System.Drawing.Color.Navy;
			this._animator2.AnimationFinished += new System.EventHandler(this.OnAnimatorFinished);
			// 
			// _animator3
			// 
			this._animator3.EndColor = System.Drawing.Color.Olive;
			this._animator3.GradientBorder = this._gb3;
			this._animator3.StartColor = System.Drawing.Color.Olive;
			this._animator3.AnimationFinished += new System.EventHandler(this.OnAnimatorFinished);
			// 
			// _animator4
			// 
			this._animator4.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(64)));
			this._animator4.GradientBorder = this._gb4;
			this._animator4.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(0)), ((System.Byte)(64)));
			this._animator4.AnimationFinished += new System.EventHandler(this.OnAnimatorFinished);
			// 
			// _animator5
			// 
			this._animator5.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._animator5.GradientBorder = this._gb5;
			this._animator5.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._animator5.AnimationFinished += new System.EventHandler(this.OnAnimatorFinished);
			// 
			// AnimationsSample2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(568, 429);
			this.Controls.Add(this._gb4);
			this.Controls.Add(this._gb5);
			this.Controls.Add(this._gb3);
			this.Controls.Add(this._gb2);
			this.Controls.Add(this._gb1);
			this.Controls.Add(this._submenus2);
			this.Controls.Add(this._submenus1);
			this.Controls.Add(this._submenus4);
			this.Controls.Add(this._submenus3);
			this.Controls.Add(this._submenus5);
			this.Name = "AnimationsSample2";
			this.Text = "AnimationsSample2";
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this._animator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator5)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void OnLoad(object sender, System.EventArgs e)
		{
			RestartAnimation();
		}

		private void RestartAnimation()
		{
			_animator1.Start();
		}

		private void OnAnimatorFinished(object sender, System.EventArgs e)
		{
			if (sender == _animator1)
			{
				_animator2.Start();
				_submenus1.Animate();
				_gb1.IsAnimationEnabled = true;
			} 
			else if (sender == _animator2)
			{
				_animator3.Start();
				_submenus2.Animate();
				_gb2.IsAnimationEnabled = true;
			} 
			else if (sender == _animator3)
			{
				_animator4.Start();
				_submenus3.Animate();
				_gb3.IsAnimationEnabled = true;
			} 
			else if (sender == _animator4)
			{
				_animator5.Start();
				_submenus4.Animate();
				_gb4.IsAnimationEnabled = true;
			}
			else if (sender == _animator5)
			{
				_submenus5.Animate();
				_gb5.IsAnimationEnabled = true;
			}
		}
	}
}
