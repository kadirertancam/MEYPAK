using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.HIZMET;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.STOK;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MEYPAK.PRL
{
    public partial class FStokKart : Form
    {
        /// <summary>
        /// Kategori ve grup yapısı oluşturulacak.
        /// </summary>
        public FStokKart()
        {
            InitializeComponent();
            _tempStok = new MPSTOK();

        }
        #region Tanımlar
        MPSTOKOLCUBR _tempStokOlcuBr;
        public MPSTOK _tempStok;
        public MPMARKA _tempMarka;
        static MEYPAKContext context = NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        IStokServis _stokServis = new StokManager(new EFStokRepo(context));
        IMarkaServis _markaServis = new MarkaManager(new EFMarkaRepo(context));
        IStokOlcuBrServis _stokOlcuBrServis = new StokOlcuBrManager(new EFStokOlcuBrRepo(context));
        IOlcuBrServis _OlcuBrServis = new OlcuBrManager(new EFOlcuBrRepo(context));
        List<MPSTOKOLCUBR> stokOlculist = new List<MPSTOKOLCUBR>();

        int stokid = 0, markaid = 0, num = 0;

        #endregion 
        #region Methods

        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (ctrl.Name != "TBStokKodu")
                        ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
        }

        private void tbDoldur()                                                 // _tempStok nesnesi dolduğu zaman bu method ile formdaki nesneleri doldur
        {
            if (_tempStok != null)
            {
                stokid = _tempStok.ID;
                TBStokKodu.Text = _tempStok.KOD;
            }
            TBStokAdı.Text = _tempStok.ADI;
            TBSatisOtv.Text = _tempStok.SATISOTV.ToString();
            TBSatisKdv.Text = _tempStok.SATISKDV.ToString();
            TBMarka.Text = _markaServis.Getir(x=>x.ID.ToString()==_tempStok.MARKAID.ToString()).FirstOrDefault().ADI.ToString();
            TBKategori.Text = _tempStok.KATEGORIID.ToString();
            TBGrupKodu.Text = _tempStok.GRUPKODU.ToString();
            TBAlisOtv.Text = _tempStok.ALISOTV.ToString();
            TBAlisKdv.Text = _tempStok.ALISKDV.ToString();
            TBAcıklama.Text = _tempStok.ACIKLAMA;
            CBSDoviz.SelectedIndex = _tempStok.SDOVIZID;
            CBADoviz.SelectedIndex = _tempStok.ADOVIZID;
            TBAFiyat1.Text = Convert.ToString(_tempStok.AFIYAT1);
            TBAFiyat2.Text = Convert.ToString(_tempStok.AFIYAT2);
            TBAFiyat3.Text = Convert.ToString(_tempStok.AFIYAT3);
            TBAFiyat4.Text = Convert.ToString(_tempStok.AFIYAT4);
            TBAFiyat5.Text = Convert.ToString(_tempStok.AFIYAT5);
            TBSFiyat1.Text = Convert.ToString(_tempStok.SFIYAT1);
            TBSFiyat2.Text = Convert.ToString(_tempStok.SFIYAT2);
            TBSFiyat3.Text = Convert.ToString(_tempStok.SFIYAT3);
            TBSFiyat4.Text = Convert.ToString(_tempStok.SFIYAT4);
            TBSFiyat5.Text = Convert.ToString(_tempStok.SFIYAT5);
            CBOlcuBr1.SelectedIndex = _tempStok.OLCUBR1;
            dataGridView1.DataSource = _tempStok.MPSTOKOLCUBR.ToList();
            dataGridView1.Refresh();
            var a = _stokServis.Listele().Select(x=>x.MPSTOKOLCUBR.Select(z=>z));
            stokOlculist.Clear(); 
            _tempStok = null;
        }

        private void TBStokKodu_Leave(object sender, EventArgs e)               // TBStokkodu doluyken stok kodu kontrolü yapıp tempstok doldurulur.
        {
            if (TBStokKodu.Text != "")
            {
                _tempStok = _stokServis.Getir(x => x.KOD == TBStokKodu.Text).FirstOrDefault();
                if (_tempStok != null)
                    tbDoldur();
                else
                {
                    Temizle(this.Controls);
                    dataGridView1.DataSource = "";
                    stokid = 0;
                }
            }
        }
        #endregion
        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            CBOlcuBr1.DataSource = _OlcuBrServis.Listele().Select(x => x.ADI).ToList();

        }
        private void BTKaydet_Click(object sender, EventArgs e)                 // Stok Kayıt
        {
            _tempStok= new MPSTOK()
            {
                ID = stokid,
                KOD = TBStokKodu.Text,
                ADI = TBStokAdı.Text,
                MARKAID = _markaServis.Getir(x => x.ADI == TBMarka.Text).FirstOrDefault().ID,
                KATEGORIID = int.Parse(TBKategori.Text),
                GRUPKODU = int.Parse(TBGrupKodu.Text),
                ACIKLAMA = TBAcıklama.Text,
                SATISKDV = Convert.ToDecimal(TBSatisKdv.Text),
                ALISKDV = Convert.ToDecimal(TBAlisKdv.Text),
                SATISOTV = Convert.ToDecimal(TBSatisOtv.Text),
                ALISOTV = Convert.ToDecimal(TBAlisOtv.Text),
                AFIYAT1 = Convert.ToDecimal(TBAFiyat1.Text),
                AFIYAT2 = Convert.ToDecimal(TBAFiyat2.Text),
                AFIYAT3 = Convert.ToDecimal(TBAFiyat3.Text),
                AFIYAT4 = Convert.ToDecimal(TBAFiyat4.Text),
                AFIYAT5 = Convert.ToDecimal(TBAFiyat5.Text),
                SFIYAT1 = Convert.ToDecimal(TBSFiyat1.Text),
                SFIYAT2 = Convert.ToDecimal(TBSFiyat2.Text),
                SFIYAT3 = Convert.ToDecimal(TBSFiyat3.Text),
                SFIYAT4 = Convert.ToDecimal(TBSFiyat4.Text),
                SFIYAT5 = Convert.ToDecimal(TBSFiyat5.Text),
                SDOVIZID = CBSDoviz.SelectedIndex,
                ADOVIZID = CBADoviz.SelectedIndex,

            };

            var snc = _stokServis.EkleyadaGuncelle(_tempStok);
            _tempStok=_stokServis.Getir(x => x.KOD == _tempStok.KOD).FirstOrDefault();
            foreach (var item in stokOlculist)
            {
                item.STOKID = _stokServis.Getir(x=>x.KOD==TBStokKodu.Text).FirstOrDefault().ID; 
                _stokOlcuBrServis.Ekle(item);
            }
            
            stokid = 0;
            if (snc == Interfaces.Durum.başarılı)
                MessageBox.Show("Kayıt Başarılı.");
            Temizle(this.Controls);
            TBStokKodu.Text = "";
            
            dataGridView1.DataSource = "";
        }
        private void BTSil_Click(object sender, EventArgs e)                  // Stok Sil
        {
            _stokServis.Sil(x => x.ID == stokid);
            Temizle(this.Controls);
        }
        private void BTMarkaSec_Click(object sender, EventArgs e)
        {
            FMarkaList fMarkaKart = new FMarkaList();
            fMarkaKart.ShowDialog();
            markaid = _tempMarka.ID;
            TBMarka.Text = _tempMarka.ADI;
            _tempMarka = null;
            dataGridView1.DataSource = stokOlculist;
        }

        private void BTKategoriSec_Click(object sender, EventArgs e)
        {
            FKategoriList fKategoriKart = new FKategoriList();
            fKategoriKart.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                num = 0;
            }
            _tempStokOlcuBr = new MPSTOKOLCUBR()
            {
                OLCUBRID = _OlcuBrServis.Getir(x => x.ADI == CBOlcuBr1.SelectedValue.ToString()).FirstOrDefault().ID,
                NUM = dataGridView1.RowCount + 1,
                KATSAYI = Convert.ToDecimal(TBKatsayi.Text),


            };
            stokOlculist.Add(_tempStokOlcuBr);
            dataGridView1.DataSource = stokOlculist;
            dataGridView1.Refresh();
        }

        private void BTStokSec_Click(object sender, EventArgs e)
        {

            FStokList fStokList = new FStokList("stokkart");
            fStokList.ShowDialog();
            if (_tempStok != null)
                if (_tempStok.ID > 0)
                {

                    tbDoldur();
                }
        }
        #endregion


    }
}