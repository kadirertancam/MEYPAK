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
using System;
using System.Linq.Expressions;

namespace MEYPAK.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StokController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IOlcuBrServis _olcuBrServis;
        private readonly IHizmetServis _hizmetServis ;
        private readonly IStokKategoriServis _stokKategoriServis;
        private readonly IStokServis _stokServis;
        private readonly IStokFiyatListServis _stokFiyatListServis;
        private readonly IStokFiyatListHarServis _stokFiyatListHarServis;
        private readonly IStokHarServis _stokHarServis;
        private readonly IStokKasaServis _stokKasaServis;
        private readonly IStokMarkaServis _stokMarkaServis;
        private readonly IStokOlcuBrServis _stokOlcuBrServis;
        private readonly IStokSayimServis _stoksayimServis;
        private readonly IStokSayimHarServis _stoksayimHarServis;

        public StokController(IMapper mapper, IOlcuBrServis olcuBrServis, IHizmetServis hizmetServis, IStokKategoriServis kategoriServis, IStokServis stokServis, IStokFiyatListServis stokFiyatListServis, IStokFiyatListHarServis stokFiyatListHarServis, IStokHarServis stokHarServis, IStokKasaServis stokKasaServis, IStokMarkaServis stokMarkaServis, IStokOlcuBrServis stokOlcuBrServis, IStokSayimServis stoksayimServis, IStokSayimHarServis stoksayimHarServis)
        {
            _mapper = mapper;
            _olcuBrServis = olcuBrServis;
            _hizmetServis = hizmetServis;
            _stokKategoriServis = kategoriServis;
            _stokServis = stokServis;
            _stokFiyatListServis = stokFiyatListServis;
            _stokFiyatListHarServis = stokFiyatListHarServis;
            _stokHarServis = stokHarServis;
            _stokKasaServis = stokKasaServis;
            _stokMarkaServis = stokMarkaServis;
            _stokOlcuBrServis = stokOlcuBrServis;
            _stoksayimServis = stoksayimServis;
            _stoksayimHarServis = stoksayimHarServis;
        }


        #region Listele
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKListe()
        {
            try
            {
                var data = _stokServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHARListe()
        {
            try
            {
                var data = _stokHarServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARListe()
        {
            try
            {
                var data = _stokFiyatListHarServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAListe()
        {
            try
            {
                var data = _stokKasaServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMListe()
        {
            try
            {
                var data = _stoksayimServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAListe()
        {
            try
            {
                var data = _stokMarkaServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRListe()
        {
            try
            {
                var data = _stokOlcuBrServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETListe()
        {
            try
            {
                var data = _hizmetServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        #endregion

        #region Ekle
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKEkle(PocoSTOK pModel)
        {
            try
            {
                var data = _stokServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHAREkle(PocoSTOKHAR pModel)
        {
            try
            {
                var data = _stokHarServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTEkle(PocoSTOKFIYATLIST pModel)
        {
            try
            {
                var data = _stokFiyatListServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHAREkle(PocoSTOKFIYATLISTHAR pModel)
        {
            try
            {
                var data = _stokFiyatListHarServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAEkle(PocoSTOKKASA pModel)
        {
            try
            {
                var data = _stokKasaServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIEkle(PocoSTOKKATEGORI pModel)
        {
            try
            {
                var data = _stokKategoriServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMEkle(PocoSTOKSAYIM pModel)
        {
            try
            {
                var data = _stoksayimServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAEkle(PocoSTOKMARKA pModel)
        {
            try
            {
                var data = _stokMarkaServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBREkle(PocoSTOKOLCUBR pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHAREkle(PocoSTOKSAYIMHAR pModel)
        {
            try
            {
                var data = _stoksayimHarServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBREkle(PocoOLCUBR pModel)
        {
            try
            {
                var data = _olcuBrServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETEkle(PocoHIZMET pModel)
        {
            try
            {
                var data = _hizmetServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        #endregion

        #region Getir
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKGetir(Expression<Func<PocoSTOK, bool>> filter)
        {
            try
            {
                var data = _stokServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHARGetir(Expression<Func<PocoSTOKHAR, bool>> filter)
        {
            try
            {
                var data = _stokHarServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTGetir(Expression<Func<PocoSTOKFIYATLIST, bool>> filter)
        {
            try
            {
                var data = _stokFiyatListServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARGetir(Expression<Func<PocoSTOKFIYATLISTHAR, bool>> filter)
        {
            try
            {
                var data = _stokFiyatListHarServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAGetir(Expression<Func<PocoSTOKKASA, bool>> filter)
        {
            try
            {
                var data = _stokKasaServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMGetir(Expression<Func<PocoSTOKSAYIM, bool>> filter)
        {
            try
            {
                var data = _stoksayimServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAGetir(Expression<Func<PocoSTOKMARKA, bool>> filter)
        {
            try
            {
                var data = _stokMarkaServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIGetir(Expression<Func<PocoSTOKKATEGORI, bool>> filter)
        {
            try
            {
                var data = _stokKategoriServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRGetir(Expression<Func<PocoSTOKOLCUBR, bool>> filter)
        {
            try
            {
                var data = _stokOlcuBrServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARGetir(Expression<Func<PocoSTOKSAYIMHAR, bool>> filter)
        {
            try
            {
                var data = _stoksayimHarServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRGetir(Expression<Func<PocoOLCUBR, bool>> filter)
        {
            try
            {
                var data = _olcuBrServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETGetir(Expression<Func<PocoHIZMET, bool>> filter)
        {
            try
            {
                var data = _hizmetServis.Getir(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        #endregion

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
        //#endregion

        #region Sil_List
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSil(List<PocoSTOK> pModel)
        {
            try
            {
                var data = _stokServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHARSil(List<PocoSTOKHAR> pModel)
        {
            try
            {
                var data = _stokHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARSil(List<PocoSTOKFIYATLISTHAR> pModel)
        {
            try
            {
                var data = _stokFiyatListHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASASil(List<PocoSTOKKASA> pModel)
        {
            try
            {
                var data = _stokKasaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMSil(List<PocoSTOKSAYIM> pModel)
        {
            try
            {
                var data = _stoksayimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKASil(List<PocoSTOKMARKA> pModel)
        {
            try
            {
                var data = _stokMarkaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRSil(List<PocoSTOKOLCUBR> pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETSil(List<PocoHIZMET> pModel)
        {
            try
            {
                var data = _hizmetServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        #endregion

        #region Guncelle
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKGuncelle(PocoSTOK pModel)
        {
            try
            {
                var data = _stokServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHARGuncelle(PocoSTOKHAR pModel)
        {
            try
            {
                var data = _stokHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTHARGuncelle(PocoSTOKFIYATLISTHAR pModel)
        {
            try
            {
                var data = _stokFiyatListHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAGuncelle(PocoSTOKKASA pModel)
        {
            try
            {
                var data = _stokKasaServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMGuncelle(PocoSTOKSAYIM pModel)
        {
            try
            {
                var data = _stoksayimServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAGuncelle(PocoSTOKMARKA pModel)
        {
            try
            {
                var data = _stokMarkaServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRGuncelle(PocoSTOKOLCUBR pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
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
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETGuncelle(PocoHIZMET pModel)
        {
            try
            {
                var data = _hizmetServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        #endregion
    }
}
