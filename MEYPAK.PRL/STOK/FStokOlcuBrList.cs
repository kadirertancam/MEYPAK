using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.SIPARIS;
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
    public partial class FStokOlcuBrList : Form
    {
        string _form;
        public FStokOlcuBrList(string form="")
        {
            InitializeComponent();
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _form = form;
        }
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        FMusteriSiparis musteriSiparis;
        public int stokid;
        private void FStokOlcuBrList_Load(object sender, EventArgs e)
        {
           
        }

        private void FStokOlcuBrList_Load_1(object sender, EventArgs e)
        {
            musteriSiparis = (FMusteriSiparis)Application.OpenForms["FMusteriSiparis"];
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            GCStokOlcuBrList.DataSource = _stokOlcuBr.obje.Where(x=>x.STOKID==stokid).Select(x=> _olcuBr.obje.Where(z=>z.id==x.OLCUBRID).Select(z=>z.adi).FirstOrDefault()).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_form == "musterisiparis")
                musteriSiparis.gridView1.SetFocusedRowCellValue("Birim", gridView1.GetFocusedRowCellValue("Column"));
            this.Close();
        }
    }
}
