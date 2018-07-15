using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class MainForm : Form
    {

        string SenderMail;
        string SenderPassword;
        string Subject;
        string Content;
        string ReceiversFile;
        int AllLines;
        string Name;

        public MainForm()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_Compeleted);
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 0;
            try
            {
                char delimiter = ',';
                using (System.IO.StreamReader file = new StreamReader(ReceiversFile))
                {
                    string line = file.ReadLine();
                    while ((line != null))
                    {
                        string[] details = line.Split(delimiter);
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(SenderMail);
                        mail.Subject = Subject;
                        mail.To.Add(details[1]);
                        Name = details[0];
                        mail.Body = "Dear " + Name + ",\n" + Content;
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                        SmtpServer.Credentials = new System.Net.NetworkCredential(SenderMail, SenderPassword);
                        SmtpServer.EnableSsl = true;
                        try
                        {
                            SmtpServer.Send(mail);
                            progress++;
                            backgroundWorker.ReportProgress(progress);
                        }
                        catch (Exception ep)
                        {
                            MessageBox.Show("Can not send mail to: " + Name + "\n" + ep.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        line = file.ReadLine();

                    }
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

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int d;
            d = Convert.ToInt32((e.ProgressPercentage / AllLines) * 100);
            SendingProgress.Value = d;
            Percentage.Text = d.ToString() + " %";
            SendingLabel.Text = "Sending mail to: " + Name;
        }


        void backgroundWorker_Compeleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Percentage.Text = "100 %";
            SendingLabel.Text = "All mails are sent succesfully!"; 
            string messages = "All mails has been sent!";
            string captions = "INFO";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(messages, captions, button, MessageBoxIcon.Information);
            // test here 
            MailBox.Enabled = true;
            ProgressBox.Enabled = false;
            if (Attachement.Checked == true)
            {
                AttachementBox.Enabled = true;
            }
            else
            {
                AttachementBox.Enabled = false;
            }

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
            try
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
                else if (string.IsNullOrEmpty(ReceiversFile))
                {
                    string message = "You have to select a csv file of receivers details!";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
                else
                {
                    MailBox.Enabled = false;
                    AttachementBox.Enabled = false;
                    ProgressBox.Enabled = true;
                    AllLines = File.ReadLines(ReceiversFile).Count();
                    backgroundWorker.RunWorkerAsync();
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailBox.Enabled = true;
                ProgressBox.Enabled = false;
                if (Attachement.Checked == true)
                {
                    AttachementBox.Enabled = true;
                }
                else
                {
                    AttachementBox.Enabled = false;
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
    }
}
