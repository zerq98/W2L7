using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            int choosenOption;
            Console.WriteLine("Calculator");
            Console.Write("A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What do you want to do: ");
            Console.WriteLine("1.Add ");
            Console.WriteLine("2.Substract ");
            Console.WriteLine("3.Divide ");
            Console.WriteLine("4.Multiply ");
            choosenOption = int.Parse(Console.ReadLine());

            switch (choosenOption)
            {
                case 1:
                    Console.WriteLine($"Result: {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {a - b}");
                    break;
                case 3:
                    if (b != 0)
                    {
                        Console.WriteLine($"Result: {a + b}");
                    }
                    else
                    {
                        Console.WriteLine("You can't divide by zero");
                    }
                    break;
                case 4:
                    Console.WriteLine($"Result: {a * b}");
                    break;
                default:
                    Console.WriteLine("We don't have more options");
                    break;
            }
        }
    }
}
