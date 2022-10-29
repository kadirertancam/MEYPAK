using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokSevkiyatListRepo : EFBaseRepo<MPSTOKSEVKİYATLİST>, IStokSevkiyatListDal
    {
        MEYPAKContext _context;
        public EFStokSevkiyatListRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            
        }

        public List<MPSTOKSEVKİYATLİST> PagingList(int skip, int take)
        {
            return _context.MPSTOKSEVKİYATLİST.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }
        public List<MPSTOKSEVKİYATLİST> PagingList(int skip, int take, int requireTotalCount=0)
        {
           return _context.MPSTOKSEVKİYATLİST.Where(x => x.ID > skip && x.KAYITTIPI==0).Take(take).ToList();
        }

        public MPSTOKSEVKİYATLİST EkleyadaGuncelle(MPSTOKSEVKİYATLİST entity)
        { 
            bool exists = _context.MPSTOK.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKSEVKİYATLİST.Add(entity);
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
                _context.MPSTOKSEVKİYATLİST.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                _context.MPSTOKSEVKİYATLİST.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }

 
    }
}
