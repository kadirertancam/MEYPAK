using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraSpreadsheet.Import.OpenXml;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Depo;
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

namespace MEYPAK.PRL.STOK.FiyatListesi
{
    public partial class FStokFiyat : XtraForm
    {

        public FStokFiyat()
        {
            InitializeComponent();
            _stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
            _stokFiyatHarServis = new GenericWebServis<PocoSTOKFIYATHAR>();
            _stokFiyatHarServis.Data(ServisList.StokFiyatHarListeServis);
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _cariServis.Data(ServisList.CariListeServis);
          
        }

        #region Tanımlar
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
            if (_cariServis.obje.Where(x => x.id == _tempCariKart.id && x.kayittipi == 0).Count() > 0)
            {
                _stokFiyatServis.Data(ServisList.StokFiyatEkleServis, (new Entity.PocoModels.STOK.PocoSTOKFIYAT()
                {
                    
                    cariid = _tempCariKart.id,
                    adi = TBAdi.Text,
                    aciklama = TBAciklama.Text,
                    baslangictarihi = Convert.ToDateTime(DTBaslangicTar.Text.ToString()),
                    bitistarihi = Convert.ToDateTime(DTBitisTar.Text.ToString()),

                }));
                _tempStokFiyat = _stokFiyatServis.obje2;

                stokFiyatPanel = new FStokFiyatPanel(_tempStokFiyat, this.Tag.ToString());
                stokFiyatPanel.ShowDialog();
                MessageBox.Show("Kayıt başartılı");
                DataGridDoldur();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!");
            }
        }
        void DataGridDoldur()
        {
            
            _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            DGStokFiyat.DataSource = _stokFiyatServis.obje.Where(x => x.kayittipi == 0 && x.cariid == _tempCariKart.id).Select(x => new
            {
                ID = x.id,
                //CARIID = _tempCariKart.id,
                FİYATLİSTESİ = x.adi,
                ACIKLAMA = x.aciklama,
                BASLANGICTARİHİ = x.baslangictarihi,
                BİTİSTARİHİ = x.bitistarihi,
            });
            DGStokFiyat.Refresh();
            DGStokFiyat.RefreshDataSource();
        }
         
        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            FCariList fCariList = new FCariList(this.Tag.ToString(), "FStokFiyat");
            fCariList.ShowDialog();
            if (_tempCariKart != null)
            {
                BTCariSec.Text = _tempCariKart.unvan.ToString(); 
            }
            else
            {
                MessageBox.Show("Cari Seçilmedi!");
            }

        }


        #endregion

        private void DGStokFiyat_DoubleClick(object sender, EventArgs e)
        {
            _tempStokFiyat = _stokFiyatServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            stokFiyatPanel = new FStokFiyatPanel(_tempStokFiyat, this.Tag.ToString());
            stokFiyatPanel.ShowDialog();
        }
        void BilgileriGetir()
        {
            if (_stokFiyatServis != null)
            {
                _tempId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                TBAdi.Text = gridView1.GetFocusedRowCellValue("FİYATLİSTESİ").ToString();
                TBAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
                DTBaslangicTar.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BASLANGICTARİHİ").ToString());
                DTBitisTar.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("BİTİSTARİHİ").ToString());

            }
        }
    }
}
