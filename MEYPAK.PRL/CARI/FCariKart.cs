using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.STOK;
using Newtonsoft.Json;
using Ninject.Infrastructure.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        GenericWebServis<ADRESLIST> _adresListServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoCARIRESIM> _cariResimServis;
        FCariList _fCariList;
        FCariAltHesap fCariAltHesap;
      

        public PocoCARIKART _tempCariKart;
        public PocoCARIALTHES _tempCariAltHes;

        void doldur()
        {
            resimList.Clear(); 
            _cariResimServis.Data(ServisList.CariResimListeServis);
            TBAciklama.Text = _tempCariKart.aciklama;
            TBAciklama1.Text = _tempCariKart.aciklamA1;
            TBAciklama2.Text = _tempCariKart.aciklamA2;
            TBAciklama3.Text = _tempCariKart.aciklamA3;
            TBAciklama4.Text = _tempCariKart.aciklamA4;
            TBAciklama5.Text = _tempCariKart.aciklamA5;
            TBAciklama6.Text = _tempCariKart.aciklamA6;
            TBAciklama7.Text = _tempCariKart.aciklamA7;
            TBAciklama8.Text = _tempCariKart.aciklamA8;
            TBAciklama9.Text = _tempCariKart.aciklamA9;
            TBCariAdi.Text = _tempCariKart.adi;
            TBCariSoyad.Text = _tempCariKart.soyadi;
            TBAdres.Text = _tempCariKart.adres;
            BTAMuhSec.Text = _tempCariKart.amuhkod;
            TBApt.Text = _tempCariKart.apt;
            TBCepTel.Text = _tempCariKart.ceptel;
            TBDaire.Text = _tempCariKart.daire;
            TBEposta.Text = _tempCariKart.eposta;
            TBFax.Text = _tempCariKart.fax;
            BTGrupSec.Text = _tempCariKart.grupkodu;
            CBIl.Text = _tempCariKart.il;
            CBIlce.Text = _tempCariKart.ilce;
            BTKategoriSec.Text = _tempCariKart.kategori;
            BTCariSec.Text = _tempCariKart.kod;
            TBMahalle.Text = _tempCariKart.mahalle;
            BTMuhSec.Text = _tempCariKart.muH_KOD;
            TBPostaKod.Text = _tempCariKart.postakod;
            TBRaporKodu1.Text = _tempCariKart.raporkoD1;
            TBRaporKodu2.Text = _tempCariKart.raporkoD2;
            TBRaporKodu3.Text = _tempCariKart.raporkoD3;
            TBRaporKodu4.Text = _tempCariKart.raporkoD4;
            TBRaporKodu5.Text = _tempCariKart.raporkoD5;
            TBRaporKodu6.Text = _tempCariKart.raporkoD6;
            TBRaporKodu7.Text = _tempCariKart.raporkoD7;
            TBRaporKodu8.Text = _tempCariKart.raporkoD8;
            TBRaporKodu9.Text = _tempCariKart.raporkoD9;
            NUDSAciklama1.Value = _tempCariKart.saciklamA1;
            NUDSAciklama2.Value  = _tempCariKart.saciklamA2;
            NUDSAciklama3.Value  = _tempCariKart.saciklamA3;
            NUDSAciklama4.Value  = _tempCariKart.saciklamA4;
            NUDSAciklama5.Value  = _tempCariKart.saciklamA5;
            NUDSAciklama6.Value  = _tempCariKart.saciklamA6;
            NUDSAciklama7.Value  = _tempCariKart.saciklamA7;
            NUDSAciklama8.Value  = _tempCariKart.saciklamA8;
            NUDSAciklama9.Value  = _tempCariKart.saciklamA9;
            BTSMuhSec.Text = _tempCariKart.smuhkod;
            BTAMuhSec.Text = _tempCariKart.amuhkod; 
            TBSokak.Text = _tempCariKart.sokak;
            TBTcNo.Text = _tempCariKart.tcno;
            TBTelefon1.Text = _tempCariKart.telefon;
            TBTelefon2.Text = _tempCariKart.telefoN2;
            CBTip.SelectedIndex = _tempCariKart.tipi;
            TBUnvan.Text = _tempCariKart.unvan;
            TBVadeGun.Text = _tempCariKart.vadegunu.ToString();
            CBVDaire.Text = _tempCariKart.vergidairesi;
            TBVergiNo.Text = _tempCariKart.vergino;
            TBWebSite.Text = _tempCariKart.web;
            if (_tempCariKart.id != null)
                foreach (var item in _cariResimServis.obje.Where(x => x.CARIID == _tempCariKart.id))
                {
                    resimList.Add(item);
                }
            gridControl3.DataSource = resimList.Where(x=>x.CARIID==_tempCariKart.id).Select(x => new { CResim = Base64ToImage(x.IMG) });
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

        private void CBIl_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private void button7_Click(object sender, EventArgs e)
        {

            _cariServis.Data(ServisList.CariSilServis, null, null);
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
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
                raporkoD1 = TBRaporKodu1.Text,
                raporkoD2 = TBRaporKodu2.Text,
                raporkoD3 = TBRaporKodu3.Text,
                raporkoD4 = TBRaporKodu4.Text,
                raporkoD5 = TBRaporKodu5.Text,
                raporkoD6 = TBRaporKodu6.Text,
                raporkoD7 = TBRaporKodu7.Text,
                raporkoD8 = TBRaporKodu8.Text,
                raporkoD9 = TBRaporKodu9.Text,
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

        private void BTKoduSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                //_tempCariAltHes = null;
                //fCariAltHesap = this.Tag.ToString()
                //fStokList.ShowDialog();

                //Doldur();
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
        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void CBIl_TextChanged_1(object sender, EventArgs e)
        {
            CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBIl.Text).Select(x => x.ilceler.Select(z => z.ilce_adi)).FirstOrDefault();
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                _fCariList = new FCariList(this.Tag.ToString(), "carikart");
                _fCariList.ShowDialog();
                if (_tempCariKart != null)
                    doldur();
            }
        }
    }
}
