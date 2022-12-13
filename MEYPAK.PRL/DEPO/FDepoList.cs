using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.BLL.DEPO;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.DEPO.Raporlar;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.SIPARIS.Raporlar;
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
        public FDepoList(string islem = "", string tag = "")
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
        FFaturaRaporu fFaturaRaporu;
        FDepoRaporu fDepoRaporu;
        FMusteriSiparisRaporu fMusteriSiparisRaporu;
        FStokSevkiyatRaporu fStokSevkiyatRaporu;
        GenericWebServis<PocoDEPO> _depoServis ;

        private void FDepoList_Load(object sender, EventArgs e)
        {
            _depoServis.Data(ServisList.DepoListeServis);
            GCDepoList.DataSource = _depoServis.obje;


            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FDepoRaporu"))
                        fDepoRaporu = (FDepoRaporu)frm;
                    else if (frm.Name.Contains("FDepoKart"))
                        depoKart = (FDepoKart)frm;
                    if (frm.Name.Contains("FStokSayımRaporu"))
                        fStokSayimRaporu = (FStokSayimRaporu)frm;
                    if (frm.Name.Contains("FStokHareketRaporu"))
                        fStokHareketRaporu = (FStokHareketRaporu)frm;
                    if (frm.Name.Contains("FFaturaRaporu"))
                        fFaturaRaporu = (FFaturaRaporu)frm;
                    if (frm.Name.Contains("FMUsteriSiparisRaporu"))
                        fMusteriSiparisRaporu = (FMusteriSiparisRaporu)frm;
                    if (frm.Name.Contains("FStokSevkiyatRaporu"))
                        fStokSevkiyatRaporu = (FStokSevkiyatRaporu)frm;

                }
            }

        }

        private void GCDepoList_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "FDepoKart")
            {
                depoKart._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferCıktı")
            {
                depoTransferKart._CıktıDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FDepoTransferHedef")
            {
                depoTransferKart._HedefDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FStokSayimRaporu")
            {
                fStokSayimRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FStokHareketRaporu")
            {
                fStokHareketRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FFaturaRaporu")
            {
                fFaturaRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FMUsteriSiparisRaporu")
            {
                fMusteriSiparisRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FDepoRaporu")
            {
                fDepoRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            else if (_islem == "FStokSevkiyatRaporu")
            {
                fStokSevkiyatRaporu._tempDepo = _depoServis.obje.Where(x => x.depokodu == gridView1.GetFocusedRowCellValue("id")).FirstOrDefault();
            }
            this.Close();
        }

       
    }
}
