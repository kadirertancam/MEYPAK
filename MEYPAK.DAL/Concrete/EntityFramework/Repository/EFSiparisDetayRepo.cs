using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
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
            //onYukle();
        }

        public MPSIPARISDETAY EkleyadaGuncelle(MPSIPARISDETAY entity)
        {

            context.ChangeTracker.Clear();
            bool exists = context.MPSIPARISDETAY.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSIPARISDETAY.Add(entity);
                context.SaveChanges();
                return entity;
            }
            else
            {
                var item = Getir(x => x.ID == entity.ID).FirstOrDefault();
                if (item.ESKIID == 0 || item.ESKIID == null)
                {
                    PropertyInfo propertyInfo3 = (item.GetType().GetProperty("ESKIID"));
                    propertyInfo3.SetValue(item, Convert.ChangeType(item.ID, propertyInfo3.PropertyType), null);

                }
                PropertyInfo propertyInfo = (item.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(item, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                propertyInfo = (item.GetType().GetProperty("ID"));
                propertyInfo.SetValue(item, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.MPSIPARISDETAY.Add(item);
                context.SaveChanges();
                context.ChangeTracker.Clear();
                propertyInfo = (entity.GetType().GetProperty("GUNCELLEMETARIHI"));
                propertyInfo.SetValue(entity, Convert.ChangeType(DateTime.Now, propertyInfo.PropertyType), null);
                context.MPSIPARISDETAY.Update(entity);
                context.SaveChanges();
                return entity;
            }
        }
        void onYukle()
        {

            var emp = context.MPSIPARISDETAY.ToList();
            foreach (var item in emp)
            {
                context.Entry(item)
                    .Collection(e => e.MPSIPARISSEVKEMRIHAR)
                .Load();
                context.Entry(item)
                  .Collection(e => e.MPIRSALIYESIPARISDETAYILISKI)
              .Load();
                context.Entry(item)
                  .Collection(e => e.MPDEPOEMIRSIPARISKALEMILISKI)
              .Load();
                context.Entry(item)
                .Collection(e => e.MPSTOKMALKABULLIST)
            .Load();
                context.Entry(item)
                .Collection(e => e.MPSTOKSEVKİYATLİST)
            .Load();

            }
        }
            public List<PocoSiparisKalem> PocoSiparisDetayListesi(int id)
        {
            var snc = context.MPSIPARISDETAY.Where(x => context.MPSIPARISDETAY.Where(z => z.ID == id).FirstOrDefault().ID == x.STOKID).Select(x => new PocoSiparisKalem
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
