using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.FATURA;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class FATURAController : Controller
    {
        private readonly ILogger<FATURAController> _logger;

        GenericWebServis<PocoFATURA> _tempFatura = new GenericWebServis<PocoFATURA>();
        GenericWebServis<PocoFATURADETAY> _tempFaturaDetay = new GenericWebServis<PocoFATURADETAY>();

        #region Tanımlar
        static List<PocoFATURA> PocoFaturas = new List<PocoFATURA>();
        static int tempfaturaid = 0;
        static List<PocoFATURADETAY> PocoFaturaDetays = new List<PocoFATURADETAY>();
        static int tempfaturadetayid = 0;

        #endregion

        public FATURAController(ILogger<FATURAController> logger)
        {
            _logger = logger;

        }

        #region FATURA

        [HttpGet]
        public IActionResult FaturaListesi()
        {
            return View();
        }

        [HttpGet]
        public object FaturaGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempFatura.Data(ServisList.FaturaListeServis);
            return DataSourceLoader.Load(_tempFatura.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        #endregion

        #region FATURADETAY

        [HttpGet]
        public IActionResult FaturaDetay()
        {
            return View();
        }

        [HttpGet]
        public object FaturaDetayGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempFaturaDetay.Data(ServisList.FaturaDetayListeServis);
            return DataSourceLoader.Load(_tempFaturaDetay.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        #endregion

    }
}
