using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEKONT;
using MEYPAK.Entity.PocoModels.DEPO;
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

namespace MEYPAK.PRL.DEKONT
{
    public partial class FDekont : DevExpress.XtraEditors.XtraForm
    {
        public FDekont()
        {
            InitializeComponent();
            dekontServis = new GenericWebServis<PocoDEKONT>();
            cariKartServis = new GenericWebServis<PocoCARIKART>();
            cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            depoServis = new GenericWebServis<PocoDEPO>(); 
        }
        GenericWebServis<PocoDEKONT> dekontServis;
        List<DekontTemplate> _tempDekont;
        GenericWebServis<PocoCARIKART> cariKartServis;
        GenericWebServis<PocoCARIALTHES> cariAltHesServis;
        RepositoryItemButtonEdit repositoryItemButtonEdit;
        RepositoryItemLookUpEdit riLookup,riLookup2;
        GenericWebServis<PocoDEPO> depoServis;
        private void FDekont_Load(object sender, EventArgs e)
        {
            _tempDekont = new List<DekontTemplate>();
            _tempDekont.Add(new DekontTemplate()
            {
                TIP = "CARI"
            });
            _tempDekont.Add(new DekontTemplate()
            {
                TIP = "CARI"
            });
            gridControl1.DataSource=_tempDekont;
            var datatb = new DataTable();
            datatb.Columns.Add("ID", typeof(int));
            datatb.Columns.Add("TIP", typeof(string));

            datatb.Rows.Add(0, "CARI");
            datatb.Rows.Add(1, "KASA");
            datatb.Rows.Add(2, "BANKA");
            datatb.Rows.Add(3, "PERSONEL");
            datatb.Rows.Add(4, "MUHASEBE");


            riLookup = new RepositoryItemLookUpEdit();
            riLookup.DataSource = datatb;
            riLookup.ValueMember = "TIP";
            riLookup.DisplayMember = "TIP";
            riLookup.NullText = "Sec";

            riLookup.HotTrackItems = true;
            riLookup.BestFitWidth = 70;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup.DropDownRows = datatb.Rows.Count;
            riLookup.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookup.AutoSearchColumnIndex = 1;
            riLookup.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            riLookup.EditValueChanged += RiLookup_EditValueChanged;
            riLookup.GetDataSourceRowByKeyValue(0);

            depoServis.Data(ServisList.DepoListeServis);

            var datatb2 = new DataTable();

            datatb2.Columns.Add("ID", typeof(int));
            datatb2.Columns.Add("DEPO", typeof(string));
            
            foreach (var item in depoServis.obje.Where(x => x.kayittipi == 0))
            {
                datatb2.Rows.Add(item.id, item.depoadi);
            }

            riLookup2 = new RepositoryItemLookUpEdit();
            riLookup2.DataSource = datatb2;
            riLookup2.ValueMember = "DEPO";
            riLookup2.DisplayMember = "DEPO";
            riLookup2.NullText = "Sec";

            riLookup2.HotTrackItems = true;
            riLookup2.BestFitWidth = 70;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup2.DropDownRows = datatb.Rows.Count;
            riLookup2.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookup2.AutoSearchColumnIndex = 1;
            riLookup2.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            riLookup2.EditValueChanged += RiLookup_EditValueChanged;
            riLookup2.GetDataSourceRowByKeyValue(0);


            gridView1.Columns["TIP"].ColumnEdit = riLookup;
            gridView1.Columns["DEPO"].ColumnEdit = riLookup2;


        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}