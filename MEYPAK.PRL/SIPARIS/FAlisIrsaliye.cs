using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.Assets.Scripts;
using MEYPAK.PRL.CARI;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.IRSALIYE
{
    public partial class FAlisIrsaliye : Form
    {  
           #region TANIMLAR
        FStokKasaList fKasaList;
        List<PocoIrsaliyeKalem> _tempIrsaliyeDetay = new List<PocoIrsaliyeKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        GenericWebServis<PocoCARIALTHESCARI> _carialthescaricari;
        PocoIrsaliyeKalem _tempPocokalem;
        FStokList _fStokList;
        FCariList _fCariList;
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoIRSALIYE _tempIrsaliye;
        public PocoCARIKART _tempCariKart;
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        List<PocoOLCUBR> _tempolcuBr;
        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyedetayServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoCARIKART> _cariKart;
        GenericWebServis<PocoSTOK> _stokServis;
        FStokOlcuBrList _fStokOlcuBrList;
        FStokKasaList _fStokKasaList;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _kasaServis;
        GenericWebServis<PocoCARIALTHES> _cariAltHes;
        GenericWebServis<PocoSTOKHAR> _stokHarServis;
        FGetKunye _fGetKunye;
        #endregion
        public FAlisIrsaliye()
        {
            InitializeComponent();
            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList = new DataGridViewComboBoxColumn();
            DGVKasaSec = new DataGridViewButtonColumn();
            DGVKasaList = new DataGridViewComboBoxColumn();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoServis.Data(ServisList.DepoListeServis);
            _stokHarServis = new GenericWebServis<PocoSTOKHAR>();

            CBParaBirimi.Properties.DataSource = _paraBirimServis.obje.Where(x => x.kayittipi == 0).Select(x => x.adi).ToList();
            CBDepo.Properties.DataSource = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).ToList();
            CBDepo.Text = _depoServis.obje.Where(x => x.kayittipi == 0).Select(x => x.depoadi).FirstOrDefault();



            CBParaBirimi.Text = _paraBirimServis.obje.Where(x => x.kayittipi == 0 && x.adi == "TÜRK LİRASI").Select(x => x.adi).FirstOrDefault();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _irsaliyedetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _cariKart = new GenericWebServis<PocoCARIKART>();
            _cariKart.Data(ServisList.CariListeServis);
            _stokServis = new GenericWebServis<PocoSTOK>();
            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _kasaServis = new GenericWebServis<PocoSTOKKASA>();
            _tempKasaList = new List<KasaList>();
            _carialthescaricari = new GenericWebServis<PocoCARIALTHESCARI>();
            _kasaaa = new List<ListKasaList>();
        }

        void temizle()
        {
            num = 0;
            GCIrsaliye.DataSource = "";
            _tempIrsaliyeDetay.Clear();
            _kasaaa.Clear();
            _tempIrsaliyeDetay.Add(new PocoIrsaliyeKalem());
            GCIrsaliye.DataSource = _tempIrsaliyeDetay;
            //DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["KasaId"].Visible = false;
        }
        public void Temizle(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    Temizle(ctrl.Controls);
                }
            }
        }
        RepositoryItemLookUpEdit riLookup, riLookup3;
        GridColumn gridColumn2;
        public List<ListKasaList> _kasaaa;
        public List<KasaList> _tempKasaList;
        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempIrsaliyeDetay.Add(new PocoIrsaliyeKalem() { Tipi = "STOK" });
            GCIrsaliye.DataSource = _tempIrsaliyeDetay;

            gridView1.Columns["sıra"].Visible = false;

            GridColumn gridColumn = gridView1.Columns.AddVisible("Seç", "Seç");
            RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit.NullText = "Seç";
            repositoryItemButtonEdit.NullValuePrompt = "Seç";



            gridColumn2 = gridView1.Columns.AddVisible("BirimSec", "Sec");
            RepositoryItemButtonEdit repositoryItemButton2 = new RepositoryItemButtonEdit();
            repositoryItemButton2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButton2.NullText = "Sec";
            repositoryItemButton2.NullValuePrompt = "Seç";

            GridColumn gridColumn3 = gridView1.Columns.AddVisible("KasaSec", "Sec");
            RepositoryItemButtonEdit repositoryItemButtonEdit3 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit3.NullText = "Sec";
            repositoryItemButtonEdit3.NullValuePrompt = "Seç";



            GridColumn gridColumn4 = gridView1.Columns.AddVisible("Kunye", "KunyeSec");
            RepositoryItemButtonEdit repositoryItemButtonEdit4 = new RepositoryItemButtonEdit();
            repositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit4.NullText = "Seç";
            repositoryItemButtonEdit4.NullValuePrompt = "Seç";


            var datatb = new DataTable();
            datatb.Columns.Add("ID", typeof(int));
            datatb.Columns.Add("TIP", typeof(string));

            datatb.Rows.Add(0, "STOK");
            datatb.Rows.Add(1, "HIZMET");
            datatb.Rows.Add(2, "KASA");
            datatb.Rows.Add(3, "DEMIRBAS");
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

            gridView1.Columns["Tipi"].OptionsColumn.AllowEdit = true;
            //repoGV.Columns.Add(colun2);
            gridView1.Columns["Tipi"].ColumnEdit = riLookup;
            _tempKasaList = new List<KasaList>();
            riLookup3 = new RepositoryItemLookUpEdit();
            riLookup3.ValueMember = "ID";
            riLookup3.DisplayMember = "KASAADI";


            riLookup3.NullText = "";

            riLookup3.BestFitWidth = 70;
            riLookup3.AutoHeight = true;
            // riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            riLookup3.DropDownRows = _tempKasaList.Count();
            riLookup3.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
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

            gridView1.BestFitColumns();



            repositoryItemButtonEdit3.ButtonClick += RepositoryItemButtonEdit3_ButtonClick;
            repositoryItemButtonEdit4.ButtonClick += RepositoryItemButtonEdit4_ButtonClick;
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            repositoryItemButton2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit);
            GCIrsaliye.RepositoryItems.Add(repositoryItemButton2);
            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit3);
            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit4);
            gridColumn.ColumnEdit = repositoryItemButtonEdit;
            gridColumn2.ColumnEdit = repositoryItemButton2;
            gridColumn3.ColumnEdit = repositoryItemButtonEdit3;
            gridColumn4.ColumnEdit = repositoryItemButtonEdit4;
            gridColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

            gridView1.Columns["Seç"].VisibleIndex = 2;
            gridView1.Columns["BirimSec"].VisibleIndex = 9;
            gridView1.Columns["KasaSec"].VisibleIndex = 7;
            gridView1.Columns["Kunye"].VisibleIndex = 11;
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["Tipi"].VisibleIndex = 0;
            gridView1.Columns["Doviz"].VisibleIndex = 20;
            gridView1.Columns["KasaId"].Visible = false;
            gridView1.Columns["Tipi"].UnboundDataType = System.Type.GetType("System.String");
            GCIrsaliye.ForceInitialize();

        }

        private void RepositoryItemButtonEdit4_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fGetKunye = new FGetKunye(this.Tag.ToString(),"FAlisIrsaliye");
            _fGetKunye.ShowDialog();
        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {

        }


        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            if (_kasaaa.Where(x => x.num.ToString() == gridView1.FocusedRowHandle.ToString()).Count() > 0)
            {
                fKasaList = new FStokKasaList(this.Tag.ToString(), "AlisIrsaliye", gridView1.FocusedRowHandle.ToString(), _kasaaa);
            }
            else
            {
                fKasaList = new FStokKasaList(this.Tag.ToString(), "AlisIrsaliye", gridView1.FocusedRowHandle.ToString());
            }
            fKasaList.ShowDialog();
            if (_kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).Count() > 0)
                riLookup3.DataSource = _kasaaa.Where(x => x.num == gridView1.FocusedRowHandle).FirstOrDefault().KasaList;
            GCIrsaliye.RefreshDataSource();
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fStokOlcuBrList = new FStokOlcuBrList(this.Tag.ToString(), "AlisIrsaliye",_tempStok.id);
            _fStokOlcuBrList.ShowDialog();
        }

        private DataView clone = null;
        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Tipi") == "STOK")
            {
                _fStokList = new FStokList(this.Tag.ToString(), "AlisIrsaliye");
                _fStokList.ShowDialog();

                _tempPocokalem = new PocoIrsaliyeKalem()
                {
                    Tipi = "STOK",
                    StokId = _tempStok.id,
                    StokKodu = _tempStok.kod,
                    StokAdı = _tempStok.adi,
                    sıra = gridView1.GetFocusedDataSourceRowIndex(),
                    Birim = "",//_olcuBr.obje.Where(x => x.adi == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().adi,
                               //KasaAdı = "",
                    Kdv = _tempStok.satiskdv,
                };
            }
            else if (gridView1.GetFocusedRowCellValue("Tipi") == "KASA")
            {

                _fStokKasaList = new FStokKasaList(this.Tag.ToString(), "AlisIrsaliye");
                _fStokKasaList.ShowDialog();
                if (_tempKasa != null)
                {
                    _tempPocokalem = new PocoIrsaliyeKalem()
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
                }
            }




            /* DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();*/ //////////////////////////// BAKILCAK
            _tempIrsaliyeDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
            GCIrsaliye.DataSource = _tempIrsaliyeDetay;
            gridView1.RefreshData();

        }

        int i;

        decimal birimfiyat = 0, kdv = 0, bsnc = 0, brutfiyat = 0, netfiyat = 0, nettoplam = 0, brüttoplam = 0, geneltoplam = 0, isktoplam = 0, kdvtoplam = 0, miktar = 0;

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }
        int tempnum;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tempnum = gridView1.GetFocusedDataSourceRowIndex();
            if (_kasaaa.Where(x => x.num == tempnum).Count() > 0)
                riLookup3.DataSource = _kasaaa.Where(x => x.num == tempnum).FirstOrDefault().KasaList;
        }

        private void BTKaydet_Click_1(object sender, EventArgs e)
        {
            _cariKart.Data(ServisList.CariListeServis);
            _irsaliyeServis.Data(ServisList.IrsaliyeEkleServis, new PocoIRSALIYE()
            {
                aciklama = TBAciklama.Text,
                kur = Convert.ToDecimal(TBKur.Text),
                belgeno = TBIrsaliyeNo.Text,
                vadetarihi = (DateTime)DTPVadeTarihi.EditValue,
                guncellemetarihi = DateTime.Now,
                vadegunu = Convert.ToInt32(TBGun.Text),
                cariadi = TBCariAdi.Text,
                cariid = _cariKart.obje.Where(x => x.kod == TBCariKodu.Text).FirstOrDefault().id,
                depoid = _depoServis.obje.Where(x => x.depoadi == CBDepo.EditValue).FirstOrDefault().id,
                // althesapid = _cariAltHesapServis.obje.Where(x => x.adi == CBAltHesap.EditValue).FirstOrDefault().id,
                dovizid = _paraBirimServis.obje.Where(x => x.adi == CBParaBirimi.Text).FirstOrDefault().id,
                iskontotoplam = _tempIrsaliyeDetay.Sum(x => x.İskontoTutarı),
                kdvtoplam = _tempIrsaliyeDetay.Sum(x => x.KdvTutarı),
                bruttoplam = _tempIrsaliyeDetay.Sum(x => x.BrütToplam),
                nettoplam = _tempIrsaliyeDetay.Sum(x => x.NetToplam),
                geneltoplam = _tempIrsaliyeDetay.Sum(x => x.KdvTutarı) + _tempIrsaliyeDetay.Sum(x => x.NetToplam),
                tip = 1,
            });

            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            int i = 0;
            foreach (var item in _tempIrsaliyeDetay.Where(x => x.StokKodu != "").ToList())
            {
                var stokolcubr = _stokOlcuBr.obje.Where(x => x.stokid == item.StokId).FirstOrDefault();

                _irsaliyedetayServis.Data(ServisList.IrsaliyeDetayEkleServis, new PocoIRSALIYEDETAY()
                {
                    stokid = item.StokId,
                    stokadi = item.StokAdı,
                    aciklama = item.Acıklama,
                    kdv = item.Kdv,
                    //kasaid = item.KasaId,
                    nettoplam = item.NetToplam,
                    netfiyat = item.NetFiyat,
                    birimid = _olcuBr.obje.Where(x => x.adi.ToString() == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Birim").ToString()).FirstOrDefault().id,
                    dovizid = 0,
                    miktar = item.Miktar,
                    istkontO1 = item.İskonto1,
                    istkontO2 = item.İskonto2,
                    istkontO3 = item.İskonto3,
                    irsaliyeid = _irsaliyeServis.obje2.id, ///ID gelecek

                    brutfiyat = item.BrütFiyat,
                    bruttoplam = item.BrütFiyat * item.Miktar,
                    bekleyenmiktar = 0,
                    hareketdurumu = 0,
                    listefiyatid = 0,
                    tip =1,
                    kdvtutari = item.KdvTutarı,
                    kunye=item.Kunye
                });

                _stokHarServis.Data(ServisList.StokHarEkleServis, new Entity.PocoModels.STOK.PocoSTOKHAR()
                {
                    aciklama = item.Acıklama,
                    belgE_NO = _irsaliyeServis.obje2.belgeno,
                    hareketturu =   4,
                    birim = _olcuBr.obje.Where(x => x.adi.ToString() == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Birim").ToString()).FirstOrDefault().id,
                    bruttoplam = item.BrütToplam,
                    depoid = _irsaliyeServis.obje2.depoid,
                    io = 1,
                    kdv = item.Kdv,
                    miktar = item.Miktar,
                    netfiyat = item.NetFiyat,
                    nettoplam = item.NetToplam,
                    stokid = item.StokId,
                    sayimid = 0,kunye=item.Kunye
                });

                i++;


                _kasaServis.Data(ServisList.StokKasaListeServis);

                foreach (var test in _kasaaa.Where(x => x.num == item.sıra))
                {
                    foreach (var item2 in test.KasaList)
                    {


                        _stokKasaHarServis.Data(ServisList.StokKasaHarEkleServis, new PocoSTOKKASAHAR()
                        {
                            belge_no = TBIrsaliyeNo.Text,
                            irsaliyeid = _irsaliyeServis.obje2.id,
                            io = 0,
                            cariid = _cariKart.obje.Where(x => x.kod == TBCariKodu.Text).FirstOrDefault().id,
                            kayittipi = 0,
                            kasaid = item2.KASAID,
                            miktar = item2.MIKTAR,


                        });
                    }
                }


            }
            temizle();

        }
        int num = 0;
        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                num++;
                _tempIrsaliyeDetay.Add(new PocoIrsaliyeKalem() { sıra = num });
                GCIrsaliye.DataSource = _tempIrsaliyeDetay;

                //dataGridView1.Columns["DGVOlcuBr"].DisplayIndex = 6;
                //dataGridView1.Columns["DGVFiyatList"].DisplayIndex = dataGridView1.ColumnCount - 1; 
                //dataGridView1.Columns["StokKodu"].DisplayIndex = 0;
                //dataGridView1.Columns["DGVStoKSec"].DisplayIndex = 1; 
                //dataGridView1.Columns["StokAdı"].DisplayIndex = 2; 

                //dataGridView1.Columns["DGVKasaSec"].DisplayIndex = 8;
                //dataGridView1.Columns["DVGKasaList"].DisplayIndex = dataGridView1.ColumnCount-1;


                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr", _tempIrsaliyeDetay[i].Birim.ToString());
                }
                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                gridView1.FocusedColumn = gridView1.Columns["StokKodu"];
                gridView1.Columns["Seç"].VisibleIndex = 2;
                gridView1.Columns["BirimSec"].VisibleIndex = 8;
                gridView1.Columns["StokId"].Visible = false;
                GCIrsaliye.RefreshDataSource();
                ////dataGridView1.Invalidate();
                //dataGridView1.Refresh();

                i = 0;


            }
            if (i == 0)
            {
                if (e.KeyChar == (char)Keys.Tab)
                {
                    if (gridView1.RowCount! > gridView1.GetFocusedDataSourceRowIndex())
                    {
                        if (gridView1.GetFocusedDataSourceRowIndex() >= 0 && gridView1.Columns[gridView1.FocusedColumn.VisibleIndex].VisibleIndex - 1 == gridView1.Columns["StokKodu"].VisibleIndex)
                        {
                            gridView1.FocusedColumn = gridView1.Columns["Miktar"];
                        }
                        else if (gridView1.FocusedRowHandle >= 0 && gridView1.Columns[gridView1.FocusedColumn.VisibleIndex].VisibleIndex - 1 == gridView1.Columns["Miktar"].VisibleIndex)
                        {
                            gridView1.FocusedColumn = gridView1.Columns["BirimFiyat"];
                        }
                    }

                }
            }
            if (e.KeyChar == 45 && e.KeyChar == (char)Keys.LControlKey)
            {
                MessageBox.Show("BURDAAAA");
            }
        }
        private void FAlisIrsaliye_Load(object sender, EventArgs e)
        {
            DataGridYapilandir();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (sy == 0)
            {
                sy = 1;

                daralı = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Daralı"));
                dara = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Dara"));
                gridView1.SetFocusedRowCellValue("Safi", daralı - dara);
                if (CHBKdvDahil.Checked == false)
                {
                    birimfiyat = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("BirimFiyat"));
                    brutfiyat = birimfiyat;
                    miktar = _tempIrsaliyeDetay.Where(x => x.StokId.ToString() == gridView1.GetFocusedRowCellValue("StokId").ToString()).FirstOrDefault().Miktar;
                    kdv = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Kdv"));
                    isktoplam = (birimfiyat * Convert.ToDecimal(gridView1.GetFocusedRowCellValue("İskonto1"))) / 100;
                    isktoplam += (isktoplam * Convert.ToDecimal(gridView1.GetFocusedRowCellValue("İskonto2"))) / 100;
                    isktoplam += (isktoplam * Convert.ToDecimal(gridView1.GetFocusedRowCellValue("İskonto3"))) / 100;
                    netfiyat = birimfiyat - isktoplam;
                    isktoplam = isktoplam * miktar;
                    nettoplam = netfiyat * miktar;
                    kdvtoplam = (((nettoplam * kdv) / 100));
                    brüttoplam = brutfiyat * miktar;
                    geneltoplam = nettoplam + kdvtoplam;
                }
                else
                {
                    kdv = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("Kdv"));
                    birimfiyat = (Convert.ToDecimal(gridView1.GetFocusedRowCellValue("BirimFiyat")));
                    netfiyat = birimfiyat / (1 + (kdv / 100));
                    miktar = _tempIrsaliyeDetay.Where(x => x.StokId.ToString() == gridView1.GetFocusedRowCellValue("StokId")).FirstOrDefault().Miktar;
                    isktoplam = (netfiyat * Convert.ToDecimal(gridView1.GetFocusedRowCellValue("İskonto1"))) / 100;
                    isktoplam += (isktoplam * Convert.ToDecimal(gridView1.GetFocusedRowCellValue("İskonto2"))) / 100;
                    isktoplam += (isktoplam * Convert.ToDecimal(gridView1.GetFocusedRowCellValue("İskonto3"))) / 100;
                    netfiyat = netfiyat - isktoplam;
                    brutfiyat = netfiyat + isktoplam;
                    nettoplam = netfiyat * miktar;
                    kdvtoplam = ((nettoplam * kdv) / 100);
                    brüttoplam = brutfiyat * miktar;
                    geneltoplam = nettoplam + kdvtoplam;
                    isktoplam = isktoplam * miktar;

                }

                gridView1.SetFocusedRowCellValue("BrütFiyat", decimal.Round(brutfiyat, 2));
                gridView1.SetFocusedRowCellValue("NetToplam", decimal.Round(nettoplam, 2));
                gridView1.SetFocusedRowCellValue("BrütToplam", decimal.Round(brüttoplam, 2));
                gridView1.SetFocusedRowCellValue("İskontoTutarı", decimal.Round(isktoplam, 2));
                gridView1.SetFocusedRowCellValue("KdvTutarı", decimal.Round(kdvtoplam, 2));
                gridView1.SetFocusedRowCellValue("NetFiyat", decimal.Round(netfiyat, 2));


                TBBrutToplam.Text = decimal.Round(_tempIrsaliyeDetay.Sum(x => x.BrütToplam), 2).ToString();
                TBIskontoToplam.Text = decimal.Round(_tempIrsaliyeDetay.Sum(x => x.İskontoTutarı), 2).ToString();
                TBKdvTutari.Text = decimal.Round(_tempIrsaliyeDetay.Sum(x => x.KdvTutarı), 2).ToString();
                TBGenelToplam.Text = decimal.Round(_tempIrsaliyeDetay.Sum(x => x.NetToplam + x.KdvTutarı), 2).ToString();
                TBAraToplam.Text = decimal.Round(_tempIrsaliyeDetay.Sum(x => x.NetToplam), 2).ToString();
                sy = 0;
            }
        }



        int sy = 0;
        decimal daralı, dara;




        private void TBSiparisNo_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FIrsaliyeList firsaliyelist = new FIrsaliyeList(this.Tag.ToString(), "FAlisIrsaliye");
            firsaliyelist.ShowDialog();
            if (_tempIrsaliye != null)
            {
                TBIrsaliyeNo.Text = _tempIrsaliye.belgeno;
                //todo : TBCariKodu.Text = 

                TBCariKodu.Text = _cariKart.obje.Where(x => x.id == _tempIrsaliye.cariid).FirstOrDefault().kod;
                TBCariAdi.Text = _tempIrsaliye.cariadi;
                _stokServis.Data(ServisList.StokListeServis);
                //TODO TBKasa.Text = 
                DTSiparisTarih.EditValue = _tempIrsaliye.irsaliyetarihi;
                TBAciklama.Text = _tempIrsaliye.aciklama;
                DTPVadeTarihi.EditValue = _tempIrsaliye.vadetarihi;
                TBGun.Text = _tempIrsaliye.vadegunu.ToString();


                _irsaliyedetayServis.Data(ServisList.IrsaliyeDetayListeServis + 2, null, "query=SIPARISID=" + _tempIrsaliye.id.ToString());
                GCIrsaliye.DataSource = _irsaliyedetayServis.obje.Select(x => new PocoSiparisKalem()
                {
                    StokId = x.stokid,
                    StokKodu = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod,//,  TODOO:BAKILACAAAK
                    StokAdı = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().adi,
                    Birim = "0",// _olcuBr.obje.Where(x => x.ADI == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().ADI,
                                //KasaAdı = "",
                    Kdv = _tempStok.satiskdv,
                    Doviz = "TL", //_tempStok.SDOVIZID 
                });
            }

        }
        private void TBCariKodu_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            _fCariList = new FCariList(this.Tag.ToString(), "AlisIrsaliye");
            _fCariList.ShowDialog();
            if (_tempCariKart != null)
            {
                List<PocoCARIALTHES> altcarilist = new List<PocoCARIALTHES>();
                TBCariKodu.Text = _tempCariKart.kod;
                TBCariAdi.Text = _tempCariKart.unvan == "" ? _tempCariKart.adi + " " + _tempCariKart.soyadi : _tempCariKart.unvan;
                // CBAltHesap.Properties.DataSource = _cariAltHesapServis.obje.Where(x=>x.cariid==_tempCariKart.id).Select(x => x.adi).ToList();
                _carialthescaricari.Data(ServisList.CariAltHesCariListeServis);
                foreach (var item in _carialthescaricari.obje.Where(x => x.cariid == _tempCariKart.id))
                {
                    altcarilist.Add(_cariAltHesapServis.obje.Where(x => x.kayittipi == 0 && x.id == item.carialthesid).FirstOrDefault());
                }
                CBAltHesap.Properties.DataSource = altcarilist.Select(x => new { ID = x.id, ADI = x.adi });
                CBAltHesap.Properties.ValueMember = "ID";
                CBAltHesap.Properties.DisplayMember = "ADI";
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["Miktar"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["BirimFiyat"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["NetFiyat"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["BrütFiyat"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["İskonto1"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["İskonto2"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["İskonto3"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["Kdv"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["KdvTutarı"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["İskontoTutarı"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["NetToplam"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (gridView1.FocusedColumn.VisibleIndex == gridView1.Columns["BrütToplam"].VisibleIndex)
            {
                e.RepositoryItem.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
        }






        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }





    }

}