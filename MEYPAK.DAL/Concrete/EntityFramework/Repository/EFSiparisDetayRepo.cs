using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisDetayRepo : EFBaseRepo<MPSIPARISDETAY>, ISiparisDetayDal
    {
        MEYPAKContext context;
        MPSTOK _tempStok;
        public EFSiparisDetayRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
           
        }

        public List<MPSIPARISDETAY> PagingList(int skip, int take)
        {
            return context.MPSIPARISDETAY.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

    
       
            public List<PocoSiparisKalem> PocoSiparisDetayListesi(int id)
        {
            var snc = context.MPSIPARISDETAY.Where(x => context.MPSIPARISDETAY.Where(z => z.ID == id).FirstOrDefault().ID == x.STOKID).Select(x => new PocoSiparisKalem
            {
                Acıklama = x.ACIKLAMA,
                StokAdı = x.STOKADI,
              //  Birim = x.BIRIMID,

                //Acıklama = x.ACIKLAMA,
                //BelgeNo = x.BELGE_NO,
                //HareketTuru = x.HAREKETTURU == 1 ? "Satış" : x.HAREKETTURU == 2 ? "Alış" : x.HAREKETTURU == 5 ? "Muhtelif" : "Muhtelif",
                //Birim = context.MPOLCUBR.Where(z => z.ID == x.BIRIM).FirstOrDefault().ADI,
                //Giris = x.IO == 1 ? x.MIKTAR : 0,
                //Cikis = x.IO == 0 ? x.MIKTAR : 0,
                //Depo = context.MPDEPO.Where(z => z.ID == x.DEPOID).FirstOrDefault().DEPOADI,
                //NetFiyat = x.NETFIYAT,
                //NetToplam = x.NETTOPLAM,
                //BrutToplam = x.BRUTTOPLAM,
                //Tarih = x.OLUSTURMATARIHI

            }).ToList();
            return snc;

        }
    }
}
