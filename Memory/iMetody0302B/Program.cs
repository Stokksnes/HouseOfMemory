using System;

namespace iMetody0302B
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person();
            bill.FirstName = "Bill";
            bill.SetDateOfBirth(new DateTime(1990, 1, 1));


            var check = bill.GetDateOfBirth();

            Console.WriteLine($"{bill.FirstName} {check.Year}");
        }

    }
}

// Metoda to blok kodu, który jest wykonywany tylko po wywołaniu, może zwrócić jedną wartośc lub w ogóle jej nie zwrócić
// do metody możemy przekazywac parametry(argumenty),które mogą być używane wenwątrz metody, używamy metod aby można było ponownie wykorzystać kod
