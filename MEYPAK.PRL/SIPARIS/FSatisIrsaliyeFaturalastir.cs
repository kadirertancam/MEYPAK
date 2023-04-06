using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels;
using System.Data;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.Models.FORMYETKI;
using ServiceReference10;
using Newtonsoft.Json;
using System.Net.Http;
using MEYPAK.PRL.Assets;

namespace MEYPAK.PRL.SIPARIS
{
    public partial class FSatisIrsaliyeFaturalastir : Form
    {
        public FSatisIrsaliyeFaturalastir()
        {
            InitializeComponent();
            _faturaServis = new GenericWebServis<PocoFATURA>();
            _irsaliyeDetayServis = new GenericWebServis<PocoIRSALIYEDETAY>();
            _depoServis = new GenericWebServis<PocoDEPO>();
            tempFaturaKalem = new List<PocoFaturaKalem>();
            tempFatDetay = new List<PocoFATURADETAY>();
            _faturaDetayServis = new GenericWebServis<PocoFATURADETAY>();
            _irsaliyeServis = new GenericWebServis<PocoIRSALIYE>();

        }
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoFATURADETAY> _faturaDetayServis;
        List<PocoFaturaKalem> tempFaturaKalem;
        List<PocoFATURADETAY> tempFatDetay;
        FFaturaSettingsPanel faturaSettingsPanel;
        HKSDepo.Root depo;
        private void gridView2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MPKullanici.YetkiGetir(AllForms.SATISIRSALIYESIFATURALASTIR.ToString()).EKLE == true)
            {
                faturaSettingsPanel = new FFaturaSettingsPanel(this.Tag.ToString(), "FSatisIrsaliyeFaturalastir");
                faturaSettingsPanel.ShowDialog();
            }
            else
                MessageBox.Show(MPKullanici.hata);
        }

        private void gridView2_RowStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            string quantity = Convert.ToString(gridView2.GetRowCellValue(e.RowHandle, "DURUM"));

            if (quantity == "Tamamlandı")
            {
                e.Appearance.BackColor = Color.LightGreen;
            }
            else
            {
                e.Appearance.BackColor = Color.Red;
            }
        }
        List<PocoIRSALIYEDETAY> _tempIrsaliyeDetay;
        private void gridView2_Click_1(object sender, EventArgs e)
        {
            _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayListeServis);
            _tempIrsaliyeDetay = _irsaliyeDetayServis.obje.Where(x => x.kayittipi == 0 && x.irsaliyeid.ToString() == gridView2.GetFocusedRowCellValue("ID").ToString()).ToList();
            gridControl1.DataSource = _tempIrsaliyeDetay.Select(x => new { ID = x.id, StokId = x.stokid, StokAdı = x.stokadi, Daralı = x.darali, Dara = x.dara, Safi = x.safi, NetFiyat = x.netfiyat, BrutFiyat = x.brutfiyat, Iskonto1 = x.iskontO1, Iskonto2 = x.iskontO2, Iskonto3 = x.iskontO3, NetToplam = x.nettoplam, BrutToplam = x.bruttoplam });
            gridView1.Columns["StokId"].Visible = false;
            gridView1.Columns["ID"].Visible = false;
        }
        void faturalist()
        {
            _depoServis.Data(ServisList.DepoListeServis);
            _irsaliyeServis.Data(ServisList.IrsaliyeListeServis);
            DGSiparisList.DataSource = _irsaliyeServis.obje.Where(x => x.kayittipi == 0 && x.tip == 0).Select(x => new
            {
                ID = x.id,
                Tarih = x.irsaliyetarihi,
                BelgeNo = x.belgeno,
                CariAdı = x.cariadi,
                SevkiyatTarihi = x.sevkiyattarihi,
                Depo = _depoServis.obje.Where(z => z.id == x.depoid).FirstOrDefault().depoadi,
                GENELTOPLAM = x.geneltoplam,
                DURUM = x.durum == false ? "Beklemede" : "Tamamlandı",

            });
            gridView2.Columns["ID"].Visible = false;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            faturalist();
        }

        private void FSatisIrsaliyeFaturalastir_Load(object sender, EventArgs e)
        {
            faturalist();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //
            HttpRequestMessage client = new HttpRequestMessage(HttpMethod.Get, @"http://78.135.80.41:8086/api/Genel?username=4300580693&servicepassword=18E932F8&password=Meypak139&islem=Depolar&parametre=4300580693");
            using (HttpClient cl = new HttpClient())
            {
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("accept", "*/*");
                client.Headers.Add("Host", "78.135.80.41:8086");
                client.Headers.Add("Accept-Encoding", "gzip, deflate,br");
                HttpResponseMessage resp = cl.Send(client);
                string tempp = resp.Content.ReadAsStringAsync().Result.ToString();
                tempp = tempp.Replace("\\", "");
                tempp = tempp.Replace("\"{", "{");
                tempp = tempp.Replace("}\"", "}");
                depo = JsonConvert.DeserializeObject<HKSDepo.Root>(tempp);
            }
            BildirimKayitIstek[] ten = new BildirimKayitIstek[_tempIrsaliyeDetay.Count];
            foreach (var item in _tempIrsaliyeDetay)
            {

              
             {
                    new BildirimKayitIstek()
                    {
                        UniqueId = Guid.NewGuid().ToString(),
                        BildirimciBilgileri = new BildirimciBilgileriDTO()
                        {
                            KisiSifat = 6,
                        },

                        BildirimTuru = 197,

                        IkinciKisiBilgileri = new IkinciKisiBilgileriDTO()
                        {
                            KisiSifat = 13,

                            TcKimlikVergiNo = "7280579490",
                            AdSoyad = "PELİT KARDEŞLER GIDA TURZ. İNS. HAYV. SANAYİ TİCARET LTD ŞTİ",
                            Eposta = "pelit@mailnator.com",
                            CepTel = "5075652525",
                            YurtDisiMi = false,
                            //KisiSifat = 6,
                            //KisiSifatSpecified= true,
                            //TcKimlikVergiNo ="4300580693",
                            //AdSoyad= "Gündüz Meypak Gıda",
                            //Eposta="mey_pak@hotmail.com",
                            //CepTel= "5494633603",
                            //YurtDisiMi=false,
                        },
                        ReferansBildirimKunyeNo = long.Parse(item.kunye),

                        BildirimMalBilgileri = new BildirimMalBilgileriDTO()
                        {
                            MalinMiktari = 0,
                            MalinSatisFiyat = 0,

                        },

                        MalinGidecekYerBilgileri = new MalinGidecekYerBilgileriDTO()
                        {
                            GidecekYerIsletmeTuruId = 19,
                            GidecekYerIlId = 6,



                            //  GidecekYerIsletmeTuruId=7,
                            //GidecekYerIsletmeTuruIdSpecified=true,
                            //  GidecekIsyeriId=1143,
                            //GidecekIsyeriIdSpecified=true,
                            GidecekYerIlceId = 477,
                            GidecekYerBeldeId = 5077,
                            AracPlakaNo = "06NAK06",

                        }

                    };
             };
            }
        }
    }
}
