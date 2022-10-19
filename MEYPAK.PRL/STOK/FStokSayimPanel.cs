using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayimPanel : Form
    {
        public FStokSayimPanel(string islemtipi = "")
        {
            InitializeComponent();
            this._islemtipi = islemtipi;
            fStokList = new FStokList("stoksayimpanel");
        }
        string _islemtipi;
        public List<PocoStokSayimPanelList> _tempStokSayimHarList;
        IStokSayimHarServis stokSayimHarServis ;
        IStokServis stokServis ;
        IDepoServis depoServis ;
        IStokOlcuBrServis stokOlcuBrServis ;
        IOlcuBrServis olcuBrServis ;
        IStokHarServis stokHarServis ;
        public int sayimId;
        public PocoSTOK _tempStok;
        FStokList fStokList;

        void Doldur()
        {
            TBStokKodu.Text = _tempStok.KOD;
            TBStokAdi.Text = _tempStok.ADI;
            CBStokBirim.DataSource = stokOlcuBrServis.Listele().Where(x => x.STOKID == _tempStok.ID).Select(x => olcuBrServis.Getir(z => z.ID == x.OLCUBRID).FirstOrDefault().ADI).ToList();
            TBBakiye.Text = (from ep in stokServis.Listele() join e in stokHarServis.Listele() on ep.ID equals e.STOKID where ep.KOD == _tempStok.KOD select Convert.ToDecimal(e.IO.ToString() == "1" ? e.MIKTAR : 0) - Convert.ToDecimal(e.IO.ToString() == "0" ? e.MIKTAR : 0)).FirstOrDefault().ToString();

            _tempStok = null;
        }

        private void FStokSayimPanel_Load(object sender, EventArgs e)
        {
            if (_islemtipi == "düzenle")
            {
            }
            else if (_islemtipi == "kaydet")
            {
                olcuBrServis.Listele();
                stokOlcuBrServis.Listele();
                _tempStokSayimHarList = new List<PocoStokSayimPanelList>();
                CBDepo.DataSource = depoServis.Listele().Select(x => x.DEPOADI).ToList();
                foreach (var item in stokServis.Listele())
                {
                    _tempStokSayimHarList.Add(new PocoStokSayimPanelList()
                    {
                        StokAdı = item.ADI,
                        Birim = item.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ADI).FirstOrDefault(),
                        Fiyat = 1,
                        Miktar = 0,
                        StokKodu = item.KOD
                    });
                }

                //DataGridViewButtonColumn dgvBtColumn = new DataGridViewButtonColumn();
                //dgvBtColumn.Name = "DGVBTStokSec";
                //dgvBtColumn.Text = "Seç";
                //dgvBtColumn.HeaderText = "Seç"; 
                //dgvBtColumn.FlatStyle = FlatStyle.Flat;
                //dgvBtColumn.DisplayIndex = 1; 
                dataGridView1.DataSource = _tempStokSayimHarList;
                //dataGridView1.Columns.Add(dgvBtColumn);
                //dataGridView1.CellClick += DataGridView1_CellClick;
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value = "Seç";

                //}
                //dataGridView1.AllowUserToAddRows = false;
                //DataTable dataTable = (DataTable)dataGridView1.DataSource;
                //DataRow drToAdd = dataTable.NewRow();
                //dataGridView1.Rows.Add(drToAdd);
                //dataTable.AcceptChanges(); 

            }
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {

            //DataGridView dgv = sender as DataGridView;
            //if(dgv!=null)
            //    if (dgv.Columns["DGVBTStokSec"].Index == e.ColumnIndex)
            //    {
            //        fStokList.ShowDialog();
            //    }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _tempStokSayimHarList = new List<PocoStokSayimPanelList>();
            dataGridView1.DataSource = _tempStokSayimHarList;
            dataGridView1.Refresh();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fStokList.ShowDialog();
            Doldur();
        }

        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _tempStokSayimHarList.Add(new PocoStokSayimPanelList()
            {
                StokKodu = TBStokKodu.Text,
                StokAdı = TBStokAdi.Text,
                ID = stokServis.Getir(x => x.KOD == TBStokKodu.Text).FirstOrDefault().ID
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                stokSayimHarServis.EkleyadaGuncelle(new PocoSTOKSAYIMHAR()
                {
                    STOKID = stokServis.Getir(x => x.KOD == dataGridView1.Rows[i].Cells["StokKodu"].Value.ToString()).FirstOrDefault().ID,
                    MIKTAR = Decimal.Parse(dataGridView1.Rows[i].Cells["Miktar"].EditedFormattedValue.ToString()),
                    FIYAT = Decimal.Parse(dataGridView1.Rows[i].Cells["Fiyat"].EditedFormattedValue.ToString()),
                    KUR = 1,
                    PARABR = 1,
                    DEPOID = CBDepo.SelectedIndex,
                    STOKSAYIMID = sayimId

                });

            }
        }

        private void BTNSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _tempStokSayimHarList.Remove(_tempStokSayimHarList[dataGridView1.SelectedRows[0].Index]);
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = _tempStokSayimHarList;
            }
        }
        #region KeyPress
        private void TBMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar!='.' && e.KeyChar!=',')
            {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            
        }

        private void TBFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        #endregion

    }
}
