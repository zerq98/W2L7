using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("Insert your grade(1-6)");

            grade = Console.ReadLine();

            switch (grade)
            {
                case "6":
                    Console.WriteLine("Celujący");
                    break;
                case "5":
                    Console.WriteLine("Bardzo dobry");
                    break;
                case "4":
                    Console.WriteLine("Dobry");
                    break;
                case "3":
                    Console.WriteLine("Dostateczny");
                    break;
                case "2":
                    Console.WriteLine("Dopuszczający");
                    break;
                case "1":
                    Console.WriteLine("Niedostateczny");
                    break;
                default:
                    Console.WriteLine("Please try number");
                    break;
            }
        }
    }
}
