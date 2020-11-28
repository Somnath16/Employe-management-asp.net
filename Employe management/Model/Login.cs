using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employe_management.Model
{
    public class Login
    {
        [Required]
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
