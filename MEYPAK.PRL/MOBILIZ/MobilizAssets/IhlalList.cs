using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    public class IhlalList
    {
        public class Result
        {
            public int notificationId { get; set; }
            public int muId { get; set; }
            public string type { get; set; }
            public object time { get; set; }
            public string formattedTime { get; set; }
            public string plate { get; set; }
            public string driverName { get; set; }
            public string detail { get; set; }
            public double? longitude { get; set; }
            public double? latitude { get; set; }
            public string address { get; set; }
            public string data { get; set; }
            public string limit { get; set; }
            public object violationData { get; set; }
            public int messagingAccessories { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public string type { get; set; }
            public object message { get; set; }
            public List<Result> result { get; set; }
            public object errors { get; set; }
        }
    }
}
