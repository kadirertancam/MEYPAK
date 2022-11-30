using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.IRSALIYE;
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
    public partial class FStokOlcuBrList : XtraForm
    {
        string _form; 
        string _islem;
        FStokKart fSTOKKART;
        FFatura ffatura;
        FStokHareket fStokHareket;
        FStokSayimPanel fstokSayimPanel;
       
        FMusteriSiparis fSiparis;
        FSatinAlmaSiparis _fSatınAlmaSiparis;
        FDepolarArasıTransferHar fDepolarArasıHar;
        FSatisIrsaliye fSatisIrsaliye;
        FAlisIrsaliye fAlisIrsaliye;
        FAlisFatura fAlisFatura;
        public FStokOlcuBrList(string form="", string islem = "")
        {
            InitializeComponent();
            _olcuBr = new GenericWebServis<PocoOLCUBR>();
            _stokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
            _form = form; 
            this._islem = islem;
        }
        GenericWebServis<PocoOLCUBR> _olcuBr;
        GenericWebServis<PocoSTOKOLCUBR> _stokOlcuBr;  
        public int stokid;
    
        private void FStokOlcuBrList_Load_1(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FStokHareket"))
                        fStokHareket = (FStokHareket)frm;
                    if (frm.Name.Contains("FStokKart"))
                        fSTOKKART = (FStokKart)frm;
                    if (frm.Name.Contains("FStokSayimPanel"))
                        fstokSayimPanel = (FStokSayimPanel)frm;
                   
                    if (frm.Name.Contains("FDepolarArasıTransferHar"))
                        fDepolarArasıHar = (FDepolarArasıTransferHar)frm;
                    if (frm.Name.Contains("FMusteriSiparis"))
                        fSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("FSatinAlmaSiparis"))
                        _fSatınAlmaSiparis = (FSatinAlmaSiparis)frm; 
                    if (frm.Name.Contains("FSatisIrsaliye"))
                        fSatisIrsaliye = (FSatisIrsaliye)frm;
                    if (frm.Name.Contains("FAlisIrsaliye"))
                        fAlisIrsaliye = (FAlisIrsaliye)frm;
                    if (frm.Name.Contains("FFatura"))
                        ffatura = (FFatura)frm;
                    if (frm.Name.Contains("FAlisFatura"))
                        fAlisFatura = (FAlisFatura)frm;
                }
            } 
             
            _olcuBr.Data(ServisList.OlcuBrListeServis);
            _stokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            GCStokOlcuBrList.DataSource = _stokOlcuBr.obje.Where(x=>x.stokid==stokid).Select(x=> _olcuBr.obje.Where(z=>z.id==x.olcubrid).Select(z=>z.adi).FirstOrDefault()).ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "musterisiparis")
                fSiparis.gridView1.SetFocusedRowCellValue("Birim", gridView1.GetFocusedRowCellValue("Column"));
            if (_islem == "FSatinAlmaSiparis")
                _fSatınAlmaSiparis.gridView1.SetFocusedRowCellValue("Birim", gridView1.GetFocusedRowCellValue("Column"));
            if (_islem == "SatisIrsaliye")
                fSatisIrsaliye.gridView1.SetFocusedRowCellValue("Birim", gridView1.GetFocusedRowCellValue("Column"));
            if (_islem == "AlisIrsaliye")
                fAlisIrsaliye.gridView1.SetFocusedRowCellValue("Birim", gridView1.GetFocusedRowCellValue("Column"));
            if (_islem == "FFatura")
                ffatura.gridView1.SetFocusedRowCellValue("Birim", gridView1.GetFocusedRowCellValue("Column"));
              if (_islem == "FAlisFatura")
                fAlisFatura.gridView1.SetFocusedRowCellValue("Birim", gridView1.GetFocusedRowCellValue("Column"));

            this.Close();
        }
    }
}
