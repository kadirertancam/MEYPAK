using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
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
    public partial class FStokSayimRaporu : XtraForm
    {
        public FStokSayimRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokSayimServis = new GenericWebServis<PocoSTOKSAYIM>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _form = tag;
            _islem = islem;
        }

        #region Tanımlar
        string _form, _islem;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSTOKSAYIM> _stokSayimServis;
        GenericWebServis<PocoDEPO> _depoServis;
        public PocoSTOK _tempStok;
        #endregion
        private void FStokSayimRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _tempStok = null;
            FStokList fStokList = new FStokList(this.Tag.ToString(), "stoksayim");
            fStokList.ShowDialog();
            Doldur();
        }

        void Doldur()
        {
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            _stokSayimServis.Data(ServisList.StokSayimListeServis);
            
            DGStokSayimRpr.DataSource = _stokSayimServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                SAYIMTARİHİ = x.sayimtarihi,
                Açıklama = x.aciklama,
                DEPO = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().depoadi : "",
                FİRMA = x.firmaid,
                ŞUBE = x.subeid,

                

            });
            DGStokSayimRpr.Refresh();
            DGStokSayimRpr.RefreshDataSource();
        }
    }
}
