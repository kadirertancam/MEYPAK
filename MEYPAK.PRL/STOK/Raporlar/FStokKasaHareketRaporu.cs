using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.SIPARIS;
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
    public partial class FStokKasaHareketRaporu : XtraForm
    {
        public FStokKasaHareketRaporu(string tag="", string islem ="")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
        }
        string _form, _islem;

        #region Tanımlar
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        public PocoCARIKART _tempCariKart;
        public PocoSTOKKASA _tempStokKasa;

        #endregion

        #region Metotlar

        private void FStokKasaHareketRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            //if (_tempStok != null) { 
            //    if (_tempStok.id > 0)
            //    {
                    DGStokKasaHarRpr.DataSource = _stokKasaHarServis.obje.Where(x => x.kayittipi == 0 /*&& x.id ==  _tempStok.id */).Select(x => new
                    {

                        ID = x.id,
                        KAYITTARİHİ = x.olusturmatarihi,
                        BELGENO = x.belge_no,
                        MİKTAR = x.miktar,
                        KAYITTİPİ = x.kayittipi,
                        STOKID = x.stokid,
                        KASAID = x.kasaid,
                        CARIID = x.cariid,
                        FATURAID = x.faturaid,
                        FATURADETAY = x.faturadetayid,
                        İRSALİYEID = x.irsaliyeid,
                        İRSALİYEDETAY = x.iresliyedetayid,

                    });
                    DGStokKasaHarRpr.Refresh();
                    DGStokKasaHarRpr.RefreshDataSource();
                    
            //    }
              
            //}
        }

        private void BTKasaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FStokKasaList2 fStokKasaList2 = new FStokKasaList2(Tag.ToString(), "FStokKasaHareketRaporu");
            fStokKasaList2.ShowDialog();
        }

        private void BTFaturaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FFaturaList fFaturaList = new FFaturaList(Tag.ToString(), "FStokKasaHareketRaporu");
            fFaturaList.ShowDialog();
        }

        private void BTRaporla_Click(object sender, EventArgs e)
        {
            //List<PocoSTOKKASAHAR> temp = new List<PocoSTOKKASAHAR>();
            //if (BTCariSec.Text!="")
            //{
               
            //}




            //temp = _stokKasaHarServis.obje.Where();
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(Tag.ToString(), "FStokKasaHareketRaporu");
            fCariList.ShowDialog();
        }

        
        #endregion

    }
}
 