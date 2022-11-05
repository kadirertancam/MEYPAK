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


namespace MEYPAK.PRL.DEPO
{
    public partial class FMalKabulCekiPanel : Form
    {
        GenericWebServis<PocoSTOK> _tempPocoStok;
        IStokMalKabulListServis _stokMalKabulListServis;
        public FMalKabulCekiPanel()
        {
            InitializeComponent();
            _tempPocoStok = new GenericWebServis<PocoSTOK>();
            _tempStokSevkiyatList = new PocoSTOKMALKABULLIST();
            _tempPocoStok.Data(ServisList.StokListeServis );
            _tempStok = _tempPocoStok.obje;
        }
        List<PocoSTOK> _tempStok;
        PocoSTOK _Stok;
        public PocoDEPOEMIR _tempEmir;
        PocoSTOKMALKABULLIST _tempStokSevkiyatList;
        public List<PocoSTOKMALKABULLIST> _tempList;

        private void button2_Click(object sender, EventArgs e)
        {
            List<PocoStokSevkiyatList> aaa = (List<PocoStokSevkiyatList>)gridControl1.DataSource;
            int _id;
            foreach (var item in aaa)
            {
                _id = _tempStok.Where(x => x.kod == item.StokKodu).FirstOrDefault().id; 
                _stokMalKabulListServis.EkleyadaGuncelle(new PocoSTOKMALKABULLIST()
                {
                    stokid = _id,
                    emirid = _tempEmir.id,
                    birimid = StaticContext._siparisDetayServis.Getir(x => x.SIPARISID == _tempEmir.siparisid && x.STOKID == _id).FirstOrDefault().BIRIMID,
                    miktar = item.Miktar,
                    depoid = _tempEmir.mpsiparis.DEPOID,
                    sirketid = 0,
                    siparismiktari = _tempEmir.mpsiparis.MPSIPARISDETAYList.Where(x => x.STOKID == _id).Sum(x => x.MIKTAR),
                    siparisdetayid = _tempList.Where(x => x.mpsiparisdetay.STOKID == _id && x.emirid == _tempEmir.id).FirstOrDefault().mpsiparisdetay.id,
                    subeid = 0,
                    kullaniciid = 0
                });

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _Stok = _tempStok.Where(x => x.id.ToString() == CBMalKabulCekiStokKodu.GetSelectedDataRow().ToString()).FirstOrDefault();
            _tempStokSevkiyatList = new PocoSTOKMALKABULLIST()
            {
                stokid = _Stok.id,
                emirid = _tempEmir.id,
                depoid = _tempEmir.mpsiparis.DEPOID,
                miktar = 0,
                siparismiktari = _tempEmir.mpsiparis.MPSIPARISDETAYList.Where(x => x.STOKID.ToString() == CBMalKabulCekiStokKodu.GetSelectedDataRow().ToString()).FirstOrDefault().MIKTAR,
                //BIRIMID = _Stok.mpstokolcubr.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
            //    MPOLCUBR = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),
                mpdepoemir = _tempEmir,
                mpstok = _Stok,


            };
            _tempList.Add(_tempStokSevkiyatList);
            if (gridControl1.DataSource != null)
            {
                gridControl1.DataSource = null;
            }
            gridControl1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList()
            {
                StokAdı = x.mpstok.adi,
                StokKodu = x.mpstok.kod,
                Birim = x.mpolcubr.adi,
                Miktar = x.miktar,
                ID = x.stokid,
                MPSTOK = _Stok
            }).ToList();
        }

        private void FMalKabulCekiPanel_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList { StokKodu = x.mpstok.kod, StokAdı = x.mpstok.adi, Birim = "0" }).ToList();
         
            CBMalKabulCekiStokKodu.Properties.DataSource = _tempStok.Select(x => new { KOD = x.kod, ID = x.id }).ToList();
        }
    }
}
