using DevExpress.XtraEditors;
using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
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
    public partial class FDepolarArasıTransfer : XtraForm
    {

        public FDepolarArasıTransfer()
        {
            InitializeComponent();
        }
        FDepoList fDepoList;
        List<PocoDepolarArasıTransfer> pocoDepolarArasıTransfer;
        public PocoDEPO _CıktıDepo;
        public PocoDEPO _HedefDepo;
        public PocoDEPOTRANSFER _tempDepoTransfer;
        FDepolarArasıTransferHar fDepolarArasıTransferHar;
        IDepoTransferServis _depoTransferServis ;

        private void button1_Click(object sender, EventArgs e)
        {
            fDepoList = new FDepoList("FDepoTransferCıktı");
            fDepoList.ShowDialog();
            TBCikisDepo.Text = _CıktıDepo.depoadi;
        }

        private void BTNHedefDepoSec_Click(object sender, EventArgs e)
        {
            fDepoList = new FDepoList("FDepoTransferHedef");
            fDepoList.ShowDialog();
            TBHedefDepo.Text = _HedefDepo.depoadi;
        }

        private void BTDepoTransferKaydet_Click(object sender, EventArgs e)
        {
            if (_HedefDepo != null && _CıktıDepo != null)
            {
                _tempDepoTransfer= _depoTransferServis.Ekle(new PocoDEPOTRANSFER()
                {
                    olusturmatarihi = DateTime.Now,
                    guncellemetarihi = DateTime.Now,
                    ciktidepoid = _CıktıDepo.id,
                    hedefdepoid = _HedefDepo.id,
                    donem = DateTime.Now.ToString("yyyy"),
                    durum = 1
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
            GCDepolarArasiTransfer.DataSource = "";
            pocoDepolarArasıTransfer = _depoTransferServis.PocoDepolarArasıTransferListesi();
            GCDepolarArasiTransfer.DataSource = pocoDepolarArasıTransfer;
            gridView1.Columns[0].Visible = false; 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView1.GetSelectedRows() != null)
            {

                _tempDepoTransfer = _depoTransferServis.Getir(x => x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("id").ToString())).FirstOrDefault();
                fDepolarArasıTransferHar = new FDepolarArasıTransferHar(_tempDepoTransfer);
                fDepolarArasıTransferHar.ShowDialog();

            }
        }

        private void BTNSil_Click(object sender, EventArgs e)
        {
            _depoTransferServis.Sil(_depoTransferServis.Getir(x => x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"))));
        }
    }
}
