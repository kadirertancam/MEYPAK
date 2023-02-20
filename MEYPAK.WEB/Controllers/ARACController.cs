using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class ARACController : Controller
    {
        private readonly ILogger<ARACController> _logger;
        GenericWebServis<PocoARAC> _tempArac = new GenericWebServis<PocoARAC>();
        GenericWebServis<PocoSOFOR> _tempSofor = new GenericWebServis<PocoSOFOR>();

        #region Tanımlar

        static List<PocoSOFOR> pocoSofors = new List<PocoSOFOR>();
        static int tempsoforid = 0;
        static List<PocoARAC> pocoAracs = new List<PocoARAC>();
        static int temparacid = 0;

        #endregion
        public ARACController(ILogger<ARACController> logger)
        {
            _logger = logger;

        }
      

        #region ARAC

        [HttpGet]
        public IActionResult AracListesi()
        {
            return View();
        }

        [HttpGet]
        public object AracGet(DataSourceLoadOptions loadOptions)
        {

            _tempArac.Data(ServisList.AracListeServis);
            return DataSourceLoader.Load(_tempArac.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region ŞOFÖR

        [HttpGet]
        public IActionResult SoförListesi()
        {
            return View();
        }
        [HttpGet]
        public object SoforGet(DataSourceLoadOptions loadOptions)
        {
            _tempSofor.Data(ServisList.SoforListeServis);
            return DataSourceLoader.Load(_tempSofor.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion
    }
}

