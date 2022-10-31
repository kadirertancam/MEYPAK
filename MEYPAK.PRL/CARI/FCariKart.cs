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
               ACIKLAMA=TBAciklama.Text,
               ACIKLAMA1=TBAciklama1.Text,
               ACIKLAMA2=TBAciklama2.Text,
               ACIKLAMA3=TBAciklama3.Text,
               ACIKLAMA4=TBAciklama4.Text,
               ACIKLAMA5=TBAciklama5.Text,
               ACIKLAMA6=TBAciklama6.Text,
               ACIKLAMA7=TBAciklama7.Text,
               ACIKLAMA8=TBAciklama8.Text,
               ACIKLAMA9=TBAciklama9.Text,
               RAPORKOD1=TBRaporKodu1.Text,
               RAPORKOD2=TBRaporKodu2.Text,
               RAPORKOD3=TBRaporKodu3.Text,
               RAPORKOD4=TBRaporKodu4.Text,
            });

        }

        private void CBil_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CBil_TextChanged(object sender, EventArgs e)
        {
            CBilce.DataSource = _adresObje.data.Where(x => x.il_adi == CBil.SelectedValue).Select(x => x.ilceler.Select(z=>z.ilce_adi).ToList()).FirstOrDefault();
        }

        private void CBilce_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
