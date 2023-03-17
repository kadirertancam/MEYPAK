using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.BANKA;

namespace MEYPAK.PRL.BANKA
{
    public partial class FBankaSubeTanim : XtraForm
    {
        public FBankaSubeTanim()
        {
            InitializeComponent();
            _bankaServis = new GenericWebServis<PocoBANKA>();
            _bankaSubeServis = new GenericWebServis<PocoBANKASUBE>();
        }
        GenericWebServis<PocoBANKA> _bankaServis;
        GenericWebServis<PocoBANKASUBE> _bankaSubeServis;
        private void FBankaSubeTanim_Load(object sender, EventArgs e)
        {
            _bankaServis.Data(ServisList.BANKAListeServis);
            CBBanka.Properties.DataSource = _bankaServis.obje.Select(x => new { KOD = x.kod, ADI = x.adi, ID = x.id });
            CBBanka.Properties.DisplayMember = "ADI";
            CBBanka.Properties.ValueMember = "ID";
            CBBanka.Properties.PopulateColumns();
            CBBanka.Properties.Columns["ID"].Visible = false;
            GridiDoldur();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.SUBETANIM.ToString()).EKLE==true)
            {

           
            if (CBBanka.EditValue != null )
            {
                _bankaSubeServis.Data(ServisList.BANKASubeEkleServis, new PocoBANKASUBE()
                {
                    ADI = TBSubeAdi.Text,
                    KODU = TBSubeKodu.Text,
                    BANKAID = Convert.ToInt32(CBBanka.EditValue),
                    userid = MPKullanici.ID
                });

                GridiDoldur();
            }
            else
            {
                MessageBox.Show("Banka Seçmeden Şube ekleyemezsin!");
            }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        void GridiDoldur()
        {
            _bankaSubeServis.Data(ServisList.BANKASubeListeServis);
            gridControl1.DataSource = _bankaSubeServis.obje;
        }
    }
}
