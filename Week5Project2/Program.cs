using System;

namespace Week5Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First name: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last name: ");
            string LastName = Console.ReadLine();

            int FirstNameLength = FirstName.Length;
            int LastNameLength = LastName.Length;
            if (FirstNameLength > LastNameLength)
            {
                Console.WriteLine($"Your first Name is longer than your last Name!");
            }else if(FirstNameLength < LastNameLength)
            {
                Console.WriteLine($"Your first Name is shorter than your last name!");

            }
            else
            {
                Console.WriteLine($"Your first Name And last Name are the same length!");
            }
            
        }
    }
}
