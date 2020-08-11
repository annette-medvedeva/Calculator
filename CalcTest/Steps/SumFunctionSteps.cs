using CalcTest.POM;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace CalcTest.Steps
{
    [Binding]
    public class SumFunctionSteps
    {
        public CalculationModel cModel;
        public IWebDriver driver;

        [BeforeScenario]
        public void CreateDriver()
        {
            driver = BaseDriverStep.GetDriver();
            cModel = BaseDriverStep.GetCalculationModel();
        }


        [When(@"I click sum button")]
        public void WhenIClickSumButton()
        {
            IWebElement elm = driver.FindElement(cModel.plusButton);
            elm.Click();
        }
   
        
    }
}
