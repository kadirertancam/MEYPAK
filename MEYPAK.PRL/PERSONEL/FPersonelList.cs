using MEYPAK.BLL.PERSONEL;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
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

namespace MEYPAK.PRL.PERSONEL
{
    public partial class FPersonelList : Form
    {
        FPersonelKart FPersonelKart;
        public FPersonelList()
        {
            InitializeComponent();
            FPersonelKart = (FPersonelKart)Application.OpenForms["FPersonelKart"];
        }

        IPersonelServis _personelServis = new PersonelManager(new EFPersonelRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        private void FPersonelList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= _personelServis.Listele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FPersonelKart._tempPersonel = _personelServis.Getir(x=>x.ID.ToString()==dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            this.Close();
        }
    }
}
