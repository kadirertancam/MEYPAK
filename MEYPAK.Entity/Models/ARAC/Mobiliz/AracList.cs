using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.ARAC.Mobiliz
{
    public class AracList
    {
        public class Child
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public List<Child> children { get; set; }
            public string plate { get; set; }
            public string vendorCode { get; set; }
            public string networkId { get; set; }
            public string gsmNo { get; set; }
            public string timezone { get; set; }
            public int softwareVersion { get; set; }
            public string vehicleLabel { get; set; }
        }

        public class Result
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public List<Child> children { get; set; }
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
