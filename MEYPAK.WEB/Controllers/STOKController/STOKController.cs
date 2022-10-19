using MEYPAK.DAL.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Mvc;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Entity.Models.STOK;
using System.Data;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.WEB.Models;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.RegularExpressions;
using MEYPAK.BLL.Assets;

namespace MEYPAK.WEB.Controllers.STOKController
{
    public class StokController : Controller
    {


        private readonly ILogger<StokController> _logger;
        GenericWebServis<PocoSTOK> _tempPocoStok = new GenericWebServis<PocoSTOK>();
        GenericWebServis<PocoHIZMET> _tempPocoHizmet = new GenericWebServis<PocoHIZMET>();
        GenericWebServis<PocoOLCUBR> _tempPocoOlcuBr = new GenericWebServis<PocoOLCUBR>();
        GenericWebServis<PocoSTOKFIYATLIST> _tempPocoStokFiyatList = new GenericWebServis<PocoSTOKFIYATLIST>();

        string BaseURL = "http://213.238.167.117:8080";
        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;
            
        }



        #region STOK
        [HttpGet]
  
        public async Task<IActionResult> StokKart()
        {
            _tempPocoStok.Data(ServisList.StokListeServis);
            return View(_tempPocoStok.obje);
        }

        [HttpGet]
        public IActionResult StokEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokEkle(PocoSTOK pModel)
        {
            _tempPocoStok.Data(ServisList.StokEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region HIZMET
        [HttpGet]
        public async Task<IActionResult> HizmetKart()
        {
            _tempPocoHizmet.Data(ServisList.HizmetListeServis);
            return View(_tempPocoStok.obje);
        }

        [HttpGet]
        public IActionResult HizmetEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HizmetEkle(PocoHIZMET pModel)
        {
            string serialize = JsonConvert.SerializeObject(pModel);
            string empty = "\" \"";
            serialize = Regex.Replace(serialize, @"\bnull\b", $"{empty}");
            HttpResponseMessage resp;
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage client = new HttpRequestMessage(HttpMethod.Post, BaseURL + @"/HIZMET/HIZMETEkle"))
                {
                    client.Headers.Add("Connection", "keep-alive");
                    client.Headers.Add("accept", "*/*"); //http://localhost:5158/swagger/index.html
                    client.Headers.Add("Referer", @"http://213.238.167.117:8080/HIZMET/HIZMETEkle");
                    client.Headers.Add("Origin", "http://213.238.167.117:8080");
                    client.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
                    client.Headers.Add("sec-ch-ua-mobile", "?0");
                    client.Headers.Add("sec-ch-ua-paltform", "\"Windows\"");
                    client.Headers.Add("Sec-Fetch-Dest", "empty");
                    client.Headers.Add("Sec-Fetch-Mode", "cors");
                    client.Headers.Add("Sec-Fetch-Site", "same-origin");
                    client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
                    client.Content = new StringContent(serialize,
                                            Encoding.UTF8,
                                            "application/json");



                    resp = httpClient.Send(client);
                }
            }
            var a = resp.Content.ReadAsStringAsync();

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }

        #endregion

        #region OLCUBR
        [HttpGet]
        public async Task<IActionResult> OlcuBrKart()
        {
             _tempPocoOlcuBr.Data(ServisList.OlcuBrListeServis);
            return View(_tempPocoStok.obje);
        }

        [HttpGet]
        public IActionResult OlcuBrEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OlcuBrEkle(PocoOLCUBR pModel)
        {
            string serialize = JsonConvert.SerializeObject(pModel);
            string empty = "\" \"";
            serialize = Regex.Replace(serialize, @"\bnull\b", $"{empty}");
            HttpResponseMessage resp;
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage client = new HttpRequestMessage(HttpMethod.Post, BaseURL + @"/OLCUBR/OLCUBREkle"))
                {
                    client.Headers.Add("Connection", "keep-alive");
                    client.Headers.Add("accept", "*/*"); //http://localhost:5158/swagger/index.html
                    client.Headers.Add("Referer", @"http://213.238.167.117:8080/OLCUBR/OLCUBREkle");
                    client.Headers.Add("Origin", "http://213.238.167.117:8080");
                    client.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
                    client.Headers.Add("sec-ch-ua-mobile", "?0");
                    client.Headers.Add("sec-ch-ua-paltform", "\"Windows\"");
                    client.Headers.Add("Sec-Fetch-Dest", "empty");
                    client.Headers.Add("Sec-Fetch-Mode", "cors");
                    client.Headers.Add("Sec-Fetch-Site", "same-origin");
                    client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
                    client.Content = new StringContent(serialize,
                                            Encoding.UTF8,
                                            "application/json");



                    resp = httpClient.Send(client);
                }
            }
            var a = resp.Content.ReadAsStringAsync();

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }

        #endregion

        #region STOKFIYATLIST
    
        [HttpGet]

        public async Task<IActionResult> StokFiyatListKart()
        {

           _tempPocoStokFiyatList.Data(ServisList.StokFiyatListListeServis);
            return View(_tempPocoStokFiyatList.obje);
        }

        [HttpGet]
        public IActionResult StokFiyatListEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokFiyatListEkle(PocoSTOKFIYATLIST pModel)
        {
            string serialize = JsonConvert.SerializeObject(pModel);
            string empty = "\" \"";
            serialize = Regex.Replace(serialize, @"\bnull\b", $"{empty}");
            HttpResponseMessage resp;
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage client = new HttpRequestMessage(HttpMethod.Post, BaseURL + @"/STOKFIYATLIST/STOKFIYATLISTEkle"))
                {
                    client.Headers.Add("Connection", "keep-alive");
                    client.Headers.Add("accept", "*/*"); //http://localhost:5158/swagger/index.html
                    client.Headers.Add("Referer", @"http://213.238.167.117:8080/STOKFIYATLIST/STOKFIYATLISTEkle");
                    client.Headers.Add("Origin", "http://213.238.167.117:8080");
                    client.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"106\", \"Google Chrome\";v=\"106\", \"Not;A=Brand\";v=\"99\"");
                    client.Headers.Add("sec-ch-ua-mobile", "?0");
                    client.Headers.Add("sec-ch-ua-paltform", "\"Windows\"");
                    client.Headers.Add("Sec-Fetch-Dest", "empty");
                    client.Headers.Add("Sec-Fetch-Mode", "cors");
                    client.Headers.Add("Sec-Fetch-Site", "same-origin");
                    client.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7");
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/106.0.0.0 Safari/537.36");
                    client.Content = new StringContent(serialize,
                                            Encoding.UTF8,
                                            "application/json");



                    resp = httpClient.Send(client);
                }
            }
            var a = resp.Content.ReadAsStringAsync();

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
      
        #endregion




    }
}
