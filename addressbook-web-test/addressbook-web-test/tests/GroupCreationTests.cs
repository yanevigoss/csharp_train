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
            app.Navigator.GoToGroupsPage();
            GroupData groups = new GroupData("1");
            groups.Header = "sd";
            groups.Footer = "23";
            app.Group
                .NewGroupCreation()
                .FillGroupForm(groups)
                .SubmitGroupCreation()
                .ReturnToGroupPage();
        }

    }
}
