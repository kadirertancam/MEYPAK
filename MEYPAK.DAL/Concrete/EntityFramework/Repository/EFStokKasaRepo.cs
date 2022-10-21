using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokKasaRepo : EFBaseRepo<MPSTOKKASA>, IStokKasaDal
    {
        MEYPAKContext _context;
        public EFStokKasaRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public MPSTOKKASA EkleyadaGuncelle(MPSTOKKASA entity)
        {
            bool exists = _context.MPSTOKKASA.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKKASA.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPSTOKKASA.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSTOKKASA.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
