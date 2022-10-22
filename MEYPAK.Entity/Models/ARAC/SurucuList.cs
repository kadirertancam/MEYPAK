using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC
{
    public class SurucuList
    {
        public class Result
        {
            public int driverId { get; set; }
            public string driverName { get; set; }
            public string driverLastName { get; set; }
            public string driverFullName { get; set; }
            public string gsmNumbers { get; set; }
            public int muId { get; set; }
            public string plate { get; set; }
            public string fleetName { get; set; }
            public string groupName { get; set; }
            public object title { get; set; }
            public object workingHours { get; set; }
            public string dallasCode { get; set; }
            public string dallasCodeType { get; set; }
            public string nationalIdentityNo { get; set; }
            public object code { get; set; }
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
