using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Insert year below:");
            year = int.Parse(Console.ReadLine());

            if (((year % 4) == 0 && (year % 100) != 0) || (year % 400) == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} isn't a leap year");
            }
        }
    }
}
