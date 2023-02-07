using MEYPAK.Entity.PocoModels;
using System.Data;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using System.Linq;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Personel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayimPanel : XtraForm
    {
        public FStokSayimPanel(PocoSTOKSAYIM tempstoksayim, string form = "", string islemtipi = "")
        {
            InitializeComponent();
            this._islemtipi = islemtipi;
            this._form = form;
            _tempStokSayim = tempstoksayim;
            stokSayimHarServis = new GenericWebServis<PocoSTOKSAYIMHAR>();
            stokServis = new GenericWebServis<PocoSTOK>();
            depoServis = new GenericWebServis<PocoDEPO>();
            stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
            _olcubrServis = new GenericWebServis<PocoOLCUBR>();
            _stokolcubrServis = new GenericWebServis<PocoSTOKOLCUBR>();
        }
        #region Tanımlar
        string _islemtipi;
        string _form;
        PocoSTOKSAYIM _tempStokSayim;

        GenericWebServis<PocoSTOKSAYIMHAR> stokSayimHarServis;
        GenericWebServis<PocoSTOKSAYIM> stokSayimServis;
        GenericWebServis<PocoSTOK> stokServis;
        GenericWebServis<PocoDEPO> depoServis;
        GenericWebServis<PocoSTOKHAR> stokHarServis;
        GenericWebServis<PocoSTOKKATEGORI> kategoriServis;
        GenericWebServis<PocoOLCUBR> _olcubrServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokolcubrServis;
        #endregion


        #region Events
        private void FStokSayimPanel_Load(object sender, EventArgs e)
        {
            DataGridiYapılandır();
        }


        private void BTKaydet_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRowView row = gridView1.GetRow(i) as DataRowView;
                if (row != null)
                {
                    if (stokSayimHarServis.obje.Where(x => x.stokid == Convert.ToInt32(row.Row.ItemArray[0]) && x.stoksayimid == _tempStokSayim.id).Count() == 0)
                    {
                        if (Convert.ToInt32(row.Row.ItemArray[4]) != 0)
                        {
                            stokSayimHarServis.Data(ServisList.StokSayimHarEkleServis, new PocoSTOKSAYIMHAR()
                            {
                                stoksayimid = _tempStokSayim.id,
                                depoid = _tempStokSayim.depoid,
                                miktar = Convert.ToInt32(row.Row.ItemArray[4]),
                                stokid = Convert.ToInt32(row.Row.ItemArray[0]),
                                birimid = Convert.ToInt32(row.Row.ItemArray[5]),
                                userid = MPKullanici.ID,
                            });
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(row.Row.ItemArray[4]) != 0)
                        {
                            stokSayimHarServis.Data(ServisList.StokSayimHarEkleServis, new PocoSTOKSAYIMHAR()
                            {
                                id = stokSayimHarServis.obje.Where(x => x.stokid == Convert.ToInt32(row.Row.ItemArray[0]) && x.stoksayimid == _tempStokSayim.id).FirstOrDefault().id,
                                stoksayimid = _tempStokSayim.id,
                                depoid = _tempStokSayim.depoid,
                                miktar = Convert.ToInt32(row.Row.ItemArray[4]),
                                stokid = Convert.ToInt32(row.Row.ItemArray[0]),
                                birimid = Convert.ToInt32(row.Row.ItemArray[5]),
                                userid = MPKullanici.ID,
                            });
                        }
                        else
                        {
                            stokSayimHarServis.Data(ServisList.StokSayimHarSilServis, modellist: stokSayimHarServis.obje.Where(x => x.stokid == Convert.ToInt32(row.Row.ItemArray[0]) && x.stoksayimid == _tempStokSayim.id).ToList());

                        }
                    }
                }
            }
            MessageBox.Show("Sayım Hareketi Başarıyla Kaydedildi");
        }


        private void BTCik_Click(object sender, EventArgs e)
        {
            MessageBoxButtons.CancelTryContinue.Equals(false);
            this.Close();
        }


        private void pdfeAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pdfaktar(gridView1, $"Stok Sayım {DTPSayimTar.EditValue}");
        }


        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excelaktar(gridView1, $"Stok Sayım {DTPSayimTar.EditValue}");
        }
        #endregion


        #region Method
        public void Excelaktar(DevExpress.XtraGrid.Views.Grid.GridView GridView, string DosyaAdi)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Excel Çalışma Kitabı |*.xlsx",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = DosyaAdi
            };
            dialog.ShowDialog();
            gridView1.ExportToXlsx(dialog.FileName);
        }
        public void Pdfaktar(DevExpress.XtraGrid.Views.Grid.GridView GridView, string DosyaAdi)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Pdf Belgesi |*.pdf",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                FileName = DosyaAdi
            };
            dialog.ShowDialog();
            gridView1.ExportToPdf(dialog.FileName);
        }

        void DataGridiYapılandır()
        {
            depoServis.Data(ServisList.DepoListeServis);
            kategoriServis.Data(ServisList.StokKategoriListeServis);
            stokHarServis.Data(ServisList.StokHarListeServis);
            stokSayimHarServis.Data(ServisList.StokSayimHarListeServis);
            stokServis.Data(ServisList.StokListeServis);

            DTPSayimTar.EditValue = _tempStokSayim.sayimtarihi;
            TBDepo.EditValue = depoServis.obje.Where(x => x.id == _tempStokSayim.depoid).FirstOrDefault().depoadi;
            TBAciklama.Text = _tempStokSayim.aciklama;

            var datatb = new DataTable();
            DataColumn ID = new DataColumn("ID", typeof(int));
            datatb.Columns.Add(ID);
            DataColumn ADI = new DataColumn("ADI", typeof(string));
            datatb.Columns.Add(ADI);
            DataColumn KATEGORI = new DataColumn("KATEGORİ", typeof(string));
            datatb.Columns.Add(KATEGORI);
            DataColumn DEPOMIKTAR = new DataColumn("DEPODAKİMIKTAR", typeof(decimal));
            datatb.Columns.Add(DEPOMIKTAR);
            DataColumn SAYIMMIKTAR = new DataColumn("SAYIMMİKTARI", typeof(decimal));
            datatb.Columns.Add(SAYIMMIKTAR);
            DataColumn BİRİM = new DataColumn("BİRİM", typeof(int));
            datatb.Columns.Add(BİRİM);

            DGStokSayim.DataSource = datatb;
            ID.ReadOnly = true;
            ADI.ReadOnly = true;
            KATEGORI.ReadOnly = true;
            DEPOMIKTAR.ReadOnly = true;


            var datatab = new DataTable();
            datatab.Columns.Add("BİRİM", typeof(int));
            datatab.Columns.Add("adi", typeof(string));

            _olcubrServis.Data(ServisList.OlcuBrListeServis);
            foreach (var item in _olcubrServis.obje)
            {
                datatab.Rows.Add(item.id, item.adi);
            }

            RepositoryItemLookUpEdit riLookuparac = new RepositoryItemLookUpEdit();
            riLookuparac.DataSource = datatab;
            riLookuparac.ValueMember = "BİRİM";
            riLookuparac.DisplayMember = "adi";
            riLookuparac.NullText = "Sec";
            riLookuparac.HotTrackItems = true;
            riLookuparac.BestFitWidth = 60;
            riLookuparac.DropDownRows = datatab.Rows.Count;
            riLookuparac.AcceptEditorTextAsNewValue = DefaultBoolean.True;
            riLookuparac.AutoSearchColumnIndex = 1;
            riLookuparac.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            

            datatab.Columns[0].ColumnMapping = MappingType.Hidden;
            gridView1.Columns["BİRİM"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["BİRİM"].ColumnEdit = riLookuparac;
            gridView1.Columns["BİRİM"].Width = 60;


            foreach (var item in stokServis.obje.Where(x => x.kayittipi == 0))
            {
                datatb.Rows.Add(item.id, item.adi,
                    kategoriServis.obje.Where(y => y.id == item.kategoriid).FirstOrDefault().acıklama,
                    stokHarServis.obje.Where(z => z.depoid == _tempStokSayim.depoid && z.stokid == item.id && z.io == 1).Sum(z => z.miktar) - stokHarServis.obje.Where(z => z.depoid == _tempStokSayim.depoid && z.stokid == item.id && z.io == 0).Sum(z => z.miktar),
                    stokSayimHarServis.obje.Where(d => d.kayittipi == 0 && d.stoksayimid == _tempStokSayim.id && d.stokid == item.id).Count() == 0
                    ? 0 : stokSayimHarServis.obje.Where(d => d.kayittipi == 0 && d.stoksayimid == _tempStokSayim.id && d.stokid == item.id).FirstOrDefault().miktar,
                    item.olcubR1
                    );
            }

        }

        #endregion
    }
}
