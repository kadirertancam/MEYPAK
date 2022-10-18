using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    public class AktiviteOzet
    {
        public class Result
        {
            public double totalKm { get; set; }
            public int workTimePercent { get; set; }
            public int idleTimePercent { get; set; }
            public int stopTimePercent { get; set; }
            public string moduleMessage { get; set; }
            public string lastAddress { get; set; }
            public double lastAltitude { get; set; }
            public double lastLongitude { get; set; }
            public string gsmNo { get; set; }
            public string firstDataDate { get; set; }
            public int state { get; set; }
            public string stateColor { get; set; }
            public string stateInfo { get; set; }
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
