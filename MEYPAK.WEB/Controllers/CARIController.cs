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

        GenericWebServis<PocoCARIKART> _tempCari = new GenericWebServis<PocoCARIKART>();
        GenericWebServis<PocoCARIALTHES> _tempAltHesap = new GenericWebServis<PocoCARIALTHES>();
        GenericWebServis<PocoCARIHAR> _tempCariHar = new GenericWebServis<PocoCARIHAR>();

        static List<PocoCARIKART> pocoCaris = new List<PocoCARIKART>();
        static int tempcariid = 0;
        static List<PocoCARIHAR> pocoCariHars = new List<PocoCARIHAR>();
        static int tempcariharid = 0;
        static List<PocoCARIALTHES> pocoAltHess = new List<PocoCARIALTHES>();
        static int tempalthesid = 0;
        public CARIController(ILogger<CARIController> logger)
        {
            _logger = logger;
        }

        #region CARI

        [HttpGet]
        public IActionResult CariRapor()
        {
            return View();
        }

        [HttpGet]
        public object CariGet(DataSourceLoadOptions loadOptions)
        {
            
            _tempCari.Data(ServisList.CariListeServis);
            return DataSourceLoader.Load(_tempCari.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region ALTHESAP

        [HttpGet]
        public IActionResult AltHesapRapor()
        {
            return View();
        }

        [HttpGet]
        public object AltHesapGet(DataSourceLoadOptions loadOptions)
        {

            _tempAltHesap.Data(ServisList.CariAltHesListeServis);
            return DataSourceLoader.Load(_tempAltHesap.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region CARIHAR

        [HttpGet]
        public IActionResult CariHareketRapor()
        {
            return View();
        }

        [HttpGet]
        public object CariHarGet(DataSourceLoadOptions loadOptions)
        {

            _tempCariHar.Data(ServisList.CariHarListeServis);
            return DataSourceLoader.Load(_tempCariHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

    }
}
