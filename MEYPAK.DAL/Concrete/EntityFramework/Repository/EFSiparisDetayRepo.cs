using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisDetayRepo : EFBaseRepo<MPSIPARISDETAY>, ISiparisDetayDal
    {
        MEYPAKContext context;
        MPSTOK _tempStok;
        public EFSiparisDetayRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

        public Durum EkleyadaGuncelle(MPSIPARISDETAY entity)
        {
            bool exists = context.MPSIPARISDETAY.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSIPARISDETAY.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSIPARISDETAY temp = context.MPSIPARISDETAY.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSIPARISDETAY.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }
        void onYukle()
        {

            var emp = context..ToList();
            foreach (var item in emp)
            {
                context.Entry(item)
                    .Collection(e => e.MPSTOKOLCUBR)
                .Load();
 
            }
        }
            public List<PocoSiparisKalem> PocoSiparisDetayListesi(int id)
        {
            var snc = context.MPSIPARISDETAY.AsNoTracking().Where(x => context.MPSIPARISDETAY.Where(z => z.ID == id).FirstOrDefault().ID == x.STOKID).Select(x => new PocoSiparisKalem
            {
                Acıklama = x.ACIKLAMA,
                StokAdı = x.STOKADI,
              //  Birim = x.BIRIMID,

                //Acıklama = x.ACIKLAMA,
                //BelgeNo = x.BELGE_NO,
                //HareketTuru = x.HAREKETTURU == 1 ? "Satış" : x.HAREKETTURU == 2 ? "Alış" : x.HAREKETTURU == 5 ? "Muhtelif" : "Muhtelif",
                //Birim = context.MPOLCUBR.Where(z => z.ID == x.BIRIM).FirstOrDefault().ADI,
                //Giris = x.IO == 1 ? x.MIKTAR : 0,
                //Cikis = x.IO == 0 ? x.MIKTAR : 0,
                //Depo = context.MPDEPO.Where(z => z.ID == x.DEPOID).FirstOrDefault().DEPOADI,
                //NetFiyat = x.NETFIYAT,
                //NetToplam = x.NETTOPLAM,
                //BrutToplam = x.BRUTTOPLAM,
                //Tarih = x.OLUSTURMATARIHI

            }).ToList();
            return snc;

        }
    }
}
