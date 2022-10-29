 using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using System.Data.Entity;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatListRepo : EFBaseRepo<MPSTOKFIYATLIST>, IStokFiyatListDal
    {
        MEYPAKContext _context;
        public EFStokFiyatListRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
         
        }

        public List<MPSTOKFIYATLIST> PagingList(int skip, int take)
        {
            return _context.MPSTOKFIYATLIST.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

        public MPSTOKFIYATLIST EkleyadaGuncelle(MPSTOKFIYATLIST entity)
        {
            bool exists = _context.MPSTOKFIYATLIST.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKFIYATLIST.Add(entity);
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
                _context.MPSTOKFIYATLIST.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOKFIYATLIST.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }

        public List<PocoStokFiyatList> PocoStokFiyatListesi()
        {
            var snc = _context.MPSTOKFIYATLIST.AsNoTracking().Select(x => new PocoStokFiyatList
            {
               ID = x.ID,
               Adı= x.FIYATLISTADI,
               BaslangicTarihi= x.BASTAR.ToString("dd/MM/yyyy ddd"),
               BitisTarihi=x.BITTAR.ToString("dd/MM/yyyy ddd")

            }).ToList();
            return snc;
        }
    }
}
