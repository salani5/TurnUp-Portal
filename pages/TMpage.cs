using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace April2021.pages
{
    class TMpage
    {
        public void createTM(IWebDriver driver)
        {
            //click on createnew button
            IWebElement createnew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnew.Click();
            Thread.Sleep(500);

            //select time from the drop down list
            driver.FindElement(By.XPath("//*[@id='timematerialeditform']/div/div[1]/div/span[1]/span/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='typecode_listbox']/li[2]")).Click();
            Thread.Sleep(500);

            //enter code
            driver.FindElement(By.Id("code")).SendKeys("test-0909");

            //enter description
            driver.FindElement(By.Id("description")).SendKeys("testing0909");

            //enter price per unit
            driver.FindElement(By.XPath("//*[@id='timematerialeditform']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("098765");
               
            //click save button
            driver.FindElement(By.Id("savebutton")).Click();
            Thread.Sleep(500);

            ////validate the created record

            //goto last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(500);

            //verify if the last row contains record
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            actualDescription.Click();
            if (actualDescription.Text == "testing0909")
            {

                Console.WriteLine("TM created and test passed");
            }
            else
            {

                Console.WriteLine(" test failed ");

            }

        }
        public void EditTM(IWebDriver driver)
        {
            //click on edit button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();
            Thread.Sleep(500);
        }

        public void deleteTM(IWebDriver driver)
        {
            //Click on Delete Record
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[4]/td[last()]/a[2]
            IWebElement Delete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            Delete.Click();
            

            //click ok button when pop-up message appears
            string s = driver.SwitchTo().Alert().Text;
            Console.WriteLine(s);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            //driver.Quit();
        }

    }
}
