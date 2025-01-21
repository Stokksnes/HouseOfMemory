using System;
using System.Data;

namespace SwitchStatement0207
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("The Weekend!");
                    break;
                default:
                    Console.WriteLine("The middle of work week.");
                    break;
            }
        }
    }
}


//***************************************************************
// Alternatywnie na if else

/* 
static void Main(string[]args)
{
    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
        Console.WriteLine("It's Monday ; ");
    else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
        Console.WriteLine("The last day of the work week");
    else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DataSetDateTime.DayOfWeek == DayOfWeek.Saturday)
        Console.WriteLine("The weekend! ");
    else
        Console.WriteLine("The middle of the work week."); 
}
*/
