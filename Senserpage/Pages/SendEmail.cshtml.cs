using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;
using MimeKit.Utils;
using Newtonsoft.Json;
using Senserpage.Models;
using Senserpage.Services;

namespace Senserpage.Pages
{
    public class SendEmailModel : PageModel
    {
        private EmailSender emailSender;

        public SendEmailModel(EmailSender emailSender1)
        {
            emailSender = emailSender1;
        }
          
        //public class InputModel
        //{
        //    [Required]
        //    [EmailAddress]
        //    public string Email { get; set; }

        //    [Required]
        //    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        //    [DataType(DataType.Password)]
        //    public string Password { get; set; }

        //    [DataType(DataType.Password)]
        //    [Display(Name = "Confirm password")]
        //    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //    public string ConfirmPassword { get; set; }

        //    public string Code { get; set; }
        //}
        public async Task OnGet(string input)
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            CallMeForm callMeForm = JsonConvert.DeserializeObject<CallMeForm>(input);
            string message = $@"<h2>Позвоните мне.</h2><br /><h2>Имя: {callMeForm.Name}</h2><br /><h2>Телефон: {callMeForm.Phone}</h2>";

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Sensershop", "senseradmin@sensershop.vysoft.top"));
            emailMessage.To.Add(new MailboxAddress("", "sensershops@gmail.com"));
            emailMessage.Subject = "С сайта Senser shop";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            await emailSender.SendEmailAsync(emailMessage);
        }

        //[BindProperty]
        //public CallMeForm Input { get; set; }
        public async Task OnPostAsync(string input)
        {
            await Task.Delay(1);

            if (!ModelState.IsValid)
            {
                return;
            }

            CallMeForm callMeForm = JsonConvert.DeserializeObject<CallMeForm>(input);
            string message = $@"<h2>Позвоните мне.</h2><br /><h2>Имя: {callMeForm.Name}</h2><br /><h2>Телефон: {callMeForm.Phone}</h2>";

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Sensershop", "senseradmin@sensershop.vysoft.top"));
            emailMessage.To.Add(new MailboxAddress("", "vyarema@gmail.com"));
            emailMessage.Subject = "С сайта Senser shop";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            await emailSender.SendEmailAsync(emailMessage);

            //return View();
            //return LocalRedirect("/Index");
        }

        public void MessageWithImage()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Joey", "joey@friends.com"));
            message.To.Add(new MailboxAddress("Alice", "alice@wonderland.com"));
            message.Subject = "How you doin?";

            var builder = new BodyBuilder();

            // Set the plain-text version of the message text
            builder.TextBody = @"Hey Alice,

What are you up to this weekend? Monica is throwing one of her parties on
Saturday and I was hoping you could make it.

Will you be my +1?

-- Joey
";

            // In order to reference selfie.jpg from the html text, we'll need to add it
            // to builder.LinkedResources and then use its Content-Id value in the img src.
            var image = builder.LinkedResources.Add(@"C:\Users\Joey\Documents\Selfies\selfie.jpg");
            image.ContentId = MimeUtils.GenerateMessageId();

            // Set the html version of the message text
            builder.HtmlBody = string.Format(@"<p>Hey Alice,<br>
<p>What are you up to this weekend? Monica is throwing one of her parties on
Saturday and I was hoping you could make it.<br>
<p>Will you be my +1?<br>
<p>-- Joey<br>
<center><img src=""cid:{0}""></center>", image.ContentId);

            // We may also want to attach a calendar event for Monica's party...
            builder.Attachments.Add(@"C:\Users\Joey\Documents\party.ics");

            // Now we just need to set the message body and we're done
            message.Body = builder.ToMessageBody();
        }
    }
}
