using MEYPAK.Entity.IdentityModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.KULLANICI
{
    public class KullaniciServis
    {
        UserManager<MPUSER> _userManager;

        public KullaniciServis(UserManager<MPUSER> userManager)
        {
            _userManager = userManager;
        }
            
        public MPUSER KullaniciBul(string Email)
        {
            return  _userManager.FindByEmailAsync(Email).Result;
        }
    }
}
