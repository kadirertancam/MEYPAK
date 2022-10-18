using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    public class AnlıkDurumlarAracSayisi
    {
        public class Result
        {
            public int idleVehicleCount { get; set; }
            public int movingVehicleCount { get; set; }
            public int stoppedVehicleCount { get; set; }
            public string moduleMessage { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public string type { get; set; }
            public object message { get; set; }
            public Result result { get; set; }
            public object errors { get; set; }
        }


    }
}
