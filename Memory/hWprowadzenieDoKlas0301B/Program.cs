using System;
using hWprowadzenieDoKlas0301B;

namespace Metody0302
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person(); // Zmienna bill jest obiektem typu Person
            // Typ Person to klasa, która definiuje właściwości dla każdej instancji typu Person
            // Obiekt jest konkretną instancją typu, który został przypisany za pomocą słowa kluczowego new
            bill.FirstName = "Bill"; // Ustawienie pola bill.FirstName na bill, musi dziedziczyć z wartości klas publicznych

            Console.WriteLine($"{bill.FirstName} {bill.DateOfBirth}"); //$ wyświetla użyte zmienne w " " a nie słowa
        }

    }
}
// Klasa określa formę wartości jakie mogą mieć zmienne w programie