using DevExpress.Pdf;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraRichEdit;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.SIPARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSarf : XtraForm
    {
        public FStokSarf()
        {
            InitializeComponent();
            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList = new DataGridViewComboBoxColumn();
            DGVKasaSec = new DataGridViewButtonColumn();
            DGVKasaList = new DataGridViewComboBoxColumn();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoServis.Data(ServisList.DepoListeServis);
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();
            _stokFiyatHarServis = new GenericWebServis<PocoSTOKFIYATHAR>();
            CBDepo.Properties.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).ToList();
            CBDepo.Text = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).FirstOrDefault();
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
            _tempKasaList = new List<KasaList>();
            _carialthescaricari = new GenericWebServis<PocoCARIALTHESCARI>();
            _kasaaa = new List<ListKasaList>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            _stokOlcuBrList = new List<StokOlcuBrTemp>();
            _hizmetServis = new GenericWebServis<PocoHIZMET>();
            _sarfServis = new GenericWebServis<PocoSTOKSARF>();
            _sarfDetayServis = new GenericWebServis<PocoSTOKSARFDETAY>();
            _tempSarfDetay = new List<PocoSarfKalem>();

        }

        #region TANIMLAR
        int fattip;
        GenericWebServis<PocoSTOKSARF> _sarfServis;
        GenericWebServis<PocoSTOKSARFDETAY> _sarfDetayServis;
        FStokKasaList fKasaList;
        List<PocoSarfKalem> _tempSarfDetay;
        List<PocoSarfKalem> _tempSilinenFaturaDetay = new List<PocoSarfKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        GenericWebServis<PocoCARIALTHESCARI> _carialthescaricari;
        PocoSarfKalem _tempPocokalem;
        FStokList _fStokList;
        FCariList _fCariList;
        PdfViewer pdfViewer1 = new PdfViewer();
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoSTOKSARF _tempSarf;
        public PocoHIZMET _tempHizmet;
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoSTOK> _stokServis;
        FStokKasaList _fStokKasaList;
        FHizmetList _fHizmetList;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        GenericWebServis<PocoSTOKFIYAT> _stokFiyatServis;
        GenericWebServis<PocoSTOKFIYATHAR> _stokFiyatHarServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        GenericWebServis<PocoHIZMET> _hizmetServis;
        List<KasaList> tempkasalist;
        FGetKunye _fGetKunye;
        RepositoryItemLookUpEdit riLookup, riLookup3;
        RepositoryItemButtonEdit repositoryItemButtonEdit;
        GridColumn gridColumn2;
        public List<ListKasaList> _kasaaa;
        List<ListKasaList> _silinenkasaaa = new List<ListKasaList>();
        public List<StokOlcuBrTemp> _stokOlcuBrList;
        public List<KasaList> _tempKasaList;
        StokOlcuBrTemp stokOlcuBrTemp = new StokOlcuBrTemp();
        List<OlcuBrlist> olcuBrlist1 = new List<OlcuBrlist>();
        int i;
        int num = 0;
        int tempnum;
        #endregion

        #region METHOD
        void temizle()
        {
            num = 0;
            GCIrsaliye.DataSource = "";
            _tempSarfDetay.Clear();
            _kasaaa.Clear();
            _tempSarfDetay.Add(new PocoSarfKalem());
            GCIrsaliye.DataSource = _tempSarfDetay;
            //DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["KasaId"].Visible = false;
            TBAciklama.Text = "";

            TBFaturaNo.Text = "";

            DTSiparisTarih.EditValue = DateTime.Now;

            CBDepo.EditValue = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).FirstOrDefault();



        }

        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempSarfDetay.Add(new PocoSarfKalem() { TIP = "STOK" });




            repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);


            RepositoryItemButtonEdit repositoryItemButtonEdit4 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repositoryItemButtonEdit4.NullText = "";
            repositoryItemButtonEdit4.NullValuePrompt = "";
            repositoryItemButtonEdit4.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit4.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit4.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);
            var datatb = new DataTable();
            datatb.Columns.Add("ID", typeof(int));
            datatb.Columns.Add("TIP", typeof(string));

            datatb.Rows.Add(0, "STOK");
            datatb.Rows.Add(1, "KASA");
        

            RepositoryItemButtonEdit repositoryItemButtonEdit5 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repositoryItemButtonEdit5.NullText = "";
            repositoryItemButtonEdit5.NullValuePrompt = "";
            repositoryItemButtonEdit5.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit5.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit5.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);


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

            //repoGV.Columns.Add(colun2);
            _tempKasaList = new List<KasaList>();
            riLookup3 = new RepositoryItemLookUpEdit();
            riLookup3.ValueMember = "ADI";
            riLookup3.DisplayMember = "ADI";

            riLookup3.NullText = "";
            riLookup3.BestFitWidth = 70;
            riLookup3.AutoHeight = true;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup3.DropDownRows = _tempKasaList.Count();
            riLookup3.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            riLookup3.EditValueChanged += RiLookup_EditValueChanged;
            GCIrsaliye.DataSource = _tempSarfDetay;
          
       
            gridView1.Columns["STOK"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["STOK"].ColumnEdit = repositoryItemButtonEdit;

            gridView1.Columns["TIP"].ColumnEdit = riLookup;
            gridView1.Columns["TIP"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["BIRIM"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["BIRIM"].ColumnEdit = repositoryItemButtonEdit5;
            gridView1.Columns["KUNYE"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["KUNYE"].ColumnEdit = repositoryItemButtonEdit4;
       
            //repoGV.Columns.Add(colun2);
            gridView1.Columns["KasaAdı"].ColumnEdit = riLookup3;


            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ADI", typeof(string));


            gridView1.BestFitColumns();
            RepositoryItemLookUpEdit riLookup2 = new RepositoryItemLookUpEdit();

            riLookup2.DataSource = dt;
            riLookup2.ValueMember = "ID";
            riLookup2.DisplayMember = "ADI";
            riLookup2.NullText = "Sec";
            riLookup2.NullValuePrompt = "Seç";

            riLookup2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup2.DropDownRows = datatb.Rows.Count;

            riLookup2.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            riLookup2.AutoSearchColumnIndex = 1;
            riLookup2.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            gridView1.Columns["Doviz"].OptionsColumn.AllowEdit = true;
            //repoGV.Columns.Add(colun2);
            gridView1.Columns["Doviz"].ColumnEdit = riLookup2;
            gridView1.Columns["Doviz"].ColumnEdit = riLookup2;

            gridView1.BestFitColumns();

            RepositoryItemLookUpEdit riLookup5 = new RepositoryItemLookUpEdit();
            riLookup5.NullText = "Sec";

            riLookup5.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup5.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            riLookup5.AutoSearchColumnIndex = 1;
            riLookup5.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            gridView1.Columns["Tevkifatno"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Tevkifatno"].ColumnEdit = riLookup5;



            RepositoryItemLookUpEdit riLookup6 = new RepositoryItemLookUpEdit();
            riLookup6.NullText = "Sec";

            riLookup6.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup6.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            riLookup6.AutoSearchColumnIndex = 1;
            riLookup6.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            gridView1.Columns["Istisnano"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Istisnano"].ColumnEdit = riLookup6;


           
            repositoryItemButtonEdit5.ButtonClick += RepositoryItemButtonEdit5_ButtonClick;
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            repositoryItemButtonEdit4.ButtonClick += RepositoryItemButtonEdit4_ButtonClick;



            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit4);

            gridView1.Columns["Daralı"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["Daralı"].DisplayFormat.FormatString = "n2";

            gridView1.Columns["Safi"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["Safi"].DisplayFormat.FormatString = "n2";
            gridView1.Columns["Safi"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["KdvTutarı"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["KdvTutarı"].DisplayFormat.FormatString = "n2";
            gridView1.Columns["KdvTutarı"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["İskontoTutarı"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["İskontoTutarı"].DisplayFormat.FormatString = "n2";
            gridView1.Columns["İskontoTutarı"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["NetToplam"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["NetToplam"].DisplayFormat.FormatString = "n2";
            gridView1.Columns["NetToplam"].OptionsColumn.AllowEdit = false;

            gridView1.Columns["BrütToplam"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["BrütToplam"].DisplayFormat.FormatString = "n2";
            gridView1.Columns["BrütToplam"].OptionsColumn.AllowEdit = false;


            gridView1.Columns["StokId"].Visible = false;

            gridView1.Columns["KasaId"].Visible = false;
            gridView1.Columns["id"].Visible = false;
            gridView1.Columns["Tipi"].UnboundDataType = System.Type.GetType("System.String");
            GCIrsaliye.ForceInitialize();
        }






        void Doldur()
        {
            if (_tempSarf!=null)
            {
                TBFaturaNo.Text = _tempSarf.SARFNO;
                CBDepo.EditValue = _depoServis.obje.Where(x => x.id == _tempSarf.DEPOID);
                DTSiparisTarih.EditValue = _tempSarf.TARIH;

                _sarfDetayServis.Data(ServisList.StokSarfDetayListeServis);

                GCIrsaliye.DataSource = _sarfDetayServis.obje.Where(x=>x.SARFID==_tempSarf.id);
            }
        }



        #endregion

        #region EVENTS
        private void RepositoryItemButtonEdit5_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId")) > 0)
            {
                FStokOlcuBrList aa = new FStokOlcuBrList(this.Tag.ToString(), "FStokSarf", Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId")));
                aa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Stok Seçiniz!");
            }
        }

        private void RepositoryItemButtonEdit4_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fGetKunye = new FGetKunye(this.Tag.ToString(), "FStokSarf");
            _fGetKunye.ShowDialog();

        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup.GetDataSourceRowByDisplayValue(riLookup.Name);
        }

        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Tipi") == "STOK")
            {
                if (_kasaaa.Where(x => x.num.ToString() == gridView1.FocusedRowHandle.ToString()).Count() > 0)
                {

                    fKasaList = new FStokKasaList(this.Tag.ToString(), "FStokSarf", gridView1.FocusedRowHandle.ToString(), _kasaaa);
                }
                else
                {
                    fKasaList = new FStokKasaList(this.Tag.ToString(), "FStokSarf", gridView1.FocusedRowHandle.ToString());
                }
                fKasaList.ShowDialog();
                if (_kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Count() > 0)
                {
                    riLookup3.DataSource = _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).FirstOrDefault().KasaList.Select(x => new { Marka = x.MARKA, Adı = x.KASAADI, Miktar = x.MIKTAR });

                    gridView1.SetFocusedRowCellValue("KasaMiktar", _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Select(x => x.KasaList.Sum(z => z.MIKTAR)).FirstOrDefault().ToString());
                    //   _tempSarfDetay.Where(x => x.sıra == gridView1.FocusedRowHandle).FirstOrDefault().KasaMiktar = Convert.ToDecimal(_kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Select(x => x.KasaList.Sum(z => z.MIKTAR)));
                }

                GCIrsaliye.RefreshDataSource();
            }
        }

        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if (gridView1.GetFocusedRowCellValue("TIP") == "STOK")
            {


                OlcuBrlist temppp = new OlcuBrlist();
               
                

                _fStokList = new FStokList(this.Tag.ToString(), "FStokSarf");
                _fStokList.ShowDialog();
                if (_tempStok.id != 0)
                {

                    gridView1.SetFocusedRowCellValue("TIP", "STOK");
                    gridView1.SetFocusedRowCellValue("StokId", _tempStok.id);
                    gridView1.SetFocusedRowCellValue("StokKodu", _tempStok.kod);
                    gridView1.SetFocusedRowCellValue("StokAdı", _tempStok.adi);
                    gridView1.SetFocusedRowCellValue("Kdv", _tempStok.satiskdv);
                    gridView1.SetFocusedRowCellValue("Birim", _stokOlcuBr.obje.Where(x => x.stokid == _tempStok.id).Select(x => _olcuBr.obje.Where(z => z.id == x.olcubrid).FirstOrDefault().adi).FirstOrDefault().ToString());
                    //}


                    //gridView1.SetFocusedRowCellValue("Birim", _olcuBr.obje.Where(y=>y.id == _stokOlcuBr.obje.Where(x => x.stokid == _tempStok.id).FirstOrDefault().olcubrid).FirstOrDefault().adi.ToString());


                    //GCIrsaliye.DataSource = _tempSarfDetay;
                    GCIrsaliye.RefreshDataSource();

                }

            }
            else if (gridView1.GetFocusedRowCellValue("TIP") == "KASA")
            {

                _fStokKasaList = new FStokKasaList(this.Tag.ToString(), "FStokSarf");
                _fStokKasaList.ShowDialog();
                if (_tempKasa != null)
                {
                    _tempPocokalem = new PocoSarfKalem()
                    {
                        TIP = "KASA",
                        KASAID = _tempKasa.id,
                        MIKTAR=0,
                        BIRIM = 0,//_olcuBr.obje.Where(x => x.adi == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().adi,
                                   //KasaAdı = "",
                    
                    };
                    _tempSarfDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
                    GCIrsaliye.DataSource = _tempSarfDetay;
                }

            }
           

            /* DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();*/ //////////////////////////// BAKILCAK

            gridView1.RefreshData();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tempnum = gridView1.GetFocusedDataSourceRowIndex();
            if (_kasaaa.Where(x => x.num == tempnum).Count() > 0)
                riLookup3.DataSource = _kasaaa.Where(x => x.num == tempnum).FirstOrDefault().KasaList.Select(x => new { Marka = x.MARKA, Adı = x.KASAADI, Miktar = x.MIKTAR });
            else
                if (riLookup3 != null)
                riLookup3.DataSource = "";

        }



        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

        // Declare a string to hold the entire document contents.
        private string documentContents;

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint;
        List<string> fileList = new List<string>();
        RichEditDocumentServer server;
        PerformanceCounter counter;
        PrintPreviewDialog prv;
        PrintDocument prndc;





        private void gridView1_ColumnChanged(object sender, EventArgs e)
        {
            if (gridView1.FocusedColumn != null)
                if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns.View.VisibleColumns.Count)
                    MessageBox.Show("testt");
        }

        private void BTKaydet_Click_1(object sender, EventArgs e)
        {
            _sarfServis.Data(ServisList.StokSarfEkleServis, new PocoSTOKSARF()
            {
                id = _tempSarf != null ? _tempSarf.id : 0,
                ACIKLAMA = TBAciklama.Text,
                SARFNO = TBFaturaNo.Text,
                TARIH = (DateTime)DTSiparisTarih.EditValue,
                guncellemetarihi = DateTime.Now,
                DEPOID = _depoServis.obje.Where(x => x.depoadi == CBDepo.EditValue).FirstOrDefault().id,

            });

            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            int i = 0;
            _stokHarServis.Data(ServisList.StokHarListeServis);

            foreach (var item in _tempSarfDetay.Where(x => x.STOKID != 0 && x.STOKID != null).ToList())
            {
                var stokolcubr = _stokOlcuBr.obje.Where(x => x.stokid == item.STOKID).FirstOrDefault();
                _sarfDetayServis.Data(ServisList.StokSarfDetayEkleServis, new PocoSTOKSARFDETAY()
                {
                    id = item.id,
                    STOKID = item.STOKID,
                    ACIKLAMA = item.ACIKLAMA,
                    BIRIMID = item.TIP == "STOK" ? _olcuBr.obje.Where(y => y.id == item.BIRIM).FirstOrDefault().id : 0,
                    MIKTAR = item.MIKTAR,
                    SARFID = _sarfServis.obje2.id, ///ID gelecek
                    KUNYE = item.KUNYE != null ? item.KUNYE : "",
                    TIP = item.TIP == "STOK" ? Convert.ToByte(0) : Convert.ToByte(1)

                }) ;

                if (item.TIP == "STOK")
                {

                    _stokHarServis.Data(ServisList.StokHarEkleServis, new Entity.PocoModels.STOK.PocoSTOKHAR()
                    {
                        id = _stokHarServis.obje.Where(x => x.sarfdetayid == _sarfDetayServis.obje2.id).Count() > 0 ? _stokHarServis.obje.Where(x => x.sarfdetayid == _sarfDetayServis.obje2.id).FirstOrDefault().id : 0,
                        sarfdetayid = _sarfDetayServis.obje2.id,
                        sarfid = _sarfServis.obje2.id,
                        aciklama = item.ACIKLAMA,
                        belgE_NO = _sarfServis.obje2.SARFNO,
                        hareketturu = 12,
                        birim = _olcuBr.obje.Where(x => x.id == item.BIRIM).FirstOrDefault().id,
                     
                        depoid = _sarfServis.obje2.DEPOID,
                        io = 0,
                        miktar = item.MIKTAR,
                        stokid = item.STOKID,
                        sayimid = 0,
                        kunye = item.KUNYE,
                    });
                }
                i++;
                //_kasaServis.Data(ServisList.StokKasaListeServis);
            }

            if (_tempSilinenFaturaDetay.Count() > 0)
            {
                foreach (var item in _tempSilinenFaturaDetay)
                {
                    _sarfDetayServis.Data(ServisList.StokSarfDetayDeleteByIdServis, id: item.id.ToString(), method: System.Net.Http.HttpMethod.Post);
                    _stokHarServis.Data(ServisList.StokHarSilServis, modellist: _stokHarServis.obje.Where(x => x.faturadetayid == item.id).ToList());
                }
                if (_silinenkasaaa.Count() > 0)
                {
                    foreach (var item in _silinenkasaaa)
                    {
                        foreach (var item2 in item.KasaList)
                        {
                            _stokKasaHarServis.Data(ServisList.StokKasaHarSilServis, modellist: _stokKasaHarServis.obje.Where(x => x.id == item2.ID).ToList());
                        }
                    }
                }
            }

            temizle();

        }




        void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                num++;
                _tempSarfDetay.Add(new PocoSarfKalem());
                GCIrsaliye.DataSource = _tempSarfDetay;

                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                gridView1.FocusedColumn = gridView1.Columns["StokKodu"];
          
                gridView1.Columns["StokId"].Visible = false;
                GCIrsaliye.RefreshDataSource();
            }

        }

        void FFatura_Load(object sender, EventArgs e)
        {



            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _hizmetServis.Data(ServisList.HizmetListeServis);
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            DataGridYapilandir();

            DTSiparisTarih.EditValue = DateTime.Now;
            Doldur();
        }

        void BTNSatirSil_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle > -1)
            {
                _tempSilinenFaturaDetay.Add(new PocoSarfKalem()
                {
                    id = _tempSarfDetay[gridView1.FocusedRowHandle].id
                }
               );
                _tempSarfDetay.Remove(_tempSarfDetay[gridView1.FocusedRowHandle]);
                if (_kasaaa.Count() > gridView1.FocusedRowHandle)
                {
                    _silinenkasaaa.Add(_kasaaa[gridView1.FocusedRowHandle]);
                    _kasaaa.Remove(_kasaaa[gridView1.FocusedRowHandle]);
                }
            }

            GCIrsaliye.RefreshDataSource();
        }



        void TBSiparisNo_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FStokSarfListe fStokSarfListe = new FStokSarfListe(this.Tag.ToString(), "FStokSarf");
            fStokSarfListe.ShowDialog();
            Doldur();

        }


        #endregion
    }
}




