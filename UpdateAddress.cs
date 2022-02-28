using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class UpdateAddress
    {


        static String firstName;
        static String lastName;
        static long phoneNumber;
        static String email;
        static String address;
        static String city;
        static String state;
        static int zipCode;
        public static List<String> addreBook = new List<String>();

        public static void AddressUpdate()
        {
            Console.WriteLine("Select any one: ");
            Console.Write("1. Create Contact \n2. Update Contact \n0. Exit\nOption:  ");
            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1:

                    CreateContact(addreBook);
                    break;
                case 2:
                    UpdateContact(addreBook);
                    break;
                default:
                    Environment.Exit(-1);
                    break;
            }

        }


        
        public static void UpdateContact(List<string> addreBook)
        {
            if (addreBook.Count == 0)
            {
                Console.Write("\nAddress Book is empty. \n\n");
                toContinue();
            }
            else
            {
                Console.Write("\nEnter contact name :  ");
               string  name = Console.ReadLine();
                for (int i = 0; i < addreBook.Count; i++)
                {
                    String[] contactArray = addreBook[i].Split();

                    for (int j = 0; j < contactArray.Length; j++)
                    {
                        if (name == contactArray[0])
                        {
                            Console.WriteLine("\nPlease update contact details:  \n");
                            ContactDeatils();
                            String updatedContact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                            addreBook[i] = updatedContact;
                            break;
                        }
                    }
                }

                Console.WriteLine("\n\nContact Updated.\n");

                for (int i = 0; i < addreBook.Count; i++)
                {
                    Console.WriteLine("{0}.  {1}", i + 1, addreBook[i]);
                }
                toContinue();

            }
        }

        // method for creating new contact in address book
        public static void CreateContact(List<string> addreBook)
        {
            int count = 0;
            string contact;
            char ch;
            do
            {
                Console.WriteLine("\nPlease Enter Contact Details: \n");
                ContactDeatils();
                Console.WriteLine("\nContact Created.\n");

                contact = firstName + " " + lastName + " " + phoneNumber.ToString() + " " + email + " " + address + " " + city + " " + state + " " + zipCode.ToString();
                addreBook.Add(contact);
                count++;

                Console.WriteLine("Do you want to continue: y/n");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'y');


            Console.WriteLine("\n{0} contacts\n", count);

            for (int i = 0; i < addreBook.Count; i++)
            {
                Console.WriteLine("{0}.  {1}", i, addreBook[i]);
            }
            toContinue();
        }

        // method for taking user input from console for creating or updating a contact
        public static void ContactDeatils()
        {

            Console.Write("First Name : ");
            firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            lastName = Console.ReadLine();
            Console.Write("Phone Number : ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email : ");
            email = Console.ReadLine(); ;
            Console.Write("Address : ");
            address = Console.ReadLine();
            Console.Write("City : ");
            city = Console.ReadLine();
            Console.Write("State : ");
            state = Console.ReadLine();
            Console.Write("Zip : ");
            zipCode = Convert.ToInt32(Console.ReadLine());
        }


        // method for asking user to continue
        public static void toContinue()
        {
            char ch;
            Console.WriteLine("Do you want to continue: y/n");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n\n");
            if (ch == 'y')
            {
                AddressUpdate();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}
  