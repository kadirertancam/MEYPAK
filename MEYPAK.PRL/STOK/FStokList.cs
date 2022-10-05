using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
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

namespace MEYPAK.PRL.STOK
{
    public partial class FStokList : Form
    {
        FStokKart fSTOKKART;
        FStokHareket fStokHareket;
        FStokSayimPanel fstokSayimPanel;
        int id;
        string _islem;
        public FStokList(string islem="")
        {
            InitializeComponent();
            this._islem = islem;
        }
        IStokServis _stokServis = new StokManager(new EFStokRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        IStokOlcuBrServis _stokOlcuBrServis = new StokOlcuBrManager(new EFStokOlcuBrRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        private void FStokList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _stokServis.Listele().Select(x => new { x.ID, x.KOD, x.ADI, x.GRUPKODU, x.OLCUBR1, x.MARKAID }).ToList();

            fSTOKKART = (FStokKart)Application.OpenForms["FStokKart"];
            fStokHareket = (FStokHareket)Application.OpenForms["FStokHareket"];
            fstokSayimPanel = (FStokSayimPanel)Application.OpenForms["FStokSayimPanel"];

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_islem == "stokkart")
            {
                if (fSTOKKART != null)
                    fSTOKKART._tempStok = _stokServis.Getir(x => x.ID.ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            }
            else if (_islem == "stoksayimpanel")
            {
                if (fstokSayimPanel != null)
                    fstokSayimPanel._tempStok = _stokServis.Getir(x=>x.ID.ToString()==dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            }
            else if (_islem == "stokhar")
            {
                if (fStokHareket != null)
                    fStokHareket._tempStok = _stokServis.Getir(x => x.ID.ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            }

            this.Close();
        }
    }
}
