using ePortfolio.Pages;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace ePortfolioTests
{
    [TestClass]
    public class BakersPercentageTest
    {
        private BakersPercentage? Percentage;

        [TestInitialize()]
        public void Initialize()
        {
            Percentage = new BakersPercentage();
            if (Percentage is not null) Percentage.mass = 600;
        }

        [TestMethod]
        public void DefaultMass600()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                int expected = Percentage.mass;

                //-- Act
                int actual = Percentage.mass;

                //-- Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DecrementCountCorrect()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                int expected = Percentage.mass - 50;

                //-- Act
                Percentage.DecrementCount();
                int actual = Percentage.mass;

                //-- Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void IncrementCountCorrect()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                int expected = Percentage.mass + 50;

                //-- Act
                Percentage.IncrementCount();
                int actual = Percentage.mass;

                //-- Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ResetWeightCorrect()
        {
            if (Percentage is not null) {

                //-- Arrange
                int expected = Percentage.mass;
                Percentage.mass = 200;

                //-- Act
                Percentage.ResetWeight();
                int actual = Percentage.mass;

                //-- Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void DefaultSandwichIngredientsCorrect()
        {
            if (Percentage is not null)
            {
                //Arrange

                //Act
                Percentage.CalculateIngredients();

                //Assert
                Assert.AreEqual(Percentage.mass, 600);
                Assert.AreEqual(Percentage.flourAmount, 340);
                Assert.AreEqual(Percentage.waterAmount, 215);
                Assert.AreEqual(Percentage.yeastAmount, 5);
                Assert.AreEqual(Percentage.saltAmount, 4);
                Assert.AreEqual(Percentage.sugarAmount, 12);
                Assert.AreEqual(Percentage.fatAmount, 28);
            }
        }

        [TestMethod]
        public void CiabattaIngredientsCorrect()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                Percentage.waterPercent = 82.0d;
                Percentage.yeastPercent = 0.4d;
                Percentage.saltPercent = 2.2d;
                Percentage.sugarPercent = 0.0d;
                Percentage.fatPercent = 0.0d;

                //Act
                Percentage.CalculateIngredients();

                //-- Assert
                Assert.AreEqual(Percentage.flourAmount, 326);
                Assert.AreEqual(Percentage.waterAmount, 268);
                Assert.AreEqual(Percentage.yeastAmount, 2);
                Assert.AreEqual(Percentage.saltAmount, 8);
                Assert.AreEqual(Percentage.sugarAmount, 0);
                Assert.AreEqual(Percentage.fatAmount, 0);
            }
        }

        [TestMethod]
        public void FocacciaIngredientsCorrect()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                Percentage.waterPercent = 90.0d;
                Percentage.yeastPercent = .75d;
                Percentage.saltPercent = 3.5d;
                Percentage.sugarPercent = 0.0d;
                Percentage.fatPercent = 9.4d;

                //Act
                Percentage.CalculateIngredients();

                //-- Assert
                Assert.AreEqual(Percentage.flourAmount, 295);
                Assert.AreEqual(Percentage.waterAmount, 266);
                Assert.AreEqual(Percentage.yeastAmount, 3);
                Assert.AreEqual(Percentage.saltAmount, 11);
                Assert.AreEqual(Percentage.sugarAmount, 0);
                Assert.AreEqual(Percentage.fatAmount, 28);
            }
        }
        [TestMethod]
        public void FrenchIngredientsCorrect()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                Percentage.waterPercent = 66.0d;
                Percentage.yeastPercent = 1.25d;
                Percentage.saltPercent = 2.0d;
                Percentage.sugarPercent = 0.0d;
                Percentage.fatPercent = 0.0d;

                //Act
                Percentage.CalculateIngredients();

                //-- Assert
                Assert.AreEqual(Percentage.flourAmount, 355);
                Assert.AreEqual(Percentage.waterAmount, 235);
                Assert.AreEqual(Percentage.yeastAmount, 5);
                Assert.AreEqual(Percentage.saltAmount, 8);
                Assert.AreEqual(Percentage.sugarAmount, 0);
                Assert.AreEqual(Percentage.fatAmount, 0);
            }
        }

        [TestMethod]
        public void BunsIngredientsCorrect()
        {
            if (Percentage is not null)
            {
            //-- Arrange
            Percentage.waterPercent = 66.0d;
            Percentage.yeastPercent = 2.0d;
            Percentage.saltPercent = 1.5d;
            Percentage.sugarPercent = 2.5d;
            Percentage.fatPercent = 5.0d;

            //Act
            Percentage.CalculateIngredients();

            //-- Assert
            Assert.AreEqual(Percentage.flourAmount, 339);
            Assert.AreEqual(Percentage.waterAmount, 224);
            Assert.AreEqual(Percentage.yeastAmount, 7);
            Assert.AreEqual(Percentage.saltAmount, 6);
            Assert.AreEqual(Percentage.sugarAmount, 9);
            Assert.AreEqual(Percentage.fatAmount, 17);
            }
        }

        [TestMethod]
        public void PizzaIngredientsCorrect()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                Percentage.waterPercent = 59.0d;
                Percentage.yeastPercent = 1.25d;
                Percentage.saltPercent = 2.0d;
                Percentage.sugarPercent = 0.0d;
                Percentage.fatPercent = 0.0d;

                //Act
                Percentage.CalculateIngredients();

                //-- Assert
                Assert.AreEqual(Percentage.flourAmount, 370);
                Assert.AreEqual(Percentage.waterAmount, 219);
                Assert.AreEqual(Percentage.yeastAmount, 5);
                Assert.AreEqual(Percentage.saltAmount, 8);
                Assert.AreEqual(Percentage.sugarAmount, 0);
                Assert.AreEqual(Percentage.fatAmount, 0);
            }
        }

        [TestMethod]
        public void RollsIngredientsCorrect()
        {
            if (Percentage is not null)
            {
                //-- Arrange
                Percentage.waterPercent = 60.0d;
                Percentage.yeastPercent = 2.3d;
                Percentage.saltPercent = 1.3d;
                Percentage.sugarPercent = 10.0d;
                Percentage.fatPercent = 10.0d;

                //Act
                Percentage.CalculateIngredients();

                //-- Assert
                Assert.AreEqual(Percentage.flourAmount, 327);
                Assert.AreEqual(Percentage.waterAmount, 197);
                Assert.AreEqual(Percentage.yeastAmount, 8);
                Assert.AreEqual(Percentage.saltAmount, 5);
                Assert.AreEqual(Percentage.sugarAmount, 33);
                Assert.AreEqual(Percentage.fatAmount, 33);
            }
        }
        [TestMethod]
        public void DumplingsIngredientsCorrect()
        {
            if (Percentage is not null)
            {
            //-- Arrange
            Percentage.waterPercent = 71.0d;
            Percentage.yeastPercent = 0.00d;
            Percentage.saltPercent = 1.0d;
            Percentage.sugarPercent = 0.0d;
            Percentage.fatPercent = 9.0d;

            //Act
            Percentage.CalculateIngredients();

            //-- Assert
            Assert.AreEqual(Percentage.flourAmount, 332);
            Assert.AreEqual(Percentage.waterAmount, 236);
            Assert.AreEqual(Percentage.yeastAmount, 0);
            Assert.AreEqual(Percentage.saltAmount, 4);
            Assert.AreEqual(Percentage.sugarAmount, 0);
            Assert.AreEqual(Percentage.fatAmount, 30);
            }
        }
    }
}