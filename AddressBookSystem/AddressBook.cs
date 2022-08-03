using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        static List<Contact> addressbook = new List<Contact>();
        Contact contact = new Contact();
        public void AddNewContacts()
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter your First name-");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name-");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address-");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your City-");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State-");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode-");
            contact.Zipcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your PhoneNumber-");
            contact.PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Email-");
            contact.Email = Console.ReadLine();

            addressbook.Add(contact);


        }
        public void Display()
        {
            foreach (var data in addressbook)
            {
                Console.WriteLine("The Details that you have added are -");
                Console.WriteLine("First Name: " + data.FirstName);
                Console.WriteLine("Last Name: " + data.LastName);
                Console.WriteLine("Enter Address: " + data.Address);
                Console.WriteLine("City: " + data.City);
                Console.WriteLine("State: " + data.State);
                Console.WriteLine("Zip: " + data.Zipcode);
                Console.WriteLine("Phone Number: " + data.PhoneNumber);
                Console.WriteLine("Email: " + data.Email);
            }
            Console.WriteLine("Details added successfully");

        }
        public void EditContact()
        {

            Console.WriteLine("__________________________");
            Console.WriteLine("For editing a contact enter first name : ");
            string Name = Console.ReadLine();

            var result = addressbook.FirstOrDefault(x => x.FirstName == Name);
            if (result == null)
            {
                Console.WriteLine("No such contact exists");
                return;
            }
            Console.WriteLine("Edit a contact\n1. Last Name\n2. Address\n3. City\n4. State\n5. ZipCode\n6. Phone Number\n7. Email Address");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter your new Last name");
                    string lastname = Console.ReadLine();
                    result.LastName = lastname;
                    break;
                case 2:
                    Console.WriteLine("Enter your new Address");
                    string address = Console.ReadLine();
                    result.Address = address;
                    break;
                case 3:

                    Console.WriteLine("Enter your new city");
                    string newcity = Console.ReadLine();
                    result.City = newcity;
                    break;
                case 4:
                    Console.WriteLine("Enter your new State");
                    string state = Console.ReadLine();
                    result.State = state;
                    break;
                case 5:
                    Console.WriteLine("Enter your new Zipcode");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    result.Zipcode = zipcode;
                    break;
                case 6:
                    Console.WriteLine("Enter your new PhoneNumber");
                    long phonenumber = Convert.ToInt32(Console.ReadLine());
                    result.PhoneNumber = phonenumber;
                    break;
                case 7:
                    Console.WriteLine("Enter your new Email");
                    string email = Console.ReadLine();
                    result.Email = email;
                    break;


            }

        }

        public void DeleteContact()
        {

            Console.WriteLine("__________________________");
            Console.WriteLine("Enter the First Name that you want to delete : ");
            string FirstName = Console.ReadLine();

            var result = addressbook.FirstOrDefault(x => x.FirstName == FirstName);
            if (result == null)
            {
                Console.WriteLine("No such contact exists");
                return;
            }

            addressbook.Remove(result);
            Console.WriteLine("Contact deleted successfully");
        }
        public void SearchContactByCity()
        {

            Console.WriteLine("__________________________");
            Console.WriteLine("Enter the City : ");
            string city = Console.ReadLine();

            var result = addressbook.FindAll(x => x.City == city);
            if (result.Count==0)
            {
                Console.WriteLine("No such contact exists");
                return;
            }
            foreach (var List in addressbook)
            {
                Console.WriteLine("Following contacts are available belongs to " + List.City);
                Console.WriteLine("FirstName " + List.FirstName);
                Console.WriteLine("LastName " + List.FirstName);
                Console.WriteLine("Address " + List.Address);
                Console.WriteLine("State " + List.State);
                Console.WriteLine("PhoneNumber " + List.PhoneNumber);
                Console.WriteLine("Email " + List.Email);
            }
        }
        public  void SearchContactByState()
        {

            Console.WriteLine("__________________________");
            Console.WriteLine("Enter the State : ");
            string state = Console.ReadLine();
            
            var result = addressbook.FindAll(x => x.State == state);
            if (result.Count==0)
            {
                Console.WriteLine("No such contact exists");
                return;
            }
            foreach (var List in addressbook)
            {
                Console.WriteLine("Following contacts are available belongs to " + List.State);
                Console.WriteLine("FirstName " + List.FirstName);
                Console.WriteLine("LastName " + List.LastName);
                Console.WriteLine("Address " + List.Address);
                Console.WriteLine("City " + List.City);
                Console.WriteLine("PhoneNumber " + List.PhoneNumber);
                Console.WriteLine("Email " + List.Email);
            }
        }
        public  void SizeOfAddressBook()
        {
            if (addressbook.Count == 0)
            {
                Console.WriteLine("Address Book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Address Book Size is : " + addressbook.Count);
            }

           
        }
    }
}





































