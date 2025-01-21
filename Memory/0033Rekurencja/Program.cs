using System;
using System.Diagnostics;

namespace _0033Rekurencja
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LICZBA = 3;
            Stopwatch time = new Stopwatch();

            time.Start();
            Console.WriteLine(Silnia(LICZBA));
            time.Stop();
            Console.WriteLine(time.ElapsedTicks);

            Console.WriteLine();
            time.Reset();

            time.Start();
            Console.WriteLine(SilniaRek(LICZBA));
            time.Stop();
            Console.WriteLine(time.ElapsedTicks);

            Console.ReadKey();
        }

        private static long SilniaRek(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return SilniaRek(x - 1) * x;
            }
        }

        private static long Silnia(int x)
        {
            long wynik = 1;
            while(x > 1)
            {
                wynik *= x;
                x--;
            }
            return wynik;
        }
    }
}

#region

//NIE REKURENCYJNIE
//class Program
//{
//    static void Main(string[] args)
//    {
//        const int LICZBA = 3;
//        Stopwatch time = new Stopwatch();
//        time.Start();
//        Console.WriteLine(Silnia(LICZBA));
//        time.Stop();
//        Console.WriteLine(time.ElapsedTicks);

//        Console.ReadKey();
//    }

//    private static long Silnia(int x)
//    {
//        long wynik = 1;
//        while (x > 1)
//        {
//            wynik *= x;
//            x--;
//        }
//        return wynik;
//    }
//}
#endregion