using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0037MenuZlozone
{
    public static class Menu
    {
        static string[] pozycjeMenu = { "Opcja 1", "Opcja 2", "Opcja 3", "Opcja 4", "Opcja 5", "Koniec" };
        static int aktywnaPozycjaMenu = 0;
        static bool skipNextMenu = false; //zmienna do zatrzymania wpisywania liter i innych niechcianych znaków, Areczkowy sposób

        public static void StartMenu()
        {
            Console.Title = "Cimcirymci trururur";
            Console.CursorVisible = false;  // nie będzie pojawiał się kursor
            while(true)
            {
                PokazMenu();
                WybieranieOpcji();
                UruchomOpcje();
            }
        }
        static void PokazMenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue; // kolor konsoli
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White; // kolor czcionki, po tym jak już się przejdzie donastepnej opcji,ładnie wygląda ten sam
            Console.WriteLine(">>> CimcieRymcie ecie pecie <<<");
            Console.WriteLine();
            for (int i = 0; i < pozycjeMenu.Length; i++)
            {
                if(i == aktywnaPozycjaMenu)
                {
                    Console.BackgroundColor = ConsoleColor.White; // kolor podświetlenia opcji która jest aktualnie wybrana
                    Console.ForegroundColor = ConsoleColor.Black; // kolor czcionki która jest podświetlona do wyboru
                    Console.WriteLine("{0, -35}", pozycjeMenu[i]);  // długość kreski podświetlającej
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(pozycjeMenu[i]);
                }
            }
        }
        static void WybieranieOpcji()
        {
            do
            {
                Menu.skipNextMenu = false; // wywołanie tej zmiennej z up
                ConsoleKeyInfo klawisz = Console.ReadKey();

                if (klawisz.Key == ConsoleKey.UpArrow)
                {
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu > 0) ? aktywnaPozycjaMenu - 1 : pozycjeMenu.Length - 1; // warunek ? - jeśli warunek przed znakiem zapytania zostanie spełniony to zostanie wykonany wyrażenie 1 a jeśli nie to wyrażenie 2
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.DownArrow)
                {
                    aktywnaPozycjaMenu = (aktywnaPozycjaMenu + 1) % pozycjeMenu.Length;
                    PokazMenu();
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    aktywnaPozycjaMenu = pozycjeMenu.Length - 1;
                    break;
                }
                else if (klawisz.Key == ConsoleKey.Enter)
                {
                    break;
                } else
                {
                    Menu.skipNextMenu = true;
                    break;
                }
            } while (true);
        }
        static void UruchomOpcje()
        {
            if (skipNextMenu == true)
            {
                return;
            }
            switch(aktywnaPozycjaMenu)
            {
                case 0: Console.Clear(); opcjaWBudowie(); break;
                case 1: Console.Clear(); opcjaWBudowie(); break;
                case 2: Console.Clear(); opcjaWBudowie(); break;
                case 3: Console.Clear(); opcjaWBudowie(); break;
                case 4: Console.Clear(); opcjaWBudowie(); break;
                case 5: Environment.Exit(0); break;
            }
        }
        static void opcjaWBudowie()
        {
            Console.SetCursorPosition(12, 4);
            Console.Write("Opcja w budowie");
            Console.ReadKey();
        }

    }
}
























