using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class HKSDepo
    {
        public class Depolar
        {
            public string Adres { get; set; }
            public int BeldeId { get; set; }
            public bool BeldeIdSpecified { get; set; }
            public string DepoAdi { get; set; }
            public bool Halicimi { get; set; }
            public bool HalicimiSpecified { get; set; }
            public int Id { get; set; }
            public bool IdSpecified { get; set; }
            public int IlId { get; set; }
            public bool IlIdSpecified { get; set; }
            public int IlceId { get; set; }
            public bool IlceIdSpecified { get; set; }
        }

        public class Root
        {
            public List<Depolar> Depolar { get; set; }
            public int HataKodu { get; set; }
            public bool HataKoduSpecified { get; set; }
            public object Mesaj { get; set; }
        }


    }
}
