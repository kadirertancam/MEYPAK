﻿using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.PRL.SIPARIS.Raporlar;
using System.Data;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FMusteriSiparisList : XtraForm
    {
        string _islem;
        string _form;
        FMusteriSiparis fmusteriSiparis;
        FSatinAlmaSiparis fsatinalmaSiparis;
        FMusteriSiparisRaporu fMusteriSiparisRaporu;
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
                    if (frm.Name.Contains("FSatinAlmaSiparis"))
                        fsatinalmaSiparis = (FSatinAlmaSiparis)frm;
                    if (frm.Name.Contains("FMusteriSiparisRaporu"))
                        fMusteriSiparisRaporu = (FMusteriSiparisRaporu)frm;
                    else if (frm.Name.Contains("FMusteriSiparis"))
                        fmusteriSiparis = (FMusteriSiparis)frm;
                   
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
            if (_islem == "Siparis" || _islem == "FMusteriSiparisRaporu")
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
            if (_islem == "FMusteriSiparisRaporu")
            {
                if (fMusteriSiparisRaporu != null)
                {
                    fMusteriSiparisRaporu._tempSIPARIS = _mSiparisServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                }
            }
            this.Close();
        }
    }
}
