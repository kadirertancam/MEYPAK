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
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;

namespace MEYPAK.PRL.STOK
{
    public partial class FSayimList : Form
    {
        public FSayimList()
        {
            int secilen;
            InitializeComponent();
            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
        }
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis ;
        FSayimIsle fSayimIsle;
        private void FSayimList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _stokSayimServis.obje;
            fSayimIsle = (FSayimIsle)Application.OpenForms["FSayimIsle"];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dt = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["SAYIMTARIHI"].Value.ToString());
            string aciklama = dataGridView1.Rows[e.RowIndex].Cells["ACIKLAMA"].Value.ToString();
            fSayimIsle._tempSayim = _stokSayimServis.obje.Where(x => x.ACIKLAMA== aciklama.ToString() ).FirstOrDefault();
            fSayimIsle._id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.Close();
        }

       
        private void lookUpEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
