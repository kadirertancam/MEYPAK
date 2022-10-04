using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayim : Form
    {
        public FStokSayim()
        {
            InitializeComponent();
           
        }
        IStokSayimServis _stokSayimServis = new StokSayimManager(new EFStokSayimRepo());
        IStokSayimHarServis _stokSayimHarServis= new StokSayimHarManager(new EFStokSayimHarRepo());
        FStokSayimPanel stokSayimPanel;
        int _tempId=0;

        private void BTSayimKaydet_Click(object sender, EventArgs e)
        {
            stokSayimPanel = new FStokSayimPanel("kaydet");
            _stokSayimServis.Ekle(new Entity.Models.MPSTOKSAYIM()
            {
                SAYIMTARIHI = DTPSayimTarihi.Value,
                ACIKLAMA = TBAciklama.Text,
            });
            dataGridView1.DataSource = _stokSayimServis.Listele();

            stokSayimPanel.sayimId = _stokSayimServis.Getir(x => x.ACIKLAMA == TBAciklama.Text && x.SAYIMTARIHI == DTPSayimTarihi.Value).FirstOrDefault().ID;
                TBAciklama.Text = "";
            DTPSayimTarihi.Value = DateTime.Now;
            stokSayimPanel.ShowDialog();

        }

        private void FStokSayim_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _stokSayimServis.Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBAciklama.Text = dataGridView1.Rows[e.RowIndex].Cells["ACIKLAMA"].Value.ToString();
            DTPSayimTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["SAYIMTARIHI"].Value);
            _tempId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
        }

        private void BTSayimDuzenle_Click(object sender, EventArgs e)
        {
            stokSayimPanel = new FStokSayimPanel("düzenle");
            var a = _stokSayimHarServis.Listele().Where(x => x.STOKSAYIMID == _tempId);
            stokSayimPanel._tempStokSayimHarList = a.Select(x=> new Entity.PocoModels.PocoStokSayimPanelList() { StokAdı=x.MPSTOK.ADI,StokKodu=x.MPSTOK.KOD,Birim=x.MPOLCUBR.ADI,Fiyat=x.FIYAT,Miktar=x.MIKTAR}).ToList();
            stokSayimPanel.ShowDialog();
        }
    }
}
