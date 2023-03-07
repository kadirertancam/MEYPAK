using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.CARI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UlkeList;

namespace MEYPAK.PRL.STOK.FiyatListesi
{
    public partial class FStokFiyat : XtraForm
    {

        public FStokFiyat(string tag = "", string islem = "")
        {
            InitializeComponent();
            _stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            _stokFiyatHarServis = new GenericWebServis<PocoSTOKFIYATHAR>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _form = tag;
            _islem = islem;

        }

        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoSTOKFIYAT> _stokFiyatServis;
        GenericWebServis<PocoSTOKFIYATHAR> _stokFiyatHarServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        public PocoCARIKART _tempCariKart;
        public PocoSTOKFIYAT _tempStokFiyat;
       
        FStokFiyatPanel stokFiyatPanel;

        #endregion

        #region Metotlar
        private void FStokFiyat_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }
        int _tempId = 0;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.STOKFIYATTANIM.ToString()).EKLE==true)
            {
            if (_cariServis.obje.Where(x => x.id == _tempCariKart.id && x.kayittipi == 0).Count() > 0)
            {
                _stokFiyatServis.Data(ServisList.StokFiyatEkleServis, (new Entity.PocoModels.STOK.PocoSTOKFIYAT()
                {
                    
                    cariid = _tempCariKart.id,
                    adi = TBAdi.Text,
                    aciklama = TBAciklama.Text,
                    baslangictarihi = Convert.ToDateTime(DTBaslangicTar.Text.ToString()),
                    bitistarihi = Convert.ToDateTime(DTBitisTar.Text.ToString()),
                    userid = MPKullanici.ID,

                }));
                _tempStokFiyat = _stokFiyatServis.obje2;

                stokFiyatPanel = new FStokFiyatPanel(_tempStokFiyat, this.Tag.ToString());
                stokFiyatPanel.ShowDialog();
                MessageBox.Show("Stok Fiyat Listesi başarıyla kaydedildi!");
                DataGridDoldur();
            }
            else
                MessageBox.Show("Kayıt Başarısız!");
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }
        void DataGridDoldur()
        {
            if (_tempCariKart != null)
            {
                BTCariSec.Text = _tempCariKart.unvan.ToString();
                _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
                _cariServis.Data(ServisList.CariListeServis);

                DGStokFiyat.DataSource = _stokFiyatServis.obje.Where(x => x.kayittipi == 0 && x.cariid == _tempCariKart.id).Select(x => new
                {
                    ID = x.id,
                    CARIID= _tempCariKart.id,
                    CARIKODU = _cariServis.obje.Where(z =>z.kayittipi==0 && z.id == x.cariid).FirstOrDefault().adi.ToString(),
                    FİYATLİSTESİ = x.adi,
                    ACIKLAMA = x.aciklama,
                    BASLANGICTARİHİ = x.baslangictarihi,
                    BİTİSTARİHİ = x.bitistarihi,

                });
               
                gridView1.Columns["ID"].Visible = false;
                gridView1.Columns["CARIID"].Visible = false;
                DGStokFiyat.Refresh();
                DGStokFiyat.RefreshDataSource();
            }
           
        }
        //void DataGridiYapilandir()
        //{
        //    if (_tempCariKart != null)
        //    {
        //        BTCariSec.Text = _tempCariKart.unvan.ToString();
        //        _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
        //        DGStokFiyat.DataSource = _stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id).Select(x => new
        //        {
        //            ID = x.id,
        //            FİYATLİSTESİ = x.adi,
        //            ACIKLAMA = x.aciklama,
        //            BASLANGICTARİHİ = x.baslangictarihi,
        //            BİTİSTARİHİ = x.bitistarihi,
        //        });
        //    }
        //    else
        //    {
        //        MessageBox.Show("Cari seçimi yapmalısınız!");
        //    }
        //}
        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FCariList fCariList = new FCariList(this.Tag.ToString(), "FStokFiyat");
            fCariList.ShowDialog();
            DataGridDoldur();

        }
        private void DGStokFiyat_DoubleClick(object sender, EventArgs e)
        {
            _tempStokFiyat = _stokFiyatServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            stokFiyatPanel = new FStokFiyatPanel(_tempStokFiyat, this.Tag.ToString());
            stokFiyatPanel.ShowDialog();
        }
  
        private void BTSil_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.STOKFIYATTANIM.ToString()).SIL==true)
            {

           
            if (gridView1.FocusedRowHandle>0)
            {
                DialogResult Secim = new DialogResult();

                Secim = MessageBox.Show($"{gridView1.GetFocusedRowCellValue("FİYATLİSTESİ")} \nSilinsin mi?", "Kaydı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
               

                if (Secim == DialogResult.Yes)
                {
                    _stokFiyatHarServis.Data(ServisList.StokFiyatHarListeServis);
                    _stokFiyatServis.Data(ServisList.StokFiyatSilServis, modellist: _stokFiyatServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString() && x.cariid.ToString() == gridView1.GetFocusedRowCellValue("CARIID").ToString()).ToList());
                    _stokFiyatHarServis.Data(ServisList.StokFiyatHarSilServis, modellist: _stokFiyatHarServis.obje.Where(x => x.stokfiyatid.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
                    MessageBox.Show("Silme işlemi Başarılı");
                    DataGridDoldur();
                }
               
            }
            else
                MessageBox.Show("Fiyat Listesi Seçmeden Silme işlemi yapamazsınız!");
            }
            else
                MessageBox.Show(MPKullanici.hata);


        }
        public void Temizle(Control.ControlCollection ctrlCollection)           //Formdaki Textboxları temizle
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }

        }
        private void BTTemizle_Click(object sender, EventArgs e)
        {
            Temizle(this.Controls);
            _tempStokFiyat = null;
        }

        #endregion


        //void BilgileriGetir()
        //{
        //    if (_stokFiyatServis != null)
        //    {
        //        _tempId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
        //        BTCariSec.Text = gridView1.GetFocusedRowCellValue("CARIID").ToString();
        //        TBAdi.Text = gridView1.GetFocusedRowCellValue("FİYATLİSTESİ").ToString();
        //        TBAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        //        DTBaslangicTar.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BASLANGICTARİHİ").ToString());
        //        DTBitisTar.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BİTİSTARİHİ").ToString());
        //    }
        //}
    }
}
