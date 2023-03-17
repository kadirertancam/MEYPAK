using DevExpress.Text.Interop;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.MUSTAHSIL;
using MEYPAK.PRL.Assets;
using Newtonsoft.Json;
using OPTYPE.HizliTeknoloji;
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

namespace MEYPAK.PRL.MUSTAHSIL
{
    public partial class FMustahsilKart : XtraForm
    {
        public FMustahsilKart()
        {
            InitializeComponent();
            mustahsilServis = new GenericWebServis<PocoMUSTAHSILCARI>();
        }
        GenericWebServis<PocoMUSTAHSILCARI> mustahsilServis;
        public PocoMUSTAHSIL tempMustahsil;
        ADRESOBJECT.Root _adresObje;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (TBTcNo.Text.Length == 11)
            {
                if (TBMustahsilAdi.Text != "" && TBMustahsilSoyad.Text != "")
                {
                    DialogResult dialogResult = tempMustahsil != null ? MessageBox.Show($"{tempMustahsil}'kimlik numaralı müstahsilin bilgilerini güncellemek istediğinize emin misiniz?", "Müstahsil Güncelleme", MessageBoxButtons.YesNo) : MessageBox.Show($"{TBTcNo.Text}'kimlik numaralı yeni bir müstahsil eklemek istediğinize emin misiniz?", "Müstahsil Tanımlama", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        mustahsilServis.Data(ServisList.MustahsilCariEkleServis, new PocoMUSTAHSILCARI()
                        {
                            KOD = BTCariSec.Text,
                            ADI = TBMustahsilAdi.Text,
                            SOYADI = TBMustahsilSoyad.Text,
                            TCNO = TBTcNo.Text,
                            userid = MPKullanici.ID,
                        });
                        MessageBox.Show($"{TBTcNo.Text}'kimlik numaralı müstahsil başarıyla eklendi!");
                    }
                }
                else
                    MessageBox.Show("Gerekli Alanları doldurmadan Müstahsil Ekeleyemezsiniz!");
            }
            else
                MessageBox.Show("TC Kimlik numarası 11 karakterden oluşmalı ve sadece rakamlardan oluşmalıdır.");
        }

        private void FMustahsilKart_Load(object sender, EventArgs e)
        {
            IlIlceDoldur();
        }

        void IlIlceDoldur()
        {
            string url = @"https://elizmeypak.com.tr/il-ilce.json";


            using (Stream s = GetStreamFromUrl(url))
            using (StreamReader sr = new StreamReader(s))
                while (!sr.EndOfStream)
                {
                    _adresObje = JsonConvert.DeserializeObject<ADRESOBJECT.Root>(sr.ReadToEnd());
                }
            CBIl.Properties.DataSource = _adresObje.data.Select(x => x.il_adi);

        }
        private static Stream GetStreamFromUrl(string url)
        {
            byte[] imageData = null;

            using (var wc = new System.Net.WebClient())
                imageData = wc.DownloadData(url);

            return new MemoryStream(imageData);
        }

        private void CBIl_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BTSorgula_Click(object sender, EventArgs e)
        {
            mukellefsorgula sorgulama = new mukellefsorgula();
            MukellefOutput resp = sorgulama.sorgu(TBTcNo.Text);
            TBMustahsilAdi.Text = resp.mukellef.ad;
            TBMustahsilSoyad.Text = resp.mukellef.soyad;
        }

        private void CBIl_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (CBIl.EditValue != null)
                CBIlce.Properties.DataSource = _adresObje.data.Where(x => x.il_adi == CBIl.EditValue).Select(x => x.ilceler.Select(z => z.ilce_adi).ToList()).FirstOrDefault();
        }
    }
}
