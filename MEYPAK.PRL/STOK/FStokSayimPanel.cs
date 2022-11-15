using MEYPAK.BLL.DEPO;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
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
using DevExpress.XtraEditors;
using System.Windows.Media.Animation;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayimPanel : Form
    {
        public FStokSayimPanel(string form = "", string islemtipi = "")
        {
            InitializeComponent();
            this._islemtipi = islemtipi;
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
            BTStokKoduSec.Text = _tempStok.kod;
            TBAdi.Text = _tempStok.adi;
            CBDepo.Properties.DataSource = stokOlcuBrServis.obje.Where(x => x.stokid == _tempStok.id).Select(x => olcuBrServis.obje.Where(z => z.id == x.olcubrid).FirstOrDefault().adi).ToList();
            TBBakiye.Text = (from ep in stokServis.obje join e in stokHarServis.obje on ep.id equals e.stokid where ep.kod == _tempStok.kod select Convert.ToDecimal(e.io.ToString() == "1" ? e.miktar : 0) - Convert.ToDecimal(e.io.ToString() == "0" ? e.miktar : 0)).FirstOrDefault().ToString();

            _tempStok = null;
        }

        private void FStokSayimPanel_Load(object sender, EventArgs e)
        {

            fStokList = new FStokList(this.Tag.ToString(), "stoksayimpanel");
            depoServis.Data(ServisList.DepoListeServis);
            stokServis.Data(ServisList.StokListeServis);
            olcuBrServis.Data(ServisList.OlcuBrListeServis);
            stokOlcuBrServis.Data(ServisList.StokOlcuBrListeServis);

            if (_islemtipi == "düzenle")
            {
                DGStokSayim.DataSource = _tempStokSayimHarList;
                CBDepo.Properties.DataSource = depoServis.obje.Select(x => x.depoadi).ToList();

            }
            else if (_islemtipi == "kaydet")
            { 
                _tempStokSayimHarList = new List<PocoStokSayimPanelList>();
                CBDepo.Properties.DataSource = depoServis.obje.Select(x => x.depoadi).ToList();
                foreach (var item in stokServis.obje.Where(x=>x.kayittipi==0))
                {
                    _tempStokSayimHarList.Add(new PocoStokSayimPanelList()
                    {
                        StokAdı = item.adi,
                        Birim = olcuBrServis.obje.Where(x=>x.id== (stokOlcuBrServis.obje.Where(z=>z.num==1 && z.stokid==item.id).Select(z=>z.olcubrid).FirstOrDefault())).FirstOrDefault().adi, //TODO: İlgili stoğun ölçü birimi gelecek fakat bütün stoklarda ölçü birim tanımlı değil. isterseniz veritabanını yapılandırabilirsiiz.
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
                DGStokSayim.DataSource = _tempStokSayimHarList;
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
            //if (gridView1.IsCurrentCellDirty)
            //{
            //    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _tempStokSayimHarList = new List<PocoStokSayimPanelList>();
            DGStokSayim.DataSource = _tempStokSayimHarList;
            DGStokSayim.Refresh();
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
                StokKodu = BTStokKoduSec.Text,
                StokAdı = TBAdi.Text,
                ID = stokServis.obje.Where(x => x.kod == BTStokKoduSec.Text).FirstOrDefault().id,
                
            });
        }

       

        private void BTNSil_Click(object sender, EventArgs e)
        {
            //if (DGStokSayim.Rows.SelectedRowsCount > 0)
            //{
            //    gridView1.DeleteSelectedRows();
            //    _tempStokSayimHarList= (List<PocoStokSayimPanelList>)gridControl1.DataSource; 
            //}
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

        private void BTStokSayimKaydet_Click(object sender, EventArgs e)
        {
            stokServis.Data(ServisList.StokListeServis);
            olcuBrServis.Data(ServisList.OlcuBrListeServis);
            for (int i = 0; i < gridView1.RowCount; i++)
            {

                stokSayimHarServis.Data(ServisList.StokSayimHarEkleServis, (new PocoSTOKSAYIMHAR()
                {
                    stokid = stokServis.obje.Where(x => x.kod == gridView1.GetRowCellValue(i,"StokKodu").ToString()).FirstOrDefault().id,
                    miktar = Decimal.Parse(gridView1.GetRowCellValue(i,"Miktar").ToString()),
                    fiyat= Decimal.Parse(gridView1.GetRowCellValue(i,"Fiyat").ToString()),
                    birimid = olcuBrServis.obje.Where(x=>x.adi==gridView1.GetRowCellValue(i,"birim")).FirstOrDefault().id,
                    kur = 1,
                    parabr = 1,
                    depoid = depoServis.obje.Where(x => x.depoadi == CBDepo.EditValue).FirstOrDefault().id,
                    stoksayimid = sayimId

                }));

            }
        }
    }
}
