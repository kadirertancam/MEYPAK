using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.PRL.Assets.Scripts;
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

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FSatınAlmaSiparis : Form
    {
        GenericWebServis<PocoDEPO> _tempDepo;
        public FSatınAlmaSiparis()
        {
            InitializeComponent();
            DGVStokSec = new DataGridViewButtonColumn();
            DGVFiyatList = new DataGridViewComboBoxColumn();
            DGVKasaSec = new DataGridViewButtonColumn();
            DGVKasaList = new DataGridViewComboBoxColumn();
            _fStokList = new FStokList(this.Tag.ToString(),"SatinAlmaSiparis");
            fKasaList = new FKasaList(this.Tag.ToString(),"SatinAlmaSiparis");
            DGSatinAlmaSiparis.MultiSelect = false;
            _depoServis = new GenericWebServis<PocoDEPO>();
            _depoServis.Data(ServisList.DepoListeServis);
            CBDepo.Properties.DataSource = _depoServis.obje.Select(x => x.DEPOADI).ToList();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _siparisServis.Data(ServisList.SiparisListeServis);
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _siparisDetayServis.Data(ServisList.DepoListeServis);
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _olcuBr.Data(ServisList.OlcuBrListeServis);
        }
        #region TANIMLAR
        FKasaList fKasaList;
        List<PocoSiparisKalem> _tempSiparisDetay = new List<PocoSiparisKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        PocoSiparisKalem _tempPocokalem;
        FStokList _fStokList;
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa;
        public PocoSIPARIS _tempSiparis;
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        List<PocoOLCUBR> _tempOlcuBr = new List<PocoOLCUBR>();
        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;
        GenericWebServis<PocoOLCUBR> _olcuBr;
        DataGridViewCell DGVtempCell;
        int i;
        decimal birimfiyat = 0, kdv = 0, bsnc = 0, brutfiyat = 0, netfiyat = 0, nettoplam = 0, brüttoplam = 0, geneltoplam = 0, isktoplam = 0, kdvtoplam = 0, miktar = 0;
        void temizle()
        {
            DGSatinAlmaSiparis.DataSource = "";
            _tempSiparisDetay.Clear();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            DGSatinAlmaSiparis.DataSource = _tempSiparisDetay;
            //DGVOlcuBr.DataSource = _tempStok.mpstokolcubr.Select(x => x.mpo.ADI).ToList();
            DGSatinAlmaSiparis.Columns["StokId"].Visible = false;
            DGSatinAlmaSiparis.Columns["MPSTOK"].Visible = false;
            DGSatinAlmaSiparis.Columns["Birim"].Visible = false;
            DGSatinAlmaSiparis.Columns["KasaId"].Visible = false;
            DGSatinAlmaSiparis.Columns["DGVOlcuBr"].DisplayIndex = 6;
            DGSatinAlmaSiparis.Columns["DGVFiyatList"].DisplayIndex = DGSatinAlmaSiparis.ColumnCount - 1;
            DGSatinAlmaSiparis.Columns["StokKodu"].DisplayIndex = 0;
            DGSatinAlmaSiparis.Columns["DGVStoKSec"].DisplayIndex = 1;
            DGSatinAlmaSiparis.Columns["StokAdı"].DisplayIndex = 2;

            DGSatinAlmaSiparis.Columns["DGVKasaSec"].DisplayIndex = 8;
            DGSatinAlmaSiparis.Columns["DVGKasaList"].DisplayIndex = 6;
        }
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CHBKdvDahil.Checked == false)
            {
                birimfiyat = Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue);
                brutfiyat = birimfiyat;
                miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().Miktar;
                kdv = Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["Kdv"].EditedFormattedValue);
                isktoplam = (birimfiyat * Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["İskonto1"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["İskonto2"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["İskonto3"].EditedFormattedValue)) / 100;
                netfiyat = birimfiyat - isktoplam;
                isktoplam = isktoplam * miktar;
                nettoplam = netfiyat * miktar;
                kdvtoplam = (((nettoplam * kdv) / 100));
                brüttoplam = brutfiyat * miktar;
                geneltoplam = nettoplam + kdvtoplam;
            }
            else
            {
                kdv = Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["Kdv"].EditedFormattedValue);
                birimfiyat = (Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue));
                netfiyat = birimfiyat / (1 + (kdv / 100));
                miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().Miktar;
                isktoplam = (netfiyat * Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["İskonto1"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["İskonto2"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["İskonto3"].EditedFormattedValue)) / 100;
                netfiyat = netfiyat - isktoplam;
                brutfiyat = netfiyat + isktoplam;
                nettoplam = netfiyat * miktar;
                kdvtoplam = ((nettoplam * kdv) / 100);
                brüttoplam = brutfiyat * miktar;
                geneltoplam = nettoplam + kdvtoplam;
                isktoplam = isktoplam * miktar;

            }

            DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["BrütFiyat"].Value = decimal.Round(brutfiyat, 2);
            DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["NetToplam"].Value = decimal.Round(nettoplam, 2);
            DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["BrütToplam"].Value = decimal.Round(brüttoplam, 2);
            DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["İskontoTutarı"].Value = decimal.Round(isktoplam, 2);
            DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["KdvTutarı"].Value = decimal.Round(kdvtoplam, 2);
            DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["NetFiyat"].Value = decimal.Round(netfiyat, 2);


            TBBrutToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.BrütToplam), 2).ToString();
            TBIskontoToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.İskontoTutarı), 2).ToString();
            TBKdvTutari.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.KdvTutarı), 2).ToString();
            TBGenelToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam + x.KdvTutarı), 2).ToString();
            TBAraToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam), 2).ToString();
            DGSatinAlmaSiparis.Invalidate();
            DGSatinAlmaSiparis.Refresh();


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_tempPocokalem != null)
            {
                _tempSiparisDetay[e.RowIndex].Birim = DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["DGVOlcuBr"].EditedFormattedValue.ToString();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["Miktar"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["BirimFiyat"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["NetFiyat"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["BrütFiyat"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["İskonto1"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["İskonto2"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["İskonto3"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["Kdv"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["KdvTutarı"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["İskontoTutarı"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["NetToplam"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (DGSatinAlmaSiparis.CurrentCell.ColumnIndex == DGSatinAlmaSiparis.Columns["BrütToplam"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

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
            if (DGSatinAlmaSiparis.Rows.Count > 1)
                i = 1;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_tempSiparisDetay != null)
            {
                if (DGSatinAlmaSiparis.CurrentCell == DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["BrütToplam"] && brutfiyat != 0)
                {
                    DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["BrütToplam"].Value = brüttoplam;
                }
                else if (DGSatinAlmaSiparis.CurrentCell == DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["NetToplam"] && nettoplam != 0)
                {
                    DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["NetToplam"].Value = nettoplam;
                }
            }
        }

        private void BTSiparisSec_Click(object sender, EventArgs e)
        {
            FMusteriSiparisList fMusteriSiparisList = new FMusteriSiparisList("Siparis");
            fMusteriSiparisList.ShowDialog();
            if (_tempSiparis != null)
                TBSiparisNo.Text = _tempSiparis.BELGENO;
            //todo : TBCariKodu.Text = 
            TBCariAdi.Text = _tempSiparis.CARIADI;
            //TODO TBKasa.Text = 
            DTSiparisTarih.Value = _tempSiparis.SIPARISTARIHI;
            TBAciklama.Text = _tempSiparis.ACIKLAMA;
            DTPVadeTarihi.Value = _tempSiparis.VADETARIHI;
            DTSevkiyatTarih.Value = _tempSiparis.SEVKIYATTARIHI;
            TBGun.Text = _tempSiparis.VADEGUNU.ToString();
        }

        private void BTNKasaSec_Click(object sender, EventArgs e)
        {
            FKasaList fKasaList = new FKasaList(this.Tag.ToString(),"Siparis");
            fKasaList.ShowDialog();
            if (_tempKasa != null)
                TBKasa.Text = _tempKasa.KASAADI;
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["DGVOlcuBr"].Value != null)
                _tempSiparisDetay[e.RowIndex].Birim = DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["DGVOlcuBr"].Value.ToString();
        }
 
        #endregion

        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            DGSatinAlmaSiparis.DataSource = _tempSiparisDetay;
            DGVStokSec.FlatStyle = FlatStyle.Flat;
            DGVOlcuBr.Name = "DGVOlcuBr";
            DGVOlcuBr.HeaderText = "Birim";
            DGVOlcuBr.FlatStyle = FlatStyle.Flat;
            DGSatinAlmaSiparis.Columns["Birim"].Visible = false;

            DGSatinAlmaSiparis.Columns.Add(DGVOlcuBr);
            DGVStokSec.Name = "DGVStoKSec";
            DGVStokSec.HeaderText = "Seç";
            DGVStokSec.Text = "Seç";
            DGVStokSec.UseColumnTextForButtonValue = true;
            DGVFiyatList.Name = "DGVFiyatList";
            DGVFiyatList.FlatStyle = FlatStyle.Flat;
            DGSatinAlmaSiparis.Columns.Add(DGVStokSec);
            DGSatinAlmaSiparis.Columns.Add(DGVFiyatList);
            DGSatinAlmaSiparis.Columns["StokId"].Visible = false;
            DGSatinAlmaSiparis.Columns["MPSTOK"].Visible = false;
            DGSatinAlmaSiparis.Columns["KasaId"].Visible = false;
            DGSatinAlmaSiparis.Columns["DGVStoKSec"].DisplayIndex = 2;
            DGSatinAlmaSiparis.Columns["DGVOlcuBr"].DisplayIndex = 5;
            DGSatinAlmaSiparis.AllowUserToAddRows = false;
            DGSatinAlmaSiparis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //KASA SEÇME İŞLEMLERİ
            DGVKasaList.Name = "DVGKasaList";
            DGVKasaList.FlatStyle = FlatStyle.Flat;
            DGSatinAlmaSiparis.Columns.Add(DGVKasaList);

            DGVKasaSec.FlatStyle = FlatStyle.Flat;
            DGVKasaSec.Name = "DGVKasaSec";
            DGVKasaSec.HeaderText = "Seç";
            DGVKasaSec.Text = "Seç";
            DGVKasaSec.UseColumnTextForButtonValue = true;
            DGSatinAlmaSiparis.Columns.Add(DGVKasaSec);
            DGSatinAlmaSiparis.Columns["DGVKasaSec"].DisplayIndex = 7;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SatınAlmaSiparis_Load(object sender, EventArgs e)
        {
            DataGridYapilandir();
            CBParaBirimi.EditValue = 0;
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {

            _siparisServis.Data(ServisList.SiparisEkleServis, new PocoSIPARIS()
            {
                ACIKLAMA = TBAciklama.Text,
                KUR = Convert.ToDecimal(TBKur.Text),
                BELGENO = BTBelgeNoSec.Text,
                VADETARIHI = DTPVadeTarihi.Value,
                guncellemetarihi = DateTime.Now,
                VADEGUNU = Convert.ToInt32(TBGun.Text),
                CARIADI = TBCariAdi.Text,
                CARIID = 0,
                DEPOID = _depoServis.obje.Where(x => x.DEPOADI == CBDepo.EditValue).FirstOrDefault().id,
                DOVIZID = 0,
                ISKONTOTOPLAM = _tempSiparisDetay.Sum(x => x.İskontoTutarı),
                KDVTOPLAM = _tempSiparisDetay.Sum(x => x.KdvTutarı),
                BRUTTOPLAM = _tempSiparisDetay.Sum(x => x.BrütToplam),
                NETTOPLAM = _tempSiparisDetay.Sum(x => x.NetToplam),
                GENELTOPLAM = _tempSiparisDetay.Sum(x => x.KdvTutarı) + _tempSiparisDetay.Sum(x => x.NetToplam),TIP=1,

            });
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            int i = 0;
            foreach (var item in _tempSiparisDetay.Where(x => x.StokKodu != "").ToList())
            {
                var stokolcubr = _stokOlcuBr.obje.Where(x => x.STOKID == item.StokId).FirstOrDefault();

                _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, new PocoSIPARISDETAY()
                {
                    STOKID = item.StokId,
                    STOKADI = item.StokAdı,
                    ACIKLAMA = item.Acıklama,
                    KDV = item.Kdv,
                    KASAID = item.KasaId,
                    NETTOPLAM = item.NetToplam,
                    NETFIYAT = item.NetFiyat,
                    BIRIMID = _olcuBr.obje.Where(x => x.adi.ToString() == DGSatinAlmaSiparis.Rows[i].Cells["DGVOlcuBr"].Value.ToString()).FirstOrDefault().id,
                    DOVIZID = 0,
                    MIKTAR = item.Miktar,
                    ISTKONTO1 = item.İskonto1,
                    ISTKONTO2 = item.İskonto2,
                    ISTKONTO3 = item.İskonto3,
                    SIPARISID = _siparisServis.obje2.id, ///ID gelecek

                    BRUTFIYAT = item.BrütFiyat,
                    BRUTTOPLAM = item.BrütFiyat * item.Miktar,
                    BEKLEYENMIKTAR = 0,
                    HAREKETDURUMU = 0,
                    LISTEFIYATID = 0,
                    TIP = 1,
                    KDVTUTARI = item.KdvTutarı
                });
                i++;
            }
            temizle();
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
            if (DGSatinAlmaSiparis.Columns[e.ColumnIndex].Name == "DGVStoKSec")
            {
                _fStokList.ShowDialog();

                var tempp = _stokOlcuBr.obje.Where(x => x.STOKID == _tempStok.id);
                _olcuBr.Data(ServisList.OlcuBrListeServis);

                foreach (var item in tempp)
                {
                    _tempOlcuBr.Add(_olcuBr.obje.Where(x => x.id == item.OLCUBRID).FirstOrDefault());
                }
                DGVOlcuBr.DataSource = _tempOlcuBr.Select(x => x.adi).ToList();
                DGVtempCell = DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["DGVOlcuBr"];
                DGVtempCell.Value = DGVOlcuBr.Items[0].ToString();
                _tempPocokalem = new PocoSiparisKalem()
                {
                    StokId = _tempStok.id,
                    MPSTOK = _tempStok,
                    StokKodu = _tempStok.kod,
                    StokAdı = _tempStok.adi,
                    Birim = _olcuBr.obje.Where(x => x.adi == DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["DGVOlcuBr"].Value.ToString()).FirstOrDefault().adi,
                    KasaAdı = "",
                    Kdv = _tempStok.satiskdv,
                    Doviz = "TL", //_tempStok.SDOVIZID 
                };



                //TODO 24.10.2022 BAKILACAK

               /* DGVFiyatList.DataSource = _tempStok.mpstokfiyatlisthar.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();*/ //////////////////////////// BAKILCAK
                _tempSiparisDetay[e.RowIndex] = _tempPocokalem;
                DGSatinAlmaSiparis.DataSource = _tempSiparisDetay;


                DGSatinAlmaSiparis.Invalidate();
                DGSatinAlmaSiparis.Refresh();
            }
            if (DGSatinAlmaSiparis.Columns[e.ColumnIndex].Name == "DGVKasaSec")
            {
                if (_tempPocokalem != null)
                {


                    fKasaList.ShowDialog();

                    if (_tempKasa != null)
                    {
                        TBKasa.Text = _tempKasa.KASAADI;
                        DGSatinAlmaSiparis.Rows[e.RowIndex].Cells["KasaAdı"].Value = _tempKasa.KASAADI;

                        _tempPocokalem.KasaAdı = _tempKasa.KASAADI;
                        _tempPocokalem.KasaId = _tempKasa.id;
                    }

                }
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {

                DGSatinAlmaSiparis.DataSource = "";
                _tempSiparisDetay.Add(new PocoSiparisKalem());
                DGSatinAlmaSiparis.DataSource = _tempSiparisDetay;

                DGSatinAlmaSiparis.Columns["StokId"].Visible = false;
                DGSatinAlmaSiparis.Columns["MPSTOK"].Visible = false;
                DGSatinAlmaSiparis.Columns["Birim"].Visible = false;
                DGSatinAlmaSiparis.Columns["KasaId"].Visible = false;
                DGSatinAlmaSiparis.Columns["DGVOlcuBr"].DisplayIndex = 6;
                DGSatinAlmaSiparis.Columns["DGVFiyatList"].DisplayIndex = DGSatinAlmaSiparis.ColumnCount - 1;
                DGSatinAlmaSiparis.Columns["StokKodu"].DisplayIndex = 0;
                DGSatinAlmaSiparis.Columns["DGVStoKSec"].DisplayIndex = 1;
                DGSatinAlmaSiparis.Columns["StokAdı"].DisplayIndex = 2;

                DGSatinAlmaSiparis.Columns["DGVKasaSec"].DisplayIndex = 8;
                DGSatinAlmaSiparis.Columns["DVGKasaList"].DisplayIndex = DGSatinAlmaSiparis.ColumnCount - 1;


                for (int i = 0; i < DGSatinAlmaSiparis.Rows.Count; i++)
                {
                    DGSatinAlmaSiparis.Rows[i].Cells["DGVOlcuBr"].Value = _tempSiparisDetay[i].Birim.ToString();
                }


                //dataGridView1.Invalidate();
                DGSatinAlmaSiparis.Refresh();

                DGSatinAlmaSiparis.Rows[DGSatinAlmaSiparis.Rows.Count - 1].Cells["StokKodu"].Selected = true;
                i = 0;

            }
            if (i == 0)
            {
                if (e.KeyChar == (char)Keys.Tab)
                {
                    if (DGSatinAlmaSiparis.Rows.Count! > DGSatinAlmaSiparis.CurrentCell.RowIndex)
                    {
                        if (DGSatinAlmaSiparis.CurrentRow.Index >= 0 && DGSatinAlmaSiparis.Columns[DGSatinAlmaSiparis.CurrentCell.ColumnIndex].DisplayIndex - 1 == DGSatinAlmaSiparis.Columns["StokKodu"].DisplayIndex)
                        {
                            DGSatinAlmaSiparis.CurrentRow.Cells["Miktar"].Selected = true;
                        }
                        else if (DGSatinAlmaSiparis.CurrentRow.Index >= 0 && DGSatinAlmaSiparis.Columns[DGSatinAlmaSiparis.CurrentCell.ColumnIndex].DisplayIndex - 1 == DGSatinAlmaSiparis.Columns["Miktar"].DisplayIndex)
                        {
                            DGSatinAlmaSiparis.CurrentRow.Cells["BirimFiyat"].Selected = true;
                        }
                    }

                }
            }

        }
    }
}
