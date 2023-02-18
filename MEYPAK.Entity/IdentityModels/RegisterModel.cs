using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.IdentityModels
{
    public class RegisterModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; } = "";
        public string UserName {get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
