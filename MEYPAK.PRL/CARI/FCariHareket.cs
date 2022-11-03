using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
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
    public partial class FCariHareket : Form
    {
        public FCariHareket()
        {
            InitializeComponent();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();
            _tempCARIKART = new PocoCARIKART();
            RGCariHareket.SelectedIndex = 0;
        }
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        FCariList _fCariList;
        public PocoCARIKART _tempCARIKART;

        public void Doldur()
        {
            BTCariKodu.Text = _tempCARIKART.KOD;
            TBCariAdi.Text = _tempCARIKART.UNVAN==""? _tempCARIKART.ADI + " " + _tempCARIKART.SOYADI : _tempCARIKART.UNVAN;
            gridControl1.DataSource = _cariHarServis.obje.Where(x => x.CARIID == _tempCARIKART.id);
            LBToplamAlacakDeger.Text = _cariHarServis.obje.Where(x => x.CARIID == _tempCARIKART.id).Sum(x => x.ALACAK).ToString();
            LBToplamBorcDeger.Text = _cariHarServis.obje.Where(x => x.CARIID == _tempCARIKART.id).Sum(x => x.BORC).ToString();
            LBToplamBakiye.Text = _cariHarServis.obje.Where(x => x.CARIID == _tempCARIKART.id).Sum(x => x.BORC - x.ALACAK).ToString();
        } 

        private void TBCariKodu_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _cariHarServis.Data(ServisList.CariHarListeServis);
            _fCariList = new FCariList(this.Tag.ToString(),"carihar");
            _fCariList.ShowDialog();
            temizle();
            Doldur();
          
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 

        private void LBTarih_Click(object sender, EventArgs e)
        {

        }

        private void BTCariHareketKaydet_Click(object sender, EventArgs e)
        {
           
        }

        private void BTCariHareketKaydet_Click_1(object sender, EventArgs e)
        {
            _cariHarServis.Data(ServisList.CariHarEkleServis, new PocoCARIHAR()
            {
                CARIID = _tempCARIKART.id,
                ACIKLAMA = TBAciklama.Text,
                ALACAK = RGCariHareket.SelectedIndex == 0 ? Convert.ToDecimal(TBFiyat.Text) : 0,
                BORC = RGCariHareket.SelectedIndex == 1 ? Convert.ToDecimal(TBFiyat.Text) : 0,
                BELGE_NO = TEBelgeNo.Text,
                HAREKETTIPI = 5,
                KUR = Convert.ToDecimal(TBKur.Text),
                TUTAR = Convert.ToDecimal(TBFiyat.Text),
                PARABIRIMID = 1,  //TODO:Parabirimi Tablosu eklendikten sonra kontrol edilecek
                HAREKETTARIHI = DateTime.Now

            });
            temizle();
            Doldur();
        }
        void temizle()
        {
            TBAciklama.Text = "";
            TBFiyat.Text = "";
            TBKur.Text = "0";
            TEBelgeNo.Text = ""; 
        }

        private void FCariHareket_Load(object sender, EventArgs e)
        {
            DTTarih.EditValue = DateTime.Now;
        }
    }
}
