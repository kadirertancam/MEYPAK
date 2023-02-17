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
        GenericWebServis<PocoBANKASUBE> _tempBankaSube = new GenericWebServis<PocoBANKASUBE>();

        #region Tanımlar

        static List<PocoBANKA> PocoBANKAs = new List<PocoBANKA>();
        static int tempbankaid = 0;
        static List<PocoBANKAHESAP> PocoBankaHesaps = new List<PocoBANKAHESAP>();
        static int tempbankahesapid = 0;
        static List<PocoBANKASUBE> PocoBankaSubes = new List<PocoBANKASUBE>();
        static int tempbankasubeid = 0;

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
        public IActionResult BankaHesapListesi()
        {
            return View();
        }

        [HttpGet]
        public object BankaHesapGet(DataSourceLoadOptions loadOptions)
        {

            _tempBankaHesap.Data(ServisList.BANKAHesapListeServis);
            return DataSourceLoader.Load(_tempBankaHesap.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region BANKASUBE

        [HttpGet]
        public IActionResult BankaSubeListesi()
        {
            return View();
        }

        [HttpGet]
        public object BankaSubeGet(DataSourceLoadOptions loadOptions)
        {

            _tempBankaSube.Data(ServisList.BANKASubeListeServis);
            return DataSourceLoader.Load(_tempBankaSube.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion
    }
}
