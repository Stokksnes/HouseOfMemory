using System;
using System.Runtime.CompilerServices;

namespace _0004Slownik
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> slowniczek = new Dictionary<int, string>();
            slowniczek.Add(1, "Baśka");
            slowniczek.Add(2, "Ania");
            if (!slowniczek.ContainsKey(2)) // sprawdzenie czy nie ma takiego samego klucza nr2
                slowniczek.Add(2, "Zośka");
            slowniczek.Add(3, "Kaśka");
            slowniczek.Add(4, "Magda");
            slowniczek.Add(5, "Jolka");
            slowniczek.Add(6, "Karolina");
            slowniczek.Add(7, "Aśka");
            slowniczek.Add(8, "Ewelina");
            slowniczek.Add(9, "Ala");
            slowniczek.Add(10, "Iza");
            slowniczek.Add(11, "Ola");
            slowniczek.Add(12, "Małgorzata");
            slowniczek.Add(13, "Monika");



            foreach (var rzecz in slowniczek)
            {
                Console.WriteLine("{0} : {1}", rzecz.Key, rzecz.Value);
            }
            Console.ReadKey();
        }


    }
}

//sprawdzamy zapis