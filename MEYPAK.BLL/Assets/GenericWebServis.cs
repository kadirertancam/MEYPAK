using MEYPAK.DAL.Migrations;
using MEYPAK.Entity.IdentityModels;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Reflection;
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
        public GenericWebServis() {
            httpClient = new HttpClient();
        }
        string serialize;
        public List<T> obje;
        public T obje2;
        public string Content="";
        public LoginResultModel loginResult;
        HttpClient httpClient;

        public void Data(string servis,T model=null,string parameters=null,List<T> modellist=null,string id=null, HttpMethod method =null)
        {
            if(modellist!=null)
                serialize = JsonConvert.SerializeObject(modellist);
            if(model!=null)
            serialize = JsonConvert.SerializeObject(model);
            //string empty = "\" \"";
            //serialize = Regex.Replace(serialize, @"\bnull\b", $"{empty}");
           // servis= parameters != null ? servis + "?" + parameters : servis;
           // servis = id != null ? servis + "?id=" + id : servis;
            HttpRequestMessage client;
            
                
            if (method != null)
                client = new HttpRequestMessage(method,servis);
            else if (model == null && modellist == null)
                client = new HttpRequestMessage(HttpMethod.Get, servis);
            else
                client = new HttpRequestMessage(HttpMethod.Post, servis);
            client.Headers.Add("Connection", "keep-alive");
            client.Headers.Add("accept", "*/*");  
            client.Headers.Add("Referer", servis);
            client.Headers.Add("Origin", "http://78.135.80.41:8081");
            client.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
            client.Headers.Add("sec-ch-ua-mobile", "?0");
            client.Headers.Add("sec-ch-ua-paltform", "\"Windows\"");
            if (ServisList.Cookie!="")
            client.Headers.Add("Cookie", ".AspNetCore.Identity.Application="+ ServisList.Cookie);
            client.Headers.Add("Sec-Fetch-Dest", "empty");
            client.Headers.Add("Sec-Fetch-Mode", "cors");
            client.Headers.Add("Sec-Fetch-Site", "same-origin");
            client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
            if(model != null || modellist!=null)
                client.Content = new StringContent(serialize,
                                        Encoding.UTF8,
                                        "application/json");
            if(parameters!= null)
                client.Content = new StringContent(parameters,
                                       Encoding.UTF8,
                                       "application/json");

            HttpResponseMessage resp =   httpClient.Send(client);
            Content = resp.Content.ReadAsStringAsync().Result;
            try
            {
                obje2 = new T();
               
                if (model == null&&modellist==null && method==null)
                    obje = JsonConvert.DeserializeObject<List<T>>(Content);
                if (model != null)
                {
                    obje2 = new T();
                    if (obje2.GetType().Name == "LoginModel" )
                    {
                        if (resp.ToString().Contains("StatusCode: 200"))
                        {
                            ServisList.Cookie = Regex.Match(resp.Headers.ToString(), ".AspNetCore.Identity.Application=" + ".*?" + ";").Value.Replace(".AspNetCore.Identity.Application=", "").Replace(";", "");
                            loginResult = JsonConvert.DeserializeObject<LoginResultModel>(Content);
                        }
                    }
                    else
                    obje2 = JsonConvert.DeserializeObject<T>(Content);
                }
                   

            }
            catch  
            {
           
                throw new Exception(Content.ToString());
            }

        }

        
    }
}
