﻿using System;
using WlasciwosciKlasy0304;

namespace _20WlasciwosciKlasy0304B
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");

            bill.SetDateOfBirth(new DateTime(1990, 1, 1));
            bill.SayHi();
            bill.ContactNumber = "999888777";
            Console.WriteLine(bill.ContactNumber);


            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");
            john.SayHi();
        }
    }
}