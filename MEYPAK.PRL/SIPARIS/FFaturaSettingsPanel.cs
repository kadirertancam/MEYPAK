using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
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
    public partial class FFaturaSettingsPanel : Form
    {
        public FFaturaSettingsPanel()
        {
            InitializeComponent();
            tempIrsDetay = new List<PocoIRSALIYEDETAY>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _faturaDetayServis = new GenericWebServis<PocoFATURADETAY>();
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _seriServis = new GenericWebServis<PocoSERI>();
            _seriHarServis = new GenericWebServis<PocoSERIHAR>();
        }
        FSatisIrsaliyeFaturalastir fSatisIrsaliyeFaturalastir;
        List<PocoIRSALIYEDETAY> tempIrsDetay;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoFATURADETAY> _faturaDetayServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoSERI> _seriServis;
        GenericWebServis<PocoSERIHAR> _seriHarServis;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayListeServis);
            fSatisIrsaliyeFaturalastir = (FSatisIrsaliyeFaturalastir)Application.OpenForms["FSatisIrsaliyeFaturalastir"];
            foreach (var item in fSatisIrsaliyeFaturalastir.gridView1.GetSelectedRows())
            {
                if (item != -1)
                {
                    tempIrsDetay.Add(_irsaliyeDetayServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == fSatisIrsaliyeFaturalastir.gridView1.GetRowCellValue(item, "ID").ToString()).FirstOrDefault());
                }


                _irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
                // var tt= _irsaliyeServis.obje.Where(x=>x.id.ToString()==grid)
                var tempirs = _irsaliyeServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == fSatisIrsaliyeFaturalastir.gridView2.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
                _faturaServis.Data(ServisList.FaturaEkleServis, new PocoFATURA()
                {
                    aciklama = tempirs.aciklama,
                    althesapid = tempirs.althesapid,
                    belgeno = comboBox1.Text + yeniTextEdit1.Text,
                    bruttoplam = tempirs.bruttoplam,
                    cariadi = tempirs.cariadi,
                    cariid = tempirs.cariid,
                    depoid = tempirs.depoid,
                    donem = tempirs.donem,
                    dovizid = tempirs.dovizid,
                    durum = tempirs.durum,
                    ekaciklama = tempirs.ekaciklama,
                    geneltoplam = tempirs.geneltoplam,
                    faturatarihi = tempirs.irsaliyetarihi,
                    iskontotoplam = tempirs.iskontotoplam,
                    kdvdahil = tempirs.kdvdahil,
                    kdvtoplam = tempirs.kdvtoplam,
                    kur = tempirs.kur,
                    kullanicitipi = tempirs.kullanicitipi,
                    nettoplam = tempirs.nettoplam,
                    tip = tempirs.tip,
                    irsaliyeid = tempirs.id, 
                    vadegunu = tempirs.vadegunu,
                    vadetarihi = tempirs.vadetarihi,
                    sirketid = tempirs.sirketid,
                    subeid = tempirs.subeid,

                });
                tempirs.durum = true;
                _irsaliyeServis.Data(ServisList.IrsaliyeEkleServis, tempirs);
            }
            foreach (var item in tempIrsDetay)
            {

                _faturaDetayServis.Data(ServisList.FaturaDetayEkleServis, new PocoFATURADETAY()
                {
                    faturaid = _faturaServis.obje2.id,
                    aciklama = item.aciklama,
                    bekleyenmiktar = item.bekleyenmiktar,
                    birimid = item.birimid,
                    brutfiyat = item.brutfiyat,
                    bruttoplam = item.bruttoplam,
                    dovizid = item.dovizid,
                    eskiid = 0,
                    hareketdurumu = 0,
                    iskontO1 = item.iskontO1,
                    iskontO2 = item.iskontO2,
                    iskontO3 = item.iskontO3,
                    kdv = item.kdv,
                    kdvtutari = item.kdvtutari,
                    listefiyatid = item.listefiyatid,
                    safi = item.safi,
                    netfiyat = item.netfiyat,
                    nettoplam = item.nettoplam,
                    stokadi = item.stokadi,
                    stokid = item.stokid,
                    tip = item.tip,
                    kunye = "",
                });
                item.hareketdurumu = 1;
                _irsaliyeDetayServis.Data(ServisList.FaturaDetayEkleServis, item);

                _seriHarServis.Data(ServisList.SeriHarListeServis);
                var tempserihar = _seriHarServis.obje.Where(x => x.seriid == _seriServis.obje.Where(z => z.SERINO.ToString() == comboBox1.Text).FirstOrDefault().id).LastOrDefault();
                tempserihar.serino = tempserihar.serino + 1;
                _seriHarServis.Data(ServisList.SeriHarEkleServis, tempserihar);
            }
        }
 

        private void FFaturaSettingsPanel_Load(object sender, EventArgs e)
        {
            fSatisIrsaliyeFaturalastir = (FSatisIrsaliyeFaturalastir)Application.OpenForms["FSatisIrsaliyeFaturalastir"];
            _seriServis.Data(ServisList.SeriListeServis);
            foreach (var item in _seriServis.obje.Where(x => x.TIP == 0))
            {
                comboBox1.Items.Add(item.SERINO);
            }
            _seriHarServis.Data(ServisList.SeriHarListeServis);
            comboBox1.Text = comboBox1.Items[0].ToString();
            yeniTextEdit1.Text = (_seriHarServis.obje.Where(x => x.seriid == _seriServis.obje.Where(z => z.SERINO.ToString() == comboBox1.Text).FirstOrDefault().id).LastOrDefault().serino + 1).ToString();
            dateEdit2.Text = fSatisIrsaliyeFaturalastir.gridView2.GetFocusedRowCellValue("Tarih").ToString();
            dateEdit1.Text = fSatisIrsaliyeFaturalastir.gridView2.GetFocusedRowCellValue("SevkiyatTarihi").ToString();
        }
    }
}
