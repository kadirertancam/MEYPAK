using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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
            _fStokList = new FStokList("siparis");
            fKasaList = new FKasaList("Siparis"); 
            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoServis.Data(ServisList.DepoListeServis);
            CBDepo.DataSource = _depoServis.obje.Select(x=>x.DEPOADI).ToList();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _siparisServis.Data(ServisList.SiparisListeServis);
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _siparisDetayServis.Data(ServisList.DepoListeServis);
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _olcuBr.Data(ServisList.OlcuBrListeServis); 

            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
        }
        FKasaList fKasaList; 
        List<PocoSiparisKalem> _tempSiparisDetay = new List<PocoSiparisKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        PocoSiparisKalem _tempPocokalem;
        FStokList _fStokList;
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoSIPARIS _tempSiparis;
        
        private void FSiparis_Load(object sender, EventArgs e)
        {
            DataGridYapilandir();
            CBParaBirimi.SelectedIndex = 0;
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
        FStokOlcuBrList _fStokOlcuBrList; 
        void temizle()
        {
            gridControl1.DataSource = "";
            _tempSiparisDetay.Clear();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            gridControl1.DataSource = _tempSiparisDetay;
            //DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["MPSTOK"].Visible = false;
            gridView1.Columns["Birim"].Visible = false;
            gridView1.Columns["KasaId"].Visible = false;
             
        }
        
        GridColumn gridColumn2;
        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            gridControl1.DataSource = _tempSiparisDetay;
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
             
            gridControl1.RepositoryItems.Add(repositoryItemButtonEdit);
            gridControl1.RepositoryItems.Add(repositoryItemButton2);
            gridControl1.RepositoryItems.Add(repositoryItemButtonEdit3);
            gridColumn.ColumnEdit = repositoryItemButtonEdit;
            gridColumn2.ColumnEdit = repositoryItemButton2;
            gridColumn3.ColumnEdit = repositoryItemButtonEdit3;
            gridColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            gridView1.Columns["Seç"].VisibleIndex = 2;
            gridView1.Columns["KasaSec"].VisibleIndex = 6;
            gridView1.Columns["BirimSec"].VisibleIndex = 9;
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["MPSTOK"].Visible = false;
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
            fKasaList = new FKasaList("musterisiparis");
            fKasaList.ShowDialog();
        }

        private void RepositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fStokOlcuBrList = new FStokOlcuBrList("musterisiparis");
            _fStokOlcuBrList.stokid = _tempStok.id;
            _fStokOlcuBrList.ShowDialog();
        }

        private DataView clone = null;
        private void RepositoryItemButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _fStokList.ShowDialog();
              
            _tempPocokalem = new PocoSiparisKalem()
            {
                StokId = _tempStok.id,
                MPSTOK = _tempStok,
                StokKodu = _tempStok.kod,
                StokAdı = _tempStok.adi,
                Birim ="0",// _olcuBr.obje.Where(x => x.ADI == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().ADI,
                KasaAdı = "",
                Kdv = _tempStok.satiskdv,
                Doviz = "TL", //_tempStok.SDOVIZID 
            };



            //TODO 24.10.2022 BAKILACAK

           /* DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();*/ //////////////////////////// BAKILCAK
            _tempSiparisDetay[e.Button.Index] = _tempPocokalem;
            gridControl1.DataSource = _tempSiparisDetay;
            gridView1.RefreshData();

        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {

             
            _siparisServis.Data(ServisList.SiparisEkleServis,new PocoSIPARIS()
            {
                ACIKLAMA = TBAciklama.Text,
                KUR = Convert.ToDecimal(TBKur.Text),
                BELGENO = TBBelgeNo.Text,
                VADETARIHI = DTPVadeTarihi.Value,
                GUNCELLEMETARIHI = DateTime.Now,
                VADEGUNU = Convert.ToInt32(TBSVadeGunu.Text),
                CARIADI = TBCariAdi.Text,
                CARIID = 0,
                DEPOID = _depoServis.obje.Where(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,
                DOVIZID = 0,
                ISKONTOTOPLAM = _tempSiparisDetay.Sum(x => x.İskontoTutarı),
                KDVTOPLAM = _tempSiparisDetay.Sum(x => x.KdvTutarı),
                BRUTTOPLAM = _tempSiparisDetay.Sum(x => x.BrütToplam),
                NETTOPLAM = _tempSiparisDetay.Sum(x => x.NetToplam),
                GENELTOPLAM = _tempSiparisDetay.Sum(x => x.KdvTutarı) + _tempSiparisDetay.Sum(x => x.NetToplam),TIP=0,

            });
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            int i = 0;
            foreach (var item in _tempSiparisDetay.Where(x => x.StokKodu != "").ToList())
            {
               var stokolcubr =_stokOlcuBr.obje.Where(x => x.STOKID == item.StokId).FirstOrDefault();
                
                _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis,new PocoSIPARISDETAY()
                {
                    STOKID = item.StokId,
                    STOKADI = item.StokAdı,
                    ACIKLAMA = item.Acıklama,
                    KDV = item.Kdv,
                    KASAID = item.KasaId,
                    NETTOPLAM = item.NetToplam,
                    NETFIYAT = item.NetFiyat,
                    BIRIMID = _olcuBr.obje.Where(x=>x.ADI.ToString()== gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"DGVOlcuBr").ToString()).FirstOrDefault().ID ,
                    DOVIZID = 0,
                    MIKTAR = item.Miktar,
                    ISTKONTO1 = item.İskonto1,
                    ISTKONTO2 = item.İskonto2,
                    ISTKONTO3 = item.İskonto3,
                    SIPARISID = _siparisServis.obje2.ID, ///ID gelecek

                    BRUTFIYAT = item.BrütFiyat,
                    BRUTTOPLAM = item.BrütFiyat * item.Miktar,
                    BEKLEYENMIKTAR = 0,
                    HAREKETDURUMU = 0,
                    LISTEFIYATID = 0,
                    TIP = 0,
                    KDVTUTARI = item.KdvTutarı
                });
                i++;
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
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridView1.GetSelectedCells(gridView1.FocusedRowHandle).FirstOrDefault().Name == "DGVStoKSec")
            {
                _fStokList.ShowDialog();

                var tempp = _stokOlcuBr.obje.Where(x => x.STOKID == _tempStok.id);
                _olcuBr.Data(ServisList.OlcuBrListeServis);

                foreach (var item in tempp)
                {
                //    repositoryItemComboBox.Items.Add(_olcuBr.obje.Where(x => x.ID == item.OLCUBRID).FirstOrDefault());
                }
             //   DGVOlcuBr.DataSource = _tempOlcuBr.Select(x => x.ADI).ToList();
                //DGVtempCell = dataGridView1.Rows[e.RowIndex].Cells["DGVOlcuBr"];
                //DGVtempCell.Value = DGVOlcuBr.Items[0].ToString();
                _tempPocokalem = new PocoSiparisKalem()
                {
                    StokId = _tempStok.id,
                    MPSTOK = _tempStok,
                    StokKodu = _tempStok.kod,
                    StokAdı = _tempStok.adi,
                    Birim = _olcuBr.obje.Where(x=>x.ADI== gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DGVOlcuBr").ToString()).FirstOrDefault().ADI,
                    KasaAdı = "",
                    Kdv = _tempStok.satiskdv,
                    Doviz = "TL", //_tempStok.SDOVIZID 
                };
                
              
               
                  //TODO 24.10.2022 BAKILACAK
               
              /*  DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();*/ //////////////////////////// BAKILCAK
                _tempSiparisDetay[e.RowIndex] = _tempPocokalem;
                gridControl1.DataSource = _tempSiparisDetay;


                gridView1.Invalidate(); 
            }
            if (gridView1.GetSelectedCells(gridView1.FocusedRowHandle).FirstOrDefault().Name == "DGVKasaSec")
            {
                if (_tempPocokalem != null)
                {

                  
                    fKasaList.ShowDialog();

                    if (_tempKasa != null)
                    {
                        TBKasa.Text = _tempKasa.KASAADI;
                        gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "KasaAdı", _tempKasa.KASAADI);
                   
                    _tempPocokalem.KasaAdı = _tempKasa.KASAADI;
                    _tempPocokalem.KasaId = _tempKasa.ID;
                    }

                }
            }
        }
        int i;
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

          

        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {

        }
        decimal birimfiyat = 0, kdv = 0, bsnc = 0, brutfiyat = 0, netfiyat = 0, nettoplam = 0, brüttoplam = 0, geneltoplam = 0, isktoplam = 0, kdvtoplam = 0, miktar = 0;

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
               
                    gridControl1.DataSource = "";
                _tempSiparisDetay.Add(new PocoSiparisKalem());
                gridControl1.DataSource = _tempSiparisDetay;

                gridView1.Columns["StokId"].Visible = false;
                gridView1.Columns["MPSTOK"].Visible = false; 
                gridView1.Columns["KasaId"].Visible = false;
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
                gridView1.FocusedRowHandle = gridView1.RowCount-1;
                gridView1.FocusedColumn = gridView1.Columns["StokKodu"];

                gridView1.Columns["Seç"].VisibleIndex = 2; 
                gridView1.Columns["KasaSec"].VisibleIndex = 6;
                gridView1.Columns["BirimSec"].VisibleIndex = 9;
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
                        //if (gridView1.GetFocusedDataSourceRowIndex() >= 0 && gridView1.Columns[gridView1.GetFocusedRowCellValue(0) DisplayIndex - 1 == dataGridView1.Columns["StokKodu"].DisplayIndex)
                        //{
                        //    dataGridView1.CurrentRow.Cells["Miktar"].Selected = true;
                        //}
                        //else if (dataGridView1.CurrentRow.Index >= 0 && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].DisplayIndex - 1 == dataGridView1.Columns["Miktar"].DisplayIndex)
                        //{
                        //    dataGridView1.CurrentRow.Cells["BirimFiyat"].Selected = true;
                        //}
                    }

                }
            }
        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void BTSiparisSec_Click(object sender, EventArgs e)
        {
            FMusteriSiparisList fMusteriSiparisList = new FMusteriSiparisList("Siparis");
            fMusteriSiparisList.ShowDialog();
            if (_tempSiparis != null)
                TBBelgeNo.Text = _tempSiparis.BELGENO;
            //todo : TBCariKodu.Text = 
            TBCariAdi.Text = _tempSiparis.CARIADI;
            //TODO TBKasa.Text = 
            DTPTarih.Value = _tempSiparis.SIPARISTARIHI;
            TBAciklama.Text = _tempSiparis.ACIKLAMA;
            DTPVadeTarihi.Value = _tempSiparis.VADETARIHI;
            DTPSevkiyatTarihi.Value = _tempSiparis.SEVKIYATTARIHI;
            TBSVadeGunu.Text = _tempSiparis.VADEGUNU.ToString();
        }

        private void BTNKasaSec_Click(object sender, EventArgs e)
        {
            FKasaList fKasaList = new FKasaList("Siparis");
            fKasaList.ShowDialog();
            if (_tempKasa != null)
                TBKasa.Text = _tempKasa.KASAADI;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CHBKdvDahil.Checked == false )
            {
                birimfiyat = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("BirimFiyat"));
                brutfiyat = birimfiyat;
                miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == gridView1.GetFocusedRowCellValue("StokId")).FirstOrDefault().Miktar;
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
                birimfiyat = (Convert.ToDecimal(gridView1.GetFocusedRowCellValue("BirimFiyat") ));
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

            gridView1.SetFocusedRowCellValue("BrütFiyat",decimal.Round(brutfiyat, 2));
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
            //if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Miktar"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}

            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["BirimFiyat"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}

            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["NetFiyat"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}

            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["BrütFiyat"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}

            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskonto1"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}
            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskonto2"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}
            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskonto3"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}
            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Kdv"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}
            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["KdvTutarı"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}
            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskontoTutarı"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}
            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["NetToplam"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}
            //else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["BrütToplam"].Index)
            //{
            //    e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            //}


        }



        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar != '.' && e.KeyChar != ',')
            //{
            //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //}
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

