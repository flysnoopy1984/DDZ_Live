namespace DDZProj
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bn_Post = new System.Windows.Forms.Button();
            this.p_QA = new System.Windows.Forms.Panel();
            this.p_QB = new System.Windows.Forms.Panel();
            this.p_QC = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bn_Post
            // 
            this.bn_Post.Location = new System.Drawing.Point(1095, 1);
            this.bn_Post.Name = "bn_Post";
            this.bn_Post.Size = new System.Drawing.Size(75, 23);
            this.bn_Post.TabIndex = 3;
            this.bn_Post.Text = "Post";
            this.bn_Post.UseVisualStyleBackColor = true;
            this.bn_Post.Click += new System.EventHandler(this.bn_Post_Click);
            // 
            // p_QA
            // 
            this.p_QA.BackColor = System.Drawing.Color.Transparent;
            this.p_QA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_QA.Location = new System.Drawing.Point(317, 12);
            this.p_QA.Name = "p_QA";
            this.p_QA.Size = new System.Drawing.Size(390, 302);
            this.p_QA.TabIndex = 4;
            // 
            // p_QB
            // 
            this.p_QB.BackColor = System.Drawing.Color.Transparent;
            this.p_QB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_QB.Location = new System.Drawing.Point(12, 320);
            this.p_QB.Name = "p_QB";
            this.p_QB.Size = new System.Drawing.Size(390, 302);
            this.p_QB.TabIndex = 6;
            // 
            // p_QC
            // 
            this.p_QC.BackColor = System.Drawing.Color.Transparent;
            this.p_QC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_QC.Location = new System.Drawing.Point(713, 12);
            this.p_QC.Name = "p_QC";
            this.p_QC.Size = new System.Drawing.Size(390, 302);
            this.p_QC.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1171, 696);
            this.Controls.Add(this.p_QB);
            this.Controls.Add(this.p_QC);
            this.Controls.Add(this.p_QA);
            this.Controls.Add(this.bn_Post);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_Post;
        private System.Windows.Forms.Panel p_QA;
        private System.Windows.Forms.Panel p_QB;
        private System.Windows.Forms.Panel p_QC;
    }
}

