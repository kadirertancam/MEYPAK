using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.DEPO
{
    public partial class FDepoList : Form
    {
        public FDepoList()
        {
            InitializeComponent();
            depoKart = (FDepoKart)Application.OpenForms["FDepoKart"];
        }
        FDepoKart depoKart;
        IDepoServis _depoServis = new DepoManager(new EFDepoRepo());

        private void FDepoList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _depoServis.Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            depoKart._tempDepo = _depoServis.Getir(x => x.DEPOKODU == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()).FirstOrDefault();
            this.Close();
        }
    }
}
