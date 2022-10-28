using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKKATEGORIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokKategoriServis _stokKategoriServis;

        public STOKKATEGORIController(IMapper mapper, IStokKategoriServis stokKategoriServis)
        {
            _mapper = mapper;
            _stokKategoriServis = stokKategoriServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIListe()
        {
            try
            {
                var data = _stokKategoriServis.Listele();
                return Ok(data);
            }
            catch (Exception ex )
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIEkleyadaGuncelle(PocoSTOKKATEGORI pModel)
        {
            try
            {
                var data = _stokKategoriServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex )
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORISil(List<PocoSTOKKATEGORI> filter)
        {
            try
            {
                var data = _stokKategoriServis.Sil(filter);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIGuncelle(PocoSTOKKATEGORI pModel)
        {
            try
            {
                var data = _stokKategoriServis.Guncelle(pModel);
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
                bool succes = _stokKategoriServis.DeleteById(id);
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
