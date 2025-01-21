using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;

namespace KonsolNotes
{
    class Program
    {
        public static List<Laseczki> names;
        public static List<Option> options;
        static void Main(string[] args)
        {
            names = new List<Laseczki>
            {

            };
            // Tworzenie opcji zawartych w menu
            options = new List<Option>
            {
                new Option("Wyświetl aktualną zawartośc listy", () => DisplayElements2(names)),
                new Option("Dodaj element do listy", () => AddElement()),
                new Option("Usuń element po indeksie", () =>  DeleteElement()),
                new Option("Wyjdź", () => Environment.Exit(0)),
            };

            // Ustawienie domyślnego indeksu na pierwszy czyli zero bo zaczynają się od zera
            int index = 0;

            // Wypisanie menu
            WriteMenu(options, options[index]);

            // info przechowania kluczy
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                // Sterownie menu (strzałka w dół pisze od nowa menu i wyświetla z wybraną pozycja)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                        WriteMenu(options, options[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options, options[index]);
                    }
                }
                // Różne akcje dla opcji 
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    options[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();

        }
        // Akcje opcji, metody
        static void WriteTemporaryMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(3000);
            WriteMenu(options, options.First());
        }



        static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(option.Name);
            }
        }

        static void DisplayElements(List<Option> el)
        {
            Console.Clear();
            foreach (Option element in el)
            {
                Console.WriteLine($"{element} ");
            }
            
        }

        static void DisplayElements2(List<Laseczki> el2)
        {
            foreach (Laseczki d in el2)
            {
                Console.Write($"{d} ");
            }
        }

        
        static void AddElement()
        {
            Console.Clear();
            Console.WriteLine("Dodaj imię dziewczyny do listy");
            string userInput = Console.ReadLine();
            names.Add(new Laseczki(userInput));
        }

        static void DeleteElement()
        {
            Console.WriteLine("Jaką dziewczyne chcesz usunąć z listy ? (Podaj imię)");
            string userInput = Console.ReadLine();
            var mak = names.FirstOrDefault(n => n.imie==userInput);
            if(mak != null)
            {
                names.Remove(mak);  
            }

        }
    }
}
// dodaje na server











#region ojojoj
//using System;

//namespace KonsolNotes
//{
//    class Program
//    {
//        //static void WyswietlanieListy(List<string> list)
//        //{
//        //    foreach (string i in list) 
//        //    {
//        //        Console.WriteLine($"{i}, ");
//        //    }
//        //    Console.WriteLine();
//        //}
//        static void Main(string[] args)
//        {
//            List<string> list1 = new List<string> { };

//            Console.WriteLine("1. Dodaj nowy element do listy");
//            Console.WriteLine("2. Usuwanie elementu");
//            Console.WriteLine("3. 321TrzyDwaJeden");
//            Console.WriteLine("4. Exit");
//            bool con = true;
//            while (con)
//            {
//                string menu = Console.ReadLine();

//                switch (menu)
//                {
//                    case "1":
//                        Console.WriteLine("Dodaj nowy element");
//                        string userInput = Console.ReadLine();
//                        list1.Add(userInput);
//                        break;

//                    case "2":
//                        Console.WriteLine("Jaki elelemt z listy chcesz usunąć ? ( indeks 0,1,2,3,4...)");
//                        string userRemove = Console.ReadLine();
//                        list1.Remove(userRemove);
//                        break;

//                    case "3":

//                        break;

//                    case "4":
//                        break;

//                    default:
//                        con = false;
//                        break;
//                }
//            }
//        }
//    }
//}
#endregion
