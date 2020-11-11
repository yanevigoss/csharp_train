using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class PersonRemovalTests : AuthTestBase
    {

        [Test]
        public void PersonRemovalTest()

        {
            app.Person.RemovePerson(1);
        }

    }
}