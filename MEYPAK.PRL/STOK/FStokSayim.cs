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
                SAYIMTARIHI = DTPSayimTarihi.Value,
                ACIKLAMA = TBAciklama.Text,
            }));
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            gridControl1.DataSource = _stokSayimServis.obje;

            stokSayimPanel.sayimId = _stokSayimServis.obje.Where(x => x.ACIKLAMA == TBAciklama.Text ).FirstOrDefault().ID;
                TBAciklama.Text = "";
            DTPSayimTarihi.Value = DateTime.Now;
            stokSayimPanel.ShowDialog();

        }

        private void FStokSayim_Load(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            DTPSayimTarihi.EditValue = DateTime.Now.ToString("dd/MM/yyyy HH.mm");
            gridControl1.DataSource = _stokSayimServis.obje;
            gridView1.Columns["FIRMAID"].Visible = false;
            gridView1.Columns["SUBEID"].Visible = false;
            gridView1.Columns["DEPOID"].Visible = false;
            gridView1.Columns["ID"].Visible = false; 
            gridView1.Columns["KAYITTIPI"].Visible = false; 
            gridView1.Columns["ESKIID"].Visible = false; 
            gridView1.Columns["OLUSTURMATARIHI"].Visible = false; 
            gridView1.Columns["GUNCELLEMETARIHI"].Visible = false; 

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            DTPSayimTarihi.Value = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("SAYIMTARIHI"));
            _tempId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
        }

        private void BTSayimDuzenle_Click(object sender, EventArgs e)
        {
            stokSayimPanel = new FStokSayimPanel("düzenle");
            var a = _stokSayimHarServis.obje.Where(x => x.STOKSAYIMID == _tempId);
            stokSayimPanel._tempStokSayimHarList = a.Select(x=> new Entity.PocoModels.PocoStokSayimPanelList() { StokAdı=x.MPSTOK.ADI,StokKodu=x.MPSTOK.KOD,Birim=x.MPOLCUBR.ADI,Fiyat=x.FIYAT,Miktar=x.MIKTAR}).ToList();
            stokSayimPanel.ShowDialog();
        }

        private void BTSayimSil_Click(object sender, EventArgs e)
        {
            _stokSayimServis.Data(ServisList.StokSayimSilServis,null,null,(_stokSayimServis.obje.Where(x => x.ID== Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString()))).ToList());
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            gridControl1.DataSource = _stokSayimServis.obje;
        }
    }
}
