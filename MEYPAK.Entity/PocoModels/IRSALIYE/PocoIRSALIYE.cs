using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.PocoModels.SIPARIS;

namespace MEYPAK.Entity.PocoModels.IRSALIYE
{
    public class PocoIRSALIYE:SUPERPOCOMODEL
    {
        public int siparisid { get; set; }
        public int sirketid { get; set; } = 0;
        public int subeid { get; set; } = 0;
        public int depoid { get; set; } = 0;
        public int cariid { get; set; } = 0;
        public int althesapid { get; set; } = 0;
        public int kullaniciid { get; set; } = 0;
        public DateTime irsaliyetarihi { get; set; } = DateTime.Now;
        public DateTime sevkiyattarihi { get; set; } = DateTime.Now;
        public DateTime vadetarihi { get; set; } = DateTime.Now;
        public byte kullanicitipi { get; set; } = 0;
        [StringLength(50)]
        public string cariadi { get; set; } = "";
        public int vadegunu { get; set; } = 0;
        [StringLength(200)]
        public string aciklama { get; set; } = "";
        [StringLength(200)]
        public string ekaciklama { get; set; } = "";
        public int dovizid { get; set; } = 0;
        public decimal kur { get; set; } = 0;
        [StringLength(50)]
        public string serino { get; set; } = "";
        public string belgeno { get; set; } = "";
        public bool kdvdahil { get; set; }
        public decimal nettoplam { get; set; } = 0;
        public decimal kdvtoplam { get; set; } = 0;
        public decimal altiskonto1 { get; set; } = 0;
        public decimal altiskonto2 { get; set; } = 0;
        public decimal altiskonto3 { get; set; } = 0;
        public decimal iskontotoplam { get; set; } = 0;
        public decimal bruttoplam { get; set; } = 0;
        public decimal geneltoplam { get; set; } = 0;
        public int aracid { get; set; }
        public int dorseid { get; set; } = 0;
        public int personelid { get; set; }
        public int tip { get; set; }
        public bool durum { get; set; }
        [Required]
        public string donem { get; set; } = DateTime.Now.ToString("yyyy");

        public string bildirimturu { get; set; } = "";
        public int bildirimturuid { get; set; } = 0;
    }
}
