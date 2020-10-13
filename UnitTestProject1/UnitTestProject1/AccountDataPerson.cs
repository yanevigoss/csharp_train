﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests1
{
    class AccountDataPerson
    {
        private string username;
        private string password;

        public AccountDataPerson(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
