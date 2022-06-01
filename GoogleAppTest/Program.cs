using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoogleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // put all tests here
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.co.uk/");
            driver.FindElement(By.Id("L2AGLb")).Click();
            driver.FindElement(By.Name("q")).SendKeys("Learn automation");

        }
    }
}
