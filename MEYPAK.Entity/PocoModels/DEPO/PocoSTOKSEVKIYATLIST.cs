using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoSTOKSEVKIYATLIST:SUPERPOCOMODEL
    {
        public int sirketid { get; set; } = 0;
        public int subeid { get; set; } = 0;
        public int depoid { get; set; } = 0;
        public int stokid { get; set; } = 0;
        public int birimid { get; set; } = 0;
        public int siparisdetayid { get; set; } = 0;
        public decimal siparismiktari { get; set; } = 0;
        public decimal miktar { get; set; } = 0;
        public decimal kalanmiktar { get; set; } = 0;
        public int emirid { get; set; } = 0;
        public int kullaniciid { get; set; } = 0;
        public int sevkemriharid { get; set; } =0;
    }
}
