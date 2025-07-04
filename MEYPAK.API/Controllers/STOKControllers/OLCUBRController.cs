﻿using AutoMapper;
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
    public class OLCUBRController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOlcuBrServis _olcuBrServis;
        private MPAdoContext<MPOLCUBR> _adoolcuBrServis = new MPAdoContext<MPOLCUBR>();
        public OLCUBRController(IMapper mapper, IOlcuBrServis olcuBrServis)
        {
            _mapper = mapper;
            _olcuBrServis = olcuBrServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRListe()
        {
            try
            {
                var data = _olcuBrServis.Listele();
                return Ok(data);
            }
            catch (Exception ex )
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRListe2([FromQuery] string query)
        {
            try
            {
                _adoolcuBrServis.HepsiniGetir(query);

                return Ok(_adoolcuBrServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBREkleyadaGuncelle(PocoOLCUBR pModel)
        {
            try
            {
                var data = _olcuBrServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRSil(List<PocoOLCUBR> pModel)
        {
            try
            {
                var data = _olcuBrServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRGuncelle(PocoOLCUBR pModel)
        {
            try
            {
                var data = _olcuBrServis.Guncelle(pModel);
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
                bool succes = _olcuBrServis.DeleteById(id);
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
