using DevExpress.XtraTab;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using MEYPAK.PRL.IRSALIYE;
using System.Data;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FIrsaliyeSettingsPanel : DevExpress.XtraEditors.XtraForm
    {
        public FIrsaliyeSettingsPanel(string tag ="",string form="")
        {
            InitializeComponent();
            tempSipDetay = new List<PocoSIPARISDETAY>();
            _siparisServis = new GenericWebServis<PocoSIPARIS>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _siparisDetayServis = new GenericWebServis<PocoSIPARISDETAY>();
            _seriServis = new GenericWebServis<PocoSERI>();
            _seriHarServis = new GenericWebServis<PocoSERIHAR>();
            _olcuBrServis= new GenericWebServis<PocoOLCUBR>();
            _stokServis= new GenericWebServis<PocoSTOK>();
            _tempIrsDetay = new List<PocoIrsaliyeKalem>();
            _siparisKasaHarServis = new GenericWebServis<PocoSIPARISKASAHAR>();
            _stokKasaHarServis = new GenericWebServis<PocoSTOKKASAHAR>();
            _stokKasaMarkaServis = new GenericWebServis<PocoSTOKKASAMARKA>();
            _stokKasaServis = new GenericWebServis<PocoSTOKKASA>();
           _tag = tag;
            _form= form;
        }
        string _tag;
        string _form;
        FMusteriSiparisIrsaliyelestir fSatisIrsaliyeFaturalastir;
        List<PocoSIPARISDETAY> tempSipDetay;
        GenericWebServis<PocoSIPARIS> _siparisServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoSIPARISDETAY> _siparisDetayServis;
        GenericWebServis<PocoSERI> _seriServis;
        GenericWebServis<PocoSERIHAR> _seriHarServis;
        GenericWebServis<PocoOLCUBR> _olcuBrServis;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoSIPARISKASAHAR> _siparisKasaHarServis;
        GenericWebServis<PocoSTOKKASAHAR> _stokKasaHarServis;
        GenericWebServis<PocoSTOKKASA> _stokKasaServis;
        GenericWebServis<PocoSTOKKASAMARKA> _stokKasaMarkaServis;
        List<ListKasaList> tempkasa;
        List<KasaList> kasalist;
        Main main;
        PocoIRSALIYE _tempIrs;
        List<PocoIrsaliyeKalem> _tempIrsDetay;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tempkasa = new List<ListKasaList>();
            _siparisDetayServis.Data(ServisList.SiparisDetayListeServis);
            _siparisServis.Data(ServisList.SiparisListeServis);
            _siparisKasaHarServis.Data(ServisList.SiparisKasaHarListeServis);
            var tempsip = _siparisServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == fSatisIrsaliyeFaturalastir.gridView2.GetFocusedRowCellValue("ID").ToString()).FirstOrDefault();
            _tempIrs = new PocoIRSALIYE()
            {
                aciklama = tempsip.aciklama,
                althesapid = tempsip.althesapid,
                belgeno = comboBox1.Text + yeniTextEdit1.Text,
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
            };

            //tempsip.durum = true;
            //_siparisServis.Data(ServisList.SiparisEkleServis, tempsip);

            foreach (var item in fSatisIrsaliyeFaturalastir.gridView1.GetSelectedRows())
            {
                if (item != -1)
                    tempSipDetay.Add( _siparisDetayServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0 && x.id.ToString() == fSatisIrsaliyeFaturalastir.gridView1.GetRowCellValue(item, "ID").ToString()).FirstOrDefault());

               
            }
            _stokKasaHarServis.Data(ServisList.StokKasaHarListeServis);
            _siparisKasaHarServis.Data(ServisList.SiparisKasaHarListeServis);
            _olcuBrServis.Data(ServisList.OlcuBrListeServis);
            _stokServis.Data(ServisList.StokListeServis);
            _stokKasaMarkaServis.Data(ServisList.StokKasaMarkaListeServis);
            _stokKasaServis.Data(ServisList.StokKasaListeServis);
            foreach (var item in tempSipDetay)
            {

                _tempIrsDetay.Add(new PocoIrsaliyeKalem()
                {

                    Acıklama = item.aciklama,
                    Birim = item.birimid != 0 ? _olcuBrServis.obje.Where(x => x.id == item.birimid).FirstOrDefault().adi : "",
                    BrütFiyat = item.brutfiyat,
                    BrütToplam = item.bruttoplam,
                    Doviz = item.dovizid,
                    İskonto1 = item.istkontO1,
                    İskonto2 = item.istkontO2,
                    İskonto3 = item.istkontO3,
                    Kdv = item.kdv,
                    KdvTutarı = item.kdvtutari,
                    Daralı = item.darali,
                    Dara = item.dara,
                    Safi = item.safi,
                    NetFiyat = item.netfiyat,
                    BirimFiyat = item.birimfiyat,
                    İskontoTutarı = item.isktoplam,
                    sıra = item.num,
                    NetToplam = item.nettoplam,
                    StokAdı = item.stokadi,
                    StokKodu =  _stokServis.obje.Where(x => x.id == item.stokid).FirstOrDefault().kod,
                    StokId = item.stokid,
                    Tipi = item.tip == 0 ? "STOK" : item.tip == 1 ? "HIZMET" : item.tip == 2 ? "KASA" : item.tip == 3 ? "DEMIRBAS" : "MUHASEBE",
                    Kunye = "",
                    KasaMiktar= _siparisKasaHarServis.obje.Where(x => x.siparisid == item.siparisid && x.siparisdetayid == item.id).Sum(x=>x.miktar)
                });
                
               kasalist = new List<KasaList>();
                foreach (var item2 in _siparisKasaHarServis.obje.Where(x => x.siparisid == item.siparisid && x.siparisdetayid == item.id))
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
                tempkasa.Add(new ListKasaList() { num = item.num,KasaList= kasalist });
            }
 

            main = (Main)Application.OpenForms["Main"];
            XtraTabPage page = new XtraTabPage();
            FSatisIrsaliye fSatisIrsaliye = new FSatisIrsaliye(_tempIrs,_tempIrsDetay, tempkasa, tempsip.id, 1);
            page.Name = "TPSatisIrsaliye" + main.i;
            page.Text = "Satis Irsaliye";
            page.Tag = "TPSatisIrsaliye" + main.i;
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            main.xtraTabControl1.TabPages.Add(page);
            main.xtraTabControl1.SelectedTabPage = page;

            fSatisIrsaliye.TopLevel = false;
            fSatisIrsaliye.AutoScroll = true;
            fSatisIrsaliye.Dock = DockStyle.Fill;
            fSatisIrsaliye.Tag = "TPSatisIrsaliye" + main.i;
            page.Controls.Add(fSatisIrsaliye);
            fSatisIrsaliye.Show();
            main.i++;
            this.Close();


        }

        private void FIrsaliyeSettingsPanel_Load(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.Tag == _tag)
                {
                    if (_form == "FMusteriSiparisIrsaliyelestir")
                        fSatisIrsaliyeFaturalastir = (FMusteriSiparisIrsaliyelestir)item;
                }
            }
           
            _seriServis.Data(ServisList.SeriListeServis);
            foreach (var item in _seriServis.obje.Where(x=>x.TIP==2))
            {
                comboBox1.Items.Add(item.SERINO);
            }
            _seriHarServis.Data(ServisList.SeriHarListeServis);
            comboBox1.Text = comboBox1.Items[0].ToString();
            yeniTextEdit1.Text=(_seriHarServis.obje.Where(x=>x.seriid==_seriServis.obje.Where(z=>z.SERINO.ToString()==comboBox1.Text && z.kayittipi==0).FirstOrDefault().id).FirstOrDefault().serino+1).ToString();
            dateEdit2.Text = fSatisIrsaliyeFaturalastir.gridView2.GetFocusedRowCellValue("Tarih").ToString();
            dateEdit1.Text = fSatisIrsaliyeFaturalastir.gridView2.GetFocusedRowCellValue("SevkiyatTarihi").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}