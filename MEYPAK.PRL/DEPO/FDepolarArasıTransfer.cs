using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FDepolarArasıTransfer : Form
    {

        public FDepolarArasıTransfer()
        {
            InitializeComponent();
        }
        FDepoList fDepoList;
        List<PocoDepolarArasıTransfer> pocoDepolarArasıTransfer;
        public MPDEPO _CıktıDepo;
        public MPDEPO _HedefDepo;
        public MPDEPOTRANSFER _tempDepoTransfer;
        FDepolarArasıTransferHar fDepolarArasıTransferHar;
        IDepoTransferServis _depoTransferServis = new DepoTransferManager(new EFDepoTransferRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));

        private void button1_Click(object sender, EventArgs e)
        {
            fDepoList = new FDepoList("FDepoTransferCıktı");
            fDepoList.ShowDialog();
            TBCıkısDepo.Text = _CıktıDepo.DEPOADI;
        }

        private void BTNHedefDepoSec_Click(object sender, EventArgs e)
        {
            fDepoList = new FDepoList("FDepoTransferHedef");
            fDepoList.ShowDialog();
            TBHedefDepo.Text = _HedefDepo.DEPOADI;
        }

        private void BTDepoTransferKaydet_Click(object sender, EventArgs e)
        {
            if (_HedefDepo != null && _CıktıDepo != null)
            {
                _tempDepoTransfer= _depoTransferServis.Ekle(new MPDEPOTRANSFER()
                {
                    OLUSTURMATARIHI = DateTime.Now,
                    GUNCELLEMETARIHI = DateTime.Now,
                    CIKTIDEPOID = _CıktıDepo.ID,
                    HEDEFDEPOID = _HedefDepo.ID,
                    DONEM = DateTime.Now.ToString("yyyy"),
                    DURUM = 1
                });
                FDepolarArasıTransferHar arasıTransferBilgi = new FDepolarArasıTransferHar(_tempDepoTransfer) ;
                DataGridDoldur();
            }

        }

        private void FDepolarArasıTransfer_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }
        void DataGridDoldur()
        {
            dataGridView1.DataSource = "";
            pocoDepolarArasıTransfer = _depoTransferServis.PocoDepolarArasıTransferListesi();
            dataGridView1.DataSource = pocoDepolarArasıTransfer;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {

                _tempDepoTransfer = _depoTransferServis.Getir(x => x.ID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())).FirstOrDefault();
                fDepolarArasıTransferHar = new FDepolarArasıTransferHar(_tempDepoTransfer);
                fDepolarArasıTransferHar.ShowDialog();

            }
        }

        private void BTNSil_Click(object sender, EventArgs e)
        {
            _depoTransferServis.Sil(_depoTransferServis.Getir(x => x.ID == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)));
        }
    }
}
