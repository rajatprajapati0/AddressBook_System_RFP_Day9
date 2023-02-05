using System;

namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book\r\nPrograming");
            addressBook data = new addressBook();


            while (true)
            {
                Console.WriteLine("enter option \n a - add new no.\n b - disply  all stored contacts ");
                char op = char.Parse(Console.ReadLine());
                switch (op)
                {
                    case 'a': Console.WriteLine("add new contact");
                        data.AddContact();
                        break;
                    case 'b': Console.WriteLine("add new contact");
                        data.disply();
                        break;
                    default: Console.WriteLine("enter onlye suggest charect");
                        break;
                }
            }
        }
    }
}