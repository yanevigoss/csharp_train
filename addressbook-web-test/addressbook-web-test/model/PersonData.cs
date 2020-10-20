using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressBookTests
{
    public class PersonData
    {
        private string firstname;
        private string secondname;

        public PersonData(string firstname, string secondname)
        {
            this.firstname = firstname;
            this.secondname = secondname;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Secondname
        {
            get
            {
                return secondname;
            }
            set
            {
                secondname = value;
            }
        }


    }
}
