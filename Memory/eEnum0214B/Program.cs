using Enum0214;
using System;
using System.Reflection;

namespace Emu0214
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaka jest Twoja plec ? 1 = Male - Męzczyzna, 2 = Female - Kobieta");
            string userInput = Console.ReadLine();
            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userInput);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("Tylko kobiety są wpuszczane");
            }
            //else
            //{
            //    Console.WriteLine("Siema chopie");
            //}
            if (userGender == Gender.Female)
            {
                Console.WriteLine("Witaj piękna Pani");
            }

        }
    }
}



//using System;

//namespace Emu0214
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            switch (DateTime.Now.DayOfWeek)
//            {
//                case DayOfWeek.Monday:
//                    Console.WriteLine("Jest poniedziałek, ojoj");
//                    break;
//                case DayOfWeek.Friday:
//                    Console.WriteLine("Ostani dzien pracy, piateczek");
//                    break;
//                case DayOfWeek.Sunday:
//                case DayOfWeek.Saturday:
//                    Console.WriteLine("Łikend");
//                        break;
//                default:
//                    Console.WriteLine("W trakcie tygodnia");
//                    break;
//            }
//        }
//    }
//}