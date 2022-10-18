using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MEYPAK.BLL.Assets
{
    public class GenericWebServis<T> where T : class, new()
    {
        string serialize;
        List<T> obje;
        public   List<T> Data(string servis,T model=null)
        {
            serialize = JsonConvert.SerializeObject(model);
            string empty = "\" \"";
            serialize = Regex.Replace(serialize, @"\bnull\b", $"{empty}");

            HttpClient httpClient = new HttpClient();
            var client = new HttpRequestMessage(HttpMethod.Get, servis);

            client.Headers.Add("Connection", "keep-alive");
            client.Headers.Add("accept", "*/*");  
            client.Headers.Add("Referer", servis);
            client.Headers.Add("Origin", "http://213.238.167.117:8080");
            client.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
            client.Headers.Add("sec-ch-ua-mobile", "?0");
            client.Headers.Add("sec-ch-ua-paltform", "\"Windows\"");
            client.Headers.Add("Sec-Fetch-Dest", "empty");
            client.Headers.Add("Sec-Fetch-Mode", "cors");
            client.Headers.Add("Sec-Fetch-Site", "same-origin");
            client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
            if(model != null)
                client.Content = new StringContent(serialize,
                                        Encoding.UTF8,
                                        "application/json");

            HttpResponseMessage resp = httpClient.Send(client);
            var a = resp.Content.ReadAsStringAsync().Result;
            obje = JsonConvert.DeserializeObject<List<T>>(a);
            return obje;

        }
    }
}
