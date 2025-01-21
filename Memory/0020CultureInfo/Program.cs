using System;
using System.Globalization;

namespace _0020CultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = CultureInfo.GetCultures(CultureTypes.AllCultures);

            //foreach (var item in c) 
            //{
            //    Console.Write(item.Name); // zwaraca nazwę danej kultury
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);  // konkretna właśność
            //}

            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();// tworzenie nowej kultury
            newCulture.NumberFormat.CurrencyDecimalSeparator = ":";
            newCulture.NumberFormat.NegativeSign = "MINUS ";

            CultureInfo.CurrentCulture = newCulture;

            int a = -5;
            float b = 3.14f;
            Console.WriteLine($"{a}\n{b}");
            Console.ReadKey();
        }
    }
}