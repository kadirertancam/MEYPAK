using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.STOK;

namespace MEYPAK.Entity.Models.SIPARIS
{
    public class MPSIPARISDETAY:SUPERMODEL
    {

        [ForeignKey("MPSIPARIS")]
        public int SIPARISID { get; set; }
        [DefaultValue(0)]

        [ForeignKey("MPIRSALIYE")]
        public int IRSALIYEID { get; set; }=0;
        [DefaultValue(0)]
        public int BIRIMID { get; set; }
        [DefaultValue(0)]
        [ForeignKey("MPSTOK")]
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
        [DefaultValue("")]
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
         
        public virtual MPSIPARIS MPSIPARIS { get; set; } 
        public virtual MPSTOK MPSTOK { get; set; } 

        public virtual MPIRSALIYE MPIRSALIYE { get; set; }
 
        public virtual ICollection<MPIRSALIYESIPARISDETAYILISKI> MPIRSALIYESIPARISDETAYILISKI { get; set; }
        public virtual ICollection<MPSTOKSEVKİYATLİST> MPSTOKSEVKİYATLİST { get; set; }

        public virtual ICollection<MPSTOKMALKABULLIST> MPSTOKMALKABULLIST { get; set; }
        public virtual ICollection<MPDEPOEMIRSIPARISKALEMILISKI> MPDEPOEMIRSIPARISKALEMILISKI { get; set; } 
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSIPARISSEVKEMRIHAR> MPSIPARISSEVKEMRIHAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MPSATINALMAMALKABULEMRIHAR> MPSATINALMAMALKABULEMRIHAR { get; set; }

    }
}
