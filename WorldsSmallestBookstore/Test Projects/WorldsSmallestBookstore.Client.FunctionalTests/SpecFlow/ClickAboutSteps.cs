using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace WorldsSmallestBookstore.Tests
{
    [Binding]
    public class ClickAboutSteps
    {
        [Given(@"I am on the Home Page")]
        public void GivenIAmOnTheHomePage()
        {
            WebBrowser.Current.GoTo("http://localhost:10487/");
            var HomeText = WebBrowser.Current.Label(Find.ByText("We suggest the following:"));
            Assert.IsNotNull(HomeText);
        }
        
        [When(@"I click About link")]
        public void WhenIClickAboutLink()
        {
            WebBrowser.Current.Link(Find.ByText("About")).Click();

        }
        
        [Then(@"the about Page will show on the screen")]
        public void ThenTheAboutPageWillShowOnTheScreen()
        {
            Assert.IsTrue( WebBrowser.Current.Title.Equals("About"));
        }
    }
}
