using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.BANKA;

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
        }

        GenericWebServis<PocoBANKASUBE> _subeServis; 
        GenericWebServis<PocoBANKA> _bankaServis;
        GenericWebServis<PocoBANKAHESAP> _hesapServis;
        GenericWebServis<PocoHESAPHAREKET> _hesapHarServis;

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            if (CBBanka.EditValue!=null && CBSube.EditValue!=null&& CBHesap.EditValue!=null && decimal.TryParse(TBTutar.Text,out decimal a)&& CBIslemTur.SelectedText!="")
            {
                _hesapHarServis.Data(ServisList.HesapHarEkleServis, new PocoHESAPHAREKET()
                {
                    HESAPID =Convert.ToInt32( CBHesap.EditValue),
                    IO= Convert.ToByte(radioGroup2.SelectedIndex),
                    MIKTAR = Convert.ToDecimal(TBTutar.Text),
                    ISLEMTURU = CBIslemTur.SelectedText,
                    ACIKLAMA = TBAciklama.Text,
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
    }
}
