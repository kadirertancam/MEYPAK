﻿using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Depo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CARIHARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICariHarServis _cariHarServis;
        private MPAdoContext<MPCARIHAR> _adocariHarServis = new MPAdoContext<MPCARIHAR>();
        public CARIHARController(IMapper mapper, ICariHarServis cariServis)
        {
            _mapper = mapper;
            _cariHarServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")] 
        public IActionResult CARIHARListe()
        {
            try
            {
                var data = _cariHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult CARIHARListe2([FromQuery] string query)
        {
            try
            {
                _adocariHarServis.HepsiniGetir(query);
                return Ok(_adocariHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIHAREkleyadaGuncelle(PocoCARIHAR pModel)
        {
            try
            {
                var data = _cariHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIHARSil(List<PocoCARIHAR> pModel)
        {
            try
            {
                var data = _cariHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIHARGuncelle(PocoCARIHAR pModel)
        {
            try
            {
                var data = _cariHarServis.Guncelle(pModel);
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
                bool succes = _cariHarServis.DeleteById(id);
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
