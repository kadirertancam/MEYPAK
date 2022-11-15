using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
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
using MEYPAK.PRL.STOK;
using MEYPAK.BLL.DEPO;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using MEYPAK.PRL.Assets.Scripts;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.BLL.Assets;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DevExpress.XtraGrid.Views.Base;
using MEYPAK.PRL.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.Models.CARI;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FSatinAlmaSiparis : Form
    {

        public FSatinAlmaSiparis()
        {
            InitializeComponent(); 

            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList = new DataGridViewComboBoxColumn();
            DGVKasaSec = new DataGridViewButtonColumn();
            DGVKasaList = new DataGridViewComboBoxColumn();


            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoServis.Data(ServisList.DepoListeServis);
            CBDepo.Properties.DataSource = _depoServis.obje.Select(x => x.depoadi).ToList();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _siparisServis.Data(ServisList.SiparisListeServis);
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _siparisDetayServis.Data(ServisList.DepoListeServis);
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _cariKart = new GenericWebServis<PocoCARIKART>();
            _cariKart.Data(ServisList.CariListeServis);
            _stokServis = new GenericWebServis<PocoSTOK>();
            _siparisKasaHarServis = new GenericWebServis<PocoSIPARISKASAHAR>();


            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
        }
        FStokKasaList fKasaList;
        List<PocoSiparisKalem> _tempSiparisDetay = new List<PocoSiparisKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        GenericWebServis<PocoSIPARISKASAHAR> _siparisKasaHarServis;

        PocoSiparisKalem _tempPocokalem;
        FStokList _fStokList;
        FCariList _fCariList;
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoSIPARIS _tempSiparis;
        public PocoCARIKART _tempCariKart;

        private void FSiparis_Load(object sender, EventArgs e)
        {

            DataGridYapilandir();
            CBParaBirimi.EditValue = 0;
        }
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        List<PocoOLCUBR> _tempolcuBr;
        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoCARIKART> _cariKart;
        GenericWebServis<PocoSTOK> _stokServis;
        FStokOlcuBrList _fStokOlcuBrList;
        void temizle()
        {
            GCSatinAlmaSiparis.DataSource = "";
            _tempSiparisDetay.Clear();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            GCSatinAlmaSiparis.DataSource = _tempSiparisDetay;
            //DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["KasaId"].Visible = false;

        }

        GridColumn gridColumn2;
        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            GCSatinAlmaSiparis.DataSource = _tempSiparisDetay;
            gridView1.RefreshData();
            DGVStokSec.FlatStyle = FlatStyle.Flat;
            DGVOlcuBr.Name = "DGVOlcuBr";
            DGVOlcuBr.HeaderText = "Birim";
            DGVOlcuBr.FlatStyle = FlatStyle.Flat;

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



            repositoryItemButtonEdit.ButtonClick += RepositoryItemButtonEdit_ButtonClick;
            repositoryItemButtonEdit3.ButtonClick += RepositoryItemButtonEdit3_ButtonClick;
            repositoryItemButton2.ButtonClick += RepositoryItemButtonEdit2_ButtonClick;

            GCSatinAlmaSiparis.RepositoryItems.Add(repositoryItemButtonEdit);
            GCSatinAlmaSiparis.RepositoryItems.Add(repositoryItemButton2);
            GCSatinAlmaSiparis.RepositoryItems.Add(repositoryItemButtonEdit3);
            gridColumn.ColumnEdit = repositoryItemButtonEdit;
            gridColumn2.ColumnEdit = repositoryItemButton2;
            gridColumn3.ColumnEdit = repositoryItemButtonEdit3;
            gridColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            gridView1.Columns["Seç"].VisibleIndex = 2;
            gridView1.Columns["KasaSec"].VisibleIndex = 6;
            gridView1.Columns["BirimSec"].VisibleIndex = 9;
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["KasaId"].Visible = false;
            //     gridView1.Columns["Birim"].Visible = false;

            //gridView1.Columns.Add(DGVOlcuBr);
            //DGVStokSec.Name = "DGVStoKSec";
            //DGVStokSec.HeaderText = "Seç";
            //DGVStokSec.Text = "Seç";
            //DGVStokSec.UseColumnTextForButtonValue = true;
            //DGVFiyatList.Name = "DGVFiyatList";
            //DGVFiyatList.FlatStyle = FlatStyle.Flat;
            //gridView1.Columns.Add(DGVStokSec);
            //gridView1.Columns.Add(DGVFiyatList);
            //gridView1.Columns["StokId"].Visible = false;
            //gridView1.Columns["MPSTOK"].Visible = false;
            //gridView1.Columns["KasaId"].Visible = false; 
            //gridView1.AllowUserToAddRows = false;
            //gridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //KASA SEÇME İŞLEMLERİ
            //DGVKasaList.Name = "DVGKasaList";
            //DGVKasaList.FlatStyle = FlatStyle.Flat;
            //dataGridView1.Columns.Add(DGVKasaList);

            //DGVKasaSec.FlatStyle = FlatStyle.Flat;
            //DGVKasaSec.Name = "DGVKasaSec";
            //DGVKasaSec.HeaderText = "Seç";
            //DGVKasaSec.Text = "Seç";
            //DGVKasaSec.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(DGVKasaSec);
            //dataGridView1.Columns["DGVKasaSec"].DisplayIndex = 7;

        }

        private void RepositoryItemButtonEdit3_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FStokKasaList fKasaList = new FStokKasaList(this.Tag.ToString(), "SatinAlmaSiparis");
            fKasaList.ShowDialog();
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fStokOlcuBrList = new FStokOlcuBrList(this.Tag.ToString(),"SatinAlmaSiparis");
            _fStokOlcuBrList.stokid = _tempStok.id;
            _fStokOlcuBrList.ShowDialog();
        }

        private DataView clone = null;
        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fStokList = new FStokList(this.Tag.ToString(), "SatinAlmaSiparis");
            _fStokList.ShowDialog();

            _tempPocokalem = new PocoSiparisKalem()
            {
                StokId = _tempStok.id,
                StokKodu = _tempStok.kod,
                StokAdı = _tempStok.adi,
                Birim = "0",// _olcuBr.obje.Where(x => x.ADI == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().ADI,
                KasaAdı = "",
                Kdv = _tempStok.satiskdv,
                Doviz = "TL", //_tempStok.SDOVIZID 
            };



            //TODO 24.10.2022 BAKILACAK

            /* DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();*/ //////////////////////////// BAKILCAK
            _tempSiparisDetay[gridView1.FocusedRowHandle] = _tempPocokalem;
            GCSatinAlmaSiparis.DataSource = _tempSiparisDetay;
            gridView1.RefreshData();

        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _cariKart.Data(ServisList.CariListeServis);

            _siparisServis.Data(ServisList.SiparisEkleServis, new PocoSIPARIS()
            {
                aciklama = TBAciklama.Text,
                kur = Convert.ToDecimal(TBKur.Text),
                belgeno = TBSiparisNo.Text,
                vadetarihi = DTPVadeTarihi.Value,
                guncellemetarihi = DateTime.Now,
                vadegunu = Convert.ToInt32(TBGun.Text),
                cariadi = TBCariAdi.Text,
                cariid = _cariKart.obje.Where(x => x.kod == TBCariKodu.Text).FirstOrDefault().id,
                depoid = _depoServis.obje.Where(x => x.depoadi == CBDepo.EditValue).FirstOrDefault().id,
                dovizid = 0,
                istkontotoplam = _tempSiparisDetay.Sum(x => x.İskontoTutarı),
                kdvtoplam = _tempSiparisDetay.Sum(x => x.KdvTutarı),
                bruttoplam = _tempSiparisDetay.Sum(x => x.BrütToplam),
                nettoplam = _tempSiparisDetay.Sum(x => x.NetToplam),
                geneltoplam = _tempSiparisDetay.Sum(x => x.KdvTutarı) + _tempSiparisDetay.Sum(x => x.NetToplam),
                tip = 1,

            });
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            int i = 0;
            foreach (var item in _tempSiparisDetay.Where(x => x.StokKodu != "").ToList())
            {
                var stokolcubr = _stokOlcuBr.obje.Where(x => x.stokid == item.StokId).FirstOrDefault();

                _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, new PocoSIPARISDETAY()
                {
                    stokid = item.StokId,
                    stokadi = item.StokAdı,
                    aciklama = item.Acıklama,
                    kdv = item.Kdv,
                    kasaid = item.KasaId,
                    nettoplam = item.NetToplam,
                    netfiyat = item.NetFiyat,
                    birimid = _olcuBr.obje.Where(x => x.adi.ToString() == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Birim").ToString()).FirstOrDefault().id,
                    dovizid = 0,
                    miktar = item.Miktar,
                    istkontO1 = item.İskonto1,
                    istkontO2 = item.İskonto2,
                    istkontO3 = item.İskonto3,
                    siparisid = _siparisServis.obje2.id, ///ID gelecek

                    brutfiyat = item.BrütFiyat,
                    bruttoplam = item.BrütFiyat * item.Miktar,
                    bekleyenmiktar = 0,
                    hareketdurumu = 0,
                    listefiyatid = 0,
                    tip = 1,
                    kdvtutari = item.KdvTutarı
                });
                i++;

                _siparisKasaHarServis.Data(ServisList.SiparisKasaHarEkleServis, new PocoSIPARISKASAHAR()
                {
                    KASAID = item.KasaId,
                    SIPARISID = _siparisServis.obje2.id,
                    SIPARISDETAYID = _siparisDetayServis.obje2.id
                });




            }
            temizle();
            //DataGrideSiparisleriGetir();
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

        int i;

        decimal birimfiyat = 0, kdv = 0, bsnc = 0, brutfiyat = 0, netfiyat = 0, nettoplam = 0, brüttoplam = 0, geneltoplam = 0, isktoplam = 0, kdvtoplam = 0, miktar = 0;

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {

                GCSatinAlmaSiparis.DataSource = "";
                _tempSiparisDetay.Add(new PocoSiparisKalem());
                GCSatinAlmaSiparis.DataSource = _tempSiparisDetay;


                //dataGridView1.Columns["DGVOlcuBr"].DisplayIndex = 6;
                //dataGridView1.Columns["DGVFiyatList"].DisplayIndex = dataGridView1.ColumnCount - 1; 
                //dataGridView1.Columns["StokKodu"].DisplayIndex = 0;
                //dataGridView1.Columns["DGVStoKSec"].DisplayIndex = 1; 
                //dataGridView1.Columns["StokAdı"].DisplayIndex = 2; 

                //dataGridView1.Columns["DGVKasaSec"].DisplayIndex = 8;
                //dataGridView1.Columns["DVGKasaList"].DisplayIndex = dataGridView1.ColumnCount-1;


                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr", _tempSiparisDetay[i].Birim.ToString());
                }
                gridView1.FocusedRowHandle = gridView1.RowCount - 1;
                gridView1.FocusedColumn = gridView1.Columns["StokKodu"];
                gridView1.Columns["Seç"].VisibleIndex = 2;
                gridView1.Columns["KasaSec"].VisibleIndex = 5;
                gridView1.Columns["BirimSec"].VisibleIndex = 8;
                gridView1.Columns["StokId"].Visible = false;
                gridView1.Columns["KasaId"].Visible = false;
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
                    miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == gridView1.GetFocusedRowCellValue("StokId").ToString()).FirstOrDefault().Miktar;
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
                    miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == gridView1.GetFocusedRowCellValue("StokId")).FirstOrDefault().Miktar;
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


                TBBrutToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.BrütToplam), 2).ToString();
                TBIskontoToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.İskontoTutarı), 2).ToString();
                TBKdvTutari.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.KdvTutarı), 2).ToString();
                TBGenelToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam + x.KdvTutarı), 2).ToString();
                TBAraToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam), 2).ToString();
                sy = 0;
            }
        }

        private void TBSiparisNo_Properties_Click(object sender, EventArgs e)
        {

        }

        private void TBSiparisNo_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FMusteriSiparisList fMusteriSiparisList = new FMusteriSiparisList(this.Tag.ToString(), "SatinAlmaSiparis");
            fMusteriSiparisList.ShowDialog();
            if (_tempSiparis != null)
            {
                TBSiparisNo.Text = _tempSiparis.belgeno;
                //todo : TBCariKodu.Text = 

                TBCariKodu.Text = _cariKart.obje.Where(x => x.id == _tempSiparis.cariid).FirstOrDefault().kod;
                TBCariAdi.Text = _tempSiparis.cariadi;
                _stokServis.Data(ServisList.StokListeServis);
                //TODO TBKasa.Text = 
                DTSiparisTarih.Value = _tempSiparis.siparistarihi;
                TBAciklama.Text = _tempSiparis.aciklama;
                DTPVadeTarihi.Value = _tempSiparis.vadetarihi;
                DTSevkiyatTarih.Value = _tempSiparis.sevkiyattarihi;
                TBGun.Text = _tempSiparis.vadegunu.ToString();
                _siparisDetayServis.Data(ServisList.SiparisDetayListeServis + 2, null, "query=SIPARISID=" + _tempSiparis.id.ToString());
                GCSatinAlmaSiparis.DataSource = _siparisDetayServis.obje.Select(x => new PocoSiparisKalem()
                {
                    StokId = x.stokid,
                    StokKodu = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().kod,//,  TODOO:BAKILACAAAK
                    StokAdı = _stokServis.obje.Where(z => z.id == x.stokid).FirstOrDefault().adi,
                    Birim = "0",// _olcuBr.obje.Where(x => x.ADI == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().ADI,
                    KasaAdı = "",
                    Kdv = _tempStok.satiskdv,
                    Doviz = "TL", //_tempStok.SDOVIZID 
                });
            }
        }

        private void TBCariKodu_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {

            _fCariList = new FCariList(this.Tag.ToString(), "SatinAlmaSiparis");
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
            //    _tempSiparisDetay[e.RowIndex].Birim = dataGridView1.Rows[e.RowIndex].Cells["DGVOlcuBr"].Value.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (_tempPocokalem != null)
            //{
            //    _tempSiparisDetay[e.RowIndex].Birim = dataGridView1.Rows[e.RowIndex].Cells["DGVOlcuBr"].EditedFormattedValue.ToString();
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
            //if (_tempSiparisDetay != null)
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
