using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Text.Interop;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Native;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using MEYPAK.PRL.CARI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.CEKSENET
{
    public partial class FMusteriCekTanim : XtraForm
    {
        public FMusteriCekTanim()
        {
            InitializeComponent();
            
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();
            _musteriCekServis = new GenericWebServis<PocoMUSTERICEKSB>();
            gridView1.OptionsNavigation.AutoMoveRowFocus = true;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            _tempMCekSb = new List<PocoMusteriCekKalem>();
        }

        #region Tanımlar
       
        GenericWebServis<PocoMUSTERICEKSB> _musteriCekServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIHAR> _cariHarServis;
        FCariList _fCariList;
        List<PocoMusteriCekKalem> _tempMCekSb;
        public PocoCARIKART _tempCariKart;





        #endregion
        #region Metotlar

        public void Doldur()
        {
            DGMusteriCek.DataSource = _cariHarServis.obje.Where(x => x.cariid == _tempCariKart.id);
            LBAlacakDeger.Text = _cariHarServis.obje.Where(x => x.cariid == _tempCariKart.id).Sum(x => x.alacak).ToString();
            LBBorcDeger.Text = _cariHarServis.obje.Where(x => x.cariid == _tempCariKart.id).Sum(x => x.borc).ToString();
            LBBakiye.Text = _cariHarServis.obje.Where(x => x.cariid == _tempCariKart.id).Sum(x => x.borc - x.alacak).ToString();
        }

        void DataGridYapilandir()
        {
            _tempMCekSb.Add(new PocoMusteriCekKalem());
            DGMusteriCek.DataSource = _tempMCekSb;

            
        }
        private void BTBordroSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void BTCariSec_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _fCariList = new FCariList(this.Tag.ToString(), "FMusteriCekTanim");
            _fCariList.ShowDialog();
            if (_tempCariKart != null)
            {
                BTCariSec.Text = _tempCariKart.kod;
                TBCariAdi.Text = _tempCariKart.unvan == "" ? _tempCariKart.adi + " " + _tempCariKart.soyadi : _tempCariKart.unvan;
            }
        }

        #endregion

        private void FMusteriCekTanim_Load(object sender, EventArgs e)
        {
            DataGridYapilandir();
            Doldur();
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                _tempMCekSb.Add(new PocoMusteriCekKalem());
                DGMusteriCek.RefreshDataSource();
            }
        }
    }
}
