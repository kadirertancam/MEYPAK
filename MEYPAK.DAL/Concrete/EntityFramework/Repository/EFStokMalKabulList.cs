using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokMalKabulList : EFBaseRepo<MPSTOKMALKABULLIST>,IStokMalKKabulListDal
    {
        MEYPAKContext context;
        public EFStokMalKabulList(MEYPAKContext _context) : base(_context)
        {
            context = _context;
            OnYukle();
        }
        public Durum EkleyadaGuncelle(MPSTOKMALKABULLIST entity)
        {
            OnYukle();
            bool exists = context.MPSTOK.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKMALKABULLIST.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOKSEVKİYATLİST temp = context.MPSTOKSEVKİYATLİST.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKMALKABULLIST.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public void OnYukle()
        {
            var emp = context.MPSTOKSEVKİYATLİST.ToList();
            foreach (var item in emp)
            {
                context.Entry(item)
                  .Navigation("MPOLCUBR").Load();
                context.Entry(item)
                  .Navigation("MPSTOK").Load();
                context.Entry(item)
                  .Navigation("MPSIPARISDETAY").Load();


            }
        }
    }
}
