using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class MainForm : Form
    {

        string SenderMail;
        string SenderPassword;
        string Subject;
        string Content;
        string ReceiversFile;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Configuration_Click(object sender, EventArgs e)
        {
            SenderConfig config = new SenderConfig();
            config.Show(this);
        }

        private void Attachement_CheckedChanged(object sender, EventArgs e)
        {
            if (Attachement.Checked == true)
            {
                AttachementBox.Enabled = true;
            }
            else
            {
                AttachementBox.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AttachementBox.Enabled = false;
            CommonFiles.Checked = true;
            ProgressBox.Enabled = false;
        }
        /*
        private void MainForm_Close(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
                if (MessageBox.Show("Are you sure you want quit Nateg Mails Sender?", "Validation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        */
        private void Browse_Click(object sender, EventArgs e)
        {
            try
            {
                Receivers.Filter = "csv files (*.csv)|*.csv";
                DialogResult result = Receivers.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string FileName = Receivers.FileName;
                    ReceiversPath.Text = FileName;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }

        private void AttachementBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonFiles.Checked == true)
                {
                    DialogResult result = CommonFilesBrowse.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string FileName = CommonFilesBrowse.FileName;
                        AttachementPath.Text = FileName;
                    }
                }
                else if (CustomFiles.Checked == true)
                {
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SenderMail = Config.Mail;
            SenderPassword = Config.Password;
            Subject = MailSubject.Text;
            Content = MailContent.Text;
            ReceiversFile = ReceiversPath.Text;
            if (string.IsNullOrEmpty(SenderMail) || string.IsNullOrEmpty(SenderPassword))
            {
                string message = "You have to set sender cridentials (mail and password) first!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(Content))
            {
                string message = "You can not send an email with an empty content!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }
    }
}
