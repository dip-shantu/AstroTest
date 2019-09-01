using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;
using OpenQA.Selenium.Interactions;

namespace AstroTest.Steps
{
    [Binding]
    public class PriceCompareSteps : TestBase
    {
        private IWebDriver _driver;
        private Pages.Locators _locatorPage;

        [Given(@"I am on Amazon website")]
        public void GivenIAmOnAmazonWebsite()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _locatorPage = Pages.Locators.NavigateToAmazon(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Given(@"I search for iPhone in amazon")]
        public void GivenISearchForIPhoneInAmazon()
        {
            _locatorPage.EnterSearchTextAmazon();
            _locatorPage.ClickSearchBtnAmazon();
            _locatorPage.ClickAppleBtnAmazon();
        }
        
        [Given(@"I get price in amazon")]
        public void GivenIGetPriceInAmazon()
        {
            _locatorPage.ProductNameAmazon();
            _locatorPage.IphonePriceAmazon();
            _locatorPage.ProductUrlAmazon();
        }
        
        [Given(@"I am on Ebay website")]
        public void GivenIAmOnEbayWebsite()
        {
            _driver.Dispose();
            //_locatorPage.OpenNewTab();

            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _locatorPage = Pages.Locators.NavigateToEbay(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        
        [Given(@"I search for iPhone in ebay")]
        public void GivenISearchForIPhoneInEbay()
        {
            _locatorPage.EnterSearchTextEbay();
            _locatorPage.ClickSearchBtnEbay();
            _locatorPage.ClickAppleBtnEbay();
        }
        
        [Given(@"I get price in ebay")]
        public void GivenIGetPriceInEbay()
        {
            
            _locatorPage.ProductNameEbay();
            _locatorPage.IphonePriceAmazon();
            _locatorPage.ProductUrlAmazon();
        }
        
        [When(@"I compare both price")]
        public void WhenICompareBothPrice()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should sort in ascending order")]
        public void ThenTheResultShouldSortInAscendingOrder()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
