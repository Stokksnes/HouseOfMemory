using _0007KonstruktorDestruktorObiekty;
using System;
using System.Xml.Linq;

namespace _0007KonstruktoryDestruktoryObiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek("Konstruktorek","Kowalski"); // z dwoma konstruktorami moze być samo ()
            adi.PrzedstawSie();
            Console.WriteLine(adi.Nazwisko);
            adi.Imie = "Bartek";
            adi.PrzedstawSie();

            Console.ReadKey();
        }
    }
}