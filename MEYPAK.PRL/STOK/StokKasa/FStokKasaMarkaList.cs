using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
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

namespace MEYPAK.PRL.STOK.StokKasa
{
    public partial class FStokKasaMarkaList :   XtraForm
    {
        string _form, _islem;
        public FStokKasaMarkaList(string frm="",string islem="")
        {
            InitializeComponent();
            _form = frm;
            _islem = islem;
            _stokKasaMarka = new GenericWebServis<PocoSTOKKASAMARKA>();
        }
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarka;
        FStokKasaPanel fStokKasaPanel;
        private void FStokKasaMarkaList_Load(object sender, EventArgs e)
        {
            _stokKasaMarka.Data(ServisList.StokKasaMarkaListeServis); 
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FStokKasa"))
                        fStokKasaPanel = (FStokKasaPanel)frm;
                }
            }
            gridControl1.DataSource = _stokKasaMarka.obje;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var cc = gridView1.GetFocusedRowCellValue("id").ToString();
            var test=(PocoSTOKKASAMARKA)_stokKasaMarka.obje.Where(x => x.id.ToString() == cc).FirstOrDefault();
            if (_islem == "FStokKasa")
                fStokKasaPanel._tempStokMarka = test;
            this.Close();
        }
    }
}
