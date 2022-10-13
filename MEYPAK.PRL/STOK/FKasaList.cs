using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.SIPARIS;
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
    public partial class FKasaList : Form
    {
        FStokKart fStokKart;
        FMusteriSiparis fSiparis;
        string _islem;
        public FKasaList(string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
        }
        IKasaServis _kasaServis = new KasaManager(new EFKasaRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));
        private void FKasaList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _kasaServis.Listele();
            fStokKart = (FStokKart)Application.OpenForms["FStokKart"];
            fSiparis = (FMusteriSiparis)Application.OpenForms["FSiparis"];

        }
        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_islem == "Stok")
            {
                if (fStokKart != null)
                    fStokKart._tempKasa = _kasaServis.Getir(x => x.ID.ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            }
            else if (_islem == "Siparis")
            {
                if (fSiparis != null) ;
                fSiparis._tempKasa = _kasaServis.Getir(x => x.ID.ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
            }

            this.Close();
        }


    }
}
