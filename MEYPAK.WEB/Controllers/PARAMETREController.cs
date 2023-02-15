using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class PARAMETREController : Controller
    {
        private readonly ILogger<PARAMETREController> _logger;

        GenericWebServis<PocoPARABIRIM> _tempParaBirim = new GenericWebServis<PocoPARABIRIM>();

        static List<PocoPARABIRIM> PocoParaBirims = new List<PocoPARABIRIM>();
        static int tempparabirimid = 0;


        public PARAMETREController(ILogger<PARAMETREController> logger)
        {
            _logger = logger;

        }
        #region PARABIRIM

        [HttpGet]
        public IActionResult ParaBirim()
        {
            return View();
        }

        [HttpGet]
        public object ParaBirimGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempParaBirim.Data(ServisList.ParaBirimiListeServis);
            return DataSourceLoader.Load(_tempParaBirim.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

    }
}
