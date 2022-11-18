using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.ARACLAR
{
    public partial class FAracRota : Form
    {
        public FAracRota()
        {
            InitializeComponent();
            _aracServis = new GenericWebServis<PocoARAC>();
            _aracRotaServis = new GenericWebServis<PocoARACROTA>();
            GridYapılandır();
        }
        RepositoryItemLookUpEdit riLookup;
        GenericWebServis<PocoARAC> _aracServis;
        GenericWebServis<PocoARACROTA> _aracRotaServis;
        DataTable datatb;
        public void GridYapılandır()
        {
            _aracRotaServis.Data(ServisList.AracRotaListeServis);
            gridControl1.DataSource = _aracRotaServis.obje;
           var datatb = new DataTable();
            datatb.Columns.Add("aracid", typeof(int));
            datatb.Columns.Add("aracplaka", typeof(string));
            datatb.Columns.Add("sofor", typeof(string));

            _aracServis.Data(ServisList.AracListeServis);

            foreach (var item in _aracServis.obje)
            {
                datatb.Rows.Add(item.soforid, item.plaka);
            }

            riLookup = new RepositoryItemLookUpEdit();
            riLookup.DataSource = datatb;
            riLookup.ValueMember = "aracid";
            riLookup.DisplayMember = "aracid";
            riLookup.NullText = "Sec";
            riLookup.HotTrackItems = true;
            riLookup.BestFitWidth = 70;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup.DropDownRows = datatb.Rows.Count;
            riLookup.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookup.AutoSearchColumnIndex = 1;
            riLookup.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True; 


            gridView1.Columns["aracid"].OptionsColumn.AllowEdit = true;
            //repoGV.Columns.Add(colun2);
            gridView1.Columns["aracid"].ColumnEdit = riLookup;

        }
    }
}
