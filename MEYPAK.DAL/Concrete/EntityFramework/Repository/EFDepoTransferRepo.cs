using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoTransferRepo : EFBaseRepo<MPDEPOTRANSFER>, IDepoTransferDal
    {
        MEYPAKContext _context;
        public EFDepoTransferRepo(MEYPAKContext context) : base(context)
        {
            _context=context;
        }

        public MPDEPOTRANSFER EkleyadaGuncelle(MPDEPOTRANSFER entity)
        {
            bool exists = _context.MPDEPOTRANSFER.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                _context.MPDEPOTRANSFER.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            else
            {
                MPDEPOTRANSFER temp = _context.MPDEPOTRANSFER.Where(x => x.ID == entity.ID).FirstOrDefault();
                _context.ChangeTracker.Clear();
                _context.MPDEPOTRANSFER.Update(entity);
                _context.SaveChanges();
                return _context.MPDEPOTRANSFER.Where(x => x.ID == temp.ID).FirstOrDefault(); 
            }
        }

        public List<PocoDepolarArasıTransfer> PocoDepolarArasıTransferListesi()
        {

            var snc = _context.MPDEPOTRANSFER.AsNoTracking().Select(x => new PocoDepolarArasıTransfer
            {
                ID = x.ID,
                CIKTIDEPOAD= (_context.MPDEPO.Where(z=>z.ID == x.CIKTIDEPOID).FirstOrDefault().DEPOADI),
                HEDEFDEPOAD = (_context.MPDEPO.Where(z => z.ID == x.HEDEFDEPOID).FirstOrDefault().DEPOADI),
                GUNCELLEMETARIHI =x.GUNCELLEMETARIHI,
                OLUSTURMATARIHI = x.OLUSTURMATARIHI,
                DONEM=x.DONEM,
                //DURUM = x.DURUM.GetType().GetProperties(System.Reflection.BindingFlags.GetField).ToString()
                //DURUM = Enum.GetName(typeof(SiparisDurum), (Convert.ToInt32(x.DURUM))).ToString()
                //DURUM = SiparisDurum.sevkiyattamamladı.GetType().GetEnumValues().GetValue(Convert.ToInt32(x.DURUM)).ToString()

        }).ToList();
            return snc;
        }
    }
}
