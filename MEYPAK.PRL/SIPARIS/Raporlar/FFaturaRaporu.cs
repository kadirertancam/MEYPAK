using DevExpress.DirectX.Common.Direct2D;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.DEPO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS.Raporlar
{
    public partial class FFaturaRaporu : XtraForm
    {
        public FFaturaRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _althesapServis = new GenericWebServis<PocoCARIALTHES>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _personelServis = new GenericWebServis<PocoPERSONEL>();
            _aracServis = new GenericWebServis<PocoARAC>();
        }

        #region Tanımlar
        string _form, _islem;
        public PocoFATURA _tempFatura;
        public PocoCARIKART _tempCariKart;
        public PocoDEPO _tempDepo;
        public PocoCARIALTHES _tempCARIALTHES;
        public PocoIRSALIYE _tempIrsaliye;
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHES> _althesapServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoPERSONEL> _personelServis;
        GenericWebServis<PocoARAC> _aracServis;
        #endregion


        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FFaturaRaporu");
            fCariList.ShowDialog();
            
        }
        private void BTFaturaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FFaturaList ffaturalist = new FFaturaList(this.Tag.ToString(), "FFaturaRaporu");
            ffaturalist.ShowDialog();
           
        }

        private void BTDepoSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FDepoList fDepoList = new FDepoList(this.Tag.ToString(), "FFaturaRaporu");
            fDepoList.ShowDialog();
        }

        private void BTAltHesSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FAltHesapList fAltHesapList = new FAltHesapList(this.Tag.ToString(), "FFaturaRaporu");
            fAltHesapList.ShowDialog();
        }

        private void BTIrsaliyeSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FIrsaliyeList fIrsaliyeList = new FIrsaliyeList(this.Tag.ToString(), "FFaturaRaporu");
            fIrsaliyeList.ShowDialog();
        }

        private void FFaturaRaporu_Load(object sender, EventArgs e)
        {
            
            Doldur();
        }

        void Doldur()
        {

            _faturaServis.Data(ServisList.FaturaListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            _althesapServis.Data(ServisList.CariAltHesListeServis);
            _irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            _personelServis.Data(ServisList.PersonelListeServis);
            _aracServis.Data(ServisList.AracListeServis);
            DGFaturaRpr.DataSource = _faturaServis.obje.Select(x => new
            {
                

                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                FATURATARİHİ =x.faturatarihi,
                DÖNEM = x.donem,
                SERİNO = x.serino,
                TİPİ = x.tip,
                FATURAADI = x.belgeno,
                AÇIKLAMA =x.aciklama,
                EKAÇIKLAMA = x.ekaciklama,
                IRSALİYENO = _irsaliyeServis.obje.Where(y => y.id == x.irsaliyeid).Count() > 0 ? _irsaliyeServis.obje.Where(y => y.id == x.irsaliyeid).FirstOrDefault().belgeno : "",
                CARİKODU = _cariServis.obje.Where(y => y.id == x.cariid).Count() > 0 ? _cariServis.obje.Where(y => y.id == x.cariid).FirstOrDefault().unvan : "",
                CARİADI = x.cariadi,
                ALTHESAP = _althesapServis.obje.Where(y => y.id == x.althesapid).Count() > 0 ? _althesapServis.obje.Where(y => y.id == x.althesapid).FirstOrDefault().adi : "",
                İRSALİYENO = _irsaliyeServis.obje.Where(y => y.id == x.irsaliyeid).Count() > 0 ? _irsaliyeServis.obje.Where(y => y.id == x.irsaliyeid).FirstOrDefault().belgeno : "",
                VADETARİHİ = x.vadetarihi,
                VADEGÜNÜ = x.vadegunu,
                DÖVİZ = _paraBirimServis.obje.Where(y => y.id == x.dovizid).Count() > 0 ? _paraBirimServis.obje.Where(y => y.id == x.dovizid).FirstOrDefault().adi : "",
                KUR = x.kur,
                KDV = x.kdvdahil,
                ISKONTO = x.iskontotoplam,
                KDVTOPLAM = x.kdvtoplam,
                BRÜTTOPLAM = x.bruttoplam,
                NETTOPLAM =x.nettoplam,
                GENELTOPLAM =x.geneltoplam,
                DEPOADI = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().aciklama : "",
                PERSONELADI = _personelServis.obje.Where(y => y.id == x.personelid).Count() > 0 ? _personelServis.obje.Where(y => y.id == x.personelid ).FirstOrDefault().adisoyadi : "",
                ARACPLAKA = _aracServis.obje.Where(y => y.id == x.aracid).Count() > 0 ? _aracServis.obje.Where(y => y.id == x.aracid).FirstOrDefault().plaka : "",
                KULLANICIID = x.kullaniciid,
                KULLANICITİPİ = x.kullanicitipi,
                ŞİRKETID = x.sirketid,
                ŞUBEID =x.subeid,
                DURUM = x.durum,
                GÜNCELLEMETARİHİ = x.guncellemetarihi,

 



            });
            DGFaturaRpr.Refresh();
            DGFaturaRpr.RefreshDataSource();
        }
       

       
    }
}
