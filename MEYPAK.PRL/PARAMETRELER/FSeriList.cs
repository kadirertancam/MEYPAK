using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.PRL.CARI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.PARAMETRELER
{
    public partial class FSeriList : DevExpress.XtraEditors.XtraForm
    {
        public FSeriList(string form = "", string islem = "")
        {
            InitializeComponent();
            _seriServis = new GenericWebServis<PocoSERI>();
            _form = form;
            _islem = islem;
        }
        string _islem;
        string _form;
        GenericWebServis<PocoSERI> _seriServis;
        FSeriYetkilendirmeTanim _fSeriyetkilendirme;
        private void FSeriList_Load(object sender, EventArgs e)
        {

            _seriServis.Data(ServisList.SeriListeServis);
            gridControl1.DataSource = _seriServis.obje.Select(x => new { SERINO = x.SERINO, TIP = x.TIP == 0 ? "E-Fatura" : x.TIP == 1 ? "E-Arşiv" : x.TIP == 2 ? "E-Irsaliye" : "E-Müstahsil" });
            if (this.Tag == null)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (_form == frm.Tag)
                    {
                        if (frm.Name.Contains("FSeriYetkilendirme"))
                            _fSeriyetkilendirme = (FSeriYetkilendirmeTanim)frm;
                    }
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                if (_islem == "FSeriYetkilendirme")
                    _fSeriyetkilendirme._seritemp = _seriServis.obje.Where(x => x.SERINO.ToString() == gridView1.GetFocusedRowCellValue("SERINO").ToString()).FirstOrDefault();
                this.Close();
            }
            
        }
    }
}