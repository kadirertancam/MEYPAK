using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Models.STOK
{
    public class MPSTOKOLCUBR
    {
        public MPSTOKOLCUBR()
        {

        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public int NUM { get; set; }                //Sıra numarası
        public decimal KATSAYI { get; set; }
        public int KULLANICIID { get; set; }
        public byte KAYITTIPI { get; set; } = 0;
        [ForeignKey("MPSTOK")]
        public int STOKID { get; set; }
        
        public virtual MPSTOK MPSTOK { get; set; }

        [ForeignKey("MPOLCUBR")]
        public int OLCUBRID { get; set; } 
        public virtual MPOLCUBR MPOLCUBR { get; set; }


    }
}
