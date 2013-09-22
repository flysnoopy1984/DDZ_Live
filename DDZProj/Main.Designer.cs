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
            this.bn_Begin = new System.Windows.Forms.Button();
            this.bn_Post = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bn_Begin
            // 
            this.bn_Begin.Location = new System.Drawing.Point(12, 25);
            this.bn_Begin.Name = "bn_Begin";
            this.bn_Begin.Size = new System.Drawing.Size(75, 23);
            this.bn_Begin.TabIndex = 2;
            this.bn_Begin.Text = "Begin";
            this.bn_Begin.UseVisualStyleBackColor = true;
            this.bn_Begin.Click += new System.EventHandler(this.bn_Begin_Click);
            // 
            // bn_Post
            // 
            this.bn_Post.Location = new System.Drawing.Point(119, 24);
            this.bn_Post.Name = "bn_Post";
            this.bn_Post.Size = new System.Drawing.Size(75, 23);
            this.bn_Post.TabIndex = 3;
            this.bn_Post.Text = "Post";
            this.bn_Post.UseVisualStyleBackColor = true;
            this.bn_Post.Click += new System.EventHandler(this.bn_Post_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1171, 696);
            this.Controls.Add(this.bn_Post);
            this.Controls.Add(this.bn_Begin);
            this.Name = "Main";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bn_Begin;
        private System.Windows.Forms.Button bn_Post;
    }
}

