using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.Assets.Scripts;
using System.Data;


namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulCekiPanel : Form
    {
        IStokServis _stokServis;
        IStokMalKabulListServis _stokMalKabulListServis;
        public FMalKabulCekiPanel()
        {
            InitializeComponent();

            _tempStokSevkiyatList = new PocoSTOKMALKABULLIST();
            _tempStok = _stokServis.Listele();
        }
        List<PocoSTOK> _tempStok;
        PocoSTOK _Stok;
        public PocoDEPOEMIR _tempEmir;
        PocoSTOKMALKABULLIST _tempStokSevkiyatList;
        public List<PocoSTOKMALKABULLIST> _tempList;

        private void button2_Click(object sender, EventArgs e)
        {
            List<PocoStokSevkiyatList> aaa = (List<PocoStokSevkiyatList>)dataGridView1.DataSource;
            int _id;
            foreach (var item in aaa)
            {
                _id = _stokServis.Getir(x => x.KOD == item.StokKodu).FirstOrDefault().ID;
                _stokMalKabulListServis.OnYukle();
                _stokMalKabulListServis.EkleyadaGuncelle(new PocoSTOKMALKABULLIST()
                {
                    STOKID = _id,
                    EMIRID = _tempEmir.ID,
                    BIRIMID = StaticContext._siparisDetayServis.Getir(x => x.SIPARISID == _tempEmir.SIPARISID && x.STOKID == _id).FirstOrDefault().BIRIMID,
                    MIKTAR = item.Miktar,
                    DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                    SIRKETID = 0,
                    SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAYList.Where(x => x.STOKID == _id).Sum(x => x.MIKTAR),
                    SIPARISDETAYID = _tempList.Where(x => x.MPSIPARISDETAY.STOKID == _id && x.EMIRID == _tempEmir.ID).FirstOrDefault().MPSIPARISDETAY.ID,
                    SUBEID = 0,
                    KULLANICIID = 0
                });

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _Stok = _stokServis.Getir(x => x.ID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault();
            _tempStokSevkiyatList = new PocoSTOKMALKABULLIST()
            {
                STOKID = _Stok.ID,
                EMIRID = _tempEmir.ID,
                DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                MIKTAR = 0,
                SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAYList.Where(x => x.STOKID.ToString() == comboBox1.SelectedValue.ToString()).FirstOrDefault().MIKTAR,
                BIRIMID = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
            //    MPOLCUBR = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),
                MPDEPOEMIR = _tempEmir,
                MPSTOK = _Stok,


            };
            _tempList.Add(_tempStokSevkiyatList);
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            dataGridView1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList()
            {
                StokAdı = x.MPSTOK.ADI,
                StokKodu = x.MPSTOK.KOD,
                Birim = x.MPOLCUBR.ADI,
                Miktar = x.MIKTAR,
                ID = x.STOKID,
                MPSTOK = _Stok
            }).ToList();
        }

        private void FMalKabulCekiPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList { StokKodu = x.MPSTOK.KOD, StokAdı = x.MPSTOK.ADI, Birim = "0" }).ToList();
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DisplayMember = "KOD";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = _tempStok.Select(x => new { KOD = x.KOD, ID = x.ID }).ToList();
        }
    }
}
