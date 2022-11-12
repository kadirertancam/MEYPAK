using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelKart : Form
    {
        GenericWebServis<PocoPERSONEL> _personelServis;
        GenericWebServis<PocoPERSONELDEPARTMAN> _personelDepartmanServis;
        GenericWebServis<PocoPERSONELGOREV> _personelGorevServis;
        GenericWebServis<PocoPERSONELBANKA> _personelBankaServis;
        GenericWebServis<PocoPERSONELZIMMET> _personelZimmetServis;
        

        public FPersonelKart()
        {
            _personelServis = new GenericWebServis<PocoPERSONEL>();
            _personelGorevServis = new GenericWebServis<PocoPERSONELGOREV>();
            _personelDepartmanServis = new GenericWebServis<PocoPERSONELDEPARTMAN>();
            _personelBankaServis = new GenericWebServis<PocoPERSONELBANKA>();
            _personelZimmetServis = new GenericWebServis<PocoPERSONELZIMMET>();
            InitializeComponent();
            CombolarıDoldur();



        }

        ADRESOBJECT.Root _adresObje;




        private void lookUpEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {//GOREV
            if (e.Button.Caption == "Ekle")
            {
               
                var a =   CBGorev.GetColumnValue("adi").ToString();
                _personelGorevServis.Data(ServisList.PersonelGorevEkleServis, new PocoPERSONELGOREV()
                {
                    //Todo departmanid
                    adi = sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString()
                });
                MessageBox.Show(sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString() + " Başarıyla Eklendi");
            }
        }

        private void lookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {//DEPARTMAN
            if (e.Button.Caption == "Ekle")
            {
                var a = CBDepartman.GetColumnValue("id").ToString();
                _personelDepartmanServis.Data(ServisList.PersonelDepartmanEkleServis, new PocoPERSONELDEPARTMAN()
                {
                    adi = sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString()
                });
                CombolarıDoldur();
                MessageBox.Show(sender.GetType().GetProperty("AutoSearchText").GetValue(sender).ToString() + " Başarıyla Eklendi");
            }
        }


        void CombolarıDoldur()
        {
            _personelDepartmanServis.Data(ServisList.PersonelDepartmanListeServis);
            CBDepartman.Properties.DataSource = _personelDepartmanServis.obje;
           // CBDepartman.Properties.Columns["adi"].Visible = false;

            _personelGorevServis.Data(ServisList.PersonelGorevListeServis);
            CBGorev.Properties.DataSource = _personelGorevServis.obje.Select(x=> new { x.id, x.adi }); 

            //foreach (var item in _personelDepartmanServis.obje)
            //{
            //    CBKanGrubu.Properties.Items.Add(item.adi);
            //}

            string path = Application.StartupPath + "/il-ilce.json";
            using (FileStream s = File.Open(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {

                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());


                    CBAdresIL.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
                    CBNufIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
                    
                }


        }


        
        private void BTSPersonelBanka_Click(object sender, EventArgs e)
        {
            if (TBBankaAdi.EditValue!=null && TBBankaSubeAdi.EditValue!=null && TBBankaSubeKod.EditValue!=null && TBBankaIban.EditValue!=null)
            {
                _personelBankaServis.Data(ServisList.PersonelBankaEkleServis, new PocoPERSONELBANKA()
                {
                    bankaadi = TBBankaAdi.Text,
                    bankasubeadi = TBBankaSubeAdi.Text,
                    bankasubekodu = TBBankaSubeKod.Text,
                    ibanno = TBBankaIban.Text,
                    personelid =1
                    //TODO PERSONEL ID YAPILANDIRALACAK

                }) ;

                _personelBankaServis.Data(ServisList.PersonelBankaListeServis);
                //Todo personel id
                gridControl2.DataSource = _personelBankaServis.obje.Where(x => x.personelid == 1);
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurmadan Banka Bilgisi Ekleyemezsiniz!");
            }
        }

        private void lookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        {
            CBAdresIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBAdresIL.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }
        private void CBNufIl_EditValueChanged(object sender, EventArgs e)
        {
            CBNufIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBNufIl.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }
        private void BTNZimKaydet_Click(object sender, EventArgs e)
        {
            if (TBZimMarka.EditValue!=null && TBZimMiktar.EditValue!=null && DTPZimBasTar.EditValue!=null && TBZimSeriNo.EditValue!=null&& TBZimAciklama.EditValue!=null)
            {
                _personelZimmetServis.Data(ServisList.PersonelZimmetlEkleServis, new PocoPERSONELZIMMET()
                {
                    serino = TBZimSeriNo.Text,
                    zimmettarihi =(DateTime) DTPZimBasTar.EditValue,
                    markamodel = TBZimMarka.Text,
                    miktar =Convert.ToInt32( TBZimMiktar.Text),
                    personelid=1
                });
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurmadan Personele Zimmet Tanımlayamazsınız!");
            }
        }

        private void BTNPersonelKaydet_Click(object sender, EventArgs e)
        {
            if (TBTCNO.EditValue!=null && TBAdi.EditValue!=null && TBSoyadi.EditValue!=null  && DTPIseGirisTar.EditValue!=null&& CBCinsiyet.EditValue!=null && DTPDogumTar.EditValue!=null)
            {
                // DTPZimBasTar.EditValue!=null ? (DateTime)DTPZimBasTar.EditValue:Convert.ToDateTime("01.01.1990");
                _personelServis.Data(ServisList.PersonelEkleServis, new PocoPERSONEL()
                {
                    subeid = 0,
                    sirketid = 0,
                    tc = TBTCNO.Text,
                    adi = TBAdi.Text,
                    soyadi = TBSoyadi.Text,
                    dogumtar = (DateTime)DTPDogumTar.EditValue,
                    cinsiyet = Convert.ToByte(CBCinsiyet.SelectedIndex),
                    personeldepartmanid = CBDepartman.EditValue != null ? (int)CBDepartman.EditValue : 0,
                    personelgorevid = CBGorev.EditValue != null ? (int)CBGorev.EditValue : 0,
                    sgksicilno = TBSGKSICILNO.Text,
                    isbastar = DTPIseGirisTar.EditValue != null ? (DateTime)DTPIseGirisTar.EditValue : Convert.ToDateTime("01.01.1990"),
                    isbittar = Convert.ToDateTime("01.01.1990"),
                    //TODO RESİM
                    resim = " ",
                    sgk = TBSGK.Text,
                    bagkur = TBBagkur.Text,
                    emeklisandigi = TBEmekliSan.Text,
                    g506MADSAN = TB506G.Text,
                    ogrenimdurumu = CBOgrenimDurum.EditValue != null ? CBOgrenimDurum.EditValue.ToString() : "BILINMIYOR",
                    mezuniyetyili = DTPMezuniyetYil.EditValue != null ? ((DateTime)DTPMezuniyetYil.EditValue).ToString("yyyy") : "BILINMIYOR",
                    mezunbolum = TBMezunBolum.Text,
                    askerlikdurum = CBAskerlikDurum.EditValue != null ? CBOgrenimDurum.EditValue.ToString() : "BILINMIYOR",
                    askerlikbaslangictar = DTPAskerBasTar.EditValue != null ? (DateTime)DTPAskerBasTar.EditValue : Convert.ToDateTime("01.01.1990"),
                    askerlikbitistar = DTPAskerBitTar.EditValue != null ? (DateTime)DTPAskerBitTar.EditValue : Convert.ToDateTime("01.01.1990"),
                    sigortaturkod = CBSigortalilikTur.EditValue != null ? CBSigortalilikTur.EditValue.ToString() : "BILINMIYOR",
                    yaslilikayligi = CBYaslilikAylik.EditValue != null ? CBYaslilikAylik.EditValue.ToString() : "BILINMIYOR",
                    istihdamdurumu = CBIstihtamTuru.EditValue != null ? CBIstihtamTuru.EditValue.ToString() : "BILINMIYOR",
                    meslekkodu = CBMeslekKodu.EditValue != null ? CBMeslekKodu.EditValue.ToString() : "BILINMIYOR",
                    sosyalguvenlikkodu = CBSGKKodu.EditValue != null ? CBSGKKodu.EditValue.ToString() : "BILINMIYOR",
                    babaadi = TBBabaAdi.Text,
                    anneadi = TBAnneAdi.Text,
                    dogumyeri = TBDogumYer.Text,
                    medenidurum = TBMedeniDurum.Text,
                    uyruk = CBUyrugu.EditValue != null ? CBUyrugu.EditValue.ToString() : "BILINMIYOR",
                    ilksoyad = TBIlkSoyad.Text,
                    nufusakayitliil = CBNufIl.EditValue != null ? CBNufIl.EditValue.ToString() : "BILINMIYOR",
                    nufusakayitliilce = CBNufIlce.EditValue != null ? CBNufIlce.EditValue.ToString() : "BILINMIYOR",
                    nufusakayitlimah = TBNufKayitMah.Text,
                    ulke = TBUlke.Text,
                    kangrubu = CBKanGrubu.EditValue != null ? CBKanGrubu.EditValue.ToString() : "BILINMIYOR",
                    ciltno = TBCiltNo.Text,
                    ailesirano = TBAileSıraNo.Text,
                    sirano = TBSiraNo.Text,
                    nufuscuzdanverilistarih = DTPNufVerTar.EditValue != null ? (DateTime)DTPNufVerTar.EditValue : Convert.ToDateTime("01.01.1990"),
                    nufuscuzdanserino = TBNufSeriNo.Text,
                    nufuscuzdankayitno = TBNufKayıtNo.Text,
                    adres = TBAdres.Text,
                    adresmah = TBAdresMahalle.Text,
                    adresil = CBAdresIL.EditValue != null ? CBAdresIL.EditValue.ToString() : "BILINMIYOR",
                    adresilce = CBAdresIlce.EditValue != null ? CBAdresIlce.EditValue.ToString() : "BILINMIYOR",
                    adrespostakodu = TBAdresPostaKodu.Text,
                    vergidairesi = TBVergiDaire.Text,
                    vergino = TBVergiNo.Text,
                    telefon = TBTelefon.Text,
                    cepno = TBCepNo.Text,
                    eposta = TBEposta.Text,
                    bedenolcusu = CBUstBeden.EditValue != null ? Convert.ToByte(CBUstBeden.SelectedIndex) : (byte)0,
                    pantolonolcusu = CBAltBeden.EditValue != null ? Convert.ToByte(CBAltBeden.EditValue) : (byte)0,
                    ayakkabino = CBAyakkabıNo.EditValue != null ? Convert.ToByte(CBAyakkabıNo.EditValue) : (byte)0,



                }) ;
                var ab = _personelServis.obje2;
                MessageBox.Show($"{_personelServis.obje2.id}");
            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurmadan Personel Ekleyemezsiniz!");
            }
        }

   
    }
}
