using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("Insert your height");
            height = int.Parse(Console.ReadLine());

            if (height >= 2000)
            {
                Console.WriteLine("You are a giant");
            }
            else if(height >= 180)
            {
                Console.WriteLine("You have a normal height");
            }
            else if(height >= 170)
            {
                Console.WriteLine("You are small but still enough");
            }
            else
            {
                Console.WriteLine("You are a dwarf");
            }
        }
    }
}
