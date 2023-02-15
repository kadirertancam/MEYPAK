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

        GenericWebServis<PocoSIPARIS> _tempSiparis = new GenericWebServis<PocoSIPARIS>();
        GenericWebServis<PocoSIPARISDETAY> _tempSiparisDetay = new GenericWebServis<PocoSIPARISDETAY>();
        GenericWebServis<PocoSIPARISSEVKEMIRHAR> _tempSiparisSevkEmriHar = new GenericWebServis<PocoSIPARISSEVKEMIRHAR>();

        #region Tanımlar

        static List<PocoSIPARIS> PocoSipariss = new List<PocoSIPARIS>();
        static int tempsiparisid = 0;
        #endregion

        public SIPARISController(ILogger<SIPARISController> logger)
        {
            _logger = logger;
        }

        #region SIPARIS
        
        [HttpGet]
        public IActionResult SiparisRapor()
        {
            return View();
        }

        [HttpGet]
        public object SiparisGet(DataSourceLoadOptions loadOptions)
        {
            _tempSiparis.Data(ServisList.SiparisListeServis);
            return DataSourceLoader.Load(_tempSiparis.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
       
        #endregion

        #region SIPARISDETAY


        [HttpGet]
        public async Task<IActionResult> SiparisDetayRapor()
        {
            return View();
        }

        [HttpGet]
        public object SiparisDetayGet(DataSourceLoadOptions loadOptions)
        {
            _tempSiparisDetay.Data(ServisList.SiparisDetayListeServis);
            return DataSourceLoader.Load(_tempSiparisDetay.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        

        #endregion

        #region SIPARISSEVKEMRIHAR


        [HttpGet]
        public async Task<IActionResult> SiparisSevkEmriHareketRapor()
        {
            return View();
        }

        [HttpGet]
        public object SiparisSevkEmriHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempSiparisSevkEmriHar.Data(ServisList.SiparisListeServis);
            return DataSourceLoader.Load(_tempSiparisSevkEmriHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
    

        #endregion

    }
}
