using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;

namespace MEYPAK.Entity.PocoModels.SIPARIS
{
    public class PocoSIPARISDETAY
    {
        public int ID { get; set; }
        public int SIPARISID { get; set; }
        [DefaultValue(0)]
        public int IRSALIYEID { get; set; }
        [DefaultValue(0)]
        public int BIRIMID { get; set; }
        [DefaultValue(0)]
        public int STOKID { get; set; }
        [DefaultValue(0)]
        public int DOVIZID { get; set; } = 0;
        [DefaultValue(0)]
        public int LISTEFIYATID { get; set; } = 0;
        [DefaultValue(0)]
        public int KULLANICIID { get; set; } = 0;
        [DefaultValue(0)]
        public int KASAID { get; set; } = 0;
        public DateTime OLUSTURMATARIHI { get; set; } = DateTime.Now;
        public DateTime GUNCELLEMETARIHI { get; set; } = DateTime.Now;
        public byte TIP { get; set; } = 0;
        [StringLength(50)]
        public string STOKADI { get; set; } = "";
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        public decimal MIKTAR { get; set; } = 0;
        public decimal ISTKONTO1 { get; set; } = 0;
        public decimal ISTKONTO2 { get; set; } = 0;
        public decimal ISTKONTO3 { get; set; } = 0;
        public decimal NETFIYAT { get; set; } = 0;
        public decimal BRUTFIYAT { get; set; } = 0;
        public decimal NETTOPLAM { get; set; } = 0;
        public decimal BRUTTOPLAM { get; set; } = 0;
        public int BEKLEYENMIKTAR { get; set; } = 0;
        public byte HAREKETDURUMU { get; set; } = 0;
        public decimal KDV { get; set; } = 0;
        public decimal KDVTUTARI { get; set; } = 0;
        public byte KAYITTIPI { get; set; } = 0;
        public MPSIPARIS MPSIPARIS { get; set; }
        public MPSTOK MPSTOK { get; set; }
        public virtual MPIRSALIYE MPIRSALIYE { get; set; }
        //TODO BAKILACAK
        public virtual List<MPIRSALIYESIPARISDETAYILISKI>? MPIRSALIYESIPARISDETAYILISKI { get; set; }
        public List<MPSTOKSEVKİYATLİST> MPSTOKSEVKİYATLİSTList { get; set; }
        public List<MPDEPOEMIRSIPARISKALEMILISKI> MPDEPOEMIRSIPARISKALEMILISKI { get; set; }
    }
}
