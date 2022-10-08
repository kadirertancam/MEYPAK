using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
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
    public partial class FDepolarArasıTransferHar : Form
    {
        MPDEPOTRANSFER _arasıtransfer;
        public MPSTOK _tempStok;
        IDepoServis _depoServis = new DepoManager(new EFDepoRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        IDepoTransferServis _depoTransferServis = new DepoTransferManager(new EFDepoTransferRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        IDepoTransferHarServis _depoTransferHarServis = new DepoTransferHarManager(new EFDepoTransferHarRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        public FDepolarArasıTransferHar(MPDEPOTRANSFER arasıTransfer)
        {
            InitializeComponent();
            _arasıtransfer = arasıTransfer;
        }


        private void FDepolarArasıTransferBilgi_Load(object sender, EventArgs e)
        {
            DOLDUR();
            DataGrideBilgiGetir();
        }

        void DOLDUR()
        {
            if (_arasıtransfer!=null)
            {
            TBCikisDepo.Text = _depoServis.Getir(x => x.ID == _arasıtransfer.CIKTIDEPOID).FirstOrDefault().DEPOADI;
            TBHedefDepo.Text = _depoServis.Getir(x => x.ID == _arasıtransfer.HEDEFDEPOID).FirstOrDefault().DEPOADI;
            TBDurum.Text = _arasıtransfer.DURUM.ToString();
            DTPOlusturmaTarihi.Value = _arasıtransfer.OLUSTURMATARIHI;
            }
            if (_tempStok!=null)
            {
                TBStokAdı.Text = _tempStok.KOD.ToString();
            }
            
        }

        void DataGrideBilgiGetir()
        {
            if (_arasıtransfer != null)
            {
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = _depoTransferHarServis.Getir(x => x.DEPOTRANSFERID == _arasıtransfer.ID);
            }

        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            if (_tempStok != null && _arasıtransfer!=null)
            {
                _depoTransferHarServis.Ekle(new MPDEPOTRANSFERHAR
                {
                    DEPOTRANSFERID = _arasıtransfer.ID,
                    OLUSTURMATARIHI = DateTime.Now,
                    GUNCELLEMETARIHI = DateTime.Now,
                    STOKID =_tempStok.ID,
                    MIKTAR=Convert.ToInt32(TBMiktar.Text),
                    DONEM=DateTime.Now.ToString("yyyy"),
                   // ACIKLAMA = TBAciklama.Text

            });
            }
            else
            {
                MessageBox.Show("Stok veya Transfer Seçmeden Kaydedemezsiniz!");
            }

        }

        private void BTNStokSec_Click(object sender, EventArgs e)
        {

            FStokList fStokList = new FStokList("FDepolarArasıTransferHar");
            fStokList.ShowDialog();
            if (_tempStok != null)
                if (_tempStok.ID > 0)
                {

                    DOLDUR();
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           _depoTransferHarServis.Sil(_depoTransferHarServis.Getir(x=>x.ID ==Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value)));
        }
    }
}
