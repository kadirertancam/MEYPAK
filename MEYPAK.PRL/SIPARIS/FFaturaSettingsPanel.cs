using DevExpress.Utils;
using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using System.Data;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FFaturaSettingsPanel : Form
    {
        public FFaturaSettingsPanel(string tag = "", string form = "")
        {
            InitializeComponent();
            tempIrsDetay = new List<PocoIRSALIYEDETAY>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _faturaDetayServis = new GenericWebServis<PocoFATURADETAY>();
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _seriServis = new GenericWebServis<PocoSERI>();
            _seriHarServis = new GenericWebServis<PocoSERIHAR>();
            _tempfatdetay = new List<PocoFaturaKalem>();
            _olcuBrServis = new GenericWebServis<PocoOLCUBR>();
            _stokServis = new GenericWebServis<PocoSTOK>();
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _tag = tag;
            _form = form;
        }
        string _tag;
        string _form;
        FSatisIrsaliyeFaturalastir fSatisIrsaliyeFaturalastir;
        List<PocoIRSALIYEDETAY> tempIrsDetay;
        List<PocoFaturaKalem> _tempfatdetay;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoFATURADETAY> _faturaDetayServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoSERI> _seriServis;
        GenericWebServis<PocoSERIHAR> _seriHarServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        GenericWebServis<PocoSTOK> _stokServis; 
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        List<ListKasaList> tempkasa;
        List<KasaList> kasalist;
        Main main;
        PocoFATURA tempfat;
        FFatura fFatura;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayListeServis);
            _irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            var tempirs = _irsaliyeServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == fSatisIrsaliyeFaturalastir.gridView2.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            tempfat = new PocoFATURA()
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

            };
            tempirs.durum = true;
            _irsaliyeServis.Data(ServisList.IrsaliyeEkleServis, tempirs);

            foreach (var item in fSatisIrsaliyeFaturalastir.gridView1.GetSelectedRows())
            {
                if (item != -1)
                    tempIrsDetay.Add(_irsaliyeDetayServis.obje.Where(x => x.kayittipi == 0 && x.id.ToString() == fSatisIrsaliyeFaturalastir.gridView1.GetRowCellValue(item, "ID").ToString()).FirstOrDefault());
            }

            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            foreach (var item in tempIrsDetay)
            {
                _tempfatdetay.Add( new PocoFaturaKalem()
                {
                   
                    Acıklama = item.aciklama, 
                    Birim = item.birimid!=0?_olcuBrServis.obje.Where(x=>x.id==item.birimid).FirstOrDefault().adi:"",
                    BrütFiyat = item.brutfiyat,
                    BrütToplam = item.bruttoplam,
                    Doviz = item.dovizid,  
                    İskonto1 = item.iskontO1,
                    İskonto2 = item.iskontO2,
                    İskonto3 = item.iskontO3,
                    Kdv = item.kdv,
                    KdvTutarı = item.kdvtutari, 
                    Dara=item.dara,
                    Daralı=item.darali,
                    BirimFiyat=item.birimfiyat,
                    KasaMiktar=item.kasamiktar,
                    StokKodu=_stokServis.obje.Where(x=>x.id==item.stokid).FirstOrDefault().kod,
                    İskontoTutarı=item.isktoplam,
                    sıra=item.num,
                    Safi = item.safi,
                    NetFiyat = item.netfiyat,
                    NetToplam = item.nettoplam,
                    StokAdı = item.stokadi,
                    StokId = item.stokid,
                    Tipi = item.tip == 0 ? "STOK" : item.tip == 1 ? "HIZMET" : item.tip == 2 ? "KASA" : item.tip == 3 ? "DEMIRBAS" : "MUHASEBE",
                    Kunye = "",
                });
                kasalist = new List<KasaList>();
                foreach (var item2 in _stokKasaHarServis.obje.Where(x => x.irsaliyeid == item.irsaliyeid && x.irsaliyedetayid == item.id))
                {
                    kasalist.Add(new KasaList()
                    {
                        KASAADI = _stokKasaServis.obje.Where(x => x.id == item2.kasaid).FirstOrDefault().kasaadi,
                        KASAID = item2.kasaid,
                        MARKA = _stokKasaMarkaServis.obje.Where(z => z.id == _stokKasaServis.obje.Where(x => x.id == item2.kasaid).FirstOrDefault().markaid).FirstOrDefault().adi,
                        MIKTAR = item2.miktar,
                        ID = item.id
                    });
                }
                item.hareketdurumu = 1;
                tempkasa.Add(new ListKasaList() { num = item.num, KasaList = kasalist });
            }
            
            main = (Main)Application.OpenForms["Main"];
            XtraTabPage page = new XtraTabPage();
            FFatura ffatura = new FFatura(tempfat, _tempfatdetay, tempkasa, 1);
            page.Name = "TPFatura" + main.i;
            page.Text = "Fatura Tanım";
            page.Tag = "TPFatura" + main.i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            main.xtraTabControl1.TabPages.Add(page);
            main.xtraTabControl1.SelectedTabPage = page;

            ffatura.TopLevel = false;
            ffatura.AutoScroll = true;
            ffatura.Dock = DockStyle.Fill;
            ffatura.Tag = "TPFatura" + main.i;
            page.Controls.Add(ffatura);
            ffatura.Show();
            main.i++;
            this.Close();
            
            
        }
 

        private void FFaturaSettingsPanel_Load(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Tag == _tag)
                {
                    if (_form == "FSatisIrsaliyeFaturalastir")
                        fSatisIrsaliyeFaturalastir = (FSatisIrsaliyeFaturalastir)item;
                }
            }
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
