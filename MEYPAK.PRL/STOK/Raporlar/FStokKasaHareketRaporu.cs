using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.IRSALIYE;
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
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
        }
        string _form, _islem;

        #region Tanımlar
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        public PocoSTOKKASA _tempStokKasa;
        public PocoIRSALIYE _tempIrsaliye;
        public PocoCARIKART _tempCariKart;
        public PocoFATURA _tempFatura;


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
            _cariServis.Data(ServisList.CariListeServis);
            _faturaServis.Data(ServisList.FaturaListeServis);
            _irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            
          
                    DGStokKasaHarRpr.DataSource = _stokKasaHarServis.obje.Select(x => new
                    {

                        ID = x.id,
                        KAYITTARİHİ = x.olusturmatarihi,
                        BELGENO = x.belge_no,
                        CARIADI = _cariServis.obje.Where(y => y.id == x.cariid).Count() > 0 ? _cariServis.obje.Where(y => y.id == x.cariid).FirstOrDefault().unvan : "",
                        KASAADI = _stokKasaServis.obje.Select(x => x.kasaadi).FirstOrDefault(), 
                        MİKTAR = x.miktar,
                        // STOKID = x.stokid,
                          KAYITTİPİ = x.kayittipi,

                    });
                    DGStokKasaHarRpr.Refresh();
                    DGStokKasaHarRpr.RefreshDataSource();
            
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

        private void BTIrsaliyeSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FIrsaliyeList fIrsaliyeList = new FIrsaliyeList(Tag.ToString(), "FStokKasaHareketRaporu");
            fIrsaliyeList.ShowDialog(); 

        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(Tag.ToString(), "FStokKasaHareketRaporu");
            fCariList.ShowDialog();
            
        }

        

        #endregion

    }
}
 