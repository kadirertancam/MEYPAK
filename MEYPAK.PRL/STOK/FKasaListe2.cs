using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
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
    public partial class FKasaListe2 : XtraForm
    {
        string _frm, _islem;
        public FKasaListe2(string frm="",string islem="")
        {
            InitializeComponent();
            _frm = frm;
            _islem = islem;
        } 
        private void FKasaListe2_Load(object sender, EventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
