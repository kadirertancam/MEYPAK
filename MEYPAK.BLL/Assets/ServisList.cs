using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.Assets
{
    public static class ServisList
    {
        #region Araç
        public const string AracListeServis = "http://213.238.167.117:8080/ARAC/ARACListe?$filter= KAYITTIPI eq 0";
        public const string AracEkleServis = "http://213.238.167.117:8080/ARAC/ARACEkleyadaGuncelle";
        public const string AracSilServis = "http://213.238.167.117:8080/ARAC/ARACSil";
        public const string AracGuncelleServis = "http://213.238.167.117:8080/ARAC/ARACGuncelle";

        #endregion

        #region StokSevkiyatList
        public const string StokSevkiyatListListeServis =           "http://213.238.167.117:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTListe?$filter= KAYITTIPI eq 0";
        public const string StokSevkiyatListEkleServis = "http://213.238.167.117:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTEkleyadaGuncelle";
        public const string StokSevkiyatListSilServis =             "http://213.238.167.117:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTSil";
        public const string StokSevkiyatListGuncelleServis =        "http://213.238.167.117:8080/STOKSEVKIYATLIST/STOKSEVKIYATLISTGuncelle";
        #endregion
         
        #region StokSayimHar
        public const string StokSayimHarListeServis =   "http://213.238.167.117:8080/STOKSAYIMHAR/STOKSAYIMHARListe?$filter= KAYITTIPI eq 0";
        public const string StokSayimHarEkleServis = "http://213.238.167.117:8080/STOKSAYIMHAR/STOKSAYIMHAREkleyadaGuncelle";
        public const string StokSayimHarSilServis =             "http://213.238.167.117:8080/STOKSAYIMHAR/STOKSAYIMHARSil";
        public const string StokSayimHarGuncelleServis = "http://213.238.167.117:8080/STOKSAYIMHAR/STOKSAYIMHARGuncelle";
        #endregion

        #region StokSayim
        public const string StokSayimListeServis =    "http://213.238.167.117:8080/STOKSAYIM/STOKSAYIMListe?$filter= KAYITTIPI eq 0";
        public const string StokSayimEkleServis = "http://213.238.167.117:8080/STOKSAYIM/STOKSAYIMEkleyadaGuncelle";
        public const string StokSayimSilServis =              "http://213.238.167.117:8080/STOKSAYIM/STOKSAYIMSil";
        public const string StokSayimGuncelleServis = "http://213.238.167.117:8080/STOKSAYIM/STOKSAYIMGuncelle";
        #endregion

        #region StokOlcuBr
        public const string StokOlcuBrListeServis =   "http://213.238.167.117:8080/STOKOLCUBR/STOKOLCUBRListe?$filter= KAYITTIPI eq 0";
        public const string StokOlcuBrEkleServis = "http://213.238.167.117:8080/STOKOLCUBR/STOKOLCUBREkleyadaGuncelle";
        public const string StokOlcuBrSilServis =             "http://213.238.167.117:8080/STOKOLCUBR/STOKOLCUBRSil";
        public const string StokOlcuBrGuncelleServis = "http://213.238.167.117:8080/STOKOLCUBR/STOKOLCUBRGuncelle";
        #endregion
         
        #region StokMarka
        public const string StokMarkaListeServis =     "http://213.238.167.117:8080/STOKMARKA/STOKMARKAListe?$filter= KAYITTIPI eq 0";
        public const string StokMarkaEkleServis = "http://213.238.167.117:8080/STOKMARKA/STOKMARKAEkleyadaGuncelle";
        public const string StokMarkaSilServis =               "http://213.238.167.117:8080/STOKMARKA/STOKMARKASil";
        public const string StokMarkaGuncelleServis = "http://213.238.167.117:8080/STOKMARKA/STOKMARKAGuncelle";
        #endregion
         
        #region StokMalKabulList
        public const string StokMalKabulListListeServis = "http://213.238.167.117:8080/STOKMALKABULLIST/STOKMALKABULLISTListe?$filter= KAYITTIPI eq 0";
        public const string StokMalKabulListEkleServis = "http://213.238.167.117:8080/STOKMALKABULLIST/STOKMALKABULLISTEkleyadaGuncelle";
        public const string StokMalKabulListSilServis = "http://213.238.167.117:8080/STOKMALKABULLIST/STOKMALKABULLISTSil";
        public const string StokMalKabulListGuncelleServis = "http://213.238.167.117:8080/STOKMALKABULLIST/STOKMALKABULLISTGuncelle";
        #endregion 
         
        #region StokKategori
        public const string StokKategoriListeServis =   "http://213.238.167.117:8080/STOKKATEGORI/STOKKATEGORIListe?$filter= KAYITTIPI eq 0";
        public const string StokKategoriEkleServis = "http://213.238.167.117:8080/STOKKATEGORI/STOKKATEGORIEkleyadaGuncelle";
        public const string StokKategoriSilServis =             "http://213.238.167.117:8080/STOKKATEGORI/STOKKATEGORISil";
        public const string StokKategoriGuncelleServis = "http://213.238.167.117:8080/STOKKATEGORI/STOKKATEGORIGuncelle";
        #endregion

        #region StokKasa
        public const string StokKasaListeServis =    "http://213.238.167.117:8080/STOKKASA/STOKKASAListe?$filter= KAYITTIPI eq 0"; 
        public const string StokKasaEkleServis = "http://213.238.167.117:8080/STOKKASA/STOKKASAEkleyadaGuncelle"; 
        public const string StokKasaSilServis =              "http://213.238.167.117:8080/STOKKASA/STOKKASASil"; 
        public const string StokKasaGuncelleServis = "http://213.238.167.117:8080/STOKKASA/STOKKASAGuncelle";
        #endregion

        #region StokHar
        public const string StokHarListeServis =       "http://213.238.167.117:8080/STOKHAR/STOKHARListe?$filter= KAYITTIPI eq 0";
        public const string StokHarEkleServis = "http://213.238.167.117:8080/STOKHAR/STOKHAREkleyadaGuncelle";
        public const string StokHarSilServis =               "http://213.238.167.117:8080/STOKHAR/STOKHARSil";
        public const string StokHarGuncelleServis = "http://213.238.167.117:8080/STOKHAR/STOKHARGuncelle";
        #endregion

        #region StokFiyatListHar
        public const string StokFiyatListHarListeServis =    "http://213.238.167.117:8080/STOKFIYATLISTHAR/STOKFIYATLISTHARListe?$filter= KAYITTIPI eq 0"; 
        public const string StokFiyatListHarEkleServis = "http://213.238.167.117:8080/STOKFIYATLISTHAR/STOKFIYATLISTHAREkleyadaGuncelle"; 
        public const string StokFiyatListHarSilServis =              "http://213.238.167.117:8080/STOKFIYATLISTHAR/STOKFIYATLISTHARSil"; 
        public const string StokFiyatListHarGuncelleServis = "http://213.238.167.117:8080/STOKFIYATLISTHAR/STOKFIYATLISTHARGuncelle";
        #endregion

        #region StokFiyatList
        public const string StokFiyatListListeServis =          "http://213.238.167.117:8080/STOKFIYATLIST/STOKFIYATLISTListe?$filter= KAYITTIPI eq 0"; 
        public const string StokFiyatListEkleServis = "http://213.238.167.117:8080/STOKFIYATLIST/STOKFIYATLISTEkleyadaGuncelle"; 
        public const string StokFiyatListSilServis =             "http://213.238.167.117:8080/STOKFIYATLIST/STOKFIYATLISTSil"; 
        public const string StokFiyatListGuncelleServis =   "http://213.238.167.117:8080/STOKFIYATLIST/STOKFIYATLISTGuncelle";
        #endregion

        #region Stok
        public const string StokListeServis =    "http://213.238.167.117:8080/STOK/STOKListe?$filter= KAYITTIPI eq 0";
        public const string StokEkleServis = "http://213.238.167.117:8080/STOK/STOKEkleyadaGuncelle";
        public const string StokSilServis =              "http://213.238.167.117:8080/STOK/STOKSil";
        public const string StokGuncelleServis = "http://213.238.167.117:8080/STOK/STOKGuncelle";
        #endregion

        #region SiparisSevkEmriHar
        public const string SiparisSevkEmriHarListeServis =     "http://213.238.167.117:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHARListe?$filter= KAYITTIPI eq 0";
        public const string SiparisSevkEmriHarEkleServis = "http://213.238.167.117:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHAREkleyadaGuncelle";
        public const string SiparisSevkEmriHarSilServis =               "http://213.238.167.117:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHARSil";
        public const string SiparisSevkEmriHarGuncelleServis = "http://213.238.167.117:8080/SIPARISSEVKEMRIHAR/SIPARISSEVKEMRIHARGuncelle";
        #endregion

        #region SiparisDetay
        public const string SiparisDetayListeServis =   "http://213.238.167.117:8080/SIPARISDETAY/SIPARISDETAYListe?$filter= KAYITTIPI eq 0";
        public const string SiparisDetayEkleServis = "http://213.238.167.117:8080/SIPARISDETAY/SIPARISDETAYEkleyadaGuncelle";
        public const string SiparisDetaySilServis =     "http://213.238.167.117:8080/SIPARISDETAY/SIPARISDETAYSil";
        public const string SiparisDetayGuncelleServis ="http://213.238.167.117:8080/SIPARISDETAY/SIPARISDETAYGuncelle";
        #endregion

        #region Siparis
        public const string SiparisListeServis =    "http://213.238.167.117:8080/SIPARIS/SIPARISListe?$filter= KAYITTIPI eq 0";
        public const string SiparisEkleServis = "http://213.238.167.117:8080/SIPARIS/SIPARISEkleyadaGuncelle";
        public const string SiparisSilServis =      "http://213.238.167.117:8080/SIPARIS/SIPARISSil";
        public const string SiparisGuncelleServis = "http://213.238.167.117:8080/SIPARIS/SIPARISGuncelle";
        #endregion

        #region Personel
        public const string PersonelListeServis =         "http://213.238.167.117:8080/PERSONEL/PERSONELListe?$filter= KAYITTIPI eq 0"; 
        public const string PersonelEkleServis = "http://213.238.167.117:8080/PERSONEL/PERSONELEkleyadaGuncelle"; 
        public const string PersonelSilServis =             "http://213.238.167.117:8080/PERSONEL/PERSONELSil"; 
        public const string PersonelGuncelleServis = "http://213.238.167.117:8080/PERSONEL/PERSONELGuncelle";
        #endregion

        #region OlcuBr
        public const string OlcuBrListeServis =      "http://213.238.167.117:8080/OLCUBR/OLCUBRListe?$filter= KAYITTIPI eq 0";
        public const string OlcuBrEkleServis = "http://213.238.167.117:8080/OLCUBR/OLCUBREkleyadaGuncelle";
        public const string OlcuBrSilServis =               "http://213.238.167.117:8080/OLCUBR/OLCUBRSil";
        public const string OlcuBrGuncelleServis = "http://213.238.167.117:8080/OLCUBR/OLCUBRGuncelle";
        #endregion

        #region Irsaliye
        public const string IrsaliyeListeServis =          "http://213.238.167.117:8080/IRSALIYE/IRSALIYEListe?$filter= KAYITTIPI eq 0";
        public const string IrsaliyeEkleServis = "http://213.238.167.117:8080/IRSALIYE/IRSALIYEEkleyadaGuncelle";
        public const string IrsaliyeSilServis =                   "http://213.238.167.117:8080/IRSALIYE/IRSALIYESil";
        public const string IrsaliyeGuncelleServis = "http://213.238.167.117:8080/IRSALIYE/IRSALIYEGuncelle";
        #endregion

        #region IrsaliyeDetay
        public const string IrsaliyeDetayListeServis = "http://213.238.167.117:8080/IRSALIYE/IRSALIYEDETAYListe?$filter= KAYITTIPI eq 0";
        public const string IrsaliyeDetayEkleServis = "http://213.238.167.117:8080/IRSALIYE/IRSALIYEDETAYEkleyadaGuncelle";
        public const string IrsaliyeDetaySilServis = "http://213.238.167.117:8080/IRSALIYE/IRSALIYEDETAYSil";
        public const string IrsaliyeDetayGuncelleServis = "http://213.238.167.117:8080/IRSALIYE/IRSALIYEDETAYGuncelle";
        #endregion

        #region Hizmet
        public const string HizmetListeServis =      "http://213.238.167.117:8080/HIZMET/HIZMETListe?$filter= KAYITTIPI eq 0";
        public const string HizmetEkleServis = "http://213.238.167.117:8080/HIZMET/HIZMETEkleyadaGuncelle";     
        public const string HizmetSilServis =               "http://213.238.167.117:8080/HIZMET/HIZMETSil";     
        public const string HizmetGuncelleServis = "http://213.238.167.117:8080/HIZMET/HIZMETGuncelle";
        #endregion

        #region DepoTransferHar
        public const string DepoTransferHarListeServis =     "http://213.238.167.117:8080/DEPOTRANSFERHAR/DEPOTRANSFERHARListe?$filter= KAYITTIPI eq 0"; 
        public const string DepoTransferHarEkleServis = "http://213.238.167.117:8080/DEPOTRANSFERHAR/DEPOTRANSFERHAREkleyadaGuncelle";
        public const string DepoTransferHarSilServis =    "http://213.238.167.117:8080/DEPOTRANSFERHAR/DEPOTRANSFERHARSil";
        public const string DepoTransferHarGuncelleServis = "http://213.238.167.117:8080/DEPOTRANSFERHAR/DEPOTRANSFERHARGuncelle";
        #endregion

        #region DepoTransfer
        public const string DepoTransferListeServis = "http://213.238.167.117:8080/DEPOTRANSFER/DEPOTRANSFERListe?$filter= KAYITTIPI eq 0";
        public const string DepoTransferEkleServis = "http://213.238.167.117:8080/DEPOTRANSFER/DEPOTRANSFEREkleyadaGuncelle";
        public const string DepoTransferSilServis = "http://213.238.167.117:8080/DEPOTRANSFER/DEPOTRANSFERSil";
        public const string DepoTransferGuncelleServis = "http://213.238.167.117:8080/DEPOTRANSFER/DEPOTRANSFERGuncelle";
        #endregion
         
        #region DepoEmir
        public const string DepoEmirListeServis = "http://213.238.167.117:8080/DEPOEMIR/DEPOEMIRListe?$filter= KAYITTIPI eq 0";
        public const string DepoEmirEkleServis = "http://213.238.167.117:8080/DEPOEMIR/DEPOEMIREkleyadaGuncelle";
        public const string DepoEmirSilServis = "http://213.238.167.117:8080/DEPOEMIR/DEPOEMIRSil";
        public const string DepoEmirGuncelleServis = "http://213.238.167.117:8080/DEPOEMIR/DEPOEMIRGuncelle";
        #endregion
         
        #region DepoCekiList
        public const string DepoCekiListListeServis = "http://213.238.167.117:8080/DEPOCEKILIST/DEPOCEKILISTListe?$filter= KAYITTIPI eq 0";
        public const string DepoCekiListEkleServis = "http://213.238.167.117:8080/DEPOCEKILIST/DEPOCEKILISTEkleyadaGuncelle";
        public const string DepoCekiListSilServis = "http://213.238.167.117:8080/DEPOCEKILIST/DEPOCEKILISTSil";
        public const string DepoCekiListGuncelleServis = "http://213.238.167.117:8080/DEPOCEKILIST/DEPOCEKILISTGuncelle";
        #endregion

        #region  Depo
        public const string DepoListeServis = "http://213.238.167.117:8080/DEPO/DEPOListe?$filter= KAYITTIPI eq 0";
        public const string DepoEkleServis = "http://213.238.167.117:8080/DEPO/DEPOEkleyadaGuncelle";
        public const string DepoSilServis = "http://213.238.167.117:8080/DEPO/DEPOSil";
        public const string DepoGuncelleServis = "http://213.238.167.117:8080/ARAC/ARACGuncelle";
        #endregion
    }
}
