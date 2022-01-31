using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HasanFacebookRegisterAutomationSelenium
{
    class Program
    {
        static void Main(string[] args)
        {



            IWebDriver driver = new ChromeDriver(@"F:\");
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            driver.Manage().Window.Maximize();

            IWebElement button = driver.FindElement(By.XPath("//*[@class='_6ltg'][2]"));
            button.Click();
            System.Threading.Thread.Sleep(4000);

            IWebElement firstname = driver.FindElement(By.Name("firstname"));
            firstname.SendKeys("Ibrahim");
            System.Threading.Thread.Sleep(4000);

            IWebElement lastname = driver.FindElement(By.Name("lastname"));
            lastname.SendKeys("Hasan");
            System.Threading.Thread.Sleep(4000);

            IWebElement reg_email__ = driver.FindElement(By.Name("reg_email__"));
            reg_email__.SendKeys("assignment@gmail.com");
            System.Threading.Thread.Sleep(4000);


            IWebElement reg_passwd__ = driver.FindElement(By.Name("reg_passwd__"));
            reg_passwd__.SendKeys("login@123");
            System.Threading.Thread.Sleep(4000);

            SelectElement element = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            element.SelectByText("10");
            System.Threading.Thread.Sleep(4000);

            SelectElement element1 = new SelectElement(driver.FindElement(By.Id("month")));
            element1.SelectByValue("9");
            System.Threading.Thread.Sleep(4000);

            SelectElement element2 = new SelectElement(driver.FindElement(By.Id("year")));
            element2.SelectByValue("1999");
            System.Threading.Thread.Sleep(4000);

            IWebElement male = driver.FindElement(By.XPath("//input[@type = 'radio' and @value = '2']"));
            male.Click();
            System.Threading.Thread.Sleep(4000);

            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(9000);


        }
    }
}

