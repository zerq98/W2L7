using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA;
            int numberB;

            Console.WriteLine("Insert two numbers to check if they are equals");
            Console.Write("A: ");
            numberA = int.Parse(Console.ReadLine());
            Console.Write("B: ");
            numberB = int.Parse(Console.ReadLine());

            if (numberA == numberB)
            {
                Console.WriteLine("Numbers are equals");
            }
            else
            {
                Console.WriteLine("Numbers aren't equals");
            }
        }
    }
}
