using System;

namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book\r\nProgram in");
            Contact contact = new Contact();
            Console.WriteLine("Enter your First Name");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your City name ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State name");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your zipcode");
            contact.Zipcode = Console.ReadLine();
            Console.WriteLine("Enter your Phone number");
            contact.Phone = Console.ReadLine();
            Console.WriteLine("Enter your email ");
            contact.Email = Console.ReadLine();

            string data=  contact.ToString();
            Console.WriteLine(data);
            Console.ReadKey();

        }
    }
}
