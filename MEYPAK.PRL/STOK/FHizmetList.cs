using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
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
    public partial class FHizmetList : XtraForm
    {
        string _islem;
        string _form;
        FHizmetKart fHizmetKart;
  
        GenericWebServis<PocoHIZMET> _hizmetservis = new GenericWebServis<PocoHIZMET>();
        private FAlisFatura fAlisFatura;
        private FFatura ffatura;
        private FAlisIrsaliye fAlisIrsaliye;
        private FSatisIrsaliye fSatisIrsaliye;
        private FSatinAlmaSiparis _fSatınAlmaSiparis;
        private FMusteriSiparis fSiparis;

        public FHizmetList(string form = "", string islem = "")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
        }

        private void FHizmetList_Load(object sender, EventArgs e)
        {
            _hizmetservis.Data(ServisList.HizmetListeServis);
            gridControl1.DataSource= _hizmetservis.obje.Where(x => x.kayittipi == 0).Select(x=> new
            {
                ID=x.id,
                ADI=x.adi,
                GRUPKODU =x.grupkodu,
                KATEGORİ=x.kategoriid,
            });
            gridView1.Columns["ID"].Visible = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FHizmetKart"))
                        fHizmetKart = (FHizmetKart)frm;
                    if (frm.Name.Contains("FMusteriSiparis"))
                        fSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("FSatinAlmaSiparis"))
                        _fSatınAlmaSiparis = (FSatinAlmaSiparis)frm;
                    if (frm.Name.Contains("SatisIrsaliye"))
                        fSatisIrsaliye = (FSatisIrsaliye)frm;
                    if (frm.Name.Contains("AlisIrsaliye"))
                        fAlisIrsaliye = (FAlisIrsaliye)frm;
                    if (frm.Name.Contains("FFatura"))
                        ffatura = (FFatura)frm;
                    if (frm.Name.Contains("FAlisFatura"))
                        fAlisFatura = (FAlisFatura)frm;
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            if (_islem == "hizmetkart")
            {
                if (fHizmetKart != null)
                    fHizmetKart._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "FMusteriSiparis")
            {
                if (fSiparis != null)
                    fSiparis._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "FSatinAlmaSiparis")
            {
                if (_fSatınAlmaSiparis != null)
                    _fSatınAlmaSiparis._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

            }
            else if (_islem == "FSatisIrsaliye")
            {
                if (fSatisIrsaliye != null)
                    fSatisIrsaliye._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

            }
            else if (_islem == "FAlisIrsaliye")
            {
                if (fAlisIrsaliye != null)
                    fAlisIrsaliye._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

            }
            else if (_islem == "FFatura")
            {
                if (ffatura != null)
                    ffatura._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            else if (_islem == "FAlisFatura")
            {
                if (fAlisFatura != null)
                    fAlisFatura._tempHizmet = _hizmetservis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }

            this.Close();
        }
    }
}
