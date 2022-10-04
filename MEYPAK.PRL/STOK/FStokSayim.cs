using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
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
            stokSayimPanel = new FStokSayimPanel();
        }
        IStokSayimServis _stokSayimServis = new StokSayimManager(new EFStokSayimRepo());
        FStokSayimPanel stokSayimPanel;

        private void BTSayimKaydet_Click(object sender, EventArgs e)
        {
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
    }
}
