using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets.Kur
{
    public class Currency
    {
        public double BanknoteBuying
        {
            get;
        }

        public double BanknoteSelling
        {
            get;
        }

        public string Code
        {
            get;
        }

        public string CrossRateName
        {
            get;
        }

        public double ForexBuying
        {
            get;
        }

        public double ForexSelling
        {
            get;
        }

        public string Name
        {
            get;
        }

        public Currency(string name, string code, string crossRateName, double forexBuying, double forexSelling, double banknoteBuying, double banknoteSelling)
        {
            this.Name = name;
            this.Code = code;
            this.CrossRateName = crossRateName;
            this.ForexBuying = forexBuying;
            this.ForexSelling = forexSelling;
            this.BanknoteBuying = banknoteBuying;
            this.BanknoteSelling = banknoteSelling;
        }
    }
}