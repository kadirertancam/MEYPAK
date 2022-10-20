using AutoMapper;
using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Mappings;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq.Expressions;
using System.Text.Json.Nodes;

namespace MEYPAK.API.Controllers.STOK
{
    [ApiController]
    [Route("[controller]")]
    public class StokController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IStokServis _stokServis;

        public StokController(IMapper mapper, IStokServis stokServis)
        {
            _mapper = mapper;
            _stokServis = stokServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKListe()
        {
            try
            {
                var data = _stokServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKEkle(PocoSTOK pModel)
        {
            try
            {
                var data = _stokServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSil(List<PocoSTOK> pModel)
        {
            try
            {
                var data = _stokServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKGuncelle(PocoSTOK pModel)
        {
            try
            {
                var data = _stokServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex )
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }



        #region Expression

      
        //[HttpPost("")]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKGetir([FromQuery]int id)
        //{
        //    try
        //    {
        //        var data = _stokServis.Getir(X=> X.ID == id);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}




        //#region Getir
        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKGetir(Expression<Func<PocoSTOK, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}


        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKHARGetir(Expression<Func<PocoSTOKHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokHarServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKFIYATLISTGetir(Expression<Func<PocoSTOKFIYATLIST, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokFiyatListServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKFIYATLISTHARGetir(Expression<Func<PocoSTOKFIYATLISTHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokFiyatListHarServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKKASAGetir(Expression<Func<PocoSTOKKASA, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokKasaServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKSAYIMGetir(Expression<Func<PocoSTOKSAYIM, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stoksayimServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKMARKAGetir(Expression<Func<PocoSTOKMARKA, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokMarkaServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}
        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKKATEGORIGetir(Expression<Func<PocoSTOKKATEGORI, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokKategoriServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}


        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKOLCUBRGetir(Expression<Func<PocoSTOKOLCUBR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokOlcuBrServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKSAYIMHARGetir(Expression<Func<PocoSTOKSAYIMHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stoksayimHarServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult OLCUBRGetir(Expression<Func<PocoOLCUBR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _olcuBrServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult HIZMETGetir(Expression<Func<PocoHIZMET, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _hizmetServis.Getir(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}
        //#endregion

        //#region Guncelle
        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKGuncelle(PocoSTOK pModel, Expression<Func<PocoSTOK, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}


        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKHARGuncelle(PocoSTOKHAR pModel, Expression<Func<PocoSTOKHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokHarServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKFIYATLISTGuncelle(PocoSTOKFIYATLIST pModel, Expression<Func<PocoSTOKFIYATLIST, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokFiyatListServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKFIYATLISTHARGuncelle(PocoSTOKFIYATLISTHAR pModel, Expression<Func<PocoSTOKFIYATLISTHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokFiyatListHarServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKKASAGuncelle(PocoSTOKKASA pModel, Expression<Func<PocoSTOKKASA, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokKasaServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKSAYIMGuncelle(PocoSTOKSAYIM pModel, Expression<Func<PocoSTOKSAYIM, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stoksayimServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKMARKAGuncelle(PocoSTOKMARKA pModel, Expression<Func<PocoSTOKMARKA, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokMarkaServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKKATEGORIGuncelle(PocoSTOKKATEGORI pModel , Expression<Func<PocoSTOKMARKA, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokKategoriServis.Guncelle(pModel);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}


        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKOLCUBRGuncelle(PocoSTOKOLCUBR pModel, Expression<Func<PocoSTOKOLCUBR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokOlcuBrServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKSAYIMHARGuncelle(PocoSTOKSAYIMHAR pModel, Expression<Func<PocoSTOKSAYIMHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stoksayimHarServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult OLCUBRGuncelle(PocoOLCUBR pModel, Expression<Func<PocoOLCUBR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _olcuBrServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult HIZMETGuncelle(PocoHIZMET pModel, Expression<Func<PocoHIZMET, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _hizmetServis.Guncelle(pModel, filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}
        //#endregion

        //#region Sil_Expression
        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKSil(Expression<Func<PocoSTOK, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}


        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKHARSil(Expression<Func<PocoSTOKHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokHarServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKFIYATLISTSil(Expression<Func<PocoSTOKFIYATLIST, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokFiyatListServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKFIYATLISTHARSil(Expression<Func<PocoSTOKFIYATLISTHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokFiyatListHarServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKKASASil(Expression<Func<PocoSTOKKASA, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokKasaServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKSAYIMSil(Expression<Func<PocoSTOKSAYIM, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stoksayimServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKMARKASil(Expression<Func<PocoSTOKMARKA, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokMarkaServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKKATEGORISil( Expression<Func<PocoSTOKKATEGORI, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokKategoriServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKOLCUBRSil(Expression<Func<PocoSTOKOLCUBR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stokOlcuBrServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult STOKSAYIMHARSil(Expression<Func<PocoSTOKSAYIMHAR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _stoksayimHarServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult OLCUBRSil(Expression<Func<PocoOLCUBR, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _olcuBrServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}

        //[HttpPost]
        //[Route("/[controller]/[action]")]
        //public IActionResult HIZMETSil(Expression<Func<PocoHIZMET, bool>> filter)
        //{
        //    try
        //    {
        //        var data = _hizmetServis.Sil(filter);
        //        return Ok(data);
        //    }
        //    catch (Exception)
        //    {
        //        return Problem("Beklenmedik bir hata oluştu!");
        //    }
        //}
#endregion



    }
}
