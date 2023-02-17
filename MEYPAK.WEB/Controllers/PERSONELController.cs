using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class PERSONELController : Controller
    {
        private readonly ILogger<PERSONELController> _logger;
        GenericWebServis<PocoPERSONEL> _tempPersonel = new GenericWebServis<PocoPERSONEL>();

        #region Tanımlar

        static List<PocoPERSONEL> PocoPERSONELs = new List<PocoPERSONEL>();
        static int temppersonelid = 0;

        #endregion

        public PERSONELController(ILogger<PERSONELController> logger)
        {
            _logger = logger;
        }


        #region PERSONEL

        [HttpGet]
        public IActionResult PersonelListesi()
        {
            return View();
        }

        [HttpGet]
        public object PersonelGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPersonel.Data(ServisList.PersonelListeServis);
            return DataSourceLoader.Load(_tempPersonel.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        #endregion



    }
}
