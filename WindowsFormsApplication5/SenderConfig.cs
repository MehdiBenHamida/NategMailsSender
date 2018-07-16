using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NategMailsSender
{
    public partial class SenderConfig : Form
    {
        public SenderConfig()
        {
            InitializeComponent();
        }

        private void SenderConfig_Load(object sender, EventArgs e)
        {
            SenderMail.Text = Config.Mail;
            Password.Text = Config.Password; 
            if (Config.Delimiter == ',')
            {
                Comma.Checked = true;
            }
            else if (Config.Delimiter == ';')
            {
                SemiColon.Checked = true;
            }
            else if (Config.Delimiter == '\t')
            {
                Tab.Checked = true;
            }
            else if (Config.Delimiter == ' ')
            {
                Space.Checked = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Config.Mail = SenderMail.Text;
            Config.Password = Password.Text;
            if (Comma.Checked)
            {
                Config.Delimiter = ',';
            }
            else if (SemiColon.Checked)
            {
                Config.Delimiter = ';';
            }
            else if (Tab.Checked)
            {
                Config.Delimiter = '\t';
            }
            else if (Space.Checked)
            {
                Config.Delimiter = ' ';
            }

            this.Close();
        }

    }
}
