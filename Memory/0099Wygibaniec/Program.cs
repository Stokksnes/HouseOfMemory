using System;
using System.Threading.Channels;

namespace _0099Wygibaniec
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Gimi dane wejściowe");
            string kw = Console.ReadLine();
            int intValue = int.Parse(kw); 
            Console.WriteLine(kw);
            Console.ReadKey();
        }
    }
}



















#region trutut
//using System;
//using System.Collections.Specialized;
//using System.Xml.Linq;

//namespace _0099Wygibaniec
//{
//    class Program
//    {
//        static void WyswietlDane(List<int> lista)
//        {
//            Console.WriteLine("** Lista **");
//            foreach (int element in lista)
//            {
//                Console.Write($" {element},");
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 677 };
//            WyswietlDane(intList);

//            Console.WriteLine("Jaką wartosć chcesz dodać do listy ?");
//            string userInput = Console.ReadLine();
//            int intValue = int.Parse(userInput);
//            intList.Add(intValue);
//            WyswietlDane(intList);

//            Console.WriteLine("Czy chcesz usunąć jakąś liczbę ? Pamiętaj abyś wybrał właściwy indeks. 0,1,2,3,4,5,6");
//            string odp = Console.ReadLine();
//            if (odp == "Tak" || odp == "tak")
//            {
//                Console.WriteLine("Który indeks chcesz usunąć ?");
//                string odp2 = Console.ReadLine();
//                intList.RemoveAt(int.Parse(odp2));
//            }
//            else if (odp == "Nie" || odp == "nie")
//            {
//                Console.WriteLine("A więc tak prezentuje się lista: ");
//                WyswietlDane(intList);
//            }
//            else { Console.WriteLine("Odpowiedź może być Tak lub Nie "); }
//            WyswietlDane(intList);

//            Console.WriteLine("Czy chcesz posortować liste ?");
//            string odp3 = Console.ReadLine();
//            if (odp3 == "Tak" || odp3 == "tak") ;
//            {
//                intList.Sort();
//                Console.WriteLine("Proszę o to Twoja posortowana lista: ");
//                WyswietlDane(intList);
//            }


//            else if (odp3 == "Nie" || odp3 == "nie")
//            {
//                Console.WriteLine("Bye bye");
//            }
//            else
//            {
//                Console.WriteLine("Bye bye");
//            }
//            Console.ReadKey();


//        }
//    }
//}
#endregion

#region Zapiski
//*********************************************************************************************************************
//namespace _0099Wygibaniec
//{
//    class Program
//    {
//        static void WyswietlanieListy(List<int> lista)
//        {
//            Console.WriteLine("** Lista **");
//            foreach (int element in lista)
//            {
//                Console.Write($"{element},");
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            List<int> intList = new List<int>() { 1, 2, 3, 4, 52, 63, 77 };
//            WyswietlanieListy(intList);

//            Console.WriteLine("Podaj wartość, którą mam dodać do listy");
//            string userInput = Console.ReadLine();
//            int intValue = int.Parse(userInput);
//            intList.Add(intValue);
//            WyswietlanieListy(intList);

//            Console.WriteLine("Czy chcesz usunąć jakąś wartość ? Tak / Nie");
//            string odp1 = Console.ReadLine();

//            if (odp1 == "Tak")
//            {
//                Console.WriteLine("Który indeks z listy chcesz usunąć ?");
//                string odp2 = Console.ReadLine();
//                intList.RemoveAt(int.Parse(odp2));  // zamiast drabiny if
//            }
//            else if (odp1 == "Nie")
//            {
//                Console.WriteLine("Ok, a więc tak prezentuje się lista: ");
//            }
//            else
//            {
//                Console.WriteLine("Możesz wybrać tylko odpowiedz Tak lub Nie");
//            }
//            WyswietlanieListy(intList);


//        }
//    }
//}

//*********************************************************************************************************************


#endregion