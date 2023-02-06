using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels
{
    public abstract class SUPERPOCOMODEL
    {
        public int id { get; set; }
        public DateTime olusturmatarihi { get; set; } = DateTime.Now;
        public DateTime guncellemetarihi { get; set; } = DateTime.Now;
        public byte kayittipi { get; set; } = 0;
        public int eskiid { get; set; } = 0;
        public string userid { get; set; }
    }
}
