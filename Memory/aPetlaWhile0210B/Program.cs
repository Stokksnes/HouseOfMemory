using System;
using System.Text;
using System.Globalization;

namespace _10PetlaWhile0210B
{
    class Progrma
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo, BMW, Mazda" };

            int i = 0;
            while (i < cars.Length)
            {
                Console.WriteLine(cars[i]);
                if (cars[i] == "BMW")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                i++;
            }

        }
    }
}

//using system;
//using system.text;
//using system.globalization;

//namespace petlawhile0210
//{
//    class progrma
//    {
//        static void main(string[] args)
//        {
//            string[] cars = { "volvo, bmw, mazda" };

//            int i = 0;
//            while (i <= 2)
//            {
//                console.writeline(i);
//                i++;
//            }

//        }
//    }
//}

