using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
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
    public partial class FCariKart : Form
    {
        public FCariKart()
        {
            InitializeComponent();
            _adresListServis = new GenericWebServis<ADRESLIST>();
            _cariServis = new GenericWebServis<PocoCARIKART>();

        }
        GenericWebServis<ADRESLIST> _adresListServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        FCariList _fCariList;
        public PocoCARIKART _tempCariKart;

        void doldur()
        {
            TBAciklama.Text = _tempCariKart.ACIKLAMA;
            TBAciklama1.Text = _tempCariKart.ACIKLAMA1;
            TBAciklama2.Text = _tempCariKart.ACIKLAMA2;
            TBAciklama3.Text = _tempCariKart.ACIKLAMA3;
            TBAciklama4.Text = _tempCariKart.ACIKLAMA4;
            TBAciklama5.Text = _tempCariKart.ACIKLAMA5;
            TBAciklama6.Text = _tempCariKart.ACIKLAMA6;
            TBAciklama7.Text = _tempCariKart.ACIKLAMA7;
            TBAciklama8.Text = _tempCariKart.ACIKLAMA8;
            TBAciklama9.Text = _tempCariKart.ACIKLAMA9;
            TBCariAdi.Text = _tempCariKart.ADI;
            TBCariSoyadi.Text = _tempCariKart.SOYADI;
            TBAdres.Text = _tempCariKart.ADRES;
            TBAMuhKodu.Text = _tempCariKart.AMUHKOD;
            TBApt.Text = _tempCariKart.APT;
            TBCepTel.Text = _tempCariKart.CEPTEL;
            TBDaire.Text = _tempCariKart.DAIRE;
            TBEposta.Text = _tempCariKart.EPOSTA;
            TBFax.Text = _tempCariKart.FAX;
            TBGrupKodu.Text = _tempCariKart.GRUPKODU;
            CBil.Text = _tempCariKart.IL;
            CBilce.Text = _tempCariKart.ILCE;
            TBKategori.Text = _tempCariKart.KATEGORI;
            TBCariKodu.Text = _tempCariKart.KOD;
            TBMahalle.Text = _tempCariKart.MAHALLE;
            TBMuhKod.Text = _tempCariKart.MUH_KOD;
            TBPostaKodu.Text = _tempCariKart.POSTAKOD;
            TBRaporKodu1.Text = _tempCariKart.RAPORKOD1;
            TBRaporKodu2.Text = _tempCariKart.RAPORKOD2;
            TBRaporKodu3.Text = _tempCariKart.RAPORKOD3;
            TBRaporKodu4.Text = _tempCariKart.RAPORKOD4;
            TBRaporKodu5.Text = _tempCariKart.RAPORKOD5;
            TBRaporKodu6.Text = _tempCariKart.RAPORKOD6;
            TBRaporKodu7.Text = _tempCariKart.RAPORKOD7;
            TBRaporKodu8.Text = _tempCariKart.RAPORKOD8;
            TBRaporKodu9.Text = _tempCariKart.RAPORKOD9;
            NUDSAciklama1.Value = _tempCariKart.SACIKLAMA1;
            NUDSAciklama2.Value  = _tempCariKart.SACIKLAMA2;
            NUDSAciklama3.Value  = _tempCariKart.SACIKLAMA3;
            NUDSAciklama4.Value  = _tempCariKart.SACIKLAMA4;
            NUDSAciklama5.Value  = _tempCariKart.SACIKLAMA5;
            NUDSAciklama6.Value  = _tempCariKart.SACIKLAMA6;
            NUDSAciklama7.Value  = _tempCariKart.SACIKLAMA7;
            NUDSAciklama8.Value  = _tempCariKart.SACIKLAMA8;
            NUDSAciklama9.Value  = _tempCariKart.SACIKLAMA9;
            TBSMuhKodu.Text = _tempCariKart.SMUHKOD;
            TBSokak.Text = _tempCariKart.SOKAK;
            TBTc.Text = _tempCariKart.TCNO;
            TBTelefon1.Text = _tempCariKart.TELEFON;
            TBTelefon2.Text = _tempCariKart.TELEFON2;
            CBTipi.SelectedIndex = _tempCariKart.TIPI;
            TBUnvan.Text = _tempCariKart.UNVAN;
            TBVadeGunu.Text = _tempCariKart.VADEGUNU.ToString();
            CBVDaire.Text = _tempCariKart.VERGIDAIRESI;
            TBVNo.Text = _tempCariKart.VERGINO;
            TBWebSite.Text = _tempCariKart.WEB;
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        ADRESOBJECT.Root _adresObje;
        private void FCariKart_Load(object sender, EventArgs e)
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

        private void BTKaydet_Click(object sender, EventArgs e)
        {

            _cariServis.Data(ServisList.CariEkleServis, new PocoCARIKART()
            {
                ACIKLAMA = TBAciklama.Text,
                ACIKLAMA1 = TBAciklama1.Text,
                ACIKLAMA2 = TBAciklama2.Text,
                ACIKLAMA3 = TBAciklama3.Text,
                ACIKLAMA4 = TBAciklama4.Text,
                ACIKLAMA5 = TBAciklama5.Text,
                ACIKLAMA6 = TBAciklama6.Text,
                ACIKLAMA7 = TBAciklama7.Text,
                ACIKLAMA8 = TBAciklama8.Text,
                ACIKLAMA9 = TBAciklama9.Text,
                ADI = TBCariAdi.Text,
                SOYADI = TBCariSoyadi.Text,
                ADRES = TBAdres.Text,
                AMUHKOD = TBAMuhKodu.Text,
                APT = TBApt.Text,
                CEPTEL = TBCepTel.Text,
                DAIRE = TBDaire.Text,
                EPOSTA = TBEposta.Text,
                FAX = TBFax.Text,
                GRUPKODU = TBGrupKodu.Text,
                IL = CBil.Text,
                ILCE = CBilce.Text,
                KATEGORI = TBKategori.Text,
                KOD = TBCariKodu.Text,
                MAHALLE = TBMahalle.Text,
                MUH_KOD = TBMuhKod.Text,
                POSTAKOD = TBPostaKodu.Text,
                RAPORKOD1 = TBRaporKodu1.Text,
                RAPORKOD2 = TBRaporKodu2.Text,
                RAPORKOD3 = TBRaporKodu3.Text,
                RAPORKOD4 = TBRaporKodu4.Text,
                RAPORKOD5 = TBRaporKodu5.Text,
                RAPORKOD6 = TBRaporKodu6.Text,
                RAPORKOD7 = TBRaporKodu7.Text,
                RAPORKOD8 = TBRaporKodu8.Text,
                RAPORKOD9 = TBRaporKodu9.Text,
                SACIKLAMA1 = int.Parse(NUDSAciklama1.Value.ToString()),
                SACIKLAMA2 = int.Parse(NUDSAciklama2.Value.ToString()),
                SACIKLAMA3 = int.Parse(NUDSAciklama3.Value.ToString()),
                SACIKLAMA4 = int.Parse(NUDSAciklama4.Value.ToString()),
                SACIKLAMA5 = int.Parse(NUDSAciklama5.Value.ToString()),
                SACIKLAMA6 = int.Parse(NUDSAciklama6.Value.ToString()),
                SACIKLAMA7 = int.Parse(NUDSAciklama7.Value.ToString()),
                SACIKLAMA8 = int.Parse(NUDSAciklama8.Value.ToString()),
                SACIKLAMA9 = int.Parse(NUDSAciklama9.Value.ToString()),
                SMUHKOD = TBSMuhKodu.Text,
                SOKAK = TBSokak.Text,
                TCNO = TBTc.Text,
                TELEFON = TBTelefon1.Text,
                TELEFON2 = TBTelefon2.Text,
                TIPI = CBTipi.SelectedIndex,
                UNVAN = TBUnvan.Text,
                VADEGUNU = int.Parse(TBVadeGunu.Text),
                VERGIDAIRESI = CBVDaire.Text,
                VERGINO = TBVNo.Text,
                WEB = TBWebSite.Text,

            });


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
            _fCariList = new FCariList(this.Tag.ToString(),"carikart");
            _fCariList.ShowDialog();
            if(_tempCariKart!=null)
            doldur();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

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

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBSevkAdres_SelectedIndexChanged(object sender, EventArgs e)
        {

                
        }
    }
}
