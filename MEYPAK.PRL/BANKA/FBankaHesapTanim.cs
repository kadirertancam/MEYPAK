using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Entity.PocoModels.PARAMETRE;

namespace MEYPAK.PRL.BANKA
{
    public partial class FBankaHesapTanim : XtraForm
    {
        public FBankaHesapTanim()
        {
            InitializeComponent();
            _bankaServis = new GenericWebServis<PocoBANKA>();
            _subeServis = new GenericWebServis<PocoBANKASUBE>();
            _hesapServis = new GenericWebServis<PocoBANKAHESAP>();
            _paraBirimServis = new GenericWebServis<PocoPARABIRIM>();
        }
        GenericWebServis<PocoBANKA> _bankaServis;
        GenericWebServis<PocoBANKASUBE> _subeServis;
        GenericWebServis<PocoBANKAHESAP> _hesapServis;
        GenericWebServis<PocoPARABIRIM> _paraBirimServis;

        private void FBankaHesapTanim_Load(object sender, EventArgs e)
        {
            _subeServis.Data(ServisList.BANKASubeListeServis);
            CombolariDoldur();
            GridiDoldur();
            
        }
        void GridiDoldur()
        {
            _hesapServis.Data(ServisList.BANKAHesapListeServis);
            gridControl1.DataSource = _hesapServis.obje;
        }
        void CombolariDoldur()
        {
            _bankaServis.Data(ServisList.BANKAListeServis);
            _paraBirimServis.Data(ServisList.ParaBirimiListeServis);

            CBBanka.Properties.DataSource = _bankaServis.obje.Select(x => new { KOD = x.kod, ADI = x.adi, ID = x.id });
            CBBanka.Properties.DisplayMember = "ADI";
            CBBanka.Properties.ValueMember = "ID";
            CBBanka.Properties.PopulateColumns();
            CBBanka.Properties.Columns["ID"].Visible = false;

            CBParaBirim.Properties.DataSource = _paraBirimServis.obje.Select(x => new { ID = x.id, ADI = x.adi });
            CBParaBirim.Properties.DisplayMember = "ADI";
            CBParaBirim.Properties.ValueMember = "ID";
            CBParaBirim.Properties.PopulateColumns();
            CBParaBirim.Properties.Columns["ID"].Visible = false;
            CBParaBirim.EditValue = 11638;
        }

        private void BTNBankaKaydet_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.HESAPTANIM.ToString()).EKLE==true)
            {

           
            if (CBBanka.EditValue != null && CBSube.EditValue != null && (int)CBBanka.EditValue>0&&(int)CBSube.EditValue>0)
            {
                _hesapServis.Data(ServisList.BANKAHesapEkleServis, new PocoBANKAHESAP()
                {
                    BANKAID = Convert.ToInt32(CBBanka.EditValue),
                    SUBEID = Convert.ToInt32(CBSube.EditValue),
                    PARABIRIMID = Convert.ToInt32(CBParaBirim.EditValue),
                    TIP = Convert.ToByte(CBHesapTipi.SelectedIndex),
                    KOD = TBKodu.Text,
                    ADI = TBAdi.Text,
                    NO = TBNo.Text,
                    IBAN = TBIban.Text,
                    userid = MPKullanici.ID
                });

                GridiDoldur();
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Bilgileri Giriniz!");
            }
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void CBBanka_EditValueChanged(object sender, EventArgs e)
        {
            CBSube.Properties.DataSource = _subeServis.obje.Where(x=> x.BANKAID== Convert.ToInt32(CBBanka.EditValue)).Select(x => new { ID = x.id, x.KODU, x.ADI });
            CBSube.Properties.ValueMember = "ID";
            CBSube.Properties.DisplayMember = "ADI";
            CBSube.Properties.PopulateColumns();
            CBSube.Properties.Columns["ID"].Visible = false;
        }
    }
}
