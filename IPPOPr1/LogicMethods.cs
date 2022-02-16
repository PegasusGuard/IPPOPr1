using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace IPPOPr1
{
    internal class LogicMethods
    {
        public static async Task SendEmailAsync (MailMessage message)
        {
            SmtpClient client = new SmtpClient ("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential ("kerzhentsevgn@gmail.com", "Dsfjkskfh2!");
            client.EnableSsl = true;
            await client.SendMailAsync (message);
        }
    }
}
