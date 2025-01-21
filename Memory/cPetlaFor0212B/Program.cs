using System;
using System.Text;
using System.Globalization;

namespace PetlaFor0212
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo, BMW, Mazda" };

            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
                if (cars[j] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }
        }
    }
}