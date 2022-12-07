using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
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
    public partial class FStokKategoriRaporu : XtraForm
    {
        public FStokKategoriRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _form = tag;
            _islem = islem;
            _kategoriServis = new GenericWebServis<PocoSTOKKATEGORI>();
        }

        string _form, _islem;
        #region Tanımlar
        GenericWebServis<PocoSTOKKATEGORI> _kategoriServis;

        private void FStokKategoriRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        #endregion

        #region Metotlar

        void Doldur()
        {
            _kategoriServis.Data(ServisList.StokKategoriListeServis);
            DGKategoriRpr.DataSource = _kategoriServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                KATEGORİADI  = x.acıklama,
                ÜSTKATEGORİ = x.ustId,
                ALTKATEGORİ = x.altID,
                KAYITTARİHİ = x.olusturmatarihi,
                DÖNEM =x.donem,

            });
            DGKategoriRpr.Refresh();
            DGKategoriRpr.RefreshDataSource();
            #endregion
        }
        }
}
