﻿using DevExpress.XtraRichEdit.Import.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ServiceReference1;
using MEYPAK.BLL.Assets;
using DevExpress.XtraEditors.Repository;
using MEYPAK.PRL.Assets;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Entity.PocoModels.CARI;

namespace MEYPAK.PRL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ıntegrationClient.ClientCredentials.UserName.UserName = "Gunduz";
            ıntegrationClient.ClientCredentials.UserName.Password = "iJAfhKSU";
           // islem();
        }

        ServiceReference1.IntegrationClient ıntegrationClient = new ServiceReference1.IntegrationClient();
        ServiceReference2.BasicIntegrationClient basicIntegration = new ServiceReference2.BasicIntegrationClient();
        ServiceReference1.WhoAmIInfo bb;
        List<InboxInvoiceListItem> gelenefaturatasktemp;
        ServiceReference1.InvoiceResponse tempp;
        List<FaturaDetailList> tempdetay;
        InvoicesResponse res;
        RepositoryItemButtonEdit repositoryItemButtonEdit3;
        public PocoSTOK _tempStok;
        public PocoCARIKART _tempCari;
        GenericWebServis<PocoSTOK> _stokServis;
        GenericWebServis<PocoCARIKART> _cariServis;
        GenericWebServis<PocoCARIALTHESCARI> _cariAltHesCariServis;
        GenericWebServis<PocoFATURASTOKOLCUBR> _faturaStokOlcuBrServis;
        GenericWebServis<PocoOLCUBR> olcuBrServis;



        List<BildirimSorguDTO> envelopes = new List<BildirimSorguDTO>();
        DateTime basTar = Convert.ToDateTime("01.01.2014");
        // 6200585694 Meypak140 65FISI4C
        // 4300580693 Meypak139 18E932F8
       
        void islem()
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            { 
                for (int i = 0; i < 150; i++)
                {


                    try
                    {
                        HttpRequestMessage client;
                        HttpClient httpClient = new HttpClient();
                        client = new HttpRequestMessage(HttpMethod.Post, "https://hks.hal.gov.tr/WebServices/BildirimService.svc");
                        client.Headers.Add("Connection", "keep-alive");
                        client.Headers.Add("Host", "hks.hal.gov.tr");
                        client.Headers.Add("User-Agent", "CodeGear SOAP 1.3");
                        DateTime dt_Ay_ilkGun = basTar.AddMonths(i);
                        DateTime dt_Ay_sonGun = dt_Ay_ilkGun.AddMonths(1);
                        client.Headers.Add("SOAPAction", "\"http://www.gtb.gov.tr//WebServices/IBildirimService/BildirimServisBildirimciyeYapilanBildirimListesi\"");
                        client.Headers.Add("VsDebuggerCausalityData", "uIDPo/l8atIDoqFFniLRCUIFbKQAAAAA64uYbk/jW0K+h9kz55jWZeM1+BqDlnNPpgceAHjWSsYACQAA");
                        //  client.Headers.Add("Content-Type", "text/xml");
                        string xml = "<?xml version=\"1.0\"?>\r\n<SOAP-ENV:Envelope xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><SOAP-ENV:Body><BaseRequestMessageOf_BildirimSorguIstek xmlns=\"http://www.gtb.gov.tr//WebServices\"><Istek><BaslangicTarihi xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\">" + dt_Ay_ilkGun.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK") + "</BaslangicTarihi><BitisTarihi xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\">" + dt_Ay_sonGun.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK") + "</BitisTarihi><KalanMiktariSifirdanBuyukOlanlar xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\">true</KalanMiktariSifirdanBuyukOlanlar><KunyeNo xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\">0</KunyeNo><KunyeTuru xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\">1</KunyeTuru><Sifat xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\">6</Sifat><UniqueId xmlns=\"http://schemas.datacontract.org/2004/07/GTB.HKS.Bildirim.ServiceContract\"></UniqueId></Istek><Password>Meypak139</Password><ServicePassword>18E932F8</ServicePassword><UserName>4300580693</UserName></BaseRequestMessageOf_BildirimSorguIstek></SOAP-ENV:Body></SOAP-ENV:Envelope>\r\n";
                        client.Method = HttpMethod.Post;


                        client.Content = new StringContent(xml,
                                                    Encoding.UTF8,
                                                    "text/xml");


                        httpClient.DefaultRequestHeaders.ExpectContinue = false;
                        HttpResponseMessage resp = httpClient.SendAsync(client).Result;
                        var aaaa = resp.Content.ReadAsStringAsync().Result.ToString();
                        XmlSerializerHelper xmlSerializerHelper = new XmlSerializerHelper();
                        var deserializedObject = (Envelope)xmlSerializerHelper.DeserializeFromXml(typeof(Envelope), aaaa);
                        foreach (var item in deserializedObject.Body.BaseResponseMessageOf_BildirimSorguCevap.Sonuc.Bildirimler)
                        {
                            envelopes.Add(item);
                        }
                    }
                    catch (Exception)
                    {

                       
                    }
                }

                gridControl1.DataSource = envelopes;
               
                gridView1.ExportToXlsx(sv.FileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        public void GidenFaturaIsle() {

            DateTime aaa = DateTime.Now.AddDays(-15);
                res = ıntegrationClient.GetOutboxInvoicesAsync( new ServiceReference1.InvoiceQueryModel
                {
                    PageIndex = 0,
                    PageSize = 9999999,
                    ExecutionStartDate=DateTime.Now,
                    ExecutionEndDate= aaa

                }).Result;
          

        }
    }
}
