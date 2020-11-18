using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
       
        [Test]
        public void GroupCreationTest()
        {
            
            GroupData groups = new GroupData("1");
            groups.Header = "sd";
            groups.Footer = "23";

            List<GroupData> oldGroups = app.Group.GetGroupList();

            app.Group.Create(groups);

            List<GroupData> newGroups = app.Group.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);


        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            
            GroupData groups = new GroupData("");
            groups.Header = "";
            groups.Footer = "";

            List<GroupData> oldGroups = app.Group.GetGroupList();

            app.Group.Create(groups);

            List<GroupData> newGroups = app.Group.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }

    }
}
