using System;

namespace TechnicalAssignment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer value between 1 and 25 to execute an Iterative Statement: ");


            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if((value_of_input > 0) && (value_of_input <= 25))
                {
                    for(int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer value between 1 and 25 and try again...");
                    Console.WriteLine("Enter any key to close the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value between 1 and 25 and try again...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
