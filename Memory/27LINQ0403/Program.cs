using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace _27LINQ0403
{
    class  Program
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

            bool EmployeeIsYoung(Person employee)
            {
                return employee.GetDateOfBirth() > new DateTime(1994, 1, 1);
            }

            List<Person> youngEmployees = employees.Where(EmployeeIsYoung).ToList(); 

            Console.WriteLine($"Wyświetl młodych uzytkowników: {youngEmployees.Count}");

            bool EmployeeIsOscypek(Person employee)
            {
                return employee.FirstName == " Oscypek";

            }

            Person Oscypek = youngEmployees.FirstOrDefault(EmployeeIsOscypek);


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

#region Stara Wersja
//using System;
//using System.Reflection.Metadata.Ecma335;
//using System.Linq;

//namespace _27LINQ0403
//{
//    class Program
//    {
//        static List<Person> GetEmployess()
//        {
//            List<Person> employees = new List<Person>()
//            {
//            new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
//            new Person(new DateTime(1991, 3, 4), "Karol", "Makikaki"),
//            new Person(new DateTime(1994, 4, 5), "Frank", "Bagieta"),
//            new Person(new DateTime(1995, 7, 6), "Oscypek", "Wziewny"),
//            new Person(new DateTime(1998, 8, 9), "Kontrabanda", "Pierdyk"),
//            new Person(new DateTime(1999, 9, 1), "Lalus", "Palus"),
//            };
//            return employees;

//        }
//        static void Main(string[] args)
//        {
//            List<Person> employees = GetEmployess();
//            List<Person> youngEmployees = new List<Person>();
//            foreach (Person employee in employees)
//            {
//                if (employee.GetDateOfBirth() > new DateTime(1995, 1, 1))
//                {
//                    youngEmployees.Add(employee);
//                }
//            }
//            Console.WriteLine($"Wyświetl młodych uzytkowników: {youngEmployees.Count}");

//            Person Oscypek = null;
//            foreach (Person youngEmployee in youngEmployees)
//            {
//                if (youngEmployee.FirstName == "Oscypek")
//                {
//                    Oscypek = youngEmployee;
//                    break;
//                }
//            }
//            if (Oscypek != null)
//            {
//                Oscypek.SayHi();
//            }
//            else
//            {
//                Console.WriteLine("Oscypek nie został znaleziony");
//            }
//        }
//    }
//}
#endregion