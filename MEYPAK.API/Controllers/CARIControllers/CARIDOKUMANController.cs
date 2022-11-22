using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    public class CARIDOKUMANController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICariDokumanServis _cariDokumanServis;
        private MPAdoContext<MPCARIDOKUMAN> _adocariServis = new MPAdoContext<MPCARIDOKUMAN>();
        public CARIDOKUMANController(IMapper mapper, ICariDokumanServis cariDokumanServis)
        {
            _mapper = mapper;
            _cariDokumanServis = cariDokumanServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult CARIDOKUMANListe()
        {
            try
            {
                var data = _cariDokumanServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult CARIDOKUMANListe2([FromQuery] string query)
        {
            try
            {
                _adocariServis.HepsiniGetir(query);
                return Ok(_adocariServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIDOKUMANEkleyadaGuncelle([FromBody] PocoCARIDOKUMAN pModel)
        {
            try
            {
                var data = _cariDokumanServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIDOKUMANSil(List<PocoCARIDOKUMAN> pModel)
        {
            try
            {
                var data = _cariDokumanServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIDOKUMANGuncelle(PocoCARIDOKUMAN pModel)
        {
            try
            {
                var data = _cariDokumanServis.Guncelle(pModel);
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
                bool succes = _cariDokumanServis.DeleteById(id);
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
