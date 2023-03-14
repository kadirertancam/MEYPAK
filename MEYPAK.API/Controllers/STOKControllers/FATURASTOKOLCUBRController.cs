using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]

    public class FATURASTOKOLCUBRController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IFaturaStokOlcuBrServis _faturaStokOlcuBrServis;
        private MPAdoContext<MPFATURASTOKOLCUBR> _adostokservis = new MPAdoContext<MPFATURASTOKOLCUBR>();
        public FATURASTOKOLCUBRController(IMapper mapper, IFaturaStokOlcuBrServis faturaStokOlcuBrServis)
        {
            _mapper = mapper;
            _faturaStokOlcuBrServis = faturaStokOlcuBrServis;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _faturaStokOlcuBrServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste2([FromQuery] string query)
        {
            try
            {
                _adostokservis.HepsiniGetir(query);

                return Ok(_adostokservis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EkleyadaGuncelle(PocoFATURASTOKOLCUBR pModel)
        {
            try
            {
                var data = _faturaStokOlcuBrServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoFATURASTOKOLCUBR> pModel)
        {
            try
            {
                var data = _faturaStokOlcuBrServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoFATURASTOKOLCUBR pModel)
        {
            try
            {
                var data = _faturaStokOlcuBrServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromQuery] string id)
        {
            try
            {
                bool succes = _faturaStokOlcuBrServis.DeleteById(Convert.ToInt32(id));
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
