using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA, numberB, numberC;
            Console.WriteLine("Which number is the greatest");
            Console.Write("A:");
            numberA = int.Parse(Console.ReadLine());
            Console.Write("B:");
            numberB = int.Parse(Console.ReadLine());
            Console.Write("C:");
            numberC = int.Parse(Console.ReadLine());

            if(numberA > numberB && numberA > numberC)
            {
                Console.WriteLine($"The greatest number is {numberA}");
            }
            else if (numberB > numberA && numberB > numberC)
            {
                Console.WriteLine($"The greatest number is {numberB}");
            }
            else if (numberC > numberB && numberC > numberA)
            {
                Console.WriteLine($"The greatest number is {numberC}");
            }
            else
            {
                Console.WriteLine("They are all the same");
            }
        }
    }
}
