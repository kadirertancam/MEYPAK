using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.BANKA;

namespace MEYPAK.PRL.BANKA
{
    public partial class FBankaTanim : DevExpress.XtraEditors.XtraForm
    {
        public FBankaTanim()
        {
            InitializeComponent();
            _bankaServis = new GenericWebServis<MPBANKA>();
        }
        GenericWebServis<MPBANKA> _bankaServis;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _bankaServis.Data(ServisList.BANKAEkleServis, new MPBANKA()
            {
                KOD = TBBankaKod.Text,
                ADI = TBBankaAdi.Text,
                IL = TBIlce.Text,
                ILCE = TBIl.Text,
                AKTIF=1
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