﻿using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET
{
    public partial class FBordroList : XtraForm
    {
        public FBordroList(string form = "", string islem = "")
        {
            InitializeComponent();
            this._islem = islem;
            this._form = form;
            _ceksenetustsbServis = new GenericWebServis<PocoCEKSENETUSTSB>();
            _cariSevis = new GenericWebServis<PocoCARIKART>();
        }

        #region TANIMLAR
        GenericWebServis<PocoCEKSENETUSTSB> _ceksenetustsbServis;
        GenericWebServis<PocoCARIKART> _cariSevis;
        FFirmaCekTanim fFirmaCekTanim;
        FFirmaSenetTanim fFirmaSenetTanim;
        FMusteriCekTanim fMusteriCekTanim;
        FMusteriSenetTanim fMusteriSenetTanim;

        string _islem;
        string _form;
        #endregion

        private void FBordroList_Load(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FFirmaCekTanim"))
                        fFirmaCekTanim = (FFirmaCekTanim)frm;
                    if (frm.Name.Contains("FFirmaSenetTanim"))
                        fFirmaSenetTanim = (FFirmaSenetTanim)frm;
                    if (frm.Name.Contains("FMusteriCekTanim"))
                        fMusteriCekTanim = (FMusteriCekTanim)frm;
                    if (frm.Name.Contains("FMusteriSenetTanim"))
                        fMusteriSenetTanim = (FMusteriSenetTanim)frm;

                }
            }

            _ceksenetustsbServis.Data(ServisList.CekSenetUstSBListeServis);
            _cariSevis.Data(ServisList.CariListeServis);

            if (_islem == "FFirmaCekTanim")
            {
                gridControl1.DataSource = _ceksenetustsbServis.obje.Where(x => x.BORDROTIP == 1).Select(x => new
                {
                    x.BORDRONO,
                    CARI= _cariSevis.obje.Where(y=>y.id==x.CARIID).FirstOrDefault().unvan,
                    x.TARIH,
                    x.TOPLAM,
                    
                });
            }
            if (_islem == "FFirmaSenetTanim")
            {
                gridControl1.DataSource = _ceksenetustsbServis.obje.Where(x => x.BORDROTIP == 2).Select(x => new
                {
                    x.BORDRONO,
                    CARI = _cariSevis.obje.Where(y => y.id == x.CARIID).FirstOrDefault().unvan,
                    x.TARIH,
                    x.TOPLAM,

                });
            }
            if (_islem == "FMusteriCekTanim")
            {
                gridControl1.DataSource = _ceksenetustsbServis.obje.Where(x => x.BORDROTIP == 3).Select(x => new
                {
                    x.BORDRONO,
                    CARI = _cariSevis.obje.Where(y => y.id == x.CARIID).FirstOrDefault().unvan,
                    x.TARIH,
                    x.TOPLAM,

                });
            }
            if (_islem == "FMusteriSenetTanim")
            {
                gridControl1.DataSource = _ceksenetustsbServis.obje.Where(x => x.BORDROTIP == 4).Select(x => new
                {
                    x.BORDRONO,
                    CARI = _cariSevis.obje.Where(y => y.id == x.CARIID).FirstOrDefault().unvan,
                    x.TARIH,
                    x.TOPLAM,

                });
            }


        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (_islem== "FFirmaCekTanim")
            fFirmaCekTanim.tempCekSenetUstSb = _ceksenetustsbServis.obje.Where(x=>x.BORDRONO== gridView1.GetFocusedRowCellValue("BORDRONO").ToString()).FirstOrDefault();
            if (_islem== "FMusteriCekTanim")
            fMusteriCekTanim.tempCekSenetUstSb = _ceksenetustsbServis.obje.Where(x => x.BORDRONO == gridView1.GetFocusedRowCellValue("BORDRONO").ToString()).FirstOrDefault();
            if (_islem == "FFirmaSenetTanim")
                fFirmaSenetTanim.tempCekSenetUstSb = _ceksenetustsbServis.obje.Where(x => x.BORDRONO == gridView1.GetFocusedRowCellValue("BORDRONO").ToString()).FirstOrDefault();
            if (_islem == "FMusteriSenetTanim")
                fMusteriSenetTanim.tempCekSenetUstSb = _ceksenetustsbServis.obje.Where(x => x.BORDRONO == gridView1.GetFocusedRowCellValue("BORDRONO").ToString()).FirstOrDefault();
            this.Close();

        }

    }
}
