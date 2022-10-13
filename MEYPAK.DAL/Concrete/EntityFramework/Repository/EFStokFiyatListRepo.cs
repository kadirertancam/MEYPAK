using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using System.Data.Entity;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatListRepo : EFBaseRepo<MPSTOKFIYATLIST>, IStokFiyatListDal
    {
        MEYPAKContext _context;
        public EFStokFiyatListRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            onYukle();
        }
        void onYukle()
        {
            var emp2 = _context.MPSTOK.ToList();
           
            var emp = _context.MPSTOKFIYATLIST.ToList();
            foreach (var item in emp)
            {
                _context.Entry(item)
                    .Collection(e => e.MPSTOKFIYATLISTHAR)
                    .Load();
               

            } 

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
                MPSTOKFIYATLIST temp = _context.MPSTOKFIYATLIST.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
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
