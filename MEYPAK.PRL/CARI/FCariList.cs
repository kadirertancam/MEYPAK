﻿using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.BANKA;
using MEYPAK.PRL.CARI.Raporlar;
using MEYPAK.PRL.CEKSENET;
using MEYPAK.PRL.E_ISLEMLER;
using MEYPAK.PRL.IRSALIYE;
using MEYPAK.PRL.KASA;
using MEYPAK.PRL.SIPARIS;
using MEYPAK.PRL.SIPARIS.Raporlar;
using MEYPAK.PRL.STOK;
using MEYPAK.PRL.STOK.FiyatListesi;
using MEYPAK.PRL.STOK.Raporlar;
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
      
       
        public FCariList(string form = "", string islem = "")
        {
            InitializeComponent();
            _islem = islem;
            _form = form;
            _cariServis = new GenericWebServis<PocoCARIKART>();

        }

        #region Tanımlar
        GenericWebServis<PocoCARIKART> _cariServis;
        Form tempForm;
        string _islem;
        string _form;
        FFirmaCekTanim _firmaCekTanim;
        FCariHareket _cariHareket;
        FMusteriSiparis _fmusteriSiparis;
        FSatinAlmaSiparis fSatinAlmaSiparis;
        FSatisIrsaliye fSatisIrsaliye;
        FAlisIrsaliye fAlisIrsaliye;
        FAlisFatura fAlisFatura;
        FCariKart fCariKart;
        FStokFiyat fStokFiyat;
        FCariHareketRaporu fCariHareketRaporu;
        FStokKasaHareketRaporu fStokKasaHareketRaporu;
        FStokFiyatRaporu fStokFiyatRaporu;
        FFatura ffatura;
        FFaturaRaporu fFaturaRaporu;
        FCariRaporu fCariRaporu;
        FMusteriSiparisRaporu fMusteriSiparisRaporu;
        FCariDurum fCariDurum;
        FKasaHareket fKasaHareket;
        FFirmaSenetTanim fFirmaSenet;
        FMusteriCekTanim fMusteriCekTanim;
        FHesapHareket fHesapHareket;
        FMusteriCekCariCiro FMusteriCekCariCiro;
        FMusteriSenetCariCiro FMusteriSenetCariCiro;
        FGELENIRSALIYE fGELENIRSALIYE;
        FGindeFaturaEşleştir fGindeFaturaEşleştir;
        EFATURA fefatura;
        Main main;
        int i = 0;
        #endregion

        #region Metotlar

        private void DGCariList_DoubleClick(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                if (_islem == "carikart")
                    fCariKart._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "carihar")
                    _cariHareket._tempCARIKART = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FMusteriSiparis")
                    _fmusteriSiparis._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FSatinAlmaSiparis")
                    fSatinAlmaSiparis._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FSatisIrsaliye")
                    fSatisIrsaliye._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FAlisIrsaliye")
                    fAlisIrsaliye._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FFatura")
                    ffatura._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                else if (_islem == "FAlisFatura")
                    fAlisFatura._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FStokFiyat")
                    fStokFiyat._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FCariHareketRaporu")
                    fCariHareketRaporu._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FStokKasaHareketRaporu")
                    fStokKasaHareketRaporu._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FStokFiyatRaporu")
                    fStokFiyatRaporu._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FFaturaRaporu")
                    fFaturaRaporu._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FCariRaporu")
                    fCariRaporu._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FMusteriSiparisRaporu")
                    fMusteriSiparisRaporu._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FCariDurum")
                    fCariDurum._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FKasaHareket")
                    fKasaHareket._tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if(_islem== "FFirmaCekTanim")
                    _firmaCekTanim.tempCari= _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FMusteriCekTanim")
                    fMusteriCekTanim.tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FFirmaSenetTanim")
                    fFirmaSenet.tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if(_islem== "FHesapHareket")
                    fHesapHareket._tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                 if(_islem== "EFaturaGelenKutu")
                    fefatura._tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "EIrsaliyeGelenKutu")
                    fGELENIRSALIYE._tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();

                if (_islem == "FMusteriCekCariCiro")
                    FMusteriCekCariCiro._tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                if (_islem == "FMusteriSenetCariCiro")
                    FMusteriSenetCariCiro._tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
             if (_islem == "EFaturaGidenEsle")
                    fGindeFaturaEşleştir._tempCari = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            
            }
            else
            {
                XtraTabPage page = new XtraTabPage();
                fCariKart = new FCariKart();
                page.Name = "TPCariKart" + i;
                page.Text = "Cari Kart";
                page.Tag = "TPCariKart2" + i;
                page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;

                main.Anasayfa.TabPages.Add(page);
                main.Anasayfa.SelectedTabPage = page;

                fCariKart.TopLevel = false;
                fCariKart.AutoScroll = true;
                fCariKart.Tag = "TPCariKart2" + i;
                fCariKart.Dock = DockStyle.Fill;
                page.Controls.Add(fCariKart);
                fCariKart._tempCariKart = _cariServis.obje.Where(x => x.id.ToString() == gridView1.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                fCariKart.Show();
                i++;
            }
            this.Close();
        }

        private void DGCariList_Load(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (_form == frm.Tag)
                    {
                        if (frm.Name.Contains("FCariKart"))
                            fCariKart = (FCariKart)frm;
                        if (frm.Name.Contains("FCariHareketRaporu"))
                            fCariHareketRaporu = (FCariHareketRaporu)frm;
                        else if (frm.Name.Contains("FCariHareket"))
                            _cariHareket = (FCariHareket)frm;
                        if (frm.Name.Contains("FMusteriSiparisRaporu"))
                            fMusteriSiparisRaporu = (FMusteriSiparisRaporu)frm;
                        else if (frm.Name.Contains("FMusteriSiparis"))
                            _fmusteriSiparis = (FMusteriSiparis)frm;
                        if (frm.Name.Contains("SatinAlmaSiparis"))
                            fSatinAlmaSiparis = (FSatinAlmaSiparis)frm;
                        if (frm.Name.Contains("FSatisIrsaliye"))
                            fSatisIrsaliye = (FSatisIrsaliye)frm;
                        if (frm.Name.Contains("AlisIrsaliye"))
                            fAlisIrsaliye = (FAlisIrsaliye)frm;
                        if (frm.Name.Contains("FFaturaRaporu"))
                            fFaturaRaporu = (FFaturaRaporu)frm;
                        else if (frm.Name.Contains("FFatura"))
                            ffatura = (FFatura)frm;
                        if (frm.Name.Contains("FAlisFatura"))
                            fAlisFatura = (FAlisFatura)frm;
                        if (frm.Name.Contains("FStokFiyatRaporu"))
                            fStokFiyatRaporu = (FStokFiyatRaporu)frm;
                        else if (frm.Name.Contains("FStokFiyat"))
                            fStokFiyat = (FStokFiyat)frm;
                        if (frm.Name.Contains("FStokKasaHareketRaporu"))
                            fStokKasaHareketRaporu = (FStokKasaHareketRaporu)frm;
                        if (frm.Name.Contains("FCariRaporu"))
                            fCariRaporu = (FCariRaporu)frm; 
                        if (frm.Name.Contains("FCariDurum"))
                            fCariDurum = (FCariDurum)frm;
                        if (frm.Name.Contains("FKasaHareket"))
                            fKasaHareket = (FKasaHareket)frm;
                        if (frm.Name.Contains("FFirmaSenetTanim"))
                            fFirmaSenet = (FFirmaSenetTanim)frm;
                        if (frm.Name.Contains("FHesapHareket"))
                            fHesapHareket = (FHesapHareket)frm;
                        if (frm.Name.Contains("FFirmaCekTanim"))
                            _firmaCekTanim = (FFirmaCekTanim)frm;
                        if (frm.Name.Contains("FMusteriCekTanim"))
                            fMusteriCekTanim = (FMusteriCekTanim)frm;
                        if (frm.Name.Contains("EFATURA"))
                            fefatura = (EFATURA)frm;
                        if (frm.Name.Contains("FGELENIRSALIYE"))
                            fGELENIRSALIYE = (FGELENIRSALIYE)frm;
                        if (frm.Name.Contains("FMusteriCekCariCiro"))
                            FMusteriCekCariCiro = (FMusteriCekCariCiro)frm;
                        if (frm.Name.Contains("FMusteriSenetCariCiro"))
                            FMusteriSenetCariCiro = (FMusteriSenetCariCiro)frm;
                        if (frm.Name.Contains("FGindeFaturaEşleştir"))
                            fGindeFaturaEşleştir = (FGindeFaturaEşleştir)frm;
                    }
                }
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name.Contains("Main"))
                        main = (Main)frm;
                }

            }

            _cariServis.Data(ServisList.CariListeServis);
            DGCariList.DataSource = _cariServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                CARIKODU = x.kod,
                CARIUNVAN = x.unvan,
                CARİADI = x.adi,
                CARİSOYADI = x.soyadi,
                VERGIDAIRESI = x.vergidairesi,
                VERGINO = x.vergino,
                TC = x.tcno,
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
