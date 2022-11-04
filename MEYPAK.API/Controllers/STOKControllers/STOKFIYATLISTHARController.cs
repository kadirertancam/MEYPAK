using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKFIYATLISTHARController : Controller
    {
        private readonly IStokFiyatListHarServis _stokFiyatListHarServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSTOKFIYATLISTHAR> _adostokFiyatListHarServis = new MPAdoContext<MPSTOKFIYATLISTHAR>();

        public STOKFIYATLISTHARController(IStokFiyatListHarServis stokFiyatListHarServis, IMapper mapper)
        {
            _stokFiyatListHarServis = stokFiyatListHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARListe()
        {
            try
            {
                var data = _stokFiyatListHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARListe2([FromQuery] string query)
        {
            try
            {
                _adostokFiyatListHarServis.HepsiniGetir(query);

                return Ok(_adostokFiyatListHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHAREkleyadaGuncelle(PocoSTOKFIYATLISTHAR pModel)
        {
            try
            {
                var data = _stokFiyatListHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARSil(List<PocoSTOKFIYATLISTHAR> pModel)
        {
            try
            {
                var data = _stokFiyatListHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARGuncelle(PocoSTOKFIYATLISTHAR pModel)
        {
            try
            {
                var data = _stokFiyatListHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex )
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
                bool succes = _stokFiyatListHarServis.DeleteById(id);
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
