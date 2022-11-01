using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
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
            _carikart = new GenericWebServis<PocoCARIKART>();
        }
        GenericWebServis<PocoCARIKART> _carikart;

        private void GCCariDurum_Click(object sender, EventArgs e)
        {
            _carikart.Data(ServisList.CariListeServis);

            gridLookUpEdit1.Properties.DataSource = _carikart.obje.Select(x => x.ADI);
        }
    }
}
