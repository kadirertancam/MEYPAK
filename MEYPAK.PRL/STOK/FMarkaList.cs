using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
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
    public partial class FMarkaList : Form
    {
        FMarkaKart FMarkaKart;
        FStokKart FSTOKKART;
        GenericWebServis<PocoSTOKMARKA> _markaServis;
        public FMarkaList()
        {
            InitializeComponent();
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
            FSTOKKART = (FStokKart)Application.OpenForms["FSTOKKART"];
        } 
        private void FMarkaKart_Load(object sender, EventArgs e)
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            DGMarkaList.DataSource= _markaServis.obje;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            FMarkaKart = new FMarkaKart();
            FMarkaKart.ShowDialog();
            _markaServis.Data(ServisList.StokMarkaListeServis);
            DGMarkaList.DataSource = _markaServis.obje;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FSTOKKART._tempMarka = _markaServis.obje.Where(x=>x.id.ToString()==DGMarkaList.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            this.Close();
        }
    }
}
