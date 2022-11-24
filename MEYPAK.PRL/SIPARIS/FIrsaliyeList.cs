using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Interfaces.Siparis;
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
    public partial class FIrsaliyeList : XtraForm
    {
        string _form,_islem; 
        public FIrsaliyeList(string frm="",string islem="")
        {
            InitializeComponent();
            _form = frm;
            _islem = islem;
            _mIrsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
        }
        FSatisIrsaliye fsatisIralsiye;
        GenericWebServis<PocoIRSALIYE> _mIrsaliyeServis;
        

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _mIrsaliyeServis.Data(ServisList.SiparisListeServis);
            if (_islem == "FSatisIrsaliye")
            {
                if (fsatisIralsiye != null)
                {
                    fsatisIralsiye._tempIrsaliye = _mIrsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

            }
            if (_islem == "FAlisIrsaliye")
            {
                //if (fsatinalmaSiparis != null)
                //{
                //    fsatinalmaSiparis._tempSiparis = _mIrsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                //}
            }
            this.Close();
        }

        private void FIrsaliyeList_Load(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FSatisIrsaliye"))
                        fsatisIralsiye = (FSatisIrsaliye)frm; 
                }
            }
            _mIrsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            if (_islem == "FSatisIrsaliye")
                gridControl1.DataSource = _mIrsaliyeServis.obje.Where(x => x.tip == 1).Select(x => new
                {
                    ID = x.id,
                    x.irsaliyetarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                });
            if (_islem == "FAlisIrsaliye")
                gridControl1.DataSource = _mIrsaliyeServis.obje.Where(x => x.tip == 0).Select(x => new
                {
                    ID = x.id,
                    x.irsaliyetarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                });
        }
    }
}
