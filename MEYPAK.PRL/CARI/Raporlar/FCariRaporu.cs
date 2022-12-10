using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Fatura;
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
    public partial class FCariRaporu : XtraForm
    {
        public FCariRaporu(string tag="", string islem="")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _stokKategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
        }

        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoSTOKKATEGORI> _stokKategoriServis;
        public PocoCARIKART _tempCariKart;
        public PocoSTOKKATEGORI _tempKategori;
        #endregion
        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FCariRaporu");
            fCariList.ShowDialog();
        }

        private void FCariRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void BTKateSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FKategoriList fKategoriList = new FKategoriList(this.Tag.ToString(), "FCariRaporu");
            fKategoriList.ShowDialog();
        }

        void Doldur()
        {
            _cariServis.Data(ServisList.CariListeServis);
            _stokKategoriServis.Data(ServisList.StokKategoriListeServis);
            DGCariRpr.DataSource = _cariServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                CARİTİPİ = x.tipi,
                CARİKODU = x.kod,
                CARİADISOYADI = x.adi + " " + x.soyadi,
                AÇIKLAMA = x.aciklama,
                TCNO = x.tcno,
                UNVAN = x.unvan,
                VERGİDAİRESİ = x.vergidairesi,
                VERGİNO = x.vergino,
                ULKE = x.ulke,
                İL = x.il,
                İLÇE = x.ilce,
                MAHALLE = x.mahalle,
                SOKAK = x.sokak,
                APT = x.apt,
                DAİRE = x.daire,
                ADRES = x.adres,
                POSTAKODU = x.postakod,
                CEPTELEFONU = x.ceptel,
                TELEFON = x.telefon,
                TELEFON2 = x.telefoN2,
                FAX = x.fax,
                WEBSİTESİ = x.web,
                EPOSTA = x.eposta,
                KATEGORİADI = x.kategori.ToString(),
                GRUPKODU = x.grupkodu,
                FİYATNUM = x.fiyatnum,
                VADEGÜNÜ = x.vadegunu,
                MUHASEBEKODU = x.muH_KOD,
                ALIŞMUHASEBE = x.amuhkod,
                SATIŞMUHASEBE = x.smuhkod,
                AÇIKLAMA1 = x.aciklamA1,
                AÇIKLAMA2 = x.aciklamA2,
                AÇIKLAMA3 = x.aciklamA3,
                AÇIKLAMA4 = x.aciklamA4,
                AÇIKLAMA5 = x.aciklamA5,
                AÇIKLAMA6 = x.aciklamA6,
                AÇIKLAMA7 = x.aciklamA7,
                AÇIKLAMA8 = x.aciklamA8,
                AÇIKLAMA9 = x.aciklamA9,
                SYSAÇIKLAMA1 = x.saciklamA1,
                SYSAÇIKLAMA2 = x.saciklamA2,
                SYSAÇIKLAMA3 = x.saciklamA3,
                SYSAÇIKLAMA4 = x.saciklamA4,
                SYSAÇIKLAMA5 = x.saciklamA5,
                SYSAÇIKLAMA6 = x.saciklamA6,
                SYSAÇIKLAMA7 = x.saciklamA7,
                SYSAÇIKLAMA8 = x.saciklamA8,
                SYSAÇIKLAMA9 = x.saciklamA9,
                RAPORKODU1 = x.raporkoD1,
                RAPORKODU2 = x.raporkoD2,   
                RAPORKODU3 = x.raporkoD3,
                RAPORKODU4 = x.raporkoD4,
                RAPORKODU5 = x.raporkoD5,
                RAPORKODU6 = x.raporkoD6,
                RAPORKODU7 = x.raporkoD7,   
                RAPORKODU8 = x.raporkoD8,
                RAPORKODU9 = x.raporkoD9,   
                KAYITTİPİ = x.kayittipi,
                GÜNCELLEMETARİHİ = x.guncellemetarihi
                     
            });
            DGCariRpr.Refresh();
            DGCariRpr.RefreshDataSource();



        }
    }
}
