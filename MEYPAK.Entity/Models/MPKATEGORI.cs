using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel;

namespace MEYPAK.Entity.Models
{
    public class MPKATEGORI
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DefaultValue(0)]
        public int UstId { get; set; }

        [DefaultValue(0)]
        public int AltID { get; set; }

        [StringLength(100),Required]
        public string Acıklama { get; set; }
    }
}
