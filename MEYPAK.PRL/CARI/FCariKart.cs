using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using Newtonsoft.Json;
using System.Data;
using System.IO;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariKart : XtraForm
    {
        int i = 0;
        public FCariKart()
        {
            InitializeComponent();
            _adresListServis = new GenericWebServis<ADRESLIST>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            _cariResimServis = new GenericWebServis<PocoCARIRESIM>();
            resimList = new List<PocoCARIRESIM>();
            _cariParABIRIM = new GenericWebServis<PocoPARABIRIM>();
            _cariParABIRIM.Data(ServisList.ParaBirimiListeServis);
        }
        #region Tanımlar
        GenericWebServis<ADRESLIST> _adresListServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _cariParABIRIM;
        GenericWebServis<PocoCARIRESIM> _cariResimServis;
        FCariList fCariList;

        public PocoCARIALTHES _tempCARIALTHES;
        public PocoCARIKART _tempCariKart;
        public PocoPARABIRIM _tempCariParABIRIM;

        #endregion

        #region Metotlar
        void Doldur()
        {
            BTCariSec.Text = _tempCariKart.kod;
            TBUnvan.Text = _tempCariKart.unvan;
            CBUlke.Text = _tempCariKart.ulke;
            CBIl.Text = _tempCariKart.il;
            CBIlce.Text = _tempCariKart.ilce;
            TBMahalle.Text = _tempCariKart.mahalle;
            TBSokak.Text = _tempCariKart.sokak;
            TBApt.Text = _tempCariKart.apt;
            TBDaire.Text = _tempCariKart.daire;
            TBPostaKod.Text = _tempCariKart.postakod;
            CBVDaire.EditValue = _tempCariKart.vergidairesi;
            TBVergiNo.Text = _tempCariKart.vergino;
            TBTcNo.Text = _tempCariKart.tcno;
            TBVadeGun.Text = _tempCariKart.vadegunu.ToString();
            BTMuhSec.Text = _tempCariKart.muH_KOD;
            TBTelefon1.Text = _tempCariKart.telefon;
            TBTelefon2.Text = _tempCariKart.telefoN2;
            TBCepTel.Text = _tempCariKart.ceptel;
            TBFax.Text = _tempCariKart.fax;
            TBWebSite.Text = _tempCariKart.web;
            TBEposta.Text = _tempCariKart.eposta;
            TBAdres.Text = _tempCariKart.adres;
            BTGrupSec.Text = _tempCariKart.grupkodu;
            BTKategoriSec.Text = _tempCariKart.kategori;
            //CBAktif.Text =
            BTAMuhSec.Text = _tempCariKart.amuhkod;
            BTSMuhSec.Text = _tempCariKart.smuhkod;
            TBCariAdi.Text = _tempCariKart.adi;
            TBCariSoyad.Text = _tempCariKart.soyadi;
            CBTip.SelectedIndex = _tempCariKart.tipi;
            TBAciklama.Text = _tempCariKart.aciklama;
            CBAltHesap.EditValue = _tempCARIALTHES.adi;
            //TBSevkKodu
            CBSevkIl.EditValue = _tempCariKart.il;
            CBSevkIlce.EditValue = _tempCariKart.ilce;
            TBSevkMahalle.Text = _tempCariKart.mahalle;
            TBSevkSokak.Text = _tempCariKart.sokak;
            TBSevkApt.Text = _tempCariKart.apt; 
            TBSevkDaire.Text = _tempCariKart.daire; 
            TBAciklama1.Text = _tempCariKart.aciklamA1;
            TBAciklama2.Text = _tempCariKart.aciklamA2;
            TBAciklama3.Text = _tempCariKart.aciklamA3;
            TBAciklama4.Text = _tempCariKart.aciklamA4;
            TBAciklama5.Text = _tempCariKart.aciklamA5;
            TBAciklama6.Text = _tempCariKart.aciklamA6;
            TBAciklama7.Text = _tempCariKart.aciklamA7;
            TBAciklama8.Text = _tempCariKart.aciklamA8;
            TBAciklama9.Text = _tempCariKart.aciklamA9;
            NUDSAciklama1.Value = _tempCariKart.saciklamA1;
            NUDSAciklama2.Value = _tempCariKart.saciklamA2;
            NUDSAciklama3.Value = _tempCariKart.saciklamA3;
            NUDSAciklama4.Value = _tempCariKart.saciklamA4;
            NUDSAciklama5.Value = _tempCariKart.saciklamA5;
            NUDSAciklama6.Value = _tempCariKart.saciklamA6;
            NUDSAciklama7.Value = _tempCariKart.saciklamA7;
            NUDSAciklama8.Value = _tempCariKart.saciklamA8;
            NUDSAciklama9.Value = _tempCariKart.saciklamA9;
            BTRprSec1.EditValue = _tempCariKart.raporkoD1;
            BTRprSec2.EditValue = _tempCariKart.raporkoD2;
            BTRprSec3.EditValue = _tempCariKart.raporkoD3;
            BTRprSec4.EditValue = _tempCariKart.raporkoD4;
            BTRprSec5.EditValue = _tempCariKart.raporkoD5;
            BTRprSec6.EditValue = _tempCariKart.raporkoD6;
            BTRprSec7.EditValue = _tempCariKart.raporkoD7;
            BTRprSec8.EditValue = _tempCariKart.raporkoD8;
            BTRprSec9.EditValue = _tempCariKart.raporkoD9;
            //TBYetkiliAdi = 
            //TBPozisyon = 
            //TBDokumanAdi.Text = 
            //BTDosyaYoluSec
            resimList.Clear();
            _cariResimServis.Data(ServisList.CariResimListeServis);
            AltCariDoldur();
            if (_tempCariKart.id != null)
                foreach (var item in _cariResimServis.obje.Where(x => x.CARIID == _tempCariKart.id))
                {
                    resimList.Add(item);
                }
            gridControl3.DataSource = resimList.Where(x => x.CARIID == _tempCariKart.id).Select(x => new { CResim = Base64ToImage(x.IMG) });
        }
        void AltCariDoldur()
        {
            if (_tempCARIALTHES != null)
            {
                if (_tempCARIALTHES.id > 0)
                {
                    TBAltHesapAdi.Text = _tempCARIALTHES.adi.ToString();
                    BTAltHesSec.Text = _tempCARIALTHES.kod.ToString();
                }
            }
        }


        ADRESOBJECT.Root _adresObje;
        public void FCariKart_Load(object sender, EventArgs e)
        {

            string path = Application.StartupPath + "/il-ilce.json";
           
            using (FileStream s = File.Open(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {

                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());

                    
                    CBIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);

                }


        }



        private void button7_Click(object sender, EventArgs e)
        {

            _cariServis.Data(ServisList.CariSilServis, null, null);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //   _fCariList = new FCariList(this.Tag.ToString(), "carikart");
            //_fCariList.ShowDialog();
            //if (_tempCariKart != null)
            //    Doldur();
        }


        private void BTSevkAdresKaydet_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariEkleServis, new PocoCARIKART()
            {
                aciklama = TBAciklama.Text,
                aciklamA1 = TBAciklama1.Text,
                aciklamA2 = TBAciklama2.Text,
                aciklamA3 = TBAciklama3.Text,
                aciklamA4 = TBAciklama4.Text,
                aciklamA5 = TBAciklama5.Text,
                aciklamA6 = TBAciklama6.Text,
                aciklamA7 = TBAciklama7.Text,
                aciklamA8 = TBAciklama8.Text,
                aciklamA9 = TBAciklama9.Text,
                adi = TBCariAdi.Text,
                soyadi = TBCariSoyad.Text,
                adres = TBAdres.Text,
                amuhkod = BTAMuhSec.Text,
                apt = TBApt.Text,
                ceptel = TBCepTel.Text,
                daire = TBDaire.Text,
                eposta = TBEposta.Text,
                fax = TBFax.Text,
                grupkodu = BTGrupSec.Text,
                il = CBIl.Text,
                ilce = CBIl.Text,
                kategori = BTKategoriSec.Text,
                kod = BTCariSec.Text,
                mahalle = TBMahalle.Text,
                muH_KOD = BTMuhSec.Text,
                postakod = TBPostaKod.Text,
                raporkoD1 = BTRprSec1.Text,
                raporkoD2 = BTRprSec2.Text,
                raporkoD3 = BTRprSec3.Text,
                raporkoD4 = BTRprSec4.Text,
                raporkoD5 = BTRprSec5.Text,
                raporkoD6 = BTRprSec6.Text,
                raporkoD7 = BTRprSec7.Text,
                raporkoD8 = BTRprSec8.Text,
                raporkoD9 = BTRprSec9.Text,
                saciklamA1 = int.Parse(NUDSAciklama1.Value.ToString()),
                saciklamA2 = int.Parse(NUDSAciklama2.Value.ToString()),
                saciklamA3 = int.Parse(NUDSAciklama3.Value.ToString()),
                saciklamA4 = int.Parse(NUDSAciklama4.Value.ToString()),
                saciklamA5 = int.Parse(NUDSAciklama5.Value.ToString()),
                saciklamA6 = int.Parse(NUDSAciklama6.Value.ToString()),
                saciklamA7 = int.Parse(NUDSAciklama7.Value.ToString()),
                saciklamA8 = int.Parse(NUDSAciklama8.Value.ToString()),
                saciklamA9 = int.Parse(NUDSAciklama9.Value.ToString()),
                smuhkod = BTSMuhSec.Text,
                sokak = TBSokak.Text,
                tcno = TBTcNo.Text,
                telefon = TBTelefon1.Text,
                telefoN2 = TBTelefon2.Text,
                tipi = CBTip.SelectedIndex,
                unvan = TBUnvan.Text,
                vadegunu = int.Parse(TBVadeGun.Text),
                vergidairesi = CBVDaire.Text,
                vergino = TBVergiNo.Text,
                web = TBWebSite.Text,

            });
            foreach (var item in resimList)
            {
                item.CARIID = _cariServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id;
                _cariResimServis.Data(ServisList.CariResimEkleServis, item);
            }

        }

        //Cari Alt Hesap
        public void BTAltHesSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Caption == "Yeni")
            {

                XtraTabPage page = new XtraTabPage();
                FCariAltHesap fCariAltHesap = new FCariAltHesap();
                Main main = (Main)Application.OpenForms["Main"]; //main e erişmek
                page.Name = "TPAltHesap";
                page.Text = "Alt Hesap";
                page.Tag = "TPAltHesapPanel";

                page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                main.xtraTabControl1.TabPages.Add(page);
                main.xtraTabControl1.SelectedTabPage = page;

                fCariAltHesap.TopLevel = false;
                fCariAltHesap.AutoScroll = true;
                fCariAltHesap.Dock = DockStyle.Top;
                //fCariAltHesap.Tag = "TPAltHesapPanel";
                page.Controls.Add(fCariAltHesap);
                fCariAltHesap.Show();
                i++;

            }
            else if (e.Button.Caption == "Seç")
            {
                FAltHesapList fAltHesapList = new FAltHesapList(this.Tag.ToString(), "carikart");
                fAltHesapList.ShowDialog();

                AltCariDoldur();

            }
        }
       
        private void simpleButton13_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
            _cariResimServis.Data(ServisList.StokResimListeServis);
            if (_cariResimServis.obje.Where(x => x.CARIID == _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id).Count() == 0)
            {
                resimList.Add(new PocoCARIRESIM()
                {
                    CARIID = _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id,
                    NUM = 0,
                    IMG = base64,

                });
            }
            else
            {
                resimList.Add(new PocoCARIRESIM()
                {
                    CARIID = _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id,
                    NUM = _cariResimServis.obje.Where(x => x.CARIID == _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id).Last().NUM + 1,
                    IMG = base64,
                });
            }

            gridControl3.DataSource = resimList.Select(x => new { Resim = Base64ToImage(x.IMG) });
        }
        string base64 = "";
        private void BTResimSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TümDosyalar |*.*|Jpeg Dosyası |*.jpeg| Jpg Dosyası|*.jpg| PNG Dosyası|*.png| ICO Dosyası|*.ico;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = ofd.FileName;
                    string DosyaAdi = ofd.SafeFileName;
                    BTResimSec.Text = DosyaYolu;
                    pictureEdit1.Image = new Bitmap(DosyaYolu);
                    base64 = ImageToBase64(DosyaYolu);
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
        string b64string = "";
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
        List<PocoCARIRESIM> resimList;

        //private void CBIl_TextChanged_1(object sender, EventArgs e)
        //{
        //    CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBIl.Text).Select(x => x.ilceler.Select(z => z.ilce_adi)).FirstOrDefault();
        //}

        #endregion

      
        private void CBUlke_Properties_EditValueChanged(object sender, EventArgs e)
        private void CBIl_TextChanged(object sender, EventArgs e)
        {
            CBUlke.Properties.DataSource = _adresObje.data.Where(x => x.ulke_adi == CBUlke.EditValue.ToString()).Select(x => x.il_adi.ToList()).FirstOrDefault();
            CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBIl.Text).Select(x => x.ilceler.Select(z => z.ilce_adi)).FirstOrDefault();

        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            fCariList = new FCariList(this.Tag.ToString(), "carikart");
            fCariList.ShowDialog();
            doldur();
        }
    }

}