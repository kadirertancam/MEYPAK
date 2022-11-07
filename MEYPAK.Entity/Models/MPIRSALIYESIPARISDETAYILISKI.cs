using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.SIPARIS;

namespace MEYPAK.Entity.Models
{
    public class MPIRSALIYESIPARISDETAYILISKI
    {
        [Key]
        public int ID { get; set; }

        public int SIPARISDETAYID { get; set; }

        public int IRSALIYEDETAYID { get; set; }
    }
}
