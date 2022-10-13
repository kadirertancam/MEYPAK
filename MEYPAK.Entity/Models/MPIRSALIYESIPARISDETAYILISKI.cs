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
        [Key]
        public int ID { get; set; }

        public int SIPARISDETAYID { get; set; }
        public virtual MPSIPARISDETAY MPSIPARISDETAY { get; set; }

        public int IRSALIYEDETAYID { get; set; }
        public virtual MPIRSALIYEDETAY MPIRSALIYEDETAY { get; set; }
    }
}
