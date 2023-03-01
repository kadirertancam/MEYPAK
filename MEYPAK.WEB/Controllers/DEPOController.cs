using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MEYPAK.WEB.Controllers
{
    public class DEPOController : Controller
    {
        private readonly ILogger<DEPOController> _logger;

        GenericWebServis<PocoDEPO> _tempDepo = new GenericWebServis<PocoDEPO>();
        GenericWebServis<PocoDEPOEMIR> _tempDepoEmir = new GenericWebServis<PocoDEPOEMIR>();
        GenericWebServis<PocoDEPOTRANSFER> _tempDepoTransfer = new GenericWebServis<PocoDEPOTRANSFER>();
        GenericWebServis<PocoDEPOTRANSFERHAR> _tempDepoTransferHar = new GenericWebServis<PocoDEPOTRANSFERHAR>();
        GenericWebServis<PocoSTOKMALKABULLIST> _tempStokMalKabul = new GenericWebServis<PocoSTOKMALKABULLIST>();
        GenericWebServis<PocoDEPOCEKILIST> _tempDepoCekiList = new GenericWebServis<PocoDEPOCEKILIST>();
        GenericWebServis<PocoSTOKSEVKIYATLIST> _tempStokSevkiyatList = new GenericWebServis<PocoSTOKSEVKIYATLIST>();

        public DEPOController(ILogger<DEPOController> logger)
        {
            _logger = logger;
        }

        static List<PocoDEPO> PocoDepos = new List<PocoDEPO>();
        static int tempdepoid = 0;
        static List<PocoSTOKMALKABULLIST> PocoStokMalKabuls = new List<PocoSTOKMALKABULLIST>();
        static int tempstokmalkabulid = 0;
        static List<PocoDEPOTRANSFERHAR> PocoDepoTransferHars = new List<PocoDEPOTRANSFERHAR>();
        static int tempdepotransferharid = 0;
        static List<PocoSTOKSEVKIYATLIST> PocoStokSevkiyats = new List<PocoSTOKSEVKIYATLIST>();
        static int tempstoksevkiyatid = 0;
       


        #region DEPO

        [HttpGet]
        public async Task<IActionResult> DepoListesi()
        {
            return View();
        }

        [HttpGet]
        public object DepoGet(DataSourceLoadOptions loadOptions)
        {
            _tempDepo.Data(ServisList.DepoListeServis);
            return DataSourceLoader.Load(_tempDepo.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
       

        #endregion

        #region DEPOCEKILIST

        [HttpGet]
        public async Task<IActionResult> DepoCekiListKart()
        {
            return View();
        }

        [HttpGet]
        public object DepoCekiListGet(DataSourceLoadOptions loadOptions)
        {
            _tempDepoCekiList.Data(ServisList.DepoCekiListListeServis);
            return DataSourceLoader.Load(_tempDepoCekiList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
     
        #endregion

        #region DEPOEMIR

        [HttpGet]
        public async Task<IActionResult> DepoEmirKart()
        {
            return View();
        }

        [HttpGet]
        public object DepoEmirGet(DataSourceLoadOptions loadOptions)
        {
            _tempDepoEmir.Data(ServisList.DepoEmirListeServis);
            return DataSourceLoader.Load(_tempDepoEmir.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
      

        #endregion

        #region DEPOTRANSFER

        [HttpGet]
        public async Task<IActionResult> DepoTransferKart()
        {
            return View();
        }

        [HttpGet]
        public object DepoTransferGet(DataSourceLoadOptions loadOptions)
        {
            _tempDepoTransfer.Data(ServisList.DepoTransferListeServis);
            return DataSourceLoader.Load(_tempDepoTransfer.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }


        #endregion

        #region DEPOTRANSFERHAR

        [HttpGet]
        public async Task<IActionResult> DepoTransferHareket()
        {
            return View();
        }

        [HttpGet]
        public object DepoTransferHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempDepoTransferHar.Data(ServisList.DepoTransferHarListeServis);
            return DataSourceLoader.Load(_tempDepoTransferHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }


        #endregion

        #region STOKMALKABULLIST

        [HttpGet]
        public async Task<IActionResult> StokMalKabulListesi()
        {
            return View();
        }

        [HttpGet]
        public object StokMalKabulGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokMalKabul.Data(ServisList.StokMalKabulListListeServis);
            return DataSourceLoader.Load(_tempStokMalKabul.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }

        #endregion

        #region STOKSEVKIYAT

        [HttpGet]
        public IActionResult StokSevkiyatListesi()
        {
            return View();
        }

        [HttpGet]
        public object StokSevkiyatGet(DataSourceLoadOptions loadOptions)
        {
            //var a = loadOptions.Take;
            //var b = loadOptions.Skip;
            //string url = "http://213.238.167.117:8080/Stok/PagingList?skip="+b+"&take="+a+"&requireTotalCount=true";
            //_tempPocoStok.Data(url);
            _tempStokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
            return DataSourceLoader.Load(_tempStokSevkiyatList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        #endregion

    
    }
}
