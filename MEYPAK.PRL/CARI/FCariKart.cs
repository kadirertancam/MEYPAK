using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.PRL.STOK;
using Newtonsoft.Json;
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
            

        }
        GenericWebServis<ADRESLIST> _adresListServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        FCariList _fCariList;
        
        public PocoCARIKART _tempCariKart;

        void doldur()
        {
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
            TBCariSoyadi.Text = _tempCariKart.soyadi;
            TBAdres.Text = _tempCariKart.adres;
            TBAMuhKodu.Text = _tempCariKart.amuhkod;
            TBApt.Text = _tempCariKart.apt;
            TBCepTel.Text = _tempCariKart.ceptel;
            TBDaire.Text = _tempCariKart.daire;
            TBEposta.Text = _tempCariKart.eposta;
            TBFax.Text = _tempCariKart.fax;
            TBGrupKodu.Text = _tempCariKart.grupkodu;
            CBil.Text = _tempCariKart.il;
            CBilce.Text = _tempCariKart.ilce;
            TBKategori.Text = _tempCariKart.kategori;
            TBCariKodu.Text = _tempCariKart.kod;
            TBMahalle.Text = _tempCariKart.mahalle;
            TBMuhKod.Text = _tempCariKart.muH_KOD;
            TBPostaKodu.Text = _tempCariKart.postakod;
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
            TBSMuhKodu.Text = _tempCariKart.smuhkod;
            TBSokak.Text = _tempCariKart.sokak;
            TBTc.Text = _tempCariKart.tcno;
            TBTelefon1.Text = _tempCariKart.telefon;
            TBTelefon2.Text = _tempCariKart.telefoN2;
            CBTipi.SelectedIndex = _tempCariKart.tipi;
            TBUnvan.Text = _tempCariKart.unvan;
            TBVadeGunu.Text = _tempCariKart.vadegunu.ToString();
            CBVDaire.Text = _tempCariKart.vergidairesi;
            TBVNo.Text = _tempCariKart.vergino;
            TBWebSite.Text = _tempCariKart.web;
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


                    CBil.DataSource = _adresObje.data.Select(x => x.il_adi).ToList();
                }

           
        }

       

        private void CBil_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CBil_TextChanged(object sender, EventArgs e)
        {
            CBilce.DataSource = _adresObje.data.Where(x => x.il_adi == CBil.SelectedValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }

        private void CBilce_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            _cariServis.Data(ServisList.CariSilServis, null, null);
        }

        private void BTCariSec_Click(object sender, EventArgs e)
        {
        

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _fCariList = new FCariList(this.Tag.ToString(), "carikart");
            _fCariList.ShowDialog();
            if (_tempCariKart != null)
                doldur();
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

       

        private void TBSevkAdres_SelectedIndexChanged(object sender, EventArgs e)
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
                soyadi = TBCariSoyadi.Text,
                adres = TBAdres.Text,
                amuhkod = TBAMuhKodu.Text,
                apt = TBApt.Text,
                ceptel = TBCepTel.Text,
                daire = TBDaire.Text,
                eposta = TBEposta.Text,
                fax = TBFax.Text,
                grupkodu = TBGrupKodu.Text,
                il = CBil.Text,
                ilce = CBilce.Text,
                kategori = TBKategori.Text,
                kod = TBCariKodu.Text,
                mahalle = TBMahalle.Text,
                muH_KOD = TBMuhKod.Text,
                postakod = TBPostaKodu.Text,
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
                smuhkod = TBSMuhKodu.Text,
                sokak = TBSokak.Text,
                tcno = TBTc.Text,
                telefon = TBTelefon1.Text,
                telefoN2 = TBTelefon2.Text,
                tipi = CBTipi.SelectedIndex,
                unvan = TBUnvan.Text,
                vadegunu = int.Parse(TBVadeGunu.Text),
                vergidairesi = CBVDaire.Text,
                vergino = TBVNo.Text,
                web = TBWebSite.Text,

            });


        }

        private void BTKoduSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Caption == "Yeni")
            {

                XtraTabPage page = new XtraTabPage(); 
                FCariAltHesap fCariAltHesap = new FCariAltHesap();
                Main main = (Main)Application.OpenForms["Main"];
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
               
            }
          }

      
    }
}
