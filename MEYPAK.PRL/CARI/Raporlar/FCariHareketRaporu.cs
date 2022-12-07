using DevExpress.DirectX.Common.Direct2D;
using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
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
            _cariHarServis.Data(ServisList.CariHarListeServis);
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _form = tag;
            _islem = islem;

        }
        string _form, _islem;
        #region Tanımlar
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        public PocoCARIKART _tempCariKart;
        public PocoCARIHAR _tempCariHar;

        #endregion

        #region Metotlar

        void Doldur()
        {
            _cariHarServis.Data(ServisList.CariHarListeServis);
            DGCariHareketRpr.DataSource = _cariHarServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                CARIID = _tempCariHar.id,
                //TODO : CariHareket düzenlemesi sonrası yapılandırılıcak

            });
            DGCariHareketRpr.Refresh();
            DGCariHareketRpr.RefreshDataSource();
        }
            private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FCariHareketRaporu");
            fCariList.ShowDialog();

        } 
        #endregion
    }
}

     

