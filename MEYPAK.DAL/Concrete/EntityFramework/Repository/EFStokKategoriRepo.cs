using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokKategoriRepo : EFBaseRepo<MPSTOKKATEGORI>, IStokKategoriDal
    {

        MEYPAKContext _context;
        public EFStokKategoriRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public MPSTOKKATEGORI EkleyadaGuncelle(MPSTOKKATEGORI entity)
        {
            bool exists = _context.MPSTOKKATEGORI.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKKATEGORI.Add(entity);
                _context.SaveChanges();
               return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPSTOKKATEGORI.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSTOKKATEGORI.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }


    }
}
