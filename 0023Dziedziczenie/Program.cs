using System;

namespace _0023Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Ziemia ziemia = new Ziemia();
            ziemia.RuchObrotowy();
            ziemia.PoraDniaINocy();
            ziemia.Atmosfera();

            Console.ReadKey();
        }
    }

    class CialoNiebieskie
    {
        public string Nazwa { get; set; }
        public void RuchObrotowy()
        {
            Console.WriteLine("Każde ciało niebieskie posiada ruch obrotowy");
        }
    }

    class Planeta : CialoNiebieskie
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pora dnia i nocy");
        }
    }

    class Ziemia : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera Ziemska");
        }
    }
}

// nowa planeta
