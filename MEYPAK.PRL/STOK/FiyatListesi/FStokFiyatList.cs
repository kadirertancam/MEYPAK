using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
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
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;

namespace MEYPAK.PRL.STOK
{
    public partial class FStokFiyatList : Form
    {
        public FStokFiyatList()
        {
            InitializeComponent();
            _stokFiyatListServis = new GenericWebServis<PocoSTOKFIYATLIST>();
            _stokFiyatListServis.Data(ServisList.StokFiyatListListeServis);
        }
        static MEYPAKContext _context = NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        GenericWebServis<PocoSTOKFIYATLIST> _stokFiyatListServis ;
        FStokFiyatListPanel _stokFiyatListPanel;
        PocoSTOKFIYATLIST _tempSTOKFIYATLIST;
        public List<PocoStokFiyatList> _tempStokFiyatList;
        private void BTKayet_Click(object sender, EventArgs e)
        {
          _stokFiyatListServis.Data(ServisList.StokFiyatListEkleServis,new PocoSTOKFIYATLIST()
            {
                FIYATLISTADI = TBFiyatListesiAdi.Text,
                OLUSTURMATARIHI = DateTime.Now,
                BASTAR = DTPBastar.Value,
                BITTAR = DTPBittar.Value
            });
            _stokFiyatListServis.Data(ServisList.StokFiyatListListeServis);

            _tempSTOKFIYATLIST = _stokFiyatListServis.obje.Where(x => x.FIYATLISTADI == TBFiyatListesiAdi.Text ).FirstOrDefault();

          _stokFiyatListPanel = new FStokFiyatListPanel(_tempSTOKFIYATLIST);
            _stokFiyatListPanel.ShowDialog();

        }

        private void FStokFiyatList_Load(object sender, EventArgs e)
        {
            _stokFiyatListServis.Data(ServisList.StokFiyatListListeServis);
            _tempStokFiyatList = new List<PocoStokFiyatList>();
            StokFiyatListesiniGetir();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows!=null)
            {

                _tempSTOKFIYATLIST = _stokFiyatListServis.obje.Where(x => x.ID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())).FirstOrDefault();
                _stokFiyatListPanel = new FStokFiyatListPanel(_tempSTOKFIYATLIST);
                _stokFiyatListPanel.ShowDialog();

            }
        }

        void StokFiyatListesiniGetir()
        {
            dataGridView1.DataSource = _stokFiyatListServis.obje;
            dataGridView1.Columns[0].Visible = false; 
            dataGridView1.Columns[dataGridView1.ColumnCount-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BTSil_Click(object sender, EventArgs e)
        {
            _stokFiyatListServis.Data(ServisList.StokFiyatListSilServis,_stokFiyatListServis.obje.Where(x => x.ID == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)).FirstOrDefault());
        }
    }
}
