using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class PersonCreationTests : TestBase
    {

        [Test]
        public void PersonCreationTest()
        {
            PersonData person = new PersonData("", " ");
            person.Firstname = "PEtr";
            person.Secondname = "Ivanov";

            app.Person.CreatePerson(person);
            app.Group.ReturnToHomePage();
        }

    }
}
