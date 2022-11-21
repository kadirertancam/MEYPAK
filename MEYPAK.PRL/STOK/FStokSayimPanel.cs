using MEYPAK.Entity.PocoModels;
using System.Data;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokSayimPanel : Form
    {
        public FStokSayimPanel(PocoSTOKSAYIM tempstoksayim,string form = "", string islemtipi = "")
        {
            InitializeComponent();
            this._islemtipi = islemtipi;
            this._form = form;
            _tempStokSayim = tempstoksayim;
            stokSayimHarServis = new GenericWebServis<PocoSTOKSAYIMHAR>();
            stokServis = new GenericWebServis<PocoSTOK>();
            depoServis = new GenericWebServis<PocoDEPO>();
            stokHarServis = new GenericWebServis<PocoSTOKHAR>();
            stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
        }
        string _islemtipi;
        string _form;
        PocoSTOKSAYIM _tempStokSayim;
        GenericWebServis<PocoSTOKSAYIMHAR> stokSayimHarServis ;
        GenericWebServis<PocoSTOKSAYIM> stokSayimServis ;
        GenericWebServis<PocoSTOK> stokServis ;
        GenericWebServis<PocoDEPO> depoServis ;
        GenericWebServis<PocoSTOKHAR> stokHarServis ;
        GenericWebServis<PocoSTOKKATEGORI> kategoriServis ;
                       
    

        void Doldur()
        {
            
            stokServis.Data(ServisList.StokListeServis);
            depoServis.Data(ServisList.DepoListeServis);
            //BTStokKoduSec.Text = _tempStok.kod;
            //TBAdi.Text = _tempStok.adi;
           
        

        }

        private void FStokSayimPanel_Load(object sender, EventArgs e)
        {
            depoServis.Data(ServisList.DepoListeServis);
            kategoriServis.Data(ServisList.StokKategoriListeServis);
            stokHarServis.Data(ServisList.StokHarListeServis);
            DTPSayimTar.EditValue = _tempStokSayim.sayimtarihi;
            TBDepo.EditValue = depoServis.obje.Where(x=> x.id == _tempStokSayim.depoid).FirstOrDefault().depoadi;
            TBAciklama.Text = _tempStokSayim.aciklama;

            stokServis.Data(ServisList.StokListeServis);

            DGStokSayim.DataSource = stokServis.obje.Select(x => new
            {
                ADI = x.adi,
                KATEGORİ = kategoriServis.obje.Where(y => y.id == x.kategoriid).FirstOrDefault().acıklama,
                DEPODAKİMIKTAR = stokHarServis.obje.Where(z => z.depoid == _tempStokSayim.depoid).Sum(z => z.miktar),
                SAYIMMİKTARI = 0,
                SAYIMACIKLAMA = "",
            }) ;
      
        
           

                //DataGridViewButtonColumn dgvBtColumn = new DataGridViewButtonColumn();
                //dgvBtColumn.Name = "DGVBTStokSec";
                //dgvBtColumn.Text = "Seç";
                //dgvBtColumn.HeaderText = "Seç"; 
                //dgvBtColumn.FlatStyle = FlatStyle.Flat;
                //dgvBtColumn.DisplayIndex = 1; 
              
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



        private void BTKaydet_Click(object sender, EventArgs e)
        {
            stokServis.Data(ServisList.StokListeServis);
            
        }



        private void BTCik_Click(object sender, EventArgs e)
        {
            MessageBoxButtons.CancelTryContinue.Equals(false);
            this.Close();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
         
        }
    }
}
