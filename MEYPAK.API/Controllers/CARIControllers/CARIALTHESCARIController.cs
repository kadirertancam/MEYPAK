using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    [Route("[controller]")]
    public class CARIALTHESCARIController : Controller
    {

        private readonly IMapper _mapper;
        private readonly ICariAltHesCariServis _cariAltHesCariServis;
        private MPAdoContext<MPCARIALTHESCARI> _adocariAltHesCariServis = new MPAdoContext<MPCARIALTHESCARI>();

        public CARIALTHESCARIController(IMapper mapper, ICariAltHesCariServis cariAltHesServis)
        {
            _mapper = mapper;
            _cariAltHesCariServis = cariAltHesServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult CARIALTHESCARIListe()
        {
            try
            {
                var data = _cariAltHesCariServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESCARIListe2([FromQuery] string query)
        {
            try
            {
                _adocariAltHesCariServis.HepsiniGetir(query);
                return Ok(_adocariAltHesCariServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESCARIEkleyadaGuncelle([FromBody]PocoCARIALTHESCARI pModel)
        {
            try
            {
                var data = _cariAltHesCariServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESCARISil([FromBody]List<PocoCARIALTHESCARI> pModel)
        {
            try
            {
                var data = _cariAltHesCariServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESCARIGuncelle(PocoCARIALTHESCARI pModel)
        {
            try
            {
                var data = _cariAltHesCariServis.Guncelle(pModel);
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
                bool succes = _cariAltHesCariServis.DeleteById(id);
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
