using CalcTest.POM;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CalcTest.Steps
{
    [Binding]
    public class DivisionOperationSteps
    {
        public CalculationModel cModel;
        public IWebDriver driver;

        [BeforeScenario]
        public void CreateDriver()
        {
            driver = BaseDriverStep.GetDriver();
            cModel = BaseDriverStep.GetCalculationModel();
        }
        [When(@"I click on division")]
        public void WhenIClickOnDivision()
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
