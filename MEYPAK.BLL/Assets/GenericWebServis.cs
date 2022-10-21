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
    #region OdataKullanımı

    /// <summary>
    /// eq	Equals      to	                 $filter=priority eq 1
    // ne	Not equals  to	                 $filter=priority ne 1
    // gt	Greater     than	             $filter=priority gt 1
    // ge	Greater     than or equal	     $filter=priority ge 1
    // lt	Less        than	             $filter=priority lt 1
    // le	Less        than or equal	     $filter=priority le 1
    // and	            Logical and	         $filter=priority gt 1 and priority lt 10
    // or	            Logical or	         $filter=priority gt 1 or priority lt 10
    // not	            Logical negation	 $filter=not endswith(name,'task')
    /// </summary>
    /// <typeparam name="T"></typeparam>
    #endregion

    public class GenericWebServis<T> where T : class, new()
    {
        string serialize;
        public List<T> obje;
        public T obje2;
       
        public void Data(string servis,T model=null,string parameters=null,List<T> modellist=null)
        {
            if(modellist!=null)
                serialize = JsonConvert.SerializeObject(modellist);
            if(model!=null)
            serialize = JsonConvert.SerializeObject(model);
            //string empty = "\" \"";
            //serialize = Regex.Replace(serialize, @"\bnull\b", $"{empty}");
            servis= parameters != null ? servis + "?$" + parameters : servis;
            HttpRequestMessage client;
            HttpClient httpClient = new HttpClient();
            if(model == null && modellist == null)
            client = new HttpRequestMessage(HttpMethod.Get, servis);
            else
                client = new HttpRequestMessage(HttpMethod.Post, servis);
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
            if(model != null || modellist!=null)
                client.Content = new StringContent(serialize,
                                        Encoding.UTF8,
                                        "application/json");

            HttpResponseMessage resp =   httpClient.Send(client);
            var a = resp.Content.ReadAsStringAsync().Result;
            try
            {

                if (model == null&&modellist==null)
                    obje = JsonConvert.DeserializeObject<List<T>>(a);
           
        
            }
            catch (Exception)
            {

               throw new Exception(a.ToString());
            }

        }
    }
}
