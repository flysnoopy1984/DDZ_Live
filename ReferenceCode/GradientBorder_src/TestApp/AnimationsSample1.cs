using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestApp
{
	public class AnimationsSample1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox _boundsSample1GroupBox;
		private System.Windows.Forms.Button _boundsSample2Button;
		private System.Windows.Forms.PictureBox _boundsSample3PictureBox;
		private System.Windows.Forms.GroupBox _groupSeperator1;
		private System.Windows.Forms.Label _lblControlBoundsAnimator;
		private System.Windows.Forms.Label _boundsSample1Label;
		private System.Windows.Forms.GroupBox _groupSeperator2;
		private Animations.ControlBoundsAnimator _boundsSample1Animator;
		private Animations.ControlBoundsAnimator _boundsSample2Animator;
		private Animations.ControlBoundsAnimator _boundsSample3Animator;
		private System.Windows.Forms.GroupBox _groupSeperator3;
		private System.Windows.Forms.Label _lblControlForeColorAnimator;
		private System.Windows.Forms.Label _foreColorSample1Label;
		private Animations.ControlForeColorAnimator _foreColorSample1Animator;
		private Animations.ControlForeColorAnimator _foreColorSample2Animator;
		private Animations.ControlForeColorAnimator _foreColorSample3Animator;
		private System.Windows.Forms.Button _foreColorSample2Button;
		private System.Windows.Forms.GroupBox _foreColorSample3GroupBox;
		private System.Windows.Forms.Label _foreColorSample3Label1;
		private System.Windows.Forms.Label _foreColorSample3Label2;
		private System.Windows.Forms.Label _foreColorSample3Label3;
		private System.Windows.Forms.Label _foreColorSample3Label4;
		private System.Windows.Forms.Label _foreColorSample3Label5;
		private System.Windows.Forms.GroupBox _groupSeperator5;
		private System.Windows.Forms.Label _lblControlBackColorAnimator;
		private System.Windows.Forms.GroupBox _groupSeperator4;
		private System.Windows.Forms.ComboBox _backColorSample1ComboBox;
		private System.Windows.Forms.Button _backColorSample2Button;
		private System.Windows.Forms.GroupBox _backColorSample3GroupBox;
		private System.Windows.Forms.Label _backColorSample4Label;
		private Animations.ControlBackColorAnimator _backColorSample1Animator;
		private Animations.ControlBackColorAnimator _backColorSample2Animator;
		private Animations.ControlBackColorAnimator _backColorSample3Animator;
		private Animations.ControlBackColorAnimator _backColorSample4Animator;
		private Animations.TrackBarValueAnimator _trackBarValueSample1Animator;
		private Animations.TrackBarValueAnimator _trackBarValueSample2Animator;
		private System.Windows.Forms.Label _lblTrackBarValueAnimator;
		private System.Windows.Forms.GroupBox _groupSeperator7;
		private System.Windows.Forms.GroupBox _groupSeperator6;
		private System.Windows.Forms.TrackBar _trackBarValueSample1;
		private System.Windows.Forms.TrackBar _trackBarValueSample2;
		private System.ComponentModel.IContainer components;

		public AnimationsSample1()
		{
			InitializeComponent();

			_boundsSample1Animator.Start(false);

			_foreColorSample1Animator.Start(false);

			_backColorSample1Animator.Start(false);

			_trackBarValueSample1Animator.Start(false);

			_trackBarValueSample2Animator.Start(false);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AnimationsSample1));
			this._boundsSample1GroupBox = new System.Windows.Forms.GroupBox();
			this._boundsSample1Label = new System.Windows.Forms.Label();
			this._boundsSample2Button = new System.Windows.Forms.Button();
			this._boundsSample3PictureBox = new System.Windows.Forms.PictureBox();
			this._groupSeperator1 = new System.Windows.Forms.GroupBox();
			this._lblControlBoundsAnimator = new System.Windows.Forms.Label();
			this._groupSeperator2 = new System.Windows.Forms.GroupBox();
			this._boundsSample1Animator = new Animations.ControlBoundsAnimator(this.components);
			this._boundsSample2Animator = new Animations.ControlBoundsAnimator(this.components);
			this._boundsSample3Animator = new Animations.ControlBoundsAnimator(this.components);
			this._groupSeperator3 = new System.Windows.Forms.GroupBox();
			this._lblControlForeColorAnimator = new System.Windows.Forms.Label();
			this._foreColorSample1Label = new System.Windows.Forms.Label();
			this._foreColorSample1Animator = new Animations.ControlForeColorAnimator(this.components);
			this._foreColorSample2Animator = new Animations.ControlForeColorAnimator(this.components);
			this._foreColorSample2Button = new System.Windows.Forms.Button();
			this._foreColorSample3Animator = new Animations.ControlForeColorAnimator(this.components);
			this._foreColorSample3GroupBox = new System.Windows.Forms.GroupBox();
			this._foreColorSample3Label1 = new System.Windows.Forms.Label();
			this._foreColorSample3Label2 = new System.Windows.Forms.Label();
			this._foreColorSample3Label3 = new System.Windows.Forms.Label();
			this._foreColorSample3Label4 = new System.Windows.Forms.Label();
			this._foreColorSample3Label5 = new System.Windows.Forms.Label();
			this._groupSeperator5 = new System.Windows.Forms.GroupBox();
			this._lblControlBackColorAnimator = new System.Windows.Forms.Label();
			this._groupSeperator4 = new System.Windows.Forms.GroupBox();
			this._backColorSample1ComboBox = new System.Windows.Forms.ComboBox();
			this._backColorSample2Button = new System.Windows.Forms.Button();
			this._backColorSample3GroupBox = new System.Windows.Forms.GroupBox();
			this._backColorSample4Label = new System.Windows.Forms.Label();
			this._backColorSample1Animator = new Animations.ControlBackColorAnimator(this.components);
			this._backColorSample2Animator = new Animations.ControlBackColorAnimator(this.components);
			this._backColorSample3Animator = new Animations.ControlBackColorAnimator(this.components);
			this._backColorSample4Animator = new Animations.ControlBackColorAnimator(this.components);
			this._trackBarValueSample1Animator = new Animations.TrackBarValueAnimator(this.components);
			this._trackBarValueSample1 = new System.Windows.Forms.TrackBar();
			this._trackBarValueSample2Animator = new Animations.TrackBarValueAnimator(this.components);
			this._trackBarValueSample2 = new System.Windows.Forms.TrackBar();
			this._lblTrackBarValueAnimator = new System.Windows.Forms.Label();
			this._groupSeperator7 = new System.Windows.Forms.GroupBox();
			this._groupSeperator6 = new System.Windows.Forms.GroupBox();
			this._boundsSample1GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._boundsSample1Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._boundsSample2Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._boundsSample3Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._foreColorSample1Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._foreColorSample2Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._foreColorSample3Animator)).BeginInit();
			this._foreColorSample3GroupBox.SuspendLayout();
			this._backColorSample3GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._backColorSample1Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._backColorSample2Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._backColorSample3Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._backColorSample4Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample1Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample2Animator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample2)).BeginInit();
			this.SuspendLayout();
			// 
			// _boundsSample1GroupBox
			// 
			this._boundsSample1GroupBox.Controls.Add(this._boundsSample1Label);
			this._boundsSample1GroupBox.Location = new System.Drawing.Point(8, 40);
			this._boundsSample1GroupBox.Name = "_boundsSample1GroupBox";
			this._boundsSample1GroupBox.Size = new System.Drawing.Size(104, 100);
			this._boundsSample1GroupBox.TabIndex = 0;
			this._boundsSample1GroupBox.TabStop = false;
			this._boundsSample1GroupBox.Text = "groupBox";
			// 
			// _boundsSample1Label
			// 
			this._boundsSample1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._boundsSample1Label.Location = new System.Drawing.Point(16, 24);
			this._boundsSample1Label.Name = "_boundsSample1Label";
			this._boundsSample1Label.Size = new System.Drawing.Size(80, 64);
			this._boundsSample1Label.TabIndex = 0;
			this._boundsSample1Label.Text = @"Bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla bla";
			// 
			// _boundsSample2Button
			// 
			this._boundsSample2Button.Location = new System.Drawing.Point(312, 40);
			this._boundsSample2Button.Name = "_boundsSample2Button";
			this._boundsSample2Button.TabIndex = 1;
			this._boundsSample2Button.Text = "button";
			// 
			// _boundsSample3PictureBox
			// 
			this._boundsSample3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_boundsSample3PictureBox.Image")));
			this._boundsSample3PictureBox.Location = new System.Drawing.Point(392, 40);
			this._boundsSample3PictureBox.Name = "_boundsSample3PictureBox";
			this._boundsSample3PictureBox.Size = new System.Drawing.Size(360, 96);
			this._boundsSample3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this._boundsSample3PictureBox.TabIndex = 2;
			this._boundsSample3PictureBox.TabStop = false;
			// 
			// _groupSeperator1
			// 
			this._groupSeperator1.Location = new System.Drawing.Point(8, 24);
			this._groupSeperator1.Name = "_groupSeperator1";
			this._groupSeperator1.Size = new System.Drawing.Size(744, 8);
			this._groupSeperator1.TabIndex = 3;
			this._groupSeperator1.TabStop = false;
			// 
			// _lblControlBoundsAnimator
			// 
			this._lblControlBoundsAnimator.Location = new System.Drawing.Point(8, 8);
			this._lblControlBoundsAnimator.Name = "_lblControlBoundsAnimator";
			this._lblControlBoundsAnimator.Size = new System.Drawing.Size(208, 16);
			this._lblControlBoundsAnimator.TabIndex = 4;
			this._lblControlBoundsAnimator.Text = "ControlBoundsAnimator";
			// 
			// _groupSeperator2
			// 
			this._groupSeperator2.Location = new System.Drawing.Point(8, 144);
			this._groupSeperator2.Name = "_groupSeperator2";
			this._groupSeperator2.Size = new System.Drawing.Size(744, 8);
			this._groupSeperator2.TabIndex = 3;
			this._groupSeperator2.TabStop = false;
			// 
			// _boundsSample1Animator
			// 
			this._boundsSample1Animator.Control = this._boundsSample1GroupBox;
			this._boundsSample1Animator.EndBounds = new System.Drawing.Rectangle(8, 40, 300, 100);
			this._boundsSample1Animator.Intervall = 20;
			this._boundsSample1Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._boundsSample1Animator.NeverEndingTimer = false;
			this._boundsSample1Animator.StartBounds = new System.Drawing.Rectangle(8, 40, 104, 100);
			// 
			// _boundsSample2Animator
			// 
			this._boundsSample2Animator.Control = this._boundsSample2Button;
			this._boundsSample2Animator.EndBounds = new System.Drawing.Rectangle(312, 112, 75, 23);
			this._boundsSample2Animator.Intervall = 20;
			this._boundsSample2Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._boundsSample2Animator.NeverEndingTimer = false;
			this._boundsSample2Animator.ParentAnimator = this._boundsSample1Animator;
			this._boundsSample2Animator.StartBounds = new System.Drawing.Rectangle(312, 40, 75, 23);
			// 
			// _boundsSample3Animator
			// 
			this._boundsSample3Animator.Control = this._boundsSample3PictureBox;
			this._boundsSample3Animator.EndBounds = new System.Drawing.Rectangle(688, 40, 64, 24);
			this._boundsSample3Animator.Intervall = 20;
			this._boundsSample3Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._boundsSample3Animator.NeverEndingTimer = false;
			this._boundsSample3Animator.ParentAnimator = this._boundsSample1Animator;
			this._boundsSample3Animator.StartBounds = new System.Drawing.Rectangle(392, 40, 360, 96);
			// 
			// _groupSeperator3
			// 
			this._groupSeperator3.Location = new System.Drawing.Point(8, 176);
			this._groupSeperator3.Name = "_groupSeperator3";
			this._groupSeperator3.Size = new System.Drawing.Size(744, 8);
			this._groupSeperator3.TabIndex = 3;
			this._groupSeperator3.TabStop = false;
			// 
			// _lblControlForeColorAnimator
			// 
			this._lblControlForeColorAnimator.Location = new System.Drawing.Point(8, 160);
			this._lblControlForeColorAnimator.Name = "_lblControlForeColorAnimator";
			this._lblControlForeColorAnimator.Size = new System.Drawing.Size(208, 16);
			this._lblControlForeColorAnimator.TabIndex = 4;
			this._lblControlForeColorAnimator.Text = "ControlForeColorAnimator";
			// 
			// _foreColorSample1Label
			// 
			this._foreColorSample1Label.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._foreColorSample1Label.ForeColor = System.Drawing.SystemColors.ControlText;
			this._foreColorSample1Label.Location = new System.Drawing.Point(16, 200);
			this._foreColorSample1Label.Name = "_foreColorSample1Label";
			this._foreColorSample1Label.Size = new System.Drawing.Size(312, 96);
			this._foreColorSample1Label.TabIndex = 5;
			this._foreColorSample1Label.Text = "Label";
			this._foreColorSample1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _foreColorSample1Animator
			// 
			this._foreColorSample1Animator.Control = this._foreColorSample1Label;
			this._foreColorSample1Animator.EndColor = System.Drawing.Color.Lime;
			this._foreColorSample1Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._foreColorSample1Animator.NeverEndingTimer = false;
			this._foreColorSample1Animator.StartColor = System.Drawing.Color.Red;
			// 
			// _foreColorSample2Animator
			// 
			this._foreColorSample2Animator.Control = this._foreColorSample2Button;
			this._foreColorSample2Animator.EndColor = System.Drawing.Color.Fuchsia;
			this._foreColorSample2Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._foreColorSample2Animator.NeverEndingTimer = false;
			this._foreColorSample2Animator.ParentAnimator = this._foreColorSample1Animator;
			this._foreColorSample2Animator.StartColor = System.Drawing.Color.Blue;
			// 
			// _foreColorSample2Button
			// 
			this._foreColorSample2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._foreColorSample2Button.ForeColor = System.Drawing.SystemColors.ControlText;
			this._foreColorSample2Button.Location = new System.Drawing.Point(336, 232);
			this._foreColorSample2Button.Name = "_foreColorSample2Button";
			this._foreColorSample2Button.Size = new System.Drawing.Size(168, 32);
			this._foreColorSample2Button.TabIndex = 8;
			this._foreColorSample2Button.Text = "button";
			// 
			// _foreColorSample3Animator
			// 
			this._foreColorSample3Animator.Control = this._foreColorSample3GroupBox;
			this._foreColorSample3Animator.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._foreColorSample3Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._foreColorSample3Animator.NeverEndingTimer = false;
			this._foreColorSample3Animator.ParentAnimator = this._foreColorSample1Animator;
			this._foreColorSample3Animator.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			// 
			// _foreColorSample3GroupBox
			// 
			this._foreColorSample3GroupBox.Controls.Add(this._foreColorSample3Label1);
			this._foreColorSample3GroupBox.Controls.Add(this._foreColorSample3Label2);
			this._foreColorSample3GroupBox.Controls.Add(this._foreColorSample3Label3);
			this._foreColorSample3GroupBox.Controls.Add(this._foreColorSample3Label4);
			this._foreColorSample3GroupBox.Controls.Add(this._foreColorSample3Label5);
			this._foreColorSample3GroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this._foreColorSample3GroupBox.Location = new System.Drawing.Point(520, 200);
			this._foreColorSample3GroupBox.Name = "_foreColorSample3GroupBox";
			this._foreColorSample3GroupBox.Size = new System.Drawing.Size(232, 96);
			this._foreColorSample3GroupBox.TabIndex = 9;
			this._foreColorSample3GroupBox.TabStop = false;
			this._foreColorSample3GroupBox.Text = "groupBox";
			// 
			// _foreColorSample3Label1
			// 
			this._foreColorSample3Label1.Location = new System.Drawing.Point(16, 24);
			this._foreColorSample3Label1.Name = "_foreColorSample3Label1";
			this._foreColorSample3Label1.Size = new System.Drawing.Size(100, 16);
			this._foreColorSample3Label1.TabIndex = 0;
			this._foreColorSample3Label1.Text = "label1";
			// 
			// _foreColorSample3Label2
			// 
			this._foreColorSample3Label2.Location = new System.Drawing.Point(128, 24);
			this._foreColorSample3Label2.Name = "_foreColorSample3Label2";
			this._foreColorSample3Label2.Size = new System.Drawing.Size(88, 16);
			this._foreColorSample3Label2.TabIndex = 0;
			this._foreColorSample3Label2.Text = "label2";
			// 
			// _foreColorSample3Label3
			// 
			this._foreColorSample3Label3.Location = new System.Drawing.Point(80, 48);
			this._foreColorSample3Label3.Name = "_foreColorSample3Label3";
			this._foreColorSample3Label3.Size = new System.Drawing.Size(88, 16);
			this._foreColorSample3Label3.TabIndex = 0;
			this._foreColorSample3Label3.Text = "label3";
			// 
			// _foreColorSample3Label4
			// 
			this._foreColorSample3Label4.Location = new System.Drawing.Point(16, 72);
			this._foreColorSample3Label4.Name = "_foreColorSample3Label4";
			this._foreColorSample3Label4.Size = new System.Drawing.Size(88, 16);
			this._foreColorSample3Label4.TabIndex = 0;
			this._foreColorSample3Label4.Text = "label4";
			// 
			// _foreColorSample3Label5
			// 
			this._foreColorSample3Label5.Location = new System.Drawing.Point(128, 72);
			this._foreColorSample3Label5.Name = "_foreColorSample3Label5";
			this._foreColorSample3Label5.Size = new System.Drawing.Size(88, 16);
			this._foreColorSample3Label5.TabIndex = 0;
			this._foreColorSample3Label5.Text = "label5";
			this._foreColorSample3Label5.Click += new System.EventHandler(this.label4_Click);
			// 
			// _groupSeperator5
			// 
			this._groupSeperator5.Location = new System.Drawing.Point(8, 336);
			this._groupSeperator5.Name = "_groupSeperator5";
			this._groupSeperator5.Size = new System.Drawing.Size(744, 8);
			this._groupSeperator5.TabIndex = 3;
			this._groupSeperator5.TabStop = false;
			// 
			// _lblControlBackColorAnimator
			// 
			this._lblControlBackColorAnimator.Location = new System.Drawing.Point(8, 320);
			this._lblControlBackColorAnimator.Name = "_lblControlBackColorAnimator";
			this._lblControlBackColorAnimator.Size = new System.Drawing.Size(208, 16);
			this._lblControlBackColorAnimator.TabIndex = 4;
			this._lblControlBackColorAnimator.Text = "ControlBackColorAnimator";
			// 
			// _groupSeperator4
			// 
			this._groupSeperator4.Location = new System.Drawing.Point(8, 304);
			this._groupSeperator4.Name = "_groupSeperator4";
			this._groupSeperator4.Size = new System.Drawing.Size(744, 8);
			this._groupSeperator4.TabIndex = 3;
			this._groupSeperator4.TabStop = false;
			// 
			// _backColorSample1ComboBox
			// 
			this._backColorSample1ComboBox.Location = new System.Drawing.Point(16, 376);
			this._backColorSample1ComboBox.Name = "_backColorSample1ComboBox";
			this._backColorSample1ComboBox.Size = new System.Drawing.Size(208, 21);
			this._backColorSample1ComboBox.TabIndex = 10;
			this._backColorSample1ComboBox.Text = "comboBox";
			// 
			// _backColorSample2Button
			// 
			this._backColorSample2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._backColorSample2Button.ForeColor = System.Drawing.SystemColors.ControlText;
			this._backColorSample2Button.Location = new System.Drawing.Point(240, 368);
			this._backColorSample2Button.Name = "_backColorSample2Button";
			this._backColorSample2Button.Size = new System.Drawing.Size(168, 32);
			this._backColorSample2Button.TabIndex = 8;
			this._backColorSample2Button.Text = "button";
			// 
			// _backColorSample3GroupBox
			// 
			this._backColorSample3GroupBox.Controls.Add(this._backColorSample4Label);
			this._backColorSample3GroupBox.Location = new System.Drawing.Point(432, 352);
			this._backColorSample3GroupBox.Name = "_backColorSample3GroupBox";
			this._backColorSample3GroupBox.Size = new System.Drawing.Size(320, 56);
			this._backColorSample3GroupBox.TabIndex = 11;
			this._backColorSample3GroupBox.TabStop = false;
			this._backColorSample3GroupBox.Text = "groupBox";
			// 
			// _backColorSample4Label
			// 
			this._backColorSample4Label.Location = new System.Drawing.Point(96, 24);
			this._backColorSample4Label.Name = "_backColorSample4Label";
			this._backColorSample4Label.Size = new System.Drawing.Size(120, 24);
			this._backColorSample4Label.TabIndex = 0;
			this._backColorSample4Label.Text = "label";
			this._backColorSample4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _backColorSample1Animator
			// 
			this._backColorSample1Animator.Control = this._backColorSample1ComboBox;
			this._backColorSample1Animator.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this._backColorSample1Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._backColorSample1Animator.NeverEndingTimer = false;
			this._backColorSample1Animator.StartColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(64)), ((System.Byte)(0)));
			this._backColorSample1Animator.StepSize = 1;
			// 
			// _backColorSample2Animator
			// 
			this._backColorSample2Animator.Control = this._backColorSample2Button;
			this._backColorSample2Animator.EndColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this._backColorSample2Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._backColorSample2Animator.NeverEndingTimer = false;
			this._backColorSample2Animator.ParentAnimator = this._backColorSample1Animator;
			this._backColorSample2Animator.StartColor = System.Drawing.Color.Magenta;
			this._backColorSample2Animator.StepSize = 1;
			// 
			// _backColorSample3Animator
			// 
			this._backColorSample3Animator.Control = this._backColorSample3GroupBox;
			this._backColorSample3Animator.EndColor = System.Drawing.Color.Lime;
			this._backColorSample3Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._backColorSample3Animator.NeverEndingTimer = false;
			this._backColorSample3Animator.ParentAnimator = this._backColorSample1Animator;
			this._backColorSample3Animator.StartColor = System.Drawing.Color.Red;
			this._backColorSample3Animator.StepSize = 1;
			// 
			// _backColorSample4Animator
			// 
			this._backColorSample4Animator.Control = this._backColorSample4Label;
			this._backColorSample4Animator.EndColor = System.Drawing.Color.Red;
			this._backColorSample4Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._backColorSample4Animator.NeverEndingTimer = false;
			this._backColorSample4Animator.ParentAnimator = this._backColorSample1Animator;
			this._backColorSample4Animator.StartColor = System.Drawing.Color.Lime;
			this._backColorSample4Animator.StepSize = 1;
			// 
			// _trackBarValueSample1Animator
			// 
			this._trackBarValueSample1Animator.EndTrackBarValue = 1000;
			this._trackBarValueSample1Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._trackBarValueSample1Animator.NeverEndingTimer = false;
			this._trackBarValueSample1Animator.StepSize = 1;
			this._trackBarValueSample1Animator.TrackBar = this._trackBarValueSample1;
			// 
			// _trackBarValueSample1
			// 
			this._trackBarValueSample1.Location = new System.Drawing.Point(8, 464);
			this._trackBarValueSample1.Maximum = 1000;
			this._trackBarValueSample1.Name = "_trackBarValueSample1";
			this._trackBarValueSample1.Size = new System.Drawing.Size(344, 42);
			this._trackBarValueSample1.TabIndex = 12;
			this._trackBarValueSample1.TickFrequency = 20;
			// 
			// _trackBarValueSample2Animator
			// 
			this._trackBarValueSample2Animator.EndTrackBarValue = 10;
			this._trackBarValueSample2Animator.Intervall = 20;
			this._trackBarValueSample2Animator.LoopMode = Animations.LoopMode.Bidirectional;
			this._trackBarValueSample2Animator.NeverEndingTimer = false;
			this._trackBarValueSample2Animator.StepSize = 1;
			this._trackBarValueSample2Animator.TrackBar = this._trackBarValueSample2;
			// 
			// _trackBarValueSample2
			// 
			this._trackBarValueSample2.Location = new System.Drawing.Point(408, 464);
			this._trackBarValueSample2.Name = "_trackBarValueSample2";
			this._trackBarValueSample2.Size = new System.Drawing.Size(344, 42);
			this._trackBarValueSample2.TabIndex = 12;
			// 
			// _lblTrackBarValueAnimator
			// 
			this._lblTrackBarValueAnimator.Location = new System.Drawing.Point(8, 424);
			this._lblTrackBarValueAnimator.Name = "_lblTrackBarValueAnimator";
			this._lblTrackBarValueAnimator.Size = new System.Drawing.Size(208, 16);
			this._lblTrackBarValueAnimator.TabIndex = 4;
			this._lblTrackBarValueAnimator.Text = "TrackBarValueAnimator";
			// 
			// _groupSeperator7
			// 
			this._groupSeperator7.Location = new System.Drawing.Point(8, 440);
			this._groupSeperator7.Name = "_groupSeperator7";
			this._groupSeperator7.Size = new System.Drawing.Size(744, 8);
			this._groupSeperator7.TabIndex = 3;
			this._groupSeperator7.TabStop = false;
			// 
			// _groupSeperator6
			// 
			this._groupSeperator6.Location = new System.Drawing.Point(8, 408);
			this._groupSeperator6.Name = "_groupSeperator6";
			this._groupSeperator6.Size = new System.Drawing.Size(744, 8);
			this._groupSeperator6.TabIndex = 3;
			this._groupSeperator6.TabStop = false;
			// 
			// AnimationsSample1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(760, 517);
			this.Controls.Add(this._trackBarValueSample1);
			this.Controls.Add(this._backColorSample3GroupBox);
			this.Controls.Add(this._backColorSample1ComboBox);
			this.Controls.Add(this._foreColorSample3GroupBox);
			this.Controls.Add(this._foreColorSample2Button);
			this.Controls.Add(this._foreColorSample1Label);
			this.Controls.Add(this._lblControlBoundsAnimator);
			this.Controls.Add(this._groupSeperator1);
			this.Controls.Add(this._boundsSample3PictureBox);
			this.Controls.Add(this._boundsSample1GroupBox);
			this.Controls.Add(this._boundsSample2Button);
			this.Controls.Add(this._groupSeperator2);
			this.Controls.Add(this._groupSeperator3);
			this.Controls.Add(this._lblControlForeColorAnimator);
			this.Controls.Add(this._groupSeperator5);
			this.Controls.Add(this._lblControlBackColorAnimator);
			this.Controls.Add(this._groupSeperator4);
			this.Controls.Add(this._backColorSample2Button);
			this.Controls.Add(this._lblTrackBarValueAnimator);
			this.Controls.Add(this._groupSeperator7);
			this.Controls.Add(this._groupSeperator6);
			this.Controls.Add(this._trackBarValueSample2);
			this.Name = "AnimationsSample1";
			this.Text = "AnimationsSample1";
			this._boundsSample1GroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._boundsSample1Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._boundsSample2Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._boundsSample3Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._foreColorSample1Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._foreColorSample2Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._foreColorSample3Animator)).EndInit();
			this._foreColorSample3GroupBox.ResumeLayout(false);
			this._backColorSample3GroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._backColorSample1Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._backColorSample2Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._backColorSample3Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._backColorSample4Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample1Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample2Animator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._trackBarValueSample2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void label4_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
