using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee
    {
        public Latte(int discount) : base(discount){}

        public override int Price()
        {
            int Price = 40;
            if (Price * (100 - Discount) < Price - 5)
            {
                throw new Exception();
            }
            return Price * (100 - Discount);
        }

        public override string Strength() => "Weak";

    }
}
