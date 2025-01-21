using System;
// Pseudo losowanko
namespace _0010LosowanieLiczb
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int los = (rnd.Next(1, 11)); // losowanie w przedzale 1 -10
            int mojaLiczba;
            int ileRazy = 0;

            Console.WriteLine("Zgadnij liczbę z zakresu 1-10");
            do
            {
                Console.Write("Podaj Liczbę: ");
                mojaLiczba = int.Parse(Console.ReadLine());
                if (mojaLiczba > 10 || mojaLiczba < 1)
                {
                    Console.WriteLine("Liczba z poza zakresu");
                }
                else
                {
                    ileRazy++;
                    if (mojaLiczba > los)
                    {
                        Console.WriteLine("Podałeś zbyt dużą liczbę");
                    }
                    else if (mojaLiczba < los)
                    {
                        Console.WriteLine("Podałeś zbyt małą liczbę");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Brawo, odgadłeś moją liczbę, za {ileRazy} razem");
                    }
                }
            } while (los != mojaLiczba);
        }
    }
}
#region Zapiski

//Random rnd = new Random();
//for (int i = 0; i < 50; i++)
//{
//    Console.WriteLine(rnd.Next(1, 11));
//}

#endregion