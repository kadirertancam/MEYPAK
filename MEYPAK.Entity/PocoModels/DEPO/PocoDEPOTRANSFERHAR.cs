using MEYPAK.Entity.PocoModels.STOK;
using System.ComponentModel.DataAnnotations;

namespace MEYPAK.Entity.PocoModels.DEPO
{
    public class PocoDEPOTRANSFERHAR:SUPERPOCOMODEL
    {
        [Required]
        public int depotransferid { get; set; }
        [Required]
        public int stokid { get; set; }
        public int miktar { get; set; }
        //BİRİM ID EKLENECEK.

        public byte durum { get; set; }
        [StringLength(200)]
        public string aciklama { get; set; } = "";
        [Required]
        public string donem { get; set; } = DateTime.Now.ToString("yyyy");
    }
}
