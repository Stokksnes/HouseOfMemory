using System;

namespace ElementyStatyczne0305
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");
            bill.SetDateOfBirth(new DateTime(1990, 1, 1));
            bill.SayHi();
            bill.ContactNumber = "992884012";
            Console.WriteLine(bill.ContactNumber);

            Console.WriteLine("********************************************************");

            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");
            john.SayHi();
            Console.WriteLine("********************************************************");


            Person kociak = new Person(new DateTime(1990, 12, 02), "Kociak", "Madagaskarka");
            kociak.SayHi();
            kociak.ContactNumber = "223102923";
            Console.WriteLine(kociak.ContactNumber);

            Console.WriteLine("********************************************************");



            Console.WriteLine($"Object of Person type count: {Person.Count}");
        }
    }
}

