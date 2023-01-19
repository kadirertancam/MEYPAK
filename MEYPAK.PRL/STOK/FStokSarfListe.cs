using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.DEPO.Raporlar;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK.Raporlar;
using Syncfusion.XlsIO.Implementation.PivotAnalysis;
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
    public partial class FStokSarfListe : XtraForm
    {
        public FStokSarfListe(string form,string islem)
        {
            InitializeComponent();
            _islem= islem;
            _form= form;
            _stokSarf = new GenericWebServis<PocoSTOKSARF>();
        }
        string _form;
        string _islem;
        GenericWebServis<PocoSTOKSARF> _stokSarf;
        FStokSarf fstokSarf;

        private void FStokSarfListe_Load(object sender, EventArgs e)
        {
            _stokSarf.Data(ServisList.StokSarfListeServis);

            gridControl1.DataSource= _stokSarf.obje;

            foreach (Form frm in Application.OpenForms)
            {
                
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FStokSarf"))
                        fstokSarf = (FStokSarf)frm;
                }
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem=="FStokSarf")
            {
                if (fstokSarf!=null)
                    fstokSarf._tempSarf = _stokSarf.obje.Where(x=> x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();

            }
            this.Close();
        }
    }
}
