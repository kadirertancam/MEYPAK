using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.PRL.Assets
{
    public class CekDurum
    {
        private string x;
        private decimal name;
        private decimal age;
        private decimal title;

        public CekDurum(string x,decimal name, decimal age, decimal title)
        {
            this.x = x;
            this.name = name;
            this.age = age;
            this.title = title;
     
        }
        public string X
        {
            get { return x; }
            set { x = value; }
        }
        public decimal BUGÜN
        {
            get { return name; }
            set { name = value; }
        }

        public decimal BUHAFTA
        {
            get { return age; }
            set { age = value; }
        }
        public decimal BUAY
        {
            get { return title; }
            set { title = value; }
        }
    }
}
