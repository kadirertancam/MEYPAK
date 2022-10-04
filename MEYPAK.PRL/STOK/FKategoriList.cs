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
    public partial class FKategoriList : Form
    {
        public FKategoriList()
        {
            InitializeComponent();
        }

        private void FKategoriList_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _stokServis.Listele().Select(x => new { x.ID, x.KOD, x.ADI, x.GRUPKODU, x.OLCUBR1, x.MARKAID }).ToList();
        }
    }
}
