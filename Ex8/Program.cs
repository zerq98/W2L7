using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int math, chemistry, physics;
            Console.WriteLine("Insert your scores");
            Console.Write("Math: ");
            math = int.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            chemistry = int.Parse(Console.ReadLine());
            Console.Write("Physics: ");
            physics = int.Parse(Console.ReadLine());

            if((math+chemistry) >=150 || (math + physics) >= 150)
            {
                Console.WriteLine("Congratulations!");
            }
            else if(math>=70 && chemistry >=55 && physics >= 45)
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Try again in next year");
            }
        }
    }
}
