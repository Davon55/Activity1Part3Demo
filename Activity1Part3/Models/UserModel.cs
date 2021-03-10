using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Activity1Part3.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Username { get; set; }

        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Password { get; set; }
    }
}
