using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        //[BindProperty]
        //public InputModel Input { get; set; }

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
        public async Task OnGet(string name, string phone)
        {
            var test = name;
            var test1 = phone;
            await emailSender.SendEmailAsync("vyarema@gmail.com", "Test", name + phone);
        }

        public async Task<IActionResult> Index()
        {
            await Task.Delay(1);
            //return View();
            return LocalRedirect("/Index");
        }
    }
}
