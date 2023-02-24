using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.IdentityModels
{
    public class PasswordChangeModel
    {
        public MPUSER user { get; set; }
        public string password { get; set; }
        public string oldPassword { get; set; } = "";

    }
}
