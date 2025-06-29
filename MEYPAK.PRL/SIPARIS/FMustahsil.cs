﻿using DevExpress.XtraEditors;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.PocoModels.MUSTAHSIL;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.STOK;
using MEYPAK.PRL.CARI;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraRichEdit;
using System.Diagnostics;
using System.Drawing.Printing;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.PRL.MUSTAHSIL;
using MEYPAK.Interfaces.Cari;

namespace MEYPAK.PRL.SIPARIS.Raporlar
{
    public partial class FMustahsil : XtraForm
    {

        public FMustahsil(PocoMUSTAHSIL _tempFaturas = null, List<PocoMustahsilKalem> _tempFaturaDetays = null, List<ListKasaList> _tempkasa = null, int tip = 0)
        {
            InitializeComponent();
            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList = new DataGridViewComboBoxColumn();
            DGVKasaSec = new DataGridViewButtonColumn();
            DGVKasaList = new DataGridViewComboBoxColumn();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoServis.Data(ServisList.DepoListeServis);
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();
            CBParaBirimi.Properties.DataSource = _paraBirimServis.obje.Where(x => x.kayittipi == 0).Select(x => x.adi).ToList();
            CBDepo.Properties.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).ToList();
            CBDepo.Text = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).FirstOrDefault();
            CBParaBirimi.Text = _paraBirimServis.obje.Where(x => x.kayittipi == 0 && x.adi == "TÜRK LİRASI").Select(x => x.adi).FirstOrDefault();
            _faturaServis = new GenericWebServis<PocoMUSTAHSIL>();
            _faturadetayServis = new GenericWebServis<PocoMUSTAHSILDETAY>();
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
            _tempKasaList = new List<KasaList>();
            _kasaaa = new List<ListKasaList>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            _stokOlcuBrList = new List<StokOlcuBrTemp>();
            kDVHesaps = new KDVHesap();
            _seriServis = new GenericWebServis<PocoSERI>();
            _seriHarServis = new GenericWebServis<PocoSERIHAR>();
            _hizmetHarServis = new GenericWebServis<PocoHIZMETHAR>();
            _hizmetServis = new GenericWebServis<PocoHIZMET>();
            _mustahsilCariServis = new GenericWebServis<PocoMUSTAHSILCARI>();
            _cariHarServsi = new GenericWebServis<PocoMUSTAHSILCARIHAR>();
            faturaBasim = new FaturaBasim();
            if (_tempFaturas != null)
                _tempFatura = _tempFaturas;
            if (_tempkasa != null)
                _kasaaa = _tempkasa;

            if (_tempFaturaDetays != null)
                _tempFaturaDetay = _tempFaturaDetays;
            else
                _tempFaturaDetay = new List<PocoMustahsilKalem>();
            fattip = tip;
           
         
        }

        #region TANIMLAR
        int fattip;
        FaturaBasim faturaBasim;
        FStokKasaList fKasaList;
        List<PocoMustahsilKalem> _tempFaturaDetay;
        List<PocoMustahsilKalem> _tempSilinenFaturaDetay = new List<PocoMustahsilKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        PocoMustahsilKalem _tempPocokalem;
        FStokList _fStokList;
        FCariList _fCariList;
        PdfViewer pdfViewer1 = new PdfViewer();
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoMUSTAHSIL _tempFatura;
        public PocoHIZMET _tempHizmet;
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        GenericWebServis<PocoMUSTAHSILCARI> _mustahsilCariServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoMUSTAHSIL> _faturaServis;
        GenericWebServis<PocoMUSTAHSILDETAY> _faturadetayServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoMUSTAHSILCARIHAR> _cariHarServsi;
        FStokKasaList _fStokKasaList;
        FHizmetList _fHizmetList;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        GenericWebServis<PocoSERIHAR> _seriHarServis;
        GenericWebServis<PocoSERI> _seriServis;
        GenericWebServis<PocoHIZMETHAR> _hizmetHarServis;
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
        KDVHesap kDVHesaps;
        int i;
        int num = 0;
        decimal birimfiyat = 0, kdv = 0, bsnc = 0, brutfiyat = 0, netfiyat = 0, nettoplam = 0, brüttoplam = 0, geneltoplam = 0, isktoplam = 0, kdvtoplam = 0, miktar = 0;
        int tempnum;
        int sx = 0;
        int sy = 0;
        int toplam = 0;
        decimal daralı, dara;
        #endregion

        #region METHOD

        void MustahsilCariDoldur()
        {
            //_mustahsilCariServis.Data(ServisList.MustahsilCariListeServis);
            //CBMustahsilCari.Properties.DataSource = _mustahsilCariServis.obje.Count()>0? _mustahsilCariServis.obje.Select(x => new { ID = x.id, ADI = x.ADI + " "+x.SOYADI }):"";
            //CBMustahsilCari.Properties.DisplayMember = "ADI";
            //CBMustahsilCari.Properties.ValueMember = "ID";
            //CBMustahsilCari.Properties.PopulateColumns();
            //CBMustahsilCari.Properties.Columns["ID"].Visible = false;
        }
        void temizle()
        {
            num = 0;
            GCIrsaliye.DataSource = "";
            _tempFaturaDetay.Clear();
            _kasaaa.Clear();
            _tempFaturaDetay.Add(new PocoMustahsilKalem());
            GCIrsaliye.DataSource = _tempFaturaDetay;
            //DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["KasaId"].Visible = false;
            TBAciklama.Text = "";
            TBAIskonto1.Text = "0";
            TBAIskonto2.Text = "0";
            TBAIskonto3.Text = "0";
            TBGun.Text = "0";
            TBFaturaNo.Text = "";
            TBIskontoToplam.EditValue = 0;
            TBBrutToplam.EditValue = 0;
            TBAraToplam.EditValue = 0;
            TBGenelToplam.EditValue = 0;
            TBKdvTutari.EditValue = 0;
            TBKur.Text = "0";
            DTPVadeTarihi.EditValue = DateTime.Now;
            DTSiparisTarih.EditValue = DateTime.Now;
            CBDepo.EditValue = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).FirstOrDefault();
            CBParaBirimi.EditValue = _paraBirimServis.obje.Where(x => x.kayittipi == 0 && x.adi == "TÜRK LİRASI").Select(x => x.adi).FirstOrDefault();
            CBMustahsilCari.EditValue = null;
            CHBKdvDahil.Checked = false;
            gridControl1.DataSource = "";
            faturaNoGuncelle();
        }

        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempFaturaDetay.Add(new PocoMustahsilKalem() { Tipi = "STOK" });




            repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);



            RepositoryItemButtonEdit repositoryItemButtonEdit3 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repositoryItemButtonEdit3.NullText = "";
            repositoryItemButtonEdit3.NullValuePrompt = "";
            repositoryItemButtonEdit3.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit3.Buttons[0].Kind = ButtonPredefines.Glyph;
            repositoryItemButtonEdit3.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);


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
            datatb.Rows.Add(1, "HIZMET");
            datatb.Rows.Add(2, "KASA");
            datatb.Rows.Add(3, "DEMIRBAS");
            datatb.Rows.Add(4, "MUHASEBE");

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
            GCIrsaliye.DataSource = _tempFaturaDetay;
            gridView1.Columns["sıra"].Visible = false;
            gridView1.Columns["KasaAdı"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["StokKodu"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["StokKodu"].ColumnEdit = repositoryItemButtonEdit;

            gridView1.Columns["Tipi"].ColumnEdit = riLookup;
            gridView1.Columns["Tipi"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Birim"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Birim"].ColumnEdit = repositoryItemButtonEdit5;
            gridView1.Columns["Kunye"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Kunye"].ColumnEdit = repositoryItemButtonEdit4;
            gridView1.Columns["KasaMiktar"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["KasaMiktar"].ColumnEdit = repositoryItemButtonEdit3;
            //repoGV.Columns.Add(colun2);
            gridView1.Columns["KasaAdı"].ColumnEdit = riLookup3;


            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ADI", typeof(string));
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            foreach (var item in _paraBirimServis.obje)
            {
                dt.Rows.Add(item.id, item.adi);
            }

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

           


            repositoryItemButtonEdit3.ButtonClick += RepositoryItemButtonEdit3_ButtonClick;
            repositoryItemButtonEdit5.ButtonClick += RepositoryItemButtonEdit5_ButtonClick;
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            repositoryItemButtonEdit4.ButtonClick += RepositoryItemButtonEdit4_ButtonClick;



            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit3);
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

            gridView1.Columns["StokKodu"].VisibleIndex = 4;
            gridView1.Columns["KasaMiktar"].VisibleIndex = 7;
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["Kunye"].VisibleIndex = 9;
            gridView1.Columns["Tipi"].VisibleIndex = 0;
            gridView1.Columns["Doviz"].VisibleIndex = 23;
            gridView1.Columns["KasaId"].Visible = false;
            gridView1.Columns["id"].Visible = false;
            gridView1.Columns["Tipi"].UnboundDataType = System.Type.GetType("System.String");
            GCIrsaliye.ForceInitialize();
        }

        void ToplamHesapla()
        {
            decimal isktoplam = 0;
            decimal temppte = 0;
            decimal nettop = 0;
            decimal kdvtoplamm = 0;
            decimal iskk = 0;
            if (TBAIskonto1.Text != "0" || TBAIskonto1.Text != "" || TBAIskonto2.Text != "0" || TBAIskonto2.Text != "" || TBAIskonto3.Text != "0" || TBAIskonto3.Text != "")
            {
                foreach (var item in _tempFaturaDetay)
                {
                    nettop = item.NetToplam;
                    nettop = nettop - ((nettop * Convert.ToDecimal(TBAIskonto1.Text)) / 100);
                    nettop = nettop - ((nettop * Convert.ToDecimal(TBAIskonto2.Text)) / 100);
                    nettop = nettop - ((nettop * Convert.ToDecimal(TBAIskonto3.Text)) / 100);
                    isktoplam = ((nettop * Convert.ToDecimal(TBAIskonto1.Text)) / 100) + ((nettop * Convert.ToDecimal(TBAIskonto2.Text)) / 100) + ((nettop * Convert.ToDecimal(TBAIskonto3.Text)) / 100);
                    temppte += nettop;
                    kdvtoplamm += ((nettop * item.Kdv) / 100);
                    iskk = decimal.Round((_tempFaturaDetay.Sum(x => x.İskontoTutarı)), 2);
                    isktoplam = isktoplam + iskk;
                }


                TBBrutToplam.EditValue = decimal.Round((_tempFaturaDetay.Sum(x => x.BrütToplam)), 2);
                TBAraToplam.EditValue = decimal.Round(temppte, 2);
                TBIskontoToplam.EditValue = (decimal.Round((_tempFaturaDetay.Sum(x => x.BrütToplam)), 2) - temppte);
                TBKdvTutari.EditValue = decimal.Round(kdvtoplamm, 2);
                TBGenelToplam.EditValue = decimal.Round((temppte + kdvtoplamm), 2);
            }
            else
            {

                TBBrutToplam.EditValue = decimal.Round(_tempFaturaDetay.Sum(x => x.BrütToplam), 2);
                TBIskontoToplam.EditValue = decimal.Round(_tempFaturaDetay.Sum(x => x.İskontoTutarı), 2);
                TBKdvTutari.EditValue = decimal.Round(_tempFaturaDetay.Sum(x => x.KdvTutarı), 2);
                TBGenelToplam.EditValue = decimal.Round(_tempFaturaDetay.Sum(x => x.NetToplam + x.KdvTutarı), 2);
                TBAraToplam.EditValue = decimal.Round(_tempFaturaDetay.Sum(x => x.NetToplam), 2);
            }

        }

        void Hesapla(int rowindex)
        {
            if (sy == 0)
            {

                sy = 1;
                daralı = Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "Daralı"));
                dara = Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "Dara"));
                gridView1.SetRowCellValue(rowindex, "Safi", daralı - dara);
                if (CHBKdvDahil.Checked == false)
                {
                    birimfiyat = Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "BirimFiyat"));
                    brutfiyat = birimfiyat;
                    miktar = _tempFaturaDetay.Where(x => x.StokId.ToString() == gridView1.GetRowCellValue(rowindex, "StokId").ToString()).FirstOrDefault().Safi;
                    kdv = Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "Kdv"));
                    isktoplam = birimfiyat - (birimfiyat * Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "İskonto1"))) / 100;
                    isktoplam = isktoplam - (isktoplam * Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "İskonto2"))) / 100;
                    isktoplam = isktoplam - (isktoplam * Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "İskonto3"))) / 100;

                    netfiyat = isktoplam;
                    isktoplam = birimfiyat - isktoplam;
                    isktoplam = isktoplam * miktar;
                    nettoplam = netfiyat * miktar;
                    kdvtoplam = (((nettoplam * kdv) / 100));
                    brüttoplam = brutfiyat * miktar;
                    geneltoplam = nettoplam + kdvtoplam;


                }
                else
                {
                    kdv = Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "Kdv"));
                    birimfiyat = (Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "BirimFiyat"))); //10
                    brutfiyat = birimfiyat / (1 + (kdv / 100)); //10/1,01
                    miktar = _tempFaturaDetay.Where(x => x.StokId.ToString() == gridView1.GetRowCellValue(rowindex, "StokId").ToString()).FirstOrDefault().Safi; //5
                    isktoplam = brutfiyat - (brutfiyat * Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "İskonto1"))) / 100;  //9,90 0
                    isktoplam = isktoplam - (isktoplam * Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "İskonto2"))) / 100;  // 0
                    isktoplam = isktoplam - (isktoplam * Convert.ToDecimal(gridView1.GetRowCellValue(rowindex, "İskonto3"))) / 100;  // 0
                    isktoplam = brutfiyat - isktoplam;
                    netfiyat = brutfiyat - isktoplam;
                    nettoplam = netfiyat * miktar;
                    kdvtoplam = ((nettoplam * kdv) / 100);
                    brüttoplam = brutfiyat * miktar;
                    geneltoplam = nettoplam + kdvtoplam;
                    isktoplam = isktoplam * miktar;

                }
                kDVHesaps.kdv0 = 0;
                kDVHesaps.kdv1 = 0;
                kDVHesaps.kdv8 = 0;
                kDVHesaps.kdv18 = 0;

                foreach (var item in _tempFaturaDetay.Where(x => x.StokKodu != ""))
                {
                    if (item.Kdv == 0)
                    {
                        kDVHesaps.kdv0 += kdvtoplam;
                    }
                    else if (item.Kdv == 1)
                    {
                        kDVHesaps.kdv1 += kdvtoplam;
                    }
                    else if (item.Kdv == 8)
                    {
                        kDVHesaps.kdv8 += kdvtoplam;
                    }
                    else if (item.Kdv == 18)
                    {
                        kDVHesaps.kdv18 += kdvtoplam;
                    }
                }
                gridView1.SetRowCellValue(rowindex, "BrütFiyat", decimal.Round(brutfiyat, 2));
                gridView1.SetRowCellValue(rowindex, "NetToplam", decimal.Round(nettoplam, 2));
                gridView1.SetRowCellValue(rowindex, "BrütToplam", decimal.Round(brüttoplam, 2));
                gridView1.SetRowCellValue(rowindex, "İskontoTutarı", decimal.Round(isktoplam, 2));
                gridView1.SetRowCellValue(rowindex, "KdvTutarı", decimal.Round(kdvtoplam, 2));
                gridView1.SetRowCellValue(rowindex, "NetFiyat", decimal.Round(netfiyat, 2));

                sy = 0;

                ToplamHesapla();


            }



        }

        void KasaAltBilgiDoldur()
        {

            tempkasalist = new List<KasaList>();
            foreach (var item in _kasaaa)
            {
                foreach (var item2 in item.KasaList)
                {
                    if (tempkasalist.Where(x => x.KASAID == item2.KASAID).Count() > 0)
                    {
                        tempkasalist.Where(x => x.KASAID == item2.KASAID).FirstOrDefault().MIKTAR = tempkasalist.Where(x => x.KASAID == item2.KASAID).FirstOrDefault().MIKTAR + item2.MIKTAR;
                    }
                    else
                    {
                        string marka = item2.MARKA.ToString();
                        string kasaadi = item2.KASAADI.ToString();
                        int id = Convert.ToInt32(item2.KASAID);
                        decimal miktar = Convert.ToDecimal(item2.MIKTAR);
                        tempkasalist.Add(new KasaList()
                        {
                            MARKA = marka,
                            KASAADI = kasaadi,
                            KASAID = id,
                            MIKTAR = miktar,
                        });
                    }
                }
            }
            gridControl1.DataSource = tempkasalist.OrderByDescending(x => x.MIKTAR);
            gridView2.Columns["ID"].Visible = false;
            gridView2.Columns["KASAID"].Visible = false;

        }

        void Doldur()
        {
            if (_tempFatura != null)
            {
                _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
                _stokOlcuBrList.Clear();
                if (fattip == 0)
                    _tempFaturaDetay.Clear();
                TBFaturaNo.Text = _tempFatura.belgeno;
                CHBKdvDahil.Checked = _tempFatura.kdvdahil ? true : false;
                //todo : TBCariKodu.Text = 
                CBDepo.EditValue = _depoServis.obje.Where(x => x.id == _tempFatura.depoid).FirstOrDefault().depoadi;
                TBKur.Text = _tempFatura.kur.ToString();


                //TODO TBKasa.Text = 
                DTSiparisTarih.EditValue = _tempFatura.faturatarihi;
                TBAciklama.Text = _tempFatura.aciklama;
                DTPVadeTarihi.EditValue = _tempFatura.vadetarihi;
                _faturadetayServis.Data(ServisList.MustahsilDetayListeServis);
                _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
                // TBGun.Text = _tempFatura.vadegunu.ToString();

                _kasaServis.Data(ServisList.StokKasaListeServis);
                List<KasaList> KasaList = new List<KasaList>();
                KasaList kslt;

                sy = -1;




                List<OlcuBrlist> olcuBrlist1;
                if (_faturadetayServis.obje.Where(x => x.mustahsilid == _tempFatura.id).Count() > 0 || _kasaaa != null)
                {

                    foreach (var item2 in _faturadetayServis.obje.Where(x => x.mustahsilid == _tempFatura.id))
                    {

                        KasaList = new List<KasaList>();
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Birim", item2.birimid);
                        foreach (var item in _stokKasaHarServis.obje.Where(z => z.mustahsildetayid == item2.id && z.mustahsilid == item2.mustahsilid))
                        {

                            kslt = new KasaList()
                            {
                                ID = item.id,
                                KASAADI = _kasaServis.obje.Where(z => z.id == item.kasaid).FirstOrDefault().kasaadi,
                                KASAID = item.kasaid,
                                MARKA = _stokKasaMarkaServis.obje.Where(c => c.id == _kasaServis.obje.Where(z => z.id == item.kasaid).FirstOrDefault().markaid).FirstOrDefault().adi,
                                MIKTAR = item.miktar
                            };


                            KasaList.Add(kslt);
                        }
                        _kasaaa.Add(new ListKasaList() { num = item2.num, KasaList = KasaList });

                    }



                    KasaAltBilgiDoldur();

                }
                else
                {
                    gridControl1.DataSource = "";
                    _tempFaturaDetay.Add(new PocoMustahsilKalem() { Tipi = "STOK" });
                }
                riLookup3.DataSource = "";
                riLookup3.DataSource = _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Count() > 0 ? _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).FirstOrDefault().KasaList.Select(x => new { Marka = x.MARKA, Adı = x.KASAADI, Miktar = x.MIKTAR }) : "";
                if (fattip == 0)
                    _faturadetayServis.Data(ServisList.MustahsilDetayListeServis + 2, null, "query=MUSTAHSILID=" + _tempFatura.id.ToString() + " AND KAYITTIPI=0");
                _olcuBr.Data(ServisList.OlcuBrListeServis);

                if (fattip == 0)
                    _tempFaturaDetay.AddRange(_faturadetayServis.obje.Select(x => new PocoMustahsilKalem()
                    {

                        id = x.id,
                        Tipi = x.tip == 0 ? "STOK" : x.tip == 1 ? "HIZMET" : x.tip == 2 ? "KASA" : x.tip == 3 ? "DEMIRBAS" : "MUHASEBE",
                        StokId = x.stokid,
                        StokKodu = x.tip == 0 ? _stokServis.obje.Where(z => z.id == x.stokid).Count() > 0 ? _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod : "" : x.tip == 1 ? _hizmetServis.obje.Where(y => y.id == x.stokid).Count() > 0 ? _hizmetServis.obje.Where(y => y.id == x.stokid).FirstOrDefault().kod : "" : "",//,  TODOO:BAKILACAAAK
                        StokAdı = x.tip == 0 ? _stokServis.obje.Where(z => z.id == x.stokid).Count() > 0 ? _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().adi : "" : x.tip == 1 ? _hizmetServis.obje.Where(y => y.id == x.stokid).Count() > 0 ? _hizmetServis.obje.Where(y => y.id == x.stokid).FirstOrDefault().kod : "" : "",
                        Birim = _olcuBr.obje.Where(y => y.id == x.birimid).Count() > 0 ? _olcuBr.obje.Where(y => y.id == x.birimid).FirstOrDefault().adi : "",
                        Kunye = x.kunye,
                        NetFiyat = x.netfiyat,
                        İskonto1 = x.iskontO1,
                        İskonto2 = x.iskontO2,
                        İskonto3 = x.iskontO3,
                        Kdv = x.kdv,
                        BrütFiyat = x.brutfiyat,
                        İskontoTutarı = x.isktoplam,
                        Acıklama = x.aciklama,
                        BirimFiyat = x.birimfiyat,
                        BrütToplam = x.bruttoplam,
                        Dara = x.dara,
                        Daralı = x.darali,
                        KasaMiktar = _kasaaa.Where(y => y.num == x.num).Select(t => t.KasaList.Sum(z => z.MIKTAR)).FirstOrDefault(),
                        NetToplam = x.nettoplam,
                        KdvTutarı = x.kdvtutari,
                        sıra = x.num,
                        Safi = x.safi,
                        Doviz = x.dovizid, //_tempStok.SDOVIZID 
                    }));

                GCIrsaliye.DataSource = _tempFaturaDetay;
                GCIrsaliye.RefreshDataSource();


                TBAIskonto1.EditValue = _tempFatura.altiskonto1;
                TBAIskonto2.EditValue = _tempFatura.altiskonto2;
                TBAIskonto3.EditValue = _tempFatura.altiskonto3;
                sy = 0;
                ToplamHesapla();
                fattip = 0;
            }

        }

        void faturaNoGuncelle()
        {
            _seriHarServis.Data(ServisList.SeriHarListeServis);
            _seriServis.Data(ServisList.SeriListeServis);
            var serino = _seriHarServis.obje.Where(x => x.seriid == _seriServis.obje.Where(z => z.SERINO == comboBoxEdit1.Text).FirstOrDefault().id).FirstOrDefault().serino;
            TBFaturaNo.Text = serino.ToString();
        }

        #endregion

        #region EVENTS
        private void RepositoryItemButtonEdit5_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId")) > 0)
            {
                FStokOlcuBrList aa = new FStokOlcuBrList(this.Tag.ToString(), "FMustahsil", Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId")));
                aa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Stok Seçiniz!");
            }
        }

        private void RepositoryItemButtonEdit4_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fGetKunye = new FGetKunye(this.Tag.ToString(), "FMustahsil");
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

                    fKasaList = new FStokKasaList(this.Tag.ToString(), "FMustahsil", gridView1.FocusedRowHandle.ToString(), _kasaaa);
                }
                else
                {
                    fKasaList = new FStokKasaList(this.Tag.ToString(), "FMustahsil", gridView1.FocusedRowHandle.ToString());
                }
                fKasaList.ShowDialog();
                if (_kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Count() > 0)
                {
                    riLookup3.DataSource = _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).FirstOrDefault().KasaList.Select(x => new { Marka = x.MARKA, Adı = x.KASAADI, Miktar = x.MIKTAR });

                    gridView1.SetFocusedRowCellValue("KasaMiktar", _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Select(x => x.KasaList.Sum(z => z.MIKTAR)).FirstOrDefault().ToString());
                    //   _tempFaturaDetay.Where(x => x.sıra == gridView1.FocusedRowHandle).FirstOrDefault().KasaMiktar = Convert.ToDecimal(_kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Select(x => x.KasaList.Sum(z => z.MIKTAR)));
                }
                KasaAltBilgiDoldur();
                GCIrsaliye.RefreshDataSource();
            }
        }

        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if (gridView1.GetFocusedRowCellValue("Tipi") == "STOK")
            {


                OlcuBrlist temppp = new OlcuBrlist();


                _fStokList = new FStokList(this.Tag.ToString(), "FMustahsil");
                _fStokList.ShowDialog();
                if (_tempStok.id != 0)
                {
                    //if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")) == 0) { 
                    //_tempPocokalem = new PocoMustahsilKalem()
                    //{
                    //    Tipi = "STOK",
                    //    StokId = _tempStok.id,
                    //    StokKodu = _tempStok.kod,
                    //    StokAdı = _tempStok.adi,
                    //    sıra = gridView1.FocusedRowHandle,
                    //    Birim = _stokOlcuBr.obje.Where(x => x.stokid == _tempStok.id).Select(x => _olcuBr.obje.Where(z => z.id == x.olcubrid).FirstOrDefault().adi).FirstOrDefault().ToString(),//_olcuBr.obje.Where(x => x.adi == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().adi,
                    //    BirimFiyat = _tempCariKart != null && _tempCariKart.id > 0 && _stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id).Count() > 0 && _stokFiyatHarServis.obje.Where(z => z.stokfiyatid == _stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id).LastOrDefault().id && z.stokid == _tempStok.id).Count() > 0 ? _stokFiyatHarServis.obje.Where(z => z.stokfiyatid == _stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id).LastOrDefault().id && z.stokid == _tempStok.id).LastOrDefault().fiyat : 0,
                    //    Kdv = _tempStok.satiskdv,


                    //};
                    //_tempFaturaDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
                    //}
                    //else
                    //{
                    gridView1.SetFocusedRowCellValue("Tipi", "STOK");
                    gridView1.SetFocusedRowCellValue("StokId", _tempStok.id);
                    gridView1.SetFocusedRowCellValue("StokKodu", _tempStok.kod);
                    gridView1.SetFocusedRowCellValue("StokAdı", _tempStok.adi);
                    gridView1.SetFocusedRowCellValue("Kdv", _tempStok.satiskdv);
                    gridView1.SetFocusedRowCellValue("BirimFiyat", _tempStok.sfiyaT1);
                    gridView1.SetFocusedRowCellValue("Birim", _stokOlcuBr.obje.Where(x => x.stokid == _tempStok.id).Select(x => _olcuBr.obje.Where(z => z.id == x.olcubrid).FirstOrDefault().adi).FirstOrDefault().ToString());
                    //}

                    gridView1.SetFocusedRowCellValue("Doviz", _paraBirimServis.obje.Where(x => x.adi == "TÜRK LİRASI").FirstOrDefault().id);
                    //gridView1.SetFocusedRowCellValue("Birim", _olcuBr.obje.Where(y=>y.id == _stokOlcuBr.obje.Where(x => x.stokid == _tempStok.id).FirstOrDefault().olcubrid).FirstOrDefault().adi.ToString());


                    //GCIrsaliye.DataSource = _tempFaturaDetay;
                    GCIrsaliye.RefreshDataSource();

                }

            }
            else if (gridView1.GetFocusedRowCellValue("Tipi") == "KASA")
            {

                FStokKasaList2 _fStokKasaList2 = new FStokKasaList2(this.Tag.ToString(), "FMustahsil");
                _fStokKasaList2.ShowDialog();
                if (_tempKasa != null)
                {
                    _tempPocokalem = new PocoMustahsilKalem()
                    {
                        Tipi = "KASA",
                        StokId = _tempKasa.id,
                        StokKodu = _tempKasa.kasakodu,
                        StokAdı = _tempKasa.kasaadi,
                        sıra = gridView1.GetFocusedDataSourceRowIndex(),
                        Birim = "",//_olcuBr.obje.Where(x => x.adi == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().adi,
                                   //KasaAdı = "",
                        Kdv = 0  //_tempKasa.satiskdv,
                    };
                    _tempFaturaDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
                    GCIrsaliye.DataSource = _tempFaturaDetay;
                }

            }
            else if (gridView1.GetFocusedRowCellValue("Tipi") == "HIZMET")
            {
                _fHizmetList = new FHizmetList(this.Tag.ToString(), "FMustahsil");
                _fHizmetList.ShowDialog();
                if (_tempHizmet != null)
                {
                    _tempPocokalem = new PocoMustahsilKalem()
                    {
                        Tipi = "HIZMET",
                        StokId = _tempHizmet.id,
                        StokKodu = _tempHizmet.kod,
                        StokAdı = _tempHizmet.adi,
                        sıra = gridView1.GetFocusedDataSourceRowIndex(),
                        Birim = "",//_olcuBr.obje.Where(x => x.adi == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().adi,
                                   //KasaAdı = "",
                        Kdv = 0  //_tempKasa.satiskdv,
                    };
                    _tempFaturaDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
                    GCIrsaliye.DataSource = _tempFaturaDetay;
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

        private void TBAIskonto1_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TBAIskonto1.Text) > 100)
            {
                MessageBox.Show("Iskonto oranı 100 den büyük olamaz");
                TBAIskonto1.Text = "0";
            }
            else if (sy == 0)
                ToplamHesapla();
        }

        private void TBAIskonto2_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TBAIskonto2.Text) > 100)
            {
                MessageBox.Show("Iskonto oranı 100 den büyük olamaz");
                TBAIskonto2.Text = "0";
            }
            else if (sy == 0)
                ToplamHesapla();
        }

        private void TBAIskonto3_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TBAIskonto3.Text) > 100)
            {
                MessageBox.Show("Iskonto oranı 100 den büyük olamaz");
                TBAIskonto3.Text = "0";
            }
            else if (sy == 0)
                ToplamHesapla();
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
        private void button1_Click(object sender, EventArgs e)
        {
            string html = "";
            if (_tempFatura != null)
                faturaBasim.TemelFaturaBasim(_tempFatura.id);






            //RichEditDocumentServer richServer = new RichEditDocumentServer(); 

            //// Specify default formatting 
            //richServer.LoadDocument(Application.StartupPath + "output.pdf");
            //// Add document content  

            //richServer.Document.Sections[0].Margins.Left = 100f;
            //richServer.Document.Sections[0].Margins.Right = 0f;
            //richServer.Document.Sections[0].Margins.Top = 100f;
            //richServer.Document.Sections[0].Margins.Bottom = 0f;
            //richServer.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            //richServer.Document.Sections[0].Page.Width = 3850;
            //richServer.Document.Sections[0].Page.Height = 2920;
            //richServer.Document.Sections[0].Page.Landscape = true;

            //// Invoke the Print Preview dialog
            //using (PrintingSystem printingSystem = new PrintingSystem())
            //{
            //    using (PrintableComponentLink link = new PrintableComponentLink(printingSystem))
            //    {

            //        link.Component = richServer;
            //        link.CreateDocument();

            //        link.ShowPreviewDialog();
            //    }
            //}


        }

        private void BTMustahsilCariEkle_Click(object sender, EventArgs e)
        {
            FMustahsilKart fmustahsilkart = new FMustahsilKart();
            fmustahsilkart.ShowDialog();
            MustahsilCariDoldur();
        }

        private void Prndc_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

            faturaNoGuncelle();
        }

        private void TBGun_EditValueChanged(object sender, EventArgs e)
        {
            if (DTPVadeTarihi.Text != DateTime.Now.AddDays((Convert.ToInt32(TBGun.Text))).ToString("dd.MM.yyyy"))
                DTPVadeTarihi.EditValue = DateTime.Now.AddDays((Convert.ToInt32(TBGun.Text)));
        }

        private void DTPVadeTarihi_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan a = Convert.ToDateTime(((DateTime)DTPVadeTarihi.EditValue).ToString("dd.MM.yyyy")) - Convert.ToDateTime(DateTime.Now.ToString("dd.MM.yyyy"));

            if (a.Days < 0)
                TBGun.Text = "0";
            else if (TBGun.Text != a.Days.ToString())
                TBGun.Text = a.Days.ToString();
        }

        private void gridView1_ColumnChanged(object sender, EventArgs e)
        {
            if (gridView1.FocusedColumn != null)
                if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns.View.VisibleColumns.Count)
                    MessageBox.Show("testt");
        }

        private void BTKaydet_Click_1(object sender, EventArgs e)
        {
            if (_tempFatura != null && TBFaturaNo.Text != _tempFatura.belgeno)
                _tempFatura = null;

            //if (_mustahsilCariServis.obje.Where(x=> x.ADISOYADI==CBMustahsilCari.Text).Count()==0)
            //{
            //    _mustahsilCariServis.Data(ServisList.MustahsilCariEkleServis, new PocoMUSTAHSILCARI()
            //    {
            //        ADI = CBMustahsilCari.Text
            //    });
            //    MustahsilCariDoldur();
            //    CBMustahsilCari.EditValue = _mustahsilCariServis.obje2.id;
            //}
            
            if (CBMustahsilCari.EditValue!=null&& _mustahsilCariServis.obje.Where(x=> x.id==Convert.ToInt32(CBMustahsilCari.EditValue)).Count()>0)
            {
                if (_tempFatura == null)
                    faturaNoGuncelle();
     

                _faturaServis.Data(ServisList.MustahsilEkleServis, new PocoMUSTAHSIL()
                {
                    id = _tempFatura != null ? _tempFatura.id : 0,
                    aciklama = TBAciklama.Text,
                    kur = Convert.ToDecimal(TBKur.Text),
                    belgeno = TBFaturaNo.Text,
                    vadetarihi = (DateTime)DTPVadeTarihi.EditValue,
                    guncellemetarihi = DateTime.Now,
                    vadegunu = Convert.ToInt32(TBGun.Text),
                    cariadi = CBMustahsilCari.Text,
                    faturatarihi = (DateTime)DTSiparisTarih.EditValue,
                    mustahsilcariid = Convert.ToInt32(CBMustahsilCari.EditValue),
                    depoid = _depoServis.obje.Where(x => x.depoadi == CBDepo.EditValue).FirstOrDefault().id,
                    dovizid = _paraBirimServis.obje.Where(x => x.adi == CBParaBirimi.Text).FirstOrDefault().id,
                    altiskonto1 = Convert.ToDecimal(TBAIskonto1.Text),
                    altiskonto2 = Convert.ToDecimal(TBAIskonto2.Text),
                    altiskonto3 = Convert.ToDecimal(TBAIskonto3.Text),
                    iskontotoplam = Convert.ToDecimal(TBIskontoToplam.EditValue), //_tempFaturaDetay.Sum(x => x.İskontoTutarı),
                    kdvtoplam = _tempFaturaDetay.Sum(x => x.KdvTutarı),
                    bruttoplam = _tempFaturaDetay.Sum(x => x.BrütToplam),
                    nettoplam = _tempFaturaDetay.Sum(x => x.NetToplam),
                    geneltoplam = _tempFaturaDetay.Sum(x => x.KdvTutarı) + _tempFaturaDetay.Sum(x => x.NetToplam),
                    kdvdahil = CHBKdvDahil.Checked,
                    tip = 1,
                    serino = comboBoxEdit1.SelectedItem.ToString(),
                    userid = MPKullanici.ID
                });


                _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
                _olcuBr.Data(ServisList.OlcuBrListeServis);
                int i = 0;
                _stokHarServis.Data(ServisList.StokHarListeServis);
                _hizmetHarServis.Data(ServisList.HizmetHarListeServis);


                foreach (var item in _tempFaturaDetay.Where(x => x.StokKodu != "" && x.StokKodu != null).ToList())
                {
                    var stokolcubr = _stokOlcuBr.obje.Where(x => x.stokid == item.StokId).FirstOrDefault();
                    _faturadetayServis.Data(ServisList.MustahsilDetayEkleServis, new PocoMUSTAHSILDETAY()
                    {
                        id = item.id,
                        stokid = item.StokId,
                        stokadi = item.StokAdı,
                        aciklama = item.Acıklama,
                        kdv = item.Kdv,
                        //kasaid = item.KasaId,
                        birimfiyat = item.BirimFiyat,
                        nettoplam = item.NetToplam,
                        netfiyat = item.NetFiyat,
                        birimid = item.Tipi == "STOK" ? _olcuBr.obje.Where(y => y.adi == item.Birim).FirstOrDefault().id : 0,
                        dovizid = item.Doviz,
                        kasamiktar = item.KasaMiktar,
                        dara = item.Dara,
                        darali = item.Daralı,
                        safi = item.Safi,
                        iskontO1 = item.İskonto1,
                        iskontO2 = item.İskonto2,
                        iskontO3 = item.İskonto3,
                        isktoplam = item.İskontoTutarı,
                        mustahsilid = _faturaServis.obje2.id, ///ID gelecek
                        kunye = item.Kunye != null ? item.Kunye : "",
                        brutfiyat = item.BrütFiyat,
                        bruttoplam = item.BrütFiyat * item.Safi,
                        bekleyenmiktar = 0,
                        num = item.sıra,
                        hareketdurumu = 0,
                        listefiyatid = 0,
                        tip = item.Tipi == "STOK" ? Convert.ToByte(0) : item.Tipi == "HIZMET" ? Convert.ToByte(1) : item.Tipi == "KASA" ? Convert.ToByte(2) : item.Tipi == "DEMIRBAS" ? Convert.ToByte(3) : Convert.ToByte(4),
                        kdvtutari = item.KdvTutarı,
                        userid = MPKullanici.ID
                    });


                    if (_tempFatura == null)
                    {
                        _seriHarServis.Data(ServisList.SeriHarListeServis);
                        var tempserihar = _seriHarServis.obje.Where(x => x.seriid == _seriServis.obje.Where(z => z.SERINO.ToString() == comboBoxEdit1.Text).FirstOrDefault().id).LastOrDefault();
                        tempserihar.serino = tempserihar.serino + 1;
                        tempserihar.userid = MPKullanici.ID;
                        _seriHarServis.Data(ServisList.SeriHarEkleServis, tempserihar);
                    }
                    if (item.Tipi == "STOK")
                    {

                        _stokHarServis.Data(ServisList.StokHarEkleServis, new Entity.PocoModels.STOK.PocoSTOKHAR()
                        {
                            id = _stokHarServis.obje.Where(x => x.mustahsildetayid == _faturadetayServis.obje2.id).Count() > 0 ? _stokHarServis.obje.Where(x => x.mustahsildetayid == _faturadetayServis.obje2.id).FirstOrDefault().id : 0,
                            mustahsildetayid = _faturadetayServis.obje2.id,
                            mustahsilid = _faturaServis.obje2.id,
                            aciklama = item.Acıklama,
                            belgE_NO = _faturaServis.obje2.belgeno,
                            hareketturu = 1,
                            birim = _olcuBr.obje.Where(x => x.adi.ToString() == item.Birim).FirstOrDefault().id,
                            bruttoplam = item.BrütToplam,
                            depoid = _faturaServis.obje2.depoid,
                            io = 1,
                            kdv = item.Kdv,
                            miktar = item.Safi,
                            netfiyat = item.NetFiyat,
                            nettoplam = item.NetToplam,
                            stokid = item.StokId,
                            sayimid = 0,
                            kunye = item.Kunye==null?"":item.Kunye,
                            userid = MPKullanici.ID
                        });
                    }
                    else if (item.Tipi == "HIZMET")
                    {

                        _hizmetHarServis.Data(ServisList.HizmetHarEkleServis, new Entity.PocoModels.STOK.PocoHIZMETHAR()
                        {
                            id = _hizmetHarServis.obje.Where(x => x.mustahsildetayid == _faturadetayServis.obje2.id).Count() > 0 ? _hizmetHarServis.obje.Where(x => x.mustahsildetayid == _faturadetayServis.obje2.id).FirstOrDefault().id : 0,
                            mustahsildetayid = _faturadetayServis.obje2.id,
                            mustahsilid = _faturaServis.obje2.id,
                            aciklama = item.Acıklama,
                            belgE_NO = _faturaServis.obje2.belgeno,
                            hareketturu = 1,
                            io = 0,
                            birim = 0,
                            bruttoplam = item.BrütToplam,
                            depoid = _faturaServis.obje2.depoid,
                            kdv = item.Kdv,
                            miktar = item.Safi,
                            netfiyat = item.NetFiyat,
                            nettoplam = item.NetToplam,
                            hizmetid = item.StokId,
                            userid = MPKullanici.ID
                        });
                    }
                    i++;


                    //_kasaServis.Data(ServisList.StokKasaListeServis);

                    foreach (var test in _kasaaa.Where(x => x.num == item.sıra))
                    {
                        List<PocoSTOKKASAHAR> except = new List<PocoSTOKKASAHAR>();


                        foreach (var item2 in test.KasaList)
                        {   //kasalist içinde olmayan stokkasaharların silinmesi
                            _stokKasaHarServis.Data(ServisList.StokKasaHarEkleServis, new PocoSTOKKASAHAR()
                            {
                                id = _stokKasaHarServis.obje.Where(x => x.id == item2.ID).Count() > 0 ? item.id : 0,
                                belge_no = TBFaturaNo.Text,
                                mustahsilid = _faturaServis.obje2.id,
                                io =  1,
                                mustahsilcariid = Convert.ToInt32( CBMustahsilCari.EditValue),
                                kayittipi = 0,
                                kasaid = item2.KASAID,
                                miktar = item2.MIKTAR, // _kasaaa.Where(x => x.num == test.num).Select(x => x.KasaList.Sum(t => t.MIKTAR)).FirstOrDefault()
                                irsaliyedetayid = 0,
                                faturadetayid=0,
                                faturaid=0,
                                mustahsildetayid = _faturadetayServis.obje2.id,
                                depoid = _depoServis.obje.Where(x => x.depoadi == CBDepo.Text).FirstOrDefault().id,
                                userid = MPKullanici.ID,
                            });
                            if (item2.ID > 0)
                                except.AddRange(_stokKasaHarServis.obje.Where(x => x.id == item2.ID));

                        }
                        if (_stokKasaHarServis.obje.Where(x => x.mustahsildetayid == _faturadetayServis.obje2.id).Except(except).Count() > 0)
                            foreach (var sss in _stokKasaHarServis.obje.Where(x => x.mustahsildetayid == _faturadetayServis.obje2.id).Except(except))
                            {
                                _stokKasaHarServis.Data(ServisList.StokKasaHarDeleteByIdServis, id: sss.id.ToString(), method: System.Net.Http.HttpMethod.Post);
                            }
                    }


                }
                _cariHarServsi.Data(ServisList.MustahsilCariHarEkleServis, new PocoMUSTAHSILCARIHAR()
                {
                    aciklama = "Müstahsil Makbuzu",
                    belgE_NO = _faturaServis.obje2.belgeno,
                    alacak =  0,
                    borc =  _faturaServis.obje2.geneltoplam,
                    MUSTAHSILID = _faturaServis.obje2.mustahsilcariid,
                    harekettarihi = _faturaServis.obje2.faturatarihi,
                    harekettipi = 1,
                    kur = 1,
                    parabirimid = 11638,
                    tutar = 0 - _faturaServis.obje2.geneltoplam,
                    userid = MPKullanici.ID

                });
                if (_tempSilinenFaturaDetay.Count() > 0)
                {
                    foreach (var item in _tempSilinenFaturaDetay)
                    {
                        _faturadetayServis.Data(ServisList.MustahsilDetayDeleteByIdServis, id: item.id.ToString(), method: System.Net.Http.HttpMethod.Post);
                        _stokHarServis.Data(ServisList.StokHarSilServis, modellist: _stokHarServis.obje.Where(x => x.mustahsildetayid == item.id).ToList());
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
            else
                MessageBox.Show("Lütfen Cariyi Seçtiğinizden emin olunuz!");

        }

        private void CHBKdvDahil_CheckedChanged(object sender, EventArgs e)
        {
            if (_tempFatura != null && _tempFatura.kdvdahil == CHBKdvDahil.Checked)
            {
            }
            else
            {
                sx = 1;
                foreach (var item in _tempFaturaDetay)
                {
                    Hesapla(item.sıra);
                }
                sx = 0;
                if (_tempFatura != null)
                    _tempFatura.kdvdahil = CHBKdvDahil.Checked;
            }

        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                num++;
                _tempFaturaDetay.Add(new PocoMustahsilKalem() { sıra = num });
                GCIrsaliye.DataSource = _tempFaturaDetay;

                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                gridView1.FocusedColumn = gridView1.Columns["StokKodu"];
                gridView1.Columns["Birim"].VisibleIndex = 8;
                gridView1.Columns["StokId"].Visible = false;
                GCIrsaliye.RefreshDataSource();
            }

        }

        private void FFatura_Load(object sender, EventArgs e)
        {

            _seriServis.Data(ServisList.SeriListeServis);
            _seriHarServis.Data(ServisList.SeriHarListeServis);
            foreach (var item in _seriServis.obje.Where(x => x.TIP == 0).Select(x => x.SERINO))
            {
                comboBoxEdit1.Properties.Items.Add(item);
            }
            comboBoxEdit1.SelectedIndex = 0;
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _hizmetServis.Data(ServisList.HizmetListeServis);
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            DataGridYapilandir();
            TBGun.Properties.MaxLength = 4;
            DTPVadeTarihi.EditValue = DateTime.Now;
            DTSiparisTarih.EditValue = DateTime.Now;
            Doldur();
            MustahsilCariDoldur();
        }

        private void BTNSatirSil_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle > -1)
            {
                _tempSilinenFaturaDetay.Add(new PocoMustahsilKalem()
                {
                    id = _tempFaturaDetay[gridView1.FocusedRowHandle].id
                }
               );
                _tempFaturaDetay.Remove(_tempFaturaDetay[gridView1.FocusedRowHandle]);
                if (_kasaaa.Count() > gridView1.FocusedRowHandle)
                {
                    _silinenkasaaa.Add(_kasaaa[gridView1.FocusedRowHandle]);
                    _kasaaa.Remove(_kasaaa[gridView1.FocusedRowHandle]);
                }
            }
            KasaAltBilgiDoldur();
            GCIrsaliye.RefreshDataSource();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (e.Column.ToString() == "İskonto1" && Convert.ToInt32(e.Value) > 100)
            {
                gridView1.SetRowCellValue(e.RowHandle, e.Column, 0);
                MessageBox.Show("İskonto1 100'den büyük olamaz!");
            }
            else if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("İskonto2")) > 100)
            {
                gridView1.SetRowCellValue(e.RowHandle, e.Column, 0);
                MessageBox.Show("İskonto2 100'den büyük olamaz!");
            }
            else if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("İskonto3")) > 100)
            {
                gridView1.SetRowCellValue(e.RowHandle, e.Column, 0);
                MessageBox.Show("İskonto3 100'den büyük olamaz!");
            }
            else if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("Kdv")) > 100)
            {
                gridView1.SetFocusedRowCellValue("Kdv", Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId")) > 0 ? _stokServis.obje.Where(x => x.id == Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId"))).FirstOrDefault().satiskdv : 0);
                MessageBox.Show("Kdv 100'den büyük olamaz!");
            }
            else if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("Daralı")) != 0 && Convert.ToInt32(gridView1.GetFocusedRowCellValue("Dara")) != 0 && Convert.ToInt32(gridView1.GetFocusedRowCellValue("Daralı")) <= Convert.ToInt32(gridView1.GetFocusedRowCellValue("Dara")))
            {
                gridView1.SetRowCellValue(e.RowHandle, "Daralı", 0);
                gridView1.SetRowCellValue(e.RowHandle, "Dara", 0);

                MessageBox.Show("Safi 0'dan küçük olamaz!");
            }
            else if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("Daralı")) < 0)
            {
                gridView1.SetRowCellValue(e.RowHandle, e.Column, 0);
                MessageBox.Show("Daralı 0'dan küçük olamaz!");
            }
            else if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("Dara")) < 0)
            {
                gridView1.SetRowCellValue(e.RowHandle, e.Column, 0);
                MessageBox.Show("Dara 0'dan küçük olamaz!");
            }

            if (sx == 0)
                Hesapla(gridView1.FocusedRowHandle);
        }

        private void TBSiparisNo_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FMustahsilList ffaturalist = new FMustahsilList(this.Tag.ToString(), "FMustahsil");
            ffaturalist.ShowDialog();
            Doldur();

        }

     
        #endregion
    }
}
