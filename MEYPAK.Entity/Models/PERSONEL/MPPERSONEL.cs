
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace MEYPAK.Entity.Models.PERSONEL
{
    public class MPPERSONEL:SUPERMODEL
    {

        public int SIRKETID { get; set; }
        public int SUBEID { get; set; }
        [StringLength(11), Required]
        public string TC { get; set; }
        [StringLength(100)]
        public string ADI { get; set; }
        [StringLength(100)]
        public string SOYADI { get; set; }
        [StringLength(200)]
        public string ADISOYADI => $"{ADI} {SOYADI}";
        [StringLength(50)]
        public DateTime DOGUMTAR { get; set; }
        public byte CINSIYET { get; set; }
        public int PERSONELDEPARTMANID { get; set; } 
        public int PERSONELGOREVID { get; set; } 
        public string SGKSICILNO { get; set; }
        public DateTime ISBASTAR { get; set; }
        public DateTime ISBITTAR { get; set; } 
        public string RESIM { get; set; }

        public string SGK { get; set; }
        public string BAGKUR { get; set; }
        public string EMEKLISANDIGI { get; set; }

        //506.G.20.mad.san
        public string G506MADSAN { get; set; }
        public string OGRENIMDURUMU { get; set; }
        public string MEZUNIYETYILI { get; set; }
        public string MEZUNBOLUM { get; set; }
        public string ASKERLIKDURUM { get; set; }
        public DateTime ASKERLIKBASLANGICTAR { get; set; }
        public DateTime ASKERLIKBITISTAR { get; set; }
        public string SIGORTATURKOD { get; set; }
        public string YASLILIKAYLIGI { get; set; }
        public string ISTIHDAMDURUMU { get; set; }
        public string GOREVKODU { get; set; }
        public string GOREVI { get; set; }
        public string SOSYALGUVENLIKKODU { get; set; }
        public string BABAADI { get; set; }
        public string ANNEADI { get; set; }
        public string DOGUMYERI { get; set; }
        public string MEDENIDURUM { get; set; }
        public string UYRUK { get; set; }
        public string ILKSOYAD { get; set; }
        public string NUFUSAKAYITLIIL { get; set; }
        public string NUFUSAKAYITLIILCE { get; set; }
        public string NUFUSAKAYITLIMAH { get; set; }
        public string ULKE { get; set; }
        public string KANGRUBU { get; set; }
        public string CILTNO { get; set; }
        public string AILESIRANO { get; set; }
        public string SIRANO { get; set; }
        public string NUFUSCUZDANVERILISTARIH { get; set; }
        public string NUFUSCUZDANSERINO { get; set; }
        public string NUFUSCUZDANKAYITNO { get; set; }
        public string ADRES { get; set; }
        public string ADRESMAH { get; set; }
        public string ADRESIL { get; set; }
        public string ADRESILCE { get; set; }
        public string ADRESPOSTAKODU { get; set; }
        public string VERGIDAIRESI { get; set; }
        public string VERGINO { get; set; }
        public string TELEFON { get; set; }
        public string CEPNO { get; set; }
        public string EPOSTA { get; set; }



        public byte BEDENOLCUSU { get; set; }
        public byte PANTOLONOLCUSU { get; set; }
        public byte AYAKKABINO { get; set; }
    }
}
