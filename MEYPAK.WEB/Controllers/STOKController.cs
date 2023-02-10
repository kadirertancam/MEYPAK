using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExpress.Pdf;

namespace MEYPAK.WEB.Controllers
{
    public class StokController : Controller
    {

        private readonly ILogger<StokController> _logger;
        GenericWebServis<PocoSTOK> _tempPocoStok = new GenericWebServis<PocoSTOK>();
        GenericWebServis<PocoSTOKFIYAT> _tempStokFiyat = new GenericWebServis<PocoSTOKFIYAT>();
        GenericWebServis<PocoSTOKHAR> _tempStokHar = new GenericWebServis<PocoSTOKHAR>();
        GenericWebServis<PocoSTOKSAYIMHAR> _tempStokSayimHar = new GenericWebServis<PocoSTOKSAYIMHAR>();
        GenericWebServis<PocoSTOKKASAHAR> _tempStokKasaHar = new GenericWebServis<PocoSTOKKASAHAR>();
        GenericWebServis<PocoHIZMET> _tempPocoHizmet = new GenericWebServis<PocoHIZMET>();
        GenericWebServis<PocoOLCUBR> _tempPocoOlcuBr = new GenericWebServis<PocoOLCUBR>();
        GenericWebServis<PocoSTOKKATEGORI> _tempPocoStokKategori = new GenericWebServis<PocoSTOKKATEGORI>();
        GenericWebServis<PocoSTOKMARKA> _tempPocoStokMarka = new GenericWebServis<PocoSTOKMARKA>();
        GenericWebServis<PocoSTOKOLCUBR> _tempPocoStokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
        GenericWebServis<PocoSTOKSAYIM> _tempPocoStokSayim = new GenericWebServis<PocoSTOKSAYIM>();




        static List<PocoSTOK> PocoSTOKs = new List<PocoSTOK>();
        static int tempstokkartid = 0;
        static List<PocoSTOKFIYAT> PocoStokFiyats = new List<PocoSTOKFIYAT>();
        static int tempstokfiyatid = 0;
        static List<PocoSTOKHAR> PocoStokHars = new List<PocoSTOKHAR>();
        static int tempstokharid = 0;
        static List<PocoSTOKSAYIMHAR> PocoStokSayimHars = new List<PocoSTOKSAYIMHAR>();
        static int tempstoksayimharid = 0;


        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;

        }
        // GenericObject<int> Stokfiyatlistid;
        //apiden guid isteği atılıp 


        #region STOK

        [HttpGet]
        public IActionResult Stok()
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
            return DataSourceLoader.Load(_tempPocoStok.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
      
       
       
        #endregion





        #region STOKFIYAT

        [HttpGet]
        public IActionResult StokFiyatRapor()
        {
            return View();
        }

        [HttpGet]
        public object StokFiyatGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokFiyat.Data(ServisList.StokFiyatListeServis);
            return DataSourceLoader.Load(_tempStokFiyat.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokFiyatPut(int key, string values)
        { //güncellenecek
            _tempStokFiyat.Data(ServisList.StokFiyatListeServis);
            var employee = _tempStokFiyat.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);



            _tempStokFiyat.Data(ServisList.StokFiyatEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokFiyatPost(string values)
        {
            PocoSTOKFIYAT newPoco = new PocoSTOKFIYAT();
            JsonConvert.PopulateObject(values, newPoco);
            _tempStokFiyat.Data(ServisList.StokFiyatEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokFiyatDelete(int key)
        {
            string url = ServisList.StokFiyatDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempStokFiyat.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKHAR

        [HttpGet]
        public async Task<IActionResult> StokHareketRapor(int id)
        {
            return View();
        }

        [HttpGet]
        public object StokHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokHar.Data(ServisList.StokHarListeServis);
            return DataSourceLoader.Load(_tempStokHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);

        }
        [HttpPut]
        public async Task<IActionResult> StokHarPut(int key, string values)
        { //güncellenecek
            _tempStokHar.Data(ServisList.StokHarListeServis);
            var employee = _tempStokHar.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);


            _tempStokHar.Data(ServisList.StokHarEkleServis, employee);
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokHarPost(string values)
        {
            PocoSTOKHAR newPoco = new PocoSTOKHAR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempStokHar.Data(ServisList.StokHarEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokHarDelete(int key)
        {
            string url = ServisList.StokHarDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempStokHar.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKSAYIMHAR

        [HttpGet]
        public async Task<IActionResult> StokSayimHarRapor()
        {
            return View();
        }

        [HttpGet]
        public object StokSayimHarGet(DataSourceLoadOptions loadOptions)
        {

            _tempStokSayimHar.Data(ServisList.StokSayimHarListeServis);
            return DataSourceLoader.Load(_tempStokSayimHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokSayimHarPut(int key, string values)
        { //güncellenecek
            _tempStokSayimHar.Data(ServisList.StokSayimHarListeServis);
            var employee = _tempStokSayimHar.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);


            _tempStokSayimHar.Data(ServisList.StokSayimHarEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokSayimHarPost(string values)
        {
            PocoSTOKSAYIMHAR newPoco = new PocoSTOKSAYIMHAR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempStokSayimHar.Data(ServisList.StokSayimHarEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokSayimHarDelete(int key)
        {
            string url = ServisList.StokSayimHarDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempStokSayimHar.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKKASAHAR

        [HttpGet]
        public async Task<IActionResult> StokKasaHarRapor()
        {
            return View();
        }

        [HttpGet]
        public object StokKasaHarGet(DataSourceLoadOptions loadOptions)
        {

            _tempStokKasaHar.Data(ServisList.StokKasaHarListeServis);
            return DataSourceLoader.Load(_tempStokKasaHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokKasaHarPut(int key, string values)
        { //güncellenecek
            _tempStokKasaHar.Data(ServisList.StokKasaHarListeServis);
            var employee = _tempStokKasaHar.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);


            _tempStokKasaHar.Data(ServisList.StokKasaHarEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokKasaHarPost(string values)
        {
            PocoSTOKKASAHAR newPoco = new PocoSTOKKASAHAR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempStokKasaHar.Data(ServisList.StokKasaHarEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokKasaHarDelete(int key)
        {
            string url = ServisList.StokKasaHarDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempStokKasaHar.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion







        #region HİZMET

        [HttpGet]
        public IActionResult HizmetKart()
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
        public IActionResult OlcuBrKart()
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





        #region STOKKATEGORI

        [HttpGet]
        public async Task<IActionResult> StokKategoriKart()
        {
            return View();
        }

        [HttpGet]
        public object StokKategoriGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoStokKategori.Data(ServisList.StokKategoriListeServis);
            return DataSourceLoader.Load(_tempPocoStokKategori.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokKategoriPut(int key, string values)
        { //güncellenecek
            _tempPocoStokKategori.Data(ServisList.StokKategoriListeServis);
            var employee = _tempPocoStokKategori.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokKategori.Data(ServisList.StokKategoriEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokKategoriPost(string values)
        {
            PocoSTOKKATEGORI newPoco = new PocoSTOKKATEGORI();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokKategori.Data(ServisList.StokKategoriEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokKategoriDelete(int key)
        {
            string url = ServisList.StokKategoriDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokKategori.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKMARKA

        [HttpGet]
        public async Task<IActionResult> StokMarkaKart()
        {
            return View();
        }

        [HttpGet]
        public object StokMarkaGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoStokMarka.Data(ServisList.StokMarkaListeServis);
            return DataSourceLoader.Load(_tempPocoStokMarka.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokMarkaPut(int key, string values)
        { //güncellenecek
            _tempPocoStokMarka.Data(ServisList.StokMarkaListeServis);
            var employee = _tempPocoStokMarka.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokMarka.Data(ServisList.StokMarkaEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokMarkaPost(string values)
        {
            PocoSTOKMARKA newPoco = new PocoSTOKMARKA();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokMarka.Data(ServisList.StokMarkaEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokMarkaDelete(int key)
        {
            string url = ServisList.StokMarkaDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokMarka.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion



        #region STOKOLCUBR

        [HttpGet]
        public IActionResult StokOlcuBrKart()
        {
            return View();
        }

        [HttpGet]
        public object StokOlcuBrGet(DataSourceLoadOptions loadOptions)
        {
            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            return DataSourceLoader.Load(_tempPocoStokOlcuBr.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokOlcuBrPut(int key, string values)
        {
            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            var employee = _tempPocoStokOlcuBr.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokOlcuBrPost(string values)
        {
            PocoSTOKOLCUBR newPoco = new PocoSTOKOLCUBR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokOlcuBrDelete(int key)
        {
            string url = ServisList.StokOlcuBrDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokOlcuBr.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion


        #region old_controller

        #region STOK






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

        #endregion

        #region OLCUBR
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

        #endregion

        #region STOKFIYATLIST

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


        #endregion

        #region STOKFIYATLISTHAR

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

        #endregion

        #region STOKHAR

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
        #endregion

        #region STOKKASA


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
        #endregion

        #region STOKKATEGORI


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
        #endregion

        #region STOKMARKA


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
        #endregion

        #region STOKOLCUBR


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
        #endregion

        #region STOKSAYIM


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
        #endregion

        #region STOKSAYIMHAR


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
        #endregion

        #endregion
    }
}


