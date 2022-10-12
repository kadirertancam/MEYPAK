using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models
{
    public class MPIRSALIYESIPARISDETAYILISKI
    {
        public int ID { get; set; }

        public int SIPARISDETAYID { get; set; }
        public MPSIPARISDETAY MPSIPARISDETAY { get; set; }

        public int IRSALIYEDETAYID { get; set; }
        public MPIRSALIYEDETAY MPIRSALIYEDETAY { get; set; }
    }
}
