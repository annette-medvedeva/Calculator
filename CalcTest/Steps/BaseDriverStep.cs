using CalcTest.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalcTest.Steps
{
   public static class BaseDriverStep      
    {
        public static CalculationModel cModel;
        public static IWebDriver driver;

        [AfterScenario]
        public static void CloseBrowser()
        {
            driver.Close();
        }
        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver("P:\\");
            }
            
            return driver;
        }
        public static CalculationModel GetCalculationModel()
        {
            cModel = new CalculationModel();
            return cModel;
        }

        public static void RemoveDriver()
        {
            driver = null;
        }
    }
}
