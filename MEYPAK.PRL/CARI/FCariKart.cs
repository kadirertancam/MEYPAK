using DevExpress.CodeParser;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.STOK;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Net.Http;

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
            _sevkAdresServis = new GenericWebServis<PocoSEVKADRES>();
            _cariAltHesList = new List<PocoCARIALTHES>();
            _cariYetkiliServis = new GenericWebServis<PocoCARIYETKILI>();
            _cariDokumanServis = new GenericWebServis<PocoCARIDOKUMAN>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
            _cariHareketServis = new GenericWebServis<PocoCARIHAR>();
            CBAltHesap.Properties.ValueMember = "ID";
            CBAltHesap.Properties.DisplayMember = "ADI";


        }
        #region Tanımlar
        GenericWebServis<ADRESLIST> _adresListServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoSEVKADRES> _sevkAdresServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _cariParABIRIM;
        GenericWebServis<PocoCARIRESIM> _cariResimServis;
        GenericWebServis<PocoCARIYETKILI> _cariYetkiliServis;
        GenericWebServis<PocoCARIDOKUMAN> _cariDokumanServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoCARIHAR> _cariHareketServis;
        FCariList fCariList;
        FKategoriList fKategoriList;
        List<PocoCARIALTHES> _cariAltHesList;
        List<PocoSEVKADRES> _sevkadreslist;
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
            DGSevkAdres.DataSource = "";
            DGAltHesap.DataSource = "";
            DGYetkiliBilgi.DataSource = "";


        }
        void Doldur()
        {
            if (_tempCariKart != null)
            {
                _cariAltHesList.Clear();
                BTCariSec.Text = _tempCariKart.kod;
                TBUnvan.Text = _tempCariKart.unvan;
                CBUlke.EditValue = _tempCariKart.ulke;
                CBIl.EditValue = _tempCariKart.il;
                // CBIlce.EditValue = _tempCariKart.ilce;
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
                BTAMuhSec.Text = _tempCariKart.amuhkod;
                BTSMuhSec.Text = _tempCariKart.smuhkod;
                TBCariAdi.Text = _tempCariKart.adi;
                TBCariSoyad.Text = _tempCariKart.soyadi;
                CBTip.SelectedIndex = _tempCariKart.tipi;
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

                _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);

                if (_cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id).Count() > 0)
                {
                    DGAltHesap.DataSource = _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id).Select(x => new { ALTHESAPKODU = _cariAltHesapServis.obje.Where(z => z.id == x.carialthesid).FirstOrDefault().kod, ALTHESAPADI = _cariAltHesapServis.obje.Where(z => z.id == x.carialthesid).FirstOrDefault().adi, PARABIRIMI = _cariParABIRIM.obje.Where(z => z.id == _cariAltHesapServis.obje.Where(y => y.id == x.carialthesid).FirstOrDefault().dovizid).FirstOrDefault().kisaadi, AKTIF = x.aktif });
                    CBAltHesap.Properties.DataSource = _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id).Select(x => new { ADI = _cariAltHesapServis.obje.Where(z => z.id == x.carialthesid).FirstOrDefault().adi, ID = _cariAltHesapServis.obje.Where(z => z.id == x.carialthesid).FirstOrDefault().id });
                }
                else
                    DGAltHesap.DataSource = "";

                //   _cariAltHesapServis.obje.Where(x=> x.id == _ car).ToList();

                if (_tempCariKart.id != null)
                    foreach (var item in _cariResimServis.obje.Where(x => x.CARIID == _tempCariKart.id))
                    {
                        resimList.Add(item);
                    }
                gridControl3.DataSource = resimList.Where(x => x.CARIID == _tempCariKart.id).Select(x => new { CResim = Base64ToImage(x.IMG) });
                SevkAdresDoldur();
                YetkiliBilgileriDoldur();
            }
        }
        void AltCariDoldur()
        {

            if (_tempCARIALTHES != null)
            {
                if (_tempCARIALTHES.id > 0)
                {
                    TBAltHesapAdi.Text = _tempCARIALTHES.adi.ToString();
                    BTAltHesSec.Text = _tempCARIALTHES.kod.ToString();
                    CBAktif.EditValue = 1;
                }
            }
        }


        ADRESOBJECT.Root _adresObje;
        UlkeList.Root _ulkeList;
        private static Stream GetStreamFromUrl(string url)
        {
            byte[] imageData = null;

            using (var wc = new System.Net.WebClient())
                imageData = wc.DownloadData(url);

            return new MemoryStream(imageData);
        }
        public void FCariKart_Load(object sender, EventArgs e)
        {
            //Il combosu

            string url = @"http://213.238.167.117:8081/il-ilce.json";
            string url2 = @"http://213.238.167.117:8081/ulkeler.json";

            using (Stream s = GetStreamFromUrl(url))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {
                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());
                }
            CBIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
            CBSevkIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
            //Ulke Combosu

            using (Stream s = GetStreamFromUrl(url2))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {
                    _ulkeList = JsonConvert.DeserializeObject<UlkeList.Root>(sr.ReadToEnd());
                }
            CBUlke.Properties.DataSource = _ulkeList.Ulke.Select(x => x.ulkeadi);

            if (_tempCariKart != null)
            {
                Doldur();
            }
        }

        //Sevk Adres
        private void BTSevkAdresKaydet_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
            if (_tempCariKart != null)
            {
                if (_cariAltHesapServis.obje.Where(x=>x.id== Convert.ToInt32(CBAltHesap.EditValue)).Count()>0)
                {
                _sevkAdresServis.Data(ServisList.SevkAdresEkleServis, new PocoSEVKADRES()
                {
                    //cariid = _tempCariKart.id,
                    althesapid = Convert.ToInt32(CBAltHesap.EditValue),
                    kodu = TBSevkKodu.Text,
                    il = CBSevkIl.EditValue.ToString(),
                    ilce = CBSevkIlce.EditValue.ToString(),
                    mahalle = TBSevkMahalle.Text,
                    sokak = TBSevkSokak.Text,
                    apartman = TBSevkApt.Text,
                    daire = TBSevkDaire.Text
                });
                MessageBox.Show("Sevk Adres Başarıyla Eklendi!");
                SevkAdresDoldur();
                }
                else
                    MessageBox.Show("Alt Hesap Seçmeden Sevk Adresi Ekleyemezsiniz!");

            }
            else
            {
                MessageBox.Show("Öncelikle Cari Seçimi yapmanız gerekmektedir!");
            }

        }
        //Yetkili Alanı
        private void BTYetkiliKaydet_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
            if (_tempCariKart != null)
            {
                _cariYetkiliServis.Data(ServisList.CariYetkiliEkleServis, new PocoCARIYETKILI()
                {
                    cariid = _tempCariKart.id,
                    adi = TBYetkiliAdi.Text,
                    yetkilitelefon = TBYetkiliTel.Text,
                    pozisyon = TBPozisyon.Text
                });
                MessageBox.Show("Yetkili Başarıyla Eklendi!");
                YetkiliBilgileriDoldur();
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
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;";
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

        //public System.Drawing.Image Base64ToDoc(string base64String)
        //{
        //    try
        //    {
        //        byte[] imageBytes = Convert.FromBase64String(base64String);
        //        MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
        //        ms.Write(imageBytes, 0, imageBytes.Length);
        //        System.Drawing.Image doc = System.Drawing.Image.FromStream(ms, true);
        //        return doc;
        //    }
        //    catch (Exception)
        //    {

        //        return null;
        //    }

        //}
        void CariKaydet()
        {
            _cariServis.Data(ServisList.CariEkleServis, new PocoCARIKART()
            {
                id = _tempCariKart != null ? _tempCariKart.id : 0,
                kod = BTCariSec.Text,
                unvan = TBUnvan.Text,
                ulke = CBUlke.Text,
                il = CBIl.Text,
                ilce = CBIlce.Text,
                mahalle = TBMahalle.Text,
                sokak = TBSokak.Text,
                apt = TBApt.Text,
                daire = TBDaire.Text,
                postakod = TBPostaKod.Text,
                vergidairesi = CBVDaire.Text,
                vergino = TBVergiNo.Text,
                tcno = TBTcNo.Text,
                vadegunu = int.Parse(TBVadeGun.Text),
                muH_KOD = BTMuhSec.Text,
                telefon = TBTelefon1.Text,
                telefoN2 = TBTelefon2.Text,
                ceptel = TBCepTel.Text,
                fax = TBFax.Text,
                web = TBWebSite.Text,
                eposta = TBEposta.Text,
                adres = TBAdres.Text,
                grupkodu = BTGrupSec.Text,
                kategori = BTKategoriSec.Text,
                amuhkod = BTAMuhSec.Text,
                smuhkod = BTSMuhSec.Text,
                adi = TBCariAdi.Text,
                soyadi = TBCariSoyad.Text,
                tipi = CBTip.SelectedIndex,
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
                saciklamA1 = int.Parse(NUDSAciklama1.Value.ToString()),
                saciklamA2 = int.Parse(NUDSAciklama2.Value.ToString()),
                saciklamA3 = int.Parse(NUDSAciklama3.Value.ToString()),
                saciklamA4 = int.Parse(NUDSAciklama4.Value.ToString()),
                saciklamA5 = int.Parse(NUDSAciklama5.Value.ToString()),
                saciklamA6 = int.Parse(NUDSAciklama6.Value.ToString()),
                saciklamA7 = int.Parse(NUDSAciklama7.Value.ToString()),
                saciklamA8 = int.Parse(NUDSAciklama8.Value.ToString()),
                saciklamA9 = int.Parse(NUDSAciklama9.Value.ToString()),
                raporkoD1 = BTRprSec1.Text,
                raporkoD2 = BTRprSec2.Text,
                raporkoD3 = BTRprSec3.Text,
                raporkoD4 = BTRprSec4.Text,
                raporkoD5 = BTRprSec5.Text,
                raporkoD6 = BTRprSec6.Text,
                raporkoD7 = BTRprSec7.Text,
                raporkoD8 = BTRprSec8.Text,
                raporkoD9 = BTRprSec9.Text,


            });
            foreach (var item in _cariAltHesList)
            {

                _cariAltHesCariServis.Data(ServisList.CariAltHesCariEkleServis, new PocoCARIALTHESCARI()
                {
                    carialthesid = item.id,
                    cariid = _cariServis.obje2.id,

                });
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
        List<PocoCARIDOKUMAN> dokumanList;
        //public string DocToBase64(string path)
        //{
        //    try
        //    {
        //        using (System.Drawing.Image doc = System.Drawing.Image.FromFile(path))
        //        {
        //            using (MemoryStream m = new MemoryStream())
        //            {
        //                doc.Save(m, doc.RawFormat);
        //                byte[] imageBytes = m.ToArray();
        //                b64string = Convert.ToBase64String(imageBytes);
        //                return b64string;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        return "";
        //    }
        //}
        //Ülke Seç


        private void BTSil_Click(object sender, EventArgs e)
        {
            if (_tempCariKart.id > 0 && _tempCariKart != null)
            {
                _cariServis.Data(ServisList.CariDeleteByIdServis, id: _tempCariKart.id.ToString(), method: HttpMethod.Post);
                MessageBox.Show("Silme Başarılı");
                FormuTemizle();
                _tempCariKart = null;
            }
            else
            {
                MessageBox.Show("Cari Seçmeden Cari Silemezsiniz!");
            }


        }

        //Kategori Seç
        private void BTKategoriSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            fKategoriList = new FKategoriList(this.Tag.ToString(), "kategorilist");
            fKategoriList.ShowDialog();
            Doldur();
        }

        private void CBSevkIl_Properties_EditValueChanged(object sender, EventArgs e)
        {
            CBSevkIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBSevkIl.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }
        //Sevk İl
        private void CBIl_Properties_EditValueChanged(object sender, EventArgs e)
        {
            string a = CBIl.EditValue == null ? "" : CBIl.EditValue.ToString();
            CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == a).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
            CBIlce.EditValue = _tempCariKart != null ? _tempCariKart.ilce : 0;
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);

            if (_tempCariKart != null && _tempCariKart.id > 0)
            {
                CariKaydet();
                MessageBox.Show("Kayıt işlemi Başarılı!");
                FormuTemizle();
                _tempCariKart = _cariServis.obje2;
                foreach (var item in resimList)
                {
                    item.CARIID = _cariServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id;
                    _cariResimServis.Data(ServisList.CariResimEkleServis, item);
                }

            }
            else
            {
                if (_cariServis.obje.Where(x => x.vergino == TBVergiNo.Text).Count() == 0)
                {
                    if (_cariServis.obje.Where(x => x.kod == BTCariSec.Text).Count() == 0)
                    {
                        if (TBTcNo.Text == "" || _cariServis.obje.Where(x => x.tcno == TBTcNo.Text).Count() == 0)
                        {

                            CariKaydet();
                            MessageBox.Show("Kayıt işlemi Başarılı!");
                            FormuTemizle();
                            _tempCariKart = _cariServis.obje2;
                            foreach (var item in resimList)
                            {
                                item.CARIID = _cariServis.obje.Where(x => x.kod == BTCariSec.Text).FirstOrDefault().id;
                                _cariResimServis.Data(ServisList.CariResimEkleServis, item);
                            }
                        }
                        else
                            MessageBox.Show("Bir TC Kimlik numarasını yalnızca bir cari kullanabilir!");
                    }
                    else
                        MessageBox.Show("Aynı Cari Kodundan yalnızca bir cari olabilir!");
                }
                else
                    MessageBox.Show("Aynı Vergi Numarasından yalnızca bir cari olabilir!");
            }
        }


        private void BTAltHesapKaydet_Click(object sender, EventArgs e)
        {
            _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
            if (_tempCARIALTHES != null && _tempCariKart != null && _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id && x.carialthesid == _tempCARIALTHES.id).Count() == 0)
            {
                _cariAltHesCariServis.Data(ServisList.CariAltHesCariEkleServis, new PocoCARIALTHESCARI()
                {
                    carialthesid = _tempCARIALTHES.id,
                    cariid = _tempCariKart.id,
                    aktif = 1,
                });
                DGAltHesap.DataSource = _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id).Select(x => new { ALTHESAPADI = _cariAltHesapServis.obje.Where(z => z.id == x.carialthesid).FirstOrDefault().adi, PARABIRIMI = _cariParABIRIM.obje.Where(z => z.id == _cariAltHesapServis.obje.Where(y => y.id == x.carialthesid).FirstOrDefault().dovizid).FirstOrDefault().kisaadi, AKTIF = x.aktif });
                DGAltHesap.RefreshDataSource();
                _tempCARIALTHES = null;
                BTAltHesSec.Text = "";
                TBAltHesapAdi.Text = "";
            }
            else
            {
                MessageBox.Show("Cari veya Alt Hesap seçmeden ekleyemezsiniz!");
            }

        } //TO DO

        //Cari Seç Buttonu
        private void BTCariSec_Properties_Click(object sender, EventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "carikart");
            fCariList.ShowDialog();
            Doldur();
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
                    //  DosyaYolu.Doc = new Bitmap(DosyaYolu);
                    base64 = ImageToBase64(DosyaYolu);
                }
            }
        }
        //TODO : Cari Döküman
        private void BTDokumanKaydet_Click(object sender, EventArgs e) //TO DO
        {
            if (_tempCariKart != null)
            {
                _cariDokumanServis.Data(ServisList.CariDokumanEkleServis, new PocoCARIDOKUMAN()
                {
                    cariid = _tempCariKart.id,
                    adi = TBDokumanAdi.Text,
                    dokuman = base64,
                });
                MessageBox.Show("Kayıt Başarıyla Eklendi!");
                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Öncelikle Cari Seçimi yapmanız gerekmektedir!");
            }
        }

        void YetkiliBilgileriDoldur()
        {
            _cariYetkiliServis.Data(ServisList.CariYetkiliListeServis);
            DGYetkiliBilgi.DataSource = _cariYetkiliServis.obje.Where(x => x.kayittipi == 0 && x.cariid == _tempCariKart.id).Select(x => new
            {
                ID = x.id,
                CARIID = _tempCariKart.id,
                ADI = x.adi,
                YETKILITELEFON = x.yetkilitelefon,
                POZISYON = x.pozisyon

            });
            DGYetkiliBilgi.Refresh();
            DGYetkiliBilgi.RefreshDataSource();

        }

        void SevkAdresDoldur()
        {
            _sevkadreslist = new List<PocoSEVKADRES>();
            _sevkAdresServis.Data(ServisList.SevkAdresListeServis);
            foreach (var item in _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id))
            {
                _sevkadreslist.AddRange(_sevkAdresServis.obje.Where(x => x.kayittipi == 0 && x.althesapid == item.carialthesid));

            }
            DGSevkAdres.DataSource = _sevkadreslist.Select(x => new
            {
                ALTHESAP = _cariAltHesapServis.obje.Where(y => y.id == x.althesapid).FirstOrDefault().adi,
                KODU = x.kodu,
                IL = x.il,
                ILCE = x.ilce,
                MAHALLE = x.mahalle,
                SOKAK = x.sokak,
                APARTMAN = x.apartman,
                DAIRE = x.daire,

            });
            DGSevkAdres.RefreshDataSource();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            _tempCariKart = null;
        }

        private void BTCariSec_Leave(object sender, EventArgs e)
        {
            _cariServis.Data(ServisList.CariListeServis);
            if (BTCariSec.Text != "")
            {
                _tempCariKart = _cariServis.obje.Where(x => x.kayittipi == 0 && x.kod == BTCariSec.Text).FirstOrDefault();
                if (_tempCariKart != null)
                    Doldur();
                else if (BTCariSec.Text == "")
                {
                    FormuTemizle();
                }
            }
        }

        private void BTCariSec_Properties_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "carikart");
            fCariList.ShowDialog();
            Doldur();
        }

        private void BTAltHesapSil_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                if (_tempCariKart != null)
                {
                    _cariHareketServis.Data(ServisList.CariHarListeServis);
                    if (_cariHareketServis.obje.Where(x => x.cariid == _tempCariKart.id && x.carialthesapid == _cariAltHesapServis.obje.Where(y => y.kod == gridView1.GetFocusedRowCellValue("ALTHESAPKODU") && y.adi == gridView1.GetFocusedRowCellValue("ALTHESAPADI")).FirstOrDefault().id).Count() == 0)
                    {
                        _cariAltHesCariServis.Data(ServisList.CariAltHesCariSilServis, modellist: _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id && x.carialthesid == _cariAltHesapServis.obje.Where(y => y.kod == gridView1.GetFocusedRowCellValue("ALTHESAPKODU") && y.adi == gridView1.GetFocusedRowCellValue("ALTHESAPADI")).FirstOrDefault().id).ToList());
                        MessageBox.Show("Başarıyla Silindi!");
                        _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
                        DGAltHesap.DataSource = _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id).Select(x => new { ALTHESAPKODU = _cariAltHesapServis.obje.Where(z => z.id == x.carialthesid).FirstOrDefault().kod, ALTHESAPADI = _cariAltHesapServis.obje.Where(z => z.id == x.carialthesid).FirstOrDefault().adi, PARABIRIMI = _cariParABIRIM.obje.Where(z => z.id == _cariAltHesapServis.obje.Where(y => y.id == x.carialthesid).FirstOrDefault().dovizid).FirstOrDefault().kisaadi, AKTIF = x.aktif });

                    }
                }
                else
                    MessageBox.Show("Önce Cari Seçmelisiniz!");

            }
            else
                MessageBox.Show("Silmek İstediğiniz Alt Hesabı Seçiniz!");
        }

   
    }
}
#endregion
