using DevExpress.XtraEditors;
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
    public partial class FCariDurum : XtraForm
    {
        public FCariDurum()
        {
            InitializeComponent();
            _cariDurumServis = new GenericWebServis<PocoCARIKART>();
        }
       GenericWebServis<PocoCARIKART> _cariDurumServis;
        FCariList fCariList;

        public PocoCARIKART _tempCariKart;
        private void BTKoduSec_Properties_ButtonClick(object sender, EventArgs e)
        {
            
        }
    }
}
