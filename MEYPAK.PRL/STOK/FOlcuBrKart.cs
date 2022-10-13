using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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
using static System.Net.Mime.MediaTypeNames;

namespace MEYPAK.PRL.STOK
{
    public partial class FOlcuBrKart : Form
    {
        string islemtipi = "Kayıt";
        public FOlcuBrKart()
        {
            InitializeComponent();
        }
        IOlcuBrServis _OlcuBrServis = new OlcuBrManager(new EFOlcuBrRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        private void FStokOlcuBrKart_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }
        int id;
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            Interfaces.Durum snc;
            if (islemtipi == "Kayıt")
                snc = _OlcuBrServis.EkleyadaGuncelle(new Entity.Models.STOK.MPOLCUBR()
                {
                    ADI = TBOlcuBrAdi.Text,
                    BIRIM = TBOlcuBr.Text,
                });
            else
                snc = _OlcuBrServis.EkleyadaGuncelle(new Entity.Models.STOK.MPOLCUBR()
                {
                    ID = id,
                    ADI = TBOlcuBrAdi.Text,
                    BIRIM = TBOlcuBr.Text,
                });
            MessageBox.Show("Kayıt Başarılı.");
            id = 0;
            DataGridDoldur();
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            if (_OlcuBrServis.Sil(x => x.ID.ToString() == dataGridView1.CurrentRow.Cells[0].Value.ToString())) ;
            MessageBox.Show("Silme Başarılı");
            dataGridView1.DataSource = _OlcuBrServis.Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TBOlcuBrAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TBOlcuBr.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            islemtipi = "Güncelleme";
        }
        void DataGridDoldur()
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = _OlcuBrServis.Listele();
        }

    }
}