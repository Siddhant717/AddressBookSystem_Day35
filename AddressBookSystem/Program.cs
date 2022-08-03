using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook contactdetails = new();
            while (true)
            {
                Console.WriteLine("Enter the option : \n1)Adding Contact \n2)Display contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contactdetails.AddNewContacts();
                        break;
                    case 2:
                        contactdetails.Display();
                        break;
                    
                    default:
                        Console.WriteLine("Please Choose From Above Given Options");
                        break;
                }
            }
        }
    }
}
