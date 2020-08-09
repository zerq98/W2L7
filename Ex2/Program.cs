using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Insert number below:");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Given number is even");
            }
            else
            {
                Console.WriteLine("Given number isn't even");
            }
        }
    }
}
