using MEYPAK.PRL.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using System.IO;
using MEYPAK.Interfaces.Stok;
using DevExpress.XtraEditors;

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
            stokOlculist = new List<PocoSTOKOLCUBR>();
            _stokResimServis = new GenericWebServis<PocoSTOKRESIM>();
            resimList = new List<PocoSTOKRESIM>();


        }
        #region Tanımlar
        PocoSTOKOLCUBR _tempStokOlcuBr;
        public PocoSTOK _tempStok;
        public PocoSTOKKATEGORI _tempKategori;
        public PocoSTOKMARKA _tempMarka;
        List<PocoSTOKRESIM> resimList;

        GenericWebServis<PocoSTOKRESIM> _stokResimServis;
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
                if (ctrl is TextEdit)
                {
                    if (ctrl.Name != "BTStokKodu")
                        ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
            TBAlisKdv.Text = "0";
            TBSatisKdv.Text = "0";
            TBSatisOtv.Text="0";
            TBAlisOtv.Text = "0";
            TBSFiyat1.Text = "0";
            TBSFiyat2.Text = "0";
            TBSFiyat3.Text = "0";
            TBSFiyat4.Text = "0";
            TBSFiyat5.Text = "0";
            TBAFiyat1.Text = "0";
            TBAFiyat2.Text = "0";
            TBAFiyat3.Text = "0";
            TBAFiyat4.Text = "0";
            TBAFiyat5.Text = "0";
            CBSDoviz.SelectedIndex = 0;
            CBADoviz.SelectedIndex = 0;

            
        }

        private void tbDoldur()                                                 // _tempStok nesnesi dolduğu zaman bu method ile formdaki nesneleri doldur
        {
           
            _stokResimServis.Data(ServisList.StokResimListeServis);
            _PocoStokServis.Data(ServisList.StokListeServis);
            _markaServis.Data(ServisList.StokMarkaListeServis);
            if (_tempStok != null)
            {
                stokid = _tempStok.id;
                BTStokKodu.Text = _tempStok.kod;
                resimList.Clear();
            }
            TBStokAdi.Text = _tempStok.adi;
            TBSatisOtv.Text = _tempStok.satisotv.ToString();
            TBSatisKdv.Text = _tempStok.satiskdv.ToString();
            BTMarka.Text = _markaServis.obje.Where(x=>x.id.ToString()==_tempStok.markaid.ToString()).FirstOrDefault().adi.ToString();
            TBSatisKdv.Text = _tempStok.kategoriid.ToString();
            BTGrupKodu.Text = _tempStok.grupkodu.ToString();
            TBAlisOtv.Text = _tempStok.alisotv.ToString();
            TBAlisKdv.Text = _tempStok.aliskdv.ToString();
            TBAciklama.Text = _tempStok.aciklama;
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

            if (_tempStok.id != null)
                foreach (var item in _stokResimServis.obje.Where(x => x.STOKID == stokid))
                {
                    resimList.Add(item);
                }
                
            gridControl2.DataSource= resimList.Select(x=> new { Resim = Base64ToImage(x.IMG) });
            gridControl1.DataSource = _StokOlcuBrServis.obje.Where(x=>x.stokid== stokid).Select(x=>_PocoOlcuBrServis.obje.Where(z=>z.id==x.olcubrid).FirstOrDefault().adi);
            gridControl1.Refresh();
            //var a = _PocoStokServis.obje.Select(x=>x.mpst.Select(z=>z));
            //stokOlculist = _tempStok.MPSTOKOLCUBR.ToList();
            _tempStok = null;
        }

        private void BTStokKodu_Leave(object sender, EventArgs e)               // BTStokKodu doluyken stok kodu kontrolü yapıp tempstok doldurulur.
        {
           
        }
        #endregion
        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
             
            _StokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            _PocoOlcuBrServis.Data(ServisList.OlcuBrListeServis);
            _tempPocoOLCUBR = _PocoOlcuBrServis.obje;
            _PocoSTOKOLCUBR = _StokOlcuBrServis.obje;
            CBBirim.Properties.DataSource = _tempPocoOLCUBR.Select(x => x.adi).ToList();
            
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

        }
        private void BTSil_Click(object sender, EventArgs e)                  // Stok Sil
        {
            _PocoStokServis.Data(ServisList.StokSilServis,null,null,_PocoStokServis.obje.Where(x => x.id == stokid).ToList());
            Temizle(this.Controls);
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
            FStokList fStokList = new FStokList(this.Tag.ToString(), "stokkart");
            fStokList.ShowDialog();
            if (_tempStok != null)
                if (_tempStok.id > 0) 
                    tbDoldur(); 
        }

        private void buttonEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FMarkaList fMarkaKart = new FMarkaList(this.Tag.ToString(), "stokkart");
            fMarkaKart.ShowDialog();
            if (_tempMarka != null)
            {
                markaid = _tempMarka.id;
                BTMarka.Text = _tempMarka.adi;
                _tempMarka = null;
            }
        }

        private void buttonEdit3_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FKategoriList fKategoriKart = new FKategoriList(this.Tag.ToString(), "stokkart");
            fKategoriKart.ShowDialog();
            if (_tempKategori != null)
                BTKategori.Text = _tempKategori.acıklama;
        }

        

  

        private void BTStokKartiKaydet_Click(object sender, EventArgs e)
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            _tempStok = new PocoSTOK()
            {
                id = stokid,
                kod = BTStokKodu.Text,
                adi = TBStokAdi.Text,
                markaid = _markaServis.obje.Where(x => x.adi == BTMarka.Text).FirstOrDefault().id,
                kategoriid = _tempKategori.id,
         
                grupkodu = BTGrupKodu.Text,
                aciklama = TBAciklama.Text,
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
                donem = DateTime.Now.ToString("yyyy"),


            };

            var snc = _PocoStokServis.obje;
            _PocoStokServis.Data(ServisList.StokEkleServis,_tempStok);
            _PocoStokServis.Data(ServisList.StokListeServis);
            _tempStok = _PocoStokServis.obje.Where(x => x.kod == _tempStok.kod).FirstOrDefault();
            foreach (var item in stokOlculist)
            {
                item.stokid = _PocoStokServis.obje.Where(x => x.kod == BTStokKodu.Text).FirstOrDefault().id;
                _StokOlcuBrServis.Data(ServisList.StokOlcuBrEkleServis, item);
            }
            foreach (var item in resimList)
            {
                item.STOKID= _PocoStokServis.obje.Where(x => x.kod == BTStokKodu.Text).FirstOrDefault().id;
                _stokResimServis.Data(ServisList.StokResimEkleServis, item);
            }
            stokid = 0;
            if (snc != null)
                MessageBox.Show("Kayıt Başarılı.");
            Temizle(this.Controls);
            BTStokKodu.Text = "";

            gridControl1.DataSource = "";
        }

        private void BTOlcuBirimiEkle_Click_1(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                num = 0;
            }
            _tempStokOlcuBr = new PocoSTOKOLCUBR()
            {
                olcubrid = _tempPocoOLCUBR.Where(x => x.adi == CBBirim.EditValue.ToString()).FirstOrDefault().id,
                num = gridView1.RowCount + 1,
                katsayi = Convert.ToDecimal(TBKatsayi.Text),


            };
            stokOlculist.Add(_tempStokOlcuBr);
            gridControl1.DataSource = stokOlculist;
            gridControl1.Refresh();
        }
        string base64 = "";
        private void buttonEdit1_Properties_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TümDosyalar |*.*|Jpeg Dosyası |*.jpeg| Jpg Dosyası|*.jpg| PNG Dosyası|*.png| ICO Dosyası|*.ico;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = ofd.FileName;
                    string DosyaAdi = ofd.SafeFileName;
                    buttonEdit1.Text = DosyaYolu;
                    pictureEdit1.Image = new Bitmap(DosyaYolu);
                    base64 =  ImageToBase64(DosyaYolu); 
                }
            }
        }
        public object base64resim; 
        public System.Drawing.Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                return image;
            }
            catch (Exception)
            {

                return null;
            }

        }
        string b64string="";
        public string ImageToBase64(string path)
        {
            try
            {
                using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();
                        b64string = Convert.ToBase64String(imageBytes);
                        return b64string;
                    }
                }
            }
            catch
            {
                return "";
            }
        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _stokResimServis.Data(ServisList.StokResimListeServis);
            if (_stokResimServis.obje.Where(x => x.STOKID == _PocoStokServis.obje.Where(z=>z.kod==BTStokKodu.Text).FirstOrDefault().id).Count() == 0) {
                resimList.Add( new PocoSTOKRESIM()
                {   
                    STOKID = _PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).FirstOrDefault().id,
                    NUM = 0,
                    IMG = base64,

                });
            }
            else
            {
                resimList.Add(new PocoSTOKRESIM()
                {
                    STOKID = _PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).FirstOrDefault().id,
                    NUM = _stokResimServis.obje.Where(x => x.STOKID == _PocoStokServis.obje.Where(z => z.kod == BTStokKodu.Text).FirstOrDefault().id).Last().NUM+1,
                    IMG = base64, 
                });
            }

            gridControl2.DataSource = resimList.Select(x => new { Resim= Base64ToImage(x.IMG) });
        }

      
       
        private void BTStokKodu_Leave_1(object sender, EventArgs e)
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
                    gridControl1.DataSource = "";
                    stokid = 0;
                }
            }
        }

        private void BTSil_Click_1(object sender, EventArgs e)
        {
            _PocoStokServis.Data(ServisList.StokSilServis);
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