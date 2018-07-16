namespace NategMailsSender
{
    partial class SenderConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderConfig));
            this.SenderConfiguration = new System.Windows.Forms.GroupBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.SenderMail = new System.Windows.Forms.TextBox();
            this.CsvFileConfigBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Comma = new System.Windows.Forms.RadioButton();
            this.SemiColon = new System.Windows.Forms.RadioButton();
            this.Tab = new System.Windows.Forms.RadioButton();
            this.Space = new System.Windows.Forms.RadioButton();
            this.SenderConfiguration.SuspendLayout();
            this.CsvFileConfigBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SenderConfiguration
            // 
            this.SenderConfiguration.Controls.Add(this.label2);
            this.SenderConfiguration.Controls.Add(this.label1);
            this.SenderConfiguration.Controls.Add(this.Password);
            this.SenderConfiguration.Controls.Add(this.SenderMail);
            this.SenderConfiguration.Location = new System.Drawing.Point(12, 12);
            this.SenderConfiguration.Name = "SenderConfiguration";
            this.SenderConfiguration.Size = new System.Drawing.Size(404, 123);
            this.SenderConfiguration.TabIndex = 0;
            this.SenderConfiguration.TabStop = false;
            this.SenderConfiguration.Text = "Sender Configuration";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(260, 222);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(341, 222);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail: ";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(69, 80);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(319, 20);
            this.Password.TabIndex = 1;
            // 
            // SenderMail
            // 
            this.SenderMail.Location = new System.Drawing.Point(69, 41);
            this.SenderMail.Name = "SenderMail";
            this.SenderMail.Size = new System.Drawing.Size(319, 20);
            this.SenderMail.TabIndex = 0;
            // 
            // CsvFileConfigBox
            // 
            this.CsvFileConfigBox.Controls.Add(this.Space);
            this.CsvFileConfigBox.Controls.Add(this.Tab);
            this.CsvFileConfigBox.Controls.Add(this.SemiColon);
            this.CsvFileConfigBox.Controls.Add(this.Comma);
            this.CsvFileConfigBox.Controls.Add(this.label3);
            this.CsvFileConfigBox.Location = new System.Drawing.Point(12, 141);
            this.CsvFileConfigBox.Name = "CsvFileConfigBox";
            this.CsvFileConfigBox.Size = new System.Drawing.Size(404, 75);
            this.CsvFileConfigBox.TabIndex = 1;
            this.CsvFileConfigBox.TabStop = false;
            this.CsvFileConfigBox.Text = "Receivers File Configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delimiter:";
            // 
            // Comma
            // 
            this.Comma.AutoSize = true;
            this.Comma.Location = new System.Drawing.Point(29, 46);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(60, 17);
            this.Comma.TabIndex = 1;
            this.Comma.Text = "Comma";
            this.Comma.UseVisualStyleBackColor = true;
            // 
            // SemiColon
            // 
            this.SemiColon.AutoSize = true;
            this.SemiColon.Location = new System.Drawing.Point(121, 46);
            this.SemiColon.Name = "SemiColon";
            this.SemiColon.Size = new System.Drawing.Size(78, 17);
            this.SemiColon.TabIndex = 2;
            this.SemiColon.Text = "Semi Colon";
            this.SemiColon.UseVisualStyleBackColor = true;
            // 
            // Tab
            // 
            this.Tab.AutoSize = true;
            this.Tab.Location = new System.Drawing.Point(230, 46);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(44, 17);
            this.Tab.TabIndex = 3;
            this.Tab.TabStop = true;
            this.Tab.Text = "Tab";
            this.Tab.UseVisualStyleBackColor = true;
            // 
            // Space
            // 
            this.Space.AutoSize = true;
            this.Space.Location = new System.Drawing.Point(316, 46);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(56, 17);
            this.Space.TabIndex = 4;
            this.Space.TabStop = true;
            this.Space.Text = "Space";
            this.Space.UseVisualStyleBackColor = true;
            // 
            // SenderConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 254);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CsvFileConfigBox);
            this.Controls.Add(this.SenderConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SenderConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SenderConfig";
            this.Load += new System.EventHandler(this.SenderConfig_Load);
            this.SenderConfiguration.ResumeLayout(false);
            this.SenderConfiguration.PerformLayout();
            this.CsvFileConfigBox.ResumeLayout(false);
            this.CsvFileConfigBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SenderConfiguration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox SenderMail;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox CsvFileConfigBox;
        private System.Windows.Forms.RadioButton Space;
        private System.Windows.Forms.RadioButton Tab;
        private System.Windows.Forms.RadioButton SemiColon;
        private System.Windows.Forms.RadioButton Comma;
        private System.Windows.Forms.Label label3;
    }
}