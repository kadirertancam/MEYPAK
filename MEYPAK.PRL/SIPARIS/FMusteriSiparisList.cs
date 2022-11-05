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
    public partial class FMusteriSiparisList : Form
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
            if(_islem=="satinalmasiparis")
                GCMusteriSiparis.DataSource = _mSiparisServis.obje.Where(x=>x.TIP==1).Select(x => new
                {
                    ID = x.id,
                    x.SIPARISTARIHI,
                    x.BELGENO,
                    x.CARIADI,
                    x.ALTHESAPID,
                    x.DEPOID,
                    x.GENELTOPLAM
                });
            if (_islem == "Siparis") 
                GCMusteriSiparis.DataSource = _mSiparisServis.obje.Where(x => x.TIP == 0).Select(x => new
                {
                    ID = x.id,
                    x.SIPARISTARIHI,
                    x.BELGENO,
                    x.CARIADI,
                    x.ALTHESAPID,
                    x.DEPOID,
                    x.GENELTOPLAM
                }); 
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _mSiparisServis.Data(ServisList.SiparisListeServis);
            if (_islem == "Siparis")
            {
                if (fmusteriSiparis != null)
                {
                    fmusteriSiparis._tempSiparis = _mSiparisServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }

            }
            if(_islem == "satinalmasiparis")
            {
                if (fsatinalmaSiparis != null)
                {
                    fsatinalmaSiparis._tempSiparis= _mSiparisServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
            }
            this.Close();
        }
    }
}
