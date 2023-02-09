using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.CekSenet;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class STOKSARFController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokSarfServis _StokSarfServis;
        private MPAdoContext<MPSTOKSARF> _adobankaServis = new MPAdoContext<MPSTOKSARF>();
        public STOKSARFController(IMapper mapper, IStokSarfServis FCekHarServis)
        {
            _mapper = mapper;
            _StokSarfServis = FCekHarServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult Liste()
        {
            try
            {
                var data = _StokSarfServis.Listele();
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
                _adobankaServis.HepsiniGetir(query);
                return Ok(_adobankaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EkleyadaGuncelle([FromBody] PocoSTOKSARF pModel)
        {
            try
            {
                var data = _StokSarfServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoSTOKSARF> pModel)
        {
            try
            {
                var data = _StokSarfServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoSTOKSARF pModel)
        {
            try
            {
                var data = _StokSarfServis.Guncelle(pModel);
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
                bool succes = _StokSarfServis.DeleteById(id);
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

