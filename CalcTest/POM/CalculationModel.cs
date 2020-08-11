using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest.POM
{
    public class CalculationModel
    {
        public By outputField= By.Id("display");
        public By acButton=By.Id("del");

        public By oneButton= By.XPath("/html/body/div/div[5]/input[1]");
        public By twoButton=By.XPath("/html/body/div/div[5]/input[2]");
        public By threeButton=By.XPath("/html/body/div/div[5]/input[3]");
        public By fourButton = By.XPath("/html/body/div/div[4]/input[1]");
        public By fiveButton = By.XPath("/html/body/div/div[4]/input[2]");
        public By sixButton = By.XPath("/html/body/div/div[4]/input[3]");
        public By sevenButton = By.XPath("/html/body/div/div[3]/input[1]");
        public By eightButton = By.XPath("/html/body/div/div[3]/input[2]");
        public By nineButton = By.XPath("/html/body/div/div[3]/input[3]");
        public By zeroButton= By.Id("zero");

        public By pointButton = By.Id("decimal");

        public By divButton = By.XPath("/html/body/div/div[2]/input[2]");
        public By multButton = By.XPath("/html/body/div/div[3]/input[4]");
        public By minusButton = By.XPath("/html/body/div/div[4]/input[4]");
        public By plusButton = By.XPath("/html/body/div/div[5]/input[4]");

        public By equalButton=By.Id("equal");
    }
}
