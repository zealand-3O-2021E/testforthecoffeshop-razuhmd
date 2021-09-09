using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class FlatWhite : Coffee
    {
        public FlatWhite()
            :base()
        {
        }

        public FlatWhite(int discount) 
            : base(discount)
        {
        }

        public override string Strength()
        {
            return "Medium";
        }

        public override int price()
        {
            return 35 - Discount;
        }

        public override string TypeOfCoffee()
        {
            return "FlatWhite";
        }
    }
}
