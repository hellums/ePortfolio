using ePortfolio.Pages;
using Bunit;
using Xunit;

namespace ePortfolioTests 
{
    [TestClass]
    public class EmployeeUITest : Bunit.TestContext
    {
        [TestMethod]
        [Fact]
        public void EmployeeTableFileLoadedCorrectly()
        {
            // Arrange

            // Act: find and click the <button> element to decrement
            // the counter in the <strong> element
            var cut = RenderComponent<Employees>();
            var paraElm = cut.Find("td");
            var paraElmText = paraElm.TextContent;

            // Assert: first find the <strong> element, then verify its content
            paraElmText.MarkupMatches("Willie Wonka");
        }
    }
}
