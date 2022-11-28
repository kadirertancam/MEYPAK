using DevExpress.DataProcessing.InMemoryDataProcessor.GraphGenerator;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
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
    public partial class FMarkaList : XtraForm
    {
        FMarkaKart FMarkaKart;
        FStokKart fStokKart;
        GenericWebServis<PocoSTOKMARKA> _markaServis;
        string _islem;
        string _form;
        public FMarkaList(string form = "", string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
            fStokKart = (FStokKart)Application.OpenForms["FStokKart"];
        } 
        private void FMarkaKart_Load(object sender, EventArgs e)
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            gridControl1.DataSource= _markaServis.obje.Where(x=>x.kayittipi==0);
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FStokKart"))
                        fStokKart = (FStokKart)frm;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            FMarkaKart = new FMarkaKart();
            FMarkaKart.ShowDialog();
            _markaServis.Data(ServisList.StokMarkaListeServis);
            gridControl1.DataSource = _markaServis.obje.Where(x=>x.kayittipi==0);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem =="stokkart")
            {
                fStokKart._tempMarka = _markaServis.obje.Where(x =>x.kayittipi==0 &&x.id.ToString() == gridView1.GetFocusedRowCellValue("id").ToString()).FirstOrDefault();
            }
            this.Close();
        }
    }
}
