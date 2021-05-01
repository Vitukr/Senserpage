﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senserpage.Models
{
    public class OrderForm
    {
        [Required(ErrorMessage = "Ім'я є обов'язковим")]
        [StringLength(20, ErrorMessage = "Дуже велике ім'я")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Телефон є обов'язковим")]
        [StringLength(20, ErrorMessage = "Багато цифр в номері телефона")]
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
