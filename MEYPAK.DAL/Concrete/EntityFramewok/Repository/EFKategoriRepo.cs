using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramewok.Repository
{
    public class EFKategoriRepo : IKategoriDal
    {

        MEYPAKContext context = new MEYPAKContext();
        string hata;
        public Interfaces.Durum Ekle(MPKATEGORI entity)
        {
            context.MPKATEGORI.Add(entity);
            context.SaveChanges();
            return Interfaces.Durum.başarılı;



        }

        public Durum EkleyadaGuncelle(MPKATEGORI entity)
        {
            bool exists = context.MPKATEGORI.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPKATEGORI.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPKATEGORI temp = context.MPKATEGORI.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPKATEGORI.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public List<MPKATEGORI> Getir(string entity)
        {

            return context.MPKATEGORI.Where(x => x.ID.ToString() == entity).ToList();

        }

        public List<MPKATEGORI> Getir(Expression<Func<MPKATEGORI, bool>> predicate)
        {

            return context.MPKATEGORI.Where(predicate).ToList();

        }


        public List<MPKATEGORI> Guncelle(MPKATEGORI entity)
        {
            context.MPKATEGORI.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPKATEGORI> Listele()
        {
            return context.MPKATEGORI.ToList();
        }

        public bool Sil(Expression<Func<MPKATEGORI, bool>> predicate)
        {
            return Sil(context.MPKATEGORI.Where(predicate).ToList());

        }

        public bool Sil(List<MPKATEGORI> entity)
        {
            foreach (var item in entity)
            {
                context.MPKATEGORI.Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
