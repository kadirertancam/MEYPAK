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

namespace MEYPAK.WEB.Controllers
{
    public class StokController : Controller
    {

        static MEYPAKContext context = new MEYPAKContext();

        private readonly ILogger<StokController> _logger;


        string BaseURL = "http://213.238.167.117:8080";
        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> StokKart()
        {

            DataTable dt = new DataTable() ;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync("/Stok/STOKListe");
             
                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                 //   results = "["
                    dt = JsonConvert.DeserializeObject<DataTable>(results);
                }
            }
            return View(dt);
        }

        [HttpPost]
        public IActionResult StokKart(List<MPSTOK> mPSTOKs)
        {


            return View();
        }
        [HttpGet]
        public IActionResult StokEkle()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokEkle(PocoSTOK PStok)
        {
            string serialize = JsonConvert.SerializeObject(PStok);

      
            HttpResponseMessage resp; 
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage client = new HttpRequestMessage(HttpMethod.Post, BaseURL + @"/Stok/STOKEkle"))
                {

                    client.Headers.Add("Accept", "application/json");
                    client.Content = new StringContent(serialize,
                                            Encoding.UTF8,
                                            "application/json");



                    resp = httpClient.PostAsJsonAsync<PocoSTOK>(@"http://213.238.167.117:8080/Stok/STOKEkle", PStok).Result;
                }
            }
            var a= resp.Content.ReadAsStringAsync();

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
    }
}
//"\"{\"ID\":0,\"SIRKETID\":0,\"SUBEID\":0,\"DEPOID\":0,\"KASAID\":0,\"OLUSTURMATARIHI\":\"2022-10-17T16:38:14.7632247+03:00\",\"GUNCELLEMETARIHI\":\"2022-10-17T16:38:14.7632255+03:00\",\"KOD\":\"MEYPAK-004\",\"ADI\":\"PATLICAN\",\"MARKAID\":0,\"KATEGORIID\":0,\"OLCUBR1\":0,\"SDOVIZID\":1,\"ADOVIZID\":1,\"SFIYAT1\":0.0,\"SFIYAT2\":0.0,\"SFIYAT3\":0.0,\"SFIYAT4\":0.0,\"SFIYAT5\":0.0,\"AFIYAT1\":0.0,\"AFIYAT2\":0.0,\"AFIYAT3\":0.0,\"AFIYAT4\":0.0,\"AFIYAT5\":0.0,\"SATISKDV\":0.0,\"ALISKDV\":0.0,\"SATISOTV\":0.0,\"ALISOTV\":0.0,\"GRUPKODU\":0,\"ACIKLAMA\":\"\",\"ACIKLAMA1\":\"\",\"ACIKLAMA2\":\"\",\"ACIKLAMA3\":\"\",\"ACIKLAMA4\":\"\",\"ACIKLAMA5\":\"\",\"SACIKLAMA\":0,\"SACIKLAMA1\":0,\"SACIKLAMA2\":0,\"SACIKLAMA3\":0,\"SACIKLAMA4\":0,\"SACIKLAMA5\":0,\"RAPORKODU\":\"\",\"RAPORKODU1\":\"\",\"RAPORKODU2\":\"\",\"RAPORKODU3\":\"\",\"RAPORKODU4\":\"\",\"RAPORKODU5\":\"\",\"RAPORKODU6\":\"\",\"RAPORKODU7\":\"\",\"RAPORKODU8\":\"\",\"RAPORKODU9\":\"\",\"GTIN\":0,\"KULLANICIID\":0,\"KAYITTIPI\":0,\"DONEM\":\"\"}\""