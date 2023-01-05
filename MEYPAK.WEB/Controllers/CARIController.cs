using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MEYPAK.WEB.Controllers
{
    public class CARIController : Controller
    {
        private readonly ILogger<CARIController> _logger;
        GenericWebServis<PocoCARIKART> _tempPocoCariKart = new GenericWebServis<PocoCARIKART>();

        static List<PocoCARIKART> pocoCARIKARTs = new List<PocoCARIKART>();
        static int tempcarikartid = 0;
        public CARIController(ILogger<CARIController> logger)
        {
            _logger = logger;

        }

        #region CARI

        [HttpGet]
        public IActionResult CariKart()
        {
            return View();
        }

        [HttpGet]
        public object CariGet(DataSourceLoadOptions loadOptions)
        {
            
            _tempPocoCariKart.Data(ServisList.CariListeServis);
            return DataSourceLoader.Load(_tempPocoCariKart.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> CariPut(int key, string values)
        { //güncellenecek
            _tempPocoCariKart.Data(ServisList.CariListeServis);
            var employee = _tempPocoCariKart.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);



            _tempPocoCariKart.Data(ServisList.CariEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CariPost(string values)
        {
            PocoCARIKART newPoco = new PocoCARIKART();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoCariKart.Data(ServisList.CariEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void CariDelete(int key)
        {
            string url = ServisList.CariDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoCariKart.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion


    }
}
