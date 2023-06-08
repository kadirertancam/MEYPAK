using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.PRL.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MEYPAK.PRL.CARI
{
    public partial class HKSILSec : Form
    {
        PocoCARIKART _tempCariKart;
        string _vergiNo;
        public HKSILSec(PocoCARIKART tempCariKart,string vergiNo)
        {
            InitializeComponent();
            _tempCariKart=tempCariKart;
            _cariAltHesapServis = new GenericWebServis<PocoCARIALTHES>();
            _beldelerservis = new GenericWebServis<PocoHKSBELDELER>();
            _ilcelerservis = new GenericWebServis<PocoHKSILCELER>();
            _illerservis = new GenericWebServis<PocoHKSILLER>();
            _cariAltHesCariServis = new GenericWebServis<PocoCARIALTHESCARI>();
            _sevkAdresServis = new GenericWebServis<PocoSEVKADRES>();
            _vergiNo =vergiNo;
        }

        private void HKSILSec_Load(object sender, EventArgs e)
        {

            _illerservis.Data(ServisList.HksIllerListeServis);
            _ilcelerservis.Data(ServisList.HksIlcelerListeServis);
            _beldelerservis.Data(ServisList.HksBeldelerListeServis);
            gridControl1.DataSource = _illerservis.obje.Select(x => new {ID=x.ilid, IL = x.iladi });
        }
        GenericWebServis<PocoHKSILLER> _illerservis;
        GenericWebServis<PocoHKSILCELER> _ilcelerservis;
        GenericWebServis<PocoHKSBELDELER> _beldelerservis;
        GenericWebServis<PocoCARIALTHES> _cariAltHesapServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoSEVKADRES> _sevkAdresServis;
        HKSGenelSubeList.Envelope genelsube;
        private void button1_Click(object sender, EventArgs e)
        {
            if (_tempCariKart != null)
            {
                var httpClient = new HttpClient();
                var client = new HttpRequestMessage(HttpMethod.Post, "https://hks.hal.gov.tr/WebServices/GenelService.svc");
                client.Headers.Add("Connection", "keep-alive");
                client.Headers.Add("Host", "hks.hal.gov.tr");
                client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
                client.Headers.Add("SOAPAction", "\"http://www.gtb.gov.tr//WebServices/IGenelService/GenelServisSubeler\"");
                client.Headers.Add("VsDebuggerCausalityData", "uIDPo/l8atIDoqFFniLRCUIFbKQAAAAA64uYbk/jW0K+h9kz55jWZeM1+BqDlnNPpgceAHjWSsYACQAA");
                //  client.Headers.Add("Content-Type", "text/xml");
                var xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><soap:Body><BaseRequestMessageOf_SubelerIstek xmlns=\"http://www.gtb.gov.tr//WebServices\"><Istek><TcKimlikVergiNo xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Genel.ServiceContract\">" + _vergiNo + "</TcKimlikVergiNo></Istek><Password>Meypak140</Password><ServicePassword>18E932F8</ServicePassword><UserName>4300580693</UserName></BaseRequestMessageOf_SubelerIstek></soap:Body></soap:Envelope>";
                client.Method = HttpMethod.Post;


                client.Content = new StringContent(xml,
                                            Encoding.UTF8,
                                            "text/xml");


                httpClient.DefaultRequestHeaders.ExpectContinue = false;
                var resp3 = httpClient.SendAsync(client).Result;
                var aaaa3 = resp3.Content.ReadAsStringAsync().Result;
                var xmlSerializerHelper3 = new XmlSerializerHelper();
                genelsube = (HKSGenelSubeList.Envelope)xmlSerializerHelper3.DeserializeFromXml(typeof(HKSGenelSubeList.Envelope), aaaa3);

            }
            progressBarControl1.Properties.Maximum = gridView1.GetSelectedRows().Length;
                foreach (var item3 in gridView1.GetSelectedRows())
            {
                if (item3 != -1)
                {
                    if (_tempCariKart != null)
                    {
                         
                        foreach (var item in genelsube.Body.BaseResponseMessageOf_SubelerCevap.Sonuc.Subeler.Where(x => x.IsyeriTuru == 12 && x.IlId.ToString()== gridView1.GetRowCellValue(item3,"ID").ToString()))
                        {

                            if(item.Id.ToString().Contains("30239")|| item.SubeAdi=="")
                            {
                                string qqq = "";
                            }


                            _cariAltHesapServis.Data(ServisList.CariAltHesEkleServis, new PocoCARIALTHES()
                            {
                                kod = item.Id.ToString(),
                                adi = item.SubeAdi,
                                dovizid = 1,
                                aktif = 1,
                                userid = MPKullanici.ID,

                            });
                            _cariAltHesCariServis.Data(ServisList.CariAltHesCariEkleServis, new PocoCARIALTHESCARI()
                            {
                                cariid = _tempCariKart.id,
                                carialthesid = _cariAltHesapServis.obje2.id,
                                userid = MPKullanici.ID,

                            });

                            _sevkAdresServis.Data(ServisList.SevkAdresEkleServis, new PocoSEVKADRES()
                            {
                                althesapid = _cariAltHesapServis.obje2.id,
                                sokak = item.Adres,
                                mahalleid = item.BeldeId,
                                mahalle = _beldelerservis.obje.Where(x => x.beldeid == item.BeldeId).FirstOrDefault().beldeadi,
                                ilid = item.IlId,
                                il = _illerservis.obje.Where(x => x.ilid == item.IlId).FirstOrDefault().iladi,
                                ilceid = item.IlceId,
                                ilce = _ilcelerservis.obje.Where(x => x.ilceid == item.IlceId).FirstOrDefault().ilceadi,
                                kodu = item.Id.ToString(),
                                daire = "0",
                                apartman = "0",
                                userid = MPKullanici.ID


                            });
                        }
                       

                    }
                    progressBarControl1.Position += 1;
                }
                MessageBox.Show("Kayıtlar başarıyla aktarıldı.");
            }
        }
    }
}
