using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Entity.PocoModels.FATURA;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class CEKSENETController : Controller
    {
        private readonly ILogger<CEKSENETController> _logger;

        GenericWebServis<PocoMUSTERICEKHAR> _tempMusteriCekHar = new GenericWebServis<PocoMUSTERICEKHAR>();
        GenericWebServis<PocoMUSTERISENETHAR> _tempMusteriSenetHar = new GenericWebServis<PocoMUSTERISENETHAR>();

        #region Tanımlar

        static List<PocoMUSTERICEKHAR> PocoMusteriCekHars = new List<PocoMUSTERICEKHAR>();
        static int tempmustericekharid = 0;
        static List<PocoMUSTERISENETHAR> PocoMusteriSenetHars = new List<PocoMUSTERISENETHAR>();
        static int tempmusterisenetharid = 0;

        #endregion

        public CEKSENETController(ILogger<CEKSENETController> logger)
        {
            _logger = logger;

        }

        #region MUSTERİCEKHAR

        [HttpGet]
        public IActionResult MusteriCekHareket()
        {
            return View();
        }

        [HttpGet]
        public object MusteriCekHarGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempMusteriCekHar.Data(ServisList.MusteriCekHarListeServis);
            return DataSourceLoader.Load(_tempMusteriCekHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        #endregion

        #region MUSTERİSENETHAR

        [HttpGet]
        public IActionResult MusteriSenetHareket()
        {
            return View();
        }

        [HttpGet]
        public object MusteriSenetHarGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempMusteriSenetHar.Data(ServisList.MusteriSenetHarListeServis);
            return DataSourceLoader.Load(_tempMusteriSenetHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        #endregion
    }
}
