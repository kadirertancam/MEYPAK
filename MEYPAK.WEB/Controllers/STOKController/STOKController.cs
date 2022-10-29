using MEYPAK.DAL.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Mvc;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Entity.Models.STOK;
using System.Data;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.WEB.Models;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.RegularExpressions;
using MEYPAK.BLL.Assets;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Ninject.Infrastructure.Language;

namespace MEYPAK.WEB.Controllers.STOKController
{
    public class StokController : Controller
    {


        private readonly ILogger<StokController> _logger;
        GenericWebServis<PocoSTOK> _tempPocoStok = new GenericWebServis<PocoSTOK>();
        GenericWebServis<PocoHIZMET> _tempPocoHizmet = new GenericWebServis<PocoHIZMET>();
        GenericWebServis<PocoOLCUBR> _tempPocoOlcuBr = new GenericWebServis<PocoOLCUBR>();
        GenericWebServis<PocoSTOKFIYATLIST> _tempPocoStokFiyatList = new GenericWebServis<PocoSTOKFIYATLIST>();
        GenericWebServis<PocoSTOKFIYATLISTHAR> _tempPocoStokFiyatHarList = new GenericWebServis<PocoSTOKFIYATLISTHAR>();
        GenericWebServis<PocoSTOKHAR> _tempPocoStokHar = new GenericWebServis<PocoSTOKHAR>();
        GenericWebServis<PocoSTOKKASA> _tempPocoStokKasa = new GenericWebServis<PocoSTOKKASA>();
        GenericWebServis<PocoSTOKKATEGORI> _tempPocoStokKategori = new GenericWebServis<PocoSTOKKATEGORI>();
        GenericWebServis<PocoSTOKMARKA> _tempPocoStokMarka = new GenericWebServis<PocoSTOKMARKA>();
        GenericWebServis<PocoSTOKOLCUBR> _tempPocoStokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
        GenericWebServis<PocoSTOKSAYIM> _tempPocoStokSayim = new GenericWebServis<PocoSTOKSAYIM>();
        GenericWebServis<PocoSTOKSAYIMHAR> _tempPocoStokSayimHar = new GenericWebServis<PocoSTOKSAYIMHAR>();
       



        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;

        }

        //[HttpGet]
        //public object Get(DataSourceLoadOptions loadOptions)
        //{
        //    return DataSourceLoader.Load(GenerateData(100000), loadOptions);
        //}

        //IEnumerable<PocoSTOK> GenerateData(int count)
        //{
        //    var surnames = new[] { "Smith", "Johnson", "Brown", "Taylor", "Anderson", "Harris", "Clark", "Allen", "Scott", "Carter" };
        //    var names = new[] { "James", "John", "Robert", "Christopher", "George", "Mary", "Nancy", "Sandra", "Michelle", "Betty" };
        //    var gender = new[] { "Male", "Female" };
        //    var startBirthDate = DateTime.Parse("1/1/1975");
        //    var endBirthDate = DateTime.Parse("1/1/1992");

        //    double s = 123456789;
        //    double NextRandom()
        //    {
        //        s = (1103515245 * s + 12345) % 2147483647;
        //        return s % (names.Length - 1);
        //    }

        //    for (var i = 0; i < count; i++)
        //    {
        //        var birthDate = new DateTime(startBirthDate.Ticks + Convert.ToInt64(Math.Floor(NextRandom() * (endBirthDate.Ticks - startBirthDate.Ticks) / 10)));

        //        birthDate.AddHours(12);

        //        var nameIndex = Convert.ToInt32(NextRandom());
        //        yield return new User
        //        {
        //            Id = i + 1,
        //            FirstName = names[nameIndex],
        //            LastName = surnames[Convert.ToInt32(NextRandom())],
        //            Gender = gender[Convert.ToInt32(Math.Floor(Convert.ToDouble(nameIndex / 5)))],
        //            BirthDate = birthDate
        //        };
        //    }
        //}


        [HttpGet]
        public IActionResult Index()
        {
             
            return View();
        }


        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            _tempPocoStok.Data(ServisList.StokListeServis);
            

            return DataSourceLoader.Load(_tempPocoStok.obje.ToEnumerable(), loadOptions);
        }


        #region STOK
        [HttpGet]

        public async Task<IActionResult> StokKart()
        {
            _tempPocoStok.Data(ServisList.StokListeServis);

            return View(_tempPocoStok.obje);
        }

        [HttpPost]
        public IActionResult StokEkle(string values)
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> StokEkle(PocoSTOK pModel)
        //{

        //    _tempPocoStok.Data(ServisList.StokEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        [HttpPut]
        public async Task<IActionResult> StokEkle(int key, string values)
        {

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpDelete]
        public async Task<IActionResult> StokEkle(int key)
        {

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }

        [HttpGet]
        public IActionResult StokSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokSil(List<PocoSTOK> pModel)
        {

            _tempPocoStok.Data(ServisList.StokSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokSil(int pModel)
        {
            _tempPocoStok.Data(ServisList.StokListeServis);
            List<PocoSTOK> pList = new List<PocoSTOK>();
            pList.Add(_tempPocoStok.obje.Where(x=>x.ID==pModel).FirstOrDefault());
            StokSil(pList);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }


        #endregion

        #region HIZMET
        [HttpGet]
        public async Task<IActionResult> HizmetKart()
        {
            _tempPocoHizmet.Data(ServisList.HizmetListeServis);
            return View(_tempPocoHizmet.obje);
        }

        [HttpGet]
        public IActionResult HizmetEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HizmetEkle(PocoHIZMET pModel)
        {
            _tempPocoHizmet.Data(ServisList.HizmetEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult HizmetSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HizmetSil(List<PocoHIZMET> pModel)
        {
            _tempPocoHizmet.Data(ServisList.HizmetSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla Silindi.";
            return View();
        }

        #endregion

        #region OLCUBR
        [HttpGet]
        public async Task<IActionResult> OlcuBrKart()
        {
            _tempPocoOlcuBr.Data(ServisList.OlcuBrListeServis);
            return View(_tempPocoOlcuBr.obje);
        }

        [HttpGet]
        public IActionResult OlcuBrEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OlcuBrEkle(PocoOLCUBR pModel)
        {
            _tempPocoOlcuBr.Data(ServisList.OlcuBrEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult OlcuBrSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OlcuBrSil(List<PocoOLCUBR> pModel)
        {
            _tempPocoOlcuBr.Data(ServisList.OlcuBrSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }

        #endregion

        #region STOKFIYATLIST

        [HttpGet]

        public async Task<IActionResult> StokFiyatListKart()
        {

            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListListeServis);
            return View(_tempPocoStokFiyatList.obje);
        }

        [HttpGet]
        public IActionResult StokFiyatListEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokFiyatListEkle(PocoSTOKFIYATLIST pModel)
        {
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokFiyatListSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokFiyatListSil(List<PocoSTOKFIYATLIST> pModel)
        {
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }

        #endregion

        #region STOKFIYATLISTHAR

        [HttpGet]

        public async Task<IActionResult> StokFiyatListHarKart()
        {

            _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarListeServis);
            return View(_tempPocoStokFiyatHarList.obje);
        }

        [HttpGet]
        public IActionResult StokFiyatListHarEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokFiyatListHarEkle(PocoSTOKFIYATLISTHAR pModel)
        {
            _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokFiyatListHarSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokFiyatListHarSil(List<PocoSTOKFIYATLISTHAR> pModel)
        {
            _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }


        #endregion

        #region STOKHAR

        [HttpGet]
        public async Task<IActionResult> StokHarKart()
        {
            _tempPocoStokHar.Data(ServisList.StokHarListeServis);

            return View(_tempPocoStokHar.obje);
        }

        [HttpGet]
        public IActionResult StokHarEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokHarEkle(PocoSTOKHAR pModel)
        {

            _tempPocoStokHar.Data(ServisList.StokHarEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }

        [HttpGet]
        public IActionResult StokHarSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokHarSil(List<PocoSTOKHAR> pModel)
        {

            _tempPocoStokHar.Data(ServisList.StokHarSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion

        #region STOKKASA


        [HttpGet]
        public async Task<IActionResult> StokKasaKart()
        {
            _tempPocoStokKasa.Data(ServisList.StokKasaListeServis);

            return View(_tempPocoStokKasa.obje);
        }

        [HttpGet]
        public IActionResult StokKasaEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokKasaEkle(PocoSTOKKASA pModel)
        {

            _tempPocoStokKasa.Data(ServisList.StokKasaEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokKasaSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokKasaSil(List<PocoSTOKKASA> pModel)
        {

            _tempPocoStokKasa.Data(ServisList.StokKasaSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion

        #region STOKKATEGORI


        [HttpGet]
        public async Task<IActionResult> StokKategoriKart()
        {
            _tempPocoStokKategori.Data(ServisList.StokKategoriListeServis);

            return View(_tempPocoStokKategori.obje);
        }

        [HttpGet]
        public IActionResult StokKategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokKategoriEkle(PocoSTOKKATEGORI pModel)
        {

            _tempPocoStokKategori.Data(ServisList.StokKategoriEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokKategoriSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokKategoriSil(List<PocoSTOKKATEGORI> pModel)
        {

            _tempPocoStokKategori.Data(ServisList.StokKategoriSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion

        #region STOKMARKA


        [HttpGet]
        public async Task<IActionResult> StokMarkaKart()
        {
            _tempPocoStokMarka.Data(ServisList.StokMarkaListeServis);

            return View(_tempPocoStokMarka.obje);
        }

        [HttpGet]
        public IActionResult StokMarkaEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokMarkaEkle(PocoSTOKMARKA pModel)
        {

            _tempPocoStokMarka.Data(ServisList.StokMarkaEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokMarkaSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokMarkaSil(List<PocoSTOKMARKA> pModel)
        {

            _tempPocoStokMarka.Data(ServisList.StokMarkaSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion

        #region STOKOLCUBR


        [HttpGet]
        public async Task<IActionResult> StokOlcuBrKart()
        {
            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrListeServis);

            return View(_tempPocoStokOlcuBr.obje);
        }

        [HttpGet]
        public IActionResult StokOlcuBrEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokOlcuBrEkle(PocoSTOKOLCUBR pModel)
        {

            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokOlcuBrSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokOlcuBrSil(List<PocoSTOKOLCUBR> pModel)
        {

            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion

        #region STOKSAYIM


        [HttpGet]
        public async Task<IActionResult> StokSayimKart()
        {
            _tempPocoStokSayim.Data(ServisList.StokSayimListeServis);

            return View(_tempPocoStokSayim.obje);
        }

        [HttpGet]
        public IActionResult StokSayimEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokSayimEkle(PocoSTOKSAYIM pModel)
        {

            _tempPocoStokSayim.Data(ServisList.StokSayimEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokSayimSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokSayimSil(List<PocoSTOKSAYIM> pModel)
        {

            _tempPocoStokSayim.Data(ServisList.StokSayimSilServis, modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion

        #region STOKSAYIMHAR


        [HttpGet]
        public async Task<IActionResult> StokSayimHarKart()
        {
            _tempPocoStokSayimHar.Data(ServisList.StokSayimHarListeServis);

            return View(_tempPocoStokSayimHar.obje);
        }

        [HttpGet]
        public IActionResult StokSayimHarEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokSayimHarEkle(PocoSTOKSAYIMHAR pModel)
        {

            _tempPocoStokSayimHar.Data(ServisList.StokSayimHarEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult StokSayimHarSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokSayimHarSil(List<PocoSTOKSAYIMHAR> pModel)
        {

            _tempPocoStokSayimHar.Data(ServisList.StokSayimHarSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla Silindi.";
            return View();
        }
        #endregion

    }
}
