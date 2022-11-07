using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets;
using MEYPAK.PRL.Assets.Scripts;
using System.Data;
using System.Windows.Forms;


namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulCekiPanel : Form
    {
        GenericWebServis<PocoSTOK> _tempPocoStok;
        IStokMalKabulListServis _stokMalKabulListServis;
        public FMalKabulCekiPanel()
        {
            InitializeComponent();
            _tempStokSevkiyatList = new PocoSTOKSEVKIYATLIST();
            _tempPocoStok = new GenericWebServis<PocoSTOK>();
            _tempPocoStok.Data(ServisList.StokListeServis);
            _tempStok = _tempPocoStok.obje;
            _stokServis = new GenericWebServis<PocoSTOK>();
        }
        GenericWebServis<PocoStokSevkiyatList> _stokSevkiyatListServis;
        GenericWebServis<PocoSTOK> _stokServis;
        List<PocoSTOK> _tempStok;
        PocoSTOK _Stok;
        public PocoDEPOEMIR _tempEmir;
        PocoSTOKSEVKIYATLIST _tempStokSevkiyatList;

        private void button2_Click(object sender, EventArgs e)
        {
            //    List<PocoStokSevkiyatList> aaa = (List<PocoStokSevkiyatList>)gridControl1.DataSource;
            //    int _id;
            //    foreach (var item in aaa)
            //    {
            //        _id = _tempStok.Where(x => x.kod == item.StokKodu).FirstOrDefault().id; 
            //        _stokMalKabulListServis.EkleyadaGuncelle(new PocoSTOKMALKABULLIST()
            //        {
            //            stokid = _id,
            //            emirid = _tempEmir.id,
            //            birimid = StaticContext._siparisDetayServis.Getir(x => x.siparisid == _tempEmir.siparisid && x.stokid == _id).FirstOrDefault().birimid,
            //            miktar = item.Miktar,
            //            depoid = _tempEmir.mpsiparis.depoid,
            //            sirketid = 0,
            //            siparismiktari = _tempEmir.mpsiparis.mpsiparisdetaylist.Where(x => x.stokid == _id).Sum(x => x.miktar),
            //            siparisdetayid = _tempList.Where(x => x.mpsiparisdetay.stokid == _id && x.emirid == _tempEmir.id).FirstOrDefault().mpsiparisdetay.id,
            //            subeid = 0,
            //            kullaniciid = 0
            //        });

            //        this.Close();
            //    }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //_Stok = _tempStok.Where(x => x.id.ToString() == CBMalKabulCekiStokKodu.GetSelectedDataRow().ToString()).FirstOrDefault();
            //_tempStokSevkiyatList = new PocoSTOKMALKABULLIST()
            //{
            //    stokid = _Stok.id,
            //    emirid = _tempEmir.id,
            //    depoid = _tempEmir.mpsiparis.depoid,
            //    miktar = 0,
            //    siparismiktari = _tempEmir.mpsiparis.mpsiparisdetaylist.Where(x => x.stokid.ToString() == CBMalKabulCekiStokKodu.GetSelectedDataRow().ToString()).FirstOrDefault().miktar,
            //    //BIRIMID = _Stok.mpstokolcubr.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
            ////    MPOLCUBR = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),



            //};
            //_tempList.Add(_tempStokSevkiyatList);
            //if (gridControl1.DataSource != null)
            //{
            //    gridControl1.DataSource = null;
            //}
            //gridControl1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList()
            //{
            //    StokAdı = x.mpstok.adi,
            //    StokKodu = x.mpstok.kod,
            //    Birim = x.mpolcubr.adi,
            //    Miktar = x.miktar,
            //    ID = x.stokid, 
            //}).ToList();
        }

        private void FMalKabulCekiPanel_Load(object sender, EventArgs e)
        {
            //_stokServis.Data(ServisList.StokListeServis);
            //// _tempList.Add(new PocoStokSevkiyatList());
            //dataGridView1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList { StokKodu = _stokServis.obje.Where(z => x.stokid == z.id).FirstOrDefault().kod, StokAdı = _stokServis.obje.Where(z => x.stokid == z.id).FirstOrDefault().adi, Birim = "0" }).ToList();
            //comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            //comboBox1.DisplayMember = "KOD";
            //comboBox1.ValueMember = "id";
            //comboBox1.DataSource = _tempStok.Select(x => new { KOD = x.kod, ID = x.id }).ToList();
        }
    }
}
