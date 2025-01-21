/*
Początkowa wersja programu **************************************


using System;
using System.Globalization;

namespace _0001ParsowanieDatyZadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj");
            string przywitanie = Console.ReadLine();

            Console.WriteLine("Podaj dzien swojego urodzenia");
            int dzien = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj miesiac swojego urodzenia");
            int miesiac = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj rok swojego urodzenia");
            int rok = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(rok, miesiac, dzien);

            TimeSpan timeSpan = DateTime.Now - dateOfBirth;

            Console.WriteLine($" Urodziles sie: {timeSpan.TotalDays} dni temu");
        }
    }
}
*/

// Sprytna wersja ************************************************
using System;
using System.Globalization;

namespace _0001ParsowanieDatyZadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz date urodzenia (DD.MM.YYYY");

            string dateOfBirthString = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(dateOfBirthString);

            TimeSpan timespan = DateTime.Now - dateOfBirth;

            Console.WriteLine($"Urodziles sie: {timespan.TotalDays} dni temu");
        }
    }
}
