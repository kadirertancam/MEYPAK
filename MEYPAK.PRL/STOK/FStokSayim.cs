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
        IOlcuBrServis _olcuBrServis ;
        FStokSayimPanel stokSayimPanel;
        int _tempId=0;

        private void BTSayimKaydet_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            stokSayimPanel = new FStokSayimPanel("kaydet");
            _stokSayimServis.Data(ServisList.StokSayimEkleServis,(new Entity.PocoModels.STOK.PocoSTOKSAYIM()
            {
                SAYIMTARIHI = (DateTime)DEStokSayimTarihi.EditValue,
                ACIKLAMA = TBStokSayimAciklama.Text,

            }));
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            GCStokSayim.DataSource = _stokSayimServis.obje;

            stokSayimPanel.sayimId = _stokSayimServis.obje.Where(x => x.ACIKLAMA == TBStokSayimAciklama.Text ).FirstOrDefault().id;
                TBStokSayimAciklama.Text = "";
            DTPSayimTarihi.EditValue = DateTime.Now;
            stokSayimPanel.ShowDialog();

        }

        private void FStokSayim_Load(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            DEStokSayimTarihi.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            GCStokSayim.DataSource = _stokSayimServis.obje;
            gridView1.Columns["FIRMAID"].Visible = false;
            gridView1.Columns["SUBEID"].Visible = false;
            gridView1.Columns["DEPOID"].Visible = false;
            gridView1.Columns["id"].Visible = false; 
            gridView1.Columns["kayittipi"].Visible = false; 
            gridView1.Columns["eskiid"].Visible = false; 
            gridView1.Columns["olusturmatarihi"].Visible = false; 
            gridView1.Columns["guncellemetarihi"].Visible = false; 

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBStokSayimAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            DTPSayimTarihi.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("SAYIMTARIHI"));
            _tempId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"));
        }

        private void BTSayimDuzenle_Click(object sender, EventArgs e)
        {
            stokSayimPanel = new FStokSayimPanel("düzenle");
            var a = _stokSayimHarServis.obje.Where(x => x.STOKSAYIMID == _tempId);
            stokSayimPanel._tempStokSayimHarList = a.Select(x=> new Entity.PocoModels.PocoStokSayimPanelList() { StokAdı=x.MPSTOK.adi,StokKodu=x.MPSTOK.kod,Birim=x.MPOLCUBR.adi,Fiyat=x.FIYAT,Miktar=x.MIKTAR}).ToList();
            stokSayimPanel.ShowDialog();
        }

        private void BTSayimSil_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimSilServis,null,null,(_stokSayimServis.obje.Where(x => x.id== Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString()))).ToList());
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            GCStokSayim.DataSource = _stokSayimServis.obje;
        }

       

        private void TBAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void DEStokSayimTarihi_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
