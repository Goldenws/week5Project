using System;

namespace Week5Project4Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            
            int counter = 0;
            while(counter < 3)
            {   
                Console.WriteLine("Enter your Login: ");
                string UserInputLogin = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                string UserInputPassword = Console.ReadLine();
              
                if(UserInputLogin == "Admin" && UserInputPassword == "pass1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
               
                else
                {
                    counter ++;
                    Console.WriteLine("Try again");
                }
               if(counter > 2)
            {
                Console.WriteLine("Access denied!");
            }


            }
      
            
        }
    }
}
