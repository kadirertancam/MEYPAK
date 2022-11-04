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
            return View();
        }

        [HttpGet]
        public object DepoGet(DataSourceLoadOptions loadOptions)
        {
            _tempPocoDepo.Data(ServisList.DepoListeServis);
            return DataSourceLoader.Load(_tempPocoDepo.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> DepoPut(int key, string values)
        { //güncellenecek
            _tempPocoDepo.Data(ServisList.DepoListeServis);
            var employee = _tempPocoDepo.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoDepo.Data(ServisList.DepoEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DepoPost(string values)
        {
            PocoDEPO newPoco = new PocoDEPO();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoDepo.Data(ServisList.DepoEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void DepoDelete(int key)
        {
            string url = ServisList.DepoDeleteByIdServis + "?id=" + key;
            _tempPocoDepo.Data(url, method: HttpMethod.Post);
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
            _tempPocoDepoCekiList.Data(ServisList.DepoCekiListListeServis);
            return DataSourceLoader.Load(_tempPocoDepoCekiList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> DepoCekiListPut(int key, string values)
        { //güncellenecek
            _tempPocoDepoCekiList.Data(ServisList.DepoCekiListListeServis);
            var employee = _tempPocoDepoCekiList.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoDepoCekiList.Data(ServisList.DepoCekiListEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DepoCekiListPost(string values)
        {
            PocoDEPOCEKILIST newPoco = new PocoDEPOCEKILIST();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoDepoCekiList.Data(ServisList.DepoCekiListEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void DepoCekiListDelete(int key)
        {
            string url = ServisList.DepoCekiListDeleteByIdServis + "?id=" + key;
            _tempPocoDepoCekiList.Data(url, method: HttpMethod.Post);
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
            _tempPocoDepoEmir.Data(ServisList.DepoEmirListeServis);
            return DataSourceLoader.Load(_tempPocoDepoEmir.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> DepoEmirPut(int key, string values)
        { //güncellenecek
            _tempPocoDepoEmir.Data(ServisList.DepoEmirListeServis);
            var employee = _tempPocoDepoEmir.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoDepoEmir.Data(ServisList.DepoEmirEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DepoEmirPost(string values)
        {
            PocoDEPOEMIR newPoco = new PocoDEPOEMIR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoDepoEmir.Data(ServisList.DepoEmirEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void DepoEmirDelete(int key)
        {
            string url = ServisList.DepoEmirDeleteByIdServis + "?id=" + key;
            _tempPocoDepoEmir.Data(url, method: HttpMethod.Post);
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
            _tempPocoDepoTransfer.Data(ServisList.DepoTransferListeServis);
            return DataSourceLoader.Load(_tempPocoDepoTransfer.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> DepoTransferPut(int key, string values)
        { //güncellenecek
            _tempPocoDepoTransfer.Data(ServisList.DepoTransferListeServis);
            var employee = _tempPocoDepoTransfer.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoDepoTransfer.Data(ServisList.DepoTransferEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DepoTransferPost(string values)
        {
            PocoDEPOTRANSFER newPoco = new PocoDEPOTRANSFER();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoDepoTransfer.Data(ServisList.DepoTransferEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void DepoTransferDelete(int key)
        {
            string url = ServisList.DepoTransferDeleteByIdServis + "?id=" + key;
            _tempPocoDepoTransfer.Data(url, method: HttpMethod.Post);
        }

        #endregion

        #region DEPOTRANSFERHAR

        [HttpGet]
        public async Task<IActionResult> DepoTransferHarKart()
        {
            return View();
        }

        [HttpGet]
        public object DepoTransferHarGet(DataSourceLoadOptions loadOptions)
        {
            _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarListeServis);
            return DataSourceLoader.Load(_tempPocoDepoTransferHar.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> DepoTransferHarPut(int key, string values)
        { //güncellenecek
            _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarListeServis);
            var employee = _tempPocoDepoTransferHar.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DepoTransferHarPost(string values)
        {
            PocoDEPOTRANSFERHAR newPoco = new PocoDEPOTRANSFERHAR();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void DepoTransferHarDelete(int key)
        {
            string url = ServisList.DepoTransferHarDeleteByIdServis + "?id=" + key;
            _tempPocoDepoTransferHar.Data(url, method: HttpMethod.Post);
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
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListListeServis);
            return DataSourceLoader.Load(_tempPocoStokMalKabulList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokMalKabulPut(int key, string values)
        { //güncellenecek
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListListeServis);
            var employee = _tempPocoStokMalKabulList.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokMalKabulPost(string values)
        {
            PocoSTOKMALKABULLIST newPoco = new PocoSTOKMALKABULLIST();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void StokMalKabulDelete(int key)
        {
            string url = ServisList.StokMalKabulListDeleteByIdServis + "?id=" + key;
            _tempPocoStokMalKabulList.Data(url, method: HttpMethod.Post);
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
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListListeServis);
            return DataSourceLoader.Load(_tempPocoStokMalKabulList.obje.Where(x => x.kayittipi == 0).Reverse().AsEnumerable(), loadOptions);
        }
        [HttpPut]
        public async Task<IActionResult> StokSevkiyatListPut(int key, string values)
        { //güncellenecek
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListListeServis);
            var employee = _tempPocoStokMalKabulList.obje.First(a => a.id == key);
            JsonConvert.PopulateObject(values, employee);
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListEkleServis, employee);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> StokSevkiyatListPost(string values)
        {
            PocoSTOKMALKABULLIST newPoco = new PocoSTOKMALKABULLIST();
            JsonConvert.PopulateObject(values, newPoco);
            _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListEkleServis, newPoco);
            return Ok();
        }
        [HttpDelete]
        public void StokSevkiyatListDelete(int key)
        {
            string url = ServisList.StokMalKabulListDeleteByIdServis + "?id=" + key;
            _tempPocoStokMalKabulList.Data(url, method: HttpMethod.Post);
        }

        #endregion



        #region oldControllers

        #region DEPO
        //[HttpGet]

        //public async Task<IActionResult> DepoListe()
        //{
        //    _tempPocoDepo.Data(ServisList.DepoListeServis);

        //    return View(_tempPocoDepo.obje);
        //}

        //[HttpGet]
        //public IActionResult DepoEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoEkle(PocoDEPO pModel)
        //{

        //    _tempPocoDepo.Data(ServisList.DepoEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult DepoSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoSil(List<PocoDEPO> pModel)
        //{

        //    _tempPocoDepo.Data(ServisList.DepoSilServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        #endregion

        #region DEPOEMIR
        //[HttpGet]

        //public async Task<IActionResult> DepoEmirList()
        //{
        //    _tempPocoDepoEmir.Data(ServisList.DepoEmirListeServis);

        //    return View(_tempPocoDepoEmir.obje);
        //}

        //[HttpGet]
        //public IActionResult DepoEmirEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoEmirEkle(PocoDEPOEMIR pModel)
        //{

        //    _tempPocoDepoEmir.Data(ServisList.DepoEmirEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult DepoEmirSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoEmirSil(List<PocoDEPOEMIR> pModel)
        //{

        //    _tempPocoDepoEmir.Data(ServisList.DepoEmirSilServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        #endregion

        #region DEPOTRANSFER
        //[HttpGet]

        //public async Task<IActionResult> DepoTransferKart()
        //{
        //    _tempPocoDepoTransfer.Data(ServisList.DepoTransferListeServis);

        //    return View(_tempPocoDepoTransfer.obje);
        //}

        //[HttpGet]
        //public IActionResult DepoTransferEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoTransferEkle(PocoDEPOTRANSFER pModel)
        //{

        //    _tempPocoDepoTransfer.Data(ServisList.DepoTransferEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult DepoTransferSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoTransferSil(List<PocoDEPOTRANSFER> pModel)
        //{

        //    _tempPocoDepoTransfer.Data(ServisList.DepoTransferSilServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        #endregion

        #region DEPOTRANSFERHAR
        //[HttpGet]

        //public async Task<IActionResult> DepoTransferHarKart()
        //{
        //    _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarListeServis);

        //    return View(_tempPocoDepoTransferHar.obje);
        //}

        //[HttpGet]
        //public IActionResult DepoTransferHarEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoTransferHarEkle(PocoDEPOTRANSFERHAR pModel)
        //{

        //    _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult DepoTransferHarSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoTransferHarSil(List<PocoDEPOTRANSFERHAR> pModel)
        //{

        //    _tempPocoDepoTransferHar.Data(ServisList.DepoTransferHarSilServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        #endregion

        #region STOKMALKABULLIST
        //[HttpGet]

        //public async Task<IActionResult> StokMalKabulListKart()
        //{
        //    _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListListeServis);

        //    return View(_tempPocoStokMalKabulList.obje);
        //}

        //[HttpGet]
        //public IActionResult StokMalKabulListEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokMalKabulListEkle(PocoSTOKMALKABULLIST pModel)
        //{

        //    _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult StokMalKabulListSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokMalKabulListSil(List<PocoSTOKMALKABULLIST> pModel)
        //{

        //    _tempPocoStokMalKabulList.Data(ServisList.StokMalKabulListSilServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        #endregion

        #region STOKSEVKIYATLIST
        //[HttpGet]

        //public async Task<IActionResult> StokSevkiyatKart()
        //{
        //    _tempPocoStokSevkiyatList.Data(ServisList.StokSevkiyatListListeServis);

        //    return View(_tempPocoStokSevkiyatList.obje);
        //}

        //[HttpGet]
        //public IActionResult StokSevkiyatListEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokSevkiyatListEkle(PocoSTOKSEVKIYATLIST pModel)
        //{

        //    _tempPocoStokSevkiyatList.Data(ServisList.StokSevkiyatListEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult StokSevkiyatListSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> StokSevkiyatListSil(List<PocoSTOKSEVKIYATLIST> pModel)
        //{

        //    _tempPocoStokSevkiyatList.Data(ServisList.StokSevkiyatListSilServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        #endregion

        #region DEPOCEKILIST
        //[HttpGet]

        //public async Task<IActionResult> DepoCekiListKart()
        //{
        //    _tempPocoDepoCekiList.Data(ServisList.DepoCekiListListeServis);

        //    return View(_tempPocoDepoCekiList.obje);
        //}

        //[HttpGet]
        //public IActionResult DepoCekiListEkle()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoCekiListEkle(PocoDEPOCEKILIST pModel)
        //{

        //    _tempPocoDepoCekiList.Data(ServisList.DepoCekiListEkleServis, pModel);

        //    ViewBag.Durum = "Başarıyla eklendi.";
        //    return View();
        //}
        //[HttpGet]
        //public IActionResult DepoCekiListSil()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DepoCekiListSil(List<PocoDEPOCEKILIST> pModel)
        //{

        //    _tempPocoDepoCekiList.Data(ServisList.DepoCekiListEkleServis, modellist: pModel);

        //    ViewBag.Durum = "Başarıyla silindi.";
        //    return View();
        //}
        #endregion
        #endregion
    }
}
