using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crm.UILayer.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını boş geçmeyin")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
