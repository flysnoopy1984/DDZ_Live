using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace TestApp
{
	public class AnchorControl : System.Windows.Forms.UserControl
	{		
		public event EventHandler ContentAlignmentChanged;
		private System.Drawing.ContentAlignment _contentAlingment;
		private System.Windows.Forms.RadioButton _rdAnchorBC;
		private System.Windows.Forms.RadioButton _rdAnchorTR;
		private System.Windows.Forms.RadioButton _rdAnchorTC;
		private System.Windows.Forms.RadioButton _rdAnchorBR;
		private System.Windows.Forms.RadioButton _rdAnchorTL;
		private System.Windows.Forms.RadioButton _rdAnchorCC;
		private System.Windows.Forms.RadioButton _rdAnchorCR;
		private System.Windows.Forms.RadioButton _rdAnchorCL;
		private System.Windows.Forms.RadioButton _rdAnchorBL;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnchorControl()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			// TODO: Initialisierungen nach dem Aufruf von InitializeComponent hinzufügen

		}


		public void Initialize(System.Drawing.ContentAlignment contentAlignment)
		{
			switch(contentAlignment)
			{
				case (System.Drawing.ContentAlignment.TopLeft):  _rdAnchorTL.Checked = true; break;
				case (System.Drawing.ContentAlignment.TopCenter):  _rdAnchorTC.Checked = true; break;
				case (System.Drawing.ContentAlignment.TopRight):  _rdAnchorTR.Checked = true; break;
				case (System.Drawing.ContentAlignment.MiddleLeft):  _rdAnchorCL.Checked = true; break;
				case (System.Drawing.ContentAlignment.MiddleCenter):  _rdAnchorCC.Checked = true; break;
				case (System.Drawing.ContentAlignment.MiddleRight):  _rdAnchorCR.Checked = true; break;
				case (System.Drawing.ContentAlignment.BottomLeft):  _rdAnchorBL.Checked = true; break;
				case (System.Drawing.ContentAlignment.BottomCenter):  _rdAnchorBC.Checked = true; break;
				case (System.Drawing.ContentAlignment.BottomRight):  _rdAnchorBR.Checked = true; break;
				default: _rdAnchorCC.Checked = true; break;
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AnchorControl));
			this._rdAnchorBC = new System.Windows.Forms.RadioButton();
			this._rdAnchorTR = new System.Windows.Forms.RadioButton();
			this._rdAnchorTC = new System.Windows.Forms.RadioButton();
			this._rdAnchorBR = new System.Windows.Forms.RadioButton();
			this._rdAnchorTL = new System.Windows.Forms.RadioButton();
			this._rdAnchorCC = new System.Windows.Forms.RadioButton();
			this._rdAnchorCR = new System.Windows.Forms.RadioButton();
			this._rdAnchorCL = new System.Windows.Forms.RadioButton();
			this._rdAnchorBL = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// _rdAnchorBC
			// 
			this._rdAnchorBC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._rdAnchorBC.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorBC.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorBC.Image")));
			this._rdAnchorBC.Location = new System.Drawing.Point(22, 41);
			this._rdAnchorBC.Name = "_rdAnchorBC";
			this._rdAnchorBC.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorBC.TabIndex = 16;
			this._rdAnchorBC.CheckedChanged += new System.EventHandler(this._rdAnchorBC_CheckedChanged);
			// 
			// _rdAnchorTR
			// 
			this._rdAnchorTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._rdAnchorTR.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorTR.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorTR.Image")));
			this._rdAnchorTR.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this._rdAnchorTR.Location = new System.Drawing.Point(42, 1);
			this._rdAnchorTR.Name = "_rdAnchorTR";
			this._rdAnchorTR.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorTR.TabIndex = 11;
			this._rdAnchorTR.CheckedChanged += new System.EventHandler(this._rdAnchorTR_CheckedChanged);
			// 
			// _rdAnchorTC
			// 
			this._rdAnchorTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._rdAnchorTC.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorTC.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorTC.Image")));
			this._rdAnchorTC.Location = new System.Drawing.Point(22, 1);
			this._rdAnchorTC.Name = "_rdAnchorTC";
			this._rdAnchorTC.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorTC.TabIndex = 10;
			this._rdAnchorTC.CheckedChanged += new System.EventHandler(this._rdAnchorTC_CheckedChanged);
			// 
			// _rdAnchorBR
			// 
			this._rdAnchorBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._rdAnchorBR.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorBR.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorBR.Image")));
			this._rdAnchorBR.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this._rdAnchorBR.Location = new System.Drawing.Point(42, 41);
			this._rdAnchorBR.Name = "_rdAnchorBR";
			this._rdAnchorBR.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorBR.TabIndex = 17;
			this._rdAnchorBR.CheckedChanged += new System.EventHandler(this._rdAnchorBR_CheckedChanged);
			// 
			// _rdAnchorTL
			// 
			this._rdAnchorTL.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorTL.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorTL.Image")));
			this._rdAnchorTL.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this._rdAnchorTL.Location = new System.Drawing.Point(2, 1);
			this._rdAnchorTL.Name = "_rdAnchorTL";
			this._rdAnchorTL.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorTL.TabIndex = 9;
			this._rdAnchorTL.CheckedChanged += new System.EventHandler(this._rdAnchorTL_CheckedChanged);
			// 
			// _rdAnchorCC
			// 
			this._rdAnchorCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._rdAnchorCC.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorCC.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorCC.Image")));
			this._rdAnchorCC.Location = new System.Drawing.Point(22, 21);
			this._rdAnchorCC.Name = "_rdAnchorCC";
			this._rdAnchorCC.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorCC.TabIndex = 13;
			this._rdAnchorCC.CheckedChanged += new System.EventHandler(this._rdAnchorCC_CheckedChanged);
			// 
			// _rdAnchorCR
			// 
			this._rdAnchorCR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._rdAnchorCR.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorCR.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorCR.Image")));
			this._rdAnchorCR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._rdAnchorCR.Location = new System.Drawing.Point(42, 21);
			this._rdAnchorCR.Name = "_rdAnchorCR";
			this._rdAnchorCR.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorCR.TabIndex = 14;
			this._rdAnchorCR.CheckedChanged += new System.EventHandler(this._rdAnchorCR_CheckedChanged);
			// 
			// _rdAnchorCL
			// 
			this._rdAnchorCL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this._rdAnchorCL.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorCL.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorCL.Image")));
			this._rdAnchorCL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._rdAnchorCL.Location = new System.Drawing.Point(2, 21);
			this._rdAnchorCL.Name = "_rdAnchorCL";
			this._rdAnchorCL.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorCL.TabIndex = 12;
			this._rdAnchorCL.CheckedChanged += new System.EventHandler(this._rdAnchorCL_CheckedChanged);
			// 
			// _rdAnchorBL
			// 
			this._rdAnchorBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._rdAnchorBL.Appearance = System.Windows.Forms.Appearance.Button;
			this._rdAnchorBL.Image = ((System.Drawing.Image)(resources.GetObject("_rdAnchorBL.Image")));
			this._rdAnchorBL.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this._rdAnchorBL.Location = new System.Drawing.Point(2, 41);
			this._rdAnchorBL.Name = "_rdAnchorBL";
			this._rdAnchorBL.Size = new System.Drawing.Size(20, 20);
			this._rdAnchorBL.TabIndex = 15;
			this._rdAnchorBL.CheckedChanged += new System.EventHandler(this._rdAnchorBL_CheckedChanged);
			// 
			// AnchorControl
			// 
			this.Controls.Add(this._rdAnchorBC);
			this.Controls.Add(this._rdAnchorTR);
			this.Controls.Add(this._rdAnchorTC);
			this.Controls.Add(this._rdAnchorBR);
			this.Controls.Add(this._rdAnchorTL);
			this.Controls.Add(this._rdAnchorCC);
			this.Controls.Add(this._rdAnchorCR);
			this.Controls.Add(this._rdAnchorCL);
			this.Controls.Add(this._rdAnchorBL);
			this.Name = "AnchorControl";
			this.Size = new System.Drawing.Size(64, 64);
			this.ResumeLayout(false);

		}
		#endregion

		private void _rdAnchorCC_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.MiddleCenter);	
		}


		private void ChangeAlignment(System.Drawing.ContentAlignment contentAlignment)
		{
			_contentAlingment = contentAlignment;
			if (ContentAlignmentChanged != null)
			{
				ContentAlignmentChanged(this,EventArgs.Empty);
			}
		}

		private void _rdAnchorCR_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.MiddleRight);	
		}

		private void _rdAnchorCL_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.MiddleLeft);	
		}

		private void _rdAnchorTL_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.TopLeft);	
		}

		private void _rdAnchorTC_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.TopCenter);	

		}

		private void _rdAnchorTR_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.TopRight);	
		}

		private void _rdAnchorBL_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.BottomLeft);	
		}

		private void _rdAnchorBC_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.BottomCenter);	
		}

		private void _rdAnchorBR_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ChangeAlignment(System.Drawing.ContentAlignment.BottomRight);	
		}

		public System.Drawing.ContentAlignment CurrentContentAlignment
		{
			get{return _contentAlingment;}
			set { Initialize(value); }
		}

		public void Enable(bool value)
		{
			_rdAnchorTL.Enabled = value;
			_rdAnchorTC.Enabled = value;
			_rdAnchorTR.Enabled = value;
			_rdAnchorCL.Enabled = value;
			_rdAnchorCC.Enabled = value;
			_rdAnchorCR.Enabled = value;
			_rdAnchorBL.Enabled = value;
			_rdAnchorBC.Enabled = value;
			_rdAnchorBR.Enabled = value;
		}
	}
}
