using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Give me a number and I will tell if it is positive or negative");

            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Given number is positive");
            }
            else if(number == 0)
            {
                Console.WriteLine("You gave me ZERO!");
            }
            else
            {
                Console.WriteLine("Given number is negative");
            }
        }
    }
}
