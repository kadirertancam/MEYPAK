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
                    STOKID = _id,
                    EMIRID = _tempEmir.id,
                    BIRIMID = StaticContext._siparisDetayServis.Getir(x => x.SIPARISID == _tempEmir.SIPARISID && x.STOKID == _id).FirstOrDefault().BIRIMID,
                    MIKTAR = item.Miktar,
                    DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                    SIRKETID = 0,
                    SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAYList.Where(x => x.STOKID == _id).Sum(x => x.MIKTAR),
                    SIPARISDETAYID = _tempList.Where(x => x.MPSIPARISDETAY.STOKID == _id && x.EMIRID == _tempEmir.id).FirstOrDefault().MPSIPARISDETAY.id,
                    SUBEID = 0,
                    KULLANICIID = 0
                });

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _Stok = _tempStok.Where(x => x.id.ToString() == CBMalKabulCekiStokKodu.GetSelectedDataRow().ToString()).FirstOrDefault();
            _tempStokSevkiyatList = new PocoSTOKMALKABULLIST()
            {
                STOKID = _Stok.id,
                EMIRID = _tempEmir.id,
                DEPOID = _tempEmir.MPSIPARIS.DEPOID,
                MIKTAR = 0,
                SIPARISMIKTARI = _tempEmir.MPSIPARIS.MPSIPARISDETAYList.Where(x => x.STOKID.ToString() == CBMalKabulCekiStokKodu.GetSelectedDataRow().ToString()).FirstOrDefault().MIKTAR,
                //BIRIMID = _Stok.mpstokolcubr.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR.ID).FirstOrDefault(),
            //    MPOLCUBR = _Stok.MPSTOKOLCUBRList.Where(x => x.NUM == 1).Select(x => x.MPOLCUBR).FirstOrDefault(),
                MPDEPOEMIR = _tempEmir,
                MPSTOK = _Stok,


            };
            _tempList.Add(_tempStokSevkiyatList);
            if (gridControl1.DataSource != null)
            {
                gridControl1.DataSource = null;
            }
            gridControl1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList()
            {
                StokAdı = x.MPSTOK.adi,
                StokKodu = x.MPSTOK.kod,
                Birim = x.MPOLCUBR.adi,
                Miktar = x.MIKTAR,
                ID = x.STOKID,
                MPSTOK = _Stok
            }).ToList();
        }

        private void FMalKabulCekiPanel_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _tempList.Select(x => new PocoStokSevkiyatList { StokKodu = x.MPSTOK.kod, StokAdı = x.MPSTOK.adi, Birim = "0" }).ToList();
         
            CBMalKabulCekiStokKodu.Properties.DataSource = _tempStok.Select(x => new { KOD = x.kod, ID = x.id }).ToList();
        }
    }
}
