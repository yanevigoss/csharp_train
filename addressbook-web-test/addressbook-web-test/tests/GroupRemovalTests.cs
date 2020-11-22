﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
       
        [Test]
        public void GroupRemovalTest()
        {
            List<GroupData> oldGroups = app.Group.GetGroupList();

            app.Group.GroupExistanceCheck(1);

            app.Group.Remove(0);

            List<GroupData> newGroups = app.Group.GetGroupList();

            oldGroups.RemoveAt(0);

            Assert.AreEqual(oldGroups, newGroups);
        }

    }
}
