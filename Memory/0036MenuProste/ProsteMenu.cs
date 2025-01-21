using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0036MenuProste
{
    internal class ProsteMenu
    {
        public static void StartMenuProste()
        {
            Console.Title = "Proste Menu";

            while(true) /// pętla nieskończona o jej zamknięciu będzie decydować klawisz wyjścia
            {
                Console.Clear();
                Console.WriteLine(">>> Przykładowe Menu <<<");
                Console.WriteLine("1- Opcja pierwsza");
                Console.WriteLine("2- Opcja druga");
                Console.WriteLine("3- Koniec");

                ConsoleKeyInfo klawisz = Console.ReadKey();
                switch(klawisz.Key) 
                {
                    case ConsoleKey.D1:Console.Clear();opcjaWBudowie(); break;
                    case ConsoleKey.D2: Console.Clear(); opcjaWBudowie(); break;
                    case ConsoleKey.Escape: // zakonczenie programu poprzed wciśnięcie escape
                    case ConsoleKey.D3:Environment.Exit(0); break;// zakonczenie programu poprzed wciśnięcie 3
                    default: break;
                        
                }
            }
        }

        static void opcjaWBudowie()
        {
            Console.WriteLine("Opcja w budowie");
            Console.ReadKey();
        }
    }
}
