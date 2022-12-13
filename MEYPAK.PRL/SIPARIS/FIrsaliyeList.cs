using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.SIPARIS.Raporlar;
using MEYPAK.PRL.STOK.Raporlar;
using System.Data;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FIrsaliyeList : XtraForm
    {
        string _form,_islem; 
        public FIrsaliyeList(string frm="",string islem="")
        {
            InitializeComponent();
            _form = frm;
            _islem = islem;
            _mIrsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
          
        }
        FSatisIrsaliye fsatisIralsiye;
        FAlisIrsaliye falisIralsiye;
        FFaturaRaporu fFaturaRaporu;
        FStokKasaHareketRaporu fStokKasaHareketRaporu;
        GenericWebServis<PocoIRSALIYE> _mIrsaliyeServis;
      

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _mIrsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            if (_islem == "FSatisIrsaliye")
            {
                if (fsatisIralsiye != null)
                {
                    fsatisIralsiye._tempIrsaliye = _mIrsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

            }
            if (_islem == "FAlisIrsaliye")
            {
                if (falisIralsiye != null)
                {
                    falisIralsiye._tempIrsaliye = _mIrsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
            }
            if (_islem == "FStokKasaHareketRaporu")
            {
                if (fStokKasaHareketRaporu != null)
                {
                    fStokKasaHareketRaporu._tempIrsaliye = _mIrsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

            }
            if (_islem == "FFaturaRaporu")
            {
                if (fFaturaRaporu != null)
                {
                    fFaturaRaporu._tempIrsaliye = _mIrsaliyeServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

            }
            this.Close();
        }

        private void FIrsaliyeList_Load(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FSatisIrsaliye"))
                        fsatisIralsiye = (FSatisIrsaliye)frm;
                    if (frm.Name.Contains("FAlisIrsaliye"))
                        falisIralsiye = (FAlisIrsaliye)frm;
                    if (frm.Name.Contains("FStokKasaHareketRaporu"))
                        fStokKasaHareketRaporu = (FStokKasaHareketRaporu)frm;
                    if (frm.Name.Contains("FFaturaRaporu"))
                        fFaturaRaporu = (FFaturaRaporu)frm;
                }
            }
            _mIrsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            if (_islem == "FSatisIrsaliye" || _islem == "FFaturaRaporu")
                gridControl1.DataSource = _mIrsaliyeServis.obje.Where(x => x.tip == 0).Select(x => new
                {
                    ID = x.id,
                    x.irsaliyetarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                });
            if (_islem == "FAlisIrsaliye")
                gridControl1.DataSource = _mIrsaliyeServis.obje.Where(x => x.tip == 1).Select(x => new
                {
                    ID = x.id,
                    x.irsaliyetarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                });
        }
    }
}
