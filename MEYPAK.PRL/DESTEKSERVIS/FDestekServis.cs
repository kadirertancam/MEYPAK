using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.DESTEKSERVIS;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Stok;
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

namespace MEYPAK.PRL.DESTEKSERVIS
{
    public partial class FDestekServis : XtraForm
    {
        string islemtipi = "Kayıt";

        public FDestekServis()
        {
            InitializeComponent();
            _destekServisServis = new GenericWebServis<PocoDestekServis>();
            _personelDepartmanServis = new GenericWebServis<PocoPERSONELDEPARTMAN>();
            CombolarıDoldur();
        }

        #region Tanımlar
        GenericWebServis<PocoDestekServis> _destekServisServis;
        GenericWebServis<PocoPERSONELDEPARTMAN> _personelDepartmanServis;
        Main main;
        #endregion

        #region Metotlar

        private void FDestekServis_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            main = (Main)Application.OpenForms["Main"];
        }
        int id;
        void PersonelDepartmanComboDoldur()
        {
            _personelDepartmanServis.Data(ServisList.PersonelDepartmanListeServis);
            CBDepartman.Properties.DataSource = _personelDepartmanServis.obje.Where(x => x.kayittipi == 0).Select(x => new { DEPARTMAN = x.adi });
            CBDepartman.Properties.ValueMember = "DEPARTMAN";
            CBDepartman.Properties.DisplayMember = "DEPARTMAN";
        }
        void CombolarıDoldur()
        {
            PersonelDepartmanComboDoldur();
        }

        void DataGridDoldur()
        {
            _destekServisServis.Data(ServisList.DestekServisListeServis);
            _personelDepartmanServis.Data(ServisList.PersonelDepartmanListeServis);
            DGDestekServis.DataSource = _destekServisServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                AD = x.ad,
                SOYAD = x.soyad,
                DEPARTMAN = x.departman,
                BAŞLIK = x.baslik,
                MESAJ = x.mesaj,
                ÖNCELİK = x.oncelik,
                // x.durum == false ? "Beklemede" : "Tamamlandı",
                BELGE = x.belge

            });
            DGDestekServis.Refresh();
            DGDestekServis.RefreshDataSource();
        }

        private void BTDestekTalebi_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.DESTEKSERVIS.ToString()).EKLE)
            {
                if (islemtipi == "Kayıt")
                {
                    _destekServisServis.Data(ServisList.DestekServisEkleServis, (new PocoDestekServis()
                    {
                        ad = TBAd.Text,
                        soyad = TBSoyad.Text,
                        baslik = TBBaslik.Text,
                        departman = CBDepartman.EditValue.ToString(),
                        oncelik = CBOncelik.EditValue.ToString(),
                        mesaj = TBMesaj.Text,
                        belge = b64string,
                        userid = MPKullanici.ID,
                    })); ;

                }
                else
                    _destekServisServis.Data(ServisList.DestekServisEkleServis, (new PocoDestekServis()
                    {
                        ad = TBAd.Text,
                        soyad = TBSoyad.Text,
                        baslik = TBBaslik.Text,
                        departman = CBDepartman.EditValue.ToString(),
                        oncelik = CBOncelik.EditValue.ToString(),
                        mesaj = TBMesaj.Text,
                        belge = b64string,
                        userid = MPKullanici.ID,
                    }));
                MessageBox.Show("Kayıt Başarılı.");
                id = 0;
                DataGridDoldur();
            }

            else
                MessageBox.Show(MPKullanici.hata);
        }

        #endregion

        string base64 = "";
        private void BTDosyaYukle_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Jpeg Dosyası |*.jpeg| Jpg Dosyası|*.jpg| PNG Dosyası|*.png| ICO Dosyası|*.ico";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = ofd.FileName;
                    string DosyaAdi = ofd.SafeFileName;
                    BTDosyaYukle.Text = DosyaYolu;
                    //  DosyaYolu.Doc = new Bitmap(DosyaYolu);
                    base64 = ImageToBase64(DosyaYolu);
                }
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

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "ÖNCELİK"));
            //Öncelikli
            //Orta
            //Düşük
            if (quantity == "Öncelikli")
            {
                e.Appearance.BackColor = Color.Red;
            }
            else if(quantity == "Orta")
            {
                e.Appearance.BackColor = Color.Yellow;
            }
            else
            {
                e.Appearance.BackColor = Color.Green;
            }
        }


    }

}
