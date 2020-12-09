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
        public async Task SendEmailAsync(MimeMessage emailMessage)
        {
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
    }
}
