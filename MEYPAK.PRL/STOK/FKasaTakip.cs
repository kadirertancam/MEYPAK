using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.KASA;
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
    public partial class FKasaTakip : Form
    {
        public FKasaTakip()
        {
            InitializeComponent();
            _tempKasaTakipKalem = new List<KasaTakipKalem>();
            _tempKasaList = new GenericWebServis<PocoKASA>();
        }
        RepositoryItemLookUpEdit riLookup;
        GenericWebServis<PocoKASA> _tempKasaList; 
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        List<KasaTakipKalem> _tempKasaTakipKalem;
        FStokKasaList _fStokKasaList;
        private void FKasaTakip_Load(object sender, EventArgs e)
        {
            _tempKasaTakipKalem.Add(new KasaTakipKalem());

            gridControl1.DataSource=_tempKasaTakipKalem;
            gridControl1.RefreshDataSource();
            gridYapilandir();
        }


        void gridYapilandir()
        {
            _tempKasaList.Data(ServisList.KasaListeServis);
            GridColumn gridColumn = gridView1.Columns.AddVisible("Seç", "Seç");
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "Seç";
            repositoryItemButtonEdit.NullValuePrompt = "Seç";

            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            gridControl1.RepositoryItems.Add(repositoryItemButtonEdit);
            gridColumn.ColumnEdit = repositoryItemButtonEdit;
            gridView1.Columns["Seç"].VisibleIndex = 1;
        }

        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fStokKasaList = new FStokKasaList(this.Tag.ToString(), "kasaTakip");
            _fStokKasaList.ShowDialog();
        }
    }
}
