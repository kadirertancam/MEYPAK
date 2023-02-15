using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MEYPAK.BLL.Assets;
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
    public partial class FAracTanim :   XtraForm
    {
        GenericWebServis<PocoARAC> _aracServis;
        GenericWebServis<PocoARACRUHSATRESIM> _aracServisRUHSATRESIMServis;
        GenericWebServis<PocoARACMODEL> _aracModelServis;
        GenericWebServis<PocoPERSONEL> _personelServis;
        public FAracTanim()
        {
            _personelServis = new GenericWebServis<PocoPERSONEL>();
            _aracServisRUHSATRESIMServis = new GenericWebServis<PocoARACRUHSATRESIM>();
            _aracModelServis = new GenericWebServis<PocoARACMODEL>();
            _aracServis = new GenericWebServis<PocoARAC>();
            InitializeComponent();
            AraclarıGetir();
            CombolarıDoldur();
        }
        PocoARAC _tempArac;
        string base64 = "";
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


        void AraclarıGetir()
        {
            _aracServis.Data(ServisList.AracListeServis);
            gridControl1.DataSource = _aracServis.obje.Select(x => new { PLAKA = x.plaka, MARKA = x.marka, MODEL = x.model, ID = x.id });
            gridView1.Columns["ID"].Visible = false;
        }
        void ResimleriGetir()
        {
            RuhsatResimleriGetir();
        }

        void AracBilgileriniDoldur()
        {
            if (_tempArac!=null && _tempArac.id!=0)
            {
                TBPlaka.Text = _tempArac.plaka;
                CBMarka.Text = _aracModelServis.obje.Where(x=> x.id ==Convert.ToInt32( _tempArac.marka)).FirstOrDefault().markaadi;
                CBModel.EditValue = _tempArac.model;
                CBYakitTuru.EditValue = _tempArac.yakitturu;
                CBSofor1.EditValue = _tempArac.soforid;
                CBSofor2.EditValue = _tempArac.sofor2id;
                
            }
            
            //plaka = TBPlaka.Text,
            //        tip = CBTip.EditValue != null ? CBTip.EditValue.ToString() : "BILINMIYOR",
            //        marka = CBMarka.EditValue != null ? CBMarka.EditValue.ToString() : "BILINMIYOR",
            //        model = CBModel.EditValue != null ? CBModel.EditValue.ToString() : "BILINMIYOR",
            //        yakitturu = TBPlaka.Text,
            //        soforid = CBSofor1.EditValue != null ? (int)CBSofor1.EditValue : 0,
            //        sofor2id = CBSofor2.EditValue != null ? (int)CBSofor2.EditValue : 0,
        }
        void RuhsatResimleriGetir()
        {
            if (_tempArac != null)
            {
                _aracServisRUHSATRESIMServis.Data(ServisList.AracRuhsatResimListeServis);
                GridRuhsat.DataSource = _aracServisRUHSATRESIMServis.obje.Where(x=> x.aracid == _tempArac.id);
            }
        }

        void CombolarıDoldur()
        {
            _aracModelServis.Data(ServisList.AracModelListeServis);
            CBMarka.Properties.DataSource = (from temp in _aracModelServis.obje group temp by temp.markaadi into temp select new { ADI = temp.FirstOrDefault().markaadi, ID = temp.FirstOrDefault().id }).OrderBy(x=> x.ADI);
            CBMarka.Properties.ValueMember = "ID";
            CBMarka.Properties.DisplayMember = "ADI";

            _personelServis.Data(ServisList.PersonelListeServis);
            CBSofor1.Properties.DataSource = _personelServis.obje.Where(x => x.kayittipi == 0).Select(x => new { ADI = x.adisoyadi, ID = x.id });
            CBSofor1.Properties.ValueMember = "ID";
            CBSofor1.Properties.DisplayMember = "ADI";

            CBSofor2.Properties.DataSource = _personelServis.obje.Where(x => x.kayittipi == 0).Select(x => new { ADI = x.adisoyadi, ID = x.id });
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
            if (TBPlaka.Text != null && CBTip.EditValue != null && CBMarka.EditValue != null && CBModel.EditValue != null && CBYakitTuru.EditValue != null && CBSofor1.EditValue != null)
            {
                if (_tempArac!=null && _tempArac.id!=0)
                {
                    _aracServis.Data(ServisList.AracEkleServis, new PocoARAC()
                    {
                        id = _tempArac.id,
                        plaka = TBPlaka.Text,
                        tip = CBTip.EditValue != null ? CBTip.EditValue.ToString() : "BILINMIYOR",
                        marka = CBMarka.EditValue != null ? CBMarka.EditValue.ToString() : "BILINMIYOR",
                        model = CBModel.EditValue != null ? CBModel.EditValue.ToString() : "BILINMIYOR",
                        yakitturu = TBPlaka.Text,
                        soforid = CBSofor1.EditValue != null ? (int)CBSofor1.EditValue : 0,
                        sofor2id = CBSofor2.EditValue != null ? (int)CBSofor2.EditValue : 0,
                        userid = MPKullanici.ID
                    });
                    _tempArac = _aracServis.obje2;
                    MessageBox.Show($"{_tempArac.plaka} plakalı araç başarıyla güncellendi");
                    AraclarıGetir();
                }
                else
                {
                    _aracServis.Data(ServisList.AracEkleServis, new PocoARAC()
                    {
                        plaka = TBPlaka.Text,
                        tip = CBTip.EditValue != null ? CBTip.EditValue.ToString() : "BILINMIYOR",
                        marka = CBMarka.EditValue != null ? CBMarka.EditValue.ToString() : "BILINMIYOR",
                        model = CBModel.EditValue != null ? CBModel.EditValue.ToString() : "BILINMIYOR",
                        yakitturu = TBPlaka.Text,
                        soforid = CBSofor1.EditValue != null ? (int)CBSofor1.EditValue : 0,
                        sofor2id = CBSofor2.EditValue != null ? (int)CBSofor2.EditValue : 0,
                        userid = MPKullanici.ID
                    });
                    _tempArac = _aracServis.obje2;
                    MessageBox.Show($"{_tempArac.plaka} plakalı araç başarıyla eklendi");
                    AraclarıGetir();
                }
               
            }
            else
            {
                MessageBox.Show("Araca ait zorunlu alanların tamamının doldurulması gerekir!");
            }
        }

        private void BTNSigortaKaydet_Click(object sender, EventArgs e)
        {
            if (_tempArac != null && _tempArac.id != 0)
            {
                if (TBSigAcenteAdi.Text != null && TBSigPoliceNo.Text != null && DTPKasPolBasTar.EditValue != null && DTPKasPolBitTar.EditValue != null)
                {
                    _aracServis.Data(ServisList.AracEkleServis, new PocoARAC()
                    {
                        id = _tempArac.id,
                        sigacenteadi = TBSigAcenteAdi.Text,
                        sigpoliceno = TBSigPoliceNo.Text,
                        sigbastar = (DateTime)DTPSigPolBasTar.EditValue,
                        sigbittar = (DateTime)DTPSigPolBitTar.EditValue,
                        userid = MPKullanici.ID
                    });
                    MessageBox.Show($"{_tempArac.plaka} plakalı araca sigorta bilgileri eklenmiştir.");
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

        private void BTNKaskoKaydet_Click(object sender, EventArgs e)
        {
            if (_tempArac != null && _tempArac.id != 0)
            {
                if (TBKasAcenteAdi.Text != null && TBKasPoliceNo.Text != null && DTPKasPolBasTar.EditValue != null && DTPKasPolBitTar != null)
                {
                    _aracServis.Data(ServisList.AracEkleServis, new PocoARAC()
                    {
                        id = _tempArac.id,
                        kasacenteadi = TBKasAcenteAdi.Text,
                        kaspoliceno = TBKasPoliceNo.Text,
                        kasbastar = (DateTime)DTPKasPolBasTar.EditValue,
                        kasbittar = (DateTime)DTPKasPolBitTar.EditValue,
                        userid = MPKullanici.ID
                    });

                    MessageBox.Show($"{_tempArac.plaka} plakalı araca sigorta bilgileri eklenmiştir.");
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


        private void simpleButton1_Click(object sender, EventArgs e)
        {//Ruhsat
            if (_tempArac != null && _tempArac.id!=0)
            {
            _aracServisRUHSATRESIMServis.Data(ServisList.AracRuhsatResimListeServis);
            if (_aracServisRUHSATRESIMServis.obje.Where(x => x.aracid == _tempArac.id).Last().num != 0)
            {
                _aracServisRUHSATRESIMServis.Data(ServisList.AracRuhsatResimEkleServis, new PocoARACRUHSATRESIM()
                {
                    aracid = _tempArac.id,
                    num = 0,
                    img = base64,
                    userid = MPKullanici.ID
                });
            }
            else
            {
                _aracServisRUHSATRESIMServis.Data(ServisList.AracRuhsatResimEkleServis, new PocoARACRUHSATRESIM()
                {
                    aracid = _tempArac.id,
                    num = _aracServisRUHSATRESIMServis.obje.Where(x => x.aracid == _tempArac.id).Last().num + 1,
                    img = base64,
                    userid = MPKullanici.ID
                });
            }
            ResimleriGetir();
            }
            else
            {
                MessageBox.Show("Ruhsat bilgileri girilecek Araç seçilmedi!");
            }
        }


        private void buttonEdit2_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Seç")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TümDosyalar |*.*|Jpeg Dosyası |*.jpeg| Jpg Dosyası|*.jpg| PNG Dosyası|*.png| ICO Dosyası|*.ico;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = ofd.FileName;
                    string DosyaAdi = ofd.SafeFileName;
                    BTNRuhsatSec.Text = DosyaYolu;
                    base64 = ImageToBase64(DosyaYolu);
                }
            }
        }


        private void CBMarka_EditValueChanged(object sender, EventArgs e)
        {
            CBModel.Properties.DataSource = _aracModelServis.obje.Where(x => x.markaadi == CBMarka.Text).OrderBy(x=> x.modeladi).Select(x => new { ADI=x.modeladi });
            CBModel.Properties.ValueMember = "ADI";
            CBModel.Properties.DisplayMember = "ADI";
        }

        private void BTNAracFoto_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TümDosyalar |*.*|Jpeg Dosyası |*.jpeg| Jpg Dosyası|*.jpg| PNG Dosyası|*.png| ICO Dosyası|*.ico;";
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
            
        }



        #endregion


    }
}
