using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.HIZMET;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.STOK;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.Interfaces;

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
            _tempStok = new PocoSTOK();
            _PocoOlcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _StokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
            _PocoStokServis = new GenericWebServis<PocoSTOK>();
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
            _StokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            stokOlculist = new List<PocoSTOKOLCUBR>();
        }
        #region Tanımlar
        PocoSTOKOLCUBR _tempStokOlcuBr;
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoSTOKKATEGORI _tempKategori;
        public PocoSTOKMARKA _tempMarka;
        
      
        GenericWebServis<PocoSTOKMARKA> _markaServis ;
        GenericWebServis<PocoSTOK> _PocoStokServis;
        GenericWebServis<PocoOLCUBR> _PocoOlcuBrServis;
        GenericWebServis<PocoSTOKOLCUBR> _StokOlcuBrServis;
        List<PocoSTOKOLCUBR> _PocoSTOKOLCUBR;
        List<PocoOLCUBR> _tempPocoOLCUBR;
        List<PocoSTOKOLCUBR> stokOlculist ;

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
            _PocoStokServis.Data(ServisList.StokListeServis);
            _markaServis.Data(ServisList.StokMarkaListeServis);
            if (_tempStok != null)
            {
                stokid = _tempStok.id;
                BTStokKodu.Text = _tempStok.kod;
                
            }
            TBStokAdi.Text = _tempStok.adi;
            TBSatisOtv.Text = _tempStok.satisotv.ToString();
            TBSatisKdv.Text = _tempStok.satiskdv.ToString();
            TBMarka.Text = _markaServis.obje.Where(x=>x.id.ToString()==_tempStok.markaid.ToString()).FirstOrDefault().ADI.ToString();
            TBSatisKdv.Text = _tempStok.kategoriid.ToString();
            TBGrupKodu.Text = _tempStok.grupkodu.ToString();
            TBAlisOtv.Text = _tempStok.alisotv.ToString();
            TBAlisKdv.Text = _tempStok.aliskdv.ToString();
            MEAciklama.Text = _tempStok.aciklama;
            CBSDoviz.SelectedIndex = _tempStok.sdovizid;
            CBADoviz.SelectedIndex = _tempStok.adovizid;
            TBAFiyat1.Text = Convert.ToString(_tempStok.afiyaT1);
            TBAFiyat2.Text = Convert.ToString(_tempStok.afiyaT2);
            TBAFiyat3.Text = Convert.ToString(_tempStok.afiyaT3);
            TBAFiyat4.Text = Convert.ToString(_tempStok.afiyaT4);
            TBAFiyat5.Text = Convert.ToString(_tempStok.afiyaT5);
            TBSFiyat1.Text = Convert.ToString(_tempStok.sfiyaT1);
            TBSFiyat2.Text = Convert.ToString(_tempStok.sfiyaT2);
            TBSFiyat3.Text = Convert.ToString(_tempStok.sfiyaT3);
            TBSFiyat4.Text = Convert.ToString(_tempStok.sfiyaT4);
            TBSFiyat5.Text = Convert.ToString(_tempStok.sfiyaT5);
            CBOlcuBr1.SelectedIndex = _tempStok.olcubR1;
            //dataGridView1.DataSource = _tempStok.MPSTOKOLCUBR.ToList();
            dataGridView1.Refresh();
            //var a = _PocoStokServis.obje.Select(x=>x.mpst.Select(z=>z));
            //stokOlculist = _tempStok.MPSTOKOLCUBR.ToList();
            _tempStok = null;
        }

        private void TBStokKodu_Leave(object sender, EventArgs e)               // TBStokkodu doluyken stok kodu kontrolü yapıp tempstok doldurulur.
        {
            _PocoStokServis.Data(ServisList.StokListeServis);
            if (BTStokKodu.Text != "")
            {
                _tempStok = _PocoStokServis.obje.Where(x => x.kod == BTStokKodu.Text).FirstOrDefault();
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
            _StokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            _PocoOlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _tempPocoOLCUBR = _PocoOlcuBrServis.obje;
            _PocoSTOKOLCUBR = _StokOlcuBrServis.obje;
            CBOlcuBr1.DataSource = _tempPocoOLCUBR.Select(x => x.adi).ToList();

        }
        private void BTKaydet_Click(object sender, EventArgs e)                 // Stok Kayıt
        {



            //Parallel.For(0, 50000, x =>

            //    {
            //        _markaServis.Data(ServisList.StokMarkaListeServis);
            //        _PocoStokServis.Data(ServisList.StokEkleServis,
            //     new PocoSTOK()
            //     {

            //         KOD = Faker.RandomNumber.Next(255).ToString(),
            //         ADI = Faker.Name.FullName(),
            //         MARKAID = Faker.RandomNumber.Next(255),
            //         KATEGORIID = Faker.RandomNumber.Next(255),
            //         KASAID = Faker.RandomNumber.Next(255),//_tempKasa.ID,
            //         GRUPKODU = Faker.RandomNumber.Next(255),
            //         ACIKLAMA = Faker.Name.FullName(),
            //         SATISKDV = Faker.RandomNumber.Next(255),
            //         ALISKDV = Faker.RandomNumber.Next(255),
            //         SATISOTV = Faker.RandomNumber.Next(255),
            //         ALISOTV = Faker.RandomNumber.Next(255),
            //         AFIYAT1 = Faker.RandomNumber.Next(255),
            //         AFIYAT2 = Faker.RandomNumber.Next(255),
            //         AFIYAT3 = Faker.RandomNumber.Next(255),
            //         AFIYAT4 = Faker.RandomNumber.Next(255),
            //         AFIYAT5 = Faker.RandomNumber.Next(255),
            //         SFIYAT1 = Faker.RandomNumber.Next(255),
            //         SFIYAT2 = Faker.RandomNumber.Next(255),
            //         SFIYAT3 = Faker.RandomNumber.Next(255),
            //         SFIYAT4 = Faker.RandomNumber.Next(255),
            //         SFIYAT5 = Faker.RandomNumber.Next(255),
            //         SDOVIZID = Faker.RandomNumber.Next(255),
            //         ADOVIZID = Faker.RandomNumber.Next(255),


            //     });
            //    });




            _markaServis.Data(ServisList.StokMarkaListeServis);
            _tempStok = new PocoSTOK()
            {
                id = stokid,
                kod = TBStokKodu.Text,
                adi = TBStokAdı.Text,
                markaid = _markaServis.obje.Where(x => x.ADI == TBMarka.Text).FirstOrDefault().id,
                kategoriid = _tempKategori.id,
                kasaid = 1,//_tempKasa.ID,
                grupkodu = int.Parse(TBGrupKodu.Text),
                aciklama = MEAciklama.Text,
                satiskdv = Convert.ToDecimal(TBSatisKdv.Text),
                aliskdv = Convert.ToDecimal(TBAlisKdv.Text),
                satisotv = Convert.ToDecimal(TBSatisOtv.Text),
                alisotv = Convert.ToDecimal(TBAlisOtv.Text),
                afiyaT1 = Convert.ToDecimal(TBAFiyat1.Text),
                afiyaT2 = Convert.ToDecimal(TBAFiyat2.Text),
                afiyaT3 = Convert.ToDecimal(TBAFiyat3.Text),
                afiyaT4 = Convert.ToDecimal(TBAFiyat4.Text),
                afiyaT5 = Convert.ToDecimal(TBAFiyat5.Text),
                sfiyaT1 = Convert.ToDecimal(TBSFiyat1.Text),
                sfiyaT2 = Convert.ToDecimal(TBSFiyat2.Text),
                sfiyaT3 = Convert.ToDecimal(TBSFiyat3.Text),
                sfiyaT4 = Convert.ToDecimal(TBSFiyat4.Text),
                sfiyaT5 = Convert.ToDecimal(TBSFiyat5.Text),
                sdovizid = CBSDoviz.SelectedIndex,
                adovizid = CBADoviz.SelectedIndex,


            };

            var snc = _PocoStokServis.obje;
            _PocoStokServis.Data(ServisList.StokListeServis);
            _tempStok = _PocoStokServis.obje.Where(x => x.kod == _tempStok.kod).FirstOrDefault();
            foreach (var item in stokOlculist)
            {
                item.STOKID = _PocoStokServis.obje.Where(x => x.kod == BTStokKodu.Text).FirstOrDefault().id;
                _StokOlcuBrServis.Data(ServisList.StokOlcuBrEkleServis, item);
            }

            stokid = 0;
            if (snc != null)
                MessageBox.Show("Kayıt Başarılı.");
            Temizle(this.Controls);
            BTStokKodu.Text = "";

            dataGridView1.DataSource = "";
        }
        private void BTSil_Click(object sender, EventArgs e)                  // Stok Sil
        {
            _PocoStokServis.Data(ServisList.StokSilServis,null,null,_PocoStokServis.obje.Where(x => x.id == stokid).ToList());
            Temizle(this.Controls);
        }
        private void BTMarkaSec_Click(object sender, EventArgs e)
        {
         
        }

        private void BTKategoriSec_Click(object sender, EventArgs e)
        {
        }
        private void BTNKasaSec_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                num = 0;
            }
            _tempStokOlcuBr = new PocoSTOKOLCUBR()
            {
                OLCUBRID = _tempPocoOLCUBR.Where(x => x.adi == CBOlcuBr1.SelectedValue.ToString()).FirstOrDefault().id,
                NUM = dataGridView1.RowCount + 1,
                KATSAYI = Convert.ToDecimal(TBKatsayi.Text),


            };
            stokOlculist.Add(_tempStokOlcuBr);
            dataGridView1.DataSource = stokOlculist;
            dataGridView1.Refresh();
        }

        private void BTStokSec_Click(object sender, EventArgs e)
        {

          
        }
        #endregion

        #region KeyPress
        private void TBSFiyat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSFiyat5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAFiyat5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBSatisKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAlisKdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FStokList fStokList = new FStokList("stokkart");
            fStokList.ShowDialog();
            if (_tempStok != null)
                if (_tempStok.id > 0) 
                    tbDoldur(); 
        }

        private void buttonEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FMarkaList fMarkaKart = new FMarkaList();
            fMarkaKart.ShowDialog();
            if (_tempMarka != null)
            {
                markaid = _tempMarka.id;
                TBMarka.Text = _tempMarka.ADI;
                _tempMarka = null;
            }
        }

        private void buttonEdit3_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FKategoriList fKategoriKart = new FKategoriList("Stok");
            fKategoriKart.ShowDialog();
            if (_tempKategori != null)
                TBSatisKdv.Text = _tempKategori.Acıklama;
        }

        private void BTNGrupSec_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit4_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void buttonEdit5_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FKasaList fKasaList = new FKasaList("Stok");
            fKasaList.ShowDialog();
            if (_tempKasa != null)
                TBKasa.Text = _tempKasa.KASAADI;
        }

        private void LBStokKartiAciklama3_Click(object sender, EventArgs e)
        {

        }

        private void LBStokKartiAciklama6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void TBSatisOtv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBAlisOtv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        #endregion

    }
}