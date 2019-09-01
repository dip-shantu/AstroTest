using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Collections;


namespace AstroTest.Pages
{
    public class Locators : TestBase
    {

        private readonly IWebDriver _driver;
        List<string> plist = new List<string>();
        Dictionary<string, List<string>> pdictionary = new Dictionary<string, List<string>>();

        //Amazons locators
        [FindsBy(How = How.XPath, Using = "//input[@id='twotabsearchtextbox']")]
        private IWebElement _searchFieldAmazon;

        [FindsBy(How = How.XPath, Using = "//div[@class='nav-search-submit nav-sprite']//input[@class='nav-input']")]
        private IWebElement _searchBtnAmazon;

        [FindsBy(How = How.XPath, Using = "//div[@id='search']//span[2]//div[1]")]
        private IWebElement _searchResultTextAmazon;

        [FindsBy(How = How.XPath, Using = "//span[@class='a-size-base a-color-base'][contains(text(),'Apple')]")]
        private IWebElement _appleFilterCheckboxAmazon;

        [FindsBy(How = How.XPath, Using = "//div[@class='a-section a-spacing-none']//a[@class='a-link-normal a-text-normal']")]
        private IWebElement _nameElementAmazon;

        [FindsBy(How = How.XPath, Using = "(//div[@class='a-row a-size-base a-color-secondary']//span[@class='a-color-base'])[1]")]
        private IWebElement _priceElementAmazon;

        [FindsBy(How = How.XPath, Using = "(//a[@class='a-link-normal a-text-normal'])[2]")]
        private IWebElement _productUrlAmazon;


        //Ebay's locators
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search for anything']")]
        private IWebElement _searchFieldEbay;

        [FindsBy(How = How.XPath, Using = "//input[@value='Search']")]
        private IWebElement _searchBtnEbay;

        [FindsBy(How = How.XPath, Using = "//div[@id='search']//span[2]//div[1]")]
        private IWebElement _searchResultTextEbay;

        [FindsBy(How = How.XPath, Using = "//li[@name='Brand']//span[@class='cbx x-refine__multi-select-cbx'][contains(text(),'Apple')]")]
        private IWebElement _appleFilterCheckboxEbay;

        [FindsBy(How = How.XPath, Using = "(//h3[@class='s-item__title s-item__title--has-tags'])[2]")]
        private IWebElement _nameElementEbay;

        [FindsBy(How = How.XPath, Using = "(//span[@class='s-item__price'])[1]")]
        private IWebElement _priceElementEbay;

        [FindsBy(How = How.XPath, Using = "//li[@id='srp-river-results-listing1']//a[@class='s-item__link']")]
        private IWebElement _productUrlEbay;


        //Navigate to Amazon
        public static Locators NavigateToAmazon(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(TestBase.PageUriAmazon);
            return new Locators(driver);
        }


        //Amazon's methods
        public Locators(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void EnterSearchTextAmazon()
        {

            {
                _searchFieldAmazon.SendKeys("iPhone8");
            }
        }

        public void ClickSearchBtnAmazon()
        {

            {
                _searchBtnAmazon.Click();
            }
        }

        public void ClickAppleBtnAmazon()
        {

            {
                _appleFilterCheckboxAmazon.Click();
            }
        }

        public string ProductNameAmazon()
        {
            {
                string _nameElementAmazon = this._nameElementAmazon.Text;
                plist.Add(_nameElementAmazon);
                pdictionary.Add("Amazon", new List<string>());
                pdictionary["Amazon"].Add(_nameElementAmazon);
                return _nameElementAmazon;
            }
        }

        public string IphonePriceAmazon()
        {

            {
                var _priceElementAmazon = this._priceElementAmazon.Text;
                plist.Add(_priceElementAmazon);
                pdictionary.Add("Amazon", new List<string>());
                pdictionary["Amazon"].Add(_priceElementAmazon);
                return _priceElementAmazon;
            }
        }

        public string ProductUrlAmazon()
        {

            {
                var _productUrlAmazon = this._productUrlAmazon.GetAttribute("href");
                plist.Add(_productUrlAmazon);
                pdictionary.Add("Amazon", new List<string>());
                pdictionary["Amazon"].Add(_productUrlAmazon);
                return _productUrlAmazon;
            }
        }


        //Navigate URL
        public static Locators NavigateToEbay(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(TestBase.PageUriEbay);
            return new Locators(driver);
        }

        //Open new tab
        public void OpenNewTab()
        {
            Actions tabAct = new Actions(_driver);
            //tabAct.SendKeys(Keys.Control +"t").Build().Perform();
            tabAct.KeyDown(Keys.Control).SendKeys(Keys.Tab + "/t").KeyUp(Keys.Control).Build().Perform();
            IAction paction = tabAct.Build();
            paction.Perform();
        }

        //Ebay's methods
        public void EnterSearchTextEbay()
        {

            {
                _searchFieldEbay.SendKeys("iPhone8");
            }
        }

        public void ClickSearchBtnEbay()
        {

            {
                _searchBtnEbay.Click();
            }
        }

        public void ClickAppleBtnEbay()
        {

            {
                _appleFilterCheckboxEbay.Click();
            }
        }

        public string ProductNameEbay()
        {
            {
                var _nameElementEbay = this._nameElementEbay.Text;
                plist.Add(_nameElementEbay);
                pdictionary.Add("Ebay", new List<string>());
                pdictionary["Ebay"].Add(_nameElementEbay);
                return _nameElementEbay;
            }
        }

        public string IphonePriceEbay()
        {
            {
                var _priceElementEbay = this._priceElementEbay.Text;
                plist.Add(_priceElementEbay);
                pdictionary.Add("Ebay", new List<string>());
                pdictionary["Ebay"].Add(_priceElementEbay);
                return _priceElementEbay;
            }
        }

        public string ProductUrlEbay()
        {

            {
                var _productUrlEbay = this._productUrlEbay.GetAttribute("href");
                plist.Add(_productUrlEbay);
                pdictionary.Add("Ebay", new List<string>());
                pdictionary["Ebay"].Add(_productUrlEbay);
                return _productUrlEbay;
            }
        }

    }
}
