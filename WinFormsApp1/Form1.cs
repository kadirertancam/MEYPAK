using Microsoft.VisualBasic;
using ServiceReference1;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Windows.Forms.Design;
using System.Xml.Serialization;
using static ServiceReference1.GenelServiceClient;

using System.Xml.Linq;
using static WinFormsApp1.Class2;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpRequestMessage client;
            HttpClient httpClient = new HttpClient(); 
            client = new HttpRequestMessage(HttpMethod.Post, "https://hks.hal.gov.tr/WebServices/UrunService.svc");
            client.Headers.Add("Connection", "keep-alive");
            client.Headers.Add("Host","hks.hal.gov.tr");
            client.Headers.Add("SOAPAction", "\"http://www.gtb.gov.tr//WebServices/IUrunService/UrunServiceUrunler\"");
            client.Headers.Add("VsDebuggerCausalityData", "uIDPo/l8atIDoqFFniLRCUIFbKQAAAAA64uYbk/jW0K+h9kz55jWZeM1+BqDlnNPpgceAHjWSsYACQAA");
            client.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; MS Web Services Client Protocol 4.0.30319.42000)");
            //  client.Headers.Add("Content-Type", "text/xml");
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><soap:Body><BaseRequestMessageOf_UrunlerIstek xmlns=\"http://www.gtb.gov.tr//WebServices\"><Istek /><Password>Meypak139</Password><ServicePassword>18E932F8</ServicePassword><UserName>4300580693</UserName></BaseRequestMessageOf_UrunlerIstek></soap:Body></soap:Envelope>";
            client.Method = HttpMethod.Post;
            

            client.Content = new StringContent(xml,
                                        Encoding.UTF8,
                                        "text/xml");
           

           
            httpClient.DefaultRequestHeaders.ExpectContinue = true;
            //client.Content.Headers.Add("Content-Type", "text/xml");
            HttpResponseMessage resp =   httpClient.Send(client);
            var aaaa = resp.Content.ReadAsStringAsync().Result;
            XmlSerializer MySerializer = new XmlSerializer(typeof(Envelope));
            StreamReader sr = new StreamReader(aaaa);
            Envelope o = (Envelope)MySerializer.Deserialize(sr);
            dataGridView1.DataSource = o;


        }

            
            return TW.ToString();
        }
    }
}