using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
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

namespace MEYPAK.PRL.DEPO.Raporlar
{
    public partial class FStokSevkiyatRaporu : XtraForm
    {
        public FStokSevkiyatRaporu(string tag = "", string islem = "")
        {
            InitializeComponent();
            _stokSevkiyatServis = new GenericWebServis<PocoSTOKSEVKIYATLIST>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _olcuBirimServis = new GenericWebServis<PocoOLCUBR>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
           
            _form = tag;
            _islem = islem;
        }

        #region Tanımlar
        GenericWebServis<PocoSTOKSEVKIYATLIST> _stokSevkiyatServis;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoOLCUBR> _olcuBirimServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;


        public PocoSTOK _tempStok;
        public PocoDEPO _tempDepo;
        string _islem, _form;
        #endregion


        #region Metotlar
        private void BTStokSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FStokList fStokList = new FStokList(this.Tag.ToString(), "FStokSevkiyatRaporu");
            fStokList.ShowDialog();
        }

        private void FStokSevkiyatRaporu_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void BTDepoSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FDepoList fDepoList = new FDepoList(this.Tag.ToString(), "FStokSevkiyatRaporu");
            fDepoList.ShowDialog();
        }

        void Doldur()
        {
            _stokServis.Data(ServisList.StokListeServis);
            _stokSevkiyatServis.Data(ServisList.StokSevkiyatListListeServis);
            _depoServis.Data(ServisList.DepoListeServis);
            _olcuBirimServis.Data(ServisList.OlcuBrListeServis);
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            DGStokSevkiyatRpr.DataSource = _stokSevkiyatServis.obje.Where(x => x.kayittipi == 0).Select(x => new
            {
                ID = x.id,
                KAYITTARİHİ = x.olusturmatarihi,
                STOKADI = _stokServis.obje.Where(y => y.id == x.stokid).Count() > 0 ? _stokServis.obje.Where(y => y.id == x.stokid).FirstOrDefault().adi : "",
                DEPOADI = _depoServis.obje.Where(y => y.id == x.depoid).Count() > 0 ? _depoServis.obje.Where(y => y.id == x.depoid).FirstOrDefault().depoadi : "",
                BİRİM = _olcuBirimServis.obje.Where(y => y.id == x.birimid).Count() > 0 ? _olcuBirimServis.obje.Where(y => y.id == x.birimid).FirstOrDefault().adi : "",
                SİPARİŞDETAY = _siparisDetayServis.obje.Where(y => y.id == x.siparisdetayid).Count() > 0 ? _siparisDetayServis.obje.Where(y => y.id == x.siparisdetayid).FirstOrDefault().aciklama : "",
                MİKTAR = x.miktar,
                SİPARİŞMİKTARI = x.siparismiktari,
                KALANMİKTAR = x.kalanmiktar,
                SEVKEMİRHAREKETİ = x.sevkemriharid,
                EMİRID = x.emirid,
                KULLANICIID = x.kullaniciid,
                ŞİRKETID = x.sirketid,
                ŞUBEID = x.subeid,
                GÜNCELLEMETARİHİ = x.guncellemetarihi,
            });
            DGStokSevkiyatRpr.Refresh();
            DGStokSevkiyatRpr.RefreshDataSource();

        }

        #endregion
    }
}
