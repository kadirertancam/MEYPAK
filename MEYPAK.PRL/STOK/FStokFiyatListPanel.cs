using MEYPAK.Entity.Models;
using MEYPAK.PRL.Assets;
using Ninject.Components;
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
    public partial class FStokFiyatListPanel : Form
    {
        public MPSTOKFIYATLIST _fiyatlist;
        FStokList _stoklist;
        public FStokFiyatListPanel(MPSTOKFIYATLIST fiyatlist)
        {
            InitializeComponent();
            this._fiyatlist = fiyatlist;
            _stoklist = NinjectFactory.CompositionRoot.Resolve<FStokList>();
        }
        public MPSTOK _tempStok;
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BTStokKaydet_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _stoklist.ShowDialog();
        }

        private void FStokFiyatListPanel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
