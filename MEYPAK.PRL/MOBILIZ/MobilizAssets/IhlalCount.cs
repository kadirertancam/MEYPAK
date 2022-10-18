using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    public class IhlalCount
    { 
            public bool success { get; set; }
            public string type { get; set; }
            public object message { get; set; }
            public int result { get; set; }
            public object errors { get; set; } 
    }
}
