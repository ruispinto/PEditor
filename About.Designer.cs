
namespace PEditor
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lblNotShow = new System.Windows.Forms.Label();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btncloseAbout = new System.Windows.Forms.Button();
            this.lblupdateData = new System.Windows.Forms.Label();
            this.lblSoftName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotShow
            // 
            this.lblNotShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblNotShow.Location = new System.Drawing.Point(334, 452);
            this.lblNotShow.Name = "lblNotShow";
            this.lblNotShow.Size = new System.Drawing.Size(110, 17);
            this.lblNotShow.TabIndex = 0;
            this.lblNotShow.Text = "Do not show";
            this.lblNotShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNotShow.Visible = false;
            // 
            // chkShow
            // 
            this.chkShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShow.AutoSize = true;
            this.chkShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.chkShow.Location = new System.Drawing.Point(445, 455);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(15, 14);
            this.chkShow.TabIndex = 2;
            this.chkShow.TabStop = false;
            this.chkShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShow.UseVisualStyleBackColor = true;
            this.chkShow.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(170, 455);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(165, 17);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version 1.1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGreeting
            // 
            this.lblGreeting.Location = new System.Drawing.Point(9, 354);
            this.lblGreeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(449, 43);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "<greeting>";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PEditor.Properties.Resources.postcards;
            this.pictureBox1.InitialImage = global::PEditor.Properties.Resources.postcards;
            this.pictureBox1.Location = new System.Drawing.Point(65, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(3, 455);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(169, 17);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "©";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncloseAbout
            // 
            this.btncloseAbout.BackColor = System.Drawing.Color.Silver;
            this.btncloseAbout.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseAbout.ForeColor = System.Drawing.Color.Black;
            this.btncloseAbout.Location = new System.Drawing.Point(154, 412);
            this.btncloseAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncloseAbout.Name = "btncloseAbout";
            this.btncloseAbout.Size = new System.Drawing.Size(143, 37);
            this.btncloseAbout.TabIndex = 1;
            this.btncloseAbout.Text = "&Close";
            this.btncloseAbout.UseVisualStyleBackColor = false;
            this.btncloseAbout.Click += new System.EventHandler(this.btncloseAbout_Click);
            // 
            // lblupdateData
            // 
            this.lblupdateData.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdateData.Location = new System.Drawing.Point(6, 49);
            this.lblupdateData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblupdateData.Name = "lblupdateData";
            this.lblupdateData.Size = new System.Drawing.Size(452, 23);
            this.lblupdateData.TabIndex = 0;
            this.lblupdateData.Text = "software update date";
            this.lblupdateData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoftName
            // 
            this.lblSoftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftName.Location = new System.Drawing.Point(6, 22);
            this.lblSoftName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoftName.Name = "lblSoftName";
            this.lblSoftName.Size = new System.Drawing.Size(452, 26);
            this.lblSoftName.TabIndex = 0;
            this.lblSoftName.Text = "software name";
            this.lblSoftName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(456, 470);
            this.ControlBox = false;
            this.Controls.Add(this.lblNotShow);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btncloseAbout);
            this.Controls.Add(this.lblupdateData);
            this.Controls.Add(this.lblSoftName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotShow;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btncloseAbout;
        private System.Windows.Forms.Label lblupdateData;
        private System.Windows.Forms.Label lblSoftName;
    }
}