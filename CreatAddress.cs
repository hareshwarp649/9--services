using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class CreatAddress
    {
        public static void AddressCreate()
        {

            string contact;
            Console.WriteLine(" Enter Contact Details\n");
            Console.Write("First Name : ");
            String firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            String lastName = Console.ReadLine();
            Console.Write("Phone Number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email : ");
            String email = Console.ReadLine(); ;
            Console.Write("Address : ");
            String address = Console.ReadLine();
            Console.Write("City : ");
            String city = Console.ReadLine();
            Console.Write("State : ");
            String state = Console.ReadLine();
            Console.Write("Zip : ");
            int zipCode = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nContact Created.\n");

            contact = firstName + " " + lastName + "\n " + phoneNumber.ToString() + "\n " + email + "\n " + address + "\n " + city + "\n " + state + " " + zipCode.ToString();

            Console.WriteLine(contact);
        }
    }
}
