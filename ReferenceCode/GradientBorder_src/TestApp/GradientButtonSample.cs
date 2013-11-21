using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestApp
{
	public class GradientButtonSample : System.Windows.Forms.Form
	{
		#region Fields

		private System.Windows.Forms.Label _lblChangeAppearanceDescription;
		private Gradients.GradientBorderButton _gbPredefSample1;
		private Gradients.GradientBorderButton _gbPredefSample2;
		private Gradients.GradientBorderButton _gbPredefSample3;
		private Gradients.GradientBorderButton _gbPredefSample4;
		private Gradients.GradientBorderButton _gbPredefSample5;
		private System.Windows.Forms.Label _lblPredefSample1;
		private System.Windows.Forms.Label _lblPredefSample2;
		private System.Windows.Forms.Label _lblPredefSample3;
		private System.Windows.Forms.Label _lblPredefSample4;
		private System.Windows.Forms.Label _lblPredefSample5;
		private System.Windows.Forms.GroupBox _seperatorVertical;
		private System.Windows.Forms.GroupBox _seperatorHorizontal;
		private System.Windows.Forms.Label _lblPredefinedSamples;
		private System.Windows.Forms.Label _lblCustomSample;
		private Gradients.GradientBorderButton _gbCustomFocused;
		private Gradients.GradientBorderButton _gbCustomUnfocused;
		private System.Windows.Forms.CheckBox _chkAnimationEnabled;
		private System.Windows.Forms.TrackBar _trackBarStepSize;
		private System.Windows.Forms.Label _lblStepSizeText;
		private System.Windows.Forms.Label _lblStepSizeValue;
		private System.Windows.Forms.TrackBar _trackBarIntervall;
		private System.Windows.Forms.Label _lblIntervallText;
		private System.Windows.Forms.Label _lblIntervallValue;
		private System.Windows.Forms.Label _lblStepSizeDescription;
		private System.Windows.Forms.Label _lblIntervallDescription;
		private System.Windows.Forms.Label _lblText;
		private System.Windows.Forms.TextBox _tbText;
		private Gradients.GradientBorderButton _gbCustomSample;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.CheckBox _chkEnabled;
		private System.Windows.Forms.ColorDialog _colorDialog;
		private TestApp.AnchorControl _textAlign;

		private bool _isInitializing = true;

		#endregion

		public GradientButtonSample()
		{
			InitializeComponent();
			
			_lblChangeAppearanceDescription.Text = _lblChangeAppearanceDescription.Text.Replace("\\n", "\n");

			_chkAnimationEnabled.Checked = _gbCustomSample.IsAnimationEnabled;
			_tbText.Text = _gbCustomSample.Text;
			_trackBarIntervall.Value = (int)_gbCustomSample.AnimationIntervall;
			_trackBarStepSize.Value = (int)_gbCustomSample.AnimationStepSize;
			_textAlign.CurrentContentAlignment = _gbCustomSample.TextAlign;

			_isInitializing = false;
			UpdateCustomSample();
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
			this._gbPredefSample1 = new Gradients.GradientBorderButton();
			this._gbPredefSample2 = new Gradients.GradientBorderButton();
			this._gbPredefSample3 = new Gradients.GradientBorderButton();
			this._gbPredefSample4 = new Gradients.GradientBorderButton();
			this._gbPredefSample5 = new Gradients.GradientBorderButton();
			this._lblPredefSample1 = new System.Windows.Forms.Label();
			this._lblPredefSample2 = new System.Windows.Forms.Label();
			this._lblPredefSample3 = new System.Windows.Forms.Label();
			this._lblPredefSample4 = new System.Windows.Forms.Label();
			this._lblPredefSample5 = new System.Windows.Forms.Label();
			this._seperatorVertical = new System.Windows.Forms.GroupBox();
			this._seperatorHorizontal = new System.Windows.Forms.GroupBox();
			this._lblPredefinedSamples = new System.Windows.Forms.Label();
			this._lblCustomSample = new System.Windows.Forms.Label();
			this._gbCustomFocused = new Gradients.GradientBorderButton();
			this._gbCustomUnfocused = new Gradients.GradientBorderButton();
			this._chkAnimationEnabled = new System.Windows.Forms.CheckBox();
			this._trackBarStepSize = new System.Windows.Forms.TrackBar();
			this._lblStepSizeText = new System.Windows.Forms.Label();
			this._lblStepSizeValue = new System.Windows.Forms.Label();
			this._trackBarIntervall = new System.Windows.Forms.TrackBar();
			this._lblIntervallText = new System.Windows.Forms.Label();
			this._lblIntervallValue = new System.Windows.Forms.Label();
			this._lblStepSizeDescription = new System.Windows.Forms.Label();
			this._lblIntervallDescription = new System.Windows.Forms.Label();
			this._lblText = new System.Windows.Forms.Label();
			this._tbText = new System.Windows.Forms.TextBox();
			this._lblChangeAppearanceDescription = new System.Windows.Forms.Label();
			this._gbCustomSample = new Gradients.GradientBorderButton();
			this._chkEnabled = new System.Windows.Forms.CheckBox();
			this._colorDialog = new System.Windows.Forms.ColorDialog();
			this._textAlign = new TestApp.AnchorControl();
			((System.ComponentModel.ISupportInitialize)(this._trackBarStepSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarIntervall)).BeginInit();
			this.SuspendLayout();
			// 
			// _gbPredefSample1
			// 
			this._gbPredefSample1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbPredefSample1.AnimationStepSize = 5;
			this._gbPredefSample1.BackColor = System.Drawing.Color.Transparent;
			this._gbPredefSample1.BorderWidthFocused = 10;
			this._gbPredefSample1.BorderWidthUnfocused = 20;
			this._gbPredefSample1.DockPadding.All = 20;
			this._gbPredefSample1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._gbPredefSample1.ForeColorFocused = System.Drawing.Color.Black;
			this._gbPredefSample1.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gbPredefSample1.InnerColor = System.Drawing.Color.Red;
			this._gbPredefSample1.InnerColorFocused = System.Drawing.Color.Lime;
			this._gbPredefSample1.InnerColorUnfocused = System.Drawing.Color.Red;
			this._gbPredefSample1.IsAnimationEnabled = true;
			this._gbPredefSample1.Location = new System.Drawing.Point(56, 80);
			this._gbPredefSample1.Name = "_gbPredefSample1";
			this._gbPredefSample1.Size = new System.Drawing.Size(168, 72);
			this._gbPredefSample1.TabIndex = 0;
			this._gbPredefSample1.Text = "Sample 1";
			this._gbPredefSample1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gbPredefSample2
			// 
			this._gbPredefSample2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbPredefSample2.AnimationStepSize = 5;
			this._gbPredefSample2.BackColor = System.Drawing.Color.Transparent;
			this._gbPredefSample2.BorderWidth = 10;
			this._gbPredefSample2.BorderWidthFocused = 20;
			this._gbPredefSample2.BorderWidthUnfocused = 10;
			this._gbPredefSample2.DockPadding.All = 10;
			this._gbPredefSample2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._gbPredefSample2.ForeColorFocused = System.Drawing.Color.White;
			this._gbPredefSample2.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gbPredefSample2.InnerColor = System.Drawing.Color.Lime;
			this._gbPredefSample2.InnerColorFocused = System.Drawing.Color.Red;
			this._gbPredefSample2.InnerColorUnfocused = System.Drawing.Color.Lime;
			this._gbPredefSample2.IsAnimationEnabled = true;
			this._gbPredefSample2.Location = new System.Drawing.Point(56, 184);
			this._gbPredefSample2.Name = "_gbPredefSample2";
			this._gbPredefSample2.Size = new System.Drawing.Size(168, 64);
			this._gbPredefSample2.TabIndex = 0;
			this._gbPredefSample2.Text = "Sample 2";
			this._gbPredefSample2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gbPredefSample3
			// 
			this._gbPredefSample3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbPredefSample3.AnimationStepSize = 5;
			this._gbPredefSample3.BackColor = System.Drawing.Color.Transparent;
			this._gbPredefSample3.BorderWidth = 40;
			this._gbPredefSample3.BorderWidthFocused = 5;
			this._gbPredefSample3.BorderWidthUnfocused = 40;
			this._gbPredefSample3.DockPadding.All = 40;
			this._gbPredefSample3.ForeColor = System.Drawing.Color.White;
			this._gbPredefSample3.ForeColorFocused = System.Drawing.Color.White;
			this._gbPredefSample3.ForeColorUnfocused = System.Drawing.Color.White;
			this._gbPredefSample3.InnerColor = System.Drawing.Color.DarkBlue;
			this._gbPredefSample3.InnerColorFocused = System.Drawing.Color.DarkBlue;
			this._gbPredefSample3.InnerColorUnfocused = System.Drawing.Color.DarkBlue;
			this._gbPredefSample3.IsAnimationEnabled = true;
			this._gbPredefSample3.Location = new System.Drawing.Point(56, 272);
			this._gbPredefSample3.Name = "_gbPredefSample3";
			this._gbPredefSample3.Size = new System.Drawing.Size(168, 96);
			this._gbPredefSample3.TabIndex = 0;
			this._gbPredefSample3.Text = "Sample 3";
			this._gbPredefSample3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gbPredefSample4
			// 
			this._gbPredefSample4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbPredefSample4.AnimationStepSize = 5;
			this._gbPredefSample4.BackColor = System.Drawing.Color.Transparent;
			this._gbPredefSample4.BorderWidthFocused = 20;
			this._gbPredefSample4.BorderWidthUnfocused = 20;
			this._gbPredefSample4.DockPadding.All = 30;
			this._gbPredefSample4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._gbPredefSample4.ForeColorFocused = System.Drawing.Color.White;
			this._gbPredefSample4.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gbPredefSample4.InnerColor = System.Drawing.Color.SaddleBrown;
			this._gbPredefSample4.InnerColorFocused = System.Drawing.Color.Chocolate;
			this._gbPredefSample4.InnerColorUnfocused = System.Drawing.Color.SaddleBrown;
			this._gbPredefSample4.IsAnimationEnabled = true;
			this._gbPredefSample4.Location = new System.Drawing.Point(88, 392);
			this._gbPredefSample4.Name = "_gbPredefSample4";
			this._gbPredefSample4.Size = new System.Drawing.Size(104, 88);
			this._gbPredefSample4.TabIndex = 0;
			this._gbPredefSample4.Text = "Long Sample 4";
			this._gbPredefSample4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gbPredefSample5
			// 
			this._gbPredefSample5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbPredefSample5.AnimationStepSize = 5;
			this._gbPredefSample5.BackColor = System.Drawing.Color.Transparent;
			this._gbPredefSample5.BorderWidthFocused = 20;
			this._gbPredefSample5.BorderWidthUnfocused = 20;
			this._gbPredefSample5.DockPadding.All = 20;
			this._gbPredefSample5.ForeColor = System.Drawing.Color.White;
			this._gbPredefSample5.ForeColorFocused = System.Drawing.Color.White;
			this._gbPredefSample5.ForeColorUnfocused = System.Drawing.Color.White;
			this._gbPredefSample5.InnerColor = System.Drawing.Color.DimGray;
			this._gbPredefSample5.InnerColorFocused = System.Drawing.Color.Lime;
			this._gbPredefSample5.InnerColorUnfocused = System.Drawing.Color.DimGray;
			this._gbPredefSample5.IsAnimationEnabled = false;
			this._gbPredefSample5.Location = new System.Drawing.Point(56, 504);
			this._gbPredefSample5.Name = "_gbPredefSample5";
			this._gbPredefSample5.Size = new System.Drawing.Size(168, 72);
			this._gbPredefSample5.TabIndex = 0;
			this._gbPredefSample5.Text = "Sample 5";
			this._gbPredefSample5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _lblPredefSample1
			// 
			this._lblPredefSample1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblPredefSample1.Location = new System.Drawing.Point(8, 64);
			this._lblPredefSample1.Name = "_lblPredefSample1";
			this._lblPredefSample1.Size = new System.Drawing.Size(272, 16);
			this._lblPredefSample1.TabIndex = 2;
			this._lblPredefSample1.Text = "From red with broad border to green and thin border:";
			this._lblPredefSample1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _lblPredefSample2
			// 
			this._lblPredefSample2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblPredefSample2.Location = new System.Drawing.Point(16, 160);
			this._lblPredefSample2.Name = "_lblPredefSample2";
			this._lblPredefSample2.Size = new System.Drawing.Size(264, 32);
			this._lblPredefSample2.TabIndex = 2;
			this._lblPredefSample2.Text = "From green with thin border and black text to red with broad border and white tex" +
				"t:";
			this._lblPredefSample2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _lblPredefSample3
			// 
			this._lblPredefSample3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblPredefSample3.Location = new System.Drawing.Point(16, 256);
			this._lblPredefSample3.Name = "_lblPredefSample3";
			this._lblPredefSample3.Size = new System.Drawing.Size(264, 16);
			this._lblPredefSample3.TabIndex = 2;
			this._lblPredefSample3.Text = "From very broad border to very thin border:";
			this._lblPredefSample3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _lblPredefSample4
			// 
			this._lblPredefSample4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblPredefSample4.Location = new System.Drawing.Point(32, 376);
			this._lblPredefSample4.Name = "_lblPredefSample4";
			this._lblPredefSample4.Size = new System.Drawing.Size(216, 16);
			this._lblPredefSample4.TabIndex = 2;
			this._lblPredefSample4.Text = "From saddle brown to chocolate:";
			this._lblPredefSample4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _lblPredefSample5
			// 
			this._lblPredefSample5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lblPredefSample5.Location = new System.Drawing.Point(80, 488);
			this._lblPredefSample5.Name = "_lblPredefSample5";
			this._lblPredefSample5.Size = new System.Drawing.Size(128, 16);
			this._lblPredefSample5.TabIndex = 2;
			this._lblPredefSample5.Text = "Animation disabled:";
			this._lblPredefSample5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _seperatorVertical
			// 
			this._seperatorVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this._seperatorVertical.Location = new System.Drawing.Point(280, 0);
			this._seperatorVertical.Name = "_seperatorVertical";
			this._seperatorVertical.Size = new System.Drawing.Size(4, 576);
			this._seperatorVertical.TabIndex = 3;
			this._seperatorVertical.TabStop = false;
			// 
			// _seperatorHorizontal
			// 
			this._seperatorHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._seperatorHorizontal.Location = new System.Drawing.Point(8, 48);
			this._seperatorHorizontal.Name = "_seperatorHorizontal";
			this._seperatorHorizontal.Size = new System.Drawing.Size(664, 4);
			this._seperatorHorizontal.TabIndex = 4;
			this._seperatorHorizontal.TabStop = false;
			// 
			// _lblPredefinedSamples
			// 
			this._lblPredefinedSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._lblPredefinedSamples.Location = new System.Drawing.Point(8, 16);
			this._lblPredefinedSamples.Name = "_lblPredefinedSamples";
			this._lblPredefinedSamples.Size = new System.Drawing.Size(264, 23);
			this._lblPredefinedSamples.TabIndex = 5;
			this._lblPredefinedSamples.Text = "Predefined samples";
			this._lblPredefinedSamples.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _lblCustomSample
			// 
			this._lblCustomSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._lblCustomSample.Location = new System.Drawing.Point(296, 16);
			this._lblCustomSample.Name = "_lblCustomSample";
			this._lblCustomSample.Size = new System.Drawing.Size(344, 23);
			this._lblCustomSample.TabIndex = 5;
			this._lblCustomSample.Text = "Custom sample";
			this._lblCustomSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _gbCustomFocused
			// 
			this._gbCustomFocused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbCustomFocused.AnimationStepSize = 5;
			this._gbCustomFocused.BackColor = System.Drawing.Color.Transparent;
			this._gbCustomFocused.BorderWidthFocused = 1;
			this._gbCustomFocused.BorderWidthUnfocused = 20;
			this._gbCustomFocused.DockPadding.All = 20;
			this._gbCustomFocused.ForeColor = System.Drawing.SystemColors.ControlText;
			this._gbCustomFocused.ForeColorFocused = System.Drawing.Color.Black;
			this._gbCustomFocused.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gbCustomFocused.InnerColor = System.Drawing.Color.Red;
			this._gbCustomFocused.InnerColorFocused = System.Drawing.Color.Lime;
			this._gbCustomFocused.InnerColorUnfocused = System.Drawing.Color.Red;
			this._gbCustomFocused.IsAnimationEnabled = false;
			this._gbCustomFocused.Location = new System.Drawing.Point(296, 312);
			this._gbCustomFocused.Name = "_gbCustomFocused";
			this._gbCustomFocused.Size = new System.Drawing.Size(176, 88);
			this._gbCustomFocused.TabIndex = 0;
			this._gbCustomFocused.Text = "Focused";
			this._gbCustomFocused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._gbCustomFocused.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnUnFocusedSampleMouseDown);
			this._gbCustomFocused.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUnFocusedSampleMouseUp);
			this._gbCustomFocused.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnUnFocusedSampleMouseMove);
			// 
			// _gbCustomUnfocused
			// 
			this._gbCustomUnfocused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbCustomUnfocused.AnimationStepSize = 5;
			this._gbCustomUnfocused.BackColor = System.Drawing.Color.Transparent;
			this._gbCustomUnfocused.BorderWidth = 10;
			this._gbCustomUnfocused.BorderWidthFocused = 20;
			this._gbCustomUnfocused.BorderWidthUnfocused = 10;
			this._gbCustomUnfocused.DockPadding.All = 10;
			this._gbCustomUnfocused.ForeColor = System.Drawing.SystemColors.ControlText;
			this._gbCustomUnfocused.ForeColorFocused = System.Drawing.Color.White;
			this._gbCustomUnfocused.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gbCustomUnfocused.InnerColor = System.Drawing.Color.Lime;
			this._gbCustomUnfocused.InnerColorFocused = System.Drawing.Color.Red;
			this._gbCustomUnfocused.InnerColorUnfocused = System.Drawing.Color.Lime;
			this._gbCustomUnfocused.IsAnimationEnabled = false;
			this._gbCustomUnfocused.Location = new System.Drawing.Point(480, 312);
			this._gbCustomUnfocused.Name = "_gbCustomUnfocused";
			this._gbCustomUnfocused.Size = new System.Drawing.Size(176, 88);
			this._gbCustomUnfocused.TabIndex = 0;
			this._gbCustomUnfocused.Text = "Unfocused";
			this._gbCustomUnfocused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this._gbCustomUnfocused.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnUnFocusedSampleMouseDown);
			this._gbCustomUnfocused.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnUnFocusedSampleMouseUp);
			this._gbCustomUnfocused.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnUnFocusedSampleMouseMove);
			// 
			// _chkAnimationEnabled
			// 
			this._chkAnimationEnabled.Checked = true;
			this._chkAnimationEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkAnimationEnabled.Location = new System.Drawing.Point(432, 64);
			this._chkAnimationEnabled.Name = "_chkAnimationEnabled";
			this._chkAnimationEnabled.Size = new System.Drawing.Size(120, 16);
			this._chkAnimationEnabled.TabIndex = 6;
			this._chkAnimationEnabled.Text = "Animation enabled";
			this._chkAnimationEnabled.CheckedChanged += new System.EventHandler(this.OnCustomPropertyChanged);
			// 
			// _trackBarStepSize
			// 
			this._trackBarStepSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._trackBarStepSize.Location = new System.Drawing.Point(288, 112);
			this._trackBarStepSize.Maximum = 100;
			this._trackBarStepSize.Minimum = 1;
			this._trackBarStepSize.Name = "_trackBarStepSize";
			this._trackBarStepSize.Size = new System.Drawing.Size(384, 42);
			this._trackBarStepSize.TabIndex = 7;
			this._trackBarStepSize.TickFrequency = 5;
			this._trackBarStepSize.Value = 1;
			this._trackBarStepSize.ValueChanged += new System.EventHandler(this.OnCustomPropertyChanged);
			this._trackBarStepSize.Scroll += new System.EventHandler(this.OnCustomPropertyChanged);
			// 
			// _lblStepSizeText
			// 
			this._lblStepSizeText.Location = new System.Drawing.Point(296, 96);
			this._lblStepSizeText.Name = "_lblStepSizeText";
			this._lblStepSizeText.Size = new System.Drawing.Size(112, 16);
			this._lblStepSizeText.TabIndex = 8;
			this._lblStepSizeText.Text = "Animation step size:";
			// 
			// _lblStepSizeValue
			// 
			this._lblStepSizeValue.Location = new System.Drawing.Point(392, 96);
			this._lblStepSizeValue.Name = "_lblStepSizeValue";
			this._lblStepSizeValue.Size = new System.Drawing.Size(46, 16);
			this._lblStepSizeValue.TabIndex = 8;
			this._lblStepSizeValue.Text = "x";
			this._lblStepSizeValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _trackBarIntervall
			// 
			this._trackBarIntervall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._trackBarIntervall.Location = new System.Drawing.Point(288, 184);
			this._trackBarIntervall.Maximum = 1000;
			this._trackBarIntervall.Minimum = 1;
			this._trackBarIntervall.Name = "_trackBarIntervall";
			this._trackBarIntervall.Size = new System.Drawing.Size(384, 42);
			this._trackBarIntervall.TabIndex = 7;
			this._trackBarIntervall.TickFrequency = 20;
			this._trackBarIntervall.Value = 1;
			this._trackBarIntervall.ValueChanged += new System.EventHandler(this.OnCustomPropertyChanged);
			this._trackBarIntervall.Scroll += new System.EventHandler(this.OnCustomPropertyChanged);
			// 
			// _lblIntervallText
			// 
			this._lblIntervallText.Location = new System.Drawing.Point(296, 168);
			this._lblIntervallText.Name = "_lblIntervallText";
			this._lblIntervallText.Size = new System.Drawing.Size(112, 16);
			this._lblIntervallText.TabIndex = 8;
			this._lblIntervallText.Text = "Animation intervall:";
			// 
			// _lblIntervallValue
			// 
			this._lblIntervallValue.Location = new System.Drawing.Point(392, 168);
			this._lblIntervallValue.Name = "_lblIntervallValue";
			this._lblIntervallValue.Size = new System.Drawing.Size(46, 16);
			this._lblIntervallValue.TabIndex = 8;
			this._lblIntervallValue.Text = "x";
			this._lblIntervallValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _lblStepSizeDescription
			// 
			this._lblStepSizeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._lblStepSizeDescription.Location = new System.Drawing.Point(440, 96);
			this._lblStepSizeDescription.Name = "_lblStepSizeDescription";
			this._lblStepSizeDescription.Size = new System.Drawing.Size(232, 16);
			this._lblStepSizeDescription.TabIndex = 8;
			this._lblStepSizeDescription.Text = "in % (smaller values -> smoother animation)";
			// 
			// _lblIntervallDescription
			// 
			this._lblIntervallDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._lblIntervallDescription.Location = new System.Drawing.Point(440, 168);
			this._lblIntervallDescription.Name = "_lblIntervallDescription";
			this._lblIntervallDescription.Size = new System.Drawing.Size(232, 16);
			this._lblIntervallDescription.TabIndex = 8;
			this._lblIntervallDescription.Text = "in ms (smaller values -> faster animation)";
			// 
			// _lblText
			// 
			this._lblText.Location = new System.Drawing.Point(296, 256);
			this._lblText.Name = "_lblText";
			this._lblText.Size = new System.Drawing.Size(40, 24);
			this._lblText.TabIndex = 9;
			this._lblText.Text = "Text:";
			this._lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _tbText
			// 
			this._tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._tbText.Location = new System.Drawing.Point(336, 256);
			this._tbText.Name = "_tbText";
			this._tbText.Size = new System.Drawing.Size(224, 20);
			this._tbText.TabIndex = 10;
			this._tbText.Text = "";
			this._tbText.TextChanged += new System.EventHandler(this.OnCustomPropertyChanged);
			// 
			// _lblChangeAppearanceDescription
			// 
			this._lblChangeAppearanceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._lblChangeAppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._lblChangeAppearanceDescription.Location = new System.Drawing.Point(296, 408);
			this._lblChangeAppearanceDescription.Name = "_lblChangeAppearanceDescription";
			this._lblChangeAppearanceDescription.Size = new System.Drawing.Size(376, 56);
			this._lblChangeAppearanceDescription.TabIndex = 12;
			this._lblChangeAppearanceDescription.Text = "- Left click to choose backcolor\\n- Right click to choose forecolor.\\n-Hold middl" +
				"e button and move mouse left and right to change border width";
			// 
			// _gbCustomSample
			// 
			this._gbCustomSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbCustomSample.AnimationStepSize = 5;
			this._gbCustomSample.BackColor = System.Drawing.Color.Transparent;
			this._gbCustomSample.BorderWidth = 10;
			this._gbCustomSample.BorderWidthFocused = 20;
			this._gbCustomSample.BorderWidthUnfocused = 10;
			this._gbCustomSample.DockPadding.All = 20;
			this._gbCustomSample.ForeColor = System.Drawing.SystemColors.ControlText;
			this._gbCustomSample.ForeColorFocused = System.Drawing.Color.Black;
			this._gbCustomSample.ForeColorUnfocused = System.Drawing.Color.Black;
			this._gbCustomSample.InnerColor = System.Drawing.Color.Red;
			this._gbCustomSample.InnerColorFocused = System.Drawing.Color.Lime;
			this._gbCustomSample.InnerColorUnfocused = System.Drawing.Color.Red;
			this._gbCustomSample.IsAnimationEnabled = true;
			this._gbCustomSample.Location = new System.Drawing.Point(392, 480);
			this._gbCustomSample.Name = "_gbCustomSample";
			this._gbCustomSample.Size = new System.Drawing.Size(176, 88);
			this._gbCustomSample.TabIndex = 0;
			this._gbCustomSample.Text = "Custom Sample";
			this._gbCustomSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _chkEnabled
			// 
			this._chkEnabled.Checked = true;
			this._chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkEnabled.Location = new System.Drawing.Point(296, 64);
			this._chkEnabled.Name = "_chkEnabled";
			this._chkEnabled.Size = new System.Drawing.Size(120, 16);
			this._chkEnabled.TabIndex = 6;
			this._chkEnabled.Text = "Enabled";
			this._chkEnabled.CheckedChanged += new System.EventHandler(this.OnEnabledCheckedChanged);
			// 
			// _colorDialog
			// 
			this._colorDialog.AnyColor = true;
			this._colorDialog.FullOpen = true;
			// 
			// _textAlign
			// 
			this._textAlign.CurrentContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this._textAlign.Location = new System.Drawing.Point(576, 232);
			this._textAlign.Name = "_textAlign";
			this._textAlign.Size = new System.Drawing.Size(64, 64);
			this._textAlign.TabIndex = 13;
			this._textAlign.ContentAlignmentChanged += new System.EventHandler(this.OnCustomPropertyChanged);
			// 
			// GradientButtonSample
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 581);
			this.Controls.Add(this._textAlign);
			this.Controls.Add(this._lblChangeAppearanceDescription);
			this.Controls.Add(this._tbText);
			this.Controls.Add(this._chkAnimationEnabled);
			this.Controls.Add(this._lblText);
			this.Controls.Add(this._lblIntervallValue);
			this.Controls.Add(this._lblStepSizeValue);
			this.Controls.Add(this._lblStepSizeText);
			this.Controls.Add(this._trackBarStepSize);
			this.Controls.Add(this._lblPredefinedSamples);
			this.Controls.Add(this._seperatorHorizontal);
			this.Controls.Add(this._seperatorVertical);
			this.Controls.Add(this._lblPredefSample1);
			this.Controls.Add(this._gbPredefSample1);
			this.Controls.Add(this._gbPredefSample2);
			this.Controls.Add(this._gbPredefSample3);
			this.Controls.Add(this._gbPredefSample4);
			this.Controls.Add(this._gbPredefSample5);
			this.Controls.Add(this._lblPredefSample2);
			this.Controls.Add(this._lblPredefSample3);
			this.Controls.Add(this._lblPredefSample4);
			this.Controls.Add(this._lblPredefSample5);
			this.Controls.Add(this._lblCustomSample);
			this.Controls.Add(this._gbCustomFocused);
			this.Controls.Add(this._gbCustomUnfocused);
			this.Controls.Add(this._trackBarIntervall);
			this.Controls.Add(this._lblIntervallText);
			this.Controls.Add(this._lblStepSizeDescription);
			this.Controls.Add(this._lblIntervallDescription);
			this.Controls.Add(this._gbCustomSample);
			this.Controls.Add(this._chkEnabled);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GradientButtonSample";
			this.Text = "GradientButtonSample";
			((System.ComponentModel.ISupportInitialize)(this._trackBarStepSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarIntervall)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void OnCustomPropertyChanged(object sender, System.EventArgs e)
		{
			if (_isInitializing)
				return;

			UpdateCustomSample();
		}

		private void UpdateCustomSample() 
		{
			_gbCustomSample.IsAnimationEnabled = _chkAnimationEnabled.Checked;
			_gbCustomSample.Text = _tbText.Text;
			_gbCustomSample.AnimationIntervall = _trackBarIntervall.Value;
			_lblIntervallValue.Text = _gbCustomSample.AnimationIntervall.ToString();
			_gbCustomSample.AnimationStepSize = _trackBarStepSize.Value;
			_lblStepSizeValue.Text = _gbCustomSample.AnimationStepSize.ToString();
			_gbCustomSample.TextAlign = _textAlign.CurrentContentAlignment;

			_gbCustomSample.BorderWidthFocused = _gbCustomFocused.BorderWidth;
			_gbCustomSample.BorderWidthUnfocused = _gbCustomUnfocused.BorderWidth;
			_gbCustomSample.InnerColorFocused = _gbCustomFocused.InnerColor;
			_gbCustomSample.InnerColorUnfocused = _gbCustomUnfocused.InnerColor;
			_gbCustomSample.ForeColorFocused = _gbCustomFocused.ForeColor;
			_gbCustomSample.ForeColorUnfocused = _gbCustomUnfocused.ForeColor;
		}

		private void OnEnabledCheckedChanged(object sender, System.EventArgs e)
		{
			_gbCustomSample.Enabled = _chkEnabled.Checked;
		}

		private Point _mouseDownPos;
		private int _mouseDownBorderWidth = -1;
		private Gradients.GradientBorderButton _mouseDownGradientButton;

		private void OnUnFocusedSampleMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Gradients.GradientBorderButton gradientButton = sender as Gradients.GradientBorderButton;
			if (gradientButton == null)
				return;

				switch (e.Button)
				{
					case MouseButtons.Left:
						_colorDialog.Color = gradientButton.InnerColor;
						if (_colorDialog.ShowDialog() == DialogResult.OK)
						{
							gradientButton.InnerColor = _colorDialog.Color;
							UpdateCustomSample();
						}
						break;
					case MouseButtons.Right:
						_colorDialog.Color = gradientButton.ForeColor;
						if (_colorDialog.ShowDialog() == DialogResult.OK)
						{
							gradientButton.ForeColor = _colorDialog.Color;
							UpdateCustomSample();
						}
						break;
					case MouseButtons.Middle:
						_mouseDownPos = new Point(e.X, e.Y);
						_mouseDownBorderWidth = gradientButton.BorderWidth;
						_mouseDownGradientButton = gradientButton;
						break;
				}
		}

		private void OnUnFocusedSampleMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (_mouseDownBorderWidth >= 0)
			{
				int newBorderWidth = _mouseDownBorderWidth + (e.X - _mouseDownPos.X);
				if (newBorderWidth < 0)
					newBorderWidth = 0;
				if (_mouseDownGradientButton.BorderWidth != newBorderWidth)
				{
					_mouseDownGradientButton.BorderWidth = newBorderWidth;
					UpdateCustomSample();
				}
			}
		}

		private void OnUnFocusedSampleMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
				_mouseDownBorderWidth = -1;
		}
	}
}
