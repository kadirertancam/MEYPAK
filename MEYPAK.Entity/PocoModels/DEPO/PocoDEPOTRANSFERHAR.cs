using MEYPAK.Entity.PocoModels.STOK;
using System.ComponentModel.DataAnnotations;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOTRANSFERHAR:SUPERPOCOMODEL
    {
        [Required]
        public int DEPOTRANSFERID { get; set; }
        [Required]
        public int STOKID { get; set; }
        public int MIKTAR { get; set; }
        //BİRİM ID EKLENECEK.

        public byte DURUM { get; set; }
        [StringLength(200)]
        public string ACIKLAMA { get; set; } = "";
        [Required]
        public string DONEM { get; set; } = DateTime.Now.ToString("yyyy");
        public virtual PocoDEPOTRANSFER DEPOTRANSFER { get; set; }
        public virtual PocoSTOK STOK { get; set; }
    }
}
