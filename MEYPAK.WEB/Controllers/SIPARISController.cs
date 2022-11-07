using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MEYPAK.WEB.Controllers
{
    public class SIPARISController : Controller
    {
        private readonly ILogger<SIPARISController> _logger;
        GenericWebServis<PocoSIPARIS> _tempPocoSiparis = new GenericWebServis<PocoSIPARIS>();
        GenericWebServis<PocoSIPARISDETAY> _tempPocoSiparisDetay = new GenericWebServis<PocoSIPARISDETAY>();
        GenericWebServis<PocoSIPARISSEVKEMIRHAR> _tempPocoSiparisSevkEmriHar = new GenericWebServis<PocoSIPARISSEVKEMIRHAR>();

        public SIPARISController(ILogger<SIPARISController> logger)
        {
            _logger = logger;
        }




        #region SIPARIS
        

        [HttpGet]
        public async Task<IActionResult> SiparisKart()
        {
            return View();
        }

        [HttpGet]
        public object SiparisGet(DataSourceLoadOptions loadOptions)
        {
            _tempPocoSiparis.Data(ServisList.SiparisListeServis);
            return DataSourceLoader.Load(_tempPocoSiparis.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> SiparisPut(int key, string values)
        { //güncellenecek
            _tempPocoSiparis.Data(ServisList.SiparisListeServis);
            var employee = _tempPocoSiparis.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoSiparis.Data(ServisList.SiparisEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> SiparisPost(string values)
        {
            PocoSIPARIS newPoco = new PocoSIPARIS();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoSiparis.Data(ServisList.DepoEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void SiparisDelete(int key)
        {
            string url = ServisList.DepoDeleteByIdServis + "?id=" + key;
            _tempPocoSiparis.Data(url, method: HttpMethod.Post);
        }

        #endregion





        #region old_Controllers
        #region SIPARIS

        //[HttpGet]

        //public async Task<IActionResult> SiparisKart()
        //{
        //    _tempPocoSiparis.Data(ServisList.SiparisListeServis);

        //    return View(_tempPocoSiparis.obje);
        //}

        //[HttpGet]
        //public IActionResult SiparisEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> SiparisEkle(List<PocoSIPARIS> pModel)
        //{

        //    _tempPocoSiparis.Data(ServisList.SiparisSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}


        #endregion

        #region SIPARISDETAY

        //[HttpGet]

        //public async Task<IActionResult> SiparisDetayKart()
        //{
        //    _tempPocoSiparisDetay.Data(ServisList.SiparisDetayListeServis);

        //    return View(_tempPocoSiparisDetay.obje);
        //}

        //[HttpGet]
        //public IActionResult SiparisDetayEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> SiparisDetayEkle(List<PocoSIPARISDETAY> pModel)
        //{

        //    _tempPocoSiparisDetay.Data(ServisList.SiparisDetaySilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}


        #endregion

        #region SIPARISSEVKEMRIHAR

        //[HttpGet]

        //public async Task<IActionResult> SiparisSevkEmriKart()
        //{
        //    _tempPocoSiparisSevkEmriHar.Data(ServisList.SiparisSevkEmriHarListeServis);

        //    return View(_tempPocoSiparisSevkEmriHar.obje);
        //}

        //[HttpGet]
        //public IActionResult SiparisSevkEmriEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> SiparisSevkEmriEkle(PocoSIPARISSEVKEMIRHAR pModel)
        //{

        //    _tempPocoSiparisSevkEmriHar.Data(ServisList.SiparisSevkEmriHarEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult SiparisSevkEmriSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> SiparisSevkEmriSil(List<PocoSIPARISSEVKEMIRHAR> pModel)
        //{

        //    _tempPocoSiparisSevkEmriHar.Data(ServisList.SiparisSevkEmriHarEkleServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}


        #endregion

        #endregion


    }
}
