using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.PocoModels.BANKA;

namespace MEYPAK.PRL.BANKA
{
    public partial class FBankaTanim : DevExpress.XtraEditors.XtraForm
    {
        public FBankaTanim()
        {
            InitializeComponent();
            _bankaServis = new GenericWebServis<PocoBANKA>();
        }
        GenericWebServis<PocoBANKA> _bankaServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _bankaServis.Data(ServisList.BANKAEkleServis, new PocoBANKA()
            {
                kod = TBBankaKod.Text,
                adi = TBBankaAdi.Text,
                il = TBIlce.Text,
                ilce = TBIl.Text,
                aktif=1,
                userid = MPKullanici.ID
            });
            MessageBox.Show("Banka Başarıyla Eklendi");
            GridiDoldur();
        }

        private void FBankaTanim_Load(object sender, EventArgs e)
        {
            GridiDoldur();
        }

        void GridiDoldur()
        {
            _bankaServis.Data(ServisList.BANKAListeServis);
            gridControl1.DataSource = _bankaServis.obje;
        }
    }
}