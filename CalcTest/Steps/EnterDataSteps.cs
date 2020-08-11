using CalcTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CalcTest.Steps
{
    [Binding]
    public class EnterDataSteps
    {
        public CalculationModel cModel;
        public IWebDriver driver;
       

        [Given(@"Web calculator open in the browser")]
        public void GivenWebCalculatorOpenInTheBrowser()
        {
            cModel = BaseDriverStep.GetCalculationModel();
            driver = BaseDriverStep.GetDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "file:///C:/Users/Anna/Desktop/Calculators/calc%20team%203/Calculator%20Kadetskaya/Calculator.html";
        }

        [When(@"I press (.*)")]
        public void WhenIPress(string value)
        {
            char[] arr=value.ToCharArray();
            IWebElement el;
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case '0':
                        el = driver.FindElement(cModel.zeroButton);
                        el.Click();
                        break;
                    case '1':
                        el = driver.FindElement(cModel.oneButton);
                        el.Click();
                        break;
                    case '2':
                        el = driver.FindElement(cModel.twoButton);
                        el.Click();
                        break;
                    case '3':
                        el = driver.FindElement(cModel.threeButton);
                        el.Click();
                        break;
                    case '4':
                        el = driver.FindElement(cModel.fourButton);
                        el.Click();
                        break;
                    case '5':
                        el = driver.FindElement(cModel.fiveButton);
                        el.Click();
                        break;
                    case '6':
                        el = driver.FindElement(cModel.sixButton);
                        el.Click();
                        break;
                    case '7':
                        el = driver.FindElement(cModel.sevenButton);
                        el.Click();
                        break;
                    case '8':
                        el = driver.FindElement(cModel.eightButton);
                        el.Click();
                        break;
                    case '9':
                        el = driver.FindElement(cModel.nineButton);
                        el.Click();
                        break;
                    case '+':
                        el = driver.FindElement(cModel.plusButton);
                        el.Click();
                        break;
                    case '-':
                        el = driver.FindElement(cModel.minusButton);
                        el.Click();
                        break;
                    case '*':
                        el = driver.FindElement(cModel.multButton);
                        el.Click();
                        break;
                    case '/':
                        el = driver.FindElement(cModel.divButton);
                        el.Click();
                        break;
                }
            }
        }

        [When(@"I click point button")]
        public void WhenIClickPointButton()
        {
            IWebElement el = driver.FindElement(cModel.pointButton);
            el.Click();
        }
        [Then(@"(.*) should be on the screen")]
        public void ThenShouldBeOnTheScreen(string value)
        {
            IWebElement el=driver.FindElement(cModel.outputField);
            Assert.AreEqual(value,el.GetProperty("value"));
        }
        [When(@"I click AC button")]
        public void WhenIClickACButton()
        {
            IWebElement elm = driver.FindElement(cModel.acButton);
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
