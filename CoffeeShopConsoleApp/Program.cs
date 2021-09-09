using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(3),
                new BlackCoffee(4),
                new Latte(5),
                new Cortado(),
                new BlackCoffee(),
                new Latte(),
                new Espresso("Akmel Espresso")
            };

            Console.WriteLine("Print the elements out in the orderList:");
            foreach (var coffeeItem in orderList)
            {
                //use the override of the ToString() in the Coffee class - look to understand
                Console.WriteLine(coffeeItem.ToString());
            }
            
            Console.WriteLine("press a key to se the OrderListMilk");
            Console.ReadLine();

            // an list that consists of objects that implements the IMilk interface
            var OrderListMilk = new List<IMilk>() {
                new Cortado(3),
                new Latte(5),
                new Cortado(),
                new Latte(),
            };

            foreach (var coffeeItem in OrderListMilk)
            {
                Console.WriteLine($"The amount of milk used is : {coffeeItem.MlMilk()}");
            }
            Console.WriteLine("Hit a key to see the typecast");
            Console.ReadLine();

            foreach (var coffeeItem in orderList)
            {
                if (coffeeItem is IMilk)
                {// the item implements the IMilk interface so I cast to this
                    IMilk cItem = coffeeItem as IMilk;
                    Console.WriteLine("see me as an IMilk object");
                    //The only method in IMilk is MlMilk so I print it out 
                    Console.WriteLine($"Ml Milk used {cItem.MlMilk()}");
                }
                else
                    Console.WriteLine("I'm not IMilk");

                if (coffeeItem is ICoffeeBlend)
                {
                    ICoffeeBlend cBlend = coffeeItem as ICoffeeBlend;
                    Console.WriteLine("see me as an ICoffeBlend object");
                    //The only method in ICoffeBlend is the method CoffeeBlend so I print it out 
                    Console.WriteLine($"CoffeBlend:  {cBlend.CoffeeBlend()}");
                }
                else
                    Console.WriteLine("I'm not ICoffeeBlend");
                Console.WriteLine(coffeeItem.ToString());
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
