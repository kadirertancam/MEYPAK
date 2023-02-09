using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.Assets.Scripts;
using System.Data;
using System.Windows.Forms;


namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulCekiPanel : XtraForm
    {
        GenericWebServis<PocoSTOK> _tempPocoStok;
        GenericWebServis<PocoSTOKMALKABULLIST> _stokMalKabulListServis;
        public FMalKabulCekiPanel()
        {
            InitializeComponent();
            _tempStokSevkiyatList = new PocoSTOKSEVKIYATLIST();
            _tempPocoStok = new GenericWebServis<PocoSTOK>();
            _tempPocoStok.Data(ServisList.StokListeServis);
            _tempStok = _tempPocoStok.obje;
            _stokMalKabulListServis = new GenericWebServis<PocoSTOKMALKABULLIST>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _satinAlmaMalKabulEmriHar = new GenericWebServis<PocoSATINALMAMALKABULEMRIHAR>();
            _depoCekiListServis = new GenericWebServis<PocoDEPOCEKILIST>(); 
        }
        GenericWebServis<PocoDEPOCEKILIST> _depoCekiListServis;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSATINALMAMALKABULEMRIHAR> _satinAlmaMalKabulEmriHar; 
        List<PocoSTOK> _tempStok;
        PocoSTOK _Stok;
        public PocoDEPOEMIR _tempEmir;
        PocoSTOKSEVKIYATLIST _tempStokSevkiyatList;

        public List<PocoDEPOCEKILIST> _tempList; 
        private void FMalKabulCekiPanel_Load(object sender, EventArgs e)
        {

            _stokServis.Data(ServisList.StokListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            // _tempList.Add(new PocoStokSevkiyatList());
            gridControl1.DataSource =
                _tempList.Select(x => new CekiPanelList { ID = x.id, StokKodu = _stokServis.obje.Where(z => x.stokid == z.id).FirstOrDefault().kod, StokAdı = _stokServis.obje.Where(z => x.stokid == z.id).FirstOrDefault().adi, Birim = _olcuBrServis.obje.Where(z => z.id == x.birimid).FirstOrDefault().adi, Miktar = x.miktar });
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "KOD";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = _tempStok.Select(x => new { KOD = x.kod, ID = x.id }).ToList();
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {


        }
         
        private void BTKaydet_Click(object sender, EventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            //_satinAlmaMalKabulEmriHar.Data(ServisList.S);
            int _id;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                _id = _stokServis.obje.Where(x => x.kod == gridView1.GetRowCellValue(i, "StokKodu")).FirstOrDefault().id;

                _depoCekiListServis.Data(ServisList.DepoCekiListEkleServis, new PocoDEPOCEKILIST()
                {
                    id = Convert.ToInt32(gridView1.GetRowCellValue(i, "ID").ToString()),
                    stokid = _id,
                    birimid = _siparisDetayServis.obje.Where(x => x.siparisid == _tempEmir.siparisid && x.stokid == _id).FirstOrDefault().birimid,
                    miktar = Convert.ToDecimal(gridView1.GetRowCellValue(i, "Miktar")),
                    isemriid = _tempEmir.id,
                    depoid = _tempEmir.depoid,
                    userid = MPKullanici.ID,
                });
            }
            _depoCekiListServis.Data(ServisList.DepoCekiListListeServis);
            _stokMalKabulListServis.Data(ServisList.StokMalKabulListListeServis);
            var taaa = _stokMalKabulListServis.obje.Where(x => x.emirid == _tempEmir.id);
            foreach (var item in taaa)
            {
                _stokMalKabulListServis.Data(ServisList.StokMalKabulListEkleServis,
                    new PocoSTOKMALKABULLIST()
                    {
                        id = item.id,
                        miktar = item.miktar,
                        birimid = item.birimid,
                        depoid = item.depoid,
                        emirid = item.emirid,
                        eskiid = item.eskiid,
                        guncellemetarihi = item.guncellemetarihi,
                        kayittipi = item.kayittipi,
                        kullaniciid = item.kullaniciid,
                        olusturmatarihi = item.olusturmatarihi,
                        malkabulharemriid = item.malkabulharemriid,
                        siparisdetayid = item.siparisdetayid,
                        siparismiktari = item.siparismiktari,
                        sirketid = item.sirketid,
                        stokid = item.stokid,
                        subeid = item.subeid,
                        kalanmiktar = item.miktar - _depoCekiListServis.obje.Where(x => x.stokid == item.stokid && x.isemriid == item.emirid).FirstOrDefault().miktar,
                        userid = MPKullanici.ID,
                    });
            }
            this.Close();
        }
    }
}
