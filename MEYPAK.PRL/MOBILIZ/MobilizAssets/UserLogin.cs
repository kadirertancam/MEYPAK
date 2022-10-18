using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    public class UserLogin
    {
        public class Result
        {
            public string token { get; set; }
            public string userName { get; set; }
            public string email { get; set; }
            public int roleId { get; set; }
            public string roleDesc { get; set; }
            public string roleKey { get; set; }
            public int companyId { get; set; }
            public string companyName { get; set; }
            public string language { get; set; }
            public int userId { get; set; }
            public string home { get; set; }
            public string systemName { get; set; }
            public string serverName { get; set; }
            public double balance { get; set; }
            public object expiredBalance { get; set; }
            public object systemCloseTime { get; set; }
            public object modules { get; set; }
            public bool allowedForVehicleCrud { get; set; }
            public bool developer { get; set; }
            public bool forcePasswordChange { get; set; }
            public object permissions { get; set; }
            public DateTime lastPasswordUpdateTime { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public string type { get; set; }
            public object message { get; set; }
            public Result result { get; set; }
        }
    }
}
