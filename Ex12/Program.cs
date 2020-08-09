using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDay;
            Console.WriteLine("Insert week day number");
            weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "1":
                    Console.WriteLine("Monday");
                    break;
                default:
                    Console.WriteLine("Please try again with numbers from 1 to 7");
                    break;
            }
        }
    }
}
