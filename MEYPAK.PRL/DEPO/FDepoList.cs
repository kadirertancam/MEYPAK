using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Interfaces.Depo;
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

namespace MEYPAK.PRL.DEPO
{
    public partial class FDepoList : Form
    {
        string _islem;
        public FDepoList(string islem="")
        {
            InitializeComponent();

            _islem = islem;
        }
        FDepoKart depoKart;
        FDepolarArasıTransfer depoTransferKart;
        FDepolarArasıTransferBilgi depoTransferBilgiKart;
        IDepoServis _depoServis = new DepoManager(new EFDepoRepo(NinjectFactory.CompositionRoot.Resolve<MEYPAKContext>()));

        private void FDepoList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _depoServis.Listele();
            depoKart = (FDepoKart)Application.OpenForms["FDepoKart"];
            depoTransferKart = (FDepolarArasıTransfer)Application.OpenForms["FDepoTransfer"];
            depoTransferBilgiKart = (FDepolarArasıTransferBilgi)Application.OpenForms["FDepoTransferBilgi"];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_islem == "FDepoKart")
            {
                depoKart._tempDepo = _depoServis.Getir(x => x.DEPOKODU == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferCıktı")
            {
                depoTransferKart._CıktıDepo = _depoServis.Getir(x => x.DEPOKODU == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferHedef")
            {
                depoTransferKart._HedefDepo = _depoServis.Getir(x => x.DEPOKODU == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()).FirstOrDefault();
            }


            this.Close();
        }
    }
}
