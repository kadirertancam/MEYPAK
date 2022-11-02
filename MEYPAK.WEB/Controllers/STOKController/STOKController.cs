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
using MEYPAK.WEB.Assets;

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



        static List<PocoSTOK> PocoSTOKs = new List<PocoSTOK>();

        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;

        }



        #region STOK

        [HttpGet]
        public async Task<IActionResult> StokKart()
        {
            return View();
        }

        [HttpGet]
        public object StokGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoStok.Data(ServisList.StokListeServis);
            return DataSourceLoader.Load(_tempPocoStok.obje.Where(x=> x.kayittipi==0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokPut(int key, string values)
        { //güncellenecek
            _tempPocoStok.Data(ServisList.StokListeServis);
            var employee = _tempPocoStok.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStok.Data(ServisList.StokEkleServis, employee);
            var b = _tempPocoStok.obje;
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokPost(string values)
        {
            PocoSTOK newPoco = new PocoSTOK();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStok.Data(ServisList.StokEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokDelete(int key)
        {
            string url = ServisList.StokDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStok.Data(url,method:HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region HİZMET

        [HttpGet]
        public async Task<IActionResult> HizmetKart()
        {
            return View();
        }

        [HttpGet]
        public object HizmetGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoHizmet.Data(ServisList.HizmetListeServis);
            return DataSourceLoader.Load(_tempPocoHizmet.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> HizmetPut(int key, string values)
        { //güncellenecek
            _tempPocoHizmet.Data(ServisList.HizmetListeServis);
            var employee = _tempPocoHizmet.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoHizmet.Data(ServisList.HizmetEkleServis, employee);
            var b = _tempPocoHizmet.obje;
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> HizmetPost(string values)
        {
            PocoHIZMET newPoco = new PocoHIZMET();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoHizmet.Data(ServisList.HizmetEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void HizmetDelete(int key)
        {
            string url = ServisList.HizmetDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoHizmet.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region OLCUBR

        [HttpGet]
        public async Task<IActionResult> OlcuBrKart()
        {
            return View();
        }

        [HttpGet]
        public object OlcuBrGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoOlcuBr.Data(ServisList.OlcuBrListeServis);
            return DataSourceLoader.Load(_tempPocoOlcuBr.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> OlcuBrPut(int key, string values)
        { //güncellenecek
            _tempPocoOlcuBr.Data(ServisList.OlcuBrListeServis);
            var employee = _tempPocoOlcuBr.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoOlcuBr.Data(ServisList.OlcuBrEkleServis, employee);
            var b = _tempPocoOlcuBr.obje;
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> OlcuBrPost(string values)
        {
            PocoOLCUBR newPoco = new PocoOLCUBR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoOlcuBr.Data(ServisList.OlcuBrEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void OlcuBrDelete(int key)
        {
            string url = ServisList.OlcuBrDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoOlcuBr.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKFIYATLIST

        [HttpGet]
        public async Task<IActionResult> StokFiyatListKart()
        {
            return View();
        }

        [HttpGet]
        public object StokFiyatListGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListListeServis);
            return DataSourceLoader.Load(_tempPocoStokFiyatList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokFiyatListPut(int key, string values)
        { //güncellenecek
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListListeServis);
            var employee = _tempPocoStokFiyatList.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis, employee);
            var b = _tempPocoStokFiyatList.obje;
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokFiyatListPost(string values)
        {
            PocoSTOKFIYATLIST newPoco = new PocoSTOKFIYATLIST();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis, newPoco);
            return Redirect("StokFiyatListHarKart?id="+_tempPocoStokFiyatList.obje2.id);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokFiyatListDelete(int key)
        {
            string url = ServisList.StokFiyatListDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokFiyatList.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKFIYATLISTHAR
        GenericObject<int> Stokfiyatlistid;
        [HttpGet]
        public async Task<IActionResult> StokFiyatListHarKart(int id)
        {
            //apiden guid isteği atılıp 
            ViewBag.FiyatList = $"{id}";
            return View();
        }

        [HttpGet]
        public object StokFiyatListHarGet(DataSourceLoadOptions loadOptions,int id)
        {
                if (ViewBag.FiyatList != null)
                {
                string a = ViewBag.FiyatList.Message;
                
                _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarListeServis);
                    return DataSourceLoader.Load(_tempPocoStokFiyatHarList.obje.Where(x => x.kayittipi == 0 && x.fiyatlistid == Convert.ToInt32(a)).Reverse().AsEnumerable(), loadOptions);
                }
            
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> StokFiyatListHarPut(int key, string values)
        { //güncellenecek
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListListeServis);
            var employee = _tempPocoStokFiyatList.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis, employee);
            var b = _tempPocoStokFiyatList.obje;
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokFiyatListHarPost(string values)
        {
            PocoSTOKFIYATLIST newPoco = new PocoSTOKFIYATLIST();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokFiyatListHarDelete(int key)
        {
            string url = ServisList.StokFiyatListDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokFiyatList.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion













        #region old_controller

        //#region STOK






        //[HttpGet]
        //public IActionResult StokSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokSil(List<PocoSTOK> pModel)
        //{

        //    _tempPocoStok.Data(ServisList.StokSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}

        //#endregion

        //#region HIZMET


        //[HttpGet]
        //public IActionResult HizmetEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> HizmetEkle(PocoHIZMET pModel)
        //{
        //    _tempPocoHizmet.Data(ServisList.HizmetEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult HizmetSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> HizmetSil(List<PocoHIZMET> pModel)
        //{
        //    _tempPocoHizmet.Data(ServisList.HizmetSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla Silindi.";
        //    return View();
        //}

        //[HttpGet]
        //public object HizmetListe(DataSourceLoadOptions loadOptions)
        //{

        //    _tempPocoHizmet.Data(ServisList.HizmetListeServis);
        //    return DataSourceLoader.Load(_tempPocoHizmet.obje, loadOptions);
        //}

        //#endregion

        //#region OLCUBR
        //[HttpGet]
        //public async Task<IActionResult> OlcuBrKart()
        //{
        //    _tempPocoOlcuBr.Data(ServisList.OlcuBrListeServis);
        //    return View(_tempPocoOlcuBr.obje);
        //}

        //[HttpGet]
        //public IActionResult OlcuBrEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> OlcuBrEkle(PocoOLCUBR pModel)
        //{
        //    _tempPocoOlcuBr.Data(ServisList.OlcuBrEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult OlcuBrSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> OlcuBrSil(List<PocoOLCUBR> pModel)
        //{
        //    _tempPocoOlcuBr.Data(ServisList.OlcuBrSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        //[HttpGet]
        //public object OlcuBrGet(DataSourceLoadOptions loadOptions)
        //{
        //    var a = loadOptions.Take;
        //    var b = loadOptions.Skip;
        //    string url = "http://213.238.167.117:8080/OLCUBR/PagingList?skip=" + b + "&take=" + a + "&requireTotalCount=true";
        //    _tempPocoOlcuBr.Data(url);
        //    return DataSourceLoader.Load(_tempPocoOlcuBr.obje, loadOptions);
        //}

        //#endregion

        //#region STOKFIYATLIST

        //[HttpGet]

        //public async Task<IActionResult> StokFiyatListKart()
        //{

        //    _tempPocoStokFiyatList.Data(ServisList.StokFiyatListListeServis);
        //    return View(_tempPocoStokFiyatList.obje);
        //}

        //[HttpGet]
        //public IActionResult StokFiyatListEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokFiyatListEkle(PocoSTOKFIYATLIST pModel)
        //{
        //    _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokFiyatListSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokFiyatListSil(List<PocoSTOKFIYATLIST> pModel)
        //{
        //    _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        //[HttpGet]
        //public object StokFiyatListGet(DataSourceLoadOptions loadOptions)
        //{
        //    var a = loadOptions.Take;
        //    var b = loadOptions.Skip;
        //    string url = "http://213.238.167.117:8080/STOKFIYATLIST/PagingList?skip=" + b + "&take=" + a + "&requireTotalCount=true";
        //    _tempPocoStokFiyatList.Data(url);
        //    return DataSourceLoader.Load(_tempPocoStokFiyatList.obje, loadOptions);
        //}


        //#endregion

        //#region STOKFIYATLISTHAR

        //[HttpGet]

        //public async Task<IActionResult> StokFiyatListHarKart()
        //{

        //    _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarListeServis);
        //    return View(_tempPocoStokFiyatHarList.obje);
        //}

        //[HttpGet]
        //public IActionResult StokFiyatListHarEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokFiyatListHarEkle(PocoSTOKFIYATLISTHAR pModel)
        //{
        //    _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokFiyatListHarSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokFiyatListHarSil(List<PocoSTOKFIYATLISTHAR> pModel)
        //{
        //    _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        //[HttpGet]
        //public object StokFiyatListHarGet(DataSourceLoadOptions loadOptions)
        //{
        //    var a = loadOptions.Take;
        //    var b = loadOptions.Skip;
        //    string url = "http://213.238.167.117:8080/STOKFIYATLISTHAR/PagingList?skip=" + b + "&take=" + a + "&requireTotalCount=true";
        //    _tempPocoStokFiyatHarList.Data(url);
        //    return DataSourceLoader.Load(_tempPocoStokFiyatHarList.obje, loadOptions);
        //}

        //#endregion

        //#region STOKHAR

        //[HttpGet]
        //public async Task<IActionResult> StokHarKart()
        //{
        //    _tempPocoStokHar.Data(ServisList.StokHarListeServis);

        //    return View(_tempPocoStokHar.obje);
        //}

        //[HttpGet]
        //public IActionResult StokHarEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokHarEkle(PocoSTOKHAR pModel)
        //{

        //    _tempPocoStokHar.Data(ServisList.StokHarEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult StokHarSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokHarSil(List<PocoSTOKHAR> pModel)
        //{

        //    _tempPocoStokHar.Data(ServisList.StokHarSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}

        //[HttpGet]
        //public object StokHarGet(DataSourceLoadOptions loadOptions)
        //{
        //    var a = loadOptions.Take;
        //    var b = loadOptions.Skip;
        //    string url = "http://213.238.167.117:8080/STOKHAR/PagingList?skip=" + b + "&take=" + a + "&requireTotalCount=true";
        //    _tempPocoStokHar.Data(url);
        //    return DataSourceLoader.Load(_tempPocoStokHar.obje, loadOptions);
        //}
        //#endregion

        //#region STOKKASA


        //[HttpGet]
        //public async Task<IActionResult> StokKasaKart()
        //{
        //    _tempPocoStokKasa.Data(ServisList.StokKasaListeServis);

        //    return View(_tempPocoStokKasa.obje);
        //}

        //[HttpGet]
        //public IActionResult StokKasaEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokKasaEkle(PocoSTOKKASA pModel)
        //{
        //    _tempPocoStokKasa.Data(ServisList.StokKasaEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokKasaSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokKasaSil(List<PocoSTOKKASA> pModel)
        //{

        //    _tempPocoStokKasa.Data(ServisList.StokKasaSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}

        //[HttpGet]
        //public object StokKasaGet(DataSourceLoadOptions loadOptions)
        //{
        //    var a = loadOptions.Take;
        //    var b = loadOptions.Skip;
        //    string url = "http://213.238.167.117:8080/STOKHAR/PagingList?skip=" + b + "&take=" + a + "&requireTotalCount=true";
        //    _tempPocoStokHar.Data(url);
        //    return DataSourceLoader.Load(_tempPocoStokHar.obje, loadOptions);
        //}
        //#endregion

        //#region STOKKATEGORI


        //[HttpGet]
        //public async Task<IActionResult> StokKategoriKart()
        //{
        //    _tempPocoStokKategori.Data(ServisList.StokKategoriListeServis);

        //    return View(_tempPocoStokKategori.obje);
        //}

        //[HttpGet]
        //public IActionResult StokKategoriEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokKategoriEkle(PocoSTOKKATEGORI pModel)
        //{

        //    _tempPocoStokKategori.Data(ServisList.StokKategoriEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokKategoriSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokKategoriSil(List<PocoSTOKKATEGORI> pModel)
        //{

        //    _tempPocoStokKategori.Data(ServisList.StokKategoriSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}

        //[HttpGet]
        //public object StokKategoriGet(DataSourceLoadOptions loadOptions)
        //{
        //    var a = loadOptions.Take;
        //    var b = loadOptions.Skip;
        //    string url = "http://213.238.167.117:8080/STOKKATEGORI/PagingList?skip=" + b + "&take=" + a + "&requireTotalCount=true";
        //    _tempPocoStokKategori.Data(url);
        //    return DataSourceLoader.Load(_tempPocoStokKategori.obje, loadOptions);
        //}
        //#endregion

        //#region STOKMARKA


        //[HttpGet]
        //public async Task<IActionResult> StokMarkaKart()
        //{
        //    _tempPocoStokMarka.Data(ServisList.StokMarkaListeServis);

        //    return View(_tempPocoStokMarka.obje);
        //}

        //[HttpGet]
        //public IActionResult StokMarkaEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokMarkaEkle(PocoSTOKMARKA pModel)
        //{

        //    _tempPocoStokMarka.Data(ServisList.StokMarkaEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokMarkaSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokMarkaSil(List<PocoSTOKMARKA> pModel)
        //{

        //    _tempPocoStokMarka.Data(ServisList.StokMarkaSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        //#endregion

        //#region STOKOLCUBR


        //[HttpGet]
        //public async Task<IActionResult> StokOlcuBrKart()
        //{
        //    _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrListeServis);

        //    return View(_tempPocoStokOlcuBr.obje);
        //}

        //[HttpGet]
        //public IActionResult StokOlcuBrEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokOlcuBrEkle(PocoSTOKOLCUBR pModel)
        //{

        //    _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokOlcuBrSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokOlcuBrSil(List<PocoSTOKOLCUBR> pModel)
        //{

        //    _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        //#endregion

        //#region STOKSAYIM


        //[HttpGet]
        //public async Task<IActionResult> StokSayimKart()
        //{
        //    _tempPocoStokSayim.Data(ServisList.StokSayimListeServis);

        //    return View(_tempPocoStokSayim.obje);
        //}

        //[HttpGet]
        //public IActionResult StokSayimEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokSayimEkle(PocoSTOKSAYIM pModel)
        //{

        //    _tempPocoStokSayim.Data(ServisList.StokSayimEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokSayimSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokSayimSil(List<PocoSTOKSAYIM> pModel)
        //{

        //    _tempPocoStokSayim.Data(ServisList.StokSayimSilServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        //#endregion

        //#region STOKSAYIMHAR


        //[HttpGet]
        //public async Task<IActionResult> StokSayimHarKart()
        //{
        //    _tempPocoStokSayimHar.Data(ServisList.StokSayimHarListeServis);

        //    return View(_tempPocoStokSayimHar.obje);
        //}

        //[HttpGet]
        //public IActionResult StokSayimHarEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokSayimHarEkle(PocoSTOKSAYIMHAR pModel)
        //{

        //    _tempPocoStokSayimHar.Data(ServisList.StokSayimHarEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokSayimHarSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokSayimHarSil(List<PocoSTOKSAYIMHAR> pModel)
        //{

        //    _tempPocoStokSayimHar.Data(ServisList.StokSayimHarSilServis,modellist: pModel);

        //    ViewBag.Durum = "Başarıyla Silindi.";
        //    return View();
        //}
        //#endregion

        #endregion
    }
}
