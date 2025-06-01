using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Start Chrome browser
        using (IWebDriver driver = new ChromeDriver())
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            // 1. First Name (by name)
            var firstName = driver.FindElement(By.Name("firstname"));
            firstName.Clear();
            firstName.SendKeys("John");

            // 2. Gender (by value)
            var genderMale = driver.FindElement(By.CssSelector("input[value='Male']"));
            genderMale.Click();

            // 3. Date (by id)
            var dateField = driver.FindElement(By.Id("datepicker"));
            dateField.Clear();
            dateField.SendKeys("01/01/2024");

            // Optional: Wait to see the result before closing
            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}