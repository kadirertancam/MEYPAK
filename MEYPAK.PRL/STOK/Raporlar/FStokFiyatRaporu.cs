using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.CARI;
using DevExpress.XtraReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEYPAK.Entity.PocoModels.CARI;

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokFiyatRaporu : XtraForm
    {
        public FStokFiyatRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
          
            _stokFiyatServis = new GenericWebServis<PocoSTOKFIYAT>();
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _form = tag;
            _islem = islem;
        }
        string _form, _islem;
        #region Tanımlar
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKFIYAT> _stokFiyatServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        public PocoSTOK _tempStok;
        public PocoCARIKART _tempCariKart;
        public PocoSTOKFIYATHAR _tempStokFiyatHar;
       
        #endregion

        #region Metotlar

        void Doldur()
        {
            _stokFiyatServis.Data(ServisList.StokFiyatListeServis);
            _cariServis.Data(ServisList.CariListeServis);
            GridiDoldur(_stokFiyatServis.obje);
            DGStokFiyatRpr.RefreshDataSource();

        }
       
        private void FStokFiyatRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
            
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FStokFiyatRaporu");
            fCariList.ShowDialog();
            if (_tempCariKart != null)
                BTCariSec.Text = _tempCariKart.unvan;

           GridiDoldur(Filtrele());

        }
        List<PocoSTOKFIYAT> Filtrele()
        {
            List<PocoSTOKFIYAT> filtre = new List<PocoSTOKFIYAT>();
            if (BTCariSec.Text != "" && _tempCariKart != null)
                filtre.AddRange(_stokFiyatServis.obje.Where(x => x.cariid == _tempCariKart.id));
          
            else
                return _stokFiyatServis.obje;


            return filtre;
        }

        private void BTRaporla_Click(object sender, EventArgs e)
        {
            
        }
        void GridiDoldur(List<PocoSTOKFIYAT> A)
        {
            DGStokFiyatRpr.DataSource = A.Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                FİYATLİSTESİADI = x.adi,
                AÇIKLAMA = x.aciklama,
                CARİADI = _cariServis.obje.Where(y => y.id == x.cariid).Count() > 0 ? _cariServis.obje.Where(y => y.id == x.cariid).FirstOrDefault().unvan : "",
                BASLANGIÇTARİHİ = x.baslangictarihi,
                BİTİŞTARİHİ = x.bitistarihi,
                FİRMAID = x.firmaid,
                ŞUBEID = x.subeid,
                GÜNCELLEMETARİHİ = x.guncellemetarihi


            }).ToList();
        }

        #endregion



    }
}
