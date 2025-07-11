﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PERSONEL
{
    public class PocoPERSONEL:SUPERPOCOMODEL
    {
       
        public string tc { get; set; } = "";
        public string adi { get; set; } = "";
        public string soyadi { get; set; } = "";
        public string adisoyadi { get; set; } = "";
        public string ilksoyad { get; set; } = "";
        public string resim { get; set; } = "";
        public DateTime dogumtar { get; set; } = Convert.ToDateTime("01/01/1990");
        public string babaadi { get; set; } = "";
        public string anneadi { get; set; } = "";
        public string dogumyeri { get; set; } = "";
        public string medenidurum { get; set; } = "";
        public byte cinsiyet { get; set; } = 0;
        public string telefon { get; set; } = "";
        public string cepno { get; set; } = "";
        public string eposta { get; set; } = "";
        [MaxLength, Column(TypeName = "ntext")]
        public string img { get; set; } = "";
        public int personeldepartmanid { get; set; } =0;
        public int personelgorevid { get; set; } = 0;
        public DateTime isbastar { get; set; } = Convert.ToDateTime("01/01/1990");
        public DateTime isbittar { get; set; } = Convert.ToDateTime("01/01/1990");
        public string sgksicilno { get; set; } = "";
        public string sgk { get; set; } = "";
        public string bagkur { get; set; } = "";
        public string emeklisandigi { get; set; } = "";
        public string g506MADSAN { get; set; } = "";
        public string ogrenimdurumu { get; set; } = "";
        public string mezuniyetyili { get; set; } = "";
        public string mezunbolum { get; set; } = "";
        public string askerlikdurum { get; set; } = "";
        public DateTime askerlikbaslangictar { get; set; } = Convert.ToDateTime("01/01/1990");
        public DateTime askerlikbitistar { get; set; } = Convert.ToDateTime("01/01/1990");
        public string sigortaturkod { get; set; } = "";
        public string yaslilikayligi { get; set; } = "";
        public string istihdamdurumu { get; set; } = "";
        public string meslekkodu { get; set; } = "";
       // public string gorevi { get; set; } = "";
        public string sosyalguvenlikkodu { get; set; } = "";
        
        public string uyruk { get; set; } = "";
       
        public string nufusakayitliil { get; set; } = "";
        public string nufusakayitliilce { get; set; } = "";
        public string nufusakayitlimah { get; set; } = "";
        public string ulke { get; set; } = "";
        public string kangrubu { get; set; } = "";
        public string ciltno { get; set; } = "";
        public string ailesirano { get; set; } = "";
        public string sirano { get; set; } = "";
        public DateTime nufuscuzdanverilistarih { get; set; } = Convert.ToDateTime("01/01/1990");
        public string nufuscuzdanserino { get; set; } = "";
        public string nufuscuzdankayitno { get; set; } = "";
        public string adres { get; set; } = "";
        public string adresmah { get; set; } = "";
        public string adresil { get; set; } = "";
        public string adresilce { get; set; }= "";
        public string adrespostakodu { get; set; } = "";
        public string vergidairesi { get; set; } = "";
        public string vergino { get; set; } = "";
        public byte bedenolcusu { get; set; } = 0;
        public byte pantolonolcusu { get; set; } = 0;
        public byte ayakkabino { get; set; } = 0;
        public int sirketid { get; set; } = 0;
        public int subeid { get; set; } = 0;
        public string notlar { get; set; } = "";
        public int maas { get; set; } = 0;
        public bool aktif { get; set; }
        public string sube { get; set; } = "";
    }
}
