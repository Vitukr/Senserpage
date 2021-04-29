using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;
using Newtonsoft.Json;
using Senserpage.Models;
using Senserpage.Services;

namespace Senserpage.Pages
{
    public class SendEmailModel : PageModel
    {
        private EmailSender _emailSender;

        public SendEmailModel(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        
        public async Task OnGet(string input)
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            CallMeForm callMeForm = JsonConvert.DeserializeObject<CallMeForm>(input);
            
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Sensershop", "admin@senser.com.ua"));
            emailMessage.To.Add(new MailboxAddress("", "sensershops@gmail.com"));
            emailMessage.Subject = "Звонок с сайта Senser shop";
            emailMessage.Body = MessageWithImage(callMeForm).ToMessageBody();

            await _emailSender.SendEmailAsync(emailMessage);
        }

        public async Task OnPostAsync([FromBody] CallMeForm callMeForm)
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Sensershop", "admin@vysoft.top"));
            emailMessage.To.Add(new MailboxAddress("", "vyarema@gmail.com"));
            emailMessage.Subject = "Звонок с сайта Senser shop";
            emailMessage.Body = MessageWithImage(callMeForm).ToMessageBody();

            await _emailSender.SendEmailAsync(emailMessage);

            //return View();
            //return LocalRedirect("/Index");
        }

        public BodyBuilder MessageWithImage(CallMeForm callMeForm)
        {
            var builder = new BodyBuilder();

            string message = $@"<h2>Позвоните мне.</h2><br /><h2>Имя: {callMeForm.Name}</h2><br /><h2>Телефон: {callMeForm.Phone}</h2>";

            builder.HtmlBody = message;

            builder.TextBody = message;

            return builder;
        }
    }
}
