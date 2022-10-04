using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;

enum HareketTuleri // 1SATIS-2ALIS-3SATISIADE-4ALISIADE-5MUHTELIF-6DAT
{
    Satış=1,
    Alış=2,
    SatışIade=3,
    AlışIade=4,
    Muhtelif=5,
    DAT=6,
}
namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokHareketRepo : IStokHarDal
    {
        MEYPAKContext context = new MEYPAKContext();
        public Interfaces.Durum Ekle(MPSTOKHAR entity)
        {
            context.MPSTOKHAR.Add(entity);
            return Interfaces.Durum.başarılı;
        }

        public Durum EkleyadaGuncelle(MPSTOKHAR entity)
        {
            bool exists = context.MPSTOKHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKHAR.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOKHAR temp = context.MPSTOKHAR.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKHAR.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
        public List<PocoStokHareketListesi> PocoStokHareketListesi(int id)
        {
            var snc = context.MPSTOKHAR.AsNoTracking().Where(x => context.MPSTOK.Where(z => z.ID == id).FirstOrDefault().ID == x.STOKID).Select(x => new PocoStokHareketListesi
            {
                Acıklama = x.ACIKLAMA,
                BelgeNo = x.BELGE_NO,
                HareketTuru = x.HAREKETTURU == 1 ? "Satış" : x.HAREKETTURU == 2 ? "Alış" : x.HAREKETTURU == 5 ? "Muhtelif" : "Muhtelif",
                Birim = context.MPOLCUBR.Where(z => z.ID == x.BIRIM).FirstOrDefault().ADI,
                Giris = x.IO == 1 ? x.MIKTAR : 0,
                Cikis=x.IO==0 ? x.MIKTAR : 0,
                Depo=context.MPDEPO.Where(z=>z.ID==x.DEPOID).FirstOrDefault().DEPOADI,
                NetFiyat=x.NETFIYAT,
                NetToplam=x.NETTOPLAM,
                BrutToplam = x.BRUTTOPLAM,
                Tarih =x.OLUSTURMATARIHI

            }).ToList();
            return snc;

        }
        public List<MPSTOKHAR> Getir(string entity)
        {
            return context.MPSTOKHAR.ToList();
        }

        public List<MPSTOKHAR> Getir(Expression<Func<MPSTOKHAR, bool>> predicate)
        {
            return context.MPSTOKHAR.Where(predicate).ToList();
        }

        public List<MPSTOKHAR> Guncelle(MPSTOKHAR entity)
        {
            context.MPSTOKHAR.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPSTOKHAR> Listele()
        {
            return context.MPSTOKHAR.ToList();
        }

        public bool Sil(Expression<Func<MPSTOKHAR, bool>> predicate)
        {
            return Sil(context.MPSTOKHAR.Where(predicate).ToList());
        }

        public bool Sil(List<MPSTOKHAR> entity)
        {
            foreach (var item in entity)
            {
                context.MPSTOKHAR.Remove(item);
            }
            return true;
        }
    }
}
