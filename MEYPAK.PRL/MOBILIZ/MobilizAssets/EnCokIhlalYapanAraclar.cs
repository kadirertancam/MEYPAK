using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    public class EnCokIhlalYapanAraclar
    {
        public class Result
        {
            public int muId { get; set; }
            public string plate { get; set; }
            public int violationCount { get; set; }
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
