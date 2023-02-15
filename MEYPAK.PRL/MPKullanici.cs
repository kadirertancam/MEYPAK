using MEYPAK.Entity.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL
{
    public static class MPKullanici
    {
        
        public static string ID
        {
            get
            {
               return ((Main)Application.OpenForms["Main"]).Kullanici.Id;
            }
        }
        public static MPUSER USER
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).Kullanici;
            }
        }
        public static List<string> Roller
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).Roller;
            }
        }
    }
}
