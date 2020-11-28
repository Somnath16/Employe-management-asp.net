using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employe_management.Model
{
    public class Employe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Salary { get; set; }

    }
}
