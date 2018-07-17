namespace NategMailsSender
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.UserNotes = new System.Windows.Forms.GroupBox();
            this.UserNoteLabel = new System.Windows.Forms.Label();
            this.License = new System.Windows.Forms.GroupBox();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.Support = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ContactBox = new System.Windows.Forms.GroupBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.UserNotes.SuspendLayout();
            this.License.SuspendLayout();
            this.ContactBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNotes
            // 
            this.UserNotes.Controls.Add(this.UserNoteLabel);
            this.UserNotes.Location = new System.Drawing.Point(12, 12);
            this.UserNotes.Name = "UserNotes";
            this.UserNotes.Size = new System.Drawing.Size(404, 126);
            this.UserNotes.TabIndex = 0;
            this.UserNotes.TabStop = false;
            this.UserNotes.Text = "User Notes";
            // 
            // UserNoteLabel
            // 
            this.UserNoteLabel.AutoSize = true;
            this.UserNoteLabel.Location = new System.Drawing.Point(7, 26);
            this.UserNoteLabel.Name = "UserNoteLabel";
            this.UserNoteLabel.Size = new System.Drawing.Size(385, 78);
            this.UserNoteLabel.TabIndex = 0;
            this.UserNoteLabel.Text = resources.GetString("UserNoteLabel.Text");
            // 
            // License
            // 
            this.License.Controls.Add(this.LicenseLabel);
            this.License.Location = new System.Drawing.Point(12, 146);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(404, 71);
            this.License.TabIndex = 1;
            this.License.TabStop = false;
            this.License.Text = "License";
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Location = new System.Drawing.Point(7, 23);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(376, 39);
            this.LicenseLabel.TabIndex = 0;
            this.LicenseLabel.Text = "This software is under Mèhdi Ben Hamida property, and it\'s distributed under a \r\n" +
    "free and open source MIT license. More Informations on software repository in \r\n" +
    "github.\r\n";
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(63, 294);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(276, 13);
            this.GithubLink.TabIndex = 1;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "https://github.com/MehdiBenHamida/NategMailsSender";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // Support
            // 
            this.Support.AutoSize = true;
            this.Support.Location = new System.Drawing.Point(148, 313);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(109, 13);
            this.Support.TabIndex = 2;
            this.Support.Text = "Support open source.";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(341, 330);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ContactBox
            // 
            this.ContactBox.Controls.Add(this.ContactLabel);
            this.ContactBox.Location = new System.Drawing.Point(12, 226);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(404, 60);
            this.ContactBox.TabIndex = 4;
            this.ContactBox.TabStop = false;
            this.ContactBox.Text = "Contact";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(7, 22);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(186, 26);
            this.ContactLabel.TabIndex = 0;
            this.ContactLabel.Text = "Email: mehdi.benhamida@ensi-uma.tn\r\nTel: +216 23 922 380";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 360);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.Support);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.License);
            this.Controls.Add(this.UserNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.UserNotes.ResumeLayout(false);
            this.UserNotes.PerformLayout();
            this.License.ResumeLayout(false);
            this.License.PerformLayout();
            this.ContactBox.ResumeLayout(false);
            this.ContactBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UserNotes;
        private System.Windows.Forms.GroupBox License;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.Label UserNoteLabel;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.Label Support;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox ContactBox;
        private System.Windows.Forms.Label ContactLabel;
    }
}