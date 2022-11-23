using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.PRL.IRSALIYE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FFaturaList : Form
    {
        public FFaturaList(string tag = "",string islem="")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
        }

        string _form, _islem;
       
        FFatura ffatura;
        GenericWebServis<PocoFATURA> _faturaServis;


        private void FFaturaList_Load(object sender, EventArgs e)
        {
            _faturaServis = new GenericWebServis<PocoFATURA>();
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FFatura"))
                        ffatura = (FFatura)frm;
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _faturaServis.Data(ServisList.FaturaListeServis);
            if (_islem == "FFatura")
            {
                if (ffatura != null)
                {
                    ffatura._tempFatura = _faturaServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

            }
          
            this.Close();
        }
    }
}
