using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Tile;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Stok;
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

namespace MEYPAK.PRL.ARAÇLAR
{
    public partial class FAracTanim : XtraForm
    {
        GenericWebServis<PocoARAC> _aracServis;
        GenericWebServis<PocoARACRUHSATRESIM> _aracServisRUHSATRESIMServis;
        GenericWebServis<PocoARACMUAYENERESIM> _aracMuayeneServis;
        GenericWebServis<PocoARACSIGORTARESIM> _aracSigortaServis;
        GenericWebServis<PocoARACKASKORESIM> _aracKaskoServis;
        GenericWebServis<PocoARACMODEL> _aracModelServis;
        GenericWebServis<PocoPERSONEL> _personelServis;
        GenericWebServis<PocoPERSONELGOREV> _personelgorevServis;
        GenericWebServis<PocoPERSONELDEPARTMAN> _personeldepartmanServis;
        public FAracTanim()
        {
            _personeldepartmanServis = new GenericWebServis<PocoPERSONELDEPARTMAN>();
            _personelServis = new GenericWebServis<PocoPERSONEL>();
            _personelgorevServis = new GenericWebServis<PocoPERSONELGOREV>();
            _aracSigortaServis = new GenericWebServis<PocoARACSIGORTARESIM>();
            _aracKaskoServis = new GenericWebServis<PocoARACKASKORESIM>();
            _aracMuayeneServis = new GenericWebServis<PocoARACMUAYENERESIM>();
            _aracServisRUHSATRESIMServis = new GenericWebServis<PocoARACRUHSATRESIM>();
            _aracModelServis = new GenericWebServis<PocoARACMODEL>();
            _aracServis = new GenericWebServis<PocoARAC>();
            InitializeComponent();
            AraclarıGetir();
            CombolarıDoldur();
        }
        PocoARAC _tempArac;
        string base64 = "";
        string base64pdf = "";
        string b64string = "";

        #region Method
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

        void AraclarıGetir()
        {
            _aracServis.Data(ServisList.AracListeServis);
            GCAraclar.DataSource = _aracServis.obje.Select(x => new { PLAKA = x.plaka, MARKA = x.marka, MODEL = x.model, ID = x.id });
            gridView1.Columns["ID"].Visible = false;
        }
        void ResimleriGetir()
        {
            RuhsatResimleriGetir();
        }

        void AracBilgileriniDoldur()
        {
            if (_tempArac != null && _tempArac.id != 0)
            {
                TBPlaka.Text = _tempArac.plaka;
                CBTip.EditValue = _tempArac.tip;
                CBMarka.EditValue = _aracModelServis.obje.Where(x => x.id == Convert.ToInt32(_tempArac.marka)).FirstOrDefault().id;
                CBModel.EditValue = _tempArac.model;
                CBYakitTuru.EditValue = _tempArac.yakitturu;
                CBSofor1.EditValue = _tempArac.soforid;
                CBSofor2.EditValue = _tempArac.sofor2id;
                RGAracDurum.SelectedIndex = _tempArac.durum;
                NUDTekerSayisi.Value = _tempArac.tekersayisi;
                NUDYedekTekerSayisi.Value = _tempArac.yedektekersayisi;
                RuhsatResimleriGetir();
                SigordaGridDoldur();
                KaskoGridDoldur();
                MuayeneGridDoldur();
            }


        }
        void MuayeneGridDoldur()
        {
            _aracMuayeneServis.Data(ServisList.AracMuayeneResimListeFiltreServis, parameters: $"query=ARACID={_tempArac.id}");
            GridMuayene.DataSource = _aracMuayeneServis.obje.Select(x => new { BAŞLANGIÇ = x.muayenebastar, BİTİŞ = x.muayenebittar, EGZOZBAŞLANGIÇ = x.egzozbastar, EGZOZBİTİŞ = x.egzozbittar, ID = x.id });
            gridViewMuayene.Columns["ID"].Visible = false;
        }
        void KaskoGridDoldur()
        {

            _aracKaskoServis.Data(ServisList.AracKaskoResimListeFiltreServis, parameters: $"query=ARACID={_tempArac.id}");
            GridKasko.DataSource = _aracKaskoServis.obje.Select(x => new { POLICENO = x.kaspoliceno, BAŞLANGIÇ = x.kasbastar, BİTİŞ = x.kasbittar, ID = x.id });
            gridViewKasko.Columns["ID"].Visible = false;
        }
        void SigordaGridDoldur()
        {
            _aracSigortaServis.Data(ServisList.AracSigortaResimListeFiltreServis, parameters: $"query=ARACID={_tempArac.id}");
            GridSigorta.DataSource = _aracSigortaServis.obje.Select(x => new { POLICENO = x.sigpoliceno, BAŞLANGIÇ = x.sigbastar, BİTİŞ = x.sigbittar, ID = x.id });
            gridViewSigorta.Columns["ID"].Visible = false;
        }
        void RuhsatResimleriGetir()
        {
            _aracServisRUHSATRESIMServis.Data(ServisList.AracRuhsatResimListeFiltreServis, parameters: $"query=ARACID={_tempArac.id}");
            GridRuhsat.DataSource = _aracServisRUHSATRESIMServis.obje.Where(x => x.aracid == _tempArac.id).Select(x => new { Resim = Base64ToImage(x.img), NUM = x.num });

        }

        void CombolarıDoldur()
        {
            _aracModelServis.Data(ServisList.AracModelListeServis);


            CBMarka.Properties.DataSource = (from temp in _aracModelServis.obje group temp by temp.markaadi into temp select new { ADI = temp.FirstOrDefault().markaadi, ID = temp.FirstOrDefault().id }).OrderBy(x => x.ADI);
            CBMarka.Properties.ValueMember = "ID";
            CBMarka.Properties.DisplayMember = "ADI";


            _personelServis.Data(ServisList.PersonelListeServis);
            _personeldepartmanServis.Data(ServisList.PersonelDepartmanListeServis); //.Where(x => x.personeldepartmanid == _personeldepartmanServis.obje.Where(x => x.adi == "LOJİSTİK").FirstOrDefault().id)

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("ADI");

            foreach (var item in _personelServis.obje.Where(x => x.personeldepartmanid == _personeldepartmanServis.obje.Where(x => x.adi == "LOJİSTİK").FirstOrDefault().id))
            {
                dt.Rows.Add(item.id, item.adisoyadi);
            }

            dt.Columns[0].ColumnMapping = MappingType.Hidden;

            CBSofor1.Properties.DataSource = dt;
            CBSofor1.Properties.DisplayMember = "ADI";
            CBSofor1.Properties.ValueMember = "ID";

            CBSofor2.Properties.DataSource = dt;
            CBSofor2.Properties.ValueMember = "ID";
            CBSofor2.Properties.DisplayMember = "ADI";

        }
        #endregion




        #region Events
        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void BTNAracKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.ARACTANIM.ToString()).EKLE)

            {
                if (TBPlaka.Text != null && CBTip.EditValue != null && CBMarka.EditValue != null && CBModel.EditValue != null && CBYakitTuru.EditValue != null && CBSofor1.EditValue != null)
                {
                    _aracServis.Data(ServisList.AracEkleServis, new PocoARAC()
                    {
                        id = _tempArac != null && _tempArac.id != 0 ? _tempArac.id : 0,
                        plaka = TBPlaka.Text,
                        tip = CBTip.EditValue != null ? CBTip.EditValue.ToString() : "BILINMIYOR",
                        marka = CBMarka.EditValue != null ? CBMarka.EditValue.ToString() : "BILINMIYOR",
                        model = CBModel.EditValue != null ? CBModel.EditValue.ToString() : "BILINMIYOR",
                        yakitturu = TBPlaka.Text,
                        soforid = CBSofor1.EditValue != null ? Convert.ToInt32(CBSofor1.EditValue) : 0,
                        sofor2id = CBSofor2.EditValue != null ? Convert.ToInt32(CBSofor2.EditValue) : 0,
                        durum = (byte)RGAracDurum.SelectedIndex,
                        tekersayisi = (byte)NUDTekerSayisi.Value,
                        yedektekersayisi = (byte)NUDYedekTekerSayisi.Value,
                        userid = MPKullanici.ID
                    });
                    _tempArac = _aracServis.obje2;
                    MessageBox.Show($"{_tempArac.plaka} plakalı araç başarıyla güncellendi");
                    AraclarıGetir();
                }
                else
                {
                    MessageBox.Show("Araca ait zorunlu alanların tamamının doldurulması gerekir!");
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void BTNSigortaKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.ARACTANIM.ToString()).GUNCELLE)
            {
                if (_tempArac != null && _tempArac.id != 0)
                {
                    if (TBSigAcenteAdi.Text != null && TBSigPoliceNo.Text != null && DTPSigPolBasTar.EditValue != null && DTPSigPolBitTar.EditValue != null)
                    {
                        _aracSigortaServis.Data(ServisList.AracSigortaResimEkleServis, new PocoARACSIGORTARESIM()
                        {
                            aracid = _tempArac.id,
                            sigacenteadi = TBSigAcenteAdi.Text,
                            sigpoliceno = TBSigPoliceNo.Text,
                            sigbastar = (DateTime)DTPSigPolBasTar.EditValue,
                            sigbittar = (DateTime)DTPSigPolBitTar.EditValue,
                            img = BTSigortaBelgeSec.Text != "" ? BTSigortaBelgeSec.Text.Substring(BTSigortaBelgeSec.Text.Length - 3, 3) != "pdf" ?
                            ImageToBase64(BTSigortaBelgeSec.Text) : Convert.ToBase64String(File.ReadAllBytes(BTSigortaBelgeSec.Text)) : "",
                            dosyatip = BTSigortaBelgeSec.Text.Substring(BTSigortaBelgeSec.Text.Length - 4, 4).Replace(".", ""),
                            userid = MPKullanici.ID,
                        });

                        MessageBox.Show($"{_tempArac.plaka} plakalı araca sigorta bilgileri eklenmiştir.");
                        TBSigAcenteAdi.Text = "";
                        TBSigPoliceNo.Text = "";
                        DTPSigPolBasTar.EditValue = null;
                        DTPSigPolBitTar.EditValue = null;
                        BTSigortaBelgeSec.Text = "";
                        SigordaGridDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Sigorta eklemek için gerekli sigorta alanlarını doldurmanız gerekmektedir!");
                    }
                }
                else
                {
                    MessageBox.Show("Sigorta bilgileri girilecek Araç seçilmedi!");
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void BTNKaskoKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.ARACTANIM.ToString()).GUNCELLE)
            {

                if (_tempArac != null && _tempArac.id != 0)
                {
                    if (TBKasAcenteAdi.Text != null && TBKasPoliceNo.Text != null && DTPKasPolBasTar.EditValue != null && DTPKasPolBitTar != null)
                    {
                        _aracKaskoServis.Data(ServisList.AracKaskoResimEkleServis, new PocoARACKASKORESIM()
                        {
                            aracid = _tempArac.id,
                            kasacenteadi = TBKasAcenteAdi.Text,
                            kaspoliceno = TBKasPoliceNo.Text,
                            kasbastar = (DateTime)DTPKasPolBasTar.EditValue,
                            kasbittar = (DateTime)DTPKasPolBitTar.EditValue,
                            img = BTKaskoBelgeSec.Text != "" ? BTKaskoBelgeSec.Text.Substring(BTKaskoBelgeSec.Text.Length - 3, 3) != "pdf" ?
                            ImageToBase64(BTKaskoBelgeSec.Text) : Convert.ToBase64String(File.ReadAllBytes(BTKaskoBelgeSec.Text)) : "",
                            dosyatip = BTKaskoBelgeSec.Text.Substring(BTKaskoBelgeSec.Text.Length - 4, 4).Replace(".", ""),
                            userid = MPKullanici.ID,
                        });
                        TBKasAcenteAdi.Text = "";
                        TBKasPoliceNo.Text = "";
                        DTPKasPolBasTar.EditValue = null;
                        DTPKasPolBitTar.EditValue = null;
                        BTKaskoBelgeSec.Text = "";
                        MessageBox.Show($"{_tempArac.plaka} plakalı araca sigorta bilgileri eklenmiştir.");
                        KaskoGridDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Kasko eklemek için gerekli kasko alanlarını dolurmanız gerekmekte!");
                    }
                }
                else
                {
                    MessageBox.Show("Sigorta bilgileri girilecek Araç seçilmedi!");
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {//Ruhsat
            if (MPKullanici.YetkiGetir(AllForms.ARACTANIM.ToString()).GUNCELLE)
            {
                if (_tempArac != null && _tempArac.id != 0)
                {
                    _aracServisRUHSATRESIMServis.Data(ServisList.AracRuhsatResimListeServis);
                    _aracServisRUHSATRESIMServis.Data(ServisList.AracRuhsatResimEkleServis, new PocoARACRUHSATRESIM()
                    {
                        aracid = _tempArac.id,
                        num = _aracServisRUHSATRESIMServis.obje.Count == 0 ? 0 : _aracServisRUHSATRESIMServis.obje.Where(x => x.aracid == _tempArac.id).Last().num != 0 ? 0 : _aracServisRUHSATRESIMServis.obje.Where(x => x.aracid == _tempArac.id).Last().num + 1,
                        img = BTNRuhsatSec.Text != "" ? BTNRuhsatSec.Text.Substring(BTNRuhsatSec.Text.Length - 3, 3) != "pdf" ?
                            ImageToBase64(BTNRuhsatSec.Text) : Convert.ToBase64String(File.ReadAllBytes(BTNRuhsatSec.Text)) : "",
                        userid = MPKullanici.ID,
                        dosyatip = BTNRuhsatSec.Text.Length > 4 ? BTNRuhsatSec.Text.Substring(BTNRuhsatSec.Text.Length - 4, 4).Replace(".", "") : "",

                    });
                    MessageBox.Show($"{_tempArac.plaka} plakalı araca ait ruhsat bilgileri başarıyla eklenmiştir.");
                    BTNRuhsatSec.Text = "";
                    RuhsatResimleriGetir();
                }
                else
                {
                    MessageBox.Show("Ruhsat bilgileri girilecek Araç seçilmedi!");
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }
        private void BTNMuayeneKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.ARACTANIM.ToString()).GUNCELLE)
            {
                if (_tempArac != null && _tempArac.id != 0)
                {
                    if (DTPMuayeneBasTar.EditValue != null & DTPMuayeneBitTar.EditValue != null & DTPEgzozBitTar.EditValue != null & DTPEgzozBasTar.EditValue != null)
                    {
                        _aracMuayeneServis.Data(ServisList.AracMuayeneResimEkleServis, new PocoARACMUAYENERESIM()
                        {
                            aracid = _tempArac.id,
                            muayenebastar = (DateTime)DTPMuayeneBasTar.EditValue,
                            muayenebittar = (DateTime)DTPMuayeneBitTar.EditValue,
                            egzozbastar = (DateTime)DTPEgzozBasTar.EditValue,
                            egzozbittar = (DateTime)DTPEgzozBitTar.EditValue,
                            img = BTMuayeneBelgeSec.Text != "" ? BTMuayeneBelgeSec.Text.Substring(BTMuayeneBelgeSec.Text.Length - 3, 3) != "pdf" ?
                            ImageToBase64(BTMuayeneBelgeSec.Text) : Convert.ToBase64String(File.ReadAllBytes(BTMuayeneBelgeSec.Text)) : "",
                            dosyatip = BTMuayeneBelgeSec.Text.Length > 4 ? BTMuayeneBelgeSec.Text.Substring(BTMuayeneBelgeSec.Text.Length - 4, 4).Replace(".", "") : "",
                            userid = MPKullanici.ID,
                        });
                        DTPMuayeneBasTar.EditValue = null;
                        DTPMuayeneBitTar.EditValue = null;
                        DTPEgzozBasTar.EditValue = null;
                        DTPEgzozBitTar.EditValue = null;
                        BTMuayeneBelgeSec.Text = "";
                        MessageBox.Show($"{_tempArac.plaka} plakalı araca muayene bilgileri başarıyla eklenmiştir.");
                        MuayeneGridDoldur();
                    }
                    else
                        MessageBox.Show("Gerekli alanları lütfen doldurunuz!");
                }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }


        private void buttonEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //ruhsat dosya seç click
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Resim Dosyaları (*.jpg, *.png, *.jpeg, *.ico)|*.jpg;*.png;*.jpeg;*.ico";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BTNRuhsatSec.Text = ofd.FileName;
                }
            }
        }


        private void CBMarka_EditValueChanged(object sender, EventArgs e)
        {
            CBModel.Properties.DataSource = _aracModelServis.obje.Where(x => x.markaadi == CBMarka.Text).OrderBy(x => x.modeladi).Select(x => new { ADI = x.modeladi });
            CBModel.Properties.ValueMember = "ADI";
            CBModel.Properties.DisplayMember = "ADI";
        }

        private void BTNAracFoto_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları (*.jpg, *.png, *.jpeg, *.ico)|*.jpg;*.png;*.jpeg;*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = ofd.FileName;
                string DosyaAdi = ofd.SafeFileName;
                BTNAracFoto.Text = DosyaYolu;
                PBAracResim.Image = new Bitmap(DosyaYolu);
                PBAracResim.Properties.SizeMode = PictureSizeMode.Stretch;
                base64 = ImageToBase64(DosyaYolu);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            _tempArac = _aracServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            AracBilgileriniDoldur();
            base64 = "";
        }




        #endregion

        private void BTSigortaBelgeSec_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF Dosyası (*.pdf)|*.pdf|Resim Dosyaları (*.jpg, *.png, *.jpeg, *.ico)|*.jpg;*.png;*.jpeg;*.ico";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BTSigortaBelgeSec.Text = ofd.FileName;
                }
            }
        }

        private void BTKaskoBelgeSec_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF Dosyası (*.pdf)|*.pdf|Resim Dosyaları (*.jpg, *.png, *.jpeg, *.ico)|*.jpg;*.png;*.jpeg;*.ico";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BTKaskoBelgeSec.Text = ofd.FileName;
                }
            }
        }

        private void BTMuayeneBelgeSec_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF Dosyası (*.pdf)|*.pdf|Resim Dosyaları (*.jpg, *.png, *.jpeg, *.ico)|*.jpg;*.png;*.jpeg;*.ico";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BTMuayeneBelgeSec.Text = ofd.FileName;
                }
            }
        }

        private void GridSigorta_DoubleClick(object sender, EventArgs e)
        {
            //_aracSigortaServis.obje.Where(x => x.id.ToString() == gridViewSigorta.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault().img;
        }

      
    }
}
