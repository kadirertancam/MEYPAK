using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.BLL.Assets;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExpress.Pdf;
using MEYPAK.Entity.PocoModels.STOK;

namespace MEYPAK.WEB.Controllers
{
    public class BANKAController : Controller
    {
        private readonly ILogger<BANKAController> _logger;

        GenericWebServis<PocoBANKA> _tempBanka = new GenericWebServis<PocoBANKA>();
        GenericWebServis<PocoBANKAHESAP> _tempBankaHesap = new GenericWebServis<PocoBANKAHESAP>();

        #region Tanımlar
        static List<PocoBANKA> PocoBANKAs = new List<PocoBANKA>();
        static int tempbankaid = 0;
        static List<PocoBANKAHESAP> PocoBANKAHESAPs = new List<PocoBANKAHESAP>();
        static int tempbankahesapid = 0;

        #endregion

        public BANKAController(ILogger<BANKAController> logger)
        {
            _logger = logger;

        }


        #region BANKA

        [HttpGet]
        public IActionResult BankaListesi()
        {
            return View();
        }

        [HttpGet]
        public object BankaGet(DataSourceLoadOptions loadOptions)
        {
         
            _tempBanka.Data(ServisList.BANKAListeServis);
            return DataSourceLoader.Load(_tempBanka.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region BANKAHESAP

        [HttpGet]
        public IActionResult BankaHesapRapor()
        {
            return View();
        }

        [HttpGet]
        public object BankaHesapGet(DataSourceLoadOptions loadOptions)
        {

            _tempBanka.Data(ServisList.BANKAHesapListeServis);
            return DataSourceLoader.Load(_tempBanka.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion
    }
}
