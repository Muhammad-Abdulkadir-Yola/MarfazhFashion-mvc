﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarfazahFashion.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
