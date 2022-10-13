using AutoMapper;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.IRSALIYE;
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
            //STOK
            CreateMap<MPSTOK, PocoSTOK>().ReverseMap();
            CreateMap<MPSTOKFIYATLIST, PocoSTOKFIYATLIST>().ReverseMap();
            CreateMap<MPSTOKFIYATLISTHAR, PocoSTOKFIYATLISTHAR>().ReverseMap();
            CreateMap<MPSTOKHAR, PocoSTOKHAR>().ReverseMap();
            CreateMap<MPSTOKKASA, PocoSTOKKASA>().ReverseMap();
            CreateMap<MPSTOKKATEGORI, PocoSTOKKATEGORI>().ReverseMap();
            CreateMap<MPSTOKMARKA, PocoSTOKMARKA>().ReverseMap();
            CreateMap<MPSTOKOLCUBR, PocoSTOKOLCUBR>().ReverseMap();
            CreateMap<MPSTOKSAYIM, PocoSTOKSAYIM>().ReverseMap();
            CreateMap<MPSTOKSAYIMHAR, PocoSTOKSAYIMHAR>().ReverseMap();
            CreateMap<MPSTOKSEVKİYATLİST, PocoSTOKSEVKIYATLIST>().ReverseMap();

            //SIPARIS
            CreateMap<MPSIPARIS, PocoSIPARIS>().ReverseMap();
            CreateMap<MPSIPARISSEVKEMRIHAR, PocoSIPARISSEVKEMIRHAR>().ReverseMap();
            CreateMap<MPSIPARISDETAY, PocoSIPARISDETAY>().ReverseMap();

            //PERSONEL
            CreateMap<MPPERSONEL, PocoPERSONEL>().ReverseMap();

            //IRSALIYE
            CreateMap<MPIRSALIYE, PocoIRSALIYE>().ReverseMap();
            CreateMap<MPIRSALIYEDETAY, PocoIRSALIYEDETAY>().ReverseMap();

            //DEPO
            CreateMap<MPDEPO, PocoDEPO>().ReverseMap();
            CreateMap<MPDEPOCEKILIST, PocoDEPOCEKILIST>().ReverseMap();
            CreateMap<MPDEPOEMIR, PocoDEPOEMIR>().ReverseMap();
            CreateMap<MPDEPOTRANSFER, PocoDEPOTRANSFER>().ReverseMap();
            CreateMap<MPDEPOTRANSFERHAR, PocoDEPOTRANSFERHAR>().ReverseMap();

            //ARAC
            CreateMap<MPARACLAR, PocoARACLAR>().ReverseMap();





        }
    }
}
