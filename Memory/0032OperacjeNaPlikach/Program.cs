using System;

namespace _0032OperacjeNaPlikach
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"plik.txt"; 
            StreamWriter sw;

            if(! File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik utworzony");
            }
            else
            {
                sw = new StreamWriter(path, true);
                Console.WriteLine("Plik został otwarty");
            }
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            sw.WriteLine(tekst);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZawartość pliku: ");

            while ((s = sr.ReadLine())! == null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();


        }
    }
}
            //System.IO.File.AppendAllText(path, args);  // zastąp streamreader do prostych