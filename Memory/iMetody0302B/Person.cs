using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMetody0302B
{
    class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        public void SetDateOfBirth(DateTime date)
        { // ciało metody
            if (date > DateTime.Now) //sprawdzanie czy data jest z przyszłości czy nie
            {
                Console.WriteLine("Nieprawidlowa data urodzin");
            }
            else
            {
                dateOfBirth = date;  //pola prywatne z małej litery
            }
        }
        public DateTime GetDateOfBirth() => dateOfBirth;
        // public DateTime GetDateOfBirth() // ta metoda zwróci wartość dateTime i nie przyjmuje żadnych parametrów
        // {
        // return dateOfBirth; 
        // }
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
        }
    }
}
// Void-nie zwraca żadnej wartości