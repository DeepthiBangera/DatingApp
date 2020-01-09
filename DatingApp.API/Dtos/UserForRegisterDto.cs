using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string username { get; set; }

        [Required]
        [StringLength(8, MinimumLength =4, ErrorMessage ="Password must be specified between 4 and 8 characters")]
        public string password { get; set; }
    }
}
