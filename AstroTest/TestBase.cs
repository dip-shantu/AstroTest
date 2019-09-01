using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace AstroTest
{
    [Binding]
    public class TestBase
    {
        public static string PageUriAmazon = @"https://www.amazon.com";
        public static string PageUriEbay = @"https://www.ebay.com";
    }


}
