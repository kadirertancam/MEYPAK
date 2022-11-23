using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Interfaces.Fatura;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.FATURAController
{
    [ApiController]
    [Route("[controller]")]
    public class FATURADETAYController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFaturaDetayServis _faturaDetayServis;
        private MPAdoContext<MPFATURADETAY> _adoFaturaServis = new MPAdoContext<MPFATURADETAY>();
        public FATURADETAYController(IMapper mapper, IFaturaDetayServis faturaDetayServis)
        {
            _mapper = mapper;
            _faturaDetayServis = faturaDetayServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult FATURADETAYListe()
        {
            try
            {
                var data = _faturaDetayServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult FATURADETAYListe2([FromQuery] string query)
        {
            try
            {
                _adoFaturaServis.HepsiniGetir(query);
                return Ok(_adoFaturaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult FATURADETAYEkleyadaGuncelle(PocoFATURADETAY pModel)
        {
            try
            {
                var data = _faturaDetayServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult FATURADETAYSil(List<PocoFATURADETAY> pModel)
        {
            try
            {
                var data = _faturaDetayServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult FATURADETAYGuncelle(PocoFATURADETAY pModel)
        {
            try
            {
                var data = _faturaDetayServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromQuery] int id)
        {
            try
            {
                bool succes = _faturaDetayServis.DeleteById(id);
                if (succes)
                    return Ok(id + " Başarıyla Silindi");
                else
                    return Ok(id + " Silinemedi.");
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}


