using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestApp
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.LinkLabel _lnkGradientBorder;
		private System.Windows.Forms.LinkLabel _lnkGradientButton;
		private System.Windows.Forms.LinkLabel _lnkAnimations;
		private System.ComponentModel.IContainer components = null;

		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Frees used resources.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this._lnkGradientBorder = new System.Windows.Forms.LinkLabel();
			this._lnkGradientButton = new System.Windows.Forms.LinkLabel();
			this._lnkAnimations = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// _lnkGradientBorder
			// 
			this._lnkGradientBorder.BackColor = System.Drawing.Color.Transparent;
			this._lnkGradientBorder.Location = new System.Drawing.Point(120, 88);
			this._lnkGradientBorder.Name = "_lnkGradientBorder";
			this._lnkGradientBorder.Size = new System.Drawing.Size(88, 16);
			this._lnkGradientBorder.TabIndex = 0;
			this._lnkGradientBorder.TabStop = true;
			this._lnkGradientBorder.Text = "GradientBorder";
			this._lnkGradientBorder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnGradientBorderLinkClicked);
			// 
			// _lnkGradientButton
			// 
			this._lnkGradientButton.BackColor = System.Drawing.Color.Transparent;
			this._lnkGradientButton.Location = new System.Drawing.Point(216, 88);
			this._lnkGradientButton.Name = "_lnkGradientButton";
			this._lnkGradientButton.Size = new System.Drawing.Size(120, 16);
			this._lnkGradientButton.TabIndex = 0;
			this._lnkGradientButton.TabStop = true;
			this._lnkGradientButton.Text = "GradientBorderButton";
			this._lnkGradientButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnGradientButtonLinkClicked);
			// 
			// _lnkAnimations
			// 
			this._lnkAnimations.BackColor = System.Drawing.Color.Transparent;
			this._lnkAnimations.Location = new System.Drawing.Point(352, 88);
			this._lnkAnimations.Name = "_lnkAnimations";
			this._lnkAnimations.Size = new System.Drawing.Size(80, 16);
			this._lnkAnimations.TabIndex = 0;
			this._lnkAnimations.TabStop = true;
			this._lnkAnimations.Text = "Animations";
			this._lnkAnimations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnAnimationsLinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(448, 141);
			this.Controls.Add(this._lnkGradientBorder);
			this.Controls.Add(this._lnkGradientButton);
			this.Controls.Add(this._lnkAnimations);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Main";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
//			for (int i = 0; i < 50; i++)
//				TestInterpolation(0, i);

			Application.Run(new MainForm());
			//Application.Run(new Form1());
			//Application.Run(new AnimationsSample2());
		}

		private static void TestInterpolation(int start, int end)
		{
			for (int i = 0; i <= 100; i++)
			{
				Console.Write(start + "   " + end + "   " + i + "   ");
				int val = Animations.AnimatorBase.InterpolateIntegerValues(start, end, i * 1.0);
				Console.WriteLine(val);
			}
		}

		private void OnGradientBorderLinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			new GradientBorderSample().Show();
		}

		private void OnGradientButtonLinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			new GradientButtonSample().Show();
		}

		private void OnAnimationsLinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			AnimationsSampleSelector ass = new AnimationsSampleSelector();
			ass.StartPosition = FormStartPosition.Manual;
			ass.Top = this.Bottom + 1;
			ass.Left = this.Left;
			ass.Size = this.Size;
			ass.Show();
		}
	}
}
