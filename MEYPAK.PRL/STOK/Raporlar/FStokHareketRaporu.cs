using DevExpress.XtraEditors;
using DevExpress.XtraMap.Drawing.Direct2D11;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.DEPO;
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
    public partial class FStokHareketRaporu : XtraForm
    {
        public FStokHareketRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            _OlcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _sayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _form = tag;
            _islem = islem;
          
        }
        
        #region Tanımlar
        string _form, _islem;
        public PocoSTOK _tempStok;
        public PocoSTOKHAR _tempStokHar;
        public PocoDEPO _tempDepo;
        public PocoSTOKSAYIM _tempSayim;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoOLCUBR> _OlcuBrServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSTOKSAYIM> _sayimServis;
        GenericWebServis<PocoFATURA> _faturaServis;
        #endregion

        #region Metotlar
        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            FStokList fStokList = new FStokList(this.Tag.ToString(), "FStokHareketRaporu");
            fStokList.ShowDialog();
            
        }

        private void FStokHareketRaporu_Load(object sender, EventArgs e)
        {
            
            Doldur();
        }

        private void BTDepoSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FDepoList fDepoList = new FDepoList(this.Tag.ToString(), "FStokHareketRaporu");
            fDepoList.ShowDialog();
        }

        private void BTFaturaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FFaturaList fFaturaList = new FFaturaList(this.Tag.ToString(), "FStokHareketRaporu");
            fFaturaList.ShowDialog();
            
        }

        private void BTSayimSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FSayimList fSayimList = new FSayimList(this.Tag.ToString(), "FStokHareketRaporu");
            fSayimList.ShowDialog();
        }

        void Doldur()
        {
            _stokHarServis.Data(ServisList.StokHarListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _sayimServis.Data(ServisList.StokSayimListeServis);
            _faturaServis.Data(ServisList.FaturaListeServis);
           _OlcuBrServis.Data(ServisList.OlcuBrListeServis);
            DGStokHareketRpr.DataSource = _stokHarServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                BELGENO = x.belgE_NO,
                AÇIKLAMA =x.aciklama,
                HAREKETTTÜRÜ = x.hareketturu == 1 ? "Satış Fatura" : x.hareketturu == 2 ? "Alış Fatura" : x.hareketturu == 3 ? "Satış Irsaliye" : x.hareketturu == 4 ? "Alış Irsaliye" : x.hareketturu == 5 ? "Satış Fatura Iade" : x.hareketturu == 6 ? "Alış Fatura Iade" : x.hareketturu == 7 ? "Satış Irsalye Iade" : x.hareketturu == 8 ? "Alış Irsaliye Iade" : x.hareketturu == 9 ? "Muhtelif" : x.hareketturu == 10 ? "DAT" : x.hareketturu == 11 ? "Sayim" : "Muhtelif",
                STOKADI = _stokServis.obje.Where(y => y.id == x.stokid).Count() > 0 ? _stokServis.obje.Where(y => y.id == x.stokid).FirstOrDefault().adi : "", //farklı tablodan gridde id den farklı veri getirme
                KÜNYE = x.kunye,
                DEPOADI = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().depoadi : "",
                SAYIMAÇIKLAMA = _sayimServis.obje.Where(y => y.id == x.id).Count() > 0 ? _sayimServis.obje.Where(y => y.id == x.id).FirstOrDefault().aciklama : "",
                FATURANO = _faturaServis.obje.Where(y => y.id == x.id).Count() > 0 ? _faturaServis.obje.Where(y => y.id == x.id).FirstOrDefault().belgeno : "",
                BİRİM = _OlcuBrServis.obje.Where(y => y.id == x.id).Count() > 0 ? _OlcuBrServis.obje.Where(y => y.id == x.id).FirstOrDefault().adi : "",
                MİKTAR =x.miktar,
                BRÜTTOPLAM = x.bruttoplam,
                GİRİŞ = x.io == 1 ? x.miktar : 0,
                ÇIKIŞ = x.io == 0 ? x.miktar : 0,
                KDV = x.kdv,
                NETFİYAT = x.netfiyat,
                NETTOPLAM = x.nettoplam,
                SİRKETID =x.sirketid,
                ŞUBEID =x.subeid,
                KULLANICIID = x.kullaniciid,
                GÜNCELLEMETARİHİ =x.guncellemetarihi,
                
            });
            DGStokHareketRpr.Refresh();
            DGStokHareketRpr.RefreshDataSource();


          
               
           

        }

        


    }
        #endregion
    }

