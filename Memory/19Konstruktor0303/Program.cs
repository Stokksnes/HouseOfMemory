using System;

namespace Konstruktor0303
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");

            bill.SetDateOfBirth(new DateTime(1990, 1, 1));
            bill.SayHi();

            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");
            john.SayHi();
        }
    }
}
// Konstruktor jest metodą używaną do tworzenia nowego obiektu dla danego typu przy użyciu słowa kluczowego new
