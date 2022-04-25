
namespace PEditor
{
    partial class ChangeLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLanguage));
            this.lblLanguage = new System.Windows.Forms.Label();
            this.countryList = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblCurrLang = new System.Windows.Forms.Label();
            this.currentCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.Location = new System.Drawing.Point(23, 86);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(150, 18);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countryList
            // 
            this.countryList.FormattingEnabled = true;
            this.countryList.Location = new System.Drawing.Point(179, 83);
            this.countryList.Name = "countryList";
            this.countryList.Size = new System.Drawing.Size(188, 26);
            this.countryList.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAccept.Location = new System.Drawing.Point(393, 82);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(141, 28);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblCurrLang
            // 
            this.lblCurrLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrLang.Location = new System.Drawing.Point(105, 27);
            this.lblCurrLang.Name = "lblCurrLang";
            this.lblCurrLang.Size = new System.Drawing.Size(188, 18);
            this.lblCurrLang.TabIndex = 0;
            this.lblCurrLang.Text = "Current Language:";
            this.lblCurrLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentCountry
            // 
            this.currentCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentCountry.Location = new System.Drawing.Point(299, 27);
            this.currentCountry.Name = "currentCountry";
            this.currentCountry.Size = new System.Drawing.Size(188, 18);
            this.currentCountry.TabIndex = 2;
            this.currentCountry.Text = "no country selected";
            this.currentCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(574, 145);
            this.Controls.Add(this.currentCountry);
            this.Controls.Add(this.lblCurrLang);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.countryList);
            this.Controls.Add(this.lblLanguage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeLanguage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Language";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox countryList;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblCurrLang;
        private System.Windows.Forms.Label currentCountry;
    }
}