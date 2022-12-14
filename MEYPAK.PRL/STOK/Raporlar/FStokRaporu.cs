using DevExpress.DirectX.Common.Direct2D;
using DevExpress.PivotGrid.ServerMode.Queryable;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.Html;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
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

namespace MEYPAK.PRL.STOK.Raporlar
{
    public partial class FStokRaporu : XtraForm
    {
        public FStokRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _stokServis = new GenericWebServis<PocoSTOK>();
            _markaServis = new GenericWebServis<PocoSTOKMARKA>();
            _olcuBirimServis = new GenericWebServis<PocoOLCUBR>();
            _kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
        }

        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKMARKA> _markaServis;
        GenericWebServis<PocoOLCUBR> _olcuBirimServis;
        GenericWebServis<PocoSTOKKATEGORI> _kategoriServis;
        public PocoSTOK _tempStok;
        public PocoSTOKMARKA _tempMarka;
        public PocoSTOKKATEGORI _tempKategori;
        #endregion
        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FStokList fStokList = new FStokList(this.Tag.ToString(), "FStokRaporu");
            fStokList.ShowDialog();
            if(_tempStok != null)
                BTStokSec.Text = _tempStok.adi;

            GridiDoldur(Filtrele());
        }

        private void FStokListesiRaporu_Load(object sender, EventArgs e)
        {

            Doldur();
        }

        private void BTKateSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FKategoriList fKategoriList = new FKategoriList(this.Tag.ToString(), "FStokListesiRaporu");
            fKategoriList.ShowDialog();
            if (_tempKategori != null)
                BTKateSec.Text = _tempKategori.acıklama;
            GridiDoldur(Filtrele());
        }

        private void BTMarkaSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FMarkaList fMarkaList = new FMarkaList(this.Tag.ToString(), "FStokListesiRaporu");
            fMarkaList.ShowDialog();
            if (_tempMarka != null)
                BTMarkaSec.Text = _tempMarka.adi;

            GridiDoldur(Filtrele());


        }
        List<PocoSTOK> Filtrele()
        {
            List<PocoSTOK> filtre = new List<PocoSTOK>();
            if (BTStokSec.Text!="" && _tempStok!=null)
                filtre.Add(_tempStok);
            else if (BTKateSec.Text!="" && _tempKategori!=null)
                filtre.AddRange(_stokServis.obje.Where(x=>x.kategoriid==_tempKategori.id));
            else if (BTMarkaSec.Text!="" && _tempMarka!=null)
                filtre.AddRange(_stokServis.obje.Where(x => x.markaid == _tempMarka.id));
            else
                return _stokServis.obje;


            return filtre;
        }

        private void BTRaporla_Click(object sender, EventArgs e)
        {
            
        }
        void GridiDoldur(List<PocoSTOK> A)
        {
            DGStokRpr.DataSource= A.Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                KOD = x.kod,
                ADI = x.adi,
                KATEGORİ = _kategoriServis.obje.Where(y => y.id == x.kategoriid).Count() > 0 ? _kategoriServis.obje.Where(y => y.id == x.kategoriid).FirstOrDefault().acıklama : "",
                ÖLÇÜBİRİMİ = _olcuBirimServis.obje.Where(y => y.id == x.olcubR1).Count() > 0 ? _olcuBirimServis.obje.Where(y => y.id == x.olcubR1).FirstOrDefault().adi : "",
                MARKA = _markaServis.obje.Where(y => y.id == x.markaid).Count() > 0 ? _markaServis.obje.Where(y => y.id == x.markaid).FirstOrDefault().adi : "",
                ALIŞKDV = x.aliskdv,
                SATIŞKDV = x.satiskdv,
                ALIŞÖTV = x.alisotv,
                SATIŞÖTV = x.satisotv,
                ALIŞFİYATI1 = x.afiyaT1,
                ALIŞFİYATI2 = x.afiyaT2,
                ALIŞFİYATI3 = x.afiyaT3,
                ALIŞFİYATI4 = x.afiyaT4,
                ALIŞFİYATI5 = x.afiyaT5,
                SATIŞFİYATI = x.sfiyaT1,
                SATIŞFİYATI2 = x.sfiyaT2,
                SATIŞFİYATI3 = x.sfiyaT3,
                SATIŞFİYATI4 = x.sfiyaT4,
                SATIŞFİYATI5 = x.sfiyaT5,
                RAPORKODU = x.raporkodu,
                RAPORKODU1 = x.raporkodU1,
                RAPORKODU2 = x.raporkodU2,
                RAPORKODU3 = x.raporkodU3,
                RAPORKODU4 = x.raporkodU4,
                RAPORKODU5 = x.raporkodU5,
                RAPORKODU6 = x.raporkodU6,
                RAPORKODU7 = x.raporkodU7,
                RAPORKODU8 = x.raporkodU8,
                RAPORKODU9 = x.raporkodU9,
                GRUPKODU = x.grupkodu,

            }).ToList();
        }

        
        void Doldur()
        {
            _markaServis.Data(ServisList.StokMarkaListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _olcuBirimServis.Data(ServisList.OlcuBrListeServis);
            _kategoriServis.Data(ServisList.StokKategoriListeServis);
            GridiDoldur(_stokServis.obje);
            DGStokRpr.RefreshDataSource();
             
        }

        

  
    }
}
