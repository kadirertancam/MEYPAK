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
    public class STOKFIYATHARController : Controller
    {
        private readonly IStokFiyatHarServis _stokfiyatHarServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSTOKFIYATHAR> _adostokfiyatHarServis = new MPAdoContext<MPSTOKFIYATHAR>();
        public STOKFIYATHARController(IStokFiyatHarServis stokfiyatHarServis, IMapper mapper)
        {
            _stokfiyatHarServis = stokfiyatHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATHARListe()
        {
            try
            {
                var data = _stokfiyatHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATHARListe2([FromQuery] string query)
        {
            try
            {
                _adostokfiyatHarServis.HepsiniGetir(query);

                return Ok(_adostokfiyatHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATHAREkleyadaGuncelle(PocoSTOKFIYATHAR pModel)
        {
            try
            {
                var data = _stokfiyatHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATHARSil(List<PocoSTOKFIYATHAR> pModel)
        {
            try
            {
                var data = _stokfiyatHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATHARGuncelle(PocoSTOKFIYATHAR pModel)
        {
            try
            {
                var data = _stokfiyatHarServis.Guncelle(pModel);
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
                bool succes = _stokfiyatHarServis.DeleteById(id);
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
