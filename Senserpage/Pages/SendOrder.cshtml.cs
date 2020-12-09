using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;
using MimeKit.Utils;
using Newtonsoft.Json;
using Senserpage.Data;
using Senserpage.Models;
using Senserpage.Services;

namespace Senserpage.Pages
{
    public class SendOrderModel : PageModel
    {
        private EmailSender _emailSender;
        private IWebHostEnvironment _hostEnvironment;
        public SendOrderModel(IWebHostEnvironment environment, EmailSender emailSender)
        {
            _hostEnvironment = environment;
            _emailSender = emailSender;
        }

        public async Task OnGet(string input)
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            OrderForm orderForm = JsonConvert.DeserializeObject<OrderForm>(input);

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Sensershop", "senseradmin@sensershop.vysoft.top"));
            emailMessage.To.Add(new MailboxAddress("", "vyarema@gmail.com")); // "sensershops@gmail.com"
            emailMessage.Subject = "С сайта Senser shop";
            emailMessage.Body = MessageWithImage(orderForm).ToMessageBody();

            await _emailSender.SendEmailAsync(emailMessage);
        }

        public async Task OnPostAsync([FromBody] OrderForm orderForm)
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Sensershop", "senseradmin@sensershop.vysoft.top"));
            emailMessage.To.Add(new MailboxAddress("", "vyarema@gmail.com"));
            emailMessage.Subject = "С сайта Senser shop";
            emailMessage.Body = MessageWithImage(orderForm).ToMessageBody();

            await _emailSender.SendEmailAsync(emailMessage);

            //return View();
            //return LocalRedirect("/Index");
        }

        public BodyBuilder MessageWithImage(OrderForm orderForm)
        {
            var builder = new BodyBuilder();

            string message = $@"<h4>Заказ от:</h4><br /><h4>Имя: {orderForm.Name}</h4><br /><h4>Телефон: {orderForm.Phone}</h4>";

            string messageHtml = $"<table cellpadding=\"2\" cellspacing=\"0\"><thead><tr><td>Фото</td>" +
            "<td>Наименование</td><td>Цена</td><td>Количество</td></tr></thead><tbody>";
            string str = "";
            for (int i = 0; i < Goods.CartGoods.Count; i++)
            {
                var good = Goods.CartGoods[i];

                string path = Path.Join(_hostEnvironment.WebRootPath, good.PhotoLink);
                var image = builder.LinkedResources.Add(path);
                image.ContentId = MimeUtils.GenerateMessageId();

                str += $"<tr><td><img width=\"100px\" src=\"cid:{image.ContentId}\"/></td>" +
                    $"<td><span>{good.Name}</span></td><td><span>{good.Price} грн.</span></td>" +
                    $"<td><span>{good.Number}</span></td></tr>";
            }
            string price = "";
            if (Goods.CartGoods.Count > 0)
            {
                decimal total = 0;
                for (int i = 0; i < Goods.CartGoods.Count; i++)
                {
                    total += Goods.CartGoods[i].Price * Goods.CartGoods[i].Number;
                }
                price = $"<tr><td>Всего</td><td></td><td>{total} грн.</td></tr>";
            }
            var endtable = "</tbody></table>";
            message += messageHtml + str + price + endtable;
            builder.HtmlBody = message;

            builder.TextBody = message;

            // In order to reference selfie.jpg from the html text, we'll need to add it
            // to builder.LinkedResources and then use its Content-Id value in the img src.            

            // Set the html version of the message text
            //            builder.HtmlBody = string.Format(@"<p>Hey Alice,<br>
            //<p>What are you up to this weekend? Monica is throwing one of her parties on
            //Saturday and I was hoping you could make it.<br>
            //<p>Will you be my +1?<br>
            //<p>-- Joey<br>
            //<center><img src=""cid:{0}""></center>", image.ContentId);

            // We may also want to attach a calendar event for Monica's party...
            //builder.Attachments.Add(@"C:\Users\Joey\Documents\party.ics");

            // Now we just need to set the message body and we're done
            //message.Body = builder.ToMessageBody();

            return builder;
        }
    }
}
