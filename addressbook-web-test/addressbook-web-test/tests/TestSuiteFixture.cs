﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {

        [SetUp]
        public void InitApplicationManager ()
        {
            ApplicationManager app = ApplicationManager.GetInstance();

            app.Navigator.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }
                
    }
}
