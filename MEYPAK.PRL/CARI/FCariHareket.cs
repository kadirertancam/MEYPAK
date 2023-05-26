using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Resizing;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariHareket : XtraForm
    {
        public FCariHareket()
        {
            InitializeComponent();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();
            _tempCARIKART = new PocoCARIKART();
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            CBParaBrm.Properties.DataSource = _parabirIMServis.obje.Select(x => x.adi).ToList(); //comboxun içini parabirim formundan doldurur
            RGCariHareket.SelectedIndex = 0;
            _parabirimServis = new GenericWebServis<PocoPARABIRIM>();
            userServis = new GenericWebServis<MPUSER>();

        }
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        FCariList _fCariList;
        public PocoCARIKART _tempCARIKART;
        public PocoCARIALTHES _tempAltHesap;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _parabirimServis;
        GenericWebServis<MPUSER> userServis;

        public void Doldur()
        {
            userServis.Data(ServisList.UserGetServis);
            _parabirimServis.Data(ServisList.ParaBirimiListeServis);
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            BTCariSec.Text = _tempCARIKART.kod;
            TBAdi.Text = _tempCARIKART.unvan == "" ? _tempCARIKART.adi + " " + _tempCARIKART.soyadi : _tempCARIKART.unvan;
            DGCariHareket.DataSource = _cariHarServis.obje.Where(x => x.cariid == _tempCARIKART.id).Select(x=>new {TARIH=x.harekettarihi,_cariAltHesapServis.obje.Where(y=>y.id== x.carialthesapid).FirstOrDefault().adi,BELGENO=x.belgE_NO,x.borc,x.alacak,x.tutar,x.aciklama,x.kur,ParaBirimi=_parabirIMServis.obje.Where(y=>y.id==x.parabirimid).FirstOrDefault().adi,Kullanıcı=userServis.obje.Where(y=>y.Id== x.userid).FirstOrDefault().AD});
            LBAlacakDeger.Text = _cariHarServis.obje.Where(x => x.cariid == _tempCARIKART.id).Sum(x => x.alacak).ToString();
            LBBorcDeger.Text = _cariHarServis.obje.Where(x => x.cariid == _tempCARIKART.id).Sum(x => x.borc).ToString();
            LBBakiyeDeger.Text = _cariHarServis.obje.Where(x => x.cariid == _tempCARIKART.id).Sum(x => x.borc - x.alacak).ToString();
            DGCariHareket.Refresh();
            DGCariHareket.RefreshDataSource();

        }



        void temizle()
        {
            TBAciklama.Text = "";
            TBFiyat.Text = "";
            TBKur.Text = "0";
            TBBelgeNo.Text = "";
            CBParaBrm.Text = "";
            CBAltHesap.Text = "";
          
        }

        private void FCariHareket_Load(object sender, EventArgs e)
        {
            DTTar.EditValue = DateTime.Now;
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cariHarServis.Data(ServisList.CariHarListeServis);
            _fCariList = new FCariList(this.Tag.ToString(), "carihar");
            _fCariList.ShowDialog();
            temizle();
            Doldur();
            //_fCariList=new FCariList();
            //_fCariList.ShowDialog();
            //if(_tempCARIKART!=null)
            //    Doldur();
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _cariHarServis.Data(ServisList.CariHarEkleServis, new PocoCARIHAR()
            {
                cariid = _tempCARIKART.id,
                aciklama = TBAciklama.Text,
                alacak = RGCariHareket.SelectedIndex == 0 ? Convert.ToDecimal(TBFiyat.Text) : 0,
                borc = RGCariHareket.SelectedIndex == 1 ? Convert.ToDecimal(TBFiyat.Text) : 0,
                belgE_NO = TBBelgeNo.Text,
                harekettipi = 5,
                //TO DO:      // = Convert.ToDecimal(CBSube.Text),   //CBSUbe eklenecek
                kur = Convert.ToDecimal(TBKur.Text),
                tutar = Convert.ToDecimal(TBFiyat.Text),
                parabirimid = _parabirIMServis.obje.Where(x => x.adi.ToString() == CBParaBrm.EditValue.ToString()).FirstOrDefault().id,
                id = _tempAltHesap.id,
                harekettarihi = DateTime.Now,
                userid = MPKullanici.ID,


            });
            temizle();
            Doldur();
        }
    }
}
