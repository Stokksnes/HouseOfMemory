using System;

namespace _0018ParamsObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerujTekst("Mam na imie #0 i mam #1 lat", "Adam", 22));
            Console.ReadKey();
        }

        public static string GenerujTekst(string tekst, params object[] args )
        {
            for (int i = 0; i < args.Length; i++)
            {
                tekst = tekst.Replace("#" + i, args[i].ToString());
            }
            return tekst;
        }
    }
}

// po object dziedziczą wszystkie inne obiekty i typy danych, moze przyjmować rózne typy danych, jest wielopostaciowy, dosotsowywuje się i przyjmuje inne typy danych, to nie jak var, var wie jaka będzie miał zmienną
// args - arguments
//Replace , zamienia np stary typ string na nowy ????