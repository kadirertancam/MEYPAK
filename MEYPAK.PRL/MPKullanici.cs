﻿using MEYPAK.Entity.IdentityModels;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL
{
    public static class MPKullanici
    {
        //Kapsülleme
        public const string  hata = "Bu işlemi yapmak için yetkiniz bulunmamaktadır! Lütfen Yönetinizle iletişime geçin.";
        public static string ID
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).Kullanici.Id;
            }
        } 
      
        public static MPUSER USER
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).Kullanici;
            }
        }
        public static List<string> Roller
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).Roller;
            }
        }
        public static List<PocoFORMYETKI> Yetkiler
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).yetkiListe;
            }
        }
        public static List<PocoFORM> Formlar
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).formListe;
            }
        }
        public static int DEPOID
        {
            get
            {
                return ((Main)Application.OpenForms["Main"]).DEPOID;
            }
        }
        public static PocoFORMYETKI YetkiGetir(string form)
        {
            return  !Roller.Contains("ADMIN")? Yetkiler.Where(x => x.FORMID == Formlar.Where(x => x.FORMADI == form).FirstOrDefault().id).FirstOrDefault(): new PocoFORMYETKI() {EKLE=true,SIL=true,GORUNTULE=true,GUNCELLE=true };
        }
    }
}
