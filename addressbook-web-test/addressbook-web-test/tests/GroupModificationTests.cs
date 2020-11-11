using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressBookTests;

namespace WebAddressBookTests
{
    [TestFixture]
    class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {

            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;

            app.Group.GroupExistanceCheck(1);
            app.Group.Modify(1, newData);
        }
    }
}
