using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using System.Data;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FMusteriSiparisIrsaliyelestir : Form
    {
        public FMusteriSiparisIrsaliyelestir()
        {
            InitializeComponent();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            tempSiparisKalem = new List<PocoSiparisKalem>();
            tempSipDetay = new List<PocoSIPARISDETAY>();
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
          
        }
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        List<PocoSiparisKalem> tempSiparisKalem;
        List<PocoSIPARISDETAY> tempSipDetay;
        FIrsaliyeSettingsPanel ırsaliyeSettingsPanel;
        private void FMusteriSiparisIrsaliyelestir_Load(object sender, EventArgs e)
        {
            siparislist();


        }

        private void gridView2_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ırsaliyeSettingsPanel = new FIrsaliyeSettingsPanel(this.Tag.ToString(), "FMusteriSiparisIrsaliyelestir");
            ırsaliyeSettingsPanel.ShowDialog();
        }
 
        private void gridView2_RowStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView2.GetRowCellValue(e.RowHandle, "DURUM"));

            if (quantity == "Tamamlandı")
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            else
            {
                e.Appearance.BackColor = Color.Red;
            }
        }

        private void gridView2_Click_1(object sender, EventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            gridControl1.DataSource = _siparisDetayServis.obje.Where(x => x.kayittipi == 0 && x.siparisid.ToString() == gridView2.GetFocusedRowCellValue("ID").ToString()).Select(x => new { ID = x.id, StokId = x.stokid, StokAdı = x.stokadi, Daralı = x.darali, Dara = x.dara, Safi = x.safi, NetFiyat = x.netfiyat, BrutFiyat = x.brutfiyat, Iskonto1 = x.istkontO1, Iskonto2 = x.istkontO2, Iskonto3 = x.istkontO3, NetToplam = x.nettoplam, BrutToplam = x.bruttoplam });
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["ID"].Visible = false;
        }
        void siparislist()
        {
            _depoServis.Data(ServisList.DepoListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            DGSiparisList.DataSource = _siparisServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0).Select(x => new
            {
                ID = x.id,
                Tarih = x.siparistarihi,
                BelgeNo = x.belgeno,
                CariAdı = x.cariadi,
                SevkiyatTarihi = x.sevkiyattarihi,
                Depo = _depoServis.obje.Where(z => z.id == x.depoid).FirstOrDefault().depoadi,
                GENELTOPLAM = x.geneltoplam,
                DURUM = x.durum == false ? "Beklemede" : "Tamamlandı",

            });
            gridView2.Columns["ID"].Visible = false;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            siparislist();
        }
    }
}
