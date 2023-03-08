using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.DESTEKSERVİS;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.DESTEKSERVIS;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.DestekServis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DESTEKSERVISController
{
    public class DestekServisController : Controller
    {
        [ApiController]
        [Route("[controller]")]
        [Authorize]
        public class DESTEKSERVISController : Controller
        {

            private readonly IMapper _mapper;
            private readonly IDestekServis _destekServis;
            private MPAdoContext<MPDESTEKSERVİS> _adodestekServis = new MPAdoContext<MPDESTEKSERVİS>();
            public DESTEKSERVISController(IMapper mapper, IDestekServis destekServis)
            {
                _mapper = mapper;
                _destekServis = destekServis;
            }

            [HttpGet]
            [Route("/[controller]/[action]")]
            public IActionResult DESTEKSERVISListe()
            {
                try
                {
                    var data = _destekServis.Listele();
                    return Ok(data);
                }
                catch (Exception ex)
                {
                    return Problem("Belirsiz bir hata oluştu!" + ex.Message);
                }
            }
            [HttpGet]
            [Route("/[controller]/[action]")]
            public IActionResult DESTEKSERVISListe2([FromQuery] string query)
            {
                try
                {
                    _adodestekServis.HepsiniGetir(query);
                    return Ok(_adodestekServis.GenericList);
                }
                catch (Exception ex)
                {
                    return Problem("Belirsiz bir hata oluştu!" + ex.Message);
                }
            }
            [HttpPost]
            [Route("/[controller]/[action]")]
            public IActionResult DESTEKSERVISEkleyadaGuncelle(PocoDestekServis pModel)
            {
                try
                {
                    var data = _destekServis.EkleyadaGuncelle(pModel);
                    return Ok(data);
                }
                catch (Exception ex)
                {
                    return Problem("Belirsiz bir hata oluştu!" + ex.Message);
                }
            }
            [HttpPost]
            [Route("/[controller]/[action]")]
            public IActionResult DESTEKSERVISSil(List<PocoDestekServis> pModel)
            {
                try
                {
                    var data = _destekServis.Sil(pModel);
                    return Ok(data);
                }
                catch (Exception ex)
                {
                    return Problem("Belirsiz bir hata oluştu!" + ex.Message);
                }
            }
            [HttpPost]
            [Route("/[controller]/[action]")]
            public IActionResult DESTEKSERVISGuncelle(PocoDestekServis pModel)
            {
                try
                {
                    var data = _destekServis.Guncelle(pModel);
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
                    bool succes = _destekServis.DeleteById(id);
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
}
