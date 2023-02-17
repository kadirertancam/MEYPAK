using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.BLL.Assets;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExpress.Pdf;

namespace MEYPAK.WEB.Controllerss
{
    public class StokController : Controller
    {

        private readonly ILogger<StokController> _logger;

        GenericWebServis<PocoSTOK> _tempStok = new GenericWebServis<PocoSTOK>();
        GenericWebServis<PocoSTOKKATEGORI> _tempStokKategori = new GenericWebServis<PocoSTOKKATEGORI>();
        GenericWebServis<PocoSTOKHAR> _tempStokHar = new GenericWebServis<PocoSTOKHAR>();
        GenericWebServis<PocoSTOKSAYIMHAR> _tempStokSayimHar = new GenericWebServis<PocoSTOKSAYIMHAR>();
        GenericWebServis<PocoSTOKSAYIM> _tempStokSayim = new GenericWebServis<PocoSTOKSAYIM>();
        GenericWebServis<PocoSTOKMARKA> _tempStokMarka = new GenericWebServis<PocoSTOKMARKA>();
        GenericWebServis<PocoSTOKKASAHAR> _tempStokKasaHar = new GenericWebServis<PocoSTOKKASAHAR>();
        GenericWebServis<PocoOLCUBR> _tempOlcuBr = new GenericWebServis<PocoOLCUBR>();
        GenericWebServis<PocoHIZMET> _tempHizmet = new GenericWebServis<PocoHIZMET>();
        GenericWebServis<PocoSTOKOLCUBR> _tempStokOlcuBr = new GenericWebServis<PocoSTOKOLCUBR>();
        GenericWebServis<PocoSTOKFIYAT> _tempStokFiyat = new GenericWebServis<PocoSTOKFIYAT>();
        GenericWebServis<PocoSTOKFIYATHAR> _tempStokFiyatHar = new GenericWebServis<PocoSTOKFIYATHAR>();

        #region Tanımlar
        static List<PocoSTOK> PocoSTOKs = new List<PocoSTOK>();
        static int tempstokkartid = 0;
        static List<PocoSTOKKATEGORI> PocoStokKategoris = new List<PocoSTOKKATEGORI>(); 
        static int tempstokkategoriid = 0;
        static List<PocoSTOKHAR> PocoStokHars = new List<PocoSTOKHAR>();
        static int tempstokharid = 0;
        static List<PocoSTOKSAYIMHAR> PocoStokSayimHars = new List<PocoSTOKSAYIMHAR>();
        static int tempstoksayimharid = 0;
        static List<PocoSTOKSAYIM> PocoStokSayims = new List<PocoSTOKSAYIM>();
        static int tempstoksayimid = 0;
        static List<PocoSTOKFIYAT> PocoStokFiyats = new List<PocoSTOKFIYAT>();
        static int tempstokfiyatid = 0;
        static List<PocoSTOKFIYATHAR> PocoStokFiyatHars = new List<PocoSTOKFIYATHAR>();
        static int tempstokfiyatharid = 0;
        static List<PocoSTOKKASAHAR> PocoStokKasaHars = new List<PocoSTOKKASAHAR>();
        static int tempstokkasaharid = 0;
        static List<PocoSTOKOLCUBR> PocoStokOlcuBrs = new List<PocoSTOKOLCUBR>();
        static int tempstokolcubrid = 0;
        static List<PocoSTOKMARKA> PocoStokMarkas = new List<PocoSTOKMARKA>();
        static int tempstokmarkaid = 0;
        static List<PocoOLCUBR> PocoOlcuBrs = new List<PocoOLCUBR>();
        static int tempolcubrid = 0;
        static List<PocoHIZMET> PocoHizmets = new List<PocoHIZMET>();
        static int temphizmetid = 0;

        #endregion
        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;

        }
        
        #region STOK

        [HttpGet]
        public IActionResult StokListesi()
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
            _tempStok.Data(ServisList.StokListeServis);
            return DataSourceLoader.Load(_tempStok.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
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
            _tempStokKategori.Data(ServisList.StokKategoriListeServis);
            return DataSourceLoader.Load(_tempStokKategori.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region STOKHAR

        [HttpGet]
        public async Task<IActionResult> StokHareketListesi(int id)
        {
            return View();
        }

        [HttpGet]
        public object StokHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokHar.Data(ServisList.StokHarListeServis);
            return DataSourceLoader.Load(_tempStokHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);

        }

        #endregion

        #region STOKSAYIMHAR

        [HttpGet]
        public async Task<IActionResult> StokSayimHareket()
        {
            return View();
        }

        [HttpGet]
        public object StokSayimHarGet(DataSourceLoadOptions loadOptions)
        {

            _tempStokSayimHar.Data(ServisList.StokSayimHarListeServis);
            return DataSourceLoader.Load(_tempStokSayimHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region STOKSAYIM

        [HttpGet]
        public async Task<IActionResult> StokSayimRapor()
        {
            return View();
        }

        [HttpGet]
        public object StokSayimGet(DataSourceLoadOptions loadOptions)
        {

            _tempStokSayim.Data(ServisList.StokSayimListeServis);
            return DataSourceLoader.Load(_tempStokSayim.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region STOKMARKA

        [HttpGet]
        public async Task<IActionResult> StokMarka()
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
            _tempStokMarka.Data(ServisList.StokMarkaListeServis);
            return DataSourceLoader.Load(_tempStokMarka.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
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
            _tempOlcuBr.Data(ServisList.OlcuBrListeServis);
            return DataSourceLoader.Load(_tempOlcuBr.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]


        #endregion

        #region HİZMET

        [HttpGet]
        public IActionResult HizmetRapor()
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
            _tempHizmet.Data(ServisList.HizmetListeServis);
            return DataSourceLoader.Load(_tempHizmet.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
     
        #endregion

        #region STOKOLCUBR

        [HttpGet]
        public IActionResult StokOlcuBrRapor()
        {
            return View();
        }

        [HttpGet]
        public object StokOlcuBrGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokOlcuBr.Data(ServisList.StokOlcuBrListeServis);
            return DataSourceLoader.Load(_tempStokOlcuBr.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
      
        #endregion

        #region STOKFİYAT

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

        #endregion

        #region STOKFİYATHAR

        [HttpGet]
        public IActionResult StokFiyatHarRapor()
        {
            return View();
        }

        [HttpGet]
        public object StokFiyatHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokFiyatHar.Data(ServisList.StokFiyatHarListeServis);
            return DataSourceLoader.Load(_tempStokFiyatHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

    }
}


