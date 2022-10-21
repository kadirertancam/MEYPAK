using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokOlcuBrRepo : EFBaseRepo<MPSTOKOLCUBR>, IStokOlcuBrDal
    {
        MEYPAKContext context;

        public EFStokOlcuBrRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
            onYukle();
        }

        void onYukle()
        {
          
            var emp = context.MPSTOKOLCUBR.ToList(); 
            //emp = emp.Include("MPSTOK");
            //emp = emp.Include("MPOLCUBR");
            foreach (var item in emp)
            {
                context.Entry(item)
                    .Navigation("MPSTOK")
                    .Load();
                context.Entry(item)
                    .Navigation("MPOLCUBR")
                    .Load();


            }


        }
        public Durum EkleyadaGuncelle(MPSTOKOLCUBR entity)
        {
            context.MPSTOKOLCUBR.Add(entity);
            context.SaveChanges();
            return Durum.başarılı;
        }

    }
}
