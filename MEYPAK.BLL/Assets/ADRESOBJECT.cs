using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.Assets
{
    public class ADRESOBJECT
    {
        public class Datum
        {
            public string il_adi { get; set; }
            public string plaka_kodu { get; set; }
            public string alan_kodu { get; set; }
            public string nufus { get; set; }
            public string bolge { get; set; }
            public string yuzolcumu { get; set; }
            public string erkek_nufus_yuzde { get; set; }
            public string erkek_nufus { get; set; }
            public string kadin_nufus_yuzde { get; set; }
            public string kadin_nufus { get; set; }
            public string nufus_yuzdesi_genel { get; set; }
            public List<Ilceler> ilceler { get; set; }
            public string kisa_bilgi { get; set; }
        }

        public class Ilceler
        {
            public string ilce_adi { get; set; }
            public string nufus { get; set; }
            public string erkek_nufus { get; set; }
            public string kadin_nufus { get; set; }
            public string yuzolcumu { get; set; }
        }

        public class Root
        {
            public List<Datum> data { get; set; }
        }
    }
}
