using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperature;
            Console.WriteLine("What temperature is outside?");
            temperature = float.Parse(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Are you living on Arctic?");
            }
            else if(temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("It's very cold outside");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("It's cold outside");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("It's enough temperature");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("It's still enough but it's begins to be too hot");
            }
            else
            {
                Console.WriteLine("Are you living in volcano?");
            }
        }
    }
}
