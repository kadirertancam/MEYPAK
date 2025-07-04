﻿using MEYPAK.BLL.Assets;
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
using MEYPAK.Entity.PocoModels.CARI;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.PERSONEL;

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
            _cariServis = new GenericWebServis<PocoCARIKART>();
            _araclarServis = new GenericWebServis<PocoARAC>();
            _personelServis = new GenericWebServis<PocoPERSONEL>();
        }
        GenericWebServis<PocoFATURA> _faturaServis;
        GenericWebServis<PocoIRSALIYE> _irsaliyeServis;
        GenericWebServis<PocoDEPO> _depoServis;
        GenericWebServis<PocoIRSALIYEDETAY> _irsaliyeDetayServis;
        GenericWebServis<PocoFATURADETAY> _faturaDetayServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoARAC> _araclarServis;
        GenericWebServis<PocoPERSONEL> _personelServis;
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
                CARIADI = x.cariadi,
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

            var tempirs = _irsaliyeServis.obje.Where(x => x.belgeno.ToString() == gridView2.GetFocusedRowCellValue("BelgeNo").ToString()).FirstOrDefault();
            _cariServis.Data(ServisList.CariListeServis);
            var tempcar = _cariServis.obje.Where(x => x.unvan.ToString() == gridView2.GetFocusedRowCellValue("CARIADI").ToString() || x.adi + " " + x.soyadi == gridView2.GetFocusedRowCellValue("CARIADI").ToString()).FirstOrDefault();
            _araclarServis.Data(ServisList.AracListeServis);
            _personelServis.Data(ServisList.PersonelListeServis);
            //
            HttpRequestMessage client = new HttpRequestMessage(HttpMethod.Get, @"http://78.135.80.41:8086/api/Genel?username=4300580693&servicepassword=18E932F8&password=Meypak140&islem=Depolar&parametre=4300580693");
            using (HttpClient cl = new HttpClient())
            {
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("accept", "*/*");
                client.Headers.Add("Host", "78.135.80.41:8086");
                client.Headers.Add("Accept-Encoding", "gzip, deflate,br");
                HttpResponseMessage resps = cl.Send(client);
                string tempp = resps.Content.ReadAsStringAsync().Result.ToString();
                tempp = tempp.Replace("\\", "");
                tempp = tempp.Replace("\"{", "{");
                tempp = tempp.Replace("}\"", "}");
                depo = JsonConvert.DeserializeObject<HKSDepo.Root>(tempp);
            }

            HttpClient httpClient = new HttpClient();
            client = new HttpRequestMessage(HttpMethod.Post, "https://hks.hal.gov.tr/WebServices/GenelService.svc");
            client.Headers.Add("Connection", "keep-alive");
            client.Headers.Add("Host", "hks.hal.gov.tr");
            client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
            client.Headers.Add("SOAPAction", "\"http://www.gtb.gov.tr//WebServices/IGenelService/GenelServisIller\"");
            client.Headers.Add("VsDebuggerCausalityData", "uIDPo/l8atIDoqFFniLRCUIFbKQAAAAA64uYbk/jW0K+h9kz55jWZeM1+BqDlnNPpgceAHjWSsYACQAA");
            //  client.Headers.Add("Content-Type", "text/xml");
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><soap:Body><BaseRequestMessageOf_IllerIstek xmlns=\"http://www.gtb.gov.tr//WebServices\"><Istek /><Password>Meypak140</Password><ServicePassword>18E932F8</ServicePassword><UserName>4300580693</UserName></BaseRequestMessageOf_IllerIstek></soap:Body></soap:Envelope>";
            client.Method = HttpMethod.Post;


            client.Content = new StringContent(xml,
                                        Encoding.UTF8,
                                        "text/xml");


            httpClient.DefaultRequestHeaders.ExpectContinue = false;
            HttpResponseMessage resp = httpClient.SendAsync(client).Result;
            var aaaa = resp.Content.ReadAsStringAsync().Result;
            XmlSerializerHelper xmlSerializerHelper = new XmlSerializerHelper();
            var iller = (HKSIller.Envelope)xmlSerializerHelper.DeserializeFromXml(typeof(HKSIller.Envelope), aaaa);


            httpClient = new HttpClient();
            client = new HttpRequestMessage(HttpMethod.Post, "https://hks.hal.gov.tr/WebServices/GenelService.svc");
            client.Headers.Add("Connection", "keep-alive");
            client.Headers.Add("Host", "hks.hal.gov.tr");
            client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
            client.Headers.Add("SOAPAction", "\"http://www.gtb.gov.tr//WebServices/IGenelService/GenelServisIlceler\"");
            client.Headers.Add("VsDebuggerCausalityData", "uIDPo/l8atIDoqFFniLRCUIFbKQAAAAA64uYbk/jW0K+h9kz55jWZeM1+BqDlnNPpgceAHjWSsYACQAA");
            //  client.Headers.Add("Content-Type", "text/xml");
            xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><soap:Body><BaseRequestMessageOf_IlcelerIstek xmlns=\"http://www.gtb.gov.tr//WebServices\"><Istek><IlId xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract\">" + iller.Body.BaseResponseMessageOf_IllerCevap.Sonuc.Iller.Where(x => x.IlAdi.ToUpper() == tempcar.il.ToUpper()).FirstOrDefault().Id + "</IlId></Istek><Password>Meypak140</Password><ServicePassword>18E932F8</ServicePassword><UserName>4300580693</UserName></BaseRequestMessageOf_IlcelerIstek></soap:Body></soap:Envelope>";
            client.Method = HttpMethod.Post;


            client.Content = new StringContent(xml,
                                        Encoding.UTF8,
                                        "text/xml");


            httpClient.DefaultRequestHeaders.ExpectContinue = false;
            HttpResponseMessage resp2 = httpClient.SendAsync(client).Result;
            var aaaa2 = resp2.Content.ReadAsStringAsync().Result;
            XmlSerializerHelper xmlSerializerHelper2 = new XmlSerializerHelper();
            var ilceler = (HKSIlceler.Envelope)xmlSerializerHelper2.DeserializeFromXml(typeof(HKSIlceler.Envelope), aaaa2);




            httpClient = new HttpClient();
            client = new HttpRequestMessage(HttpMethod.Post, "https://hks.hal.gov.tr/WebServices/GenelService.svc");
            client.Headers.Add("Connection", "keep-alive");
            client.Headers.Add("Host", "hks.hal.gov.tr");
            client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
            client.Headers.Add("SOAPAction", "\"http://www.gtb.gov.tr//WebServices/IGenelService/GenelServisBeldeler\"");
            client.Headers.Add("VsDebuggerCausalityData", "uIDPo/l8atIDoqFFniLRCUIFbKQAAAAA64uYbk/jW0K+h9kz55jWZeM1+BqDlnNPpgceAHjWSsYACQAA");
            //  client.Headers.Add("Content-Type", "text/xml");
            xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><soap:Body><BaseRequestMessageOf_BeldelerIstek xmlns=\"http://www.gtb.gov.tr//WebServices\"><Istek><IlceId xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract\">" + ilceler.Body.BaseResponseMessageOf_IlcelerCevap.Sonuc.Ilceler.Where(x => x.IlceAdi.ToUpper() == tempcar.ilce.ToUpper()).FirstOrDefault().Id + "</IlceId></Istek><Password>Meypak140</Password><ServicePassword>18E932F8</ServicePassword><UserName>4300580693</UserName></BaseRequestMessageOf_BeldelerIstek></soap:Body></soap:Envelope>";
            client.Method = HttpMethod.Post;


            client.Content = new StringContent(xml,
                                        Encoding.UTF8,
                                        "text/xml");


            httpClient.DefaultRequestHeaders.ExpectContinue = false;
            HttpResponseMessage resp3 = httpClient.SendAsync(client).Result;
            var aaaa3 = resp3.Content.ReadAsStringAsync().Result;
            XmlSerializerHelper xmlSerializerHelper3 = new XmlSerializerHelper();
            var beldeler = (HKSBeldeler.Envelope)xmlSerializerHelper3.DeserializeFromXml(typeof(HKSBeldeler.Envelope), aaaa3);

            HKSSatKunye.Envelope ten = new HKSSatKunye.Envelope();


            for (int i = 0; i < _tempIrsaliyeDetay.Count; i++)
            {
                string adsoyad = tempcar.unvan == "" ? tempcar.adi + " " + tempcar.soyadi : tempcar.unvan;
                int silceler = ilceler.Body.BaseResponseMessageOf_IlcelerCevap.Sonuc.Ilceler.Where(x => x.IlceAdi.ToLower() == tempcar.ilce.ToLower()).FirstOrDefault().Id;
                int siller = iller.Body.BaseResponseMessageOf_IllerCevap.Sonuc.Iller.Where(x => x.IlAdi.ToLower() == tempcar.il.ToLower()).FirstOrDefault().Id;
                int sbeldeler = beldeler.Body.BaseResponseMessageOf_BeldelerCevap.Sonuc.Beldeler.Where(x => x.BeldeAdi.ToLower() == tempcar.BELDE.ToLower()).FirstOrDefault().Id;
                ten = new HKSSatKunye.Envelope()
                {
                    Body = new HKSSatKunye.EnvelopeBody()
                    {
                        BaseRequestMessageOf_ListOf_BildirimKayitIstek = new HKSSatKunye.BaseRequestMessageOf_ListOf_BildirimKayitIstek()
                        {
                            Password = "Meypak140",
                            ServicePassword = "18E932F8",
                            UserName = 4300580693,
                            Istek = new HKSSatKunye.BaseRequestMessageOf_ListOf_BildirimKayitIstekIstek()
                            {


                                BildirimKayitIstek = new HKSSatKunye.BildirimKayitIstek()
                                {

                                    BildirimMalBilgileri = new HKSSatKunye.BildirimKayitIstekBildirimMalBilgileri()
                                    {
                                        MalinMiktari = Convert.ToDouble(_tempIrsaliyeDetay[i].safi),
                                        MalinSatisFiyat = Convert.ToDouble(_tempIrsaliyeDetay[i].netfiyat)

                                    },
                                    BildirimciBilgileri = new HKSSatKunye.BildirimKayitIstekBildirimciBilgileri()
                                    {
                                        KisiSifat = 6
                                    },
                                    BildirimTuru = tempirs.bildirimturuid,
                                    IkinciKisiBilgileri = new HKSSatKunye.BildirimKayitIstekIkinciKisiBilgileri()
                                    {
                                        AdSoyad = adsoyad,
                                        CepTel = tempcar.ceptel,
                                        Eposta = tempcar.eposta,
                                        KisiSifat = tempcar.SIFATID,
                                        TcKimlikVergiNo = tempcar.vergino == "" ? tempcar.tcno : tempcar.vergino,
                                    },
                                    MalinGidecekYerBilgileri = new HKSSatKunye.BildirimKayitIstekMalinGidecekYerBilgileri()
                                    {
                                        GidecekYerIsletmeTuruId = tempcar.SUBEID,
                                        AracPlakaNo = _araclarServis.obje.Where(x => x.id == tempirs.aracid).FirstOrDefault().plaka,

                                        GidecekYerIlId = siller,
                                        GidecekYerIlceId = silceler,
                                        GidecekYerBeldeId = sbeldeler

                                    },
                                    ReferansBildirimKunyeNo = _tempIrsaliyeDetay[i].kunye,
                                    UniqueId = Guid.NewGuid().ToString()
                                }

                            }
                        }
                    }
                };




                var xmlll = xmlSerializerHelper3.SerializeToXml(ten);

                httpClient = new HttpClient();
                client = new HttpRequestMessage(HttpMethod.Post, "https://hks.hal.gov.tr/WebServices/BildirimService.svc");
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("Host", "hks.hal.gov.tr");
                client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
                client.Headers.Add("SOAPAction", "\"http://www.gtb.gov.tr//WebServices/IBildirimService/BildirimServisBildirimKaydet\"");
                client.Headers.Add("VsDebuggerCausalityData", "uIDPo/l8atIDoqFFniLRCUIFbKQAAAAA64uYbk/jW0K+h9kz55jWZeM1+BqDlnNPpgceAHjWSsYACQAA");
                //  client.Headers.Add("Content-Type", "text/xml");
                // xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><soap:Body><BaseRequestMessageOf_BeldelerIstek xmlns=\"http://www.gtb.gov.tr//WebServices\"><Istek><IlceId xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract\">" + ilceler.Body.BaseResponseMessageOf_IlcelerCevap.Sonuc.Ilceler.Where(x => x.IlceAdi.ToUpper() == tempcar.ilce.ToUpper()).FirstOrDefault().Id + "</IlceId></Istek><Password>Meypak140</Password><ServicePassword>18E932F8</ServicePassword><UserName>4300580693</UserName></BaseRequestMessageOf_BeldelerIstek></soap:Body></soap:Envelope>";
                client.Method = HttpMethod.Post;


                client.Content = new StringContent(xmlll,
                                            Encoding.UTF8,
                                            "text/xml");


                httpClient.DefaultRequestHeaders.ExpectContinue = false;
                //HttpResponseMessage resp4 = httpClient.SendAsync(client).Result;
                string snc = "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\"><s:Body><BaseResponseMessageOf_ListOf_BildirimKayitCevap xmlns=\"http://www.gtb.gov.tr//WebServices\"><HataKodlari xmlns:a=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Core.ServiceContract\" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\"><a:ErrorModel><a:HataKodu>1</a:HataKodu><a:Mesaj>GTBWSRV0000001</a:Mesaj></a:ErrorModel></HataKodlari><IslemKodu>GTBWSRV0000001</IslemKodu><Sonuc xmlns:a=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\" xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\"><a:BildirimKayitCevap><a:AracPlakaNo>06TETS001</a:AracPlakaNo><a:BelgeNo i:nil=\"true\"/><a:BelgeTipi>0</a:BelgeTipi><a:HataKodu>0</a:HataKodu><a:KayitTarihi>2023-06-03T14:48:10.1175658+03:00</a:KayitTarihi><a:MalinCinsiId>1859</a:MalinCinsiId><a:MalinKodNo>438</a:MalinKodNo><a:MalinMiktari>0.1</a:MalinMiktari><a:MalinSahibAdi>PELİT KARDEŞLER GIDA TURİZM İNŞAAT HAYVANCILIK SANAYİ VE TİCARET LİMİTED ŞİRKETİ</a:MalinSahibAdi><a:Mesaj i:nil=\"true\"/><a:MiktarBirimId>74</a:MiktarBirimId><a:RusumMiktari>0</a:RusumMiktari><a:UniqueId>e52a9163-27de-4449-b341-f0b0153c9173</a:UniqueId><a:UreticisininAdUnvani>MUSTAFA YENİ</a:UreticisininAdUnvani><a:UretimBeldeId>4707</a:UretimBeldeId><a:UretimIlId>33</a:UretimIlId><a:UretimIlceId>107</a:UretimIlceId><a:UretimSekli>28</a:UretimSekli><a:YeniKunyeNo>2334389230076530668</a:YeniKunyeNo></a:BildirimKayitCevap></Sonuc></BaseResponseMessageOf_ListOf_BildirimKayitCevap></s:Body></s:Envelope>";
                var xmlllcevap = xmlSerializerHelper3.DeserializeFromXml<HKSSatCev.Envelope>(snc);

                _irsaliyeDetayServis.Data(ServisList.IrsaliyeDetayEkleServis, new PocoIRSALIYEDETAY(){

                    id= _tempIrsaliyeDetay[i].id,
               kunye = xmlllcevap.Body.BaseResponseMessageOf_ListOf_BildirimKayitCevap.Sonuc.BildirimKayitCevap.YeniKunyeNo.ToString(),
                aciklama= _tempIrsaliyeDetay[i].aciklama,
                bekleyenmiktar= _tempIrsaliyeDetay[i].bekleyenmiktar,
                birimfiyat= _tempIrsaliyeDetay[i].birimfiyat,
                birimid= _tempIrsaliyeDetay[i].birimid,
                brutfiyat= _tempIrsaliyeDetay[i].brutfiyat,
                bruttoplam= _tempIrsaliyeDetay[i].bruttoplam,
                dara= _tempIrsaliyeDetay[i].dara,
                darali= _tempIrsaliyeDetay[i].darali,
                dovizid= _tempIrsaliyeDetay[i].dovizid,
                eskiid= _tempIrsaliyeDetay[i].eskiid,
                guncellemetarihi= DateTime.Now,
                hareketdurumu= _tempIrsaliyeDetay[i].hareketdurumu,
                irsaliyeid= _tempIrsaliyeDetay[i].irsaliyeid,
                iskontO1= _tempIrsaliyeDetay[i].iskontO1,
                iskontO2=_tempIrsaliyeDetay[i].iskontO2,
                iskontO3= _tempIrsaliyeDetay[i].iskontO3,
                isktoplam= _tempIrsaliyeDetay[i].isktoplam,
                kasaid= _tempIrsaliyeDetay[i].kasaid,
                kasamiktar= _tempIrsaliyeDetay[i].kasamiktar,
                kayittipi= _tempIrsaliyeDetay[i].kayittipi,
                kdv= _tempIrsaliyeDetay[i].kdv,
                kdvtutari= _tempIrsaliyeDetay[i].kdvtutari,
                kullaniciid= _tempIrsaliyeDetay[i].kullaniciid,
                listefiyatid= _tempIrsaliyeDetay[i].listefiyatid,
                netfiyat= _tempIrsaliyeDetay[i].netfiyat,
                nettoplam= _tempIrsaliyeDetay[i].nettoplam,
                num= _tempIrsaliyeDetay[i].num,
                olusturmatarihi= _tempIrsaliyeDetay[i].olusturmatarihi,
                safi= _tempIrsaliyeDetay[i].safi,
                stokadi= _tempIrsaliyeDetay[i].stokadi,
                stokid= _tempIrsaliyeDetay[i].stokid,
                tip= _tempIrsaliyeDetay[i].tip,
               userid =MPKullanici.ID

                    });
            }
            MessageBox.Show("Künyeler başarıyla oluşturuldu.");
        }
    }
}
