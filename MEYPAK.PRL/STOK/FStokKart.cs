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
                stokid = _tempStok.ID;
                TBStokKodu.Text = _tempStok.KOD;
            }
            TBStokAdı.Text = _tempStok.ADI;
            TBSatisOtv.Text = _tempStok.SATISOTV.ToString();
            TBSatisKdv.Text = _tempStok.SATISKDV.ToString();
            TBMarka.Text = _markaServis.obje.Where(x=>x.ID.ToString()==_tempStok.MARKAID.ToString()).FirstOrDefault().ADI.ToString();
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
            var a = _PocoStokServis.obje.Select(x=>x.MPSTOKOLCUBR.Select(z=>z));
            stokOlculist = _tempStok.MPSTOKOLCUBR.ToList();
            _tempStok = null;
        }

        private void TBStokKodu_Leave(object sender, EventArgs e)               // TBStokkodu doluyken stok kodu kontrolü yapıp tempstok doldurulur.
        {
            _PocoStokServis.Data(ServisList.StokListeServis);
            if (TBStokKodu.Text != "")
            {
                _tempStok = _PocoStokServis.obje.Where(x => x.KOD == TBStokKodu.Text).FirstOrDefault();
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
            CBOlcuBr1.DataSource = _tempPocoOLCUBR.Select(x => x.ADI).ToList();

        }
        private void BTKaydet_Click(object sender, EventArgs e)                 // Stok Kayıt
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
             _tempStok = new PocoSTOK()
            {
                ID = stokid,
                KOD = TBStokKodu.Text,
                ADI = TBStokAdı.Text,
                MARKAID = _markaServis.obje.Where(x => x.ADI == TBMarka.Text).FirstOrDefault().ID,
                KATEGORIID = _tempKategori.ID,
                KASAID = 1,//_tempKasa.ID,
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

             _PocoStokServis.Data(ServisList.StokEkleServis,_tempStok);
            var snc = _PocoStokServis.obje;
            _PocoStokServis.Data(ServisList.StokListeServis);
            _tempStok =_PocoStokServis.obje.Where(x => x.KOD == _tempStok.KOD).FirstOrDefault();
            foreach (var item in stokOlculist)
            {
                item.STOKID = _PocoStokServis.obje.Where(x=>x.KOD==TBStokKodu.Text).FirstOrDefault().ID; 
                _StokOlcuBrServis.Data(ServisList.StokOlcuBrEkleServis,item);
            }
            
            stokid = 0;
            if (snc!=null)
                MessageBox.Show("Kayıt Başarılı.");
            Temizle(this.Controls);
            TBStokKodu.Text = "";
            
            dataGridView1.DataSource = "";
        }
        private void BTSil_Click(object sender, EventArgs e)                  // Stok Sil
        {
            _PocoStokServis.Data(ServisList.StokSilServis,null,null,_PocoStokServis.obje.Where(x => x.ID == stokid).ToList());
            Temizle(this.Controls);
        }
        private void BTMarkaSec_Click(object sender, EventArgs e)
        {
            FMarkaList fMarkaKart = new FMarkaList();
            fMarkaKart.ShowDialog();
            if (_tempMarka != null)
            {
                markaid = _tempMarka.ID;
                TBMarka.Text = _tempMarka.ADI;
                _tempMarka = null;
            } 
        }

        private void BTKategoriSec_Click(object sender, EventArgs e)
        {
            FKategoriList fKategoriKart = new FKategoriList("Stok");
            fKategoriKart.ShowDialog();
            if (_tempKategori != null)
            TBKategori.Text = _tempKategori.Acıklama;
        }
        private void BTNKasaSec_Click(object sender, EventArgs e)
        {
            FKasaList fKasaList = new FKasaList("Stok");
            fKasaList.ShowDialog();
            if (_tempKasa!=null)
            TBKasa.Text = _tempKasa.KASAADI;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {
                num = 0;
            }
            _tempStokOlcuBr = new PocoSTOKOLCUBR()
            {
                OLCUBRID = _tempPocoOLCUBR.Where(x => x.ADI == CBOlcuBr1.SelectedValue.ToString()).FirstOrDefault().ID,
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