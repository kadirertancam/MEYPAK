using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Reflection;

enum HareketTuleri // 1SATIS-2ALIS-3SATISIADE-4ALISIADE-5MUHTELIF-6DAT
{
    Satış = 1,
    Alış = 2,
    SatışIade = 3,
    AlışIade = 4,
    Muhtelif = 5,
    DAT = 6,
}
namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokHareketRepo : EFBaseRepo<MPSTOKHAR>, IStokHarDal
    {
        MEYPAKContext _context;

        public EFStokHareketRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public List<MPSTOKHAR> PagingList(int skip, int take)
        {
            return _context.MPSTOKHAR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

     
        public List<PocoStokHareketListesi> PocoStokHareketListesi(int id)
        {
            var snc = _context.MPSTOKHAR.Where(x => _context.MPSTOK.Where(z => z.ID == id).FirstOrDefault().ID == x.STOKID).Select(x => new PocoStokHareketListesi
            {
                Acıklama = x.ACIKLAMA,
                BelgeNo = x.BELGE_NO,
                HareketTuru = x.HAREKETTURU == 1 ? "Satış Fatura" : x.HAREKETTURU == 2 ? "Alış Fatura" : x.HAREKETTURU == 3 ? "Satış Irsaliye" : x.HAREKETTURU == 4 ? "Alış Irsaliye" : x.HAREKETTURU == 5 ? "Satış Fatura Iade" : x.HAREKETTURU == 6 ? "Alış Fatura Iade" : x.HAREKETTURU == 7 ? "Satış Irsalye Iade" : x.HAREKETTURU == 8 ? "Alış Irsaliye Iade" : x.HAREKETTURU == 9 ? "Muhtelif" : x.HAREKETTURU == 10 ? "DAT" : x.HAREKETTURU == 11 ? "Sayim" : "Muhtelif",
                Birim = _context.MPOLCUBR.Where(z => z.ID == x.BIRIM).FirstOrDefault().ADI,
                Giris = x.IO == 1 ? x.MIKTAR : 0,
                Cikis = x.IO == 0 ? x.MIKTAR : 0,
                Depo = _context.MPDEPO.Where(z => z.ID == x.DEPOID).FirstOrDefault().DEPOADI,
                NetFiyat = x.NETFIYAT,
                NetToplam = x.NETTOPLAM,
                BrutToplam = x.BRUTTOPLAM,
                Tarih = x.OLUSTURMATARIHI

            }).ToList();
            return snc;

        }
     

    }
}
