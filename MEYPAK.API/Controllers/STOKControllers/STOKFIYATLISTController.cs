using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOK
{
    [ApiController]
    [Route("[controller]")]
    public class STOKFIYATLISTController : Controller
    {


        private readonly IStokFiyatListServis _stokFiyatListServis;
        private readonly IMapper _mapper;

        public STOKFIYATLISTController(IStokFiyatListServis stokFiyatListServis, IMapper mapper)
        {
            _stokFiyatListServis = stokFiyatListServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTListe()
        {
            try
            {
                var data = _stokFiyatListServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTEkleyadaGuncelle(PocoSTOKFIYATLIST pModel)
        {
            try
            {
                var data = _stokFiyatListServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTSil(List<PocoSTOKFIYATLIST> pModel)
        {
            try
            {
                var data = _stokFiyatListServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTGuncelle(PocoSTOKFIYATLIST pModel)
        {
            try
            {
                var data = _stokFiyatListServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteById([FromBody] int id)
        {
            try
            {
                bool succes = _stokFiyatListServis.DeleteById(id);
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
