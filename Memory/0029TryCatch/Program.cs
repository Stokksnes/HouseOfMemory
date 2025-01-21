using System;
using System.Xml;

namespace _0029TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try // w try umieszczamy kod który może powodować błąd
            {
                Console.WriteLine("Wynik = " + Dzielenie(0));
            }
            catch(DivideByZeroException er)
            {
                Console.WriteLine("Dzielisz przez zero !!!" + er.Message);
            }
            catch(Exception er)
            {
                Console.WriteLine("Coś poszło nie tak" + er.Message);
            }
            finally // może go nie być, po zakonczeniu całego trycatch, wykonuje się zawsze, gdy program się nie wywali z rowerka również
            {
                Console.WriteLine("Zawsze będę i posprzątam po błędzie");
            }
            
            Console.ReadKey();
        }

        public static float Dzielenie(int a) // static żeby nie tworzyć obiektu
        {
            if(a == 5)
            {
                throw new Exception("Nigdy nie dziel przez 5");
            }
            return 10 / a;
            
        }
    }
}

// dodaje zeby dodac do server anmjfjaebhnfliadshgf;iouos