using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestApp
{
	public class AnimationsSample4 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TrackBar _trackBar1;
		private System.Windows.Forms.TrackBar _trackBar7;
		private System.Windows.Forms.TrackBar _trackBar8;
		private System.Windows.Forms.TrackBar _trackBar2;
		private System.Windows.Forms.TrackBar _trackBar3;
		private System.Windows.Forms.TrackBar _trackBar4;
		private System.Windows.Forms.TrackBar _trackBar5;
		private System.Windows.Forms.TrackBar _trackBar6;
		private Animations.TrackBarValueAnimator _animator1;
		private Animations.TrackBarValueAnimator _animator2;
		private Animations.TrackBarValueAnimator _animator3;
		private Animations.TrackBarValueAnimator _animator4;
		private Animations.TrackBarValueAnimator _animator5;
		private Animations.TrackBarValueAnimator _animator6;
		private Animations.TrackBarValueAnimator _animator7;
		private Animations.TrackBarValueAnimator _animator8;
		private System.ComponentModel.IContainer components;

		public AnimationsSample4()
		{
			InitializeComponent();
		}

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
			this._trackBar1 = new System.Windows.Forms.TrackBar();
			this._trackBar7 = new System.Windows.Forms.TrackBar();
			this._trackBar8 = new System.Windows.Forms.TrackBar();
			this._trackBar2 = new System.Windows.Forms.TrackBar();
			this._trackBar3 = new System.Windows.Forms.TrackBar();
			this._trackBar4 = new System.Windows.Forms.TrackBar();
			this._trackBar5 = new System.Windows.Forms.TrackBar();
			this._trackBar6 = new System.Windows.Forms.TrackBar();
			this._animator1 = new Animations.TrackBarValueAnimator(this.components);
			this._animator2 = new Animations.TrackBarValueAnimator(this.components);
			this._animator3 = new Animations.TrackBarValueAnimator(this.components);
			this._animator4 = new Animations.TrackBarValueAnimator(this.components);
			this._animator5 = new Animations.TrackBarValueAnimator(this.components);
			this._animator6 = new Animations.TrackBarValueAnimator(this.components);
			this._animator7 = new Animations.TrackBarValueAnimator(this.components);
			this._animator8 = new Animations.TrackBarValueAnimator(this.components);
			((System.ComponentModel.ISupportInitialize)(this._trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._animator8)).BeginInit();
			this.SuspendLayout();
			// 
			// _trackBar1
			// 
			this._trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._trackBar1.Location = new System.Drawing.Point(16, 16);
			this._trackBar1.Maximum = 1000;
			this._trackBar1.Name = "_trackBar1";
			this._trackBar1.Size = new System.Drawing.Size(592, 42);
			this._trackBar1.TabIndex = 0;
			this._trackBar1.TickFrequency = 10;
			// 
			// _trackBar7
			// 
			this._trackBar7.Location = new System.Drawing.Point(8, 432);
			this._trackBar7.Maximum = 1000;
			this._trackBar7.Name = "_trackBar7";
			this._trackBar7.Size = new System.Drawing.Size(200, 42);
			this._trackBar7.TabIndex = 0;
			this._trackBar7.TickFrequency = 30;
			// 
			// _trackBar8
			// 
			this._trackBar8.Location = new System.Drawing.Point(16, 80);
			this._trackBar8.Maximum = 1000;
			this._trackBar8.Name = "_trackBar8";
			this._trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
			this._trackBar8.Size = new System.Drawing.Size(42, 336);
			this._trackBar8.TabIndex = 0;
			this._trackBar8.TickFrequency = 15;
			// 
			// _trackBar2
			// 
			this._trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._trackBar2.Location = new System.Drawing.Point(568, 72);
			this._trackBar2.Maximum = 1000;
			this._trackBar2.Name = "_trackBar2";
			this._trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
			this._trackBar2.Size = new System.Drawing.Size(42, 408);
			this._trackBar2.TabIndex = 0;
			this._trackBar2.TickFrequency = 20;
			// 
			// _trackBar3
			// 
			this._trackBar3.Location = new System.Drawing.Point(360, 432);
			this._trackBar3.Maximum = 1000;
			this._trackBar3.Name = "_trackBar3";
			this._trackBar3.Size = new System.Drawing.Size(200, 42);
			this._trackBar3.TabIndex = 0;
			this._trackBar3.TickFrequency = 30;
			// 
			// _trackBar4
			// 
			this._trackBar4.Location = new System.Drawing.Point(360, 80);
			this._trackBar4.Maximum = 1000;
			this._trackBar4.Name = "_trackBar4";
			this._trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
			this._trackBar4.Size = new System.Drawing.Size(42, 336);
			this._trackBar4.TabIndex = 0;
			this._trackBar4.TickFrequency = 20;
			// 
			// _trackBar5
			// 
			this._trackBar5.Location = new System.Drawing.Point(216, 80);
			this._trackBar5.Maximum = 1000;
			this._trackBar5.Name = "_trackBar5";
			this._trackBar5.Size = new System.Drawing.Size(136, 42);
			this._trackBar5.TabIndex = 0;
			this._trackBar5.TickFrequency = 30;
			// 
			// _trackBar6
			// 
			this._trackBar6.Location = new System.Drawing.Point(216, 128);
			this._trackBar6.Maximum = 1000;
			this._trackBar6.Name = "_trackBar6";
			this._trackBar6.Orientation = System.Windows.Forms.Orientation.Vertical;
			this._trackBar6.Size = new System.Drawing.Size(42, 352);
			this._trackBar6.TabIndex = 0;
			this._trackBar6.TickFrequency = 15;
			// 
			// _animator1
			// 
			this._animator1.NeverEndingTimer = false;
			this._animator1.TrackBar = this._trackBar1;
			// 
			// _animator2
			// 
			this._animator2.NeverEndingTimer = false;
			this._animator2.TrackBar = this._trackBar2;
			this._animator2.TriggerAnimator = this._animator1;
			// 
			// _animator3
			// 
			this._animator3.NeverEndingTimer = false;
			this._animator3.TrackBar = this._trackBar3;
			this._animator3.TriggerAnimator = this._animator2;
			// 
			// _animator4
			// 
			this._animator4.NeverEndingTimer = false;
			this._animator4.TrackBar = this._trackBar4;
			this._animator4.TriggerAnimator = this._animator3;
			// 
			// _animator5
			// 
			this._animator5.NeverEndingTimer = false;
			this._animator5.TrackBar = this._trackBar5;
			this._animator5.TriggerAnimator = this._animator4;
			// 
			// _animator6
			// 
			this._animator6.NeverEndingTimer = false;
			this._animator6.TrackBar = this._trackBar6;
			this._animator6.TriggerAnimator = this._animator5;
			// 
			// _animator7
			// 
			this._animator7.NeverEndingTimer = false;
			this._animator7.TrackBar = this._trackBar7;
			this._animator7.TriggerAnimator = this._animator6;
			// 
			// _animator8
			// 
			this._animator8.NeverEndingTimer = false;
			this._animator8.TrackBar = this._trackBar8;
			this._animator8.TriggerAnimator = this._animator7;
			this._animator8.AnimationFinished += new System.EventHandler(this.OnAnimationFinished);
			// 
			// AnimationsSample4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(624, 493);
			this.Controls.Add(this._trackBar1);
			this.Controls.Add(this._trackBar7);
			this.Controls.Add(this._trackBar8);
			this.Controls.Add(this._trackBar2);
			this.Controls.Add(this._trackBar3);
			this.Controls.Add(this._trackBar4);
			this.Controls.Add(this._trackBar5);
			this.Controls.Add(this._trackBar6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AnimationsSample4";
			this.Text = "AnimationsSample4";
			((System.ComponentModel.ISupportInitialize)(this._trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBar6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._animator8)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			StartAnimation();
		}

		private bool _reverse = false;

		private void StartAnimation()
		{
			Configure(_trackBar1, _animator1, _reverse);
			Configure(_trackBar2, _animator2, !_reverse);
			Configure(_trackBar3, _animator3, !_reverse);
			Configure(_trackBar4, _animator4, _reverse);
			Configure(_trackBar5, _animator5, !_reverse);
			Configure(_trackBar6, _animator6, !_reverse);
			Configure(_trackBar7, _animator7, !_reverse);
			Configure(_trackBar8, _animator8, _reverse);

			_reverse = !_reverse;

			_animator1.Start();
		}

		private void Configure(TrackBar trackBar, Animations.TrackBarValueAnimator animator, bool reverse)
		{
			if (reverse)
			{
				trackBar.Value = trackBar.Maximum;
				animator.CurrentValue = trackBar.Value;
				animator.StartTrackBarValue = trackBar.Value;
				animator.EndTrackBarValue = trackBar.Minimum;
			} 
			else 
			{
				trackBar.Value = trackBar.Minimum;
				animator.CurrentValue = trackBar.Value;
				animator.StartTrackBarValue = trackBar.Value;
				animator.EndTrackBarValue = trackBar.Maximum;
			}
		}

		private void OnAnimationFinished(object sender, System.EventArgs e)
		{
			StartAnimation();
		}
	}
}
