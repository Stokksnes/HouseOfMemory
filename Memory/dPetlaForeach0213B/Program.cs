using System;
using System.Text;
using System.Globalization;

namespace PetlaForeach2013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
                if (car == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }
        }
    }
}