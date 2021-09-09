using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            return 20 - Discount;
        }

        /// <summary>
        /// for the default constructor , Discount is set to 0
        /// </summary>
        public Coffee()
            :this(0)
        {
        }

        public Coffee(int discount)
        {
            if (discount > 5)
                throw new ArgumentException("Not more than 5 dk in discount");

            if (discount < 0)
                throw new ArgumentException("discount may be between 1 and 5");

            this.Discount = discount;
        }

        /// <summary>
        /// Says how much discount for the coffee
        /// </summary>
        protected int Discount { get; private set; }

        public abstract string Strength();

        /// <summary>
        /// tells which type of coffee the object is
        /// </summary>
        /// <returns>a string with the name of the coffee type e.g. espresso , Latte </returns>
        public abstract string TypeOfCoffee();

        public override string ToString()
        {
            return $"I'm a {this.TypeOfCoffee()}, and my price is {this.price()}, and the strength of me is {this.Strength()}";
        }

    }
}
