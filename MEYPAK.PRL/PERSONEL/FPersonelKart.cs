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
            DataTable dt = new DataTable();
          
            CBDepartman.Properties.DataSource = _personelDepartmanServis.obje;
           // CBDepartman.Properties.Columns["adi"].Visible = false;

            _personelGorevServis.Data(ServisList.PersonelGorevListeServis);
            CBGorev.Properties.DataSource = _personelGorevServis.obje.Select(x=> new { x.id, x.adi }); 

            foreach (var item in _personelGorevServis.obje)
            {
                
                CBKanGrubu.Properties.Items.Add(item.adi);
            }

            string path = Application.StartupPath + "/il-ilce.json";
            using (FileStream s = File.Open(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {

                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());


                    CBAdresIL.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);
                    
                }


        }


        
        private void BTSPersonelBanka_Click(object sender, EventArgs e)
        {
            if (TBBankaAdi.EditValue!=null && TBBankaSubeAdi.EditValue!=null && TBBankaSubeKod.EditValue!=null && TBBankaIban.EditValue!=null)
            {
                _personelBankaServis.Data(ServisList.PersonelBankaEkleServis, new PocoPERSONELBANKA()
                {
                    bankaadi = TBBankaAdi.EditValue.ToString(),
                    bankasubeadi = TBBankaSubeAdi.EditValue.ToString(),
                    bankasubekodu = TBBankaSubeKod.EditValue.ToString(),
                    ibanno = TBBankaIban.EditValue.ToString(),
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
            CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBAdresIL.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }

        private void BTNZimKaydet_Click(object sender, EventArgs e)
        {
            if (TBZimMarka.EditValue!=null && TBZimMiktar.EditValue!=null && DTPZimBasTar.EditValue!=null && TBZimSeriNo.EditValue!=null&& TBZimAciklama.EditValue!=null)
            {
                _personelZimmetServis.Data(ServisList.PersonelZimmetlEkleServis, new PocoPERSONELZIMMET()
                {
                    serino = TBZimSeriNo.EditValue.ToString(),
                    zimmettarihi =(DateTime) DTPZimBasTar.EditValue,
                    markamodel = TBZimMarka.EditValue.ToString(),
                    miktar =Convert.ToInt32( TBZimMiktar.EditValue),
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
            var a = CBCinsiyet.EditValue;
            if (TBTCNO.EditValue!=null && TBAdi.EditValue!=null && TBSoyadi.EditValue!=null  && DTPIseGirisTar.EditValue!=null&& CBCinsiyet.EditValue!=null && DTPDogumTar.EditValue!=null)
            {
                string az = " ";
                _personelServis.Data(ServisList.PersonelEkleServis, new PocoPERSONEL()
                {
                    subeid = 0,
                    sirketid = 0,
                    tc = TBTCNO.Text,
                    adi = TBAdi.Text,
                    soyadi = TBSoyadi.Text,
                    cinsiyet =Convert.ToByte(CBCinsiyet.SelectedIndex),
                    adres = TBBabaAdi.Text
                  //  adresilce = TBBabaAdi.EditValue != null ? TBBabaAdi.EditValue.ToString() : " "


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
