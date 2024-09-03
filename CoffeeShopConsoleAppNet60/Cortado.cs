using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee
    {
        public Cortado(int discount) : base(discount){}

        public override int Price()
        {
            int Price = 25;
            if (Price * (100 - Discount) < Price - 5)
            {
                throw new Exception();
            }
            return Price * (100 - Discount);
        }
        public override string Strength() => "Medium";
    }
}
