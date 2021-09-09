using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte : Coffee, IMilk
    {
        public Latte()
            :base()
        {
        }

        public Latte(int discount) 
            : base(discount)
        {
        }

        public int MlMilk()
        {
            return 200;
        }

        public override string TypeOfCoffee()
        {
            return "Latte";
        }

        public override int price()
        {
            return 40 - base.Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
