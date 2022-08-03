using System;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook contactdetails = new();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact\n3)Editing Contact\n4)Delete Contact" +
                    "\n5)Search Contact by city\n6)Search Contact by state\n7)count size of AddressBook\n8)Sort person name alphabetically by city" +
                    "\n9) Add multiple contacts\n10) Add contacts by type and name\n11) Get number of contacts by type");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        
                        contactdetails.AddNewContacts();
                        break;
                    case 2:
                        contactdetails.Display();
                        break;
                    case 3:
                        contactdetails.EditContact();
                        break;
                    case 4:
                        contactdetails.DeleteContact();
                        break;
                    case 5:
                        contactdetails.SearchContactByCity();
                        break;
                    case 6:
                        contactdetails.SearchContactByState();
                        break;
                    case 7:
                        contactdetails.SizeOfAddressBook();
                        break;
                    case 8:
                        contactdetails.SortPersonsNameByCity();
                        break;
                    case 9:
                        Console.WriteLine("How many contacts you want to add?");
                        int n = Convert.ToInt32(Console.ReadLine());
                        contactdetails.AddMultipleContact(n);
                        break;
                    case 10:
                        Console.WriteLine("How many contacts you want to add?");
                        int num = Convert.ToInt32(Console.ReadLine());
                        contactdetails.AddContactbyType(num);
                        break;
                    case 11:
                        contactdetails.NumberOfContactPersonCountByType();
                        break;

                    default:
                        Console.WriteLine("Please Choose From Above Given Options");
                        break;
                }
            }
        }
    }
}
