using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.DEPO;
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
    public class EFADRESLISTREPO :  IAdresListDal
    {
        public EFADRESLISTREPO(MEYPAKContext _context) 
        {
           
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ADRESLIST Ekle(ADRESLIST entity)
        {
            throw new NotImplementedException();
        }

        public List<ADRESLIST> Getir(Expression<Func<ADRESLIST, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Durum Guncelle(ADRESLIST entity, Expression<Func<ADRESLIST, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ADRESLIST Guncelle(ADRESLIST entity)
        {
            throw new NotImplementedException();
        }

        public List<ADRESLIST> Listele()
        {
            throw new NotImplementedException();
        }

        public bool Sil(List<ADRESLIST> entity)
        {
            throw new NotImplementedException();
        }
    }
}
