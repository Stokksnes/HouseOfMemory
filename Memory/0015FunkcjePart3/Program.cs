using System;

namespace _0015FunkcjePart3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 2;
            Test(ref tab);
            Console.WriteLine("Po: " + tab[0] + " , " + tab[1]);
            Console.ReadKey();
        }

        static void Test(ref int[] tab)  // tutaj nazwy lokalne, dalej bedzie działało po zmianie bo jest to odseparowane
        {
            tab = new int[2];
            tab[0] = -5;
            tab[1] = -2;
            Console.WriteLine("W funkcji " + tab[0] + " , " + tab[1]);
        }
    }
}
#region Koment
// out używamy gdy nie wiemy jaką wartośc chcemy okreslić początkową zmienną podczas wywoływania funkcji
// out używa się po to aby nie przypisywać początkowej wartości przy deklaracji

//using System;

//namespace _0015FunkcjePart3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 5;
//            Console.WriteLine("Przed: " + a);
//            Test(ref a);
//            Console.WriteLine("Po: " + a);
//            Console.ReadKey();
//        }

//        static void Test(ref int a)  // tutaj nazwy lokalne, dalej bedzie działało po zmianie bo jest to odseparowane
//        {
//            a += 5;
//            Console.WriteLine("W funkcji " + a);
//        }
//    }
//}
#endregion