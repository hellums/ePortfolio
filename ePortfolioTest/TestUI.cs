using ePortfolio.Pages;
using Bunit;
using Xunit;

namespace ePortfolioTests
{
    [TestClass]
    public class TestUI : Bunit.TestContext
    {
        [TestMethod]
        [Fact]
        public void MassShouldDecrementWhenClicked()
        {
            // Arrange
            var cut = RenderComponent<BakersPercentage>();
            var paraElm = cut.Find("strong");

            // Act: find and click the <button> element to decrement
            // the counter in the <strong> element
            cut.Find("button-decrement").Click();
            var paraElmText = paraElm.TextContent;

            // Assert: first find the <strong> element, then verify its content
            paraElmText.MarkupMatches("Target weight (grams): 550");
        }

        [TestMethod]
        [Fact]
        public void MassShouldIncrementWhenClicked()
        {
            // Arrange
            var cut = RenderComponent<BakersPercentage>();
            var paraElm = cut.Find("strong");

            // Act: find and click the <button> element to increment
            // the counter in the <strong> element
            cut.Find("button-increment").Click();
            var paraElmText = paraElm.TextContent;

            // Assert: first find the <strong> element, then verify its content
            paraElmText.MarkupMatches("Target weight (grams): 650");
        }

        [TestMethod]
        [Fact]
        public void MassShouldResetWhenClicked()  //multiple asserts, always run this one last
        {
            // Arrange
            var cut = RenderComponent<BakersPercentage>();
            var paraElm = cut.Find("strong");

            // Act 1: let's make sure a few increment button clicks change the default first
            cut.Find("button-increment").Click();
            cut.Find("button-increment").Click();
            var paraElmText = paraElm.TextContent;
            // Assert 1: should have changed from 600 to 700
            paraElmText.MarkupMatches("Target weight (grams): 700");

            // Act 2: If we have it set to 700 now, we can test to see if reset works
            cut.Find("button-reset").Click();
            paraElmText = paraElm.TextContent;

            // Assert 2: find the <strong> element, then verify its content
            paraElmText.MarkupMatches("Target weight (grams): 600");
        }
    }
}