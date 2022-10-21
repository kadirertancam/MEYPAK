using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC.Mobiliz
{
    public class AracList
    {
        public class Result
        {
            public int muId { get; set; }
            public string companyName { get; set; }
            public int fleetId { get; set; }
            public string fleetName { get; set; }
            public int groupId { get; set; }
            public string groupName { get; set; }
            public string plate { get; set; }
            public string label { get; set; }
            public string timezone { get; set; }
            public string deviceType { get; set; }
            public string canbusProfile { get; set; }
            public string networkId { get; set; }
            public int hardwareVersion { get; set; }
            public int softwareVersion { get; set; }
            public string softwareSubVersion { get; set; }
            public string phone { get; set; }
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
