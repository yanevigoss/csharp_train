﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            NewGroupCreation();
            GroupData group = new GroupData("1");
            group.Header = "sd";
            group.Footer = "23";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
        }

    }
}
