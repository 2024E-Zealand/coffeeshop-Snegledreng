using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount {  get; set; }

        public Coffee(int discount) 
        {
            Discount = discount;
        }
        public abstract int Price();
        public abstract string Strength();
    }
}
