using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using MEYPAK.Interfaces.Parametre;
using DevExpress.Text.Interop;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayim : Form
    {
        public FStokSayim()
        {
            InitializeComponent();
            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _stokSayimHarServis = new GenericWebServis<PocoSTOKSAYIMHAR>();
            _stokSayimHarServis.Data(ServisList.StokSayimHarListeServis);
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokServis.Data(ServisList.StokListeServis);
        }
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis ;
        GenericWebServis<PocoSTOKSAYIMHAR> _stokSayimHarServis ;
        GenericWebServis<PocoSTOK> _stokServis ;
        GenericWebServis<PocoOLCUBR> _olcuBrServis ;
        FStokSayimPanel stokSayimPanel;
        

        private void FStokSayim_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            CombolariDoldur();
        }
        int _tempId = 0;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            stokSayimPanel = new FStokSayimPanel(this.Tag.ToString(), "kaydet");
            stokSayimPanel.Name = "FStokSayimPanel";
            stokSayimPanel.Tag = "TPStokSayimPanel" + 1; 
           
            _stokSayimServis.Data(ServisList.StokSayimEkleServis, (new Entity.PocoModels.STOK.PocoSTOKSAYIM()
            {
                sayimtarihi = Convert.ToDateTime(DTSayimTar.EditValue.ToString()),
                aciklama = TBAciklama.Text,

            }));
            stokSayimPanel.ShowDialog();
           
            //stokSayimPanel.sayimId = _stokSayimServis.obje.Where(x => x.aciklama == TBAciklama.Text).FirstOrDefault().id;
            //TBAciklama.Text = "";
            //DTSayimTar.EditValue = DateTime.Now;
           
        }
        
        private void BTSil_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _stokSayimServis.Data(ServisList.StokSayimSilServis, null, null, _stokSayimServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).ToList());
            MessageBox.Show("Silme işlemi Başarılı");
            DataGridDoldur();
        }

        //private void BTDuzenle_Click(object sender, EventArgs e)
        //{
        //    stokSayimPanel = new FStokSayimPanel("düzenle");
        //    var a = _stokSayimHarServis.obje.Where(x => x.stoksayimid == _tempId);
        //    stokSayimPanel._tempStokSayimHarList = a.Select(x => new Entity.PocoModels.PocoStokSayimPanelList() { StokAdı = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().adi, StokKodu = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod, Birim = _olcuBrServis.obje.Where(z => z.id == x.birimid).FirstOrDefault().adi, Fiyat = x.fiyat, Miktar = x.miktar }).ToList();
        //    stokSayimPanel.ShowDialog();
        //}

        void DataGridDoldur()
        {

            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            DTSayimTar.EditValue = DateTime.Now;
            DGStokSayim.DataSource = _stokSayimServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                SayimTarihi = x.sayimtarihi,
                Açıklama = x.aciklama,
                OluşturmaTarihi = x.olusturmatarihi
            });
            DGStokSayim.Refresh();
            DGStokSayim.RefreshDataSource();

            //gridView1.Columns["firmaid"].Visible = false;
            //gridView1.Columns["subeid"].Visible = false;
            //gridView1.Columns["depoid"].Visible = false;
            //gridView1.Columns["id"].Visible = false;
            //gridView1.Columns["kayittipi"].Visible = false;
            //gridView1.Columns["eskiid"].Visible = false;
            //gridView1.Columns["olusturmatarihi"].Visible = false;
            //gridView1.Columns["guncellemetarihi"].Visible = false;
           
        }
        private void DGStokSayim_DoubleClick(object sender, EventArgs e)
        {
            _tempId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            TBAciklama.Text = gridView1.GetFocusedRowCellValue("Açıklama").ToString();
            DTPSayimTarihi.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("SayimTarihi"));
            BilgileriGetir();
            //olusturmatarihi = DateTime.Now;
        }
        void BilgileriGetir()
        {
            if (_stokSayimServis != null)
            {
                _tempId= int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                DTSayimTar.Text = gridView1.GetFocusedRowCellValue("SayimTarihi").ToString();
                TBAciklama.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Adı").ToString());
                
            }
        }

        void CombolariDoldur()
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            // CBDoviz.Properties.DataSource = _parabirIMServis.obje.Select(x => new { x.id, x.adi });

        }
    }
}
