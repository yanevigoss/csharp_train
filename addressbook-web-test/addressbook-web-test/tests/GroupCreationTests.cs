using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       
        [Test]
        public void GroupCreationTest()
        {
            
            GroupData groups = new GroupData("1");
            groups.Header = "sd";
            groups.Footer = "23";

            app.Group.Create(groups);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            
            GroupData groups = new GroupData("");
            groups.Header = "";
            groups.Footer = "";

            app.Group.Create(groups);
        }

    }
}
