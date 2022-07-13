using static ePortfolio.Pages.Employees;

namespace ePortfolioTests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void EmployeeFullNameCorrect()
        {
            //-- Arrange
            var worker = new Worker();
            worker.FirstName = "Duane";
            worker.LastName = "Hellums";
            string expected = "Duane Hellums";

            //-- Act
            string actual = worker.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmployeeWorkingStatusCorrect()
        {
            //-- Arrange
            var worker = new Worker();
            string expected = "Working";

            //-- Act
            string actual = worker.Working();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmployeeProjectStatusCorrect()
        {
            //-- Arrange
            string expected = "Manchester Project";
            var worker = new Worker();

            //-- Act
            string actual = worker.Working(expected);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateRaiseIsCorrect()
        {
            //-- Arrange
            var worker = new Worker();
            worker.Salary = 130000;
            worker.BonusPercentage = 3;
            string expected = "3900"; //refactor as double, no longer a console app

            //-- Act?
            string actual = worker.CalculateRaise();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}