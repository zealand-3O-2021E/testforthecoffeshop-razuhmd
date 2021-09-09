using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProjectCoffeeApp
{
    [TestClass]
    public class UnitTestBaseCoffee
    {

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(6)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDiscountExceptionThrownPrice(int discount)
        {
            //Arrange
            var coffee = new BlackCoffee(discount);
            //Act
            int actuel_price = coffee.price();
            //Assert
            Assert.Fail(); // the test should fail if the exception is not thrown before we are here !
        }

        [DataTestMethod]
        [DataRow(0,20)]
        [DataRow(1, 19)]
        [DataRow(2, 18)]
        [DataRow(3, 17)]
        [DataRow(4, 16)]
        [DataRow(5, 15)]
        public void TestDiscountPrice(int discount, int expectedprice)
        {
            //Arrange
            var coffee = new BlackCoffee(discount);
            //Act
            int actuel_price = coffee.price();
            //Assert
            Assert.AreEqual(expectedprice, actuel_price); 
        }


    }
}
