using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
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
    public partial class FDepolarArasıTransferBilgi : Form
    {
        MPDEPOTRANSFER _arasıtransfer;
        IDepoTransferServis _depoTransferServis = new DepoTransferManager(new EFDepoTransferRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        IDepoTransferBilgiServis _depoTransferBilgiServis = new DepoTransferBilgiManager(new EFDepoTransferBilgiRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        public FDepolarArasıTransferBilgi(MPDEPOTRANSFER arasıTransfer)
        {
            InitializeComponent();
            _arasıtransfer = arasıTransfer;
        }

      



        void DOLDUR()
        {
            TBCikisDepo.Text = _arasıtransfer.CIKTIDEPOID.ToString();
            TBHedefDepo.Text = _arasıtransfer.HEDEFDEPOID.ToString();
            TBDurum.Text=_arasıtransfer.DURUM.ToString();
            DTPOlusturmaTarihi.Value = _arasıtransfer.OLUSTURMATARIHI;
            
        }

        private void FDepolarArasıTransferBilgi_Load(object sender, EventArgs e)
        {
            DOLDUR();
        }
    }
}
