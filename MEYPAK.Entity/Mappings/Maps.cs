using AutoMapper;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.CEKSENET;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.Mappings
{
    public class Maps:Profile
    {
        public Maps()
        {
            //FORM-YETKI
            CreateMap<MPFORM, PocoFORM>().ReverseMap();
            CreateMap<MPFORMYETKI, PocoFORMYETKI>().ReverseMap();

            //EISLEMLER
            CreateMap<MPGELENEFATURA, PocoGELENEFATURA>().ReverseMap();
            CreateMap<MPMUKELLEFLISTESI, PocoMUKELLEFLISTESI>().ReverseMap();

            //SARF
            CreateMap<MPSTOKSARF, PocoSTOKSARF>().ReverseMap();
            CreateMap<MPSTOKSARFDETAY, PocoSTOKSARFDETAY>().ReverseMap();

            //CEKSENET
            CreateMap<MPCEKSENETUSTSB, PocoCEKSENETUSTSB>().ReverseMap();

            CreateMap<MPFIRMACEKHAR, PocoFIRMACEKHAR>().ReverseMap();
            CreateMap<MPFIRMACEKNO, PocoFIRMACEKNO>().ReverseMap();
            CreateMap<MPFIRMACEKSB, PocoFIRMACEKSB>().ReverseMap();

            CreateMap<MPFIRMASENETHAR,PocoFIRMASENETHAR>().ReverseMap();
            CreateMap<MPFIRMASENETNO, PocoFIRMASENETNO>().ReverseMap();
            CreateMap<MPFIRMASENETSB, PocoFIRMASENETSB>().ReverseMap();

            CreateMap<MPMUSTERICEKHAR,PocoMUSTERICEKHAR>().ReverseMap();
            CreateMap<MPMUSTERICEKNO, PocoMUSTERICEKNO>().ReverseMap();
            CreateMap<MPMUSTERICEKSB, PocoMUSTERICEKSB>().ReverseMap();

            CreateMap<MPMUSTERISENETHAR,PocoMUSTERISENETHAR>().ReverseMap();
            CreateMap<MPMUSTERISENETNO, PocoMUSTERISENETNO>().ReverseMap();
            CreateMap<MPMUSTERISENETSB, PocoMUSTERISENETSB>().ReverseMap();

            CreateMap<MPMUSTERICEKSENET,PocoMUSTERICEKSENET>().ReverseMap();


            //BANKA
            CreateMap<MPBANKA, PocoBANKA>().ReverseMap();
            CreateMap<MPBANKASUBE, PocoBANKASUBE>().ReverseMap();
            CreateMap<MPBANKAHESAP, PocoBANKAHESAP>().ReverseMap();
            CreateMap<MPHESAPHAREKET, PocoHESAPHAREKET>().ReverseMap();
            CreateMap<MPKREDIKART, PocoKREDIKART>().ReverseMap();
           

            //PARAMETRE

            CreateMap<MPPARABIRIM, PocoPARABIRIM>().ReverseMap();
            CreateMap<MPPERSONELPARAMETRE, PocoPERSONELPARAMETRE>().ReverseMap();
            CreateMap<MPSERIHAR, PocoSERIHAR>().ReverseMap(); 
            CreateMap<MPKASAPARAMS, PocoKASAPARAMS>().ReverseMap();
            //CARI
            CreateMap<ADRESLIST, PocoAdresList>().ReverseMap();
            CreateMap<MPCARIKART, PocoCARIKART>().ReverseMap();
            CreateMap<MPCARIHAR, PocoCARIHAR>().ReverseMap();
            CreateMap<MPCARIALTHES, PocoCARIALTHES>().ReverseMap();
            CreateMap<MPCARIRESIM,PocoCARIRESIM>().ReverseMap();    
            CreateMap<MPSEVKADRES, PocoSEVKADRES>().ReverseMap();
            CreateMap<MPCARIYETKILI, PocoCARIYETKILI>().ReverseMap();
            CreateMap<MPSEVKADRES, MPSEVKADRES>().ReverseMap();
            CreateMap<MPCARIALTHESCARI, PocoCARIALTHESCARI>().ReverseMap();
            CreateMap<MPCARIDOKUMAN, PocoCARIDOKUMAN>().ReverseMap();

            //STOK
            CreateMap<MPSTOKRESIM, PocoSTOKRESIM>().ReverseMap();
            CreateMap<MPSTOK, PocoSTOK>().ReverseMap(); 
            CreateMap<MPSTOKHAR, PocoSTOKHAR>().ReverseMap();
            CreateMap<MPSTOKKASA, PocoSTOKKASA>().ReverseMap();
            CreateMap<MPSTOKKATEGORI, PocoSTOKKATEGORI>().ReverseMap();
            CreateMap<MPSTOKMARKA, PocoSTOKMARKA>().ReverseMap();
            CreateMap<MPSTOKOLCUBR, PocoSTOKOLCUBR>().ReverseMap();
            CreateMap<MPSTOKSAYIM, PocoSTOKSAYIM>().ReverseMap();
            CreateMap<MPSTOKSAYIMHAR, PocoSTOKSAYIMHAR>().ReverseMap();
            CreateMap<MPSTOKSEVKİYATLİST, PocoSTOKSEVKIYATLIST>().ReverseMap();
            CreateMap<MPOLCUBR, PocoOLCUBR>().ReverseMap();
            CreateMap<MPSTOKFIYAT, PocoSTOKFIYAT>().ReverseMap();
            CreateMap<MPSTOKFIYATHAR, PocoSTOKFIYATHAR>().ReverseMap();
           
            //HIZMET
            CreateMap<MPHIZMET, PocoHIZMET>().ReverseMap();
            CreateMap<MPHIZMETHAR, PocoHIZMETHAR>().ReverseMap();
            CreateMap<MPHIZMETKATEGORI, PocoHIZMETKATEGORI>().ReverseMap();
            CreateMap<MPSTOKKASAMARKA,PocoSTOKKASAMARKA>().ReverseMap();

            //SIPARIS
            CreateMap<MPSIPARIS, PocoSIPARIS>().ReverseMap();
            CreateMap<MPSIPARISSEVKEMRIHAR, PocoSIPARISSEVKEMIRHAR>().ReverseMap();
            CreateMap<MPSIPARISDETAY, PocoSIPARISDETAY>().ReverseMap();
            CreateMap<MPSATINALMAMALKABULEMRIHAR,PocoSATINALMAMALKABULEMRIHAR>().ReverseMap();
            CreateMap<MPSIPARISKASAHAR, PocoSIPARISKASAHAR>().ReverseMap();

            //PERSONEL
            CreateMap<MPPERSONEL, PocoPERSONEL>().ReverseMap();
            CreateMap<MPPERSONELBANKA, PocoPERSONELBANKA>().ReverseMap();
            CreateMap<MPPERSONELDEPARTMAN, PocoPERSONELDEPARTMAN>().ReverseMap();
            CreateMap<MPPERSONELGOREV, PocoPERSONELGOREV>().ReverseMap();
            CreateMap<MPPERSONELZIMMET, PocoPERSONELZIMMET>().ReverseMap();
            CreateMap<MPPERSONELIZIN, PocoPERSONELIZIN>().ReverseMap();
            CreateMap<MPPERSONELAVANS, PocoPERSONELAVANS>().ReverseMap();

            //IRSALIYE
            CreateMap<MPIRSALIYE, PocoIRSALIYE>().ReverseMap();
            CreateMap<MPIRSALIYEDETAY, PocoIRSALIYEDETAY>().ReverseMap();

            //DEPO
            CreateMap<MPDEPO, PocoDEPO>().ReverseMap();
            CreateMap<MPDEPOCEKILIST, PocoDEPOCEKILIST>().ReverseMap();
            CreateMap<MPDEPOEMIR, PocoDEPOEMIR>().ReverseMap();
            CreateMap<MPDEPOTRANSFER, PocoDEPOTRANSFER>().ReverseMap();
            CreateMap<MPDEPOTRANSFERHAR, PocoDEPOTRANSFERHAR>().ReverseMap();
            CreateMap<PocoSTOKMALKABULLIST,MPSTOKMALKABULLIST>().ReverseMap();

            //ARAC
            CreateMap<MPARACLAR, PocoARACLAR>().ReverseMap();
            CreateMap<MPARAC, PocoARAC>().ReverseMap();
            CreateMap<MPARACMODEL, PocoARACMODEL>().ReverseMap();
            CreateMap<MPARACRESIM, PocoARACRESIM>().ReverseMap();
            CreateMap<MPARACRUHSATRESIM, PocoARACRUHSATRESIM>().ReverseMap();
            CreateMap<MPARACSIGORTARESIM, PocoARACSIGORTARESIM>().ReverseMap();
            CreateMap<MPARACKASKORESIM, PocoARACKASKORESIM>().ReverseMap();
            CreateMap<MPARACROTA, PocoARACROTA>().ReverseMap();

            //KASA
            CreateMap<MPKASA, PocoKASA>().ReverseMap();
            CreateMap<MPKASAHAR, PocoKASAHAR>().ReverseMap();
            CreateMap<MPSTOKKASAHAR, PocoSTOKKASAHAR>().ReverseMap();

            //FATURA            
            CreateMap<MPFATURA, PocoFATURA>().ReverseMap();
            CreateMap<MPFATURADETAY, PocoFATURADETAY>().ReverseMap();
            CreateMap<MPSERI, PocoSERI>().ReverseMap();




        }
    }
}
