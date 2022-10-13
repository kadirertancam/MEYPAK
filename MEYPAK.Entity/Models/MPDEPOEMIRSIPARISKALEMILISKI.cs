using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPDEPOEMIRSIPARISKALEMILISKI
    {
        public int ID { get; set; }
        public int DEPOEMIRID { get; set; }
        public MPDEPOEMIR MPDEPOEMIR { get; set; }
        public int SIPARISDETAYID { get; set; }
        public MPSIPARISDETAY MPSIPARISDETAY { get; set; }
    }
}
