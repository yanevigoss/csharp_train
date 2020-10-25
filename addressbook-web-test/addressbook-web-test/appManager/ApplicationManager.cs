using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper group;
        protected PersonHelper person;
        private string baseURL;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";

            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            group = new GroupHelper(this);
            person = new PersonHelper(this);

        }

        public ApplicationManager(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }

        public GroupHelper Group
        {
            get
            {
                return group;
            }
        }

        public PersonHelper Person
        {
            get
            {
                return person;
            }
        }

        
    }
}
