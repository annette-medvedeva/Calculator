using CalcTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace CalcTest.Steps
{
    [Binding]
    public class SubtractionSteps
    {

        public CalculationModel cModel;
        public IWebDriver driver;

        [BeforeScenario]
        public  void CreateDriver()
        {
            driver = BaseDriverStep.GetDriver();
            cModel = BaseDriverStep.GetCalculationModel();
        }

        [When(@"I click Subtraction")]
        public void WhenIClickSubtraction()
        {
            IWebElement elm = driver.FindElement(cModel.minusButton);
            elm.Click();
        }

        [When(@"I click equal")]
        public void WhenIClickEqual()
        {
            IWebElement el = driver.FindElement(cModel.equalButton);
            el.Click();
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriverStep.RemoveDriver();
        }

    }
}
