using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
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
    public partial class FSayimList : Form
    {
        public FSayimList()
        {
            InitializeComponent();
        }
        IStokSayimServis _stokSayimServis ;
        FSayimIsle fSayimIsle;
        private void FSayimList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _stokSayimServis.Listele();
            fSayimIsle = (FSayimIsle)Application.OpenForms["FSayimIsle"];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["SAYIMTARIHI"].Value.ToString());
            string aciklama = dataGridView1.Rows[e.RowIndex].Cells["ACIKLAMA"].Value.ToString();
            fSayimIsle._tempSayim = _stokSayimServis.Getir(x => x.ACIKLAMA== aciklama.ToString() ).FirstOrDefault();
            fSayimIsle._id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            this.Close();
        }
    }
}
