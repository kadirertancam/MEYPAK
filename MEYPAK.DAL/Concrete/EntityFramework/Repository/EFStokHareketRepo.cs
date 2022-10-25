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

        public MPSTOKHAR EkleyadaGuncelle(MPSTOKHAR entity)
        {
            bool exists = _context.MPSTOKHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKHAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                if (item.ESKIID == 0 || item.ESKIID == null)
                {
                    PropertyInfo propertyInfo3 = (item.GetType().GetProperty("ESKIID"));
                    propertyInfo3.SetValue(item, Convert.ChangeType(item.ID, propertyInfo3.PropertyType), null);

                }
                PropertyInfo propertyInfo = (item.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(item, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("ID"));
                propertyInfo.SetValue(item, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSTOKHAR.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOKHAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
        public List<PocoStokHareketListesi> PocoStokHareketListesi(int id)
        {
            var snc = _context.MPSTOKHAR.Where(x => _context.MPSTOK.Where(z => z.ID == id).FirstOrDefault().ID == x.STOKID).Select(x => new PocoStokHareketListesi
            {
                Acıklama = x.ACIKLAMA,
                BelgeNo = x.BELGE_NO,
                HareketTuru = x.HAREKETTURU == 1 ? "Satış" : x.HAREKETTURU == 2 ? "Alış" : x.HAREKETTURU == 5 ? "Muhtelif" : "Muhtelif",
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
        public void Sil(int id)
        {
            MPSTOKHAR deleteStok = _context.MPSTOKHAR.Where(x => x.ID == id).FirstOrDefault();
            deleteStok.KAYITTIPI = 1;
            _context.MPSTOKHAR.Update(deleteStok);
            _context.SaveChanges();
        }

    }
}
