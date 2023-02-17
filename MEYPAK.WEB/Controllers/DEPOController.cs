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
        GenericWebServis<PocoSTOKMALKABULLIST> _tempStokMalKabulList = new GenericWebServis<PocoSTOKMALKABULLIST>();
        GenericWebServis<PocoSTOKSEVKIYATLIST> _tempStokSevkiyatList = new GenericWebServis<PocoSTOKSEVKIYATLIST>();
        GenericWebServis<PocoDEPOCEKILIST> _tempDepoCekiList = new GenericWebServis<PocoDEPOCEKILIST>();
        public DEPOController(ILogger<DEPOController> logger)
        {
            _logger = logger;
        }

        static List<PocoDEPO> PocoDepos = new List<PocoDEPO>();
        static int tempdepoid = 0;
       

        #region DEPO

        [HttpGet]
        public async Task<IActionResult> DepoRapor()
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
     
        #region STOKMALKABULLIST

        [HttpGet]
        public async Task<IActionResult> StokMalKabulKart()
        {
            return View();
        }

        [HttpGet]
        public object StokMalKabulGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokMalKabulList.Data(ServisList.StokMalKabulListListeServis);
            return DataSourceLoader.Load(_tempStokMalKabulList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
       
        #endregion

        #region STOKSEVKIYATLIST

        [HttpGet]
        public async Task<IActionResult> StokSevkiyatListKart()
        {
            return View();
        }

        [HttpGet]
        public object StokSevkiyatListGet(DataSourceLoadOptions loadOptions)
        {
            _tempStokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);
            return DataSourceLoader.Load(_tempStokSevkiyatList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        
        #endregion

    }
}
