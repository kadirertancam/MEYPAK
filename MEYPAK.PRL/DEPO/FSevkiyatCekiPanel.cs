using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
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

namespace MEYPAK.PRL.DEPO
{
    public partial class FSevkiyatCekiPanel : Form
    {
        public FSevkiyatCekiPanel()
        {
            InitializeComponent();
        }
        static MEYPAKContext context=NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        IStokServis _stokServis = new StokManager(new EFStokRepo(context));
        List<MPSTOK> _tempStok;
        List<MPSTOK> _Stok;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void comboBox1_TextChanged(object sender, EventArgs e)
        //{

        //    //comboBox1.DataSource= (from aa in _stokServis.Listele() where aa.KOD.StartsWith(comboBox1.Text) select aa).ToList();
        //}

        private void FSevkiyatCekiPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=
            _tempStok = _stokServis.Listele();
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            comboBox1.AutoCompleteCustomSource.AddRange(_tempStok.Select(x=>x.KOD).ToArray()); 
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
   
           
        }
    }
}
