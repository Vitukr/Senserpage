using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senserpage.Models
{
    public class OrderForm
    {
        [Required]
        [StringLength(20, ErrorMessage = "Слишком большое имя")]
        public string Name { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Много цифр в номере телефона")]
        public string Phone { get; set; }
    }
}
