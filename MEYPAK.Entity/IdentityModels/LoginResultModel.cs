using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.IdentityModels
{
    public class LoginResultModel
    {
        
       public MPUSER MPUSER { get; set; }
       public List<string> userRoles { get; set; }    
    }
}
