﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressBookTests;

namespace WebAddressBookTests
{
    [TestFixture]
    class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {

            GroupData newData = new GroupData("zzz");
            newData.Header = "ss";
            newData.Footer = "gggg";

            app.Group.Modify(1, newData);
        }
    }
}
