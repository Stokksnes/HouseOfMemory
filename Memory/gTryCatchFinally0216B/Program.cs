using System;

namespace TryCatchFinally0216
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };

            try
            {
                Console.WriteLine("Inside try -1");
                cars[4] = "Tesla";
                Console.WriteLine("Inside try -1");
                //blok kodu który może wygenerować wyjątek
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Handing IndexOutOfRangeException");
                // jaki wyjątek chcemy przechwycić i obsłużyć
            }
            catch (Exception e)
            {
                Console.WriteLine("Handling any exception");
            }
            finally // moze wystąpic po wszystkich instrukacjach cash, będzie zawsze wykonywany niezależnie czy wystąpił wyjątek czy nie w bloku try , np do zamknięcia pliku czy zamknięcie połaczenia  z bazą danych
            {
                Console.WriteLine("Cleanup");
            }
            Console.WriteLine("Outside of try-catch");
        }
    }
}