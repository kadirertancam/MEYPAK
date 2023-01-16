using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using MEYPAK.PRL.CARI;

namespace MEYPAK.PRL.BANKA
{
    public partial class FHesapHareket : XtraForm
    {
        public FHesapHareket()
        {
            InitializeComponent();
            _subeServis = new GenericWebServis<PocoBANKASUBE>();
            _bankaServis = new GenericWebServis<PocoBANKA>();
            _hesapServis = new GenericWebServis<PocoBANKAHESAP>();
            _hesapHarServis = new GenericWebServis<PocoHESAPHAREKET>();
            _cariHarServis = new GenericWebServis<PocoCARIHAR>();
            _cariAltHesServis = new GenericWebServis<PocoCARIALTHES>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
        }

        GenericWebServis<PocoBANKASUBE>     _subeServis; 
        GenericWebServis<PocoBANKA>         _bankaServis;
        GenericWebServis<PocoBANKAHESAP>    _hesapServis;
        GenericWebServis<PocoHESAPHAREKET>  _hesapHarServis;
        GenericWebServis<PocoCARIHAR>  _cariHarServis;
        GenericWebServis<PocoCARIALTHES>  _cariAltHesServis;
        GenericWebServis<PocoCARIALTHESCARI>  _cariAltHesCariServis;
        public PocoCARIKART _tempCari;

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            if (CBBanka.EditValue!=null && CBSube.EditValue!=null&& CBHesap.EditValue!=null && decimal.TryParse(TBTutar.Text,out decimal a)&& CBIslemTur.SelectedText!=""&&_tempCari!=null&& lookUpEdit1.EditValue!="")
            {
               
                _hesapHarServis.Data(ServisList.HesapHarEkleServis, new PocoHESAPHAREKET()
                {
                    HESAPID =Convert.ToInt32( CBHesap.EditValue),
                    IO= Convert.ToByte(radioGroup2.SelectedIndex),
                    MIKTAR = Convert.ToDecimal(TBTutar.Text),
                    ISLEMTURU = CBIslemTur.SelectedText,
                    ACIKLAMA = TBAciklama.Text,
                    CARIID = _tempCari.id,
                    ALTHESCARIID = Convert.ToInt32(lookUpEdit1.EditValue),
                    
                });
                _cariHarServis.Data(ServisList.CariHarEkleServis, new PocoCARIHAR()
                {
                    carialthesapid = Convert.ToInt32(lookUpEdit1.EditValue),
                    cariid = _tempCari.id,
                    tutar = Convert.ToDecimal(TBTutar.Text),
                    harekettipi = 0
                });
                MessageBox.Show("Hareket Başarıyla Eklendi.");
                GridiDoldur();
                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Gerekli Bilgileri Girmeden Hareket Ekleyemezsiniz!");
            }
        }

        private void CBBanka_EditValueChanged(object sender, EventArgs e)
        {
            _subeServis.Data(ServisList.BANKASubeListeServis);
            CBSube.Properties.DataSource = _subeServis.obje.Where(x => x.BANKAID == Convert.ToInt32(CBBanka.EditValue)).Select(x => new { ID = x.id, x.KODU, x.ADI });
            CBSube.Properties.ValueMember = "ID";
            CBSube.Properties.DisplayMember = "ADI";
            CBSube.Properties.PopulateColumns();
            CBSube.Properties.Columns["ID"].Visible = false;
        }

        private void CBSube_EditValueChanged(object sender, EventArgs e)
        {
            _hesapServis.Data(ServisList.BANKAHesapListeServis);
            CBHesap.Properties.DataSource = _hesapServis.obje.Where(x => x.SUBEID == Convert.ToInt32(CBSube.EditValue)).Select(x => new { ID = x.id, x.KOD, x.ADI});
            CBHesap.Properties.ValueMember = "ID";
            CBHesap.Properties.DisplayMember = "ADI";
            CBHesap.Properties.PopulateColumns();
            CBHesap.Properties.Columns["ID"].Visible = false;
        }

        void HesaplariDoldur()
        {
            _bankaServis.Data(ServisList.BANKAListeServis);
            CBBanka.Properties.DataSource = _bankaServis.obje.Select(x => new { ID = x.id, KODU = x.kod, ADI = x.adi});
            CBBanka.Properties.ValueMember = "ID";
            CBBanka.Properties.DisplayMember = "ADI";
            CBBanka.Properties.PopulateColumns();
            CBBanka.Properties.Columns["ID"].Visible = false;

        }

        private void FHesapHareket_Load(object sender, EventArgs e)
        {
            HesaplariDoldur();
        }

        private void CBHesap_EditValueChanged(object sender, EventArgs e)
        {
           GridiDoldur();
        }
        void GridiDoldur()
        {
            _hesapHarServis.Data(ServisList.HesapHarListeServis);
            gridControl1.DataSource = _hesapHarServis.obje.Where(x => x.HESAPID == Convert.ToInt32(CBHesap.EditValue));
        }

        void FormuTemizle()
        {
            foreach (var ctrl in groupControl1.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in groupControl4.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }
            foreach (var ctrl in groupControl5.Controls)
            {
                BaseEdit editor = ctrl as BaseEdit;
                if (editor != null)
                    editor.EditValue = null;
            }

        }

        private void BTCari_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FCariList fCariList = new FCariList(this.Tag.ToString(), "FHesapHareket");
            fCariList.ShowDialog();

            if (_tempCari != null)
            {
                BTCari.Text = _tempCari.kod;
                TBCariAdi.Text = _tempCari.unvan;
                _cariAltHesServis.Data(ServisList.CariAltHesListeServis);
                _cariAltHesCariServis.Data(ServisList.CariAltHesCariListeServis);

                lookUpEdit1.Properties.DataSource = _cariAltHesCariServis.obje.Where(x => x.cariid == _tempCari.id).Select(x => new
                {
                    ID= x.carialthesid,
                    ADI = _cariAltHesServis.obje.Where(y=> y.id == x.carialthesid).FirstOrDefault().adi
                });
                lookUpEdit1.Properties.DisplayMember = "ADI";
                lookUpEdit1.Properties.ValueMember = "ID";
                lookUpEdit1.Properties.PopulateColumns();
                lookUpEdit1.Properties.Columns["ID"].Visible= false;

            }
        }
    }
}
