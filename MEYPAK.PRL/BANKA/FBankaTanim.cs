using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.BANKA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.BANKA
{
    public partial class FBankaTanim : DevExpress.XtraEditors.XtraForm
    {
        public FBankaTanim()
        {
            InitializeComponent();
            _bankaServis = new GenericWebServis<MPBANKA>();
        }
        GenericWebServis<MPBANKA> _bankaServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //_bankaServis.Data()
        }
    }
}