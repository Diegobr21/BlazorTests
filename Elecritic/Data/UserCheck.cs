using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Elecritic.Data
{
    public class UserCheck
    {
        [Required(ErrorMessage = "Este campo no puede estar vacío")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacío")]
        public string Password { get; set; }


        public UserCheck()
        {
        }
        public UserCheck(string email, string password)
        {
            Email = email;
            Password = password;

        }
    }
}
