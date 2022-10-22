using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokSayimHarRepo : EFBaseRepo<MPSTOKSAYIMHAR>, IStokSayimHarDal
    {
        MEYPAKContext _context;

        public EFStokSayimHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            //   context.MPSTOKSAYIMHAR.Include(x => x.MPSTOK).Load();
            onYukle();

        }

       public void onYukle()
        {

            var emp = _context.MPSTOKSAYIMHAR.ToList();
            EFStokRepo jj = new EFStokRepo(_context);
            EFOlcuBrRepo jj2 = new EFOlcuBrRepo(_context);

            foreach (var item in emp)
            {
                _context.Entry(item)
                    .Navigation("MPSTOK").Load();
                _context.Entry(item)
                  .Navigation("MPOLCUBR").Load();  


            }

        }
        public MPSTOKSAYIMHAR EkleyadaGuncelle(MPSTOKSAYIMHAR entity)
        {
            bool exists = _context.MPSTOKSAYIMHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPSTOKSAYIMHAR.Add(entity);
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
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                PropertyInfo propertyInfo2 = (item.GetType().GetProperty("ID"));
                propertyInfo2.SetValue(item, Convert.ChangeType(0, propertyInfo2.PropertyType), null);
                _context.MPSTOKSAYIMHAR.Add(item);
                _context.SaveChanges();
                _context.ChangeTracker.Clear();
                _context.MPSTOKSAYIMHAR.Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }


        public void Sil(int id)
        {
            MPSTOKSAYIMHAR deleteStokHar = _context.MPSTOKSAYIMHAR.Where(x => x.ID == id).FirstOrDefault();
            deleteStokHar.KAYITTIPI = 1;
            _context.MPSTOKSAYIMHAR.Update(deleteStokHar);
            _context.SaveChanges();
        }

    }
}
