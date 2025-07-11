﻿using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.SIPARISControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SIPARISController : Controller
    {
        private readonly ISiparisServis _siparisServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSIPARIS> _adosiparisServis = new MPAdoContext<MPSIPARIS>();
        public SIPARISController(ISiparisServis siparisServis, IMapper mapper)
        {
            _siparisServis = siparisServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISListe()
        {
            try
            {
                var data = _siparisServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISListe2([FromQuery] string query)
        {
            try
            {
                _adosiparisServis.HepsiniGetir(query);
                return Ok(_adosiparisServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISEkleyadaGuncelle(PocoSIPARIS pModel)
        {
            try
            {
                var data = _siparisServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISSil(List<PocoSIPARIS> pModel)
        {
            try
            {
                var data = _siparisServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISGuncelle(PocoSIPARIS pModel)
        {
            try
            {
                var data = _siparisServis.Guncelle(pModel);
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
                bool succes = _siparisServis.DeleteById(id);
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
