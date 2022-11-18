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
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
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
    public partial class FSatisIrsaliye : Form
    { 
        public FSatisIrsaliye()
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

            CBParaBirimi.Properties.DataSource = _paraBirimServis.obje.Select(x => x.adi).ToList();
            CBDepo.Properties.DataSource = _depoServis.obje.Select(x => x.depoadi).ToList();
            CBAltHesap.Properties.DataSource = _cariAltHesapServis.obje.Select(x => x.adi).ToList();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _irsaliyeDetayServis.Data(ServisList.DepoListeServis);
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _cariKart = new GenericWebServis<PocoCARIKART>();
            _cariKart.Data(ServisList.CariListeServis);
            _stokServis = new GenericWebServis<PocoSTOK>();
            _irsaliyeKasaHarServis = new GenericWebServis<PocoIRSALIYEKASAHAR>();
            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
        }
        FStokKasaList fKasaList;
        List<PocoIrsaliyeKalem> _tempIrsaliyeDetay = new List<PocoIrsaliyeKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        GenericWebServis<PocoIRSALIYEKASAHAR> _irsaliyeKasaHarServis;

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
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoCARIKART> _cariKart;
        GenericWebServis<PocoSTOK> _stokServis;
        FStokOlcuBrList _fStokOlcuBrList;
        FStokKasaList _fStokKasaList;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        void temizle()
        {
            GCIrsaliye.DataSource = "";
            _tempIrsaliyeDetay.Clear();
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
        RepositoryItemLookUpEdit riLookup;
        GridColumn gridColumn2;
        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempIrsaliyeDetay.Add(new PocoIrsaliyeKalem());
            GCIrsaliye.DataSource = _tempIrsaliyeDetay;

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


            gridView1.Columns["Tipi"].OptionsColumn.AllowEdit = true;
            //repoGV.Columns.Add(colun2);
            gridView1.Columns["Tipi"].ColumnEdit = riLookup;



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
            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            repositoryItemButton2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit);
            GCIrsaliye.RepositoryItems.Add(repositoryItemButton2);
            GCIrsaliye.RepositoryItems.Add(repositoryItemButtonEdit3);
            gridColumn.ColumnEdit = repositoryItemButtonEdit;
            gridColumn2.ColumnEdit = repositoryItemButton2;
            gridColumn3.ColumnEdit = repositoryItemButtonEdit3;
            gridColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

            gridView1.Columns["Seç"].VisibleIndex = 2;
            gridView1.Columns["BirimSec"].VisibleIndex = 9;
            gridView1.Columns["KasaSec"].VisibleIndex = 7;
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["Tipi"].VisibleIndex = 0;
            gridView1.Columns["Doviz"].VisibleIndex = 20;
            gridView1.Columns["KasaId"].Visible = false;
            gridView1.Columns["Tipi"].UnboundDataType = System.Type.GetType("System.String");
            GCIrsaliye.ForceInitialize();

        }

        private void RiLookup_EditValueChanged(object? sender, EventArgs e)
        {
            
        }


        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FStokKasaList fKasaList = new FStokKasaList(this.Tag.ToString(), "SatisIrsaliye");
            fKasaList.ShowDialog();
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fStokOlcuBrList = new FStokOlcuBrList(this.Tag.ToString(), "SatisIrsaliye");
            _fStokOlcuBrList.stokid = _tempStok.id;
            _fStokOlcuBrList.ShowDialog();
        }

        private DataView clone = null;
        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("Tipi") == "STOK")
            {
                _fStokList = new FStokList(this.Tag.ToString(), "SatisIrsaliye");
                _fStokList.ShowDialog();

                _tempPocokalem = new PocoIrsaliyeKalem()
                {
                    Tipi = "STOK",
                    StokId = _tempStok.id,
                    StokKodu = _tempStok.kod,
                    StokAdı = _tempStok.adi,
                    Birim = "",//_olcuBr.obje.Where(x => x.adi == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().adi,
                               //KasaAdı = "",
                    Kdv = _tempStok.satiskdv,
                };
            }
            else if (gridView1.GetFocusedRowCellValue("Tipi") == "KASA")
            {
                _fStokKasaList = new FStokKasaList(this.Tag.ToString(), "SatisIrsaliye");
                _fStokKasaList.ShowDialog();
                if (_tempKasa != null)
                {
                    _tempPocokalem = new PocoIrsaliyeKalem()
                    {
                        Tipi = "KASA",
                        StokId = _tempKasa.id,
                        StokKodu = _tempKasa.kasakodu,
                        StokAdı = _tempKasa.kasaadi,
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

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _cariKart.Data(ServisList.CariListeServis);

            _irsaliyeServis.Data(ServisList.IrsaliyeEkleServis, new PocoIRSALIYE()
            {
                aciklama = TBAciklama.Text,
                kur = Convert.ToDecimal(TBKur.Text),
                belgeno = TBSiparisNo.Text,
                vadetarihi = (DateTime)DTPVadeTarihi.EditValue,
                guncellemetarihi = DateTime.Now,
                vadegunu = Convert.ToInt32(TBGun.Text),
                cariadi = TBCariAdi.Text,
                cariid = _cariKart.obje.Where(x => x.kod == TBCariKodu.Text).FirstOrDefault().id,
                depoid = _depoServis.obje.Where(x => x.depoadi == CBDepo.EditValue).FirstOrDefault().id,
                althesapid = _cariAltHesapServis.obje.Where(x => x.adi == CBAltHesap.EditValue).FirstOrDefault().id,
                dovizid = _paraBirimServis.obje.Where(x => x.kisaadi == CBParaBirimi.EditValue).FirstOrDefault().id,
                iskontotoplam = _tempIrsaliyeDetay.Sum(x => x.İskontoTutarı),
                kdvtoplam = _tempIrsaliyeDetay.Sum(x => x.KdvTutarı),
                bruttoplam = _tempIrsaliyeDetay.Sum(x => x.BrütToplam),
                nettoplam = _tempIrsaliyeDetay.Sum(x => x.NetToplam),
                geneltoplam = _tempIrsaliyeDetay.Sum(x => x.KdvTutarı) + _tempIrsaliyeDetay.Sum(x => x.NetToplam),
                tip = 0,

            });
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            int i = 0;
            foreach (var item in _tempIrsaliyeDetay.Where(x => x.StokKodu != "").ToList())
            {
                var stokolcubr = _stokOlcuBr.obje.Where(x => x.stokid == item.StokId).FirstOrDefault();

                _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayEkleServis, new PocoIRSALIYEDETAY()
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
                    siparisid = _irsaliyeServis.obje2.id, ///ID gelecek

                    brutfiyat = item.BrütFiyat,
                    bruttoplam = item.BrütFiyat * item.Miktar,
                    bekleyenmiktar = 0,
                    hareketdurumu = 0,
                    listefiyatid = 0,
                    tip = 0,
                    kdvtutari = item.KdvTutarı
                });
                i++;

                _irsaliyeKasaHarServis.Data(ServisList.IrsaliyeKasaHarEkleServis, new PocoIRSALIYEKASAHAR()
                {
                    //KASAID = item.KasaId,
                    IRSALIYEID = _irsaliyeServis.obje2.id,
                    IRSALIYEDETAYID = _irsaliyeDetayServis.obje2.id
                });




            }
            temizle();

        }
        private void FIrsaliye_Load(object sender, EventArgs e)
        {
            DataGridYapilandir();
            CBParaBirimi.EditValue = 0;
        }

        private void BTKaydet_Click_1(object sender, EventArgs e)
        {

        }
        int i;

        decimal birimfiyat = 0, kdv = 0, bsnc = 0, brutfiyat = 0, netfiyat = 0, nettoplam = 0, brüttoplam = 0, geneltoplam = 0, isktoplam = 0, kdvtoplam = 0, miktar = 0;

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {

                GCIrsaliye.DataSource = "";
                _tempIrsaliyeDetay.Add(new PocoIrsaliyeKalem());
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
                gridView1.Columns["BirimSec"].VisibleIndex = 7;
                gridView1.Columns["StokId"].Visible = false;
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


        int sy = 0;
        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (sy == 0)
            {
                sy = 1;
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

        private void TBSiparisNo_Properties_Click(object sender, EventArgs e)
        {

        }

        private void TBSiparisNo_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FMusteriSiparisList fMusteriSiparisList = new FMusteriSiparisList(this.Tag.ToString(), "Siparis");
            fMusteriSiparisList.ShowDialog();
            if (_tempIrsaliye != null)
            {
                TBSiparisNo.Text = _tempIrsaliye.belgeno;
                //todo : TBCariKodu.Text = 

                TBCariKodu.Text = _cariKart.obje.Where(x => x.id == _tempIrsaliye.cariid).FirstOrDefault().kod;
                TBCariAdi.Text = _tempIrsaliye.cariadi;
                _stokServis.Data(ServisList.StokListeServis);
                //TODO TBKasa.Text = 
                DTSiparisTarih.EditValue = _tempIrsaliye.irsaliyetarihi;
                TBAciklama.Text = _tempIrsaliye.aciklama;
                DTPVadeTarihi.EditValue = _tempIrsaliye.vadetarihi;
                DTSevkiyatTarih.Value = _tempIrsaliye.sevkiyattarihi;
                TBGun.Text = _tempIrsaliye.vadegunu.ToString();
                _irsaliyeDetayServis.Data(ServisList.SiparisDetayListeServis + 2, null, "query=SIPARISID=" + _tempIrsaliye.id.ToString());
                GCIrsaliye.DataSource = _irsaliyeDetayServis.obje.Select(x => new PocoSiparisKalem()
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

            _fCariList = new FCariList(this.Tag.ToString(), "musterisiparis");
            _fCariList.ShowDialog();
            if (_tempCariKart != null)
            {
                TBCariKodu.Text = _tempCariKart.kod;
                TBCariAdi.Text = _tempCariKart.unvan == "" ? _tempCariKart.adi + " " + _tempCariKart.soyadi : _tempCariKart.unvan;
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



        private void BTCariSec_Click(object sender, EventArgs e)
        {
        }


        private void BTSiparisSec_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridView1.Invalidate();
            //dataGridView1.Refresh();


        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //    if (gridView1.GetFocusedRowCellValue("DGVOlcuBr")!=null)
            //    _tempIrsaliyeDetay[e.RowIndex].Birim = dataGridView1.Rows[e.RowIndex].Cells["DGVOlcuBr"].Value.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (_tempPocokalem != null)
            //{
            //    _tempIrsaliyeDetay[e.RowIndex].Birim = dataGridView1.Rows[e.RowIndex].Cells["DGVOlcuBr"].EditedFormattedValue.ToString();
            //}
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


        }



        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dataGridView1.Rows.Count > 1)
            //    i = 1;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (_tempIrsaliyeDetay != null)
            //{
            //    if (dataGridView1.CurrentCell == dataGridView1.Rows[e.RowIndex].Cells["BrütToplam"] && brutfiyat != 0)
            //    {
            //        dataGridView1.Rows[e.RowIndex].Cells["BrütToplam"].Value = brüttoplam;
            //    }
            //    else if (dataGridView1.CurrentCell == dataGridView1.Rows[e.RowIndex].Cells["NetToplam"] && nettoplam != 0)
            //    {
            //        dataGridView1.Rows[e.RowIndex].Cells["NetToplam"].Value = nettoplam;
            //    }
            //}
        }







    }

} 