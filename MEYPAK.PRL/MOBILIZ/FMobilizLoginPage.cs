using LiveCharts.Wpf;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.ARAC.Mobiliz;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces;
using MEYPAK.PRL.MOBILIZ.MobilizAssets;
using MEYPAK.PRL.STOK;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer.Utilities;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEYPAK.PRL.MOBILIZ
{
    public partial class FMobilizLoginPage : Form
    {
        public FMobilizLoginPage()
        {
            InitializeComponent();
            _aracServis = new GenericWebServis<PocoARACLAR>();
        }
        UserLogin.Root loginresp;
        FMobilizPanel mpanel;
        Main main;
        GenericWebServis<PocoARACLAR> _aracServis;
        private async void button1_Click(object sender, EventArgs e)
        {
             Login(textBox1.Text, textBox2.Text); 
           
        }

        async void Login(string eposta, string parola)
        {

            HttpClient httpClient = new HttpClient();
            var client = new HttpRequestMessage(HttpMethod.Post, "https://ng.mobiliz.com.tr/su7/sso/login/userLogin");

            client.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            client.Headers.Add("Sec-Fetch-Site", "same-site");
            client.Headers.Add("Sec-Fetch-Mode", "cors");
            client.Headers.Add("Sec-Fetch-Dest", "empty");
            //  client.Headers.Add("Access-Control-Request-Header", "content-type,x-client-type,x-client-version,x-container-id,x-csrf-token");

            client.Headers.Add("Mobiliz-App-Token", "UKq9uX6VMHB38434h27gRirtopX376407qd711299H3L3894Vs9U46QEVFaYp0MW");
            client.Headers.Add("Mobiliz-User-Language", "tr_TR");
            client.Headers.Add("Referer", @"https://ng.mobiliz.com.tr/");
            //  client.Headers.Add("If-None-Match", $"W/\"01131748e4a367afaebdfc6bb7b2faadf\"");
            //  client.Headers.Add("Origin", @"https://account.grammarly.com");
            //  client.Headers.Add("Access-Control-Request-Method", "POST");

            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.0.0 Safari/537.36");

            // client.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9");
            client.Headers.Add("Cookie", $"_gcl_aw=GCL.1665749475.CjwKCAjwkaSaBhA4EiwALBgQaBh-3WPeY2rrzuFq6C3ITxMHYAdu9DjDp8GyHxcjW8g4lMalrEyaSBoC12YQAvD_BwE; _gcl_au=1.1.1808461410.1665749475; _gid=GA1.3.2016968108.1665749475; _gac_UA-111853802-1=1.1665749475.CjwKCAjwkaSaBhA4EiwALBgQaBh-3WPeY2rrzuFq6C3ITxMHYAdu9DjDp8GyHxcjW8g4lMalrEyaSBoC12YQAvD_BwE; _fbp=fb.2.1665749474834.817731395; _ga_18SE6FWZYW=GS1.1.1665816040.2.0.1665816040.0.0.0; _ga=GA1.3.1707220265.1664808166");
            client.Content = new StringContent("{\"userName\":\"" + eposta + "\",\"password\":\"" + parola + "\"}",
                                  Encoding.UTF8,
                                  "application/json");

            var resp = await httpClient.SendAsync(client);
            var a = resp.Content.ReadAsStringAsync().Result;
            loginresp = JsonConvert.DeserializeObject<UserLogin.Root>(a);
            if (loginresp.result != null)
            {
                //main = (Main)Application.OpenForms["Main"];
                mpanel = new FMobilizPanel(loginresp.result.token);
                //main.panel2.Controls.Clear();
                //mpanel.TopLevel = false;
                //mpanel.AutoScroll = true;
                //mpanel.Dock = DockStyle.Fill;
                //main.panel2.Controls.Add(mpanel);
                AracListKontrol(loginresp.result.token);
                mpanel.Show();
            }

            //using (BrotliStream bs = new BrotliStream(resp.Content.ReadAsStreamAsync().Result, System.IO.Compression.CompressionMode.Decompress))
            //{
            //    using (System.IO.MemoryStream msOutput = new System.IO.MemoryStream())
            //    {
            //        bs.CopyTo(msOutput);
            //        msOutput.Seek(0, System.IO.SeekOrigin.Begin);
            //        using (StreamReader reader = new StreamReader(msOutput))
            //        {
            //           var html = reader.ReadToEnd();
            //        }
            //    }
            //}
            //   UserLogin user = JsonConvert.DeserializeObject<UserLogin>(a.Result);

        }

        async void AracListKontrol(string token)
        {
            HttpClient httpClient = new HttpClient();
            var client = new HttpRequestMessage(HttpMethod.Get, MOBILIZSERVISLIST.ARACLIST);

            client.Headers.Add("sec-ch-ua-platform", $"\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
            client.Headers.Add("sec-ch-ua", "\"Windows\"");
            client.Headers.Add("Sec-Fetch-Site", "same-site");
            client.Headers.Add("Sec-Fetch-Mode", "cors");
            client.Headers.Add("Sec-Fetch-Dest", "empty");
            client.Headers.Add("sec-ch-ua-mobile", "?0");
            client.Headers.Add("If-None-Match", $"W/\"07e63b8dba5ff3fd69f6341d17119f0c9\"");
            client.Headers.Add("Connection", "keep-alive");
            client.Headers.Add("Mobiliz-Token", token);
            client.Headers.Add("Referer", @"https://ng.mobiliz.com.tr/");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/105.0.0.0 Safari/537.36");
            client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
            client.Headers.Add("Accept", "application/json, text/plain, */*");
            //client.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            client.Headers.Add("Cookie", $"_gcl_aw=GCL.1665749475.CjwKCAjwkaSaBhA4EiwALBgQaBh-3WPeY2rrzuFq6C3ITxMHYAdu9DjDp8GyHxcjW8g4lMalrEyaSBoC12YQAvD_BwE; _gcl_au=1.1.1808461410.1665749475; _gid=GA1.3.2016968108.1665749475; _gac_UA-111853802-1=1.1665749475.CjwKCAjwkaSaBhA4EiwALBgQaBh-3WPeY2rrzuFq6C3ITxMHYAdu9DjDp8GyHxcjW8g4lMalrEyaSBoC12YQAvD_BwE; _fbp=fb.2.1665749474834.817731395; _ga_18SE6FWZYW=GS1.1.1665816040.2.0.1665816040.0.0.0; _ga=GA1.3.1707220265.1664808166");

            //client.Content = new StringContent("{\"userName\":\""  + "\",\"password\":\"" +  "\"}",
            //                      Encoding.UTF8,
            //                      "application/json");

            var resp = await httpClient.SendAsync(client);
            var a =   resp.Content.ReadAsStringAsync().Result;
            var b = JsonConvert.DeserializeObject<AracList.Root>(a);
            _aracServis.Data(ServisList.AracListeServis);
            foreach (var item in b.result)
            {
                if (!_aracServis.obje.Any(x => x.muId == item.muId))
                {
                    _aracServis.Data(ServisList.AracEkleServis, new PocoARACLAR()
                    {
                        companyName = item.companyName,
                        canbusProfile = item.canbusProfile == null ? "" : item.canbusProfile,
                        deviceType = item.deviceType,
                        fleetId = item.fleetId,
                        fleetName = item.fleetName,
                        groupId = item.groupId,
                        groupName = item.groupName,
                        hardwareVersion = item.hardwareVersion,
                        label = item.label == null ? "" : item.label,
                        muId = item.muId,
                        networkId = item.networkId,
                        phone = item.phone == null ? "" : item.phone,
                        plate = item.plate,
                        softwareSubVersion = item.softwareSubVersion == null ? "" : item.softwareSubVersion,
                        softwareVersion = item.softwareVersion,
                        timezone = item.timezone
                    });
                }
            }

        }
    }
}
