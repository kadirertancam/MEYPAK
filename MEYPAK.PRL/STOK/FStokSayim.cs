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
        static MEYPAKContext context = NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis ;
        GenericWebServis<PocoSTOKSAYIMHAR> _stokSayimHarServis ;
        GenericWebServis<PocoSTOK> _stokServis ;
        GenericWebServis<PocoOLCUBR> _olcuBrServis ;
        FStokSayimPanel stokSayimPanel;
        int _tempId=0;

      
        private void FStokSayim_Load(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            DTSayimTar.EditValue = DateTime.Now;
            DGStokSayim.DataSource = _stokSayimServis.obje;
            gridView1.Columns["firmaid"].Visible = false;
            gridView1.Columns["subeid"].Visible = false;
            gridView1.Columns["depoid"].Visible = false;
            gridView1.Columns["id"].Visible = false; 
            gridView1.Columns["kayittipi"].Visible = false; 
            gridView1.Columns["eskiid"].Visible = false; 
            gridView1.Columns["olusturmatarihi"].Visible = false; 
            gridView1.Columns["guncellemetarihi"].Visible = false; 

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBAciklama.Text = gridView1.GetFocusedRowCellValue("aciklama").ToString();
            DTPSayimTarihi.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("sayimtarihi"));
            _tempId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
        }

        
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            stokSayimPanel = new FStokSayimPanel(this.Tag.ToString(), "kaydet");
            stokSayimPanel.Name = "FStokSayimPanel";
            stokSayimPanel.Tag = "TPStokSayimPanel" + 1; 
           
            _stokSayimServis.Data(ServisList.StokSayimEkleServis, (new Entity.PocoModels.STOK.PocoSTOKSAYIM()
            {
                sayimtarihi = Convert.ToDateTime(DTStokSayimTarih.EditValue.ToString()),
                aciklama = TBAciklama.Text,

            }));
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            DGStokSayim.DataSource = _stokSayimServis.obje;

            stokSayimPanel.sayimId = _stokSayimServis.obje.Where(x => x.aciklama == TBAciklama.Text).FirstOrDefault().id;
            TBAciklama.Text = "";
            DTStokSayimTarih.EditValue = DateTime.Now;
            stokSayimPanel.ShowDialog();
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimSilServis, null, null, (_stokSayimServis.obje.Where(x => x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString()))).ToList());
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            DGStokSayim.DataSource = _stokSayimServis.obje;
        }

        private void BTDuzenle_Click(object sender, EventArgs e)
        {
            stokSayimPanel = new FStokSayimPanel("düzenle");
            var a = _stokSayimHarServis.obje.Where(x => x.stoksayimid == _tempId);
            stokSayimPanel._tempStokSayimHarList = a.Select(x => new Entity.PocoModels.PocoStokSayimPanelList() { StokAdı = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().adi, StokKodu = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod, Birim = _olcuBrServis.obje.Where(z => z.id == x.birimid).FirstOrDefault().adi, Fiyat = x.fiyat, Miktar = x.miktar }).ToList();
            stokSayimPanel.ShowDialog();
        }

        
    }
    }
