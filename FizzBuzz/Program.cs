using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 3;
            int buzz = 5;

            Console.WriteLine("Enter the limit");
            int limit = int.Parse(Console.ReadLine());
            for (int counter = 1; counter <= limit; counter++)
            {

                if (counter % fizz == 0 && counter % buzz == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("fizzbuzz");
                    Console.ResetColor();
                }
                else
                {
                    if (counter % fizz == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("fizz");
                        Console.ResetColor();
                    }
                    else if (counter % buzz == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("buzz");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(counter);
                    }
                }

            }

        }
    }
}
