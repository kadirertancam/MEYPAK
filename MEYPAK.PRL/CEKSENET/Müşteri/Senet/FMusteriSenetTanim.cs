using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET
{
    public partial class FMusteriSenetTanim : XtraForm
    {
        
        public FMusteriSenetTanim()
        {
            InitializeComponent();
            _cariServis = new GenericWebServis<PocoCARIKART>();
        }

        #region Tanımlar
        GenericWebServis<PocoCARIKART> _cariServis;
        PocoCARIKART _tempCariKart;
        public PocoCEKSENETUSTSB tempCekSenetUstSb;

        #endregion

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _tempCariKart = null;
            FCariList fCariList = new FCariList(this.Tag.ToString(), "musterisenet");
            fCariList.ShowDialog();
             
        }
    }
}
