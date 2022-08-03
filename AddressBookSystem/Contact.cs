using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zipcode;
        public long PhoneNumber;
        public string Email;
        public string AddressBookName { get; set; }
        public string AddressBookType { get; set; }

    }
}
