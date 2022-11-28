using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CARI
{
    public partial class FCariList : XtraForm
    {
        string _islem;
        string _form;
       
        FCariHareket _cariHareket;
        FMusteriSiparis _fmusteriSiparis;
        FSatinAlmaSiparis fSatinAlmaSiparis;
        FSatisIrsaliye fSatisIrsaliye;
        FAlisIrsaliye fAlisIrsaliye;
        FCariKart fCariKart;
       
        FFatura ffatura;
        public FCariList(string form="",string islem="")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
            _cariServis = new GenericWebServis<PocoCARIKART>();
           
        }

        #region Tanımlar
        GenericWebServis<PocoCARIKART> _cariServis;
        Form tempForm;

        #endregion

        #region Metotlar
       
        private void DGCariList_DoubleClick(object sender, EventArgs e)
        {
            if (_islem == "carikart")
                fCariKart._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            if (_islem == "carihar")
                _cariHareket._tempCARIKART = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            if (_islem == "musterisiparis")
            {
                _fmusteriSiparis._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            if (_islem == "SatinAlmaSiparis")
            {
                fSatinAlmaSiparis._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            if (_islem == "SatisIrsaliye")
            {
                fSatisIrsaliye._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }    if (_islem == "AlisIrsaliye")
            {
                fAlisIrsaliye._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            if (_islem == "FFatura")
            {
                ffatura._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            this.Close();
        }

        private void DGCariList_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FCariKart"))
                        fCariKart = (FCariKart)frm;
                    if (frm.Name.Contains("FCariHareket"))
                        _cariHareket = (FCariHareket)frm;
                    if (frm.Name.Contains("FMusteriSiparis"))
                        _fmusteriSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("SatinAlmaSiparis"))
                        fSatinAlmaSiparis = (FSatinAlmaSiparis)frm;
                    if (frm.Name.Contains("SatisIrsaliye"))
                        fSatisIrsaliye = (FSatisIrsaliye)frm;
                    if (frm.Name.Contains("AlisIrsaliye"))
                        fAlisIrsaliye = (FAlisIrsaliye)frm;
                    if (frm.Name.Contains("FFatura"))
                        ffatura = (FFatura)frm;
                }
            }

            _cariServis.Data(ServisList.CariListeServis);
            DGCariList.DataSource = _cariServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                CARIKODU = x.kod,
                CARIUNVAN = x.unvan,
                VERGIDAIRESI = x.vergidairesi,
                VERGINO = x.vergino,
                x.il,
                x.ilce,
                x.grupkodu,
                x.kategori,
                x.telefon,
                x.ceptel,
                x.eposta
            }).ToList();
            DGCariList.Refresh();
            DGCariList.RefreshDataSource();

        }
        #endregion

        private void gridView1_CellDoubleClick(object sender, EventArgs e)
        {
            
            //DateTime dt = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("SAYIMTARIHI").ToString());
            //string aciklama = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            //fSayimIsle._tempSayim = _stokSayimServis.obje.Where(x => x.aciklama == aciklama.ToString()).FirstOrDefault();
            //fSayimIsle._id = int.Parse(gridView1.GetFocusedRowCellValue("SAYIMTARIHI").ToString());
            //this.Close();
        }
    }
}
