using System;

namespace _0021Equals
{
    class Program
    {
        static void Main(string[] args) 
        {
            Auto auto1 = new Auto("Audi", 2014);
            Auto auto2 = new Auto("Volkswagen", 2018);
            Auto auto3 = new Auto("Audi", 2010);
            Console.WriteLine(auto1.Equals(auto3));

            Console.ReadKey();

        }

        class Auto
        {
            public string Model { get; set; }
            public int Rocznik { get; set; }

            public Auto(string model, int rocznik)
            {
                Model = model;
                Rocznik = rocznik;
            }

            public bool Equals(Auto auto) => auto.Model == Model && auto.Rocznik == Rocznik;
            //public bool Equals(Auto auto)
            //{
            //    return auto.Model == Model && auto.Rocznik == Rocznik;
            //}
        }
    }
}

#region Koment

//string s1 = "Program";
//String s2 = new string("Program".ToArray());
//Console.WriteLine(s1.Equals(s2));
//      public override bool Equals(object obj)
//            {
//                return base.Equals(obj);
//            }
#endregion