using ePortfolio.Pages;

namespace ePortfolioTests
{
    [TestClass]
    public class BakerPercentageTest
    {
        [TestMethod]
        public void DefaultMass600()
        {
            //-- Arrange
            var DefaultPercentage = new BakersPercentage();
            int expected = 600;

            //-- Act
            int actual = DefaultPercentage.mass;
 
            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DecrementCountCorrect()
        {
            var DefaultPercentage = new BakersPercentage();
            int expected = 550;

            //-- Act
            DefaultPercentage.DecrementCount();
            int actual = DefaultPercentage.mass;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IncrementCountCorrect()
        {
            //-- Arrange
            var DefaultPercentage = new BakersPercentage();
            int expected = 650;

            //-- Act
            DefaultPercentage.IncrementCount();
            int actual = DefaultPercentage.mass;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ResetWeightCorrect()
        {
            //-- Arrange
            var DefaultPercentage = new BakersPercentage();
            DefaultPercentage.mass = 200;
            int expected = 600;

            //-- Act
            DefaultPercentage.ResetWeight();
            int actual = DefaultPercentage.mass;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DefaultFlourSandwichCorrect()
        {
            //-- Arrange
            var DefaultPercentage = new BakersPercentage();
            DefaultPercentage.CalculateIngredients();
            int expected = 363;

            //-- Act
            int actual = (int)DefaultPercentage.flourAmount;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DefaultCiabattaIngredientsCorrect()
        {
            //-- Arrange
            var DefaultPercentage = new BakersPercentage();
            DefaultPercentage.waterPercent = 82.0F;
            DefaultPercentage.yeastPercent = .4F;
            DefaultPercentage.saltPercent = 2.2F;

            DefaultPercentage.CalculateIngredients();
            int expectedFlour = 325;
            int expectedWater = 266;
            int expectedYeast = 1;
            int expectedSalt = 7;

            //-- Act
            int actualFlour = (int)DefaultPercentage.flourAmount;
            int actualWater = (int)DefaultPercentage.waterAmount;
            int actualYeast = (int)DefaultPercentage.yeastAmount;
            int actualSalt = (int)DefaultPercentage.saltAmount;

            //-- Assert
            Assert.AreEqual(expectedFlour, actualFlour);
            Assert.AreEqual(expectedWater, actualWater);
            Assert.AreEqual(expectedYeast, actualYeast);
            Assert.AreEqual(expectedSalt, actualSalt);
        }

    }
}
