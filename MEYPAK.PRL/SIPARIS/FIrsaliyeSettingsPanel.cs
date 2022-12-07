using DevExpress.XtraEditors;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Siparis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FIrsaliyeSettingsPanel : DevExpress.XtraEditors.XtraForm
    {
        public FIrsaliyeSettingsPanel(string islem="",string frm="")
        {
            InitializeComponent();
            tempSipDetay = new List<PocoSIPARISDETAY>();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _seriServis = new GenericWebServis<PocoSERI>();
            _seriHarServis = new GenericWebServis<PocoSERIHAR>();
        }
        FMusteriSiparisIrsaliyelestir musteriSiparisIrsaliyelestir;
        List<PocoSIPARISDETAY> tempSipDetay;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSERI> _seriServis;
        GenericWebServis<PocoSERIHAR> _seriHarServis;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            musteriSiparisIrsaliyelestir = (FMusteriSiparisIrsaliyelestir)Application.OpenForms["FMusteriSiparisIrsaliyelestir"];
            foreach (var item in musteriSiparisIrsaliyelestir.gridView1.GetSelectedRows())
            {
                if (item != -1)
                {
                    tempSipDetay.Add( _siparisDetayServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == musteriSiparisIrsaliyelestir.gridView1.GetRowCellValue(item, "ID").ToString()).FirstOrDefault());
                }


                _siparisServis.Data(ServisList.SiparisListeServis);
                // var tt= _irsaliyeServis.obje.Where(x=>x.id.ToString()==grid)
                var tempsip = _siparisServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == musteriSiparisIrsaliyelestir.gridView1.GetRowCellValue(item, "ID").ToString()).FirstOrDefault();
                _irsaliyeServis.Data(ServisList.IrsaliyeEkleServis, new PocoIRSALIYE()
                {
                    aciklama = tempsip.aciklama,
                    althesapid = tempsip.althesapid,
                    belgeno = comboBox1.Text+yeniTextEdit1.Text,
                    bruttoplam = tempsip.bruttoplam,
                    cariadi = tempsip.cariadi,
                    cariid = tempsip.cariid,
                    depoid = tempsip.depoid,
                    donem = tempsip.donem,
                    dovizid = tempsip.dovizid,
                    durum = tempsip.durum,
                    ekaciklama = tempsip.ekaciklama,
                    geneltoplam = tempsip.geneltoplam,
                    irsaliyetarihi = tempsip.siparistarihi,
                    iskontotoplam = tempsip.istkontotoplam,
                    kdvdahil = tempsip.kdvdahil,
                    kdvtoplam = tempsip.kdvtoplam,
                    kur = tempsip.kur,
                    kullanicitipi = tempsip.kullanicitipi,
                    nettoplam = tempsip.nettoplam,
                    tip = tempsip.tip,
                    siparisid = tempsip.id,
                    sevkiyattarihi = tempsip.sevkiyattarihi,
                    vadegunu = tempsip.vadegunu,
                    vadetarihi = tempsip.vadetarihi,
                    sirketid = tempsip.sirketid,
                    subeid = tempsip.subeid,

                });
                tempsip.durum = true;
                _siparisServis.Data(ServisList.SiparisEkleServis, tempsip);
            }
            foreach (var item in tempSipDetay)
            {

                _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayEkleServis, new PocoIRSALIYEDETAY()
                {
                    irsaliyeid= _irsaliyeServis.obje2.id,
                    aciklama = item.aciklama,
                    bekleyenmiktar = item.bekleyenmiktar,
                    birimid = item.birimid,
                    brutfiyat = item.brutfiyat,
                    bruttoplam = item.bruttoplam,
                    dovizid = item.dovizid,
                    eskiid = 0,
                    hareketdurumu = 0,
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
                    kunye = "",
                });
                item.hareketdurumu = 1;
                _siparisDetayServis.Data(ServisList.SiparisDetayEkleServis, item);

                _seriHarServis.Data(ServisList.SeriHarListeServis);
                var tempserihar = _seriHarServis.obje.Where(x => x.seriid == _seriServis.obje.Where(z => z.SERINO.ToString() == comboBox1.Text).FirstOrDefault().id).FirstOrDefault();
                tempserihar.serino = tempserihar.serino + 1;
                _seriHarServis.Data(ServisList.SeriHarEkleServis, tempserihar);
            }
        }

        private void FIrsaliyeSettingsPanel_Load(object sender, EventArgs e)
        {
            musteriSiparisIrsaliyelestir = (FMusteriSiparisIrsaliyelestir)Application.OpenForms["FMusteriSiparisIrsaliyelestir"];
            _seriServis.Data(ServisList.SeriListeServis);
            foreach (var item in _seriServis.obje)
            {
                comboBox1.Items.Add(item.SERINO);
            }
            _seriHarServis.Data(ServisList.SeriHarListeServis);
            comboBox1.Text = comboBox1.Items[0].ToString();
            yeniTextEdit1.Text=(_seriHarServis.obje.Where(x=>x.seriid==_seriServis.obje.Where(z=>z.SERINO.ToString()==comboBox1.Text).FirstOrDefault().id).FirstOrDefault().serino +1).ToString();
            dateEdit2.Text = musteriSiparisIrsaliyelestir.gridView2.GetFocusedRowCellValue("Tarih").ToString();
            dateEdit1.Text = musteriSiparisIrsaliyelestir.gridView2.GetFocusedRowCellValue("SevkiyatTarihi").ToString();
        }
    }
}