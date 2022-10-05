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
        
        int id;
        string _islem;
        public FKategoriList(string islem="")
        {
            InitializeComponent();
            this._islem = islem;
        }
        IKategoriServis _kategoriServis;
        private void FKategoriList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _kategoriServis.Listele().Select(x => new { x.ID, x.Acıklama }).ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
