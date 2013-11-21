using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestApp
{
	public class GradientBorderSample : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RadioButton _rbDiffEasy;
		private Gradients.GradientBorder _gbcDifficulty;
		private System.Windows.Forms.RadioButton _rbDiffHorrible;
		private System.Windows.Forms.RadioButton _rbDiffNormal;
		private System.Windows.Forms.TrackBar _trackbarGradientWidth;
		private Gradients.GradientBorder _gbcGradientWidth;
		private System.Windows.Forms.Label _lblGradientWidth;
		private System.Windows.Forms.ColumnHeader _chName;
		private System.Windows.Forms.ColumnHeader _chDescription;
		private System.Windows.Forms.ColumnHeader _chRating;
		private Gradients.GradientBorder _gbcList;
		private System.Windows.Forms.ListView _lvList;
		private System.Windows.Forms.Label _lblList;
		private System.Windows.Forms.Label _lblDifficulty;
		private Gradients.GradientBorderInnerColorAnimator _gbcacDifficulty;
		private Gradients.GradientBorder gradientBorder1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox _chkShowBackgroundImage;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button _btnChangeBackGroundColor;
		private System.Windows.Forms.ColorDialog _colorDialog;
		private System.Windows.Forms.Button _btnChangeGradientColor;
		private System.Windows.Forms.Button _btnChangeGridForeColor;
		private Image _backImage;

		public GradientBorderSample()
		{
			InitializeComponent();

			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.UserPaint, true);

			_rbDiffEasy.Checked = true;

			_backImage = this.BackgroundImage;
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
																													 "Tutorial 1",
																													 "A tutorial introducing the basic game concepts",
																													 "0"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
																													 "Tutorial 2",
																													 "A tutorial introducing some more advanced game concepts",
																													 "0"}, -1);
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GradientBorderSample));
			this._trackbarGradientWidth = new System.Windows.Forms.TrackBar();
			this._gbcGradientWidth = new Gradients.GradientBorder();
			this._lblGradientWidth = new System.Windows.Forms.Label();
			this._rbDiffEasy = new System.Windows.Forms.RadioButton();
			this._gbcDifficulty = new Gradients.GradientBorder();
			this._rbDiffHorrible = new System.Windows.Forms.RadioButton();
			this._rbDiffNormal = new System.Windows.Forms.RadioButton();
			this._lblDifficulty = new System.Windows.Forms.Label();
			this._gbcList = new Gradients.GradientBorder();
			this._lvList = new System.Windows.Forms.ListView();
			this._chName = new System.Windows.Forms.ColumnHeader();
			this._chDescription = new System.Windows.Forms.ColumnHeader();
			this._chRating = new System.Windows.Forms.ColumnHeader();
			this._lblList = new System.Windows.Forms.Label();
			this._gbcacDifficulty = new Gradients.GradientBorderInnerColorAnimator(this.components);
			this.gradientBorder1 = new Gradients.GradientBorder();
			this._btnChangeGridForeColor = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this._btnChangeGradientColor = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this._btnChangeBackGroundColor = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this._chkShowBackgroundImage = new System.Windows.Forms.CheckBox();
			this._colorDialog = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this._trackbarGradientWidth)).BeginInit();
			this._gbcGradientWidth.SuspendLayout();
			this._gbcDifficulty.SuspendLayout();
			this._gbcList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._gbcacDifficulty)).BeginInit();
			this.gradientBorder1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _trackbarGradientWidth
			// 
			this._trackbarGradientWidth.BackColor = System.Drawing.Color.Violet;
			this._trackbarGradientWidth.Dock = System.Windows.Forms.DockStyle.Fill;
			this._trackbarGradientWidth.Location = new System.Drawing.Point(64, 10);
			this._trackbarGradientWidth.Maximum = 100;
			this._trackbarGradientWidth.Name = "_trackbarGradientWidth";
			this._trackbarGradientWidth.Size = new System.Drawing.Size(462, 44);
			this._trackbarGradientWidth.TabIndex = 2;
			this._trackbarGradientWidth.Value = 40;
			this._trackbarGradientWidth.ValueChanged += new System.EventHandler(this.OnTrackBarGradientWidthScroll);
			this._trackbarGradientWidth.Scroll += new System.EventHandler(this.OnTrackBarGradientWidthScroll);
			// 
			// _gbcGradientWidth
			// 
			this._gbcGradientWidth.BorderWidth = 10;
			this._gbcGradientWidth.Controls.Add(this._trackbarGradientWidth);
			this._gbcGradientWidth.Controls.Add(this._lblGradientWidth);
			this._gbcGradientWidth.DockPadding.All = 10;
			this._gbcGradientWidth.InnerColor = System.Drawing.Color.Violet;
			this._gbcGradientWidth.Location = new System.Drawing.Point(8, 40);
			this._gbcGradientWidth.Name = "_gbcGradientWidth";
			this._gbcGradientWidth.Size = new System.Drawing.Size(536, 64);
			this._gbcGradientWidth.TabIndex = 3;
			// 
			// _lblGradientWidth
			// 
			this._lblGradientWidth.BackColor = System.Drawing.Color.Violet;
			this._lblGradientWidth.Dock = System.Windows.Forms.DockStyle.Left;
			this._lblGradientWidth.Location = new System.Drawing.Point(10, 10);
			this._lblGradientWidth.Name = "_lblGradientWidth";
			this._lblGradientWidth.Size = new System.Drawing.Size(54, 44);
			this._lblGradientWidth.TabIndex = 3;
			this._lblGradientWidth.Text = "Gradient width:";
			this._lblGradientWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _rbDiffEasy
			// 
			this._rbDiffEasy.BackColor = System.Drawing.Color.Yellow;
			this._rbDiffEasy.Dock = System.Windows.Forms.DockStyle.Left;
			this._rbDiffEasy.Location = new System.Drawing.Point(15, 32);
			this._rbDiffEasy.Name = "_rbDiffEasy";
			this._rbDiffEasy.Size = new System.Drawing.Size(66, 17);
			this._rbDiffEasy.TabIndex = 0;
			this._rbDiffEasy.Text = "Easy";
			this._rbDiffEasy.CheckedChanged += new System.EventHandler(this.OnDifficultyCheckedChanged);
			// 
			// _gbcDifficulty
			// 
			this._gbcDifficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._gbcDifficulty.BorderWidth = 15;
			this._gbcDifficulty.Controls.Add(this._rbDiffHorrible);
			this._gbcDifficulty.Controls.Add(this._rbDiffNormal);
			this._gbcDifficulty.Controls.Add(this._rbDiffEasy);
			this._gbcDifficulty.Controls.Add(this._lblDifficulty);
			this._gbcDifficulty.DockPadding.All = 15;
			this._gbcDifficulty.InnerColor = System.Drawing.Color.Yellow;
			this._gbcDifficulty.Location = new System.Drawing.Point(16, 232);
			this._gbcDifficulty.Name = "_gbcDifficulty";
			this._gbcDifficulty.Size = new System.Drawing.Size(224, 64);
			this._gbcDifficulty.TabIndex = 1;
			// 
			// _rbDiffHorrible
			// 
			this._rbDiffHorrible.BackColor = System.Drawing.Color.Yellow;
			this._rbDiffHorrible.Dock = System.Windows.Forms.DockStyle.Fill;
			this._rbDiffHorrible.Location = new System.Drawing.Point(147, 32);
			this._rbDiffHorrible.Name = "_rbDiffHorrible";
			this._rbDiffHorrible.Size = new System.Drawing.Size(62, 17);
			this._rbDiffHorrible.TabIndex = 0;
			this._rbDiffHorrible.Text = "Horrible";
			this._rbDiffHorrible.CheckedChanged += new System.EventHandler(this.OnDifficultyCheckedChanged);
			// 
			// _rbDiffNormal
			// 
			this._rbDiffNormal.BackColor = System.Drawing.Color.Yellow;
			this._rbDiffNormal.Dock = System.Windows.Forms.DockStyle.Left;
			this._rbDiffNormal.Location = new System.Drawing.Point(81, 32);
			this._rbDiffNormal.Name = "_rbDiffNormal";
			this._rbDiffNormal.Size = new System.Drawing.Size(66, 17);
			this._rbDiffNormal.TabIndex = 0;
			this._rbDiffNormal.Text = "Normal";
			this._rbDiffNormal.CheckedChanged += new System.EventHandler(this.OnDifficultyCheckedChanged);
			// 
			// _lblDifficulty
			// 
			this._lblDifficulty.BackColor = System.Drawing.Color.Yellow;
			this._lblDifficulty.Dock = System.Windows.Forms.DockStyle.Top;
			this._lblDifficulty.Location = new System.Drawing.Point(15, 15);
			this._lblDifficulty.Name = "_lblDifficulty";
			this._lblDifficulty.Size = new System.Drawing.Size(194, 17);
			this._lblDifficulty.TabIndex = 1;
			this._lblDifficulty.Text = "Choose difficulty:";
			// 
			// _gbcList
			// 
			this._gbcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._gbcList.BorderWidth = 40;
			this._gbcList.Controls.Add(this._lvList);
			this._gbcList.Controls.Add(this._lblList);
			this._gbcList.DockPadding.All = 40;
			this._gbcList.InnerColor = System.Drawing.Color.Blue;
			this._gbcList.Location = new System.Drawing.Point(0, 304);
			this._gbcList.Name = "_gbcList";
			this._gbcList.Size = new System.Drawing.Size(664, 280);
			this._gbcList.TabIndex = 4;
			// 
			// _lvList
			// 
			this._lvList.BackColor = System.Drawing.Color.Blue;
			this._lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this._chName,
																					  this._chDescription,
																					  this._chRating});
			this._lvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lvList.ForeColor = System.Drawing.Color.White;
			this._lvList.FullRowSelect = true;
			this._lvList.GridLines = true;
			this._lvList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
																					listViewItem1,
																					listViewItem2});
			this._lvList.Location = new System.Drawing.Point(40, 72);
			this._lvList.Name = "_lvList";
			this._lvList.Size = new System.Drawing.Size(584, 168);
			this._lvList.TabIndex = 2;
			this._lvList.View = System.Windows.Forms.View.Details;
			// 
			// _chName
			// 
			this._chName.Text = "Name";
			this._chName.Width = 100;
			// 
			// _chDescription
			// 
			this._chDescription.Text = "Description";
			this._chDescription.Width = 400;
			// 
			// _chRating
			// 
			this._chRating.Text = "Rating";
			this._chRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _lblList
			// 
			this._lblList.BackColor = System.Drawing.Color.Blue;
			this._lblList.Dock = System.Windows.Forms.DockStyle.Top;
			this._lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._lblList.ForeColor = System.Drawing.Color.White;
			this._lblList.Location = new System.Drawing.Point(40, 40);
			this._lblList.Name = "_lblList";
			this._lblList.Size = new System.Drawing.Size(584, 32);
			this._lblList.TabIndex = 0;
			this._lblList.Text = "Choose from list:";
			this._lblList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// _gbcacDifficulty
			// 
			this._gbcacDifficulty.CurrentStep = 0;
			this._gbcacDifficulty.CurrentValue = System.Drawing.Color.Yellow;
			this._gbcacDifficulty.EndColor = System.Drawing.Color.Yellow;
			this._gbcacDifficulty.EndValue = System.Drawing.Color.Yellow;
			this._gbcacDifficulty.GradientBorder = this._gbcDifficulty;
			this._gbcacDifficulty.StartValue = System.Drawing.Color.Empty;
			// 
			// gradientBorder1
			// 
			this.gradientBorder1.BorderWidth = 50;
			this.gradientBorder1.Controls.Add(this._btnChangeGridForeColor);
			this.gradientBorder1.Controls.Add(this.panel3);
			this.gradientBorder1.Controls.Add(this._btnChangeGradientColor);
			this.gradientBorder1.Controls.Add(this.panel2);
			this.gradientBorder1.Controls.Add(this._btnChangeBackGroundColor);
			this.gradientBorder1.Controls.Add(this.panel1);
			this.gradientBorder1.Controls.Add(this._chkShowBackgroundImage);
			this.gradientBorder1.DockPadding.All = 50;
			this.gradientBorder1.InnerColor = System.Drawing.SystemColors.Control;
			this.gradientBorder1.Location = new System.Drawing.Point(536, 0);
			this.gradientBorder1.Name = "gradientBorder1";
			this.gradientBorder1.Size = new System.Drawing.Size(248, 200);
			this.gradientBorder1.TabIndex = 7;
			// 
			// _btnChangeGridForeColor
			// 
			this._btnChangeGridForeColor.BackColor = System.Drawing.SystemColors.Control;
			this._btnChangeGridForeColor.Dock = System.Windows.Forms.DockStyle.Top;
			this._btnChangeGridForeColor.Location = new System.Drawing.Point(50, 122);
			this._btnChangeGridForeColor.Name = "_btnChangeGridForeColor";
			this._btnChangeGridForeColor.Size = new System.Drawing.Size(148, 23);
			this._btnChangeGridForeColor.TabIndex = 6;
			this._btnChangeGridForeColor.Text = "Change grid forecolor";
			this._btnChangeGridForeColor.Click += new System.EventHandler(this.OnChangeGridForeColorClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(50, 118);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(148, 4);
			this.panel3.TabIndex = 5;
			// 
			// _btnChangeGradientColor
			// 
			this._btnChangeGradientColor.BackColor = System.Drawing.SystemColors.Control;
			this._btnChangeGradientColor.Dock = System.Windows.Forms.DockStyle.Top;
			this._btnChangeGradientColor.Location = new System.Drawing.Point(50, 95);
			this._btnChangeGradientColor.Name = "_btnChangeGradientColor";
			this._btnChangeGradientColor.Size = new System.Drawing.Size(148, 23);
			this._btnChangeGradientColor.TabIndex = 4;
			this._btnChangeGradientColor.Text = "Change gradient color";
			this._btnChangeGradientColor.Click += new System.EventHandler(this.OnChangeGradientColorClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(50, 91);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(148, 4);
			this.panel2.TabIndex = 3;
			// 
			// _btnChangeBackGroundColor
			// 
			this._btnChangeBackGroundColor.BackColor = System.Drawing.SystemColors.Control;
			this._btnChangeBackGroundColor.Dock = System.Windows.Forms.DockStyle.Top;
			this._btnChangeBackGroundColor.Location = new System.Drawing.Point(50, 68);
			this._btnChangeBackGroundColor.Name = "_btnChangeBackGroundColor";
			this._btnChangeBackGroundColor.Size = new System.Drawing.Size(148, 23);
			this._btnChangeBackGroundColor.TabIndex = 1;
			this._btnChangeBackGroundColor.Text = "Change background color";
			this._btnChangeBackGroundColor.Click += new System.EventHandler(this.OnChangeBackGroundColorClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(50, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(148, 4);
			this.panel1.TabIndex = 2;
			// 
			// _chkShowBackgroundImage
			// 
			this._chkShowBackgroundImage.BackColor = System.Drawing.SystemColors.Control;
			this._chkShowBackgroundImage.Checked = true;
			this._chkShowBackgroundImage.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkShowBackgroundImage.Dock = System.Windows.Forms.DockStyle.Top;
			this._chkShowBackgroundImage.Location = new System.Drawing.Point(50, 50);
			this._chkShowBackgroundImage.Name = "_chkShowBackgroundImage";
			this._chkShowBackgroundImage.Size = new System.Drawing.Size(148, 14);
			this._chkShowBackgroundImage.TabIndex = 0;
			this._chkShowBackgroundImage.Text = "Show background image";
			this._chkShowBackgroundImage.CheckedChanged += new System.EventHandler(this.OnShowBackgroundImageCheckedChanged);
			// 
			// _colorDialog
			// 
			this._colorDialog.AnyColor = true;
			this._colorDialog.FullOpen = true;
			// 
			// GradientBorderSample
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(784, 581);
			this.Controls.Add(this._gbcList);
			this.Controls.Add(this._gbcGradientWidth);
			this.Controls.Add(this._gbcDifficulty);
			this.Controls.Add(this.gradientBorder1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GradientBorderSample";
			this.Text = "Sample 1";
			((System.ComponentModel.ISupportInitialize)(this._trackbarGradientWidth)).EndInit();
			this._gbcGradientWidth.ResumeLayout(false);
			this._gbcDifficulty.ResumeLayout(false);
			this._gbcList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._gbcacDifficulty)).EndInit();
			this.gradientBorder1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void OnTrackBarGradientWidthScroll(object sender, System.EventArgs e)
		{
			_gbcList.BorderWidth = _trackbarGradientWidth.Value;
		}

		private void OnDifficultyCheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked)
			{
				if (sender == _rbDiffEasy)
					_gbcacDifficulty.Start(Color.Yellow);
				else if (sender == _rbDiffNormal)
					_gbcacDifficulty.Start(Color.Orange);
				else if (sender == _rbDiffHorrible)
					_gbcacDifficulty.Start(Color.Red);
			}
		}

		private void OnShowBackgroundImageCheckedChanged(object sender, System.EventArgs e)
		{
			this.BackgroundImage = _chkShowBackgroundImage.Checked ? _backImage : null;
		}

		private void OnChangeBackGroundColorClick(object sender, System.EventArgs e)
		{
			_colorDialog.Color = this.BackColor;
			if (_colorDialog.ShowDialog() == DialogResult.OK)
				this.BackColor = _colorDialog.Color;
		}

		private void OnChangeGradientColorClick(object sender, System.EventArgs e)
		{
			_colorDialog.Color = _gbcList.InnerColor;
			if (_colorDialog.ShowDialog() == DialogResult.OK)
				_gbcList.InnerColor = _colorDialog.Color;
		}

		private void OnChangeGridForeColorClick(object sender, System.EventArgs e)
		{
			_colorDialog.Color = _lvList.ForeColor;
			if (_colorDialog.ShowDialog() == DialogResult.OK)
			{
				_lvList.ForeColor = _colorDialog.Color;
				_lblList.ForeColor = _colorDialog.Color;
			}
		}
	}
}
