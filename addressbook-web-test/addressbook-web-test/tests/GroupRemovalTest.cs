﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
       
        [Test]
        public void GroupRemovalTest()
        {
            app.Group.Remove(1);
        }

    }
}
