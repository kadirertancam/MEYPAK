using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
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
        FStokFiyatListPanel _stokFiyatListPanel;
        MPSTOKFIYATLIST _tempSTOKFIYATLIST;
        private void BTKayet_Click(object sender, EventArgs e)
        {
           _tempSTOKFIYATLIST=  _stokFiyatListServis.EkleyadaGuncelle(new Entity.Models.MPSTOKFIYATLIST()
            {
                FIYATLISTADI = TBFiyatListesiAdi.Text,
                BASTAR = DTPBastar.Value,
                BITTAR = DTPBittar.Value
            });
            _stokFiyatListPanel = new FStokFiyatListPanel(_tempSTOKFIYATLIST); 
            _stokFiyatListPanel.ShowDialog();

        }
    }
}
