using AutoMapper;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class PERSONELController : Controller
    {
        private readonly ILogger<PERSONELController> _logger;
        GenericWebServis<PocoPERSONEL> _tempPocoPersonel = new GenericWebServis<PocoPERSONEL>();

        public PERSONELController(ILogger<PERSONELController> logger)
        {
            _logger = logger;
        }

    



    }
}
