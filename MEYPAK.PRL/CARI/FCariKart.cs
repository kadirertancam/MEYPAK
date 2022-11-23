using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.PRL.STOK;
using Newtonsoft.Json;
using System;
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
            _cariStOKKATEGORI = new GenericWebServis<PocoSTOKKATEGORI>();
            _sevkAdresServis = new GenericWebServis<PocoSEVKADRES>();
            _cariAltHesList = new List<PocoCARIALTHES>();
            _cariYetkiliServis = new GenericWebServis<PocoCARIYETKILI>();
            _cariDokumanServis = new GenericWebServis<PocoCARIDOKUMAN>();
            CBAltHesap.Properties.DataSource = _cariAltHesapServis.obje.Select(x => x.adi).ToList();
            

        }
        #region Tanımlar
        GenericWebServis<ADRESLIST> _adresListServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoSEVKADRES> _sevkAdresServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _cariParABIRIM;
        GenericWebServis<PocoCARIRESIM> _cariResimServis;
        GenericWebServis<PocoSTOKKATEGORI> _cariStOKKATEGORI;
        GenericWebServis<PocoCARIYETKILI> _cariYetkiliServis;
        GenericWebServis<PocoCARIDOKUMAN> _cariDokumanServis;
        FCariList fCariList;
        FKategoriList fKategoriList;
        List<PocoCARIALTHES> _cariAltHesList;
        public PocoCARIALTHES _tempCARIALTHES;
        public PocoCARIKART _tempCariKart;
        public PocoPARABIRIM _tempCariParABIRIM;
        public PocoSTOKKATEGORI _tempCariStOKKATEGORI;
       
        int cariid = 0;
        public int _id;
        #endregion

        #region Metotlar

        void FormuTemizle()
        {
            foreach (var ctrl in panelControl8.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in panelControl13.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in panelControl16.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in groupBox1.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in groupBox2.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in groupBox4.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in panelControl16.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }


        }
        void Doldur()
        {
            _cariAltHesList.Clear();
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
            CBTip.Text = _tempCariKart.tipi.ToString();
            TBAciklama.Text = _tempCariKart.aciklama;
          //  CBAltHesap.EditValue = _tempCARIALTHES.adi;
            //TBSevkKodu
            CBSevkIl.Text = _tempCariKart.il;
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
        UlkeList.Root _ulkeList;

        public void FCariKart_Load(object sender, EventArgs e)
        {
            //Il combosu
            string path = Application.StartupPath + "/il-ilce.json";
           
            using (FileStream s = File.Open(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {
                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());
                }
            CBIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
            CBSevkIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
            //Ulke Combosu
            path = Application.StartupPath + "ulkeler.json";
            using (FileStream s = File.Open(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {
                    _ulkeList = JsonConvert.DeserializeObject<UlkeList.Root>(sr.ReadToEnd());
                }
            CBUlke.Properties.DataSource = _ulkeList.Ulke.Select(x => x.ulkeadi);
        }

        //Sevk Adres
        private void BTSevkAdresKaydet_Click(object sender, EventArgs e)
        {
            _sevkAdresServis.Data(ServisList.SevkAdresEkleServis, new PocoSEVKADRES()
            {
                althesapid = _cariAltHesapServis.obje.Where(x => x.adi == CBAltHesap.EditValue).FirstOrDefault().id,
                kodu = TBSevkKodu.Text,
                il = CBSevkIl.EditValue.ToString(),
                ilce = CBSevkIlce.EditValue.ToString(),
                mahalle = TBSevkMahalle.Text,
                sokak = TBSevkSokak.Text,
                apartman = TBSevkApt.Text,
                daire=TBSevkDaire.Text
            }) ;
            FormuTemizle();
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

        //Resim Seç Button
        private void BTResimKaydet_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
            _cariResimServis.Data(ServisList.StokResimListeServis);
            if (_cariResimServis.obje.Where(x => x.CARIID == _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id).Count() == 0)
            {
                _cariResimServis.Data(ServisList.CariResimEkleServis, new PocoCARIRESIM()
                {
                    CARIID = _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id,
                    NUM = 0,
                    IMG = base64,
                });
                base64 = "";
            }
            else
            {
                _cariResimServis.Data(ServisList.CariResimEkleServis, new PocoCARIRESIM()
                {
                    CARIID = _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id,
                    NUM = 0,
                    IMG = base64,
                });
            }
            _cariResimServis.Data(ServisList.StokResimListeServis);
            resimList = _cariResimServis.obje.Where(x => x.CARIID == _cariServis.obje.Where(z => z.kod == BTCariSec.Text).FirstOrDefault().id).ToList();
            gridControl3.DataSource = resimList.Select(x => new { Resim = Base64ToImage(x.IMG) });
        }
        
        string base64 = "";
        private void BTResimSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "SEÇ")
          
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

        //Ülke Seç
        private void CBUlke_Properties_EditValueChanged(object sender, EventArgs e)
        {
         //   CBUlke.Properties.DataSource = _adresObje.data.Where(x => x.ulke_adi == CBUlke.EditValue.ToString()).Select(x => x.il_adi.ToList()).FirstOrDefault();

        }
 
        private void BTSil_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
          //  _cariServis.Data(ServisList.CariSilServis, null, null, _cariServis.obje.Where(x => x.id.ToString()
            MessageBox.Show("Silme Başarılı");
           
        }

        //Kategori Seç
        private void BTKategoriSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            fKategoriList = new FKategoriList(this.Tag.ToString(), "kategorilist");
            fKategoriList.ShowDialog();
            Doldur();
        }

        //private void CBNufIl_EditValueChanged(object sender, EventArgs e)
        //{
        //    CBNufIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBNufIl.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        //}

        private void CBSevkIl_Properties_EditValueChanged(object sender, EventArgs e)
        {
            CBSevkIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBSevkIl.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }
        //Sevk İl
        private void CBIl_Properties_EditValueChanged(object sender, EventArgs e)
        {
            CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBIl.EditValue.ToString()).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariEkleServis, new PocoCARIKART()
            {
                id = cariid,
                kod = BTCariSec.Text,
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
                ulke = CBUlke.Text,
                il = CBIl.Text,
                ilce = CBIl.Text,
                kategori = BTKategoriSec.Text,
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
                //tipi = CBTip.Text,
                unvan = TBUnvan.Text,
                vadegunu = int.Parse(TBVadeGun.Text),
                vergidairesi = CBVDaire.Text,
                vergino = TBVergiNo.Text,
                web = TBWebSite.Text,

            }) ;
           
            MessageBox.Show("Kayıt işlemi Başarılı!");
            FormuTemizle();
            foreach (var item in resimList)
            {
                item.CARIID = _cariServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id;
                _cariResimServis.Data(ServisList.CariResimEkleServis, item);
            }
            
        }

        private void BTAltHesapKaydet_Click(object sender, EventArgs e)
        {
            _cariAltHesList.Add(_tempCARIALTHES);
            DGAltHesap.DataSource = _cariAltHesList.Select(x=> new {ALTHESAPADI=x.adi,PARABIRIMI=_cariParABIRIM.obje.Where(z=>z.id==x.dovizid).FirstOrDefault().kisaadi,AKTIF=x.aktif});
            DGAltHesap.RefreshDataSource();
        } //TO DO

        //Yetkili Alanı
        private void BTYetkiliKaydet_Click(object sender, EventArgs e)
        {
            if(_tempCariKart != null)
            {
                _cariYetkiliServis.Data(ServisList.CariYetkiliEkleServis, new PocoCARIYETKILI()
                {
                    cariid = _tempCariKart.id,
                    adi = TBYetkiliAdi.Text,
                    yetkilitelefon = TBYetkiliTel.Text,
                    pozisyon = TBPozisyon.Text,
                   
                });
                MessageBox.Show("Yetkili Başarıyla Eklendi!");
                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Öncelikle Cari Seçimi yapmanız gerekmektedir!");
            }
        }
        private void BTYetkiliSil_Click(object sender, EventArgs e) //TO DO 
        {
         
           
        }

        //Cari Seç Buttonu
        private void BTCariSec_Properties_Click(object sender, EventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "carikart");
            fCariList.ShowDialog();
            if (_tempCariKart != null)
            {
                
                BTCariSec.Text = _tempCariKart.kod;
                TBUnvan.Text = _tempCariKart.unvan;
                CBUlke.EditValue = _tempCariKart.ulke;
                CBIl.EditValue = _tempCariKart.il;
                CBIlce.EditValue = _tempCariKart.ilce;
                TBMahalle.Text = _tempCariKart.mahalle;
                TBSokak.Text = _tempCariKart.sokak;
                TBApt.Text = _tempCariKart.apt;
                TBDaire.Text = _tempCariKart.daire;
                TBPostaKod.Text = _tempCariKart.postakod;
                CBVDaire.EditValue = _tempCariKart.vergidairesi;
                TBVergiNo.Text = _tempCariKart.vergino;
                TBTcNo.Text = _tempCariKart.tcno;
                TBVadeGun.Text = _tempCariKart.vadegunu.ToString();
                RGFiyat.EditValue = _tempCariKart.fiyatnum;
                BTMuhSec.EditValue = _tempCariKart.muH_KOD;
                TBTelefon1.Text = _tempCariKart.telefon;
                TBTelefon2.Text = _tempCariKart.telefoN2;
                TBCepTel.Text = _tempCariKart.ceptel;
                TBFax.Text = _tempCariKart.fax;
                TBWebSite.Text = _tempCariKart.web;
                TBEposta.Text = _tempCariKart.eposta;
                TBAdres.Text = _tempCariKart.adres;
                BTGrupSec.EditValue = _tempCariKart.grupkodu;
                BTKategoriSec.EditValue = _tempCariKart.kategori;
                CBAktif.EditValue = CheckState.Checked;
                BTAMuhSec.EditValue = _tempCariKart.amuhkod;
                BTSMuhSec.EditValue = _tempCariKart.smuhkod;
                TBCariAdi.Text = _tempCariKart.adi;
                TBCariSoyad.Text = _tempCariKart.soyadi;
                CBTip.EditValue = _tempCariKart.tipi;
                TBAciklama.Text = _tempCariKart.aciklama;
                TBAciklama1.Text = _tempCariKart.aciklamA1;
                TBAciklama2.Text = _tempCariKart.aciklamA2;
                TBAciklama3.Text = _tempCariKart.aciklamA3;
                TBAciklama4.Text = _tempCariKart.aciklamA4;
                TBAciklama5.Text = _tempCariKart.aciklamA5;
                TBAciklama6.Text = _tempCariKart.aciklamA6;
                TBAciklama7.Text = _tempCariKart.aciklamA7;
                TBAciklama8.Text = _tempCariKart.aciklamA9;
                //Yetkili Grid Doldurur
                _cariYetkiliServis.Data(ServisList.CariYetkiliListeServis);
                DGYetkiliBilgi.DataSource = _cariYetkiliServis.obje.Where(x=> x.cariid == _tempCariKart.id).Select(x => new 
                {
                    ID=x.id,
                    ADI=x.adi,
                    TELEFON =x.yetkilitelefon,
                    POZISYON=x.pozisyon});

            }
        }

        //Döküman Seç
        private void BTDosyaYoluSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "SEÇ")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TümDosyalar |*.*|Jpeg Dosyası |*.jpeg| Jpg Dosyası|*.jpg| PNG Dosyası|*.png| ICO Dosyası|*.ico";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = ofd.FileName;
                    string DosyaAdi = ofd.SafeFileName;
                    BTDosyaYoluSec.Text = DosyaYolu;
                    //pictureEdit1.Image = new Bitmap(DosyaYolu);
                    //base64 = ImageToBase64(DosyaYolu);
                }
            }
        }

        private void BTDokumanKaydet_Click(object sender, EventArgs e) //TO DO
        {
            if (_tempCariKart!=null)
            {
            _cariDokumanServis.Data(ServisList.CariDokumanEkleServis, new PocoCARIDOKUMAN()
            {
                  cariid = _tempCariKart.id,
                  adi = TBDokumanAdi.Text,
                  dokuman = BTDosyaYoluSec.Text,
            });
            MessageBox.Show("Kayıt Başarıyla Eklendi!");
            FormuTemizle();
            }
            else
            {
                MessageBox.Show("Öncelikle Cari Seçimi yapmanız gerekmektedir!");
            }
        }

    }
    }
    #endregion
