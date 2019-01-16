using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "file:///C:/PitDevelop/C%23/WebDriverDemo/WebDriverDemo/TestPage.html";

            //RADIOBUTTONS
            var radioButtons = driver.FindElements(By.Name("color"));
            radioButtons[1].Click();
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Selected)
                    Console.WriteLine(radioButton.GetAttribute("value"));
            }
            //CHECKBUTTONS
            //var checkBok = driver.FindElement(By.Id("check1"));
            //checkBok.Click();
            //checkBok.Click();
            //COMBOBOX POR INDICE
            //var select = driver.FindElement(By.Id("select1"));
            //var tomOption = select.FindElements(By.TagName("option"))[2];
            //tomOption.Click();
            //COMBOBOX POR NOMBRE
            //var select = driver.FindElement(By.Id("select1"));
            //var selectElement = new SelectElement(select);
            //selectElement.SelectByText("Frank");
            //TABLAS FUERZA BRUTA
            //var outerTable = driver.FindElement(By.TagName("table"));
            //var row = innerTable.FindElements(By.TagName("td"))[1];
            //Console.WriteLine(row.Text);
            //TABLAS XPATH
            //var row = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            //Console.WriteLine(row.Text);
        }

        private static void WaitSec(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }


    }
}
