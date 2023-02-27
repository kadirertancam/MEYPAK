using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.Assets
{
    public class CekDurum
    {
        private string x;
        private decimal name;
        private decimal age;
        private decimal title;
        private decimal price;

        public CekDurum(string x,decimal bugun, decimal buhafta, decimal buay, decimal sONRAKİAY)
        {
            this.x = x;
            this.name = bugun;
            this.age = buhafta;
            this.title = buay;
            this.price = sONRAKİAY;
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

        public decimal SONRAKİAY
        {
            get { return price; }
            set { price = value; }
        }
    }
}
