using System;

namespace _0017GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            adi.Imie = "Adrian";
            adi.Wiek = 20;
            adi.Wiek = -20;

            Console.WriteLine($"Jestem {adi.Imie} i  mam {adi.Wiek} lat");

            Console.ReadKey();
        }
    }
}
#region sdafgsa

//Czlowiek adi = new Czlowiek();
//adi.Imie = "Adrian";
//adi.setWiek(20);

//Console.WriteLine($"Jestem {adi.Imie} i  mam {adi.getWiek()} lat");

//Console.ReadKey();

#endregion