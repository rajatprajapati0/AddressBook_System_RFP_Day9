using System;
using System.Collections.Generic;

namespace Address_Book
{
    public class addressBook
    {
        List<Contact> contacts;
        public addressBook()
        {
            contacts = new List<Contact>();
        }
       public void AddContact()
       {
            Contact person = new Contact();
            Console.WriteLine("Enter your First Name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address ");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter your City name ");
            person.City = Console.ReadLine();
            Console.WriteLine("Enter your State name");
            person.State = Console.ReadLine();
            Console.WriteLine("Enter your zipcode");
            person.Zipcode = Console.ReadLine();
            Console.WriteLine("Enter your Phone number");
            person.Phone = Console.ReadLine();
            Console.WriteLine("Enter your email ");
            person.Email = Console.ReadLine();
            contacts.Add(person);
        }


        public void disply()
        {
            if (contacts.Count <= 0)
            {
                Console.WriteLine("No contacts available");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine
                   (@$"
                      Name: {contact.firstName} {contact.lastName}
                      Address: {contact.Address} 
                      City: {contact.City}
                      State: {contact.State}
                      Zipcode: {contact.Zipcode}
                      PhoneNumber:{contact.Phone}
                      Email: {contact.Email}
                  ");

                }
            }

        }
    }


}
