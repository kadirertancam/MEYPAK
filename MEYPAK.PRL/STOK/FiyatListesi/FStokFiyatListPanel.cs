using MEYPAK.BLL.Assets;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokFiyatListPanel : Form
    {
        int stokid=0,stokfiyatharid=0;
        public List<PocoSTOKFIYATLISTHAR> _mpStokFiyatListHar = new List<PocoSTOKFIYATLISTHAR>();
        public PocoSTOKFIYATLIST _fiyatlist;
        public PocoSTOKFIYATLISTHAR _fiyatlisthar = new PocoSTOKFIYATLISTHAR();
        FStokList _stoklist;
        GenericWebServis<PocoSTOK> _stokServis ;
        GenericWebServis<PocoSTOKFIYATLISTHAR> _stokFiyatListHarServis ;
        public FStokFiyatListPanel(PocoSTOKFIYATLIST fiyatlist)
        {
            InitializeComponent();
 
                this._fiyatlist = fiyatlist; 

            
            _stoklist = NinjectFactory.CompositionRoot.Resolve<FStokList>();
            _stokFiyatListHarServis = new GenericWebServis<PocoSTOKFIYATLISTHAR>();
            _stokFiyatListHarServis.Data(ServisList.StokFiyatListHarListeServis);
        }
        public PocoSTOK _tempStok;
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (PocoSTOKFIYATLISTHAR mPSTOKFIYATLISTHAR in _mpStokFiyatListHar)
            {
                _stokFiyatListHarServis.Data(ServisList.StokFiyatListHarEkleServis,(mPSTOKFIYATLISTHAR));
                
            }
            MessageBox.Show("Başarıyla Eklendi.");
        }

        private void BTStokKaydet_Click(object sender, EventArgs e)
        {
            DataGrideEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FStokList fStokList = new FStokList("stokfiyatlistpanel");
            fStokList.ShowDialog();
            if (_tempStok != null)
                if (_tempStok.id > 0)
                {
                    stokid = _tempStok.id;
                    TBStokKodu.Text = _tempStok.kod;
                    TBStokAdi.Text = _tempStok.adi;
                }
        }

        private void FStokFiyatListPanel_Load(object sender, EventArgs e)
        {
            DataGridiDoldur();
        }
        void DataGridiDoldur()
        {
            if (_fiyatlist.ID != null && _stokFiyatListHarServis.obje.Where(x => x.FIYATLISTID == _fiyatlist.ID).ToList().Count>0)
            {   _mpStokFiyatListHar = _stokFiyatListHarServis.obje.Where(x =>x.FIYATLISTID==_fiyatlist.ID).ToList();
                dataGridView1.DataSource = _mpStokFiyatListHar;
            }
        }
        void DataGrideEkle()
        {
            if (_fiyatlist.ID != null && stokid!=0)
            {
                PocoSTOKFIYATLISTHAR mpStok = new PocoSTOKFIYATLISTHAR()
                {
                    FIYATLISTID = _fiyatlist.ID,
                    // DOVIZID=CMBDovizId.SelectedValue,
                    GUNCELLEMETARIHI = DateTime.Now,
                    NETFIYAT = Convert.ToInt32(TBFiyat.Text),
                    STOKID = stokid,
                    KUR = Convert.ToInt32(TBKur.Text),
                    ISKONTO =Convert.ToInt32( TBIskonto.Text)
                };

                _mpStokFiyatListHar.Add(mpStok);
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = _mpStokFiyatListHar;
            }
        }

        private void BTStokSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                _mpStokFiyatListHar.Remove(_mpStokFiyatListHar[dataGridView1.SelectedRows[0].Index]);

                dataGridView1.DataSource = "";
                dataGridView1.DataSource = _mpStokFiyatListHar;
            }
        }
        

        private void BTTemizle_Click(object sender, EventArgs e)
        {
            _mpStokFiyatListHar.Clear();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = _mpStokFiyatListHar;
        }
 
        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _stokServis.Data(ServisList.StokListeServis);
            if (dataGridView1.SelectedRows != null)
            {   //todo burdan id çekip güncelleme işlemi yapılabilecek.
                stokfiyatharid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                _fiyatlisthar = _stokFiyatListHarServis.obje.Where(x=> x.ID==stokfiyatharid).FirstOrDefault();
                TBStokKodu.Text = _stokServis.obje.Where(x=> x.id==_fiyatlisthar.STOKID).FirstOrDefault().kod;
                TBKur.Text = _fiyatlisthar.KUR.ToString();
                TBStokAdi.Text = _stokServis.obje.Where(x => x.id == _fiyatlisthar.STOKID).FirstOrDefault().adi;
                TBIskonto.Text= _fiyatlisthar.ISKONTO.ToString();  
                TBFiyat.Text = _fiyatlisthar.NETFIYAT.ToString();
            }
        }

        #region KeyPress
        private void BTCık_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBKur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void TBIskonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        #endregion
    }
}
