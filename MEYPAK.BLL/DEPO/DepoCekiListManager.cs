using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    internal class DepoCekiListManager : BaseManager<MPDEPOCEKILIST>, IDepoCekiListServis
    {
        IDepoCekiListDal _depoCekiListDal;
        public DepoCekiListManager(IDepoCekiListDal generic) : base(generic)
        {
            _depoCekiListDal = generic;
        }
    }
}
