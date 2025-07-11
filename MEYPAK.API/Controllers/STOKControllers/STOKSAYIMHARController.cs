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
    public class STOKSAYIMHARController : Controller
    {
        private readonly IStokSayimHarServis _stoksayimHarServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSTOKSAYIMHAR> _adostoksayimHarServis = new MPAdoContext<MPSTOKSAYIMHAR>();
        public STOKSAYIMHARController(IStokSayimHarServis stoksayimHarServis, IMapper mapper)
        {
            _stoksayimHarServis = stoksayimHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARListe()
        {
            try
            {
                var data = _stoksayimHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARListe2([FromQuery] string query)
        {
            try
            {
                _adostoksayimHarServis.HepsiniGetir(query);

                return Ok(_adostoksayimHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHAREkleyadaGuncelle(PocoSTOKSAYIMHAR pModel)
        {
            try
            {
                var data = _stoksayimHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARSil(List<PocoSTOKSAYIMHAR> pModel)
        {
            try
            {
                var data = _stoksayimHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARGuncelle(PocoSTOKSAYIMHAR pModel)
        {
            try
            {
                var data = _stoksayimHarServis.Guncelle(pModel);
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
                bool succes = _stoksayimHarServis.DeleteById(id);
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
