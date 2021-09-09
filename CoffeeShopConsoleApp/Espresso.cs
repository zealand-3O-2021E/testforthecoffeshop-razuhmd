using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Espresso : Coffee, ICoffeeBlend
    {
        private string coffeeBlend;
        public Espresso(string coffeblend)
            :base()
        {
            this.coffeeBlend = coffeblend;
        }

        public Espresso(int discount)
            :base(discount)
        {

        }

        public Espresso()
            :base()
        {

        }

        public string CoffeeBlend()
        {
            return coffeeBlend;
        }

        public override string TypeOfCoffee()
        {
            return "Espresso";
        }

        public override string Strength()
        {
            return "Strong";
        }

    }
}
