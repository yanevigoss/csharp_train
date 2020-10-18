using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    [TestFixture]
    public class PersonCreationTests : TestBase
    {

        [Test]
        public void PersonCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            NewPersonCreation();
            FillPersonForm(new PersonData("Carl", "Gallagher"));
            SubmitPersonCreation();
            ReturnToHomePage();
        }

    }
}
