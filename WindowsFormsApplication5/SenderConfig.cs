﻿using System;
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
    public partial class SenderConfig : Form
    {
        public SenderConfig()
        {
            InitializeComponent();
        }

        private void SenderConfig_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);
            }
            SenderMail.Text = Config.Mail;
            Password.Text = Config.Password; 
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Config.Mail = SenderMail.Text;
            Config.Password = Password.Text;
            this.Close();
        }

    }
}
