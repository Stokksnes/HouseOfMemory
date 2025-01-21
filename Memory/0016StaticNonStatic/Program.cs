using System;

namespace _0016StaticNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);
            CzlowiekStatic.liczbaLudnosci = 1000;
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);

            Czlowiek czlowiek = new Czlowiek();
            Console.WriteLine(czlowiek.Imie);
            czlowiek.Imie = "Marek";
            Console.WriteLine(czlowiek.Imie);

            Czlowiek czlowiek2 = new Czlowiek();
            Console.WriteLine(czlowiek2.Imie);

            Console.WriteLine(Czlowiek.liczbaLudnosci);

            Console.ReadKey();
        }
    }
}

//Różnice między klasami static i no static
// Do klasy nie statycznej można odwoływac się tylk poprzez obiekt

// klasy statyczne występują raz dla programu a klasy nie statyczne możemy wywoływac do woli