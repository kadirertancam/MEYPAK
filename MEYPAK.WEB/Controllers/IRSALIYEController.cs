using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class IRSALIYEController : Controller
    {
        private readonly ILogger<IRSALIYEController> _logger;

        GenericWebServis<PocoIRSALIYE> _tempIrsaliye = new GenericWebServis<PocoIRSALIYE>();


        #region Tanımlar
        static List<PocoIRSALIYE> PocoIrsaliyes = new List<PocoIRSALIYE>();
        static int tempirsaliyeid = 0;

        #endregion

        public IRSALIYEController(ILogger<IRSALIYEController> logger)
        {
            _logger = logger;
        }

        #region IRSALİYE

        [HttpGet]
        public IActionResult IrsaliyeRapor()
        {
            return View();
        }

        [HttpGet]
        public object IrsaliyeGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempIrsaliye.Data(ServisList.IrsaliyeListeServis);
            return DataSourceLoader.Load(_tempIrsaliye.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

    }
}
