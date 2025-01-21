using System;
using System.Globalization;

namespace _0013FunkcjePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dodaj(2, 3, "Badum");   // c# sam sobie dobierze czy chce skorzystać z pierwszej metody czy z przeładowania, w zależności od zmiennych
            Dodaj(2, 3, "klik");
            Console.ReadKey();
        }

        static void Dodaj(int a, int b, string cimcirymci) // każda kolejna zmienna po prawej ma przypisane zero, jeśli np do b = 0 to wszystko po niej będzie musiało mieć wartość zero
        {
            int wynik = a + b;
            Console.WriteLine("Wynik dodawania: " + wynik + cimcirymci);
        }
    }
}
#region Koment
// void - funkcja po zakonczeniu swojego działania nie będzie zwracała wyniku
//Metody w c# zawsze pisać dużą literą
// (string[] args) - tablica przyjmująca wartosci stringów, args- argumenty wejsciowe, inicjowane przy uruchomieniu pgoramu

//using System;
//using System.Globalization;

//namespace _0013FunkcjePart1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dodaj(2, 3, 4);   // c# sam sobie dobierze czy chce skorzystać z pierwszej metody czy z przeładowania, w zależności od zmiennych
//            Console.ReadKey();
//        }

//        static void Dodaj(int a, int b)
//        {
//            int wynik = a + b;
//            Console.WriteLine("Wynik dodawania: " + wynik);
//        }

//        static void Dodaj(int a, int b, int c)    //przeciążenie
//        {
//            int wynik = a + b + c;
//            Console.WriteLine("Wynik dodawania: " + wynik);
//        }

//    }
//}
#endregion