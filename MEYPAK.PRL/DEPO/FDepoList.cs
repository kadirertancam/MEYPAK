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
        FDepolarArasıTransferHar depoTransferBilgiKart;
        IDepoServis _depoServis ;

        private void FDepoList_Load(object sender, EventArgs e)
        {
            GCDepoList.DataSource = _depoServis.Listele();
            depoKart = (FDepoKart)Application.OpenForms["FDepoKart"];
            depoTransferKart = (FDepolarArasıTransfer)Application.OpenForms["FDepolarArasıTransfer"];
            depoTransferBilgiKart = (FDepolarArasıTransferHar)Application.OpenForms["FDepolarArasıTransferBilgi"];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_islem == "FDepoKart")
            {
                depoKart._tempDepo = _depoServis.Getir(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferCıktı")
            {
                depoTransferKart._CıktıDepo = _depoServis.Getir(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferHedef")
            {
                depoTransferKart._HedefDepo = _depoServis.Getir(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            this.Close();
        }
    }
}
