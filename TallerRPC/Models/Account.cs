using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TallerRPC.Pages.Models
{

    public class Account
    {
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
