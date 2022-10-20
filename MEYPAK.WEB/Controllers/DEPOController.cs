using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class DEPOController : Controller
    {
        private readonly ILogger<DEPOController> _logger;
        GenericWebServis<PocoDEPO> _tempPocoDepo = new GenericWebServis<PocoDEPO>();
        GenericWebServis<PocoDEPOEMIR> _tempPocoDepoEmir = new GenericWebServis<PocoDEPOEMIR>();
        GenericWebServis<PocoDEPOTRANSFER> _tempPocoDepoTransfer = new GenericWebServis<PocoDEPOTRANSFER>();
        GenericWebServis<PocoDEPOTRANSFERHAR> _tempPocoDepoTransferHar = new GenericWebServis<PocoDEPOTRANSFERHAR>();
        GenericWebServis<PocoSTOKMALKABULLIST> _tempPocoStokMalKabulList = new GenericWebServis<PocoSTOKMALKABULLIST>();
        GenericWebServis<PocoSTOKSEVKIYATLIST> _tempPocoStokSevkiyatList = new GenericWebServis<PocoSTOKSEVKIYATLIST>();
        GenericWebServis<PocoDEPOCEKILIST> _tempPocoDepoCekiList = new GenericWebServis<PocoDEPOCEKILIST>();
        public DEPOController(ILogger<DEPOController> logger)
        {
            _logger = logger;
        }

        #region DEPO
        [HttpGet]

        public async Task<IActionResult> DepoKart()
        {
            _tempPocoDepo.Data(ServisList.DepoListeServis);

            return View(_tempPocoDepo.obje);
        }

        [HttpGet]
        public IActionResult DepoEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepoEkle(PocoDEPO pModel)
        {

            _tempPocoDepo.Data(ServisList.DepoEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region DEPOEMIR
        [HttpGet]

        public async Task<IActionResult> DepoEmirKart()
        {
            _tempPocoDepoEmir.Data(ServisList.DepoEmirListeServis);

            return View(_tempPocoDepoEmir.obje);
        }

        [HttpGet]
        public IActionResult DepoEmirEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepoEmirEkle(PocoDEPOEMIR pModel)
        {

            _tempPocoDepoEmir.Data(ServisList.DepoEmirEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region DEPOTRANSFER
        [HttpGet]

        public async Task<IActionResult> DepoTransferKart()
        {
            _tempPocoDepoTransfer.Data(ServisList.DepoTransferListeServis);

            return View(_tempPocoDepoTransfer.obje);
        }

        [HttpGet]
        public IActionResult DepoTransferEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepoTransferEkle(PocoDEPOTRANSFER pModel)
        {

            _tempPocoDepoTransfer.Data(ServisList.DepoTransferEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region DEPOTRANSFERHAR
        [HttpGet]

        public async Task<IActionResult> DepoTransferHarKart()
        {
            _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarListeServis);

            return View(_tempPocoDepoTransferHar.obje);
        }

        [HttpGet]
        public IActionResult DepoTransferHarEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepoTransferHarEkle(PocoDEPOTRANSFERHAR pModel)
        {

            _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region STOKMALKABULLIST
        [HttpGet]

        public async Task<IActionResult> StokMalKabulListKart()
        {
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListListeServis);

            return View(_tempPocoStokMalKabulList.obje);
        }

        [HttpGet]
        public IActionResult StokMalKabulListEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokMalKabulListEkle(PocoSTOKMALKABULLIST pModel)
        {

            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region STOKSEVKIYATLIST
        [HttpGet]

        public async Task<IActionResult> StokSevkiyatKart()
        {
            _tempPocoStokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);

            return View(_tempPocoStokSevkiyatList.obje);
        }

        [HttpGet]
        public IActionResult StokSevkiyatListEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StokSevkiyatListEkle(PocoSTOKSEVKIYATLIST pModel)
        {

            _tempPocoStokSevkiyatList.Data(ServisList.StokSevkiyatListEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region DEPOCEKILIST
        [HttpGet]

        public async Task<IActionResult> DepoCekiListKart()
        {
            _tempPocoDepoCekiList.Data(ServisList.DepoCekiListListeServis);

            return View(_tempPocoDepoCekiList.obje);
        }

        [HttpGet]
        public IActionResult DepoCekiListEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepoCekiListEkle(PocoDEPOCEKILIST pModel)
        {

            _tempPocoDepoCekiList.Data(ServisList.DepoCekiListEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion
    }
}
