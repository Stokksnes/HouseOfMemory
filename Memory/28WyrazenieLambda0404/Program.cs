using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using _28WyrazenieLambda0404;

namespace _28WyrazenieLambda0404
{
    class Program
    {
        static List<Person> GetEmployess()
        {
            List<Person> employees = new List<Person>()
            {
            new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
            new Person(new DateTime(1991, 3, 4), "Karol", "Makikaki"),
            new Person(new DateTime(1994, 4, 5), "Frank", "Bagieta"),
            new Person(new DateTime(1995, 7, 6), "Oscypek", "Wziewny"),
            new Person(new DateTime(1998, 8, 9), "Kontrabanda", "Pierdyk"),
            new Person(new DateTime(1999, 9, 1), "Lalus", "Palus"),
            };
            return employees;

        }
        static void Main(string[] args)
        {
            List<Person> employees = GetEmployess();
            List<Person> youngEmployees = employees.Where(e => e.GetDateOfBirth() > new DateTime(20, 1, 1)).ToList();

            Console.WriteLine($"Young empoyees count: {youngEmployees.Count}");

            Person Oscypek = youngEmployees.FirstOrDefault(e => e.FirstName == "Oscypek");
#region tst
            //List<Person> employees = GetEmployess();

            //bool EmployeeIsYoung(Person employee)
            //{
            //    return employee.GetDateOfBirth() > new DateTime(2000, 1, 1);
            //}

            //List<Person> youngEmployees = employees.Where(EmployeeIsYoung).ToList();

            //Console.WriteLine($"Wyświetl młodych uzytkowników: {youngEmployees.Count}");

            //bool EmployeeIsOscypek(Person employee)
            //{
            //    return employee.FirstName == " Oscypek";

            //}

            //Person Oscypek = youngEmployees.FirstOrDefault(EmployeeIsOscypek);
            #endregion

            if (Oscypek != null)
            {
                Oscypek.SayHi();
            }
            else
            {
                Console.WriteLine("Oscypek nie został znaleziony");
            }
        }
    }
}

