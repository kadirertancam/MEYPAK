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
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayimPanel : Form
    {
        public FStokSayimPanel(string islemtipi = "")
        {
            InitializeComponent();
            this._islemtipi = islemtipi;
            fStokList = new FStokList("stoksayimpanel");
            stokSayimHarServis = new GenericWebServis<PocoSTOKSAYIMHAR>();
            stokSayimHarServis.Data(ServisList.StokSayimHarListeServis);
            stokServis = new GenericWebServis<PocoSTOK>();
            depoServis = new GenericWebServis<PocoDEPO>();
            stokOlcuBrServis = new GenericWebServis<PocoSTOKOLCUBR>();
            olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            stokHarServis = new GenericWebServis<PocoSTOKHAR>();
        }
        string _islemtipi;
        public List<PocoStokSayimPanelList> _tempStokSayimHarList;
        GenericWebServis<PocoSTOKSAYIMHAR> stokSayimHarServis ;
        GenericWebServis<PocoSTOK> stokServis ;
        GenericWebServis<PocoDEPO> depoServis ;
        GenericWebServis<PocoSTOKOLCUBR> stokOlcuBrServis ;
        GenericWebServis<PocoOLCUBR> olcuBrServis ;
        GenericWebServis<PocoSTOKHAR> stokHarServis ;
        public int sayimId;
        public PocoSTOK _tempStok;
        FStokList fStokList;

        void Doldur()
        {
            stokHarServis.Data(ServisList.StokHarListeServis);
            olcuBrServis.Data(ServisList.OlcuBrListeServis);
            stokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);
            stokServis.Data(ServisList.StokListeServis);
            TBStokBilgiStokKodu.Text = _tempStok.kod;
            TBStokBilgiStokAdi.Text = _tempStok.adi;
            CBStokBilgiBirim.Properties.DataSource = stokOlcuBrServis.obje.Where(x => x.STOKID == _tempStok.id).Select(x => olcuBrServis.obje.Where(z => z.id == x.OLCUBRID).FirstOrDefault().adi).ToList();
            TBStokBilgiBakiye.Text = (from ep in stokServis.obje join e in stokHarServis.obje on ep.id equals e.stokid where ep.kod == _tempStok.kod select Convert.ToDecimal(e.io.ToString() == "1" ? e.miktar : 0) - Convert.ToDecimal(e.io.ToString() == "0" ? e.miktar : 0)).FirstOrDefault().ToString();

            _tempStok = null;
        }

        private void FStokSayimPanel_Load(object sender, EventArgs e)
        {
            depoServis.Data(ServisList.DepoListeServis);
            stokServis.Data(ServisList.StokListeServis);
            if (_islemtipi == "düzenle")
            {
                dataGridView1.DataSource = _tempStokSayimHarList; 
                CBDepo.Properties.DataSource = depoServis.obje.Select(x => x.DEPOADI).ToList();

            }
            else if (_islemtipi == "kaydet")
            { 
                _tempStokSayimHarList = new List<PocoStokSayimPanelList>();
                CBDepo.Properties.DataSource = depoServis.obje.Select(x => x.DEPOADI).ToList();
                foreach (var item in stokServis.obje)
                {
                    _tempStokSayimHarList.Add(new PocoStokSayimPanelList()
                    {
                        StokAdı = item.adi,
                        //Birim = item.MPSTOKOLCUBR.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ADI).FirstOrDefault(),
                        Fiyat = 1,
                        Miktar = 0,
                        StokKodu = item.kod
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
            stokServis.Data(ServisList.StokListeServis);
            _tempStokSayimHarList.Add(new PocoStokSayimPanelList()
            {
                StokKodu = TBStokBilgiStokKodu.Text,
                StokAdı = TBStokBilgiStokAdi.Text,
                ID = stokServis.obje.Where(x => x.kod == TBStokBilgiStokKodu.Text).FirstOrDefault().id
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stokServis.Data(ServisList.StokListeServis);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                stokSayimHarServis.Data(ServisList.StokSayimHarEkleServis,(new PocoSTOKSAYIMHAR()
                {
                    STOKID = stokServis.obje.Where(x => x.kod == dataGridView1.Rows[i].Cells["StokKodu"].Value.ToString()).FirstOrDefault().id,
                    MIKTAR = Decimal.Parse(dataGridView1.Rows[i].Cells["Miktar"].EditedFormattedValue.ToString()),
                    FIYAT = Decimal.Parse(dataGridView1.Rows[i].Cells["Fiyat"].EditedFormattedValue.ToString()),
                    KUR = 1,
                    PARABR = 1,
                    DEPOID = depoServis.obje.Where(x=>x.DEPOADI== CBDepo.SelectedText).FirstOrDefault().id,
                    STOKSAYIMID = sayimId

                }));

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
