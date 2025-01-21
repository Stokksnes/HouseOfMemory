using System;
using System.Xml;

namespace _0029TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Wynik = " + Dzielenie(0));
            }
            catch(DivideByFifeException e)
            {
                Console.WriteLine("Wyjątek dzielenia przez 5\n" +e.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine("Coś poszło nie tak" + er.Message);
            }
            Console.ReadKey();
        }

        public static float Dzielenie(int a) 
        {
            if (a == 5)
            {
                throw new DivideByFifeException();
            }
            return 10 / a;

        }
    }
    // Osobny plik
    class DivideByFifeException : Exception
    {
        public DivideByFifeException()
        {

        }

        public DivideByFifeException(string? message, Exception? innerException) : base(message, innerException)
        {

        }
    }
}

// ? - zmienne, których typ standardowo nie przyjmuje wartości null

// dodaje zeby dodac do server anmjfjaebhnfliadshgf;iouos