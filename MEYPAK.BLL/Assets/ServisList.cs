using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.Assets
{
    public static class ServisList
    {
        #region Cookie
        public static string Cookie = "";

        #endregion

        #region PERSONELIZIN
        public const string PersonelAvansListeServis =       "http://78.135.80.41:8080/PERSONELAVANS/Liste";
        public const string PersonelAvansEkleServis =        "http://78.135.80.41:8080/PERSONELAVANS/EkleyadaGuncelle";
        public const string PersonelAvansSilServis =         "http://78.135.80.41:8080/PERSONELAVANS/Sil";
        public const string PersonelAvansGuncelleServis =    "http://78.135.80.41:8080/PERSONELAVANS/Guncelle";
        public const string PersonelAvansDeleteByIdServis =  "http://78.135.80.41:8080/PERSONELAVANS/DeleteById";
        public const string PersonelAvansListeFiltreServis = "http://78.135.80.41:8080/PERSONELAVANS/Liste2?query=";


        #endregion
        #region PERSONELIZIN
        public const string PersonelIzinListeServis = "http://78.135.80.41:8080/PERSONELIZIN/Liste";
        public const string PersonelIzinEkleServis = "http://78.135.80.41:8080/PERSONELIZIN/EkleyadaGuncelle";
        public const string PersonelIzinSilServis = "http://78.135.80.41:8080/PERSONELIZIN/Sil";
        public const string PersonelIzinGuncelleServis = "http://78.135.80.41:8080/PERSONELIZIN/Guncelle";
        public const string PersonelIzinDeleteByIdServis = "http://78.135.80.41:8080/PERSONELIZIN/DeleteById";
        public const string PersonelIzinListeFiltreServis = "http://78.135.80.41:8080/PERSONELIZIN/Liste2?query=";


        #endregion

        #region STOKSARFDETAY
        public const string StokSarfDetayListeServis = "http://78.135.80.41:8080/STOKSARFDETAY/Liste";
        public const string StokSarfDetayEkleServis = "http://78.135.80.41:8080/STOKSARFDETAY/EkleyadaGuncelle";
        public const string StokSarfDetaySilServis = "http://78.135.80.41:8080/STOKSARFDETAY/Sil";
        public const string StokSarfDetayGuncelleServis = "http://78.135.80.41:8080/STOKSARFDETAY/Guncelle";
        public const string StokSarfDetayDeleteByIdServis = "http://78.135.80.41:8080/STOKSARFDETAY/DeleteById";
        public const string StokSarfDetayListeFiltreServis = "http://78.135.80.41:8080/STOKSARFDETAY/Liste2?query=";


        #endregion

        #region STOKSARF
        public const string StokSarfListeServis = "http://78.135.80.41:8080/STOKSARF/Liste";
        public const string StokSarfEkleServis = "http://78.135.80.41:8080/STOKSARF/EkleyadaGuncelle";
        public const string StokSarfSilServis = "http://78.135.80.41:8080/STOKSARF/Sil";
        public const string StokSarfGuncelleServis = "http://78.135.80.41:8080/STOKSARF/Guncelle";
        public const string StokSarfDeleteByIdServis = "http://78.135.80.41:8080/STOKSARF/DeleteById";
        public const string StokSarfListeFiltreServis = "http://78.135.80.41:8080/STOKSARF/Liste2?query=";


        #endregion
        #region Arac
        public const string AracListeServis =    "http://78.135.80.41:8080/ARAC/ARACListe";
        public const string AracEkleServis = "http://78.135.80.41:8080/ARAC/ARACEkleyadaGuncelle";
        public const string AracSilServis = "http://78.135.80.41:8080/ARAC/ARACSil";
        public const string AracGuncelleServis = "http://78.135.80.41:8080/ARAC/ARACGuncelle";
        public const string AracDeleteByIdServis = "http://78.135.80.41:8080/ARAC/DeleteById";
        public const string AracListeFiltreServis = "http://78.135.80.41:8080/ARAC/ARACListe2?query=";
        #endregion

        #region AracRota
        public const string AracRotaListeServis =        "http://78.135.80.41:8080/ARACROTA/ARACROTAListe";
        public const string AracRotaEkleServis =         "http://78.135.80.41:8080/ARACROTA/ARACROTAEkleyadaGuncelle";
        public const string AracRotaSilServis =          "http://78.135.80.41:8080/ARACROTA/ARACROTASil";
        public const string AracRotaGuncelleServis =     "http://78.135.80.41:8080/ARACROTA/ARACROTAGuncelle";
        public const string AracRotaDeleteByIdServis =   "http://78.135.80.41:8080/ARACROTA/DeleteById";
        public const string AracRotaListeFiltreServis =  "http://78.135.80.41:8080/ARACROTA/ARACROTAListe2?query=";
        #endregion

        #region Araclar
        public const string AraclarListeServis = "http://78.135.80.41:8080/ARACLAR/ARACLARListe";
        public const string AraclarEkleServis = "http://78.135.80.41:8080/ARACLAR/ARACLAREkleyadaGuncelle";
        public const string AraclarSilServis = "http://78.135.80.41:8080/ARACLAR/ARACLARSil";
        public const string AraclarGuncelleServis = "http://78.135.80.41:8080/ARACLAR/ARACLARGuncelle";
        public const string AraclarDeleteByIdServis = "http://78.135.80.41:8080/ARACLAR/DeleteById";
        public const string AraclarListeFiltreServis = "http://78.135.80.41:8080/ARACLAR/ARACLARListe2?query=";
        #endregion

        #region AracModel
        public const string AracModelListeServis =        "http://78.135.80.41:8080/ARACMODEL/ARACMODELListe";
        public const string AracModelEkleServis =         "http://78.135.80.41:8080/ARACMODEL/ARACMODELEkleyadaGuncelle";
        public const string AracModelSilServis =          "http://78.135.80.41:8080/ARACMODEL/ARACMODELSil";
        public const string AracModelGuncelleServis =     "http://78.135.80.41:8080/ARACMODEL/ARACMODELGuncelle";
        public const string AracModelListeFiltreServis =  "http://78.135.80.41:8080/ARACMODEL/ARACMODELListe2?query=";
        public const string AracModelDeleteByIdServis =   "http://78.135.80.41:8080/ARACMODEL/DeleteById";

        #endregion

        #region AracSigortaResim
        public const string AracSigortaResimListeServis = "http://78.135.80.41:8080/ARACSIGORTARESIM/ARACSIGORTARESIMListe";
        public const string AracSigortaResimEkleServis = "http://78.135.80.41:8080/ARACSIGORTARESIM/ARACSIGORTARESIMEkleyadaGuncelle";
        public const string AracSigortaResimSilServis = "http://78.135.80.41:8080/ARACSIGORTARESIM/ARACSIGORTARESIMSil";
        public const string AracSigortaResimGuncelleServis = "http://78.135.80.41:8080/ARACSIGORTARESIM/ARACSIGORTARESIMGuncelle";
        public const string AracSigortaResimListeFiltreServis = "http://78.135.80.41:8080/ARACSIGORTARESIM/ARACSIGORTARESIMListe2?query=";
        public const string AracSigortaResimDeleteByIdServis = "http://78.135.80.41:8080/ARACSIGORTARESIM/DeleteById";

        #endregion

        #region AracRuhsatResim
        public const string AracRuhsatResimListeServis = "http://78.135.80.41:8080/ARACRUHSATRESIM/ARACRUHSATRESIMListe";
        public const string AracRuhsatResimEkleServis = "http://78.135.80.41:8080/ARACRUHSATRESIM/ARACRUHSATRESIMEkleyadaGuncelle";
        public const string AracRuhsatResimSilServis = "http://78.135.80.41:8080/ARACRUHSATRESIM/ARACRUHSATRESIMSil";
        public const string AracRuhsatResimGuncelleServis = "http://78.135.80.41:8080/ARACRUHSATRESIM/ARACRUHSATRESIMGuncelle";
        public const string AracRuhsatResimListeFiltreServis = "http://78.135.80.41:8080/ARACRUHSATRESIM/ARACRUHSATRESIMListe2?query=";
        public const string AracRuhsatResimDeleteByIdServis = "http://78.135.80.41:8080/ARACRUHSATRESIM/DeleteById";

        #endregion

        #region AracKaskoResim
        public const string AracKaskoResimListeServis = "http://78.135.80.41:8080/ARACKASKORESIM/ARACKASKORESIMListe";
        public const string AracKaskoResimEkleServis = "http://78.135.80.41:8080/ARACKASKORESIM/ARACKASKORESIMEkleyadaGuncelle";
        public const string AracKaskoResimSilServis = "http://78.135.80.41:8080/ARACKASKORESIM/ARACKASKORESIMSil";
        public const string AracKaskoResimGuncelleServis = "http://78.135.80.41:8080/ARACKASKORESIM/ARACKASKORESIMGuncelle";
        public const string AracKaskoResimListeFiltreServis = "http://78.135.80.41:8080/ARACKASKORESIM/ARACKASKORESIMListe2?query=";
        public const string AracKaskoResimDeleteByIdServis = "http://78.135.80.41:8080/ARACKASKORESIM/DeleteById";

        #endregion

        #region AracResim
        public const string AracResimListeServis = "http://78.135.80.41:8080/ARACRESIM/ARACRESIMListe";
        public const string AracResimEkleServis = "http://78.135.80.41:8080/ARACRESIM/ARACRESIMEkleyadaGuncelle";
        public const string AracResimSilServis = "http://78.135.80.41:8080/ARACRESIM/ARACRESIMSil";
        public const string AracResimGuncelleServis = "http://78.135.80.41:8080/ARACRESIM/ARACRESIMGuncelle";
        public const string AracResimListeFiltreServis = "http://78.135.80.41:8080/ARACRESIM/ARACRESIMListe2?query=";
        public const string AracResimDeleteByIdServis = "http://78.135.80.41:8080/ARACRESIM/DeleteById";

        #endregion

        #region AdresList


        public const string AdresListServis = "http://78.135.80.41:8080/ADRESLIST/ADRESLISTListe";

        #endregion

        #region HesapHar
        public const string HesapHarListeServis = "http://78.135.80.41:8080/HESAPHAR/HESAPHARListe";
        public const string HesapHarEkleServis = "http://78.135.80.41:8080/HESAPHAR/HESAPHAREkleyadaGuncelle";
        public const string HesapHarSilServis = "http://78.135.80.41:8080/HESAPHAR/HESAPHARSil";
        public const string HesapHarGuncelleServis = "http://78.135.80.41:8080/HESAPHAR/HESAPHARGuncelle";
        public const string HesapHarDeleteByIdServis = "http://78.135.80.41:8080/HESAPHAR/DeleteById";
        public const string HesapHarFiltreServis = "http://78.135.80.41:8080/HESAPHAR/HESAPHARListe2?query=";
        #endregion

        #region Banka
        public const string BANKAListeServis = "http://78.135.80.41:8080/BANKA/BANKAListe";
        public const string BANKAEkleServis = "http://78.135.80.41:8080/BANKA/BANKAEkleyadaGuncelle";
        public const string BANKASilServis = "http://78.135.80.41:8080/BANKA/BANKASil";
        public const string BANKAGuncelleServis = "http://78.135.80.41:8080/BANKA/BANKAGuncelle";
        public const string BANKADeleteByIdServis = "http://78.135.80.41:8080/BANKA/DeleteById";
        public const string BANKAFiltreServis = "http://78.135.80.41:8080/BANKA/BANKAListe2?query=";
        #endregion

        #region KrediKart
        public const string KrediKartListeServis =       "http://78.135.80.41:8080/KREDIKART/Liste";
        public const string KrediKartEkleServis =        "http://78.135.80.41:8080/KREDIKART/EkleyadaGuncelle";
        public const string KrediKartSilServis =         "http://78.135.80.41:8080/KREDIKART/Sil";
        public const string KrediKartGuncelleServis =    "http://78.135.80.41:8080/KREDIKART/Guncelle";
        public const string KrediKartDeleteByIdServis =  "http://78.135.80.41:8080/KREDIKART/DeleteById";
        public const string KrediKartFiltreServis =      "http://78.135.80.41:8080/KREDIKART/Liste2?query=";
        #endregion

        #region BankaHesap
        public const string BANKAHesapListeServis = "http://78.135.80.41:8080/BANKAHESAP/BANKAHESAPListe";
        public const string BANKAHesapEkleServis = "http://78.135.80.41:8080/BANKAHESAP/BANKAHESAPEkleyadaGuncelle";
        public const string BANKAHesapSilServis = "http://78.135.80.41:8080/BANKAHESAP/BANKAHESAPSil";
        public const string BANKAHesapGuncelleServis = "http://78.135.80.41:8080/BANKAHESAP/BANKAHESAPGuncelle";
        public const string BANKAHesapDeleteByIdServis = "http://78.135.80.41:8080/BANKAHESAP/DeleteById";
        public const string BANKAHesapFiltreServis = "http://78.135.80.41:8080/BANKAHESAP/BANKAHESAPListe2?query=";
        #endregion

        #region BankaSube
        public const string BANKASubeListeServis = "http://78.135.80.41:8080/BANKASUBE/BANKASUBEListe";
        public const string BANKASubeEkleServis = "http://78.135.80.41:8080/BANKASUBE/BANKASUBEEkleyadaGuncelle";
        public const string BANKASubeSilServis = "http://78.135.80.41:8080/BANKASUBE/BANKASUBESil";
        public const string BANKASubeGuncelleServis = "http://78.135.80.41:8080/BANKASUBE/BANKASUBEGuncelle";
        public const string BANKASubeDeleteByIdServis = "http://78.135.80.41:8080/BANKASUBE/DeleteById";
        public const string BANKASubeFiltreServis = "http://78.135.80.41:8080/BANKASUBE/BANKASUBEListe2?query=";
        #endregion

        #region Cari

        public const string CariListeServis = "http://78.135.80.41:8080/CARI/CARIListe";
        public const string CariEkleServis = "http://78.135.80.41:8080/CARI/CARIEkleyadaGuncelle";
        public const string CariSilServis = "http://78.135.80.41:8080/CARI/CARISil";
        public const string CariGuncelleServis = "http://78.135.80.41:8080/CARI/CARIGuncelle";
        public const string CariDeleteByIdServis = "http://78.135.80.41:8080/CARI/DeleteById";
        public const string CariFiltreServis = "http://78.135.80.41:8080/CARI/CARIListe2?query=";


        #endregion

        #region CariDokuman
        public const string CariDokumanListeServis = "http://78.135.80.41:8080/CARIDOKUMAN/CARIDOKUMANListe";
        public const string CariDokumanEkleServis = "http://78.135.80.41:8080/CARIDOKUMAN/CARIDOKUMANEkleyadaGuncelle";
        public const string CariDokumanSilServis = "http://78.135.80.41:8080/CARIDOKUMAN/CARIDOKUMANSil";
        public const string CariDokumanGuncelleServis = "http://78.135.80.41:8080/CARIDOKUMAN/CARIDOKUMANGuncelle";
        public const string CariDokumanDeleteByIdServis = "http://78.135.80.41:8080/CARIDOKUMAN/DeleteById";
        public const string CariDokumanFiltreServis = "http://78.135.80.41:8080/CARIDOKUMAN/CARIDOKUMANListe2?query=";
        #endregion

        #region SevkAdres
        public const string SevkAdresListeServis =       "http://78.135.80.41:8080/SEVKADRES/SEVKADRESListe";
        public const string SevkAdresEkleServis =        "http://78.135.80.41:8080/SEVKADRES/SEVKADRESEkleyadaGuncelle";
        public const string SevkAdresSilServis =         "http://78.135.80.41:8080/SEVKADRES/SEVKADRESSil";
        public const string SevkAdresGuncelleServis =    "http://78.135.80.41:8080/SEVKADRES/SEVKADRESGuncelle";
        public const string SevkAdresDeleteByIdServis = "http://78.135.80.41:8080/SEVKADRES/DeleteById";
        public const string SevkAdresFiltreServis = "http://78.135.80.41:8080/SEVKADRES/SEVKADRESListe2?query=";


        #endregion

        #region CariYetkili
        public const string CariYetkiliListeServis = "http://78.135.80.41:8080/CARIYETKILI/CARIYETKILIListe";
        public const string CariYetkiliEkleServis = "http://78.135.80.41:8080/CARIYETKILI/CARIYETKILIEkleyadaGuncelle";
        public const string CariYetkiliSilServis = "http://78.135.80.41:8080/CARIYETKILI/CARIYETKILISil";
        public const string CariYetkiliGuncelleServis = "http://78.135.80.41:8080/CARIYETKILI/CARIYETKILIGuncelle";
        public const string CariYetkiliDeleteByIdServis = "http://78.135.80.41:8080/CARIYETKILI/DeleteById";
        public const string CariYetkiliFiltreServis = "http://78.135.80.41:8080/CARIYETKILI/CARIYETKILIListe2?query=";
        #endregion

        #region CariResim

        public const string CariResimListeServis =      "http://78.135.80.41:8080/CARIRESIM/CARIRESIMListe";
        public const string CariResimEkleServis =       "http://78.135.80.41:8080/CARIRESIM/CARIRESIMEkleyadaGuncelle";
        public const string CariResimSilServis =        "http://78.135.80.41:8080/CARIRESIM/CARIRESIMSil";
        public const string CariResimGuncelleServis =   "http://78.135.80.41:8080/CARIRESIM/CARIRESIMGuncelle";
        public const string CariResimDeleteByIdServis = "http://78.135.80.41:8080/CARIRESIM/DeleteById";
        public const string CariResimFiltreServis = "http://78.135.80.41:8080/CARIRESIM/CARIRESIMListe2?query=";


        #endregion

        #region CariHar

        public const string CariHarListeServis =        "http://78.135.80.41:8080/CARIHAR/CARIHARListe";
        public const string CariHarEkleServis =         "http://78.135.80.41:8080/CARIHAR/CARIHAREkleyadaGuncelle";
        public const string CariHarSilServis =          "http://78.135.80.41:8080/CARIHAR/CARIHARSil";
        public const string CariHarGuncelleServis =     "http://78.135.80.41:8080/CARIHAR/CARIHARGuncelle";
        public const string CariHarFiltreServis = "http://78.135.80.41:8080/ARAC/CARIHARListe2?query=";
        #endregion

        #region Seri
        public const string SeriListeServis =               "http://78.135.80.41:8080/Seri/SERIListe";
        public const string SeriEkleServis =                "http://78.135.80.41:8080/Seri/SERIEkleyadaGuncelle";
        public const string SeriSilServis =                 "http://78.135.80.41:8080/Seri/SERISil";
        public const string SeriGuncelleServis =            "http://78.135.80.41:8080/Seri/SERIGuncelle";
        public const string SeriDeleteByIdServis =          "http://78.135.80.41:8080/Seri/DeleteById";
        #endregion

        #region SatınAlmaMalKabulHar
        public const string SatinAlmaMalKabulHarListeServis =       "http://78.135.80.41:8080/SATINALMAMALKABULEMRIHAR/SATINALMAMALKABULEMRIHARListe";
        public const string SatinAlmaMalKabulHarEkleServis =        "http://78.135.80.41:8080/SATINALMAMALKABULEMRIHAR/SATINALMAMALKABULEMRIHAREkleyadaGuncelle";
        public const string SatinAlmaMalKabulHarSilServis =         "http://78.135.80.41:8080/SATINALMAMALKABULEMRIHAR/SATINALMAMALKABULEMRIHARSil";
        public const string SatinAlmaMalKabulHarGuncelleServis = "http://78.135.80.41:8080/SATINALMAMALKABULEMRIHAR/SATINALMAMALKABULEMRIHARGuncelle";
        public const string SatinAlmaMalKabulHarDeleteByIdServis = "http://78.135.80.41:8080/SATINALMAMALKABULEMRIHAR/DeleteById";
        #endregion

        #region SeriHar
        public const string SeriHarListeServis =        "http://78.135.80.41:8080/SeriHar/SeriHarListe";
        public const string SeriHarEkleServis =         "http://78.135.80.41:8080/SeriHar/SeriHarEkleyadaGuncelle";
        public const string SeriHarSilServis =          "http://78.135.80.41:8080/SeriHar/SeriHarSil";
        public const string SeriHarGuncelleServis =     "http://78.135.80.41:8080/SeriHar/SeriHarGuncelle";
        public const string SeriHarDeleteByIdServis =   "http://78.135.80.41:8080/SeriHar/DeleteById";
        #endregion

        #region StokSevkiyatList
        public const string StokSevkiyatListListeServis =           "http://78.135.80.41:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTListe";
        public const string StokSevkiyatListEkleServis = "http://78.135.80.41:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTEkleyadaGuncelle";
        public const string StokSevkiyatListSilServis =             "http://78.135.80.41:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTSil";
        public const string StokSevkiyatListGuncelleServis =        "http://78.135.80.41:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTGuncelle";
        public const string StokSevkiyatListDeleteByIdServis = "http://78.135.80.41:8080/STOKSEVKIYATLIST/DeleteById";
        #endregion

        #region StokSayimHar
        public const string StokSayimHarListeServis =   "http://78.135.80.41:8080/STOKSAYIMHAR/STOKSAYIMHARListe";
        public const string StokSayimHarEkleServis = "http://78.135.80.41:8080/STOKSAYIMHAR/STOKSAYIMHAREkleyadaGuncelle";
        public const string StokSayimHarSilServis =             "http://78.135.80.41:8080/STOKSAYIMHAR/STOKSAYIMHARSil";
        public const string StokSayimHarGuncelleServis = "http://78.135.80.41:8080/STOKSAYIMHAR/STOKSAYIMHARGuncelle";
        public const string StokSayimHarDeleteByIdServis = "http://78.135.80.41:8080/STOKSAYIMHAR/DeleteById";

        #endregion

        #region StokSayim
        public const string StokSayimListeServis =    "http://78.135.80.41:8080/STOKSAYIM/STOKSAYIMListe";
        public const string StokSayimEkleServis = "http://78.135.80.41:8080/STOKSAYIM/STOKSAYIMEkleyadaGuncelle";
        public const string StokSayimSilServis =              "http://78.135.80.41:8080/STOKSAYIM/STOKSAYIMSil";
        public const string StokSayimGuncelleServis = "http://78.135.80.41:8080/STOKSAYIM/STOKSAYIMGuncelle";
        public const string StokSayimDeleteByIdServis = "http://78.135.80.41:8080/STOKSAYIM/DeleteById";

        #endregion

        #region StokOlcuBr
        public const string StokOlcuBrListeServis =   "http://78.135.80.41:8080/STOKOLCUBR/STOKOLCUBRListe";
        public const string StokOlcuBrEkleServis = "http://78.135.80.41:8080/STOKOLCUBR/STOKOLCUBREkleyadaGuncelle";
        public const string StokOlcuBrSilServis =             "http://78.135.80.41:8080/STOKOLCUBR/STOKOLCUBRSil";
        public const string StokOlcuBrGuncelleServis = "http://78.135.80.41:8080/STOKOLCUBR/STOKOLCUBRGuncelle";
        public const string StokOlcuBrDeleteByIdServis = "http://78.135.80.41:8080/STOKOLCUBR/DeleteById";

        #endregion

        #region StokMarka
        public const string StokMarkaListeServis =     "http://78.135.80.41:8080/STOKMARKA/STOKMARKAListe";
        public const string StokMarkaEkleServis = "http://78.135.80.41:8080/STOKMARKA/STOKMARKAEkleyadaGuncelle";
        public const string StokMarkaSilServis =               "http://78.135.80.41:8080/STOKMARKA/STOKMARKASil";
        public const string StokMarkaGuncelleServis = "http://78.135.80.41:8080/STOKMARKA/STOKMARKAGuncelle";
        public const string StokMarkaDeleteByIdServis = "http://78.135.80.41:8080/STOKMARKA/DeleteById";

        #endregion

        #region StokMalKabulList
        public const string StokMalKabulListListeServis = "http://78.135.80.41:8080/STOKMALKABULLIST/STOKMALKABULLISTListe";
        public const string StokMalKabulListEkleServis = "http://78.135.80.41:8080/STOKMALKABULLIST/STOKMALKABULLISTEkleyadaGuncelle";
        public const string StokMalKabulListSilServis = "http://78.135.80.41:8080/STOKMALKABULLIST/STOKMALKABULLISTSil";
        public const string StokMalKabulListGuncelleServis = "http://78.135.80.41:8080/STOKMALKABULLIST/STOKMALKABULLISTGuncelle";
        public const string StokMalKabulListDeleteByIdServis = "http://78.135.80.41:8080/STOKMALKABULLIST/DeleteById";

        #endregion

        #region StokKategori
        public const string StokKategoriListeServis =   "http://78.135.80.41:8080/STOKKATEGORI/STOKKATEGORIListe";
        public const string StokKategoriEkleServis = "http://78.135.80.41:8080/STOKKATEGORI/STOKKATEGORIEkleyadaGuncelle";
        public const string StokKategoriSilServis =             "http://78.135.80.41:8080/STOKKATEGORI/STOKKATEGORISil";
        public const string StokKategoriGuncelleServis = "http://78.135.80.41:8080/STOKKATEGORI/STOKKATEGORIGuncelle";
        public const string StokKategoriDeleteByIdServis = "http://78.135.80.41:8080/STOKKATEGORI/DeleteById";
        #endregion

        #region StokKasaMarka
        public const string StokKasaMarkaListeServis =          "http://78.135.80.41:8080/STOKKASAMARKA/STOKKASAMARKAListe"; 
        public const string StokKasaMarkaEkleServis =           "http://78.135.80.41:8080/STOKKASAMARKA/STOKKASAMARKAEkleyadaGuncelle"; 
        public const string StokKasaMarkaSilServis =            "http://78.135.80.41:8080/STOKKASAMARKA/STOKKASAMARKASil"; 
        public const string StokKasaMarkaGuncelleServis =       "http://78.135.80.41:8080/STOKKASAMARKA/STOKKASAMARKAGuncelle";
        public const string StokKasaMarkaDeleteByIdServis =     "http://78.135.80.41:8080/STOKKASAMARKA/DeleteById";
        #endregion

        #region StokKasa
        public const string StokKasaListeServis =    "http://78.135.80.41:8080/STOKKASA/STOKKASAListe"; 
        public const string StokKasaEkleServis = "http://78.135.80.41:8080/STOKKASA/STOKKASAEkleyadaGuncelle"; 
        public const string StokKasaSilServis =              "http://78.135.80.41:8080/STOKKASA/STOKKASASil"; 
        public const string StokKasaGuncelleServis = "http://78.135.80.41:8080/STOKKASA/STOKKASAGuncelle";
        public const string StokKasaDeleteByIdServis = "http://78.135.80.41:8080/STOKKASA/DeleteById";
        #endregion

        #region StokHar
        public const string StokHarListeServis =       "http://78.135.80.41:8080/STOKHAR/STOKHARListe";
        public const string StokHarEkleServis =     "http://78.135.80.41:8080/STOKHAR/STOKHAREkleyadaGuncelle";
        public const string StokHarSilServis =               "http://78.135.80.41:8080/STOKHAR/STOKHARSil";
        public const string StokHarGuncelleServis = "http://78.135.80.41:8080/STOKHAR/STOKHARGuncelle";
        public const string StokHarDeleteByIdServis = "http://78.135.80.41:8080/STOKHAR/DeleteById";

        #endregion

        #region StokFiyat
        public const string StokFiyatListeServis =      "http://78.135.80.41:8080/STOKFIYAT/STOKFIYATListe";
        public const string StokFiyatEkleServis =       "http://78.135.80.41:8080/STOKFIYAT/STOKFIYATEkleyadaGuncelle";
        public const string StokFiyatSilServis =        "http://78.135.80.41:8080/STOKFIYAT/STOKFIYATSil";
        public const string StokFiyatGuncelleServis =   "http://78.135.80.41:8080/STOKFIYAT/STOKFIYATGuncelle";
        public const string StokFiyatDeleteByIdServis = "http://78.135.80.41:8080/STOKFIYAT/DeleteById";
        #endregion

        #region StokFiyatHar
        public const string StokFiyatHarListeServis = "http://78.135.80.41:8080/STOKFIYATHAR/STOKFIYATHARListe";
        public const string StokFiyatHarEkleServis = "http://78.135.80.41:8080/STOKFIYATHAR/STOKFIYATHAREkleyadaGuncelle";
        public const string StokFiyatHarSilServis = "http://78.135.80.41:8080/STOKFIYATHAR/STOKFIYATHARSil";
        public const string StokFiyatHarGuncelleServis = "http://78.135.80.41:8080/STOKFIYATHAR/STOKFIYATHARGuncelle";
        public const string StokFiyatHarDeleteByIdServis = "http://78.135.80.41:8080/STOKFIYATHAR/DeleteById";
        #endregion

        #region Stok
        public const string StokListeServis =    "http://78.135.80.41:8080/STOK/StokListe";
        public const string StokEkleServis = "http://78.135.80.41:8080/STOK/STOKEkleyadaGuncelle";
        public const string StokSilServis =              "http://78.135.80.41:8080/STOK/STOKSil";
        public const string StokGuncelleServis = "http://78.135.80.41:8080/STOK/STOKGuncelle";
        public const string StokDeleteByIdServis = "http://78.135.80.41:8080/STOK/DeleteById";

        #endregion

        #region StokResim
        public const string StokResimListeServis =      "http://78.135.80.41:8080/STOKRESIM/STOKRESIMListe";
        public const string StokResimEkleServis =       "http://78.135.80.41:8080/STOKRESIM/STOKRESIMEkleyadaGuncelle";
        public const string StokResimSilServis =        "http://78.135.80.41:8080/STOKRESIM/STOKRESIMSil";
        public const string StokResimGuncelleServis =   "http://78.135.80.41:8080/STOKRESIM/STOKRESIMGuncelle";
        public const string StokResimDeleteByIdServis = "http://78.135.80.41:8080/STOKRESIM/DeleteById";

        #endregion

        #region SiparisSevkEmriHar
        public const string SiparisSevkEmriHarListeServis =     "http://78.135.80.41:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHARListe";
        public const string SiparisSevkEmriHarEkleServis = "http://78.135.80.41:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHAREkleyadaGuncelle";
        public const string SiparisSevkEmriHarSilServis =               "http://78.135.80.41:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHARSil";
        public const string SiparisSevkEmriHarGuncelleServis = "http://78.135.80.41:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHARGuncelle";
        public const string SiparisSevkEmriHarDeleteByIdServis = "http://78.135.80.41:8080/SIPARISSEVKEMRIHAR/DeleteById";

        #endregion

        #region SiparisDetay
        public const string SiparisDetayListeServis =   "http://78.135.80.41:8080/SIPARISDETAY/SIPARISDETAYListe";
        public const string SiparisDetayEkleServis = "http://78.135.80.41:8080/SIPARISDETAY/SIPARISDETAYEkleyadaGuncelle";
        public const string SiparisDetaySilServis =     "http://78.135.80.41:8080/SIPARISDETAY/SIPARISDETAYSil";
        public const string SiparisDetayGuncelleServis ="http://78.135.80.41:8080/SIPARISDETAY/SIPARISDETAYGuncelle";
        public const string SiparisDetayDeleteByIdServis = "http://78.135.80.41:8080/SIPARISDETAY/DeleteById";

        #endregion

        #region Siparis
        public const string SiparisListeServis =    "http://78.135.80.41:8080/SIPARIS/SIPARISListe";
        public const string SiparisEkleServis = "http://78.135.80.41:8080/SIPARIS/SIPARISEkleyadaGuncelle";
        public const string SiparisSilServis =      "http://78.135.80.41:8080/SIPARIS/SIPARISSil";
        public const string SiparisGuncelleServis = "http://78.135.80.41:8080/SIPARIS/SIPARISGuncelle";
        public const string SiparisDeleteByIdServis = "http://78.135.80.41:8080/SIPARIS/DeleteById";

        #endregion

        #region SiparisKasaHareket
        public const string SiparisKasaHarListeServis =         "http://78.135.80.41:8080/SIPARISKASAHAR/SIPARISKASAHARListe";
        public const string SiparisKasaHarEkleServis =          "http://78.135.80.41:8080/SIPARISKASAHAR/SIPARISKASAHAREkleyadaGuncelle";
        public const string SiparisKasaHarSilServis =           "http://78.135.80.41:8080/SIPARISKASAHAR/SIPARISKASAHARSil";
        public const string SiparisKasaHarGuncelleServis =      "http://78.135.80.41:8080/SIPARISKASAHAR/SIPARISKASAHARGuncelle";
        public const string SiparisKasaHarDeleteByIdServis =    "http://78.135.80.41:8080/SIPARISKASAHAR/DeleteById";

        #endregion

        #region Personel
        public const string PersonelListeServis =         "http://78.135.80.41:8080/PERSONEL/PERSONELListe"; 
        public const string PersonelEkleServis = "http://78.135.80.41:8080/PERSONEL/PERSONELEkleyadaGuncelle"; 
        public const string PersonelSilServis =             "http://78.135.80.41:8080/PERSONEL/PERSONELSil"; 
        public const string PersonelGuncelleServis = "http://78.135.80.41:8080/PERSONEL/PERSONELGuncelle";
        public const string PersonelDeleteByIdServis = "http://78.135.80.41:8080/PERSONEL/DeleteById";

        #endregion

        #region PersonelBanka
        public const string PersonelBankaListeServis = "http://78.135.80.41:8080/PERSONELBANKA/PERSONELBANKAListe";
        public const string PersonelBankaEkleServis = "http://78.135.80.41:8080/PERSONELBANKA/PERSONELBANKAEkleyadaGuncelle";
        public const string PersonelBankaSilServis = "http://78.135.80.41:8080/PERSONELBANKA/PERSONELBANKASil";
        public const string PersonelBankaGuncelleServis = "http://78.135.80.41:8080/PERSONELBANKA/PERSONELBANKAGuncelle";
        public const string PersonelBankaDeleteByIdServis = "http://78.135.80.41:8080/PERSONELBANKA/DeleteById";

        #endregion

        #region PersonelGorev
        public const string PersonelGorevListeServis =      "http://78.135.80.41:8080/PERSONELGOREV/PERSONELGOREVListe";
        public const string PersonelGorevEkleServis =       "http://78.135.80.41:8080/PERSONELGOREV/PERSONELGOREVEkleyadaGuncelle";
        public const string PersonelGorevSilServis =        "http://78.135.80.41:8080/PERSONELGOREV/PERSONELGOREVSil";
        public const string PersonelGorevGuncelleServis =   "http://78.135.80.41:8080/PERSONELGOREV/PERSONELGOREVGuncelle";
        public const string PersonelGorevDeleteByIdServis = "http://78.135.80.41:8080/PERSONELGOREV/DeleteById";

        #endregion

        #region PersonelDepartman
        public const string PersonelDepartmanListeServis =      "http://78.135.80.41:8080/PERSONELDEPARTMAN/PERSONELDEPARTMANListe";
        public const string PersonelDepartmanEkleServis =       "http://78.135.80.41:8080/PERSONELDEPARTMAN/PERSONELDEPARTMANEkleyadaGuncelle";
        public const string PersonelDepartmanSilServis =        "http://78.135.80.41:8080/PERSONELDEPARTMAN/PERSONELDEPARTMANSil";
        public const string PersonelDepartmanGuncelleServis =   "http://78.135.80.41:8080/PERSONELDEPARTMAN/PERSONELDEPARTMANGuncelle";
        public const string PersonelDepartmanDeleteByIdServis = "http://78.135.80.41:8080/PERSONELDEPARTMAN/DeleteById";

        #endregion

        #region PersonelZimmet
        public const string PersonelZimmetlListeServis =      "http://78.135.80.41:8080/PERSONELZIMMET/PERSONELZIMMETListe";
        public const string PersonelZimmetlEkleServis =       "http://78.135.80.41:8080/PERSONELZIMMET/PERSONELZIMMETEkleyadaGuncelle";
        public const string PersonelZimmetlSilServis =        "http://78.135.80.41:8080/PERSONELZIMMET/PERSONELZIMMETSil";
        public const string PersonelZimmetlGuncelleServis =   "http://78.135.80.41:8080/PERSONELZIMMET/PERSONELZIMMETGuncelle";
        public const string PersonelZimmetlDeleteByIdServis = "http://78.135.80.41:8080/PERSONELZIMMET/DeleteById";

        #endregion

        #region OlcuBr
        public const string OlcuBrListeServis =      "http://78.135.80.41:8080/OLCUBR/OLCUBRListe";
        public const string OlcuBrEkleServis = "http://78.135.80.41:8080/OLCUBR/OLCUBREkleyadaGuncelle";
        public const string OlcuBrSilServis =               "http://78.135.80.41:8080/OLCUBR/OLCUBRSil";
        public const string OlcuBrGuncelleServis = "http://78.135.80.41:8080/OLCUBR/OLCUBRGuncelle";
        public const string OlcuBrDeleteByIdServis = "http://78.135.80.41:8080/OLCUBR/DeleteById";

        #endregion

        #region Irsaliye
        public const string IrsaliyeListeServis =          "http://78.135.80.41:8080/IRSALIYE/IRSALIYEListe";
        public const string IrsaliyeEkleServis = "http://78.135.80.41:8080/IRSALIYE/IRSALIYEEkleyadaGuncelle";
        public const string IrsaliyeSilServis =                   "http://78.135.80.41:8080/IRSALIYE/IRSALIYESil";
        public const string IrsaliyeGuncelleServis = "http://78.135.80.41:8080/IRSALIYE/IRSALIYEGuncelle";
        public const string IrsaliyeDeleteByIdServis = "http://78.135.80.41:8080/IRSALIYE/DeleteById";
        public const string IrsaliyeFiltreServis = "http://78.135.80.41:8080/IRSALIYE/IRSALIYEListe2?query=";

        #endregion

        #region IrsaliyeDetay
        public const string IrsaliyeDetayListeServis = "http://78.135.80.41:8080/IRSALIYEDETAY/IRSALIYEDETAYListe";
        public const string IrsaliyeDetayEkleServis = "http://78.135.80.41:8080/IRSALIYEDETAY/IRSALIYEDETAYEkleyadaGuncelle";
        public const string IrsaliyeDetaySilServis = "http://78.135.80.41:8080/IRSALIYEDETAY/IRSALIYEDETAYSil";
        public const string IrsaliyeDetayGuncelleServis = "http://78.135.80.41:8080/IRSALIYEDETAY/IRSALIYEDETAYGuncelle";
        public const string IrsaliyeDetayDeleteByIdServis = "http://78.135.80.41:8080/IRSALIYEDETAY/DeleteById";
        public const string IrsaliyeDetayFiltreServis = "http://78.135.80.41:8080/IRSALIYEDETAY/IRSALIYEDETAYListe2?query=";

        #endregion

        #region IrsaliyeKasaHar
        public const string IrsaliyeKasaHarListeServis =        "http://78.135.80.41:8080/IRSALIYEKASAHAR/IRSALIYEKASAHARListe";
        public const string IrsaliyeKasaHarEkleServis =         "http://78.135.80.41:8080/IRSALIYEKASAHAR/IRSALIYEKASAHAREkleyadaGuncelle";
        public const string IrsaliyeKasaHarSilServis =          "http://78.135.80.41:8080/IRSALIYEKASAHAR/IRSALIYEKASAHARSil";
        public const string IrsaliyeKasaHarGuncelleServis =     "http://78.135.80.41:8080/IRSALIYEKASAHAR/IRSALIYEKASAHARGuncelle";
        public const string IrsaliyeKasaHarDeleteByIdServis =   "http://78.135.80.41:8080/IRSALIYEKASAHAR/DeleteById";

        #endregion

        #region Hizmet
        public const string HizmetListeServis =      "http://78.135.80.41:8080/HIZMET/HIZMETListe";
        public const string HizmetEkleServis = "http://78.135.80.41:8080/HIZMET/HIZMETEkleyadaGuncelle";     
        public const string HizmetSilServis =               "http://78.135.80.41:8080/HIZMET/HIZMETSil";     
        public const string HizmetGuncelleServis = "http://78.135.80.41:8080/HIZMET/HIZMETGuncelle";
        public const string HizmetDeleteByIdServis = "http://78.135.80.41:8080/HIZMET/DeleteById";
        #endregion

        #region HizmetHar
        public const string HizmetHarListeServis =      "http://78.135.80.41:8080/HIZMETHAR/Liste";
        public const string HizmetHarEkleServis =       "http://78.135.80.41:8080/HIZMETHAR/EkleyadaGuncelle";
        public const string HizmetHarSilServis =        "http://78.135.80.41:8080/HIZMETHAR/Sil";
        public const string HizmetHarGuncelleServis =   "http://78.135.80.41:8080/HIZMETHAR/Guncelle";
        public const string HizmetHarDeleteByIdServis = "http://78.135.80.41:8080/HIZMETHAR/DeleteById";
        #endregion

        #region DepoTransferHar
        public const string DepoTransferHarListeServis =     "http://78.135.80.41:8080/DEPOTRANSFERHAR/DEPOTRANSFERHARListe"; 
        public const string DepoTransferHarEkleServis = "http://78.135.80.41:8080/DEPOTRANSFERHAR/DEPOTRANSFERHAREkleyadaGuncelle";
        public const string DepoTransferHarSilServis =    "http://78.135.80.41:8080/DEPOTRANSFERHAR/DEPOTRANSFERHARSil";
        public const string DepoTransferHarGuncelleServis = "http://78.135.80.41:8080/DEPOTRANSFERHAR/DEPOTRANSFERHARGuncelle";
        public const string DepoTransferHarDeleteByIdServis = "http://78.135.80.41:8080/DEPOTRANSFERHAR/DeleteById";

        #endregion

        #region DepoTransfer
        public const string DepoTransferListeServis = "http://78.135.80.41:8080/DEPOTRANSFER/DEPOTRANSFERListe";
        public const string DepoTransferEkleServis = "http://78.135.80.41:8080/DEPOTRANSFER/DEPOTRANSFEREkleyadaGuncelle";
        public const string DepoTransferSilServis = "http://78.135.80.41:8080/DEPOTRANSFER/DEPOTRANSFERSil";
        public const string DepoTransferGuncelleServis = "http://78.135.80.41:8080/DEPOTRANSFER/DEPOTRANSFERGuncelle";
        public const string DepoTransferDeleteByIdServis = "http://78.135.80.41:8080/DEPOTRANSFER/DeleteById";
        #endregion

        #region DepoEmir
        public const string DepoEmirListeServis = "http://78.135.80.41:8080/DEPOEMIR/DEPOEMIRListe";
        public const string DepoEmirEkleServis = "http://78.135.80.41:8080/DEPOEMIR/DEPOEMIREkleyadaGuncelle";
        public const string DepoEmirSilServis = "http://78.135.80.41:8080/DEPOEMIR/DEPOEMIRSil";
        public const string DepoEmirGuncelleServis = "http://78.135.80.41:8080/DEPOEMIR/DEPOEMIRGuncelle";
        public const string DepoEmirDeleteByIdServis = "http://78.135.80.41:8080/DEPOEMIR/DeleteById";
        #endregion

        #region DepoCekiList
        public const string DepoCekiListListeServis = "http://78.135.80.41:8080/DEPOCEKILIST/DEPOCEKILISTListe";
        public const string DepoCekiListEkleServis = "http://78.135.80.41:8080/DEPOCEKILIST/DEPOCEKILISTEkleyadaGuncelle";
        public const string DepoCekiListSilServis = "http://78.135.80.41:8080/DEPOCEKILIST/DEPOCEKILISTSil";
        public const string DepoCekiListGuncelleServis = "http://78.135.80.41:8080/DEPOCEKILIST/DEPOCEKILISTGuncelle";
        public const string DepoCekiListDeleteByIdServis = "http://78.135.80.41:8080/DEPOCEKILIST/DeleteById";
        #endregion

        #region  Depo
        public const string DepoListeServis = "http://78.135.80.41:8080/DEPO/DEPOListe";
        public const string DepoEkleServis = "http://78.135.80.41:8080/DEPO/DEPOEkleyadaGuncelle";
        public const string DepoSilServis = "http://78.135.80.41:8080/DEPO/DEPOSil";
        public const string DepoGuncelleServis = "http://78.135.80.41:8080/DEPO/DEPOGuncelle";
        public const string DepoDeleteByIdServis = "http://78.135.80.41:8080/DEPO/DeleteById";

        #endregion

        #region  CariAltHes
        public const string CariAltHesListeServis = "http://78.135.80.41:8080/CARIALTHES/CARIALTHESListe";
        public const string CariAltHesEkleServis = "http://78.135.80.41:8080/CARIALTHES/CARIALTHESEkleyadaGuncelle";
        public const string CariAltHesSilServis = "http://78.135.80.41:8080/CARIALTHES/CARIALTHESSil";
        public const string CariAltHesGuncelleServis = "http://78.135.80.41:8080/CARIALTHES/CARIALTHESGuncelle";
        public const string CariAltHesDeleteByIdServis = "http://78.135.80.41:8080/CARIALTHES/DeleteById";

        #endregion

        #region  ParaBirimi
        
        public const string ParaBirimiListeServis = "http://78.135.80.41:8080/PARABIRIM/PARABIRIMListe";
        public const string ParaBirimiEkleServis = "http://78.135.80.41:8080/PARABIRIM/PARABIRIMEkleyadaGuncelle";
        public const string ParaBirimiSilServis = "http://78.135.80.41:8080/PARABIRIM/PARABIRIMSSil";
        public const string ParaBirimiGuncelleServis = "http://78.135.80.41:8080/PARABIRIM/PARABIRIMGuncelle";
        public const string ParaBirimiDeleteByIdServis = "http://78.135.80.41:8080/PARABIRIM/DeleteById";

        #endregion

        #region HizmetKategori
        public const string HizmetKategoriListeServis = "http://78.135.80.41:8080/HIZMETKATEGORI/HIZMETKATEGORIListe";
        public const string HizmetKategoriEkleServis = "http://78.135.80.41:8080/HIZMETKATEGORI/HIZMETKATEGORIEkleyadaGuncelle";
        public const string HizmetKategoriSilServis = "http://78.135.80.41:8080/HIZMETKATEGORI/HIZMETKATEGORISil";
        public const string HizmetKategoriGuncelleServis = "http://78.135.80.41:8080/HIZMETKATEGORI/HIZMETKATEGORIGuncelle";
        public const string HizmetKategoriDeleteByIdServis = "http://78.135.80.41:8080/HIZMETKATEGORI/DeleteById";
        #endregion

        #region KasaHar
        public const string KasaHarListeServis =       "http://78.135.80.41:8080/KASAHAR/KASAHARListe";
        public const string KasaHarEkleServis =        "http://78.135.80.41:8080/KASAHAR/KASAHAREkleyadaGuncelle";
        public const string KasaHarSilServis =         "http://78.135.80.41:8080/KASAHAR/KASAHARSil";
        public const string KasaHarGuncelleServis =    "http://78.135.80.41:8080/KASAHAR/KASAHARGuncelle";
        public const string KasaHarDeleteByIdServis =  "http://78.135.80.41:8080/KASAHAR/DeleteById";
        #endregion

        #region Kasa
        public const string KasaListeServis = "http://78.135.80.41:8080/KASA/KASAListe";
        public const string KasaEkleServis = "http://78.135.80.41:8080/KASA/KASAEkleyadaGuncelle";
        public const string KasaSilServis = "http://78.135.80.41:8080/KASA/KASASil";
        public const string KasaGuncelleServis = "http://78.135.80.41:8080/KASA/KASAGuncelle";
        public const string KasaDeleteByIdServis = "http://78.135.80.41:8080/KASA/DeleteById";
        #endregion

        #region CARIALTHESCARI
        public const string CariAltHesCariListeServis =            "http://78.135.80.41:8080/CARIALTHESCARI/CARIALTHESCARIListe";
        public const string CariAltHesCariEkleServis =             "http://78.135.80.41:8080/CARIALTHESCARI/CARIALTHESCARIEkleyadaGuncelle";
        public const string CariAltHesCariSilServis =              "http://78.135.80.41:8080/CARIALTHESCARI/CARIALTHESCARISil";
        public const string CariAltHesCariGuncelleServis =         "http://78.135.80.41:8080/CARIALTHESCARI/CARIALTHESCARIGuncelle";
        public const string CariAltHesCariDeleteByIdServis =       "http://78.135.80.41:8080/CARIALTHESCARI/DeleteById";
        #endregion

        #region StokKasaHar
        public const string StokKasaHarListeServis = "http://78.135.80.41:8080/STOKKASAHAR/STOKKASAHARListe";
        public const string StokKasaHarEkleServis = "http://78.135.80.41:8080/STOKKASAHAR/STOKKASAHAREkleyadaGuncelle";
        public const string StokKasaHarSilServis = "http://78.135.80.41:8080/STOKKASAHAR/STOKKASAHARSil";
        public const string StokKasaHarGuncelleServis = "http://78.135.80.41:8080/STOKKASAHAR/STOKKASAHARGuncelle";
        public const string StokKasaHarDeleteByIdServis = "http://78.135.80.41:8080/STOKKASAHAR/DeleteById";
        #endregion

        #region FATURADETAY
        public const string FaturaDetayListeServis =      "http://78.135.80.41:8080/FATURADETAY/FATURADETAYListe";
        public const string FaturaDetayEkleServis =       "http://78.135.80.41:8080/FATURADETAY/FATURADETAYEkleyadaGuncelle";
        public const string FaturaDetaySilServis =        "http://78.135.80.41:8080/FATURADETAY/FATURADETAYSil";
        public const string FaturaDetayGuncelleServis =   "http://78.135.80.41:8080/FATURADETAY/FATURADETAYGuncelle";
        public const string FaturaDetayDeleteByIdServis = "http://78.135.80.41:8080/FATURADETAY/DeleteById";
        public const string FaturaDetayFiltreServis = "http://78.135.80.41:8080/FATURADETAY/FATURADETAYListe2?query=";
        #endregion

        #region FATURA
        public const string FaturaListeServis = "http://78.135.80.41:8080/FATURA/FATURAListe";
        public const string FaturaEkleServis = "http://78.135.80.41:8080/FATURA/FATURAEkleyadaGuncelle";
        public const string FaturaSilServis = "http://78.135.80.41:8080/FATURA/FATURASil";
        public const string FaturaGuncelleServis = "http://78.135.80.41:8080/FATURA/FATURAGuncelle";
        public const string FaturaDeleteByIdServis = "http://78.135.80.41:8080/FATURA/DeleteById";
        public const string FaturaFiltreServis = "http://78.135.80.41:8080/FATURA/FATURAListe2?query=";
        #endregion

        #region USER-IDENTITY
        public const string UserLoginServis =        "http://78.135.80.41:8080/KULLANICI/Login";
        public const string UserLogoutServis =        "http://78.135.80.41:8080/KULLANICI/Logout";
        public const string UserEkleServis =         "http://78.135.80.41:8080/KULLANICI/Register";


        #endregion

        #region CEKSENETUSTSB
        public const string CekSenetUstSBListeServis =       "http://78.135.80.41:8080/CEKSENETUSTSB/Liste";
        public const string CekSenetUstSBEkleServis =        "http://78.135.80.41:8080/CEKSENETUSTSB/EkleyadaGuncelle";
        public const string CekSenetUstSBSilServis =         "http://78.135.80.41:8080/CEKSENETUSTSB/Sil";
        public const string CekSenetUstSBGuncelleServis =    "http://78.135.80.41:8080/CEKSENETUSTSB/Guncelle";
        public const string CekSenetUstSBDeleteByIdServis =  "http://78.135.80.41:8080/CEKSENETUSTSB/DeleteById";
        public const string CekSenetUstSBFiltreServis =      "http://78.135.80.41:8080/CEKSENETUSTSB/Liste2?query=";

        #endregion

        #region FIRMACEKHAR
        public const string FirmaCekHarListeServis = "http://78.135.80.41:8080/FIRMACEKHAR/Liste";
        public const string FirmaCekHarEkleServis = "http://78.135.80.41:8080/FIRMACEKHAR/EkleyadaGuncelle";
        public const string FirmaCekHarSilServis = "http://78.135.80.41:8080/FIRMACEKHAR/Sil";
        public const string FirmaCekHarGuncelleServis = "http://78.135.80.41:8080/FIRMACEKHAR/Guncelle";
        public const string FirmaCekHarDeleteByIdServis = "http://78.135.80.41:8080/FIRMACEKHAR/DeleteById";
        public const string FirmaCekHarFiltreServis = "http://78.135.80.41:8080/FIRMACEKHAR/Liste2?query=";

        #endregion

        #region FIRMACEKNO
        public const string FirmaCekNoListeServis = "http://78.135.80.41:8080/FIRMACEKNO/Liste";
        public const string FirmaCekNoEkleServis = "http://78.135.80.41:8080/FIRMACEKNO/EkleyadaGuncelle";
        public const string FirmaCekNoSilServis = "http://78.135.80.41:8080/FIRMACEKNO/Sil";
        public const string FirmaCekNoGuncelleServis = "http://78.135.80.41:8080/FIRMACEKNO/Guncelle";
        public const string FirmaCekNoDeleteByIdServis = "http://78.135.80.41:8080/FIRMACEKNO/DeleteById";
        public const string FirmaCekNoFiltreServis = "http://78.135.80.41:8080/FIRMACEKNO/Liste2?query=";

        #endregion

        #region FIRMACEKSB
        public const string FirmaCekSBListeServis = "http://78.135.80.41:8080/FIRMACEKSB/Liste";
        public const string FirmaCekSBEkleServis = "http://78.135.80.41:8080/FIRMACEKSB/EkleyadaGuncelle";
        public const string FirmaCekSBSilServis = "http://78.135.80.41:8080/FIRMACEKSB/Sil";
        public const string FirmaCekSBGuncelleServis = "http://78.135.80.41:8080/FIRMACEKSB/Guncelle";
        public const string FirmaCekSBDeleteByIdServis = "http://78.135.80.41:8080/FIRMACEKSB/DeleteById";
        public const string FirmaCekSBFiltreServis = "http://78.135.80.41:8080/FIRMACEKSB/Liste2?query=";

        #endregion

        #region FIRMASENETHAR
        public const string FirmaSenetHarListeServis = "http://78.135.80.41:8080/FIRMASENETHAR/Liste";
        public const string FirmaSenetHarEkleServis = "http://78.135.80.41:8080/FIRMASENETHAR/EkleyadaGuncelle";
        public const string FirmaSenetHarSilServis = "http://78.135.80.41:8080/FIRMASENETHAR/Sil";
        public const string FirmaSenetHarGuncelleServis = "http://78.135.80.41:8080/FIRMASENETHAR/Guncelle";
        public const string FirmaSenetHarDeleteByIdServis = "http://78.135.80.41:8080/FIRMASENETHAR/DeleteById";
        public const string FirmaSenetHarFiltreServis = "http://78.135.80.41:8080/FIRMASENETHAR/Liste2?query=";

        #endregion

        #region FIRMASENETNO
        public const string FirmaSenetNoListeServis = "http://78.135.80.41:8080/FIRMASENETNO/Liste";
        public const string FirmaSenetNoEkleServis = "http://78.135.80.41:8080/FIRMASENETNO/EkleyadaGuncelle";
        public const string FirmaSenetNoSilServis = "http://78.135.80.41:8080/FIRMASENETNO/Sil";
        public const string FirmaSenetNoGuncelleServis = "http://78.135.80.41:8080/FIRMASENETNO/Guncelle";
        public const string FirmaSenetNoDeleteByIdServis = "http://78.135.80.41:8080/FIRMASENETNO/DeleteById";
        public const string FirmaSenetNoFiltreServis = "http://78.135.80.41:8080/FIRMASENETNO/Liste2?query=";

        #endregion

        #region FIRMASENETSB
        public const string FirmaSenetSBListeServis = "http://78.135.80.41:8080/FIRMASENETSB/Liste";
        public const string FirmaSenetSBEkleServis = "http://78.135.80.41:8080/FIRMASENETSB/EkleyadaGuncelle";
        public const string FirmaSenetSBSilServis = "http://78.135.80.41:8080/FIRMASENETSB/Sil";
        public const string FirmaSenetSBGuncelleServis = "http://78.135.80.41:8080/FIRMASENETSB/Guncelle";
        public const string FirmaSenetSBDeleteByIdServis = "http://78.135.80.41:8080/FIRMASENETSB/DeleteById";
        public const string FirmaSenetSBFiltreServis = "http://78.135.80.41:8080/FIRMASENETSB/Liste2?query=";

        #endregion

        #region MUSTERICEKHAR
        public const string MusteriCekHarListeServis = "http://78.135.80.41:8080/MUSTERICEKHAR/Liste";
        public const string MusteriCekHarEkleServis = "http://78.135.80.41:8080/MUSTERICEKHAR/EkleyadaGuncelle";
        public const string MusteriCekHarSilServis = "http://78.135.80.41:8080/MUSTERICEKHAR/Sil";
        public const string MusteriCekHarGuncelleServis = "http://78.135.80.41:8080/MUSTERICEKHAR/Guncelle";
        public const string MusteriCekHarDeleteByIdServis = "http://78.135.80.41:8080/MUSTERICEKHAR/DeleteById";
        public const string MusteriCekHarFiltreServis = "http://78.135.80.41:8080/MUSTERICEKHAR/Liste2?query=";

        #endregion

        #region MUSTERICEKNO
        public const string MusteriCekNoListeServis = "http://78.135.80.41:8080/MUSTERICEKNO/Liste";
        public const string MusteriCekNoEkleServis = "http://78.135.80.41:8080/MUSTERICEKNO/EkleyadaGuncelle";
        public const string MusteriCekNoSilServis = "http://78.135.80.41:8080/MUSTERICEKNO/Sil";
        public const string MusteriCekNoGuncelleServis = "http://78.135.80.41:8080/MUSTERICEKNO/Guncelle";
        public const string MusteriCekNoDeleteByIdServis = "http://78.135.80.41:8080/MUSTERICEKNO/DeleteById";
        public const string MusteriCekNoFiltreServis = "http://78.135.80.41:8080/MUSTERICEKNO/Liste2?query=";

        #endregion

        #region MUSTERICEKSB
        public const string MusteriCekSBListeServis = "http://78.135.80.41:8080/MUSTERICEKSB/Liste";
        public const string MusteriCekSBEkleServis = "http://78.135.80.41:8080/MUSTERICEKSB/EkleyadaGuncelle";
        public const string MusteriCekSBSilServis = "http://78.135.80.41:8080/MUSTERICEKSB/Sil";
        public const string MusteriCekSBGuncelleServis = "http://78.135.80.41:8080/MUSTERICEKSB/Guncelle";
        public const string MusteriCekSBDeleteByIdServis = "http://78.135.80.41:8080/MUSTERICEKSB/DeleteById";
        public const string MusteriCekSBFiltreServis = "http://78.135.80.41:8080/MUSTERICEKSB/Liste2?query=";

        #endregion

        #region MUSTERISENETHAR
        public const string MusteriSenetHarListeServis = "http://78.135.80.41:8080/MUSTERISENETHAR/Liste";
        public const string MusteriSenetHarEkleServis = "http://78.135.80.41:8080/MUSTERISENETHAR/EkleyadaGuncelle";
        public const string MusteriSenetHarSilServis = "http://78.135.80.41:8080/MUSTERISENETHAR/Sil";
        public const string MusteriSenetHarGuncelleServis = "http://78.135.80.41:8080/MUSTERISENETHAR/Guncelle";
        public const string MusteriSenetHarDeleteByIdServis = "http://78.135.80.41:8080/MUSTERISENETHAR/DeleteById";
        public const string MusteriSenetHarFiltreServis = "http://78.135.80.41:8080/MUSTERISENETHAR/Liste2?query=";

        #endregion

        #region MUSTERISENETNO
        public const string MusteriSenetNoListeServis = "http://78.135.80.41:8080/MUSTERISENETNO/Liste";
        public const string MusteriSenetNoEkleServis = "http://78.135.80.41:8080/MUSTERISENETNO/EkleyadaGuncelle";
        public const string MusteriSenetNoSilServis = "http://78.135.80.41:8080/MUSTERISENETNO/Sil";
        public const string MusteriSenetNoGuncelleServis = "http://78.135.80.41:8080/MUSTERISENETNO/Guncelle";
        public const string MusteriSenetNoDeleteByIdServis = "http://78.135.80.41:8080/MUSTERISENETNO/DeleteById";
        public const string MusteriSenetNoFiltreServis = "http://78.135.80.41:8080/MUSTERISENETNO/Liste2?query=";

        #endregion

        #region MUSTERISENETSB
        public const string MusteriSenetSBListeServis = "http://78.135.80.41:8080/MUSTERISENETSB/Liste";
        public const string MusteriSenetSBEkleServis = "http://78.135.80.41:8080/MUSTERISENETSB/EkleyadaGuncelle";
        public const string MusteriSenetSBSilServis = "http://78.135.80.41:8080/MUSTERISENETSB/Sil";
        public const string MusteriSenetSBGuncelleServis = "http://78.135.80.41:8080/MUSTERISENETSB/Guncelle";
        public const string MusteriSenetSBDeleteByIdServis = "http://78.135.80.41:8080/MUSTERISENETSB/DeleteById";
        public const string MusteriSenetSBFiltreServis = "http://78.135.80.41:8080/MUSTERISENETSB/Liste2?query=";

        #endregion

        #region MUSTERICEKSENET
        public const string MusteriCekSenetListeServis =      "http://78.135.80.41:8080/MUSTERICEKSENET/Liste";
        public const string MusteriCekSenetEkleServis =       "http://78.135.80.41:8080/MUSTERICEKSENET/EkleyadaGuncelle";
        public const string MusteriCekSenetSilServis =        "http://78.135.80.41:8080/MUSTERICEKSENET/Sil";
        public const string MusteriCekSenetGuncelleServis =   "http://78.135.80.41:8080/MUSTERICEKSENET/Guncelle";
        public const string MusteriCekSenetDeleteByIdServis = "http://78.135.80.41:8080/MUSTERICEKSENET/DeleteById";
        public const string MusteriCekSenetFiltreServis =     "http://78.135.80.41:8080/MUSTERICEKSENET/Liste2?query=";

        #endregion




    }
}
