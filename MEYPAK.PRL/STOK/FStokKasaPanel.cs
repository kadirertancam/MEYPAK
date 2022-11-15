using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.STOK;
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
    public partial class FStokKasaPanel : Form
    {
        
        public FStokKasaPanel()
        {
            InitializeComponent();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
        }
        GenericWebServis<PocoSTOKKASA>_kasaServis;

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _kasaServis.Data(ServisList.StokKasaEkleServis, new PocoSTOKKASA
            {
                kasaadi = TBKasaAdi.Text,
                aciklama = TBAciklama.Text,
                kasakodu = TBKasaKodu.Text,
                olusturmatarihi = DateTime.Now,
            });
            MessageBox.Show("Kasa Başarıyla Eklendi.");
            Doldur();
        }

        private void FKasaPanel_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        void Doldur()
        {
            _kasaServis.Data(ServisList.StokKasaListeServis);
            DGKasaPanel.DataSource = "";
            DGKasaPanel.DataSource = _kasaServis.obje;
        }

        private void BTSil_Click(object sender, EventArgs e)
        {

        }
    }
}
