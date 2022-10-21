using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokSevkiyatListRepo : EFBaseRepo<MPSTOKSEVKİYATLİST>,IStokSevkiyatListDal
    {
        MEYPAKContext _context;
        public EFStokSevkiyatListRepo(MEYPAKContext context) : base(context)
        {
            _context=context;
            OnYukle();
        }
    
        public MPSTOKSEVKİYATLİST EkleyadaGuncelle(MPSTOKSEVKİYATLİST entity)
        {
            OnYukle();
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                _context.MPSTOKSEVKİYATLİST.Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                _context.MPSTOKSEVKİYATLİST.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }

        public void OnYukle()
        {
            var emp = _context.MPSTOKSEVKİYATLİST.ToList();
            foreach (var item in emp)
            {
                _context.Entry(item)
                  .Navigation("MPOLCUBR").Load();
                _context.Entry(item)
                  .Navigation("MPSTOK").Load();
                _context.Entry(item)
                  .Navigation("MPSIPARISDETAY").Load();


            }
        }
    }
}
