using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FKasaPanel : Form
    {
        
        public FKasaPanel()
        {
            InitializeComponent();
        }
        MEYPAKContext context = new MEYPAKContext();
        IKasaServis _kasaServis = new KasaManager(new EFKasaRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        private void BTStokKaydet_Click(object sender, EventArgs e)
        {
            _kasaServis.Ekle(new Entity.Models.MPKASA
            {
                KASAADI =TBKasaAdi.Text,
                ACIKLAMA = TBAciklama.Text,
                KASAKODU = TBKasaKodu.Text
            });
            Doldur();
        }

        private void FKasaPanel_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = _kasaServis.Listele();
        }
    }
}
