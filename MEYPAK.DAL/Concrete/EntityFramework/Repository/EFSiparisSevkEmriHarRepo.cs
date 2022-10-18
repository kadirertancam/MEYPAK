using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisSevkEmriHarRepo : EFBaseRepo<MPSIPARISSEVKEMRIHAR>, ISiparisSevkEmriHarDal
    {
        MEYPAKContext context;
        public EFSiparisSevkEmriHarRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
            OnYukle();
        }
        public void OnYukle()
        {
            var emp = context.MPSIPARISSEVKEMRIHAR.ToList();
            foreach (var item in emp)
            {
                context.Entry(item)
                  .Navigation("MPSIPARIS").Load();
                context.Entry(item)
                  .Navigation("MPSIPARISDETAY").Load();
                context.Entry(item)
                  .Navigation("MPDEPOEMIR").Load();


            }
        }
    }
}
