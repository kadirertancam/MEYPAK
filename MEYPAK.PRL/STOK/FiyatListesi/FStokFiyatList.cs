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
            _stokFiyatListHarServis = new GenericWebServis<PocoSTOKFIYATLISTHAR>();
            _stokFiyatListHarServis.Data(ServisList.StokFiyatListHarListeServis);
        }
        static MEYPAKContext _context = NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>();
        GenericWebServis<PocoSTOKFIYATLIST> _stokFiyatListServis ;
        GenericWebServis<PocoSTOKFIYATLISTHAR> _stokFiyatListHarServis ;
        FStokFiyatListPanel _stokFiyatListPanel;
        PocoSTOKFIYATLIST _tempSTOKFIYATLIST;
        public List<PocoStokFiyatList> _tempStokFiyatList;
        private void BTKayet_Click(object sender, EventArgs e)
        {
          _stokFiyatListServis.Data(ServisList.StokFiyatListEkleServis,new PocoSTOKFIYATLIST()
            {
                fiyatlistadi = TBFiyatListesiAdi.Text,
                olusturmatarihi = DateTime.Now,
                bastar = DTBasTar.Value,
                bittar = DTBitisTar.Value
            });
            _stokFiyatListServis.Data(ServisList.StokFiyatListListeServis);

            _tempSTOKFIYATLIST = _stokFiyatListServis.obje.Where(x => x.fiyatlistadi == TBFiyatListesiAdi.Text ).FirstOrDefault();

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
            if (DGFiyatListesi.SelectedRows!=null)
            {

                _tempSTOKFIYATLIST = _stokFiyatListServis.obje.Where(x => x.id == Convert.ToInt32(DGFiyatListesi.Rows[e.RowIndex].Cells[0].Value.ToString())).FirstOrDefault();
                _stokFiyatListPanel = new FStokFiyatListPanel(_tempSTOKFIYATLIST);
                _stokFiyatListPanel.ShowDialog();

            }
        }

        void StokFiyatListesiniGetir()
        {
            DGFiyatListesi.DataSource = _stokFiyatListServis.obje;
            DGFiyatListesi.Columns[0].Visible = false; 
            DGFiyatListesi.Columns[DGFiyatListesi.ColumnCount-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BTSil_Click(object sender, EventArgs e)
        { 
            _stokFiyatListServis.Data(ServisList.StokFiyatListSilServis,null,null,_stokFiyatListServis.obje.Where(x => x.id == Convert.ToInt32(DGFiyatListesi.SelectedRows[0].Cells[0].Value)).ToList());
            _stokFiyatListServis.Data(ServisList.StokFiyatListListeServis);
            _stokFiyatListHarServis.Data(ServisList.StokFiyatListHarListeServis);

            _stokFiyatListHarServis.Data(ServisList.StokFiyatListHarSilServis, null, null, _stokFiyatListHarServis.obje.Where(x => x.fiyatlistid.ToString() == DGFiyatListesi.SelectedRows[0].Cells[0].Value.ToString()).ToList());
            DGFiyatListesi.DataSource= _stokFiyatListServis.obje;
        }

       
    }
}
