using DevExpress.CodeParser;
using DevExpress.CodeParser;
using DevExpress.Mvvm.Native;
using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using DevExpress.Text.Interop;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraScheduler.iCalendar.Native;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Siparis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using MEYPAK.PRL.Assets;
using OPTYPE.HizliTeknoloji;
using DevExpress.XtraSpreadsheet.Model;
using DevExpress.Office.Utils;
using System.Diagnostics;
using System.Xml.Serialization.Extensions;

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelKart : XtraForm
    {
        GenericWebServis<PocoPERSONEL> _personelServis;
        GenericWebServis<PocoPERSONELDEPARTMAN> _personelDepartmanServis;
        GenericWebServis<PocoPERSONELGOREV> _personelGorevServis;
        GenericWebServis<PocoPERSONELBANKA> _personelBankaServis;
        GenericWebServis<PocoPERSONELZIMMET> _personelZimmetServis;
        GenericWebServis<PocoPERSONELIZIN> _personelIzinServis;
        GenericWebServis<PocoPERSONELAVANS> _personelAvansServis;
        GenericWebServis<PocoPERSONELBELGE> _personelBelgeServis;


        public FPersonelKart()
        {
            _personelServis = new GenericWebServis<PocoPERSONEL>();
            _personelGorevServis = new GenericWebServis<PocoPERSONELGOREV>();
            _personelDepartmanServis = new GenericWebServis<PocoPERSONELDEPARTMAN>();
            _personelBankaServis = new GenericWebServis<PocoPERSONELBANKA>();
            _personelZimmetServis = new GenericWebServis<PocoPERSONELZIMMET>();
            _personelIzinServis = new GenericWebServis<PocoPERSONELIZIN>();
            _personelAvansServis = new GenericWebServis<PocoPERSONELAVANS>();
            _personelBelgeServis = new GenericWebServis<PocoPERSONELBELGE>();

            InitializeComponent();
            PersonelleriGetir();
            CombolarıDoldur();

            CBIzinTur.SelectedIndex = 0;
        }
        //TODO RESİM EKLENECEK - (STOKTAN-CARİDEN RESİM ALINACAK)

        ADRESOBJECT.Root _adresObje;
        public PocoPERSONEL _tempPocoPERSONEL;

        string base64 = "";
        string belgebase64 = "";
        string belgetip = "";

        private void BTNPersonelKaydet_Click(object sender, EventArgs e)
        {
            if (TBTCNO.EditValue != null && TBAdi.EditValue != null && TBSoyadi.EditValue != null && DTPIseGirisTar.EditValue != null && CBCinsiyet.EditValue != null && DTPDogumTar.EditValue != null && CBDepartman.EditValue != null && CBGorev.EditValue != null && TBTCNO.EditValue != "" && TBAdi.EditValue != "" && TBSoyadi.EditValue != "" && DTPIseGirisTar.EditValue != "" && CBCinsiyet.EditValue != "" && DTPDogumTar.EditValue != "" && CBDepartman.EditValue != "" && CBGorev.EditValue != "" && DTPIseGirisTar.EditValue != "" && DTPDogumTar.EditValue != "")
            {
                _personelServis.Data(ServisList.PersonelEkleServis, new PocoPERSONEL()
                {
                    id = _tempPocoPERSONEL != null ? _tempPocoPERSONEL.id : 0,
                    //TODO Şube Şirket seçme ekranı yapılacak
                    subeid = 0,
                    sirketid = 0,
                    img = base64,
                    tc = TBTCNO.Text,
                    adi = TBAdi.Text,
                    soyadi = TBSoyadi.Text,
                    adisoyadi = TBAdi.Text + " " + TBSoyadi.Text,
                    dogumtar = Convert.ToDateTime(DTPDogumTar.Text),
                    cinsiyet = Convert.ToByte(CBCinsiyet.SelectedIndex),
                    personeldepartmanid = CBDepartman.EditValue != null ? (int)CBDepartman.EditValue : 0,
                    personelgorevid = CBGorev.EditValue != null ? (int)CBGorev.EditValue : 0,
                    sgksicilno = TBSGKSICILNO.Text,
                    isbastar = DTPIseGirisTar.EditValue != null ? Convert.ToDateTime(DTPIseGirisTar.Text) : Convert.ToDateTime("01.01.1990"),
                    isbittar = Convert.ToDateTime("01.01.1990"),
                    //TODO RESİM
                    resim = " ",
                    sgk = TBSGK.Text,
                    bagkur = TBBagkur.Text,
                    emeklisandigi = TBEmekliSan.Text,
                    g506MADSAN = TB506G.Text,
                    ogrenimdurumu = CBOgrenimDurum.EditValue != null ? CBOgrenimDurum.EditValue.ToString() : "BILINMIYOR",
                    mezuniyetyili = TBMezuniyetYil.Text,
                    mezunbolum = TBMezunBolum.Text,
                    askerlikdurum = CBAskerlikDurum.EditValue != null ? CBAskerlikDurum.EditValue.ToString() : "BILINMIYOR",
                    askerlikbaslangictar = DTPAskerBasTar.EditValue != null && DTPAskerBasTar.Text != "" ? Convert.ToDateTime(DTPAskerBasTar.EditValue) : Convert.ToDateTime("01.01.1990"),
                    askerlikbitistar = DTPAskerBitTar.EditValue != null && DTPAskerBitTar.Text != "" ? Convert.ToDateTime(DTPAskerBitTar.EditValue) : Convert.ToDateTime("01.01.1990"),
                    sigortaturkod = CBSigortalilikTur.EditValue != null && CBSigortalilikTur.Text != "" ? CBSigortalilikTur.EditValue.ToString() : "BILINMIYOR",
                    yaslilikayligi = CBYaslilikAylik.EditValue != null && CBYaslilikAylik.Text != "" ? CBYaslilikAylik.EditValue.ToString() : "BILINMIYOR",
                    istihdamdurumu = CBIstihtamTuru.EditValue != null && CBIstihtamTuru.Text != "" ? CBIstihtamTuru.EditValue.ToString() : "BILINMIYOR",
                    meslekkodu = CBMeslekKodu.EditValue != null && CBMeslekKodu.Text != "" ? CBMeslekKodu.EditValue.ToString() : "BILINMIYOR",
                    sosyalguvenlikkodu = CBSGKKodu.EditValue != null && CBSGKKodu.Text != "" ? CBSGKKodu.EditValue.ToString() : "BILINMIYOR",
                    babaadi = TBBabaAdi.Text,
                    anneadi = TBAnneAdi.Text,
                    dogumyeri = TBDogumYer.Text,
                    medenidurum = TBMedeniDurum.Text,
                    uyruk = CBUyrugu.EditValue != null && CBUyrugu.Text != "" ? CBUyrugu.EditValue.ToString() : "BILINMIYOR",
                    ilksoyad = TBIlkSoyad.Text,
                    nufusakayitliil = CBNufIl.EditValue != null && CBNufIl.Text != "" ? CBNufIl.EditValue.ToString() : "BILINMIYOR",
                    nufusakayitliilce = CBNufIlce.EditValue != null && CBNufIlce.Text != "" ? CBNufIlce.EditValue.ToString() : "BILINMIYOR",
                    nufusakayitlimah = TBNufKayitMah.Text,
                    ulke = TBUlke.Text,
                    kangrubu = CBKanGrubu.EditValue != null && CBKanGrubu.Text != "" ? CBKanGrubu.EditValue.ToString() : "BILINMIYOR",
                    ciltno = TBCiltNo.Text,
                    ailesirano = TBAileSıraNo.Text,
                    sirano = TBSiraNo.Text,
                    nufuscuzdanverilistarih = DTPNufVerTar.EditValue != null && DTPNufVerTar.Text != "" ? Convert.ToDateTime(DTPNufVerTar.EditValue) : Convert.ToDateTime("01.01.1990"),
                    nufuscuzdanserino = TBNufSeriNo.Text,
                    nufuscuzdankayitno = TBNufKayıtNo.Text,
                    adres = TBAdres.Text,
                    adresmah = TBAdresMahalle.Text,
                    adresil = CBAdresIL.EditValue != null && CBAdresIL.Text != "" ? CBAdresIL.EditValue.ToString() : "BILINMIYOR",
                    adresilce = CBAdresIlce.EditValue != null && CBAdresIlce.Text != "" ? CBAdresIlce.EditValue.ToString() : "BILINMIYOR",
                    adrespostakodu = TBAdresPostaKodu.Text,
                    vergidairesi = TBVergiDaire.Text,
                    vergino = TBVergiNo.Text,
                    telefon = TBTelefon.Text,
                    cepno = TBCepNo.Text,
                    eposta = TBEposta.Text,
                    bedenolcusu = CBUstBeden.EditValue != null && CBUstBeden.Text != "" ? Convert.ToByte(CBUstBeden.SelectedIndex) : (byte)0,
                    pantolonolcusu = CBAltBeden.EditValue != null && CBAltBeden.Text != "" ? Convert.ToByte(CBAltBeden.EditValue) : (byte)0,
                    ayakkabino = CBAyakkabıNo.EditValue != null && CBAyakkabıNo.Text != "" ? Convert.ToByte(CBAyakkabıNo.EditValue) : (byte)0,
                    notlar = TBNotlar.Text,
                    maas = TBMaas.EditValue != null & TBMaas.Text != "" ? Convert.ToInt32(TBMaas.Text) : 0,
                    aktif = true,
                    sube = TBSube.Text,
                    userid = MPKullanici.ID,


                });
                string message = _tempPocoPERSONEL != null ? _tempPocoPERSONEL.adi + "'e ait bilgiler başarıyla güncellendi." : "Kayıt Başarıyla Eklendi";
                _tempPocoPERSONEL = _personelServis.obje2;
                MessageBox.Show(message);
                PersonelleriGetir();

                FormuTemizle(this.Controls);
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurmadan Personel Ekleyemezsiniz!");
            }

        }
        private void BTNPersonelFoto_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TümDosyalar |*.*|Jpeg Dosyası |*.jpeg| Jpg Dosyası|*.jpg| PNG Dosyası|*.png| ICO Dosyası|*.ico;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = ofd.FileName;
                string DosyaAdi = ofd.SafeFileName;
                BTNPersonelFoto.Text = DosyaYolu;
                PBPersonelResim.Image = new Bitmap(DosyaYolu);
                PBPersonelResim.Properties.SizeMode = PictureSizeMode.Stretch;
                base64 = ImageToBase64(DosyaYolu);
            }
        }

        private void BTIzin_Click(object sender, EventArgs e)
        {
            if (_tempPocoPERSONEL != null && _tempPocoPERSONEL.id > 0)
            {
                if (TBIzınNeden.Text != "" && DTPIzinBas.EditValue != null && DTPIzinBit.EditValue != null)
                {
                    if (CBIzinTur.SelectedText != "YILLIK ÜCRETLİ İZİN" && Convert.ToInt32(TBIzinGun.EditValue) >= IzinHesapla())
                    {
                        _personelIzinServis.Data(ServisList.PersonelIzinEkleServis, new PocoPERSONELIZIN()
                        {
                            IZINTURU = CBIzinTur.SelectedText,
                            IZINNEDENI = TBIzınNeden.Text,
                            IZINBASLANGIC = (DateTime)DTPIzinBas.EditValue,
                            DEVREDILECEKPERSONEL = TBIzinDevirPers.Text,
                            IZINBITIS = (DateTime)DTPIzinBit.EditValue,
                            PERSONELID = _tempPocoPERSONEL.id,
                            IZINGUN = Convert.ToInt32(TBIzinGun.EditValue),
                            userid = MPKullanici.ID,
                        });

                        PersonelIzinGridDoldur();
                    }
                    else
                        MessageBox.Show("YILLIK ÜCRETLİ İZİN KULLANILIRKEN, İZİN KULLANILACAK GÜN SAYISI HAKEDİLEN İZİN MİKTARINDAN FAZLA OLAMAZ!");
                }
                else
                {
                    MessageBox.Show("Gerekli Alanları Girmeden Izin Tanımlayamazsınız!");
                }
            }
            else
            {
                MessageBox.Show("Izin Bilgisi Eklenecek Personel Bulunamadı!");
            }
        }
        private void BTAvansKaydet_Click(object sender, EventArgs e)
        {
            decimal a = 0;
            if (_tempPocoPERSONEL != null && _tempPocoPERSONEL.id > 0)
            {

                if (TBAvansMiktar.EditValue != null && DTPAvansTar.EditValue != null)
                {
                    if (decimal.TryParse(TBAvansMiktar.EditValue.ToString(), out a))
                    {
                        _personelAvansServis.Data(ServisList.PersonelAvansEkleServis, new PocoPERSONELAVANS()
                        {
                            PERSONELID = _tempPocoPERSONEL.id,
                            MIKTAR = Convert.ToDecimal(TBAvansMiktar.EditValue.ToString().Replace(".", ",")),
                            ACIKLAMA = TBAvansAciklama.Text,
                            TARIH = (DateTime)DTPAvansTar.EditValue,
                            userid = MPKullanici.ID,
                        });

                        MessageBox.Show($"{_tempPocoPERSONEL.adisoyadi} adlı personele avans eklenmiştir.");
                        PersonelAvansGridDoldur();
                    }
                    else
                        MessageBox.Show("Geçerli bir avans miktarı girmeden, Personele Avans Bilgisi Kaydedemezsiniz!");
                }
                else
                    MessageBox.Show("Gerekli Alanları Doldurmadan Personele Avans Bilgisi Kaydedemezsiniz!");
            }
            else
                MessageBox.Show("Avans Bilgisi Eklenecek Personel Bulunamadı!");
        }
        private void BTNZimKaydet_Click(object sender, EventArgs e)
        {
            if (TBZimMarka.EditValue != null && TBZimMiktar.EditValue != null && DTPZimBasTar.EditValue != null && TBZimSeriNo.EditValue != null && TBZimAciklama.EditValue != null)
            {
                if (_tempPocoPERSONEL != null && _tempPocoPERSONEL.id > 0)
                {
                    _personelZimmetServis.Data(ServisList.PersonelZimmetlEkleServis, new PocoPERSONELZIMMET()
                    {
                        serino = TBZimSeriNo.Text,
                        zimmettarihi = (DateTime)DTPZimBasTar.EditValue,
                        markamodel = TBZimMarka.Text,
                        miktar = Convert.ToInt32(TBZimMiktar.Text),
                        personelid = _tempPocoPERSONEL.id,
                        aciklama = TBZimAciklama.Text,
                        userid = MPKullanici.ID,

                    });
                    TBZimAciklama.Text = "";
                    TBZimMarka.Text = "";
                    TBZimSeriNo.Text = "";
                    TBZimMiktar.Text = "";
                    MessageBox.Show($"{_tempPocoPERSONEL.adisoyadi}'adlı personele zimmet eklendi.");
                    PersonelZimmetGridDoldur();
                }
                else
                {
                    MessageBox.Show("Zimmet Bilgisi Eklenecek Personel Bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurmadan Personele Zimmet Tanımlayamazsınız!");
            }
        }
        private void BTSPersonelBanka_Click(object sender, EventArgs e)
        {
            if (TBBankaAdi.EditValue != null && TBBankaSubeAdi.EditValue != null && TBBankaSubeKod.EditValue != null && TBBankaIban.EditValue != null)
            {
                if (_tempPocoPERSONEL != null && _tempPocoPERSONEL.id > 0)
                {
                    _personelBankaServis.Data(ServisList.PersonelBankaEkleServis, new PocoPERSONELBANKA()
                    {
                        bankaadi = TBBankaAdi.Text,
                        bankasubeadi = TBBankaSubeAdi.Text,
                        bankasubekodu = TBBankaSubeKod.Text,
                        ibanno = TBBankaIban.Text,
                        personelid = _tempPocoPERSONEL.id,
                        userid = MPKullanici.ID,
                    });
                    TBBankaIban.Text = "";
                    TBBankaSubeKod.Text = "";
                    TBBankaSubeAdi.Text = "";
                    TBBankaAdi.Text = "";
                    MessageBox.Show($"{_tempPocoPERSONEL.adisoyadi}'adlı personele banka bilgileri eklendi.");
                    PersonelBankaGridDoldur();
                }
                else
                {
                    MessageBox.Show("Banka Bilgisi Eklenecek Personel Bulunamadı!");
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurmadan Banka Bilgisi Ekleyemezsiniz!");
            }
        }
        private void lookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        { //ADRESIL EDIT VALUE CHANGED
            if (CBAdresIL.EditValue != null)
                CBAdresIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBAdresIL.EditValue.ToString()).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();

        }
        private void CBNufIl_EditValueChanged(object sender, EventArgs e)
        {
            if (CBNufIl.EditValue != null)
                CBNufIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBNufIl.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }

        private void CBNufIl_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (CBNufIl.EditValue != null)
                CBNufIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBNufIl.EditValue.ToString()).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                FormuTemizle(this.Controls);
                _tempPocoPERSONEL = _personelServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                _personelServis.Data(ServisList.PersonelListeServis);
                FormuTemizle(this.Controls);
                var asda = gridView1.GetFocusedRowCellValue("ID");
                _tempPocoPERSONEL = _personelServis.obje.Where(x => x.id.ToString() == (gridView1.GetFocusedRowCellValue("ID") != null ? gridView1.GetFocusedRowCellValue("ID").ToString() : "0")).FirstOrDefault();
                PersonelBilgileriniDoldur();
            }
        }

        private void CBDepartman_EditValueChanged(object sender, EventArgs e)
        {
            CBGorevDoldur();
        }
        void CBGorevDoldur()
        {
            CBGorev.Properties.DataSource = "";
            CBGorev.Properties.DataSource = _personelGorevServis.obje.Where(x => x.departmanid == Convert.ToInt32(CBDepartman.EditValue)).Select(x => new { ID = x.id, GOREV = x.adi });
            CBGorev.Properties.ValueMember = "ID";
            CBGorev.Properties.DisplayMember = "GOREV";
            CBGorev.Properties.PopulateColumns();
            CBGorev.Properties.Columns["ID"].Visible = false;
        }



        #region Methods
        void ComponentTemizle(System.Windows.Forms.Control.ControlCollection ctrlCollection)
        {
            foreach (System.Windows.Forms.Control ctrl in ctrlCollection)
            {
                if (ctrl is TextEdit)
                {
                    ctrl.Text = "";
                }
                else
                {
                    ComponentTemizle(ctrl.Controls);
                }
            }
        }
        void FormuTemizle(System.Windows.Forms.Control.ControlCollection ctrlCollection)
        {
            ComponentTemizle(ctrlCollection);

            GCPersonelBanka.DataSource = new PersonelBankaListe();
            GCPersonelIzın.DataSource = new PersonelIzinListe();
            GCPersonelZimmet.DataSource = new PersonelZimmetListe();
            GCAvans.DataSource = new AvansList();
            DTPIseGirisTar.EditValue = DateTime.Now;
            TBNotlar.Text = "";
            PBPersonelResim.Image = null;
            _tempPocoPERSONEL = null;
            base64 = "";
            belgebase64 = "";
            belgetip = "";
            CBGorev.EditValue = 0;
            CBDepartman.EditValue = 0;

        }
        private static Stream GetStreamFromUrl(string url)
        {
            byte[] imageData = null;

            using (var wc = new System.Net.WebClient())
                imageData = wc.DownloadData(url);

            return new MemoryStream(imageData);
        }
        void PersonelDepartmanComboDoldur()
        {
            _personelGorevServis.Data(ServisList.PersonelGorevListeServis);
            _personelDepartmanServis.Data(ServisList.PersonelDepartmanListeServis);
            CBDepartman.Properties.DataSource = _personelDepartmanServis.obje.Where(x => x.kayittipi == 0).Select(x => new { DEPARTMAN = x.adi, ID = x.id });
            CBDepartman.Properties.ValueMember = "ID";
            CBDepartman.Properties.DisplayMember = "DEPARTMAN";
        }
        void CombolarıDoldur()
        {
            PersonelDepartmanComboDoldur();
            string url = @"https://elizmeypak.com.tr/il-ilce.json";


            using (Stream s = GetStreamFromUrl(url))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {
                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());
                }
            CBAdresIL.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
            CBNufIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);

        }
        void PersonelleriGetir()
        {
            _personelServis.Data(ServisList.PersonelListeServis);
            _personelDepartmanServis.Data(ServisList.PersonelDepartmanListeServis);
            gridControl1.DataSource = _personelServis.obje.Where(x => x.aktif == true).Select(x => new { ID = x.id, ADI = x.adisoyadi, DEPARTMAN = _personelDepartmanServis.obje.Where(y => y.id == x.personeldepartmanid).FirstOrDefault().adi, SUBE = x.sube });
            gridView1.Columns["ID"].Visible = false;
            GridColumn SUBE = gridView1.Columns["SUBE"];
            gridView1.SortInfo.ClearAndAddRange(new[] {
                new GridColumnSortInfo(SUBE , DevExpress.Data.ColumnSortOrder.Ascending)
            }, 1);
            gridView1.ExpandAllGroups();
            gridControl2.DataSource = _personelServis.obje.Where(x => x.aktif == false).Select(x => new { ID = x.id, ADI = x.adisoyadi, DEPARTMAN = _personelDepartmanServis.obje.Where(y => y.id == x.personeldepartmanid).FirstOrDefault().adi, SUBE = x.sube });
            gridView2.Columns["ID"].Visible = false;
        }
        void PersonelBilgileriniDoldur()
        {
            if (_tempPocoPERSONEL != null)
            {
                base64 = _tempPocoPERSONEL.img;
                TBTCNO.Text = _tempPocoPERSONEL.tc;
                TBAdi.Text = _tempPocoPERSONEL.adi;
                TBSoyadi.Text = _tempPocoPERSONEL.soyadi;
                DTPDogumTar.EditValue = (DateTime)_tempPocoPERSONEL.dogumtar;
                CBCinsiyet.SelectedIndex = _tempPocoPERSONEL.cinsiyet;
                if (_tempPocoPERSONEL.personeldepartmanid != 0 && _tempPocoPERSONEL.personelgorevid != 0)
                {
                    CBDepartman.EditValue = _personelDepartmanServis.obje.Where(x => x.id == _tempPocoPERSONEL.personeldepartmanid).FirstOrDefault().id;
                    CBGorev.EditValue = _personelGorevServis.obje.Where(x => x.id == _tempPocoPERSONEL.personelgorevid).FirstOrDefault().id;
                }
                DTPIseGirisTar.EditValue = (DateTime)_tempPocoPERSONEL.isbastar;
                //PBPersonelResim
                if (_tempPocoPERSONEL.img != null && _tempPocoPERSONEL.img != "")
                {
                    PBPersonelResim.Image = Base64ToImage(_tempPocoPERSONEL.img);
                    PBPersonelResim.Properties.SizeMode = PictureSizeMode.Stretch;
                }
                else
                {
                    PBPersonelResim.Image = null;
                }
                TBSGK.Text = _tempPocoPERSONEL.sgk;
                TBBagkur.Text = _tempPocoPERSONEL.bagkur;
                TBEmekliSan.Text = _tempPocoPERSONEL.emeklisandigi;
                TB506G.Text = _tempPocoPERSONEL.g506MADSAN;
                CBOgrenimDurum.EditValue = _tempPocoPERSONEL.ogrenimdurumu;
                TBMezuniyetYil.Text = _tempPocoPERSONEL.mezuniyetyili;
                TBMezunBolum.Text = _tempPocoPERSONEL.mezunbolum;
                CBAskerlikDurum.EditValue = _tempPocoPERSONEL.askerlikdurum;
                DTPAskerBasTar.EditValue = (DateTime)_tempPocoPERSONEL.askerlikbaslangictar;
                DTPAskerBitTar.EditValue = (DateTime)_tempPocoPERSONEL.askerlikbitistar;
                CBSigortalilikTur.EditValue = _tempPocoPERSONEL.sigortaturkod;
                CBYaslilikAylik.EditValue = _tempPocoPERSONEL.yaslilikayligi;
                CBIstihtamTuru.EditValue = _tempPocoPERSONEL.istihdamdurumu;
                CBMeslekKodu.EditValue = _tempPocoPERSONEL.meslekkodu;
                CBSGKKodu.EditValue = _tempPocoPERSONEL.sosyalguvenlikkodu;
                TBBabaAdi.Text = _tempPocoPERSONEL.babaadi;
                TBAnneAdi.Text = _tempPocoPERSONEL.anneadi;
                TBDogumYer.Text = _tempPocoPERSONEL.dogumyeri;
                TBMedeniDurum.Text = _tempPocoPERSONEL.medenidurum;
                CBUyrugu.EditValue = _tempPocoPERSONEL.uyruk;
                TBIlkSoyad.Text = _tempPocoPERSONEL.ilksoyad;
                TBMaas.Text = _tempPocoPERSONEL.maas.ToString();
                TBSube.Text = _tempPocoPERSONEL.sube;
                /*EditValue yerine CanFocus denenecek.*/
                TBNufKayitMah.Text = _tempPocoPERSONEL.nufusakayitlimah;
                TBUlke.Text = _tempPocoPERSONEL.ulke;
                CBKanGrubu.EditValue = _tempPocoPERSONEL.kangrubu;
                TBAileSıraNo.Text = _tempPocoPERSONEL.ailesirano;
                TBSiraNo.Text = _tempPocoPERSONEL.sirano;
                DTPNufVerTar.EditValue = (DateTime)_tempPocoPERSONEL.nufuscuzdanverilistarih;
                TBNufSeriNo.Text = _tempPocoPERSONEL.nufuscuzdanserino;
                TBNufKayıtNo.Text = _tempPocoPERSONEL.nufuscuzdankayitno;
                TBAdres.Text = _tempPocoPERSONEL.adres;
                TBAdresMahalle.Text = _tempPocoPERSONEL.adresmah;
                if (_tempPocoPERSONEL.adresil != "" && _tempPocoPERSONEL.adresil != "BILINMIYOR")
                    CBAdresIL.EditValue = _tempPocoPERSONEL.adresil;
                else
                    CBAdresIL.EditValue = 0;
                if (_tempPocoPERSONEL.adresilce != "" && _tempPocoPERSONEL.adresilce != "BILINMIYOR")
                    CBAdresIlce.EditValue = _tempPocoPERSONEL.adresilce;
                else
                    CBAdresIlce.EditValue = 0;
                if (_tempPocoPERSONEL.nufusakayitliil != "" && _tempPocoPERSONEL.nufusakayitliil != "BILINMIYOR")
                    CBNufIl.EditValue = _tempPocoPERSONEL.nufusakayitliil;
                else
                    CBNufIl.EditValue = 0;
                if (_tempPocoPERSONEL.nufusakayitliilce != "" && _tempPocoPERSONEL.nufusakayitliilce != "BILINMIYOR")
                    CBNufIlce.EditValue = _tempPocoPERSONEL.nufusakayitliilce;
                else
                    CBNufIlce.EditValue = 0;
                TBAdresPostaKodu.Text = _tempPocoPERSONEL.adrespostakodu;
                TBVergiDaire.Text = _tempPocoPERSONEL.vergidairesi;
                TBVergiNo.Text = _tempPocoPERSONEL.vergino;
                TBTelefon.Text = _tempPocoPERSONEL.telefon;
                TBCepNo.Text = _tempPocoPERSONEL.cepno;
                TBCiltNo.Text = _tempPocoPERSONEL.ciltno;
                TBEposta.Text = _tempPocoPERSONEL.eposta;
                CBUstBeden.SelectedIndex = _tempPocoPERSONEL.bedenolcusu;
                CBAltBeden.EditValue = _tempPocoPERSONEL.pantolonolcusu;
                CBAyakkabıNo.EditValue = _tempPocoPERSONEL.ayakkabino;
                TBNotlar.Text = _tempPocoPERSONEL.notlar;
                PersonelIzinGridDoldur();
                PersonelBankaGridDoldur();
                PersonelZimmetGridDoldur();
                PersonelAvansGridDoldur();
                PersonelBelgeGridDoldur();
                LBIzinMiktari.Text = IzinHesapla().ToString();
            }
        }
        int IzinHesapla()
        {
            if (_tempPocoPERSONEL != null)
            {
                DateTime IzinTarih;
                int izinGun = 0;
                if (_tempPocoPERSONEL.isbastar.Year < 2022)
                    IzinTarih = new DateTime(2022, _tempPocoPERSONEL.isbastar.Month, _tempPocoPERSONEL.isbastar.Day);
                else
                    IzinTarih = new DateTime(_tempPocoPERSONEL.isbastar.Year, _tempPocoPERSONEL.isbastar.Month, _tempPocoPERSONEL.isbastar.Day);

                TimeSpan fark = DateTime.Now - IzinTarih;
                TimeSpan Yasfark = DateTime.Now - _tempPocoPERSONEL.dogumtar;
                byte yas = (byte)(Yasfark.Days / 365);
                byte calistigiyıl = (byte)(fark.Days / 365);
                for (int i = 0; i < (fark.Days / 365); i++)
                {
                    izinGun += calistigiyıl >= 15 ? 26 : calistigiyıl > 5 ? 20 : yas > 50 ? 20 : yas < 18 ? 20 : 14;
                }
                if (_personelIzinServis.obje != null && _personelIzinServis.obje.Where(x => x.PERSONELID == _tempPocoPERSONEL.id && x.IZINTURU == "YILLIK ÜCRETLİ İZİN").Count() > 0)
                {
                    foreach (var item in _personelIzinServis.obje.Where(x => x.PERSONELID == _tempPocoPERSONEL.id && x.IZINTURU == "YILLIK ÜCRETLİ İZİN"))
                    {
                        izinGun -= item.IZINGUN;
                    }
                }

                return izinGun;
            }
            return 0;
        }
        void PersonelIzinGridDoldur()
        {
            if (_tempPocoPERSONEL != null)
            {
                _personelIzinServis.Data(ServisList.PersonelIzinListeServis);
                GCPersonelIzın.DataSource = _personelIzinServis.obje.Where(x => x.PERSONELID == _tempPocoPERSONEL.id).Select(x => new PersonelIzinListe()
                {
                    IZINTURU = x.IZINTURU,
                    IZINNEDENI = x.IZINNEDENI,
                    IZINGUN = x.IZINGUN,
                    IZINBASLANGIC = x.IZINBASLANGIC,
                    IZINBITIS = x.IZINBITIS,
                    DEVREDILECEKPERSONEL = x.DEVREDILECEKPERSONEL,
                });
            }
        }

        void PersonelAvansGridDoldur()
        {
            if (_tempPocoPERSONEL != null)
            {
                _personelAvansServis.Data(ServisList.PersonelAvansListeServis);
                GCAvans.DataSource = _personelAvansServis.obje.Where(x => x.PERSONELID == _tempPocoPERSONEL.id).Select(x => new AvansList()
                {
                    MIKTAR = x.MIKTAR,
                    TARIH = x.TARIH,
                    ACIKLAMA = x.ACIKLAMA
                });
                GCAvans.RefreshDataSource();
            }

        }
        void PersonelZimmetGridDoldur()
        {
            if (_tempPocoPERSONEL != null)
            {
                _personelZimmetServis.Data(ServisList.PersonelZimmetlListeServis);
                GCPersonelZimmet.DataSource = _personelZimmetServis.obje.Where(x => x.personelid == _tempPocoPERSONEL.id).Select(x => new PersonelZimmetListe
                {
                    MARKAMODEL = x.markamodel,
                    SERINO = x.serino,
                    MIKTAR = x.miktar,
                    ZIMMETTARIH = x.zimmettarihi,
                    ACIKLAMA = x.aciklama
                });

            }
        }
        void PersonelBankaGridDoldur()
        {
            if (_tempPocoPERSONEL != null)
            {
                _personelBankaServis.Data(ServisList.PersonelBankaListeServis);
                GCPersonelBanka.DataSource = _personelBankaServis.obje.Where(x => x.personelid == _tempPocoPERSONEL.id).Select(x => new
                {
                    BANKAADI = x.bankaadi,
                    BANKASUBE = x.bankasubeadi,
                    BANKASUBEKOD = x.bankasubekodu,
                    IBANNO = x.ibanno
                });
            }
        }

        void PersonelBelgeGridDoldur()
        {
            if (_tempPocoPERSONEL != null)
            {
                _personelBelgeServis.Data(ServisList.PersonelBelgeListeFiltreServis,parameters:$"query=PERSONELID={_tempPocoPERSONEL.id}");
                GCPersonelBelge.DataSource = _personelBelgeServis.obje.Where(x => x.PERSONELID == _tempPocoPERSONEL.id).Select(x => new
                {
                    ID = x.id,
                    BELGE = "",
                    ACIKLAMA = x.ACIKLAMA,
                    TARIH = x.olusturmatarihi,
                   
                });
                gridView7.Columns["ID"].Visible = false;
            }
        }
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
        public string ImageToBase64(string path)
        {
            string b64string = "";
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







        #endregion

        private void BTCIKIS_Click(object sender, EventArgs e)
        {
            if (_tempPocoPERSONEL != null)
            {
                DialogResult dialogResult = MessageBox.Show($"{_tempPocoPERSONEL.adisoyadi}'adlı \nPersoneli işten çıkarmak istediğinize emin misiniz?", "Personel Çıkış", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _tempPocoPERSONEL.aktif = false;
                    _tempPocoPERSONEL.isbittar = DateTime.Now;
                    _tempPocoPERSONEL.userid = MPKullanici.ID;
                    _personelServis.Data(ServisList.PersonelEkleServis, _tempPocoPERSONEL);
                    PersonelleriGetir();
                    FormuTemizle(this.Controls);
                }

            }
            else
                MessageBox.Show("Çıkış Verilecek Personel Bulunamadı!");
        }

        private void BTDepGorevEkle_Click(object sender, EventArgs e)
        {
            FPersonelGorevKart fPersonelGorevKart = new FPersonelGorevKart();
            fPersonelGorevKart.ShowDialog();

            PersonelDepartmanComboDoldur();
        }

        private void TBTCNO_EditValueChanged(object sender, EventArgs e)
        {
            if (_personelServis.obje.Where(x => x.tc == TBTCNO.Text).Count() > 0)
            {
                _tempPocoPERSONEL = _personelServis.obje.Where(x => x.tc == TBTCNO.Text).FirstOrDefault();
                PersonelBilgileriniDoldur();
            }
            else if (_tempPocoPERSONEL != null)
            {
                string a = TBTCNO.Text;
                FormuTemizle(this.Controls);
                TBTCNO.Text = a;
            }

        }

        private void BTSorgula_Click(object sender, EventArgs e)
        {
            mukellefsorgula sorgulama = new mukellefsorgula();
            MukellefOutput resp = sorgulama.sorgu(TBTCNO.Text == "" ? TBVergiNo.Text : TBTCNO.Text);
            TBAdi.Text = resp.mukellef.ad;
            TBSoyadi.Text = resp.mukellef.soyad;
            TBBabaAdi.Text = resp.mukellef.babaAdi;
            //TBDogumYer.Text = resp.mukellef.dogumYeri;
            //string yil = resp.mukellef.iseBaslamaTarihi.Substring(0, 4);
            //string ay = resp.mukellef.iseBaslamaTarihi.Substring(4, 2); 
            //string gun = resp.mukellef.iseBaslamaTarihi.Substring(6,2); 
            //DTPIseGirisTar.EditValue = Convert.ToDateTime(gun+"."+ay+"."+yil);
            TBVergiDaire.Text = resp.mukellef.vergiDairesiAdi;
            TBVergiNo.Text = resp.mukellef.vergiDairesiKodu;


        }

        private void BTNBelgeKaydet_Click(object sender, EventArgs e)
        {
            if (_tempPocoPERSONEL != null && _tempPocoPERSONEL.id > 0)
            {
                if (BTNBelgeSec.Text != "" && belgebase64 != "")
                {
                    _personelBelgeServis.Data(ServisList.PersonelBelgeEkleServis, new PocoPERSONELBELGE()
                    {
                        PERSONELID = _tempPocoPERSONEL.id,
                        BELGETIP = belgetip,
                        ACIKLAMA = TBBelgeAciklama.Text,
                        IMG = belgebase64,
                        userid = MPKullanici.ID,
                    });
                    MessageBox.Show($"{_tempPocoPERSONEL.adisoyadi}'adlı personele belge başarıyla eklendi!");
                    PersonelBelgeGridDoldur();
                }
                else
                    MessageBox.Show("Belge Eklenirken bir hata oluştu!");
            }
            else
                MessageBox.Show("Personel Seçmeden Belge Ekleyemezsiniz!");
        }

        private void BTNBelgeSec_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Dosyası |*.pdf| Jpeg Dosyası |*.jpeg| Jpg Dosyası |*.jpg| PNG Dosyası |*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = ofd.FileName;
                string DosyaAdi = ofd.SafeFileName;
                BTNBelgeSec.Text = DosyaYolu;
                if (DosyaYolu.Substring(DosyaYolu.Length - 3, 3) != "pdf")
                    belgebase64 = ImageToBase64(DosyaYolu);
                else
                {
                    Byte[] fileBytes = File.ReadAllBytes(DosyaYolu);
                    belgebase64 = Convert.ToBase64String(fileBytes);
                    belgetip = "pdf";
                }
            }
        }

        private void GCPersonelBelge_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("ID") != null)
            {
                SaveFileDialog sv = new SaveFileDialog();
            sv.Title = "Personel Belge Kaydet";
            if (_personelBelgeServis.obje.Where(x => x.id.ToString() == gridView7.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().BELGETIP == "pdf")
                sv.Filter = "PDF Dosyası|*.pdf;";
            else
                sv.Filter = "RESIM Dosyası|*.jpeg||*.png;";


                if (sv.ShowDialog() == DialogResult.OK)
                {
                    if (_personelBelgeServis.obje.Where(x => x.id.ToString() == gridView7.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().BELGETIP == "pdf")
                    {
                        byte[] bytedecode = Convert.FromBase64String(_personelBelgeServis.obje.Where(x => x.id.ToString() == gridView7.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().IMG);
                        File.WriteAllBytes(sv.FileName, bytedecode);

                        var p = new Process();
                        p.StartInfo = new ProcessStartInfo(sv.FileName)
                        {
                            UseShellExecute = true
                        };
                        p.Start();
                    }
                    else
                    {
                        byte[] bytedecode = Convert.FromBase64String(_personelBelgeServis.obje.Where(x => x.id.ToString() == gridView7.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().IMG);
                        File.WriteAllBytes(sv.FileName, bytedecode);
                        var p = new Process();
                        p.StartInfo = new ProcessStartInfo(sv.FileName)
                        {
                            UseShellExecute = true
                        };
                        p.Start();
                    }
                }
            }



            //FileStream fs = new FileStream(Application.StartupPath+$"PersonelBelge\\{gridView7.GetFocusedRowCellValue("ID")}", FileMode.OpenOrCreate,FileAccess.ReadWrite);

            //fs.Write(_personelBelgeServis.obje.Where(x=> x.id.ToString()== gridView7.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().IMG,);
        }
    }
}


