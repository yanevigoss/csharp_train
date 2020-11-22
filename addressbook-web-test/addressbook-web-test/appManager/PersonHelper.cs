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
    public class PersonHelper : HelperBase
    {
        
        public PersonHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public PersonHelper RemovePerson(int p)
        {
            manager.Navigator.OpenHomePage();

            SelectPerson(p);
            InitPersonRemove();
            SubmitPersonRemove();
            return this;
        }

        public PersonHelper ModifyPerson(int p, PersonData newData)
        {
            manager.Navigator.OpenHomePage();

            SelectPerson(p);
            InitPersonModify();
            FillPersonForm(newData);
            SubmitPersonModify();
            return this;
        }

        public PersonHelper SubmitPersonModify()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public PersonHelper InitPersonModify()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public PersonHelper SubmitPersonRemove()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public PersonHelper InitPersonRemove()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public PersonHelper SelectPerson(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public PersonHelper CreatePerson(PersonData person)
        {
            NewPersonCreation();
            FillPersonForm(person);
            SubmitPersonCreation();
            return this;
        }
        public PersonHelper NewPersonCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

       

        public PersonHelper FillPersonForm(PersonData person)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(person.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(person.Secondname);
            return this;
        }

        public PersonHelper SubmitPersonCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }
        public PersonHelper PersonExistanceCheck(int index)
        {
            manager.Navigator.OpenHomePage();
            if (IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + index + "]")))
            {
                return this;
            }
            else
            {
                PersonData person = new PersonData("Baggy", "Straus");

                manager.Person.CreatePerson(person);
            }
            return this;
        }

    }
}
