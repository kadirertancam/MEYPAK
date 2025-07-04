﻿using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.PRL.DEPO;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.STOK;
using MEYPAK.PRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using DevExpress.XtraEditors;
using MEYPAK.Interfaces.Cari;
using MEYPAK.PRL.SIPARIS.Raporlar;
using MEYPAK.PRL.CARI.Raporlar;

namespace MEYPAK.PRL.CARI
{
    public partial class FAltHesapList : XtraForm
    {
        public FAltHesapList(string form="", string islem = "")
        {
           
            InitializeComponent();
            this._islem = islem;
            this._form = form;
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _parabirIMServis = new GenericWebServis<PocoPARABIRIM>();
           
        }

        #region Tanımlar
        int id;
        string _islem;
        string _form;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoPARABIRIM> _parabirIMServis;
        FCariAltHesap fCariAltHesap;
        FCariKart fCariKart;
        FFaturaRaporu fFaturaRaporu;
        FMusteriSiparisRaporu fMusteriSiparisRaporu;
        FCariHareketRaporu fCariHareketRaporu;
        Form tempForm;

        #endregion
        private void FAltHesapList_Load(object sender, EventArgs e)
        {

            foreach (Form frm in Application.OpenForms)
            {
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FCariKart"))
                        fCariKart = (FCariKart)frm;
                    
                }
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FFaturaRaporu"))
                        fFaturaRaporu = (FFaturaRaporu)frm;

                }
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FMusteriSiparisRaporu"))
                        fMusteriSiparisRaporu = (FMusteriSiparisRaporu)frm;

                }
                if (_form == frm.Tag)
                {
                    if (frm.Name.Contains("FCariHareketRaporu"))
                        fCariHareketRaporu = (FCariHareketRaporu)frm;

                }
            }
            _parabirIMServis.Data(ServisList.ParaBirimiListeServis);
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            DGAltHesap.DataSource = _cariAltHesapServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                KOD = x.kod,
                ADI = x.adi,
                AKTIF = 1,
                DOVIZ = _parabirIMServis.obje.Where(z => z.id == x.dovizid).Select(z => z.kisaadi).FirstOrDefault() }).ToList();
               
            DGAltHesap.Refresh();
            DGAltHesap.RefreshDataSource();
            
        }

        private void DGAltHesap_CellDoubleClick(object sender, EventArgs e)
        {
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _cariAltHesapServis.Data(ServisList.CariAltHesListeServis);
            if (_islem == "carikart")
            {
                if (fCariKart != null)
                    fCariKart._tempCARIALTHES = _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            if (_islem == "FFaturaRaporu")
            {
                if (fFaturaRaporu != null)
                    fFaturaRaporu._tempCARIALTHES = _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            if (_islem == "FMusteriSiparisRaporu")
            {
                if (fMusteriSiparisRaporu != null)
                    fMusteriSiparisRaporu._tempCARIALTHES = _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            if (_islem == "FCariHareketRaporu")
            {
                if (fCariHareketRaporu != null)
                    fCariHareketRaporu._tempAltHesap = _cariAltHesapServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            }
            this.Close();
        }
    }
}

