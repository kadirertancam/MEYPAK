using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Entity.PocoModels.PERSONEL
{
    public class PocoPERSONELIZIN:SUPERPOCOMODEL
    {
        public int PERSONELID { get; set; }
        public string IZINTURU { get; set; }
        public string IZINNEDENI { get; set; }
        public int IZINGUN { get; set; }
        public string DEVREDILECEKPERSONEL { get; set; }
        public DateTime IZINBASLANGIC { get; set; }
        public DateTime IZINBITIS { get; set; }
    }
}
