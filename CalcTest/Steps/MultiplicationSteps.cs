using CalcTest.POM;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CalcTest.Steps
{
    [Binding]
    public class MultiplicationSteps
    {
        public CalculationModel cModel;
        public IWebDriver driver;

        [BeforeScenario]
        public void CreateDriver()
        {
            driver = BaseDriverStep.GetDriver();
            cModel = BaseDriverStep.GetCalculationModel();
        }
        [When(@"I click multiplication")]
        public void WhenIClickMultiplicationButton()
        {
            IWebElement elm = driver.FindElement(cModel.multButton);
            elm.Click();
        }
        [AfterScenario]
        public void CloseBrowser()
        {
            driver.Quit();
            BaseDriverStep.RemoveDriver();
        }
    }
}
