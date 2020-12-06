using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            await emailSender.SendEmailAsync("sensershops@gmail.com", "С сайта Senser shop", message);
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
            await emailSender.SendEmailAsync("vyarema@gmail.com", "С сайта Senser shop", message);

            //return View();
            //return LocalRedirect("/Index");
        }
    }
}
