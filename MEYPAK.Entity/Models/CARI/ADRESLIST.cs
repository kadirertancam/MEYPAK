using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.CARI
{
    public class ADRESLIST
    { 
        public string il { get; set; }
        public string ilçe { get; set; }
        public string semt_bucak_belde { get; set; }
        public string Mahalle { get; set; }
        [Key]
        public string PK { get; set; }
    }
}
