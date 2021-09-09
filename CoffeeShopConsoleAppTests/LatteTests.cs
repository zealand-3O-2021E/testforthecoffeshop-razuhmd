using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class LatteTests
    {
        [TestMethod()]
        public void LatteTest()
        {
            ////Arrange
            var latte = new Latte();

            ////Act
            var result = latte.price();

            ////Assert
            Assert.AreEqual(40, result);
            Assert.IsInstanceOfType(latte, typeof(Latte));
        }

        [TestMethod()]
        public void LatteConstructorTest1()
        {
            ////Arrange
            var latte = new Latte(2);

            ////Act
            var result = latte.price();

            ////Assert
            Assert.AreEqual(38, result);
        }

        [TestMethod()]
        public void MlMilkTest()
        {
            //Arrange
            var latte = new Latte();

            //Act
            var result = latte.MlMilk();

            //Assert
            Assert.AreEqual(200, result);
            
        }

        [TestMethod()]
        public void TypeOfCoffeeTest()
        {
            //Arrange
            var latte = new Latte();

            //Act
            var result = latte.TypeOfCoffee();

            //Assert
            Assert.AreEqual("Latte", result);

        }

        [TestMethod()]
        public void priceTest()
        {
            //Arrange
            var latteWithoutDiscount = new Latte();
            var latteWithDiscount = new Latte(5);

            //Act
            var resultWithoutDiscount = latteWithoutDiscount.price();
            var resultWithDiscount = latteWithDiscount.price();

            //Assert
            Assert.AreEqual(40, resultWithoutDiscount);
            Assert.AreEqual(35, resultWithDiscount);
        }

        [TestMethod()]
        public void StrengthTest()
        {
            //Arrange
            var latte = new Latte();

            //Act
            var result = latte.Strength();

            //Assert
            Assert.AreEqual("Weak", result);
        }
    }
}