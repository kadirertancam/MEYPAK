using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using Ninject.Components;
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
    public partial class FStokFiyatListPanel : Form
    {
        int stokid=0;
        public List<MPSTOKFIYATLISTHAR> _mpStokFiyatListHar = new List<MPSTOKFIYATLISTHAR>();
        public MPSTOKFIYATLIST _fiyatlist;
        FStokList _stoklist;
        IStokServis _stokServis = new StokManager(new EFStokRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        IStokFiyatListHarServis _stokFiyatListHarServis = new StokFiyatListHarManager(new EFStokFiyatListHarRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        public FStokFiyatListPanel(MPSTOKFIYATLIST fiyatlist)
        {
            InitializeComponent();
            this._fiyatlist = fiyatlist;
            _stoklist = NinjectFactory.CompositionRoot.Resolve<FStokList>();
        }
        public MPSTOK _tempStok;
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BTStokKaydet_Click(object sender, EventArgs e)
        {
            DataGrideEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FStokList fStokList = new FStokList("stokkart");
            fStokList.ShowDialog();
            if (_tempStok != null)
                if (_tempStok.ID > 0)
                {
                    stokid = _tempStok.ID;
                    TBStokAdi.Text = _tempStok.KOD;
                }
        }

        private void FStokFiyatListPanel_Load(object sender, EventArgs e)
        {
            DataGridiDoldur();
        }
        void DataGridiDoldur()
        {
            if (_fiyatlist.ID != null && _stokFiyatListHarServis.Getir(x => x.FIYATLISTID == _fiyatlist.ID).Count>0)
            {   _mpStokFiyatListHar = _stokFiyatListHarServis.Getir(x =>x.FIYATLISTID==_fiyatlist.ID);
                dataGridView1.DataSource = _mpStokFiyatListHar;
            }
        }
        void DataGrideEkle()
        {
            if (_fiyatlist.ID != null && stokid!=0)
            {
                MPSTOKFIYATLISTHAR mpStok = new MPSTOKFIYATLISTHAR()
                {
                    FIYATLISTID = _fiyatlist.ID,
                    // DOVIZID=CMBDovizId.SelectedValue,
                    GUNCELLEMETARIHI = DateTime.Now,
                    NETFIYAT=Convert.ToInt32(TBFiyat.Text),
                    STOKID= stokid,
                    KUR=Convert.ToInt32(TBKur.Text)
                };

                _mpStokFiyatListHar.Add(mpStok);
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = _mpStokFiyatListHar;
            }
        }
    }
}
