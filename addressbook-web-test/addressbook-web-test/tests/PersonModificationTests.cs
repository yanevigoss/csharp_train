using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    class PersonModificationTests : TestBase
    {
        [Test]
        public void PersonModificationTest()
        {
            PersonData newData = new PersonData("", "");
            newData.Firstname = "PEtr";
            newData.Secondname = "Ivanov";

            app.Person.ModifyPerson(1, newData);
        }

    }
}

