using System;

namespace Nullable0215
{
    class Program
    {
        static void Main(string[] args)
        {
            int? favoriteNumber = 23;   //Nullable<int> favoriteNumber = 23; 
            //bool favoriteNumberHasValue = false;

            Console.WriteLine("Ulubiona liczba: " + (favoriteNumber.HasValue ? favoriteNumber.Value.ToString() : ""));
        }
    }
}