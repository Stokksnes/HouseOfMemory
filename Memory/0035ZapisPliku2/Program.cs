using System;
using System.IO;

namespace _0035ZapisPliku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otwieranie");
            string patch =@"plik.txt";
            File.AppendText(patch);
        }
    }
}