using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace IPPOPr1
{
    public partial class MailClient : Form
    {
        public MailClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MailClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("kerzhentsevgn@gmail.com", "George Kerzhentsev");
            MailAddress to = new MailAddress($"{addrTo.Text}");
            MailMessage message = new MailMessage(from, to);
            message.Subject = msgTopic.Text;
            message.Body = msgBody.Text;
            topicLbl.Text = msgTopic.Text;
            messageLbl.Text = msgBody.Text;

            LogicMethods sendMsg = new LogicMethods();
            LogicMethods.SendEmailAsync(message).GetAwaiter();

            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //client.Credentials = new NetworkCredential("kerzhentsevgn@gmail.com", "Dsfjkskfh2!");
            //client.EnableSsl = true;

        }
    }
}
