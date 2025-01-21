using System;
using System.Reflection.Metadata.Ecma335;

namespace _0008WyswietlProstokat
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            Console.Write("Podaj szerokość: ");
            string xs = Console.ReadLine();
            
            try
            {
                 x = int.Parse(xs);
            }
            catch (Exception ex2)
            {
                Console.WriteLine($"Błąd: {ex2}");
            }

            Console.Write("Podaj wysokość: ");
            string ys = Console.ReadLine();
            
            try
            {
                y = int.Parse(ys);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex} ");
            }

            for (int i = 0; i < y; i++) // wysokość musi być pierwsza bo program nie będzie wiedział ile dać gwiazdek szerokości
            {
                for (int j = 0; j < x; j++) //szerokość / szerokosc jest powtarzana w kazdym rzedzie
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        

    }
}

#region Propozycje

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Podaj szerokość: ");
//        string xs = Console.ReadLine();
//        try
//        {
//            int intValue = int.Parse(xs);
//        }
//        catch
//        {
//            Console.WriteLine("Błędzik kurnia ");
//        }

//        Console.WriteLine("Podaj wysokość");
//        string ys = Console.ReadLine();

//        try
//        {
//            int intValue2 = int.Parse(ys);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Błędzik kurnia {ex} ");
//        }
//        Console.WriteLine("Chcesz kontynuować ?");
//        Console.ReadKey();
//    }

//}


#endregion
