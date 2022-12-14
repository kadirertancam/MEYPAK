using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.STOK;
using System.Data;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FMusteriSiparis : Form
    {
     


        public FMusteriSiparis()
        {
            InitializeComponent();
            
            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList = new DataGridViewComboBoxColumn();
            DGVKasaSec = new DataGridViewButtonColumn();
            DGVKasaList = new DataGridViewComboBoxColumn();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoServis.Data(ServisList.DepoListeServis);
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();
            _stokFiyatHarServis = new GenericWebServis<PocoSTOKFIYATHAR>();
            _stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            CBParaBirimi.Properties.DataSource = _paraBirimServis.obje.Where(x => x.kayittipi == 0).Select(x => x.adi).ToList();
            CBDepo.Properties.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).ToList();
            CBDepo.Text = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).FirstOrDefault();

            CBParaBirimi.Text = _paraBirimServis.obje.Where(x => x.kayittipi == 0 && x.adi == "TÜRK LİRASI").Select(x => x.adi).FirstOrDefault();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _cariKart = new GenericWebServis<PocoCARIKART>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            _siparisKasaHarServis = new GenericWebServis<PocoSIPARISKASAHAR>();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
            _tempKasaList = new List<KasaList>();
            _carialthescaricari = new GenericWebServis<PocoCARIALTHESCARI>();
            _kasaaa = new List<ListKasaList>();
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            _stokOlcuBrList = new List<StokOlcuBrTemp>();
            kDVHesaps = new KDVHesap();
  
        }

        #region TANIMLAR
        FStokKasaList fKasaList;
        List<PocoSiparisKalem> _tempSiparisDetay = new List<PocoSiparisKalem>();
        List<PocoSiparisKalem> _tempSilinenFaturaDetay = new List<PocoSiparisKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        GenericWebServis<PocoCARIALTHESCARI> _carialthescaricari;
        PocoSiparisKalem _tempPocokalem;
        FStokList _fStokList;
        FCariList _fCariList;
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoSIPARIS _tempSIPARIS;
        public PocoCARIKART _tempCariKart;
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoCARIKART> _cariKart;
        GenericWebServis<PocoSTOK> _stokServis;
        FStokKasaList _fStokKasaList;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        GenericWebServis<PocoSIPARISKASAHAR> _siparisKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        GenericWebServis<PocoSTOKFIYAT> _stokFiyatServis;
        GenericWebServis<PocoSTOKFIYATHAR> _stokFiyatHarServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        List<KasaList> tempkasalist;

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
        void temizle()
        {
            num = 0;
            GCIrsaliye.DataSource = "";
            _tempSiparisDetay.Clear();
            _kasaaa.Clear();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            GCIrsaliye.DataSource = _tempSiparisDetay;
            //DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["KasaId"].Visible = false;

            TBAciklama.Text = "";
            TBAIskonto1.Text = "0";
            TBAIskonto2.Text = "0";
            TBAIskonto3.Text = "0";
            TBAraToplam.Text = "0";
            TBBrutToplam.Text = "0";
            TBCariAdi.Text = "";
            TBCariKodu.Text = "";
            TBGenelToplam.Text = "0";
            TBGun.Text = "0";
            TBFaturaNo.Text = "";
            TBIskontoToplam.Text = "0";
            TBIskontoToplam.Text = "0";
            TBKdvTutari.Text = "0";
            TBKur.Text = "0";
            DTPVadeTarihi.EditValue = DateTime.Now;
            DTSiparisTarih.EditValue = DateTime.Now;
            CBAltHesap.Properties.DataSource = "";
            CBDepo.EditValue = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).FirstOrDefault();
            CBParaBirimi.EditValue = _paraBirimServis.obje.Where(x => x.kayittipi == 0 && x.adi == "TÜRK LİRASI").Select(x => x.adi).FirstOrDefault();
            _tempCariKart = null;
            CHBKdvDahil.Checked = false;
            gridControl1.DataSource = "";
       

        }

        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempSiparisDetay.Add(new PocoSiparisKalem() { Tipi = "STOK" });
            GCIrsaliye.DataSource = _tempSiparisDetay;

            gridView1.Columns["sıra"].Visible = false;

            repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repositoryItemButtonEdit.NullText = "";
            repositoryItemButtonEdit.NullValuePrompt = "";
            repositoryItemButtonEdit.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit.Buttons[0].Kind = ButtonPredefines.Glyph;
            gridView1.Columns["StokKodu"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["StokKodu"].ColumnEdit = repositoryItemButtonEdit;
            repositoryItemButtonEdit.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);



            RepositoryItemButtonEdit repositoryItemButtonEdit3 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repositoryItemButtonEdit3.NullText = "";
            repositoryItemButtonEdit3.NullValuePrompt = "";
            repositoryItemButtonEdit3.Buttons[0].Caption = "SEÇ";
            repositoryItemButtonEdit3.Buttons[0].Kind = ButtonPredefines.Glyph;
            gridView1.Columns["KasaMiktar"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["KasaMiktar"].ColumnEdit = repositoryItemButtonEdit3;
            repositoryItemButtonEdit3.Buttons[0].Shortcut = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Enter);

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
            gridView1.Columns["Birim"].OptionsColumn.AllowEdit = true;
            gridView1.Columns["Birim"].ColumnEdit = repositoryItemButtonEdit5;
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

            gridView1.Columns["Tipi"].OptionsColumn.AllowEdit = true;
            //repoGV.Columns.Add(colun2);
            gridView1.Columns["Tipi"].ColumnEdit = riLookup;
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

            gridView1.Columns["KasaAdı"].OptionsColumn.AllowEdit = true;
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




            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit3);




            gridView1.Columns["StokKodu"].VisibleIndex = 4;
            gridView1.Columns["KasaMiktar"].VisibleIndex = 7;
            gridView1.Columns["StokId"].Visible = false;

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
                foreach (var item in _tempSiparisDetay)
                {
                    nettop = item.NetToplam;
                    nettop = nettop - ((nettop * Convert.ToDecimal(TBAIskonto1.Text)) / 100);
                    nettop = nettop - ((nettop * Convert.ToDecimal(TBAIskonto2.Text)) / 100);
                    nettop = nettop - ((nettop * Convert.ToDecimal(TBAIskonto3.Text)) / 100);
                    isktoplam = ((nettop * Convert.ToDecimal(TBAIskonto1.Text)) / 100) + ((nettop * Convert.ToDecimal(TBAIskonto2.Text)) / 100) + ((nettop * Convert.ToDecimal(TBAIskonto3.Text)) / 100);
                    temppte += nettop;
                    kdvtoplamm += ((nettop * item.Kdv) / 100);
                    iskk = decimal.Round((_tempSiparisDetay.Sum(x => x.İskontoTutarı)), 2);
                    isktoplam = isktoplam + iskk;
                }



                TBBrutToplam.Text = decimal.Round((_tempSiparisDetay.Sum(x => x.BrütToplam)), 2).ToString();
                TBAraToplam.Text = temppte.ToString();
                TBIskontoToplam.Text = (decimal.Round((_tempSiparisDetay.Sum(x => x.BrütToplam)), 2) - temppte).ToString();
                TBKdvTutari.Text = kdvtoplamm.ToString();
                TBGenelToplam.Text = (temppte + kdvtoplamm).ToString();
            }
            else
            {

                TBBrutToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.BrütToplam), 2).ToString();
                TBIskontoToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.İskontoTutarı), 2).ToString();
                TBKdvTutari.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.KdvTutarı), 2).ToString();
                TBGenelToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam + x.KdvTutarı), 2).ToString();
                TBAraToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam), 2).ToString();
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
                    miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == gridView1.GetRowCellValue(rowindex, "StokId").ToString()).FirstOrDefault().Safi;
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
                    miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == gridView1.GetRowCellValue(rowindex, "StokId").ToString()).FirstOrDefault().Safi; //5
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

                foreach (var item in _tempSiparisDetay.Where(x => x.StokKodu != ""))
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
            if (_tempSIPARIS != null)
            {
                _siparisKasaHarServis.Data(ServisList.SiparisKasaHarListeServis);
                _kasaaa.Clear();
                _stokOlcuBrList.Clear();
                _tempSiparisDetay.Clear();
                _cariKart.Data(ServisList.CariListeServis);
                TBFaturaNo.Text = _tempSIPARIS.belgeno;
                CHBKdvDahil.Checked = _tempSIPARIS.kdvdahil ? true : false;
                //todo : TBCariKodu.Text = 
                CBDepo.EditValue = _depoServis.obje.Where(x => x.id == _tempSIPARIS.depoid).FirstOrDefault().depoadi;
                TBKur.Text = _tempSIPARIS.kur.ToString();
                TBCariKodu.Text = _cariKart.obje.Where(x => x.id == _tempSIPARIS.cariid).FirstOrDefault().kod;
                TBCariAdi.Text = _tempSIPARIS.cariadi;

                //TODO TBKasa.Text = 
                DTSiparisTarih.EditValue = _tempSIPARIS.siparistarihi;
                TBAciklama.Text = _tempSIPARIS.aciklama;
                DTPVadeTarihi.EditValue = _tempSIPARIS.vadetarihi;
                _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
                _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
                // TBGun.Text = _tempSIPARIS.vadegunu.ToString();

                _kasaServis.Data(ServisList.StokKasaListeServis);
                List<KasaList> KasaList = new List<KasaList>();
                KasaList kslt;

                sy = -1;

                List<PocoCARIALTHES> altcarilist = new List<PocoCARIALTHES>();
                _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
                // CBAltHesap.Properties.DataSource = _cariAltHesapServis.obje.Where(x=>x.cariid==_tempCariKart.id).Select(x => x.adi).ToList();
                _carialthescaricari.Data(ServisList.CariAltHesCariListeServis);
                foreach (var item in _carialthescaricari.obje.Where(x => x.cariid == _tempSIPARIS.cariid))
                {
                    altcarilist.Add(_cariAltHesapServis.obje.Where(x => x.kayittipi == 0 && x.id == item.carialthesid).FirstOrDefault());
                }
                CBAltHesap.Properties.ValueMember = "ID";
                CBAltHesap.Properties.DisplayMember = "ADI";
                CBAltHesap.Properties.DataSource = altcarilist.Select(x => new { ID = x.id, ADI = x.adi.ToString() });
                CBAltHesap.EditValue = _tempSIPARIS.althesapid;
                List<OlcuBrlist> olcuBrlist1;
                if (_siparisDetayServis.obje.Where(x => x.siparisid == _tempSIPARIS.id).Count() > 0)
                {

                    foreach (var item2 in _siparisDetayServis.obje.Where(x => x.siparisid == _tempSIPARIS.id))
                    {

                        KasaList = new List<KasaList>();
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Birim", item2.birimid);
                        foreach (var item in _siparisKasaHarServis.obje.Where(z => z.siparisdetayid == item2.id && z.siparisid == item2.siparisid))
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
                    _tempSiparisDetay.Add(new PocoSiparisKalem() { Tipi = "STOK" });
                }
                riLookup3.DataSource = "";
                riLookup3.DataSource = _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Count() > 0 ? _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).FirstOrDefault().KasaList.Select(x => new { Marka = x.MARKA, Adı = x.KASAADI, Miktar = x.MIKTAR }) : "";
                _siparisDetayServis.Data(ServisList.SiparisDetayListeServis + 2, null, "query=SIPARISID=" + _tempSIPARIS.id.ToString() + " AND KAYITTIPI=0");
                _olcuBr.Data(ServisList.OlcuBrListeServis);
                _tempSiparisDetay.AddRange(_siparisDetayServis.obje.Select(x => new PocoSiparisKalem()
                {
                    id = x.id,
                    Tipi = "STOK",
                    StokId = x.stokid,
                    StokKodu = _stokServis.obje.Where(z => z.id == x.stokid).Count() > 0 ? _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod : "",//,  TODOO:BAKILACAAAK
                    StokAdı = _stokServis.obje.Where(z => z.id == x.stokid).Count() > 0 ? _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().adi : "",
                    Birim = _olcuBr.obje.Where(y => y.id == x.birimid).Count() > 0 ? _olcuBr.obje.Where(y => y.id == x.birimid).FirstOrDefault().adi : "",
                    
                    NetFiyat = x.netfiyat,
                    İskonto1 = x.istkontO1,
                    İskonto2 = x.istkontO2,
                    İskonto3 = x.istkontO3,
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

                GCIrsaliye.DataSource = _tempSiparisDetay;
                GCIrsaliye.RefreshDataSource();


                TBAIskonto1.EditValue = _tempSIPARIS.altiskonto1;
                TBAIskonto2.EditValue = _tempSIPARIS.altiskonto2;
                TBAIskonto3.EditValue = _tempSIPARIS.altiskonto3;
                sy = 0;
                ToplamHesapla();
            }

        }

        #endregion

        #region EVENTS
        private void RepositoryItemButtonEdit5_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId")) > 0)
            {
                FStokOlcuBrList aa = new FStokOlcuBrList(this.Tag.ToString(), "FMusteriSiparis", Convert.ToInt32(gridView1.GetFocusedRowCellValue("StokId")));
                aa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Stok Seçiniz!");
            }
        }



        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            riLookup.GetDataSourceRowByDisplayValue(riLookup.Name);
        }

        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if (_kasaaa.Where(x => x.num.ToString() == gridView1.FocusedRowHandle.ToString()).Count() > 0)
            {

                fKasaList = new FStokKasaList(this.Tag.ToString(), "FMusteriSiparis", gridView1.FocusedRowHandle.ToString(), _kasaaa);
            }
            else
            {
                fKasaList = new FStokKasaList(this.Tag.ToString(), "FMusteriSiparis", gridView1.FocusedRowHandle.ToString());
            }
            fKasaList.ShowDialog();
            if (_kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Count() > 0)
            {
                riLookup3.DataSource = _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).FirstOrDefault().KasaList.Select(x => new { Marka = x.MARKA, Adı = x.KASAADI, Miktar = x.MIKTAR });

                gridView1.SetFocusedRowCellValue("KasaMiktar", _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Select(x => x.KasaList.Sum(z => z.MIKTAR)).FirstOrDefault().ToString());
                //   _tempSiparisDetay.Where(x => x.sıra == gridView1.FocusedRowHandle).FirstOrDefault().KasaMiktar = Convert.ToDecimal(_kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Select(x => x.KasaList.Sum(z => z.MIKTAR)));
            }
            KasaAltBilgiDoldur();
            GCIrsaliye.RefreshDataSource();
        }

        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if (gridView1.GetFocusedRowCellValue("Tipi") == "STOK")
            {


                OlcuBrlist temppp = new OlcuBrlist();
                _stokFiyatHarServis.Data(ServisList.StokFiyatHarListeServis);
                _stokFiyatServis.Data(ServisList.StokFiyatListeServis);

                _fStokList = new FStokList(this.Tag.ToString(), "FMusteriSiparis");
                _fStokList.ShowDialog();
                if (_tempStok.id != 0)
                {
                    //if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")) == 0) { 
                    //_tempPocokalem = new PocoSiparisKalem()
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
                    //_tempSiparisDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
                    //}
                    //else
                    //{
                    gridView1.SetFocusedRowCellValue("Tipi", "STOK");
                    gridView1.SetFocusedRowCellValue("StokId", _tempStok.id);
                    gridView1.SetFocusedRowCellValue("StokKodu", _tempStok.kod);
                    gridView1.SetFocusedRowCellValue("StokAdı", _tempStok.adi);
                    gridView1.SetFocusedRowCellValue("Kdv", _tempStok.satiskdv);
                    gridView1.SetFocusedRowCellValue("BirimFiyat", _tempCariKart != null && _tempCariKart.id > 0 && _stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id).Count() > 0 && _stokFiyatHarServis.obje.Where(z => z.stokfiyatid == _stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id).LastOrDefault().id && z.stokid == _tempStok.id).Count() > 0 ? _stokFiyatHarServis.obje.Where(z => z.stokfiyatid == _stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id).LastOrDefault().id && z.stokid == _tempStok.id).LastOrDefault().fiyat : 0);
                    gridView1.SetFocusedRowCellValue("Birim", _stokOlcuBr.obje.Where(x => x.stokid == _tempStok.id).Select(x => _olcuBr.obje.Where(z => z.id == x.olcubrid).FirstOrDefault().adi).FirstOrDefault().ToString());
                    //}

                    gridView1.SetFocusedRowCellValue("Doviz", _paraBirimServis.obje.Where(x => x.adi == "TÜRK LİRASI").FirstOrDefault().id);
                    //gridView1.SetFocusedRowCellValue("Birim", _olcuBr.obje.Where(y=>y.id == _stokOlcuBr.obje.Where(x => x.stokid == _tempStok.id).FirstOrDefault().olcubrid).FirstOrDefault().adi.ToString());


                    //GCIrsaliye.DataSource = _tempSiparisDetay;
                    GCIrsaliye.RefreshDataSource();

                }

            }
            else if (gridView1.GetFocusedRowCellValue("Tipi") == "KASA")
            {

                _fStokKasaList = new FStokKasaList(this.Tag.ToString(), "FMusteriSiparis");
                _fStokKasaList.ShowDialog();
                if (_tempKasa != null)
                {
                    _tempPocokalem = new PocoSiparisKalem()
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
                    _tempSiparisDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
                    GCIrsaliye.DataSource = _tempSiparisDetay;
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
            if (_tempSIPARIS != null && TBFaturaNo.Text != _tempSIPARIS.belgeno)
                _tempSIPARIS = null;

            _cariKart.Data(ServisList.CariListeServis);
            if (_cariKart.obje.Where(x => x.kod == TBCariKodu.Text).Count() > 0)
            {
               
                _siparisServis.Data(ServisList.SiparisEkleServis, new PocoSIPARIS()
                {
                    id = _tempSIPARIS != null ? _tempSIPARIS.id : 0,
                    aciklama = TBAciklama.Text,
                    kur = Convert.ToDecimal(TBKur.Text),
                    belgeno = TBFaturaNo.Text,
                    vadetarihi = (DateTime)DTPVadeTarihi.EditValue,
                    guncellemetarihi = DateTime.Now,
                    vadegunu = Convert.ToInt32(TBGun.Text),
                    cariadi = TBCariAdi.Text,
                    siparistarihi = (DateTime)DTSiparisTarih.EditValue,
                    cariid = _cariKart.obje.Where(x => x.kod == TBCariKodu.Text).FirstOrDefault().id,
                    depoid = _depoServis.obje.Where(x => x.depoadi == CBDepo.EditValue).FirstOrDefault().id,
                    althesapid = int.Parse(CBAltHesap.EditValue.ToString()),
                    dovizid = _paraBirimServis.obje.Where(x => x.adi == CBParaBirimi.Text).FirstOrDefault().id,
                    
                    altiskonto1 = Convert.ToDecimal(TBAIskonto1.Text),
                    altiskonto2 = Convert.ToDecimal(TBAIskonto2.Text),
                    altiskonto3 = Convert.ToDecimal(TBAIskonto3.Text),
                    istkontotoplam = Convert.ToDecimal(TBIskontoToplam.Text), //_tempSiparisDetay.Sum(x => x.İskontoTutarı),
                    kdvtoplam = _tempSiparisDetay.Sum(x => x.KdvTutarı),
                    bruttoplam = _tempSiparisDetay.Sum(x => x.BrütToplam),
                    nettoplam = _tempSiparisDetay.Sum(x => x.NetToplam),
                    geneltoplam = _tempSiparisDetay.Sum(x => x.KdvTutarı) + _tempSiparisDetay.Sum(x => x.NetToplam),
                    kdvdahil = CHBKdvDahil.Checked,
                    tip = 0,
                });

                _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
                _olcuBr.Data(ServisList.OlcuBrListeServis);
                int i = 0;

                foreach (var item in _tempSiparisDetay.Where(x => x.StokKodu != "" && x.StokKodu != null).ToList())
                {
                    var stokolcubr = _stokOlcuBr.obje.Where(x => x.stokid == item.StokId).FirstOrDefault();
                    _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, new PocoSIPARISDETAY()
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
                        birimid = _olcuBr.obje.Where(y => y.adi == item.Birim).FirstOrDefault().id,
                        dovizid = item.Doviz,
                        kasamiktar = item.KasaMiktar,
                        dara = item.Dara,
                        darali = item.Daralı,
                        safi = item.Safi,
                        istkontO1 = item.İskonto1,
                        istkontO2 = item.İskonto2,
                        istkontO3 = item.İskonto3,
                        isktoplam = item.İskontoTutarı,
                        siparisid = _siparisServis.obje2.id, ///ID gelecek
                        
                        brutfiyat = item.BrütFiyat,
                        bruttoplam = item.BrütFiyat * item.Safi,
                        bekleyenmiktar = 0,
                        num = item.sıra,
                        hareketdurumu = 0,
                        listefiyatid = 0,
                        tip = 0,
                        kdvtutari = item.KdvTutarı
                    });
             

                    i++;

                    _siparisKasaHarServis.Data(ServisList.SiparisKasaHarListeServis);
                    //_kasaServis.Data(ServisList.StokKasaListeServis);

                    foreach (var test in _kasaaa.Where(x => x.num == item.sıra))
                    {
                        List<PocoSIPARISKASAHAR> except = new List<PocoSIPARISKASAHAR>();


                        foreach (var item2 in test.KasaList)
                        {   //kasalist içinde olmayan stokkasaharların silinmesi
                            _siparisKasaHarServis.Data(ServisList.SiparisKasaHarEkleServis, new PocoSIPARISKASAHAR()
                            {
                                id = item2.ID,
                                siparisid = _siparisServis.obje2.id,
                                kayittipi = 0,
                                kasaid = item2.KASAID,
                                miktar = item2.MIKTAR, // _kasaaa.Where(x => x.num == test.num).Select(x => x.KasaList.Sum(t => t.MIKTAR)).FirstOrDefault()
                                siparisdetayid = _siparisDetayServis.obje2.id
                            });
                            if (item2.ID > 0)
                                except.AddRange(_siparisKasaHarServis.obje.Where(x => x.id == item2.ID));

                        }
                        if (_siparisKasaHarServis.obje.Where(x => x.siparisdetayid == _siparisDetayServis.obje2.id).Except(except).Count() > 0)
                            foreach (var sss in _siparisKasaHarServis.obje.Where(x => x.siparisdetayid == _siparisDetayServis.obje2.id).Except(except))
                            {
                                _siparisKasaHarServis.Data(ServisList.SiparisKasaHarDeleteByIdServis, id: sss.id.ToString(), method: System.Net.Http.HttpMethod.Post);
                            }
                    }


                }

                if (_tempSilinenFaturaDetay.Count() > 0)
                {
                    foreach (var item in _tempSilinenFaturaDetay)
                    {
                        _siparisDetayServis.Data(ServisList.SiparisDetayDeleteByIdServis, id: item.id.ToString(), method: System.Net.Http.HttpMethod.Post);
                        _stokHarServis.Data(ServisList.StokHarSilServis, modellist: _stokHarServis.obje.Where(x => x.irsaliyedetayid == item.id).ToList());
                    }
                    if (_silinenkasaaa.Count() > 0)
                    {
                        foreach (var item in _silinenkasaaa)
                        {
                            foreach (var item2 in item.KasaList)
                            {
                                _siparisKasaHarServis.Data(ServisList.SiparisKasaHarSilServis, modellist: _siparisKasaHarServis.obje.Where(x => x.id == item2.ID).ToList());
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
            if (_tempSIPARIS != null && _tempSIPARIS.kdvdahil == CHBKdvDahil.Checked)
            {
            }
            else
            {
                sx = 1;
                foreach (var item in _tempSiparisDetay)
                {
                    Hesapla(item.sıra);
                }
                sx = 0;
                if (_tempSIPARIS != null)
                    _tempSIPARIS.kdvdahil = CHBKdvDahil.Checked;
            }

        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                num++;
                _tempSiparisDetay.Add(new PocoSiparisKalem() { sıra = num });
                GCIrsaliye.DataSource = _tempSiparisDetay;

                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                gridView1.FocusedColumn = gridView1.Columns["StokKodu"];
                gridView1.Columns["Birim"].VisibleIndex = 8;
                gridView1.Columns["StokId"].Visible = false;
                GCIrsaliye.RefreshDataSource();
            }

        }

        private void FFatura_Load(object sender, EventArgs e)
        {
  
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _siparisKasaHarServis.Data(ServisList.SiparisKasaHarListeServis);
            DataGridYapilandir();
            TBGun.Properties.MaxLength = 4;
            DTPVadeTarihi.EditValue = DateTime.Now;
            DTSiparisTarih.EditValue = DateTime.Now;
            Doldur();
        }

        private void BTNSatirSil_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle > -1)
            {
                _tempSilinenFaturaDetay.Add(new PocoSiparisKalem()
                {
                    id = _tempSiparisDetay[gridView1.FocusedRowHandle].id
                }
               );
                _tempSiparisDetay.Remove(_tempSiparisDetay[gridView1.FocusedRowHandle]);
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
            FMusteriSiparisList ffaturalist = new FMusteriSiparisList(this.Tag.ToString(), "FMusteriSiparis");
            ffaturalist.ShowDialog();
            Doldur();

        }

        private void TBCariKodu_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            _fCariList = new FCariList(this.Tag.ToString(), "FMusteriSiparis");
            _fCariList.ShowDialog();
            if (_tempCariKart != null)
            {
                List<PocoCARIALTHES> altcarilist = new List<PocoCARIALTHES>();
                _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
                TBCariKodu.Text = _tempCariKart.kod;
                TBCariAdi.Text = _tempCariKart.unvan == "" ? _tempCariKart.adi + " " + _tempCariKart.soyadi : _tempCariKart.unvan;
                TBGun.EditValue = _tempCariKart.vadegunu;

                // CBAltHesap.Properties.DataSource = _cariAltHesapServis.obje.Where(x=>x.cariid==_tempCariKart.id).Select(x => x.adi).ToList();
                _carialthescaricari.Data(ServisList.CariAltHesCariListeServis);
                foreach (var item in _carialthescaricari.obje.Where(x => x.cariid == _tempCariKart.id))
                {
                    altcarilist.Add(_cariAltHesapServis.obje.Where(x => x.kayittipi == 0 && x.id == item.carialthesid).FirstOrDefault());
                }
                CBAltHesap.Properties.ValueMember = "ID";
                CBAltHesap.Properties.DisplayMember = "ADI";
                CBAltHesap.EditValue = altcarilist.Count() > 0 ? altcarilist.Select(x => new { ID = x.id, ADI = x.adi.ToString() }).FirstOrDefault().ID : "";
                CBAltHesap.Properties.DataSource = altcarilist.Select(x => new { ID = x.id, ADI = x.adi.ToString() });

            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        #endregion


    }

}