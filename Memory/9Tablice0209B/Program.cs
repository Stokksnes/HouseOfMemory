using System;
using System.Text;

namespace _9Tablice0209B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo, BMW, Mazda" };
            Console.WriteLine(cars[0]);
            int arrayLength = cars.Length;

            cars[2] = "Teselka";
            Console.WriteLine(cars[cars.Length - 1]);
        }

    }
}