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
            app.Person.NewPersonCreation();
            app.Person.FillPersonForm(new PersonData("Carl", "Gallagher"));
            app.Person.SubmitPersonCreation();
            app.Group.ReturnToHomePage();
        }

    }
}
