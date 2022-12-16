using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
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
    public partial class FMusteriSiparisRaporu : XtraForm
    {
        public FMusteriSiparisRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _musteriSiparisServis = new GenericWebServis<PocoSIPARIS>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _altHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
            _depoServis = new GenericWebServis<PocoDEPO>();
        }

        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoSIPARIS> _musteriSiparisServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHES> _altHesapServis;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        GenericWebServis<PocoDEPO> _depoServis;
        public PocoSIPARIS _tempSIPARIS;
        public PocoCARIKART _tempCariKart;
        public PocoCARIALTHES _tempCARIALTHES;
        public PocoDEPO _tempDepo;
        #endregion

        void Doldur()
        {

            _musteriSiparisServis.Data(ServisList.SiparisListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            _altHesapServis.Data(ServisList.CariAltHesListeServis);
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            GridiDoldur(_musteriSiparisServis.obje);
            DGMSiparisRaporu.RefreshDataSource();


        }
        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FMusteriSiparisRaporu");
            fCariList.ShowDialog();
            if (_tempCariKart != null)
                BTCariSec.Text = _tempCariKart.unvan;
            GridiDoldur(Filtrele());
        }

        private void BTAltHesSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FAltHesapList fAltHesapList = new FAltHesapList(this.Tag.ToString(), "FMusteriSiparisRaporu");
            fAltHesapList.ShowDialog();
            if (_tempCARIALTHES != null)
                BTAltHesSec.Text = _tempCARIALTHES.adi;
            GridiDoldur(Filtrele());
        }

        private void BTDepoSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FDepoList fDepoList = new FDepoList(this.Tag.ToString(), "FMusteriSiparisRaporu");
            fDepoList.ShowDialog();
            if (_tempDepo != null)
                BTDepoSec.Text = _tempDepo.aciklama;
            GridiDoldur(Filtrele());
        }

        private void FMusteriSiparisRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void BTSiparisSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FMusteriSiparisList fMusteriSiparisList = new FMusteriSiparisList(this.Tag.ToString(), "FMusteriSiparisRaporu");
            fMusteriSiparisList.ShowDialog();
            if (_tempSIPARIS != null)
                BTSiparisSec.Text = _tempSIPARIS.belgeno;
            GridiDoldur(Filtrele());

        }

        List<PocoSIPARIS> Filtrele()
        {
            List<PocoSIPARIS> filtre = new List<PocoSIPARIS>();
            if (BTSiparisSec.Text != "" && _tempSIPARIS != null)
                filtre.Add(_tempSIPARIS);
            else if (BTCariSec.Text != "" && _tempCariKart != null)
                filtre.AddRange(_musteriSiparisServis.obje.Where(x => x.cariid == _tempCariKart.id));
            else if (BTAltHesSec.Text != "" && _tempCARIALTHES != null)
                filtre.AddRange(_musteriSiparisServis.obje.Where(x => x.althesapid == _tempCARIALTHES.id));
            else if (BTDepoSec.Text != "" && _tempDepo != null)
                filtre.AddRange(_musteriSiparisServis.obje.Where(x => x.depoid == _tempDepo.id));
            else
                return _musteriSiparisServis.obje;


            return filtre;
        }

        void GridiDoldur(List<PocoSIPARIS> A)
        {
            DGMSiparisRaporu.DataSource = A.Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                SİPARİŞTARİHİ = x.siparistarihi,
                DÖNEM = x.donem,
                TİPİ = x.tip,
                BELGENO = x.belgeno,
                SERİNO = x.serino,
                AÇIKLAMA = x.aciklama,
                EKAÇIKLAMA = x.ekaciklama,
                DURUM = x.durum,
                CARİKODU = _cariServis.obje.Where(y => y.id == x.cariid).Count() > 0 ? _cariServis.obje.Where(y => y.id == x.cariid).FirstOrDefault().unvan : "",
                CARİADI = x.cariadi,
                ALTHESAP = _altHesapServis.obje.Where(y => y.id == x.althesapid).Count() > 0 ? _altHesapServis.obje.Where(y => y.id == x.althesapid).FirstOrDefault().adi : "",
                SEVKİYATTARİHİ = x.sevkiyattarihi,
                VADETARİHİ = x.vadetarihi,
                VADEGÜNÜ = x.vadegunu,
                DÖVİZ = _paraBirimServis.obje.Where(y => y.id == x.dovizid).Count() > 0 ? _paraBirimServis.obje.Where(y => y.id == x.dovizid).FirstOrDefault().adi : "",
                KUR = x.kur,
                BRÜTTOPALM = x.bruttoplam,
                İSKONTOTOPLAM = x.istkontotoplam,
                NETTOPLAM = x.nettoplam,
                KDVDAHİL = x.kdvdahil,
                KDVTOPLAM = x.kdvtoplam,
                GENELTOPLAM = x.geneltoplam,
                DEPOADI = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().aciklama : "",
                ŞİRKETID = x.sirketid,
                ŞUBEID = x.subeid,
                KULLANICITİPİ = x.kullanicitipi,
                KULLANICIİD = x.kullaniciid,
                GÜNCELLEMETARİHİ = x.guncellemetarihi,

            }).ToList();
        }
    }
}