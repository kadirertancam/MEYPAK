using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
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
            _tempDepo = new GenericWebServis<PocoDEPO>();
            fKasaList = new FKasaList("SatinAlmaSiparis");
            _fStokList = new FStokList("SatinAlmaSiparis");
            dataGridView1.MultiSelect = false;
            _tempDepo.Data(ServisList.DepoListeServis);
            CBDepo.DataSource = _tempDepo.obje.Select(x=>x.DEPOADI).ToList();
        }
        #region TANIMLAR
        List<PocoSiparisKalem> _tempSiparisDetay = new List<PocoSiparisKalem>();
        DataGridViewComboBoxColumn DGVOlcuBr = new DataGridViewComboBoxColumn();
        PocoSiparisKalem _tempPocokalem;
        FStokList _fStokList;
        FKasaList fKasaList;
        public PocoSTOK _tempStok;
        public PocoSTOKKASA _tempKasa; 
        DataGridViewButtonColumn DGVStokSec;
        DataGridViewButtonColumn DGVKasaSec;
        int i;
        decimal birimfiyat = 0, kdv = 0, bsnc = 0, brutfiyat = 0, netfiyat = 0, nettoplam = 0, brüttoplam = 0, geneltoplam = 0, isktoplam = 0, kdvtoplam = 0, miktar = 0;

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CHBKdvDahil.Checked == false)
            {
                birimfiyat = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue);
                brutfiyat = birimfiyat;
                miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().Miktar;
                kdv = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Kdv"].EditedFormattedValue);
                isktoplam = (birimfiyat * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto1"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto2"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto3"].EditedFormattedValue)) / 100;
                netfiyat = birimfiyat - isktoplam;
                isktoplam = isktoplam * miktar;
                nettoplam = netfiyat * miktar;
                kdvtoplam = (((nettoplam * kdv) / 100));
                brüttoplam = brutfiyat * miktar;
                geneltoplam = nettoplam + kdvtoplam;
            }
            else
            {
                kdv = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Kdv"].EditedFormattedValue);
                birimfiyat = (Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["BirimFiyat"].EditedFormattedValue));
                netfiyat = birimfiyat / (1 + (kdv / 100));
                miktar = _tempSiparisDetay.Where(x => x.StokId.ToString() == dataGridView1.Rows[e.RowIndex].Cells["StokId"].Value.ToString()).FirstOrDefault().Miktar;
                isktoplam = (netfiyat * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto1"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto2"].EditedFormattedValue)) / 100;
                isktoplam += (isktoplam * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["İskonto3"].EditedFormattedValue)) / 100;
                netfiyat = netfiyat - isktoplam;
                brutfiyat = netfiyat + isktoplam;
                nettoplam = netfiyat * miktar;
                kdvtoplam = ((nettoplam * kdv) / 100);
                brüttoplam = brutfiyat * miktar;
                geneltoplam = nettoplam + kdvtoplam;
                isktoplam = isktoplam * miktar;


            }

            dataGridView1.Rows[e.RowIndex].Cells["BrütFiyat"].Value = decimal.Round(brutfiyat, 2);
            dataGridView1.Rows[e.RowIndex].Cells["NetToplam"].Value = decimal.Round(nettoplam, 2);
            dataGridView1.Rows[e.RowIndex].Cells["BrütToplam"].Value = decimal.Round(brüttoplam, 2);
            dataGridView1.Rows[e.RowIndex].Cells["İskontoTutarı"].Value = decimal.Round(isktoplam, 2);
            dataGridView1.Rows[e.RowIndex].Cells["KdvTutarı"].Value = decimal.Round(kdvtoplam, 2);
            dataGridView1.Rows[e.RowIndex].Cells["NetFiyat"].Value = decimal.Round(netfiyat, 2);


            TBBrutToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.BrütToplam), 2).ToString();
            TBIskontoToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.İskontoTutarı), 2).ToString();
            TBKdvTutari.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.KdvTutarı), 2).ToString();
            TBGenelToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam + x.KdvTutarı), 2).ToString();
            TBAraToplam.Text = decimal.Round(_tempSiparisDetay.Sum(x => x.NetToplam), 2).ToString();
            dataGridView1.Invalidate();
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_tempPocokalem != null)
            {
                _tempSiparisDetay[e.RowIndex].Birim = dataGridView1.Rows[e.RowIndex].Cells["DGVOlcuBr"].EditedFormattedValue.ToString();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Miktar"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["BirimFiyat"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["NetFiyat"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["BrütFiyat"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }

            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskonto1"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskonto2"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskonto3"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Kdv"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["KdvTutarı"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["İskontoTutarı"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["NetToplam"].Index)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["BrütToplam"].Index)
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
            if (dataGridView1.Rows.Count > 1)
                i = 1;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (_tempSiparisDetay != null)
            {
                if (dataGridView1.CurrentCell == dataGridView1.Rows[e.RowIndex].Cells["BrütToplam"] && brutfiyat != 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["BrütToplam"].Value = brüttoplam;
                }
                else if (dataGridView1.CurrentCell == dataGridView1.Rows[e.RowIndex].Cells["NetToplam"] && nettoplam != 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["NetToplam"].Value = nettoplam;
                }
            }
        }

        DataGridViewComboBoxColumn DGVFiyatList;
        DataGridViewComboBoxColumn DGVKasaList;
        DataGridViewCell DGVtempCell;
        #endregion

        void DataGridYapilandir()
        {
            _tempStok = new PocoSTOK();
            _tempSiparisDetay.Add(new PocoSiparisKalem());
            dataGridView1.DataSource = _tempSiparisDetay;
            DGVStokSec.FlatStyle = FlatStyle.Flat;
            DGVOlcuBr.Name = "DGVOlcuBr";
            DGVOlcuBr.HeaderText = "Birim";
            DGVOlcuBr.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns["Birim"].Visible = false;
            DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
            dataGridView1.Columns.Add(DGVOlcuBr);
            DGVStokSec.Name = "DGVStoKSec";
            DGVStokSec.HeaderText = "Seç";
            DGVStokSec.Text = "Seç";
            DGVStokSec.UseColumnTextForButtonValue = true;
            DGVFiyatList.Name = "DGVFiyatList";
            DGVFiyatList.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(DGVStokSec);
            dataGridView1.Columns.Add(DGVFiyatList);
            dataGridView1.Columns["StokId"].Visible = false;
            dataGridView1.Columns["MPSTOK"].Visible = false;
            dataGridView1.Columns["KasaId"].Visible = false;
            dataGridView1.Columns["DGVStoKSec"].DisplayIndex = 2;
            dataGridView1.Columns["DGVOlcuBr"].DisplayIndex = 5;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //KASA SEÇME İŞLEMLERİ
            DGVKasaList.Name = "DVGKasaList";
            DGVKasaList.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(DGVKasaList);

            DGVKasaSec.FlatStyle = FlatStyle.Flat;
            DGVKasaSec.Name = "DGVKasaSec";
            DGVKasaSec.HeaderText = "Seç";
            DGVKasaSec.Text = "Seç";
            DGVKasaSec.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(DGVKasaSec);
            dataGridView1.Columns["DGVKasaSec"].DisplayIndex = 7;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SatınAlmaSiparis_Load(object sender, EventArgs e)
        {
            DataGridYapilandir();
            CBParaBirimi.SelectedIndex = 0;
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {

            StaticContext._stokServis.Listele();
            var _tempp = StaticContext._siparisServis.Ekle(new PocoSIPARIS()
            {
                ACIKLAMA = TBAciklama.Text,
                KUR = Convert.ToDecimal(TBKur.Text),
                BELGENO = TBBelgeNo.Text,
                VADETARIHI = DTPVadeTarihi.Value,
                GUNCELLEMETARIHI = DateTime.Now,
                VADEGUNU = Convert.ToInt32(TBSVadeGunu.Text),
                CARIADI = TBCariAdi.Text,
                CARIID = 0,
                DEPOID = StaticContext._depoServis.Getir(x => x.DEPOADI == CBDepo.SelectedValue).FirstOrDefault().ID,
                DOVIZID = 0,
                ISKONTOTOPLAM = _tempSiparisDetay.Sum(x => x.İskontoTutarı),
                KDVTOPLAM = _tempSiparisDetay.Sum(x => x.KdvTutarı),
                BRUTTOPLAM = _tempSiparisDetay.Sum(x => x.BrütToplam),
                NETTOPLAM = _tempSiparisDetay.Sum(x => x.NetToplam),
                GENELTOPLAM = _tempSiparisDetay.Sum(x => x.KdvTutarı) + _tempSiparisDetay.Sum(x => x.NetToplam),TIP=1

            });

            foreach (var item in _tempSiparisDetay.Where(x => x.StokKodu != "").ToList())
            {

                StaticContext._siparisDetayServis.EkleyadaGuncelle(new PocoSIPARISDETAY()
                {
                    STOKID = item.StokId,
                    STOKADI = item.MPSTOK.ADI,
                    ACIKLAMA = item.Acıklama,
                    KDV = item.Kdv,
                    KASAID = item.KasaId,
                    NETTOPLAM = item.NetToplam,
                    NETFIYAT = item.NetFiyat,
                    BIRIMID = item.MPSTOK.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
                    DOVIZID = 0,
                    MIKTAR = item.Miktar,
                    ISTKONTO1 = item.İskonto1,
                    ISTKONTO2 = item.İskonto2,
                    ISTKONTO3 = item.İskonto3,
                    SIPARISID = _tempp.ID,
                    BRUTFIYAT = item.BrütFiyat,
                    BRUTTOPLAM = item.BrütFiyat * item.Miktar,
                    BEKLEYENMIKTAR = 0,
                    HAREKETDURUMU = 0,
                    LISTEFIYATID = 0,
                    TIP = 1,
                    KDVTUTARI = item.KdvTutarı
                });
            }
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVStoKSec")
            {
                _fStokList.ShowDialog();


                _tempPocokalem = new PocoSiparisKalem()
                {
                    StokId = _tempStok.ID,
                    MPSTOK = _tempStok,
                    StokKodu = _tempStok.KOD,
                    StokAdı = _tempStok.ADI,
                    Birim = _tempStok.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ADI).FirstOrDefault().ToString(),
                    KasaAdı = "",
                    Kdv = _tempStok.SATISKDV,
                    Doviz = "TL", //_tempStok.SDOVIZID 
                };

                DGVOlcuBr.DataSource = _tempStok.MPSTOKOLCUBR.Select(x => x.MPOLCUBR.ADI).ToList();
                DGVtempCell = dataGridView1.Rows[e.RowIndex].Cells["DGVOlcuBr"];
                DGVtempCell.Value = DGVOlcuBr.Items[0].ToString();
                StaticContext._stokFiyatListServis.Listele();
                DGVFiyatList.DataSource = _tempStok.MPSTOKFIYATLISTHAR.Select(x => x.MPSTOKFIYATLIST.FIYATLISTADI).ToList();
                _tempSiparisDetay[e.RowIndex] = _tempPocokalem;
                dataGridView1.DataSource = _tempSiparisDetay;

                dataGridView1.Invalidate();
                dataGridView1.Refresh();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DGVKasaSec")
            {
                if (_tempPocokalem != null)
                { 
                    fKasaList.ShowDialog();

                    if (_tempKasa != null)
                    {
                        TBKasa.Text = _tempKasa.KASAADI;
                        dataGridView1.Rows[e.RowIndex].Cells["KasaAdı"].Value = _tempKasa.KASAADI;
                    }
                    _tempPocokalem.KasaAdı = _tempKasa.KASAADI;
                    _tempPocokalem.KasaId = _tempKasa.ID;

                }
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {

                dataGridView1.DataSource = "";
                _tempSiparisDetay.Add(new PocoSiparisKalem());
                dataGridView1.DataSource = _tempSiparisDetay;

                dataGridView1.Columns["StokId"].Visible = false;
                dataGridView1.Columns["MPSTOK"].Visible = false;
                dataGridView1.Columns["Birim"].Visible = false;
                dataGridView1.Columns["DGVOlcuBr"].DisplayIndex = 6;
                dataGridView1.Columns["DGVFiyatList"].DisplayIndex = dataGridView1.ColumnCount - 1;
                dataGridView1.Columns["DGVStoKSec"].DisplayIndex = 2;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["DGVOlcuBr"].Value = _tempSiparisDetay[i].Birim.ToString();
                }


                dataGridView1.Invalidate();
                dataGridView1.Refresh();

                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["StokKodu"].Selected = true;
                i = 0;

            }
            if (i == 0)
            {
                if (e.KeyChar == (char)Keys.Tab)
                {
                    if (dataGridView1.Rows.Count! > dataGridView1.CurrentCell.RowIndex)
                    {
                        if (dataGridView1.CurrentRow.Index >= 0 && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].DisplayIndex - 1 == dataGridView1.Columns["StokKodu"].DisplayIndex)
                        {
                            dataGridView1.CurrentRow.Cells["Miktar"].Selected = true;
                        }
                        else if (dataGridView1.CurrentRow.Index >= 0 && dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].DisplayIndex - 1 == dataGridView1.Columns["Miktar"].DisplayIndex)
                        {
                            dataGridView1.CurrentRow.Cells["BirimFiyat"].Selected = true;
                        }
                    }

                }
            }
        }
    }
}
