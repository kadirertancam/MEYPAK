using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.KASA;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class KASAController : Controller
    {
        private readonly ILogger<KASAController> _logger;

        GenericWebServis<PocoKASA> _tempKasa = new GenericWebServis<PocoKASA>();
        GenericWebServis<PocoKASAHAR> _tempKasaHar = new GenericWebServis<PocoKASAHAR>();

        static List<PocoKASA> pocoKasas = new List<PocoKASA>();
        static int tempkasaid = 0;
        static List<PocoKASAHAR> pocoKasaHars = new List<PocoKASAHAR>();
        static int tempkasaharid = 0;
        
        public KASAController(ILogger<KASAController> logger)
        {
            _logger = logger;
        }

        #region KASA

        [HttpGet]
        public IActionResult KasaListesi()
        {
            return View();
        }

        [HttpGet]
        public object KasaGet(DataSourceLoadOptions loadOptions)
        {

            _tempKasa.Data(ServisList.KasaListeServis);
            return DataSourceLoader.Load(_tempKasa.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region KASAHAR

        [HttpGet]
        public IActionResult KasaHareket()
        {
            return View();
        }

        [HttpGet]
        public object KasaHarGet(DataSourceLoadOptions loadOptions)
        {

            _tempKasaHar.Data(ServisList.KasaHarListeServis);
            return DataSourceLoader.Load(_tempKasaHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

    }
}
 