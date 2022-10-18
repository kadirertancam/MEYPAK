using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    internal class CanbusYakıtOzet
    {
        public class Result
        {
            public double odometer { get; set; }
            public double fuelUsed { get; set; }
            public double avgConsumption { get; set; }
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
