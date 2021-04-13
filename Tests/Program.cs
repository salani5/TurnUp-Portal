using April2021.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace April2021
{
     class Program
    {
          static void Main(string[] args)
        {
            //launch the turUp portal
            IWebDriver driver = new ChromeDriver("F:\\chromeDriver");

            //page objects
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(driver);

            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            TMpage TMobj = new TMpage();
            TMobj.createTM(driver);
            TMobj.EditTM(driver);
            TMobj.deleteTM(driver);
            












        }
    }
}


        
    
