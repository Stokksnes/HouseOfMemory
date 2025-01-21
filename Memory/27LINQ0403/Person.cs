using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27LINQ0403
{
             internal class Person
             {
            public string FirstName;
            public string LastName;

            private DateTime dateOfBirth;
            private string contactNumber;

            public static int Count = 0;

            public string ContactNumber
            {
                get { return contactNumber; }
                set
                {
                    if (value.Length > 9)
                    {
                        Console.WriteLine("Nieprawidlowa wartosc");
                    }
                    else
                    {
                        contactNumber = value;
                    }
                }
            }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
                Count++;
            }

            public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
            {
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

#region Własny pomysł
//{
//    internal class Person
//    {  
//        public string Imie;
//        public string Nazwisko;
//        private DateTime dateTime;
//        private string v1;
//        private string v2;

//        public Person(DateTime dateTime, string v1, string v2)
//        {
//            this.dateTime = dateTime;
//            this.v1 = v1;
//            this.v2 = v2;
//        }

//        public Person(string imie, string nazwisko )
//        {
//            Imie = imie;
//            Nazwisko = nazwisko;
//        }

//        public void SayHi()
//        {
//            Console.WriteLine($"Siema, jestem {Imie}, {Nazwisko}");
//        }
#endregion
#region Fail 1
        //public void SetDateOfBirth(DateTime date)
        //{
        //    if (Rok_Urodzenia > DateTime.Now)
        //    {
        //        Console.WriteLine("Nieprawidlowa data urodzenia");
        //    }
        //    else
        //    {
        //        Rok_Urodzenia = date;
        //    }

        //    public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
        //{
        //    SetDateOfBirth(dateOfBirth);
        //}
#endregion

