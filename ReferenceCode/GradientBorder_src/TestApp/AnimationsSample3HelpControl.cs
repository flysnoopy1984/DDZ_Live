using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using Gradients;

namespace TestApp
{
	public class AnimationsSample3HelpControl : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.IContainer components;
		private Gradients.GradientBorderAnimationExtender _stateExtender;
		private Gradients.GradientBorderLabel _gradientBorderLabel1;
		private static Random _randomizer;
		private const int MIN_INNER_HEIGHT = 10;

		static AnimationsSample3HelpControl()
		{
			_randomizer = new Random();
			for (int i = 0; i < 1000; i++)
				_randomizer.Next();
		}

		public AnimationsSample3HelpControl()
		{
			InitializeComponent();
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
			this._stateExtender = new Gradients.GradientBorderAnimationExtender(this.components);
			this._gradientBorderLabel1 = new Gradients.GradientBorderLabel();
			this.SuspendLayout();
			// 
			// _stateExtender
			// 
			this._stateExtender.GradientBorder = this._gradientBorderLabel1;
			this._stateExtender.Intervall = 10;
			this._stateExtender.IsAnimated = true;
			this._stateExtender.StepSize = 5;
			this._stateExtender.AnimationFinished += new System.EventHandler(this.OnAnimationFinished);
			// 
			// _gradientBorderLabel1
			// 
			this._gradientBorderLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._gradientBorderLabel1.BackColor = System.Drawing.Color.Transparent;
			this._gradientBorderLabel1.DockPadding.All = 20;
			this._gradientBorderLabel1.InnerColor = System.Drawing.Color.Red;
			this._gradientBorderLabel1.Location = new System.Drawing.Point(0, 0);
			this._gradientBorderLabel1.Name = "_gradientBorderLabel1";
			this._gradientBorderLabel1.Size = new System.Drawing.Size(216, 64);
			this._gradientBorderLabel1.TabIndex = 0;
			this._gradientBorderLabel1.Text = "gradientBorderLabel1";
			this._gradientBorderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AnimationsSample3HelpControl
			// 
			this.Controls.Add(this._gradientBorderLabel1);
			this.Name = "AnimationsSample3HelpControl";
			this.Size = new System.Drawing.Size(216, 64);
			this.ResumeLayout(false);

		}
		#endregion

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (!base.DesignMode)
				AnimateNextState();
		}

		public string LabelText
		{
			get { return _gradientBorderLabel1.Text; }
			set { _gradientBorderLabel1.Text = value; }
		}

		private int GetNextBorderWidth()
		{
			int minSize = Math.Min(_gradientBorderLabel1.Height, _gradientBorderLabel1.Width);
			return _randomizer.Next(1, (minSize - MIN_INNER_HEIGHT) / 2);
		}

		private Color GetNextColor()
		{
			return Color.FromArgb(_randomizer.Next(0, 255), _randomizer.Next(0, 255), _randomizer.Next(0, 255));
		}

		private void AnimateNextState() 
		{
			_stateExtender.StepSize = _randomizer.Next(5, 100) / 10.0;
			_stateExtender.Change(GetNextColor(), GetNextBorderWidth(), GetNextColor());
		}

		private void OnAnimationFinished(object sender, System.EventArgs e)
		{
			AnimateNextState();
		}
	}
}
