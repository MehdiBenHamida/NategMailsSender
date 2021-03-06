﻿namespace NategMailsSender
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Configuration = new System.Windows.Forms.Button();
            this.SendingProgress = new System.Windows.Forms.ProgressBar();
            this.ProgressBox = new System.Windows.Forms.GroupBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.Label();
            this.SendingLabel = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.GroupBox();
            this.DearTopMessage = new System.Windows.Forms.CheckBox();
            this.Attachement = new System.Windows.Forms.CheckBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.MailContent = new System.Windows.Forms.TextBox();
            this.MailSubject = new System.Windows.Forms.TextBox();
            this.AttachementBox = new System.Windows.Forms.GroupBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AttachementBrowse = new System.Windows.Forms.Button();
            this.AttachementPath = new System.Windows.Forms.TextBox();
            this.CustomFiles = new System.Windows.Forms.RadioButton();
            this.CommonFiles = new System.Windows.Forms.RadioButton();
            this.Receivers = new System.Windows.Forms.OpenFileDialog();
            this.SendMails = new System.Windows.Forms.Button();
            this.CustomFilesBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.CommonFilesBrowse = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Help = new System.Windows.Forms.Button();
            this.ProgressBox.SuspendLayout();
            this.MailBox.SuspendLayout();
            this.AttachementBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Configuration
            // 
            this.Configuration.Location = new System.Drawing.Point(311, 12);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(78, 23);
            this.Configuration.TabIndex = 0;
            this.Configuration.Text = "Configuration";
            this.Configuration.UseVisualStyleBackColor = true;
            this.Configuration.Click += new System.EventHandler(this.Configuration_Click);
            // 
            // SendingProgress
            // 
            this.SendingProgress.Location = new System.Drawing.Point(6, 47);
            this.SendingProgress.Name = "SendingProgress";
            this.SendingProgress.Size = new System.Drawing.Size(445, 23);
            this.SendingProgress.TabIndex = 1;
            // 
            // ProgressBox
            // 
            this.ProgressBox.Controls.Add(this.CancelBtn);
            this.ProgressBox.Controls.Add(this.Percentage);
            this.ProgressBox.Controls.Add(this.SendingLabel);
            this.ProgressBox.Controls.Add(this.SendingProgress);
            this.ProgressBox.Location = new System.Drawing.Point(12, 446);
            this.ProgressBox.Name = "ProgressBox";
            this.ProgressBox.Size = new System.Drawing.Size(458, 138);
            this.ProgressBox.TabIndex = 2;
            this.ProgressBox.TabStop = false;
            this.ProgressBox.Text = "Progress";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(373, 109);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Location = new System.Drawing.Point(6, 31);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(24, 13);
            this.Percentage.TabIndex = 3;
            this.Percentage.Text = "0 %";
            // 
            // SendingLabel
            // 
            this.SendingLabel.AutoSize = true;
            this.SendingLabel.Location = new System.Drawing.Point(6, 82);
            this.SendingLabel.Name = "SendingLabel";
            this.SendingLabel.Size = new System.Drawing.Size(102, 13);
            this.SendingLabel.TabIndex = 3;
            this.SendingLabel.Text = "Mails Configuaration";
            // 
            // MailBox
            // 
            this.MailBox.Controls.Add(this.DearTopMessage);
            this.MailBox.Controls.Add(this.Attachement);
            this.MailBox.Controls.Add(this.ContentLabel);
            this.MailBox.Controls.Add(this.SubjectLabel);
            this.MailBox.Controls.Add(this.MailContent);
            this.MailBox.Controls.Add(this.MailSubject);
            this.MailBox.Location = new System.Drawing.Point(12, 41);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(458, 261);
            this.MailBox.TabIndex = 3;
            this.MailBox.TabStop = false;
            this.MailBox.Text = "Mail";
            // 
            // DearTopMessage
            // 
            this.DearTopMessage.AutoSize = true;
            this.DearTopMessage.Location = new System.Drawing.Point(103, 58);
            this.DearTopMessage.Name = "DearTopMessage";
            this.DearTopMessage.Size = new System.Drawing.Size(95, 17);
            this.DearTopMessage.TabIndex = 9;
            this.DearTopMessage.Text = "Dear <Name>,";
            this.DearTopMessage.UseVisualStyleBackColor = true;
            // 
            // Attachement
            // 
            this.Attachement.AutoSize = true;
            this.Attachement.Location = new System.Drawing.Point(103, 228);
            this.Attachement.Name = "Attachement";
            this.Attachement.Size = new System.Drawing.Size(86, 17);
            this.Attachement.TabIndex = 8;
            this.Attachement.Text = "Attachement";
            this.Attachement.UseVisualStyleBackColor = true;
            this.Attachement.CheckedChanged += new System.EventHandler(this.Attachement_CheckedChanged);
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(42, 89);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(47, 13);
            this.ContentLabel.TabIndex = 5;
            this.ContentLabel.Text = "Content:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(42, 30);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(49, 13);
            this.SubjectLabel.TabIndex = 4;
            this.SubjectLabel.Text = "Subject: ";
            // 
            // MailContent
            // 
            this.MailContent.Location = new System.Drawing.Point(103, 86);
            this.MailContent.Multiline = true;
            this.MailContent.Name = "MailContent";
            this.MailContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MailContent.Size = new System.Drawing.Size(345, 127);
            this.MailContent.TabIndex = 1;
            // 
            // MailSubject
            // 
            this.MailSubject.Location = new System.Drawing.Point(103, 27);
            this.MailSubject.Name = "MailSubject";
            this.MailSubject.Size = new System.Drawing.Size(345, 20);
            this.MailSubject.TabIndex = 0;
            // 
            // AttachementBox
            // 
            this.AttachementBox.Controls.Add(this.ModeLabel);
            this.AttachementBox.Controls.Add(this.label1);
            this.AttachementBox.Controls.Add(this.AttachementBrowse);
            this.AttachementBox.Controls.Add(this.AttachementPath);
            this.AttachementBox.Controls.Add(this.CustomFiles);
            this.AttachementBox.Controls.Add(this.CommonFiles);
            this.AttachementBox.Location = new System.Drawing.Point(12, 308);
            this.AttachementBox.Name = "AttachementBox";
            this.AttachementBox.Size = new System.Drawing.Size(458, 100);
            this.AttachementBox.TabIndex = 0;
            this.AttachementBox.TabStop = false;
            this.AttachementBox.Text = "Attachement";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(52, 23);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(37, 13);
            this.ModeLabel.TabIndex = 5;
            this.ModeLabel.Text = "Mode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Path:";
            // 
            // AttachementBrowse
            // 
            this.AttachementBrowse.Location = new System.Drawing.Point(373, 54);
            this.AttachementBrowse.Name = "AttachementBrowse";
            this.AttachementBrowse.Size = new System.Drawing.Size(75, 23);
            this.AttachementBrowse.TabIndex = 3;
            this.AttachementBrowse.Text = "Browse";
            this.AttachementBrowse.UseVisualStyleBackColor = true;
            this.AttachementBrowse.Click += new System.EventHandler(this.AttachementBrowse_Click);
            // 
            // AttachementPath
            // 
            this.AttachementPath.Enabled = false;
            this.AttachementPath.Location = new System.Drawing.Point(103, 56);
            this.AttachementPath.Name = "AttachementPath";
            this.AttachementPath.Size = new System.Drawing.Size(265, 20);
            this.AttachementPath.TabIndex = 2;
            // 
            // CustomFiles
            // 
            this.CustomFiles.AutoSize = true;
            this.CustomFiles.Location = new System.Drawing.Point(278, 19);
            this.CustomFiles.Name = "CustomFiles";
            this.CustomFiles.Size = new System.Drawing.Size(84, 17);
            this.CustomFiles.TabIndex = 1;
            this.CustomFiles.TabStop = true;
            this.CustomFiles.Text = "Custom Files";
            this.CustomFiles.UseVisualStyleBackColor = true;
            this.CustomFiles.CheckedChanged += new System.EventHandler(this.CustomFiles_CheckedChanged);
            // 
            // CommonFiles
            // 
            this.CommonFiles.AutoSize = true;
            this.CommonFiles.Location = new System.Drawing.Point(115, 19);
            this.CommonFiles.Name = "CommonFiles";
            this.CommonFiles.Size = new System.Drawing.Size(85, 17);
            this.CommonFiles.TabIndex = 0;
            this.CommonFiles.TabStop = true;
            this.CommonFiles.Text = "Common File";
            this.CommonFiles.UseVisualStyleBackColor = true;
            this.CommonFiles.CheckedChanged += new System.EventHandler(this.CommonFiles_CheckedChanged);
            // 
            // Receivers
            // 
            this.Receivers.FileName = "Receivers";
            // 
            // SendMails
            // 
            this.SendMails.Location = new System.Drawing.Point(374, 418);
            this.SendMails.Name = "SendMails";
            this.SendMails.Size = new System.Drawing.Size(96, 23);
            this.SendMails.TabIndex = 4;
            this.SendMails.Text = "Send Mails";
            this.SendMails.UseVisualStyleBackColor = true;
            this.SendMails.Click += new System.EventHandler(this.SendMails_Click);
            // 
            // CommonFilesBrowse
            // 
            this.CommonFilesBrowse.FileName = "Attachement";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(395, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
            this.Help.TabIndex = 5;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 597);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.SendMails);
            this.Controls.Add(this.AttachementBox);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.ProgressBox);
            this.Controls.Add(this.Configuration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nateg Mails Sender";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ProgressBox.ResumeLayout(false);
            this.ProgressBox.PerformLayout();
            this.MailBox.ResumeLayout(false);
            this.MailBox.PerformLayout();
            this.AttachementBox.ResumeLayout(false);
            this.AttachementBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Configuration;
        private System.Windows.Forms.ProgressBar SendingProgress;
        private System.Windows.Forms.GroupBox ProgressBox;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Label SendingLabel;
        private System.Windows.Forms.GroupBox MailBox;
        private System.Windows.Forms.TextBox MailContent;
        private System.Windows.Forms.TextBox MailSubject;
        private System.Windows.Forms.GroupBox AttachementBox;
        private System.Windows.Forms.OpenFileDialog Receivers;
        private System.Windows.Forms.CheckBox Attachement;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.RadioButton CustomFiles;
        private System.Windows.Forms.RadioButton CommonFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AttachementBrowse;
        private System.Windows.Forms.TextBox AttachementPath;
        private System.Windows.Forms.Button SendMails;
        private System.Windows.Forms.FolderBrowserDialog CustomFilesBrowse;
        private System.Windows.Forms.OpenFileDialog CommonFilesBrowse;
        private System.Windows.Forms.Button CancelBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.CheckBox DearTopMessage;
    }
}

