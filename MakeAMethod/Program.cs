using System;

namespace MakeAMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            age = DisplayGetUserAge();
        }

        static int DisplayGetUserAge()
        {
            int age;
            string userResponse;
            bool validResponse;

            do
            {
                validResponse = true;
                Console.WriteLine("Enter age in years");
                
                //userResponse = Console.ReadLine();
                //if (!int.TryParse(userResponse,out age))
                //{
                //    Console.WriteLine("Please enter your age as an integer");
                //    validResponse = false;
                //}

                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Please enter your age as an integer");
                    validResponse = false;
                }
            } while (!validResponse);

            return age;
            
        }
    }
}
