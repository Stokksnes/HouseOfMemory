using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor0303
{
    internal class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("konstruktorek1");
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            Console.WriteLine("konstruktorek2");
            SetDateOfBirth(dateOfBirth);

        }

        public void SetDateOfBirth(DateTime date)
        {
            if (dateOfBirth > DateTime.Now)
            {
                Console.WriteLine("Nieprawidlowa data urodzenia");
            }
            else
            {
                dateOfBirth = date;
            }
        }

        public DateTime GetDateOfBirth() => dateOfBirth;

        public void SayHi()
        {
            Console.WriteLine($"Czesc, mam na imie {FirstName}, {GetDateOfBirth()}");
        }
    }
}














