﻿using System;
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

namespace NategMailsSender
{
    public partial class MainForm : Form
    {

        string SenderMail;
        string SenderPassword;
        string Subject;
        string Content;
        string ReceiversFile;
        int AllLines;
        string ReceiverName;
        Boolean isSuccess;

        public MainForm()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_Compeleted);
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            const int MaxAttemps = 3;
            int Attemps;
            int progress = 0;
            try
            {
                char delimiter = Config.Delimiter;
                using (System.IO.StreamReader file = new StreamReader(ReceiversFile))
                {
                    if (Config.FileHeader)
                    {
                        file.ReadLine();
                    }
                    string line = file.ReadLine();
                    while ((line != null))
                    {
                        Attemps = 0;
                        string[] details = line.Split(delimiter);
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress(SenderMail);
                        mail.Subject = Subject;
                        mail.To.Add(details[1]);
                        ReceiverName = details[0];
                        if (DearTopMessage.Checked)
                        {
                            mail.Body = "Dear " + ReceiverName + ",\n\n" + Content;
                        }
                        else
                        {
                            mail.Body = Content;
                        }
                        if (Attachement.Checked)
                        {
                            System.Net.Mail.Attachment attachment;
                            if (CommonFiles.Checked)
                            {
                                attachment = new System.Net.Mail.Attachment(AttachementPath.Text);
                                mail.Attachments.Add(attachment);
                            }
                            else if (CustomFiles.Checked)
                            {
                                attachment = new System.Net.Mail.Attachment(Path.Combine(AttachementPath.Text, details[2]));
                                mail.Attachments.Add(attachment);
                            }
                        }
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                        SmtpServer.Credentials = new System.Net.NetworkCredential(SenderMail, SenderPassword);
                        SmtpServer.EnableSsl = true;
                        Retry: 
                            try
                            {
                                    Attemps++;
                                    SmtpServer.Send(mail);
                                    progress++;
                                    backgroundWorker.ReportProgress(progress);
                                    isSuccess = true;
                            }
                            catch (Exception ep)
                            {
                                if (Attemps <= MaxAttemps)
                                {
                                    System.Threading.Thread.Sleep(Attemps*500);
                                    goto Retry;
                                }
                                MessageBox.Show("Can not send mail to: " + ReceiverName + "\n" + ep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                isSuccess = false;
                                break;
                            }
                            line = file.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                string message = ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
            
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int d;
            d = Convert.ToInt32(((double)e.ProgressPercentage / AllLines) * 100);
            SendingProgress.Value = d;
            Percentage.Text = d.ToString() + " %";
            SendingLabel.Text = "Sending mail to: " + ReceiverName;
        }


        void backgroundWorker_Compeleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isSuccess == true)
            {
                SendingProgress.Value = 100;
                Percentage.Text = "100 %";
                SendingLabel.Text = "All mails are sent succesfully!";
                string messages = "All mails has been sent!";
                string captions = "Info";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(messages, captions, button, MessageBoxIcon.Information);
            }
            else
            {
                Percentage.Text = "0 %";
                SendingLabel.Text = "Sending failed";
                SendingProgress.Value = 0;
            }
            MailBox.Enabled = true;
            ProgressBox.Enabled = false;
            SendMails.Enabled = true;
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
            config.ShowDialog();
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

        private void AttachementBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonFiles.Checked == true)
                {
                    if (CommonFilesBrowse.ShowDialog() == DialogResult.OK)
                    {
                        AttachementPath.Text = CommonFilesBrowse.FileName;
                    }
                }
                else if (CustomFiles.Checked == true)
                {   
                    if (CustomFilesBrowse.ShowDialog() == DialogResult.OK)
                    {
                        AttachementPath.Text = CustomFilesBrowse.SelectedPath;
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

        private void SendMails_Click(object sender, EventArgs e)
        {
            try
            {
                SenderMail = Config.Mail;
                SenderPassword = Config.Password;
                Subject = MailSubject.Text;
                Content = MailContent.Text;
                ReceiversFile = Config.ReceiversFilePath;
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
                else if (Config.Delimiter == '\0')
                {
                    string message = "You have to select a file delimiter to enable file parsing!";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
                else
                {
                    backgroundWorker.RunWorkerAsync();
                    SendingLabel.Text = "Start sending...";
                    MailBox.Enabled = false;
                    AttachementBox.Enabled = false;
                    SendMails.Enabled = false;
                    ProgressBox.Enabled = true;
                    AllLines = File.ReadLines(ReceiversFile).Count();
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
                backgroundWorker.CancelAsync();
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

        private void Help_Click(object sender, EventArgs e)
        {
            HelpForm Help = new HelpForm();
            Help.ShowDialog();
        }

        private void CommonFiles_CheckedChanged(object sender, EventArgs e)
        {
            AttachementPath.Text = "";
        }

        private void CustomFiles_CheckedChanged(object sender, EventArgs e)
        {
            AttachementPath.Text = "";
        }
    }
}
