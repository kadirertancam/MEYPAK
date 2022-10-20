using MEYPAK.BLL.PERSONEL;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Personel;
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
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelList : Form
    {
        FPersonelKart FPersonelKart;
        public FPersonelList()
        {
            InitializeComponent();
            FPersonelKart = (FPersonelKart)Application.OpenForms["FPersonelKart"];
            _personelServis.Data(ServisList.PersonelListeServis);
        }

        GenericWebServis<PocoPERSONEL> _personelServis ;
        private void FPersonelList_Load(object sender, EventArgs e)
        {
            _personelServis.Data(ServisList.PersonelListeServis);
            dataGridView1.DataSource= _personelServis.obje;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FPersonelKart._tempPersonel = _personelServis.obje.Where(x=>x.ID.ToString()==dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            this.Close();
        }
    }
}
