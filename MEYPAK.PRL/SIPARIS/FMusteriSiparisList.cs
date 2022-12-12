using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FMusteriSiparisList : XtraForm
    {
        string _islem;
        string _form;
        FMusteriSiparis fmusteriSiparis;
        FSatinAlmaSiparis fsatinalmaSiparis;
        GenericWebServis<PocoSIPARIS> _mSiparisServis;
        public FMusteriSiparisList(string form="",string islem="")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;   
            _mSiparisServis = new GenericWebServis<PocoSIPARIS>();
        }

        private void FMusteriSiparisList_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FMusteriSiparis"))
                        fmusteriSiparis = (FMusteriSiparis)frm;
                    if (frm.Name.Contains("FSatinAlmaSiparis"))
                        fsatinalmaSiparis = (FSatinAlmaSiparis)frm;
                }
            } 
            _mSiparisServis.Data(ServisList.SiparisListeServis);
            if(_islem== "FSatinAlmaSiparis")
                GCMusteriSiparisList.DataSource = _mSiparisServis.obje.Where(x=>x.tip==1).Select(x => new
                {
                    ID = x.id,
                    x.siparistarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                });
            if (_islem == "FMusteriSiparis")
                GCMusteriSiparisList.DataSource = _mSiparisServis.obje.Where(x => x.tip == 0).Select(x => new
                {
                    ID = x.id,
                    x.siparistarihi,
                    x.belgeno,
                    x.cariadi,
                    x.althesapid,
                    x.depoid,
                    x.geneltoplam
                }); 
        }




        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _mSiparisServis.Data(ServisList.SiparisListeServis);
            if (_islem == "FMusteriSiparis")
            {
                if (fmusteriSiparis != null)
                {
                    fmusteriSiparis._tempSIPARIS = _mSiparisServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

            }
            if(_islem == "FSatinAlmaSiparis")
            {
                if (fsatinalmaSiparis != null)
                {
                    fsatinalmaSiparis._tempSIPARIS= _mSiparisServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
            }
            this.Close();
        }
    }
}
