﻿using DevExpress.DirectX.Common.Direct2D;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.Interfaces.Stok;
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

namespace MEYPAK.PRL.CARI.Raporlar
{
    public partial class FCariHareketRaporu : XtraForm
    {
        public FCariHareketRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _althesapServis = new GenericWebServis<PocoCARIALTHES>();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();

            _form = tag;
            _islem = islem;

        }
        string _form, _islem;
        #region Tanımlar
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHES> _althesapServis;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;
        public PocoCARIKART _tempCariKart;
        public PocoCARIHAR _tempCariHar;
        public PocoCARIALTHES _tempAltHesap;


        #endregion

        #region Metotlar

        private void FCariHareketRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            _cariHarServis.Data(ServisList.CariHarListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            _althesapServis.Data(ServisList.CariAltHesListeServis);
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);
            GridiDoldur(_cariHarServis.obje);
            DGCariHareketRpr.RefreshDataSource();
        }

        private void BTAltHesapSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FAltHesapList fAltHesapList = new FAltHesapList(this.Tag.ToString(), "FCariHareketRaporu");
            fAltHesapList.ShowDialog();
            if (_tempAltHesap != null)
                BTAltHesapSec.Text = _tempAltHesap.adi;

            GridiDoldur(Filtrele());

        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FCariHareketRaporu");
            fCariList.ShowDialog();
            if (_tempCariKart != null)
                BTCariSec.Text = _tempCariKart.unvan;

           GridiDoldur(Filtrele());


        }

        void GridiDoldur(List<PocoCARIHAR> A)
        {
            DGCariHareketRpr.DataSource = A.Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                HAREKETTARİHİ = x.harekettarihi,
                CARİHAREKET = x.belgE_NO,
                AÇIKLAMA =  x.aciklama,
                TİPİ = x.harekettipi,
                CARİ = _cariServis.obje.Where(y => y.id == x.cariid).Count() > 0 ? _cariServis.obje.Where(y => y.id == x.cariid).FirstOrDefault().unvan : "",
                ALTHESAP = _althesapServis.obje.Where(y => y.id == x.carialthesapid).Count() > 0 ? _althesapServis.obje.Where(y => y.id == x.carialthesapid).FirstOrDefault().adi : "",
                PARABİRİMİ = _paraBirimServis.obje.Where(y => y.id == x.parabirimid).Count() > 0 ? _paraBirimServis.obje.Where(y => y.id == x.parabirimid).FirstOrDefault().adi : "",
                KUR = x.kur,
                BORÇ = x.borc,
                ALACAK = x.alacak,
                TUTAR = x.tutar,
                GÜNCELLEMETARİHİ = x.guncellemetarihi

            }).ToList();
        }

        List<PocoCARIHAR> Filtrele()
        {
            List<PocoCARIHAR> filtre = new List<PocoCARIHAR>();
            if (BTCariSec.Text != "" && _tempCariKart != null)
                filtre.AddRange(_cariHarServis.obje.Where(x=> x.cariid==_tempCariKart.id));
            else if (BTAltHesapSec.Text != "" && _tempAltHesap != null)
                filtre.AddRange(_cariHarServis.obje.Where(x => x.carialthesapid == _tempAltHesap.id));
            
            else
                return _cariHarServis.obje;

            return filtre;
        }
        #endregion
    }
}

     

