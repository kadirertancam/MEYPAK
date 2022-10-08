using MEYPAK.BLL.PERSONEL;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Interfaces.Depo;

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelKart : Form
    {
        public FPersonelKart()
        {
            InitializeComponent();
        }
        #region Tanımlar
        int id = 0;
        public MPPERSONEL _tempPersonel;
        IPersonelServis _personelServis = new PersonelManager(new EFPersonelRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        int mdurum = 0;
        string base64String = "";
        FPersonelList fPersonelList;
        int PSD = 1, _tempPsd;
        #endregion
        #region EVENTS
        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            MTBTcKimlik.Select(0, 0);
            MTBTcKimlik.ScrollToCaret();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            #region RBCheck
            if (RBBekar.Checked)
                mdurum = 0;
            else if (RBEvli.Checked)
                mdurum = 1;
            else if (RBBosanmis.Checked)
                mdurum = 2;
            #endregion

            string hashresim = ImageToBase64(pictureBox1.Image);
            _personelServis.EkleyadaGuncelle(new Entity.Models.MPPERSONEL()
            {
                TC = MTBTcKimlik.Text,
                ADI = TBAdi.Text,
                SOYADI = TBSoyadi.Text,
                ADRES = TBAdres.Text,
                TEL = TBTelefon.Text,
                DOGUMTAR = DTPDogumTarihi.Value,
                EHLIYETNO = TBEhliyetNo.Text,
                ASKERLIK = TBAskerlik.Text,
                EMAIL = TBEposta.Text,
                GOREVI = CBGorevi.Text,
                DURUM = 0,
                ISBASTAR = DateTime.Now,
                KANGRUBU = TBKanGrubu.Text,
                MEDENIDURUM = mdurum,
                PSIKOTAR = DTPPsikoTeknik.Value,
                RESIM = hashresim,
                SCR = TBScr.Text,
                SGKSICIL = TBSgkSicilNo.Text,
                ISBITTAR = Convert.ToDateTime("01/01/1799")

            });
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            resimekle();
        }
        #endregion
        #region METHODS
        void Doldur()
        {
            if (_tempPersonel != null)
            {
                id = _tempPersonel.ID;
                TBAdi.Text = _tempPersonel.ADI;
                TBSoyadi.Text = _tempPersonel.SOYADI;
                TBTelefon.Text = _tempPersonel.TEL;
                MTBTcKimlik.Text = _tempPersonel.TC;
                TBScr.Text = _tempPersonel.SCR;
                TBKanGrubu.Text = _tempPersonel.KANGRUBU;
                TBEposta.Text = _tempPersonel.EMAIL;
                TBEhliyetNo.Text = _tempPersonel.EHLIYETNO;
                TBAskerlik.Text = _tempPersonel.ASKERLIK;
                TBAdres.Text = _tempPersonel.ADRES;
                pictureBox1.Image = Base64ToImage(_tempPersonel.RESIM);
                TBSgkSicilNo.Text = _tempPersonel.SGKSICIL;
                CBGorevi.SelectedIndex = CBGorevi.FindStringExact(_tempPersonel.GOREVI);
                LBPanelIseBaslamaTarihi.Text = _tempPersonel.ISBASTAR.Date.ToString("dd/MM/yyyy");
                _tempPsd = _tempPersonel.PSD;
                switch (_tempPersonel.MEDENIDURUM)
                {
                    case 0: RBBekar.Checked = true; break;
                    case 1: RBEvli.Checked = true; break;
                    case 2:
                        RBBosanmis.Checked = true; break;
                        break;
                }


                _tempPersonel = null;
            }
        }
        void resimekle()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RESİM DOSYASI|*.jpg*;*.png*;*.jpeg*";
            openFileDialog.ShowDialog();

            base64String = ImageToBase64(openFileDialog.FileName);
            pictureBox1.Image = Base64ToImage();

        }
        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (ctrl.Name != "MTBTcKimlik")
                        ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
        }

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
                        base64String = Convert.ToBase64String(imageBytes);
                        return base64String;
                    }
                }
            }
            catch
            {
                return "";
            }
        }
        public string ImageToBase64(Image _image)
        {
            try
            {


                using (System.Drawing.Image image = _image)
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        image.Save(m, image.RawFormat);
                        byte[] imageBytes = m.ToArray();
                        base64String = Convert.ToBase64String(imageBytes);
                        return base64String;
                    }
                }
            }
            catch
            {
                return "";
            }
        }
        public System.Drawing.Image Base64ToImage2(byte[] aa)
        {
            try
            {
                string result = Encoding.UTF8.GetString(aa);
                byte[] imageBytes = Convert.FromBase64String(result);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                System.Drawing.Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }
        public System.Drawing.Image Base64ToImage()
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return null;
            }

        }

        #endregion

        private void TBAdi_TextChanged(object sender, EventArgs e)
        {
            LBPanelAdi.Text = TBAdi.Text;
        }

        private void TBSoyadi_TextChanged(object sender, EventArgs e)
        {
            LBPanelSoyadi.Text = TBSoyadi.Text;
        }

        private void MTBTcKimlik_TextChanged(object sender, EventArgs e)
        {
            LBPanelTc.Text = MTBTcKimlik.Text;
        }

        private void CBGorevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBPanelGorevi.Text = CBGorevi.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            _personelServis.Sil(_personelServis.Getir(x => x.ID == _tempPersonel.ID));
        }

        private void BTPersonelSec_Click(object sender, EventArgs e)
        {
            fPersonelList = new FPersonelList();
            fPersonelList.ShowDialog();
            LBSigortasizPersonelKayit.Visible = false;
            PSD = 1;
            Doldur();
        }

        private void BTCikisIslemi_Click(object sender, EventArgs e)
        {
            if (PNCikis.Visible)
                PNCikis.Visible = false;
            else
                PNCikis.Visible = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F12))
            {
                if (PSD == 1)
                {
                    PSD = 0;
                    LBSigortasizPersonelKayit.Visible = true;
                    if (id != 0)
                    {
                        if (_tempPsd == 1)
                        {
                            LBSigortasizPersonelKayit.Text = "Sigortalı";
                            LBSigortasizPersonelKayit.ForeColor = Color.Green;
                        }
                        else
                        {

                            LBSigortasizPersonelKayit.Text = "Sigortasız";
                            LBSigortasizPersonelKayit.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    PSD = 1;
                    LBSigortasizPersonelKayit.Visible = false;
                    LBSigortasizPersonelKayit.Text = "Sigortasız Personel Kayıt";
                    LBSigortasizPersonelKayit.ForeColor = Color.Red;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MTBTcKimlik_Leave(object sender, EventArgs e)
        {
            if (MTBTcKimlik.Text != "")
            {
                string _temptc = MTBTcKimlik.Text.ToString();
                _tempPersonel = _personelServis.Getir(x => x.TC == _temptc).FirstOrDefault();
                if (_tempPersonel != null)
                    Doldur();
                else
                    Temizle(this.Controls);
            }
        }

        private void TBTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar!='+')
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                }
            
        }

        private void FPersonelKart_Load(object sender, EventArgs e)
        {

        }
    }
}
