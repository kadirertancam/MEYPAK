using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.MOBILIZ.MobilizAssets
{
    public class MobilizGenericData<T> where T : class
    {
       public T Data(string servis,string token) 
        {
            T obje;
            HttpClient httpClient = new HttpClient();
            var client = new HttpRequestMessage(HttpMethod.Get, servis);

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


            HttpResponseMessage resp =  httpClient.Send(client);
            var a = resp.Content.ReadAsStringAsync().Result;
            obje = JsonConvert.DeserializeObject<T>(a);

            return obje;

        }
    }
}
