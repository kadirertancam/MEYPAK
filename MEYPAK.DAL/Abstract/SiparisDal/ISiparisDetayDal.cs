﻿using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.SiparisDal
{
    public interface ISiparisDetayDal:IGeneric<MPSIPARISDETAY>
    {

        public List<MPSIPARISDETAY> PagingList(int skip, int take);

    }
}
