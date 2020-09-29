using System;
using System.Security.Cryptography;

namespace Week5Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int DiceNumber;
            int sum = 0;
            int counter = 0;

            while (counter < 5)
            {
                DiceNumber = rnd.Next(1, 7);
                sum = sum + DiceNumber;
                Console.WriteLine(DiceNumber);

                counter++;
            }

            Console.WriteLine(sum);
            




            
             
            
           
           
            
            
           
        }
    }
}
