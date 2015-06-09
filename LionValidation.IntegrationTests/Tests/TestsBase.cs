using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace LionValidation.IntegrationTests.Tests
{
    [TestClass]
    public class TestsBase
    {
        public IWebDriver Driver { get; set; }
        public string BaseUrl { get; set; }
        public IWebElement FirstField { get { return Driver.FindElement(By.Name("FirstField")); } }
        public IWebElement SecondField { get { return Driver.FindElement(By.Name("SecondField")); } }
        public IWebElement ThirdField { get { return Driver.FindElement(By.Name("ThirdField")); } }
        public IWebElement FourthField { get { return Driver.FindElement(By.Name("FourthField")); } }
        public IWebElement GrandChildFirstField { get { return Driver.FindElement(By.Name("Child.ChildFirstField.GrandChildFirstField")); } }
        public IWebElement GrandChildSecondField { get { return Driver.FindElement(By.Name("Child.ChildFirstField.GrandChildSecondField")); } }
        public IWebElement BooleanOneField { get { return Driver.FindElement(By.Name("BooleanOneField")); } }
        public IWebElement BooleanTwoField { get { return Driver.FindElement(By.Name("BooleanTwoField")); } }
        public IWebElement IntField { get { return Driver.FindElement(By.Name("IntField")); } }
        public IWebElement SubmitButton { get { return Driver.FindElement(By.Id("submitButton")); } }
        public WebDriverWait Wait; 

        [TestInitialize]
        public void Initialise()
        {
            string testName = this.GetType().Name.Replace("Tests", "");
            Driver = new FirefoxDriver();
            BaseUrl = "http://localhost:58755/Test/StartTest/";
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(4));

            Driver.Navigate().GoToUrl(BaseUrl + testName);
            LocalInitialise();
        }

        protected virtual void LocalInitialise()
        {}

        [TestCleanup]
        public void AfterTest()
        {
            //Close the browser
            Driver.Quit();
        }

        protected void Validate()
        {
            SubmitButton.Click();
            WaitForValidationCompletion();
        }

        protected void WaitForValidationCompletion()
        {
            Wait.Until(drv => drv.FindElement(By.Id("IsFinishedValidating")).GetAttribute("value") == "True");
        }
    }

    public static class TestExtensionMethods
    {   
        public static bool IsInvalid(this IWebElement element)
        {
            return element.GetAttribute("class").Contains("input-validation-error");
        }

        public static bool IsValid(this IWebElement element)
        {
            return !(element.IsInvalid());
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }

}