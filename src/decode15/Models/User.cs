using System;
using System.ComponentModel.DataAnnotations;

namespace decode15.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public string Message { get; set; }
    }
}

