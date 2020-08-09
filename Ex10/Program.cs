using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Give me three lenghts and we we will see if it is possible to build a triangle");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            if ((a + b > c) || (c + b > a) || (a + c > b))
            {
                Console.WriteLine("Congratulations we can build a triangle");
            }
            else
            {
                Console.WriteLine("Ups, sorry we can't build a triangle");
            }
        }
    }
}
