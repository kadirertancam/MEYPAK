using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariDurum : Form
    {
        public FCariDurum()
        {
            InitializeComponent();
            _cariKart = new GenericWebServis<PocoCARIKART>();
        }
        GenericWebServis<PocoCARIKART> _cariKart;

        private void GCCariDurum_Click(object sender, EventArgs e)
        {
          
        }

        private void FCariDurum_Load(object sender, EventArgs e)
        {
            _cariKart.Data(ServisList.CariListeServis);

         //   gridLookUpEdit1.Properties.DataSource = _stok.obje.Select(x => x.adi);
        }

        private void LBCariKodu_Click(object sender, EventArgs e)
        {

        }
    }
}
