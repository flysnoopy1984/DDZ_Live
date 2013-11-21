using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Gradients;

namespace TestApp
{
	public class AnimationsSample3 : System.Windows.Forms.Form
	{
		private Random _randomizer;
		private const int MIN_INNER_HEIGHT = 10;
		private TestApp.AnimationsSample3HelpControl _ctrl1;
		private TestApp.AnimationsSample3HelpControl _ctrl2;
		private TestApp.AnimationsSample3HelpControl animationsSample3HelpControl1;
		private TestApp.AnimationsSample3HelpControl animationsSample3HelpControl2;
		private TestApp.AnimationsSample3HelpControl animationsSample3HelpControl3;
		private TestApp.AnimationsSample3HelpControl animationsSample3HelpControl4;
		private TestApp.AnimationsSample3HelpControl animationsSample3HelpControl5;
		private TestApp.AnimationsSample3HelpControl animationsSample3HelpControl6;
		private TestApp.AnimationsSample3HelpControl animationsSample3HelpControl7;
		private System.ComponentModel.IContainer components = null;

		public AnimationsSample3()
		{
			InitializeComponent();
			_randomizer = new Random();
			for (int i = 0; i < 1000; i++)
				_randomizer.Next();
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
			this._ctrl1 = new TestApp.AnimationsSample3HelpControl();
			this._ctrl2 = new TestApp.AnimationsSample3HelpControl();
			this.animationsSample3HelpControl1 = new TestApp.AnimationsSample3HelpControl();
			this.animationsSample3HelpControl2 = new TestApp.AnimationsSample3HelpControl();
			this.animationsSample3HelpControl3 = new TestApp.AnimationsSample3HelpControl();
			this.animationsSample3HelpControl4 = new TestApp.AnimationsSample3HelpControl();
			this.animationsSample3HelpControl5 = new TestApp.AnimationsSample3HelpControl();
			this.animationsSample3HelpControl6 = new TestApp.AnimationsSample3HelpControl();
			this.animationsSample3HelpControl7 = new TestApp.AnimationsSample3HelpControl();
			this.SuspendLayout();
			// 
			// _ctrl1
			// 
			this._ctrl1.LabelText = "This is the";
			this._ctrl1.Location = new System.Drawing.Point(8, 8);
			this._ctrl1.Name = "_ctrl1";
			this._ctrl1.Size = new System.Drawing.Size(192, 80);
			this._ctrl1.TabIndex = 0;
			// 
			// _ctrl2
			// 
			this._ctrl2.LabelText = "funky 70\'s style";
			this._ctrl2.Location = new System.Drawing.Point(8, 96);
			this._ctrl2.Name = "_ctrl2";
			this._ctrl2.Size = new System.Drawing.Size(192, 80);
			this._ctrl2.TabIndex = 0;
			// 
			// animationsSample3HelpControl1
			// 
			this.animationsSample3HelpControl1.LabelText = "randomly colored";
			this.animationsSample3HelpControl1.Location = new System.Drawing.Point(8, 184);
			this.animationsSample3HelpControl1.Name = "animationsSample3HelpControl1";
			this.animationsSample3HelpControl1.Size = new System.Drawing.Size(192, 80);
			this.animationsSample3HelpControl1.TabIndex = 0;
			// 
			// animationsSample3HelpControl2
			// 
			this.animationsSample3HelpControl2.LabelText = "animation sample.";
			this.animationsSample3HelpControl2.Location = new System.Drawing.Point(8, 272);
			this.animationsSample3HelpControl2.Name = "animationsSample3HelpControl2";
			this.animationsSample3HelpControl2.Size = new System.Drawing.Size(192, 80);
			this.animationsSample3HelpControl2.TabIndex = 0;
			// 
			// animationsSample3HelpControl3
			// 
			this.animationsSample3HelpControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animationsSample3HelpControl3.LabelText = "long at those colors...";
			this.animationsSample3HelpControl3.Location = new System.Drawing.Point(258, 184);
			this.animationsSample3HelpControl3.Name = "animationsSample3HelpControl3";
			this.animationsSample3HelpControl3.Size = new System.Drawing.Size(192, 80);
			this.animationsSample3HelpControl3.TabIndex = 0;
			// 
			// animationsSample3HelpControl4
			// 
			this.animationsSample3HelpControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animationsSample3HelpControl4.LabelText = "WARNING:";
			this.animationsSample3HelpControl4.Location = new System.Drawing.Point(258, 8);
			this.animationsSample3HelpControl4.Name = "animationsSample3HelpControl4";
			this.animationsSample3HelpControl4.Size = new System.Drawing.Size(192, 80);
			this.animationsSample3HelpControl4.TabIndex = 0;
			// 
			// animationsSample3HelpControl5
			// 
			this.animationsSample3HelpControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animationsSample3HelpControl5.LabelText = "You might get mind controlled!!!";
			this.animationsSample3HelpControl5.Location = new System.Drawing.Point(258, 272);
			this.animationsSample3HelpControl5.Name = "animationsSample3HelpControl5";
			this.animationsSample3HelpControl5.Size = new System.Drawing.Size(192, 80);
			this.animationsSample3HelpControl5.TabIndex = 0;
			// 
			// animationsSample3HelpControl6
			// 
			this.animationsSample3HelpControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.animationsSample3HelpControl6.LabelText = "Don\'t look to";
			this.animationsSample3HelpControl6.Location = new System.Drawing.Point(258, 96);
			this.animationsSample3HelpControl6.Name = "animationsSample3HelpControl6";
			this.animationsSample3HelpControl6.Size = new System.Drawing.Size(192, 72);
			this.animationsSample3HelpControl6.TabIndex = 1;
			// 
			// animationsSample3HelpControl7
			// 
			this.animationsSample3HelpControl7.LabelText = "";
			this.animationsSample3HelpControl7.Location = new System.Drawing.Point(216, 8);
			this.animationsSample3HelpControl7.Name = "animationsSample3HelpControl7";
			this.animationsSample3HelpControl7.Size = new System.Drawing.Size(24, 344);
			this.animationsSample3HelpControl7.TabIndex = 2;
			// 
			// AnimationsSample3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(458, 365);
			this.Controls.Add(this.animationsSample3HelpControl7);
			this.Controls.Add(this._ctrl1);
			this.Controls.Add(this._ctrl2);
			this.Controls.Add(this.animationsSample3HelpControl1);
			this.Controls.Add(this.animationsSample3HelpControl2);
			this.Controls.Add(this.animationsSample3HelpControl3);
			this.Controls.Add(this.animationsSample3HelpControl4);
			this.Controls.Add(this.animationsSample3HelpControl5);
			this.Controls.Add(this.animationsSample3HelpControl6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AnimationsSample3";
			this.Text = "AnimationsSample3";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
