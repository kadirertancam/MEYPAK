using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokListesiRaporu : XtraForm
    {
        public FStokListesiRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _stokServis = new GenericWebServis<PocoSTOK>();
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
        }

        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKMARKA> _markaServis;
        public PocoSTOK _tempStok;
        #endregion
        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FStokList fStokList = new FStokList(this.Tag.ToString(), "stoklist");
            fStokList.ShowDialog();
            Doldur();
        }

        private void FStokListesiRaporu_Load(object sender, EventArgs e)
        {
            
                Doldur();
        }

        void Doldur()
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            _stokServis.Data(ServisList.StokListeServis);
              DGStokRpr.DataSource = _stokServis.obje.Where(x => x.kayittipi == 0).Select(x => new
               {
                 ID = x.id,
                 KAYITTARİHİ = x.olusturmatarihi,
                 KOD = x.kod,
                 ADI = x.adi,
                 ÖLÇÜBİRİMİ = x.olcubR1,
                 MARKA = _stokServis.obje.Where(z => z.id == x.markaid).Select(z => z.adi).FirstOrDefault(),
                 ALIŞKDV = x.aliskdv,
                 SATIŞKDV =x.satiskdv,
                 ALIŞÖTV =x.alisotv,
                 SATIŞÖTV = x.satisotv,
                 ALIŞFİYATI1 =x.afiyaT1,
                 ALIŞFİYATI2 = x.afiyaT2,
                 ALIŞFİYATI3 = x.afiyaT3,
                 ALIŞFİYATI4 = x.afiyaT4,
                 ALIŞFİYATI5 = x.afiyaT5,
                 SATIŞFİYATI = x.sfiyaT1,
                 SATIŞFİYATI2 = x.sfiyaT2,
                 SATIŞFİYATI3 = x.sfiyaT3,
                 SATIŞFİYATI4 = x.sfiyaT4,
                 SATIŞFİYATI5 = x.sfiyaT5,
                 RAPORKODU =x.raporkodu,
                 RAPORKODU1 = x.raporkodU1,
                 RAPORKODU2 = x.raporkodU2,
                 RAPORKODU3 = x.raporkodU3, 
                 RAPORKODU4 = x.raporkodU4, 
                 RAPORKODU5 = x.raporkodU5,
                 RAPORKODU6 = x.raporkodU6,  
                 RAPORKODU7 = x.raporkodU7,  
                 RAPORKODU8 = x.raporkodU8,  
                 RAPORKODU9 = x.raporkodU9,
                 GRUPKODU = x.grupkodu,
                 
               }).ToList();
              DGStokRpr.Refresh();
              DGStokRpr.RefreshDataSource();
             
        }
    }
}
