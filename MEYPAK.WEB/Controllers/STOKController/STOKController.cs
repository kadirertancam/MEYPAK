using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
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
        static int tempstokkartid = 0;
        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;

        }
        // GenericObject<int> Stokfiyatlistid;
        //apiden guid isteği atılıp 


        #region STOK

        [HttpGet]
        public IActionResult StokKart()
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
        [HttpPut]
        public async Task<IActionResult> StokPut(int key, string values)
        { //güncellenecek
            _tempPocoStok.Data(ServisList.StokListeServis);
            var employee = _tempPocoStok.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStok.Data(ServisList.StokEkleServis, employee);

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
            _tempPocoStok.Data(url, method: HttpMethod.Post);
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

        #region STOKFIYATLIST

        [HttpGet]
        public async Task<IActionResult> StokFiyatListKart()
        { 
            tempstokkartid=0;
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
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok(_tempPocoStokFiyatList.obje.FirstOrDefault().id);
        }
        [HttpPost]
        public   IActionResult StokFiyatListPost(string values)
        {
            PocoSTOKFIYATLIST newPoco = new PocoSTOKFIYATLIST();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokFiyatList.Data(ServisList.StokFiyatListEkleServis, newPoco);
            tempstokkartid = _tempPocoStokFiyatList.obje2.id;
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

        [HttpGet]
        public   IActionResult StokFiyatListHarKart()
        {
            if (tempstokkartid != 0)
                return View();
            else 
                return Redirect("http://localhost:5232/Home/Error"); 
        }

        [HttpGet]
        public object StokFiyatListHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarListeServis);
            return DataSourceLoader.Load(_tempPocoStokFiyatHarList.obje.Where(x => x.kayittipi == 0 && x.fiyatlistid == tempstokkartid).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokFiyatListHarPut(int key, string values)
        { //güncellenecek
            _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarListeServis);
            var employee = _tempPocoStokFiyatHarList.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarEkleServis, employee);
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokFiyatListHarPost(string values)
        {
            PocoSTOKFIYATLISTHAR newPoco = new PocoSTOKFIYATLISTHAR();
            JsonConvert.PopulateObject(values, newPoco);
            newPoco.fiyatlistid = tempstokkartid;
            newPoco.stokid = 1;
            _tempPocoStokFiyatHarList.Data(ServisList.StokFiyatListHarEkleServis, newPoco);
            
            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokFiyatListHarDelete(int key)
        {
            string url = ServisList.StokFiyatListHarDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokFiyatHarList.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKHAR

        [HttpGet]
        public async Task<IActionResult> StokHarKart(int id)
        {
            return View();
        }

        [HttpGet]
        public object StokHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempPocoStokHar.Data(ServisList.StokHarListeServis);
            return DataSourceLoader.Load(_tempPocoStokHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);

        }
        [HttpPut]
        public async Task<IActionResult> StokHarPut(int key, string values)
        { //güncellenecek
            _tempPocoStokHar.Data(ServisList.StokHarListeServis);
            var employee = _tempPocoStokHar.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokHar.Data(ServisList.StokHarEkleServis, employee);
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokHarPost(string values)
        {
            PocoSTOKHAR newPoco = new PocoSTOKHAR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokHar.Data(ServisList.StokHarEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokHarDelete(int key)
        {
            string url = ServisList.StokHarDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokHar.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKKASA

        [HttpGet]
        public async Task<IActionResult> StokKasaKart(int id)
        {
            return View();
        }

        [HttpGet]
        public object StokKasaGet(DataSourceLoadOptions loadOptions)
        {
            _tempPocoStokKasa.Data(ServisList.StokKasaListeServis);
            return DataSourceLoader.Load(_tempPocoStokKasa.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);

        }
        [HttpPut]
        public async Task<IActionResult> StokKasaPut(int key, string values)
        { //güncellenecek
            _tempPocoStokKasa.Data(ServisList.StokKasaListeServis);
            var employee = _tempPocoStokKasa.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokKasa.Data(ServisList.StokKasaEkleServis, employee);
 
            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokKasaPost(string values)
        {
            PocoSTOKKASA newPoco = new PocoSTOKKASA();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokKasa.Data(ServisList.StokKasaEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokKasaDelete(int key)
        {
            string url = ServisList.StokKasaDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokKasa.Data(url, method: HttpMethod.Post);
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
        public async Task<IActionResult> StokOlcuBrKart()
        {
            return View();
        }

        [HttpGet]
        public object StokOlcuBrGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            return DataSourceLoader.Load(_tempPocoStokOlcuBr.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokOlcuBrPut(int key, string values)
        { //güncellenecek
            _tempPocoStokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            var employee = _tempPocoStokOlcuBr.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

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

        #region STOKSAYIM

        [HttpGet]
        public async Task<IActionResult> StokSayimKart()
        {
            return View();
        }

        [HttpGet]
        public object StokSayimGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoStokSayim.Data(ServisList.StokSayimListeServis);
            return DataSourceLoader.Load(_tempPocoStokSayim.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokSayimPut(int key, string values)
        { //güncellenecek
            _tempPocoStokSayim.Data(ServisList.StokSayimListeServis);
            var employee = _tempPocoStokSayim.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokSayim.Data(ServisList.StokSayimEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokSayimPost(string values)
        {
            PocoSTOKSAYIM newPoco = new PocoSTOKSAYIM();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokSayim.Data(ServisList.StokSayimEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokSayimDelete(int key)
        {
            string url = ServisList.StokSayimDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokSayim.Data(url, method: HttpMethod.Post);
            ViewBag.Durum = "Başarıyla silindi.";
        }

        #endregion

        #region STOKSAYIMHAR

        [HttpGet]
        public async Task<IActionResult> StokSayimHarKart()
        {
            return View();
        }

        [HttpGet]
        public object StokSayimHarGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempPocoStokSayimHar.Data(ServisList.StokSayimHarListeServis);
            return DataSourceLoader.Load(_tempPocoStokSayimHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokSayimHarPut(int key, string values)
        { //güncellenecek
            _tempPocoStokSayimHar.Data(ServisList.StokSayimHarListeServis);
            var employee = _tempPocoStokSayimHar.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);

            //_tempPocoStok.Data(ServisList.StokEkleServis, id);

            _tempPocoStokSayimHar.Data(ServisList.StokSayimHarEkleServis, employee);

            ViewBag.Durum = "Başarıyla Güncellendi.";
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokSayimHarPost(string values)
        {
            PocoSTOKSAYIMHAR newPoco = new PocoSTOKSAYIMHAR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokSayimHar.Data(ServisList.StokSayimHarEkleServis, newPoco);

            ViewBag.Durum = "Başarıyla eklendi.";
            return Ok();
        }
        [HttpDelete]
        public void StokSayimHarDelete(int key)
        {
            string url = ServisList.StokSayimHarDeleteByIdServis;
            url += "?id=";
            url += key;
            _tempPocoStokSayimHar.Data(url, method: HttpMethod.Post);
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
