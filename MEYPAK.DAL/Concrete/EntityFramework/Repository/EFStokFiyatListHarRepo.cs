using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System.Data.Entity;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatListHarRepo : EFBaseRepo<MPSTOKFIYATLISTHAR>, IStokFiyatListHarDal
    {
        MEYPAKContext _context;
        public EFStokFiyatListHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            onYukle();
        }

        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity)
        {
            bool exists = _context.MPSTOKFIYATLIST.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKFIYATLISTHAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPSTOKFIYATLISTHAR.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSTOKFIYATLISTHAR.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }
        public void onYukle()
        {

            var emp = _context.MPSTOKFIYATLISTHAR.ToList();

            //emp = emp.Include("MPSTOK");
            //emp = emp.Include("MPSTOKFIYATLIST");


            foreach (var item in emp)
            {
                _context.Entry(item)
                    .Navigation("MPSTOK")
                    .Load();
                _context.Entry(item)
                   .Navigation("MPSTOKFIYATLIST")
                   .Load();
            }

        }
        public void Sil(int id)
        {
            MPSTOKFIYATLISTHAR deleteStok = _context.MPSTOKFIYATLISTHAR.Where(x => x.ID == id).FirstOrDefault();
            deleteStok.KAYITTIPI = 1;
            _context.MPSTOKFIYATLISTHAR.Update(deleteStok);
            _context.SaveChanges();
        }
    }
}
