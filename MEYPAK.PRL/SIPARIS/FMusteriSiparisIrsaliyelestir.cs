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
        private void FMusteriSiparisIrsaliyelestir_Load(object sender, EventArgs e)
        {
            _depoServis.Data(ServisList.DepoListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            gridControl2.DataSource = _siparisServis.obje.Where(x => x.durum == false && x.kayittipi == 0 && x.tip == 0).Select(x => new
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

        private void gridView2_Click(object sender, EventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            gridControl1.DataSource = _siparisDetayServis.obje.Where(x => x.kayittipi == 0 && x.siparisid.ToString() == gridView2.GetFocusedRowCellValue("ID").ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in gridView1.GetSelectedRows())
            {
                if (item != -1)
                {
                    tempSipDetay.Add(_siparisDetayServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == gridView1.GetRowCellValue(item, "id").ToString()).FirstOrDefault());
                }


                _siparisServis.Data(ServisList.SiparisListeServis);
                // var tt= _irsaliyeServis.obje.Where(x=>x.id.ToString()==grid)
                var tempsip = _siparisServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == gridView1.GetRowCellValue(item, "id").ToString()).FirstOrDefault();
                _irsaliyeServis.Data(ServisList.IrsaliyeEkleServis, new PocoIRSALIYE()
                {
                    aciklama = tempsip.aciklama,
                    althesapid=tempsip.althesapid,
                    belgeno=tempsip.belgeno,
                    bruttoplam=tempsip.bruttoplam,
                    cariadi = tempsip.cariadi,
                    cariid = tempsip.cariid,
                    depoid = tempsip.depoid,
                    donem = tempsip.donem,
                    dovizid = tempsip.dovizid,
                    durum = tempsip.durum,
                    ekaciklama = tempsip.ekaciklama,
                    geneltoplam = tempsip.geneltoplam,
                    irsaliyetarihi=tempsip.siparistarihi,
                    iskontotoplam=tempsip.istkontotoplam,
                    kdvdahil=tempsip.kdvdahil,
                    kdvtoplam=tempsip.kdvtoplam,
                    kur=tempsip.kur,
                    kullanicitipi=tempsip.kullanicitipi,
                    nettoplam=tempsip.nettoplam,
                    tip=tempsip.tip,
                    siparisid=tempsip.id,
                    sevkiyattarihi=tempsip.sevkiyattarihi,
                    vadegunu=tempsip.vadegunu,
                    vadetarihi=tempsip.vadetarihi,
                    sirketid=tempsip.sirketid,
                    subeid=tempsip.subeid,
                    
                });
            }
            foreach (var item in tempSipDetay)
            {

                _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayEkleServis, new PocoIRSALIYEDETAY()
                {
                    aciklama = item.aciklama,
                    bekleyenmiktar = item.bekleyenmiktar,
                    birimid = item.birimid,
                    brutfiyat = item.brutfiyat,
                    bruttoplam = item.bruttoplam,
                    dovizid = item.dovizid,
                    eskiid = 0,
                    hareketdurumu = 1,
                    istkontO1 = item.istkontO1,
                    istkontO2 = item.istkontO2,
                    istkontO3 = item.istkontO3,
                    kdv = item.kdv,
                    kdvtutari = item.kdvtutari,
                    listefiyatid = item.listefiyatid,
                    miktar = item.miktar,
                    netfiyat = item.netfiyat,
                    nettoplam = item.nettoplam,
                    stokadi = item.stokadi,
                    stokid = item.stokid,
                    tip = item.tip,

                });
            }
        }
    }
}
