using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;

namespace MEYPAK.Entity.Models
{
    public class MPDEPOEMIRSIPARISKALEMILISKI
    {
        [Key]
        public int ID { get; set; }
        public int DEPOEMIRID { get; set; }
        public MPDEPOEMIR MPDEPOEMIR { get; set; }
        public int SIPARISDETAYID { get; set; }
        public MPSIPARISDETAY MPSIPARISDETAY { get; set; }
    }
}
