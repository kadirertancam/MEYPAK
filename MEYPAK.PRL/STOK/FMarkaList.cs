using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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
    public partial class FMarkaList : Form
    {
        FMarkaKart FMarkaKart;
        FStokKart FSTOKKART;
        public FMarkaList()
        {
            InitializeComponent();
            FSTOKKART = (FStokKart)Application.OpenForms["FSTOKKART"];
        }
        IMarkaServis _markaServis = new MarkaManager(new EFMarkaRepo());
        private void FMarkaKart_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= _markaServis.Listele();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FMarkaKart = new FMarkaKart();
            FMarkaKart.ShowDialog();
            dataGridView1.DataSource = _markaServis.Listele();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FSTOKKART._tempMarka = _markaServis.Getir(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            this.Close();
        }
    }
}
