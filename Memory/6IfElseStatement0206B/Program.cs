using System;
using System.Text;
using System.Threading.Channels;

namespace IfElseStatement0206 // namespace ma być ten sam co nazwa projektu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year ofth birth? ");
            string userInput = Console.ReadLine();

            int yearOfBirth = int.Parse(userInput);
            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;
            if (isUserOver18)
            {
                Console.WriteLine("Hello");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Oh well its Sunday");
            }
            else
            {
                Console.WriteLine("Acces denited");
            }

            Console.WriteLine("bye");
        }



    }
}