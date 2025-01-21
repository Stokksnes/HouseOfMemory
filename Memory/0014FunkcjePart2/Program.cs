using System;

namespace _0014FunkcjePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(2,4));
            Console.ReadKey();
        }

        static string Dodaj(int a, int b)
        {
            int wynik = a + b;
            if(wynik >= 10)
            {
                return "Wynik większy od 10";
            }
            else
            {
                return "Wynik mniejszy od 10";
            }
            
        }
    } 
}

    