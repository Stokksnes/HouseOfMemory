using System;
using System.Security.Principal;

namespace _0003BankoweKonto
{
    class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe Konto = new KontoBankowe("<name>", 1000);
            Console.WriteLine($"Konto {Konto.Numer} zostało stworzone dla {Konto.Wlasciciel} z saldem: {Konto.Saldo}");

            Konto.DokonajWplaty2(500, DateTime.Now, "Wpłata za mieszkanie");
            Console.WriteLine(Konto.Saldo);
            Konto.DokonajWplaty(100, DateTime.Now, "Kumpel oddał kase");
            Console.WriteLine(Konto.Saldo);

            try
            {
                Konto.DokonajWplaty2(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            KontoBankowe invalidAccount;
            try
            {
                invalidAccount = new KontoBankowe("Nieprawidłowy", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Wyjątek przyłapany na tworzeniu konta z ujemnym saldem");
                Console.WriteLine(e.ToString());
                return;
            }
            Console.WriteLine(Konto.GetAccountHistory());
        }
    }
}

