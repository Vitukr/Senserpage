using System;
using System.Collections.Generic;
using System.Linq;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace Senserpage.Services
{
    public class EmailSender //: IEmailSender
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "senseradmin@sensershop.vysoft.top"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
#if DEBUG
                await client.ConnectAsync("scp.realhost.pro", 25, false);
#else
                await client.ConnectAsync("localhost", 25, false);
#endif

                await client.AuthenticateAsync("senseradmin@sensershop.vysoft.top", "bzphqlisf0oukaxvyngc");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }

        private bool sendEmail;
        public bool SendEmail
        {
            get
            {
                return sendEmail;
            }
            set
            {
                sendEmail = value;
                NotifyDataChanged();
            }
        }

        public event Action<string, string> OnChange;

        private void NotifyDataChanged()
        {
            if (SendEmail == true)
            {
                SendEmail = false;
                SendEmailAsync("vyarema@gmail.com", "Test", Name + Phone).GetAwaiter().GetResult();
            }
        }
    }
}
