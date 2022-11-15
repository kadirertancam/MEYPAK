using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.CARI;
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

namespace MEYPAK.PRL.CARI
{
    public partial class FCariList : Form
    {
        string _islem;
        string _form;
        public FCariList(string form="",string islem="")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
            _cariServis = new GenericWebServis<PocoCARIKART>();
           
        }
        GenericWebServis<PocoCARIKART> _cariServis;
        FCariKart _cariKart;
        FCariHareket _cariHareket;
        FMusteriSiparis _fmusteriSiparis;
        FSatinAlmaSiparis fSatinAlmaSiparis;
    
        private void FCariList_Load_1(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FCariKart"))
                        _cariKart = (FCariKart)frm;
                    if (frm.Name.Contains("FCariHareket"))
                        _cariHareket = (FCariHareket)frm;
                    if (frm.Name.Contains("FMusteriSiparis"))
                        _fmusteriSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("SatinAlmaSiparis"))
                        fSatinAlmaSiparis = (FSatinAlmaSiparis)frm;
                }
            }

            _cariServis.Data(ServisList.CariListeServis);
            DGCariList.DataSource = _cariServis.obje.Select(x => new
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
            });
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (_islem == "carikart")
                _cariKart._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
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
            this.Close();
        }
    }
}
