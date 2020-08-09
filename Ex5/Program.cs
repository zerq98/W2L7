using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Insert your age");
            age = int.Parse(Console.ReadLine());

            if (age >= 35)
            {
                Console.WriteLine("You can be the president of Poland");
            }
            else if(age >= 30)
            {
                Console.WriteLine("You can be the senator of Poland");
            }
            else if (age >= 25)
            {
                Console.WriteLine("You can be a Prime Minister");
            }
            else if(age>=21)
            {
                Console.WriteLine("You can be a Member of Parliament");
            }
            else
            {
                Console.WriteLine("You are too young");
            }
        }
    }
}
