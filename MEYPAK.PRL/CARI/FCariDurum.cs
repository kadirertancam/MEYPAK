using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.SIPARIS;
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
    public partial class FCariDurum : XtraForm
    {
        public FCariDurum()
        {
            InitializeComponent();
            _cariDurumServis = new GenericWebServis<PocoCARIKART>();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();
            _cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
        }
       GenericWebServis<PocoCARIKART> _cariDurumServis;
       GenericWebServis<PocoCARIHAR> _cariHarServis;
       GenericWebServis<PocoCARIALTHES> _cariAltHesServis;
       GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        FCariList fCariList; 
        public PocoCARIKART _tempCariKart;
        private void BTKoduSec_Properties_ButtonClick(object sender, EventArgs e)
        {
            
        }
        void Doldur()
        {
            TBAdi.Text = _tempCariKart.unvan;
            BTKoduSec.Text = _tempCariKart.kod;
            List<PocoCARIALTHES> altcarilist = new List<PocoCARIALTHES>();
            _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
            // CBAltHesap.Properties.DataSource = _cariAltHesapServis.obje.Where(x=>x.cariid==_tempCariKart.id).Select(x => x.adi).ToList();
            _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);
            foreach (var item in _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCariKart.id))
            {
                altcarilist.Add(_cariAltHesServis.obje.Where(x => x.kayittipi == 0 && x.id == item.carialthesid).FirstOrDefault());
            }
            CBAltHesap.Properties.ValueMember = "ID";
            CBAltHesap.Properties.DisplayMember = "ADI";
            CBAltHesap.Properties.DataSource = altcarilist.Select(x => new { ID = x.id, ADI = x.adi.ToString() });
            CBAltHesap.EditValue = altcarilist.FirstOrDefault().id;


            _cariHarServis.Data(ServisList.CariHarListeServis);
            DGCariDurum.DataSource = _cariHarServis.obje.Where(x => x.cariid == _tempCariKart.id && CBAltHesap.EditValue.ToString()==x.carialthesapid.ToString());
        }
        private void BTKoduSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            fCariList = new FCariList(this.Tag.ToString(), "FCariDurum");
            fCariList.ShowDialog();
            Doldur();
            _siparisServis.Data(ServisList.SiparisListeServis);
            LBBekleyenSiparis.Text = _siparisServis.obje.Where(x => x.cariid == _tempCariKart.id && x.durum == false).Sum(x => x.geneltoplam).ToString();
        }

        private void CBAltHesap_EditValueChanged(object sender, EventArgs e)
        {
            _cariHarServis.Data(ServisList.CariHarListeServis);
            var tempp = _cariHarServis.obje.Where(x => x.cariid == _tempCariKart.id && CBAltHesap.EditValue.ToString() == x.carialthesapid.ToString());

            DGCariDurum.DataSource = tempp;
            LBAlacakDeger.Text = tempp.Sum(x => x.alacak).ToString();
            LBBorcDeger.Text = tempp.Sum(x => x.borc).ToString();
            LBToplamDeger.Text = tempp.Sum(x => x.tutar).ToString();
            DGCariDurum.RefreshDataSource();
        }
    }
}
