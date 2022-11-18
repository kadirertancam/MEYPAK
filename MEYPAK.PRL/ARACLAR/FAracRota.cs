using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Personel;
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

namespace MEYPAK.PRL.ARACLAR
{
    public partial class FAracRota : Form
    {
        public FAracRota()
        {
            InitializeComponent();
            _aracServis = new GenericWebServis<PocoARAC>();
            _aracRotaServis = new GenericWebServis<PocoARACROTA>();
            _tempAracRota = new List<PocoARACROTA>();
            _personelServis = new GenericWebServis<PocoPERSONEL>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            GridYapılandır();
        }
        RepositoryItemLookUpEdit riLookuparac;
        RepositoryItemLookUpEdit riLookupdepo;
        GenericWebServis<PocoARAC> _aracServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoARACROTA> _aracRotaServis;
        GenericWebServis<PocoPERSONEL> _personelServis;
        DataTable datatb;
        List<PocoARACROTA> _tempAracRota;

        public void GridYapılandır()
        {
            _tempAracRota.Clear();
            _tempAracRota = new List<PocoARACROTA>();
            _personelServis.Data(ServisList.PersonelListeServis);
            if (_aracRotaServis.obje != null)
            {
                foreach (var item in _aracRotaServis.obje)
                {
                    _tempAracRota.Add(item);
                }
            }
            _tempAracRota.Add(new PocoARACROTA());
            _aracRotaServis.Data(ServisList.AracRotaListeServis);
            gridControl1.DataSource = _tempAracRota;
            var datatb = new DataTable();
            datatb.Columns.Add("aracid", typeof(int));
            datatb.Columns.Add("aracplaka", typeof(string));

            _aracServis.Data(ServisList.AracListeServis);
            foreach (var item in _aracServis.obje)
            {
                datatb.Rows.Add(item.id, item.plaka + " - " + _personelServis.obje.Where(x => x.id == item.soforid).FirstOrDefault().adisoyadi);
            }

            riLookuparac = new RepositoryItemLookUpEdit();
            riLookuparac.DataSource = datatb;
            riLookuparac.ValueMember = "aracid";
            riLookuparac.DisplayMember = "aracplaka";
            riLookuparac.NullText = "Sec";
            riLookuparac.HotTrackItems = true;
            riLookuparac.BestFitWidth = 120;
            //riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookuparac.DropDownRows = datatb.Rows.Count;
            riLookuparac.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookuparac.AutoSearchColumnIndex = 1;
            riLookuparac.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;


            gridView1.Columns["aracid"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["aracid"].ColumnEdit = riLookuparac;
            gridView1.Columns["aracid"].Width = 120;


            datatb = new DataTable();
            datatb.Columns.Add("id", typeof(int));
            datatb.Columns.Add("depoadi", typeof(string));
            _depoServis.Data(ServisList.DepoListeServis);
            foreach (var item in _depoServis.obje)
            {
                datatb.Rows.Add(item.id, item.depokodu + " - " + item.depoadi);
            }



            riLookupdepo = new RepositoryItemLookUpEdit();
            riLookupdepo.DataSource = datatb;
            riLookupdepo.ValueMember = "id";
            riLookupdepo.DisplayMember = "depoadi";
            riLookupdepo.NullText = "Sec";
            riLookupdepo.HotTrackItems = true;
            riLookupdepo.BestFitWidth = 120;
            riLookupdepo.DropDownRows = datatb.Rows.Count;
            riLookupdepo.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookupdepo.AutoSearchColumnIndex = 1;
            riLookupdepo.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            gridView1.Columns["cikisid"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["cikisid"].ColumnEdit = riLookupdepo;
            gridView1.Columns["cikisid"].Width = 120;

            gridView1.Columns["hedefid"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["hedefid"].ColumnEdit = riLookupdepo;
            gridView1.Columns["hedefid"].Width = 120;
        }

        private void BTNAracKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gridView1.GetFocusedRowCellValue("aracid").ToString());

            foreach (var item in _tempAracRota)
            {
                if (item != null)
                {
                        _aracRotaServis.Data(ServisList.AracRotaEkleServis, new PocoARACROTA()
                        {
                            id = item.id,
                            aracid = item.aracid,
                            hedefid = item.hedefid,
                            cikisid = item.cikisid,
                            tarih = item.tarih,
                            hareketsaati = item.hareketsaati,
                        });
                }
            }
            GridYapılandır();


        }

        private void dateEdit1_DateTimeChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                gridControl1.DataSource = "";
                _tempAracRota.Add(new PocoARACROTA());
                gridControl1.DataSource = _tempAracRota;
            }
        }
    }
}
