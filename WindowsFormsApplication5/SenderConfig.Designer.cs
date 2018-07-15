namespace WindowsFormsApplication5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.SenderMail = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SenderConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // SenderConfiguration
            // 
            this.SenderConfiguration.Controls.Add(this.OK);
            this.SenderConfiguration.Controls.Add(this.Cancel);
            this.SenderConfiguration.Controls.Add(this.label2);
            this.SenderConfiguration.Controls.Add(this.label1);
            this.SenderConfiguration.Controls.Add(this.Password);
            this.SenderConfiguration.Controls.Add(this.SenderMail);
            this.SenderConfiguration.Location = new System.Drawing.Point(12, 12);
            this.SenderConfiguration.Name = "SenderConfiguration";
            this.SenderConfiguration.Size = new System.Drawing.Size(404, 151);
            this.SenderConfiguration.TabIndex = 0;
            this.SenderConfiguration.TabStop = false;
            this.SenderConfiguration.Text = "Sender Configuration";
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
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(321, 122);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(240, 122);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // SenderConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 175);
            this.Controls.Add(this.SenderConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SenderConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SenderConfig";
            this.Load += new System.EventHandler(this.SenderConfig_Load);
            this.SenderConfiguration.ResumeLayout(false);
            this.SenderConfiguration.PerformLayout();
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
    }
}