using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.STOK.Raporlar;
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
    public partial class FDepoList : XtraForm
    {
        string _islem,_form;
        public FDepoList(string islem="", string tag = "")
        {
            InitializeComponent();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _islem = islem;
            _form = tag;
        }
        FDepoKart depoKart;
        FDepolarArasıTransfer depoTransferKart;
        FDepolarArasıTransferHar depoTransferBilgiKart;
        FStokSayimRaporu fStokSayimRaporu;
        FStokHareketRaporu fStokHareketRaporu;
        GenericWebServis<PocoDEPO> _depoServis ;

        private void FDepoList_Load(object sender, EventArgs e)
        {
            _depoServis.Data(ServisList.DepoListeServis);
            GCDepoList.DataSource = _depoServis.obje;
            depoKart = (FDepoKart)Application.OpenForms["FDepoKart"];
            depoTransferKart = (FDepolarArasıTransfer)Application.OpenForms["FDepolarArasıTransfer"];
            depoTransferBilgiKart = (FDepolarArasıTransferHar)Application.OpenForms["FDepolarArasıTransferBilgi"];
        }


        private void GCDepoList_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "FDepoKart")
            {
                depoKart._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferCıktı")
            {
                depoTransferKart._CıktıDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferHedef")
            {
                depoTransferKart._HedefDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            else if (_islem == "FStokSayimRaporu")
            {
                fStokSayimRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            else if (_islem == "FStokHareketRaporu")
            {
                fStokHareketRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("depokodu")).FirstOrDefault();
            }
            this.Close();
        }
    }
}
