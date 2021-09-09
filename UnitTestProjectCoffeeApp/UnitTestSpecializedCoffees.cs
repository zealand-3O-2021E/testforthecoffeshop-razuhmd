using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectCoffeeApp
{
    [TestClass]
    public class UnitTestSpecializedCoffees
    {
        #region CoffeePriceTests

        [TestMethod]
        public void TestLattePriceNoDiscount()
        {
            //Arrange
            Latte coffee = new Latte();
            //Act
            int actuel_price = coffee.price();
            //Assert
            Assert.AreEqual(40, actuel_price);
        }

        [TestMethod]
        public void TestBlackCoffeePriceNoDiscount()
        {
            //Arrange
            var coffee = new BlackCoffee();
            //Act
            int actuel_price = coffee.price();
            //Assert
            Assert.AreEqual(20, actuel_price);
        }

        [TestMethod]
        public void TestCortadoPriceNoDiscount()
        {
            //Arrange
            var coffee = new Cortado();
            //Act
            int actuel_price = coffee.price();
            //Assert
            Assert.AreEqual(25, actuel_price);
        }

        [TestMethod]
        public void TestEspressoPriceNoDiscount()
        {
            //Arrange
            var coffee = new Espresso();
            //Act
            int actuel_price = coffee.price();
            //Assert
            Assert.AreEqual(20, actuel_price);
        }

        [TestMethod]
        public void TestFlatWhitePriceNoDiscount()
        {
            //Arrange
            var coffee = new FlatWhite();
            //Act
            int actuel_price = coffee.price();
            //Assert
            Assert.AreEqual(35, actuel_price);
        }

        #endregion CoffeePriceTests

        #region CoffeeStrengthTests
        [TestMethod]
        public void TestBlackCoffeeStrength()
        {
            //Arrange
            var coffee = new BlackCoffee();
            //Act
            string actuel_strength = coffee.Strength();
            //Assert
            Assert.AreEqual("Strong", actuel_strength);
        }

        [TestMethod]
        public void TestCortadoStrength()
        {
            //Arrange
            var coffee = new Cortado();
            //Act
            string actuel_strength = coffee.Strength();
            //Assert
            Assert.AreEqual("Medium", actuel_strength);
        }

        [TestMethod]
        public void TestEspressoStrength()
        {
            //Arrange
            var coffee = new Espresso();
            //Act
            string actuel_strength = coffee.Strength();
            //Assert
            Assert.AreEqual("Strong", actuel_strength);
        }

        [TestMethod]
        public void TestFlatWhiteStrength()
        {
            //Arrange
            var coffee = new FlatWhite();
            //Act
            string actuel_strength = coffee.Strength();
            //Assert
            Assert.AreEqual("Medium", actuel_strength);
        }

        [TestMethod]
        public void TestLatteStrength()
        {
            //Arrange
            var coffee = new Latte();
            //Act
            string actuel_strength = coffee.Strength();
            //Assert
            Assert.AreEqual("Weak", actuel_strength);
        }

        #endregion Coffee strength tests

    }
}
