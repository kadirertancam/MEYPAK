using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
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
    public partial class FStokFiyatList : Form
    {
        public FStokFiyatList()
        {
            InitializeComponent();
        }
        static MEYPAKContext _context=NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        IStokFiyatListServis _stokFiyatListServis = new StokFiyatListManager(new EFStokFiyatListRepo(_context));
     
        private void BTKayet_Click(object sender, EventArgs e)
        {
            //_stokFiyatListServis.Ekle()
        }
    }
}
