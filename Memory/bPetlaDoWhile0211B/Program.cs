using System;
using System.Text;

namespace PetlaDoWhile0211
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nacisnij x aby wyjsc");

            string userInput;

            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine($"Echo: {userInput}");
            } while (userInput != "x");
        }
    }
}