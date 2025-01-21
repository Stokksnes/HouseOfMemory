using System.Reflection.Metadata.Ecma335;

namespace _0022Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("FIAT", 1999);
            Auto auto2 = new Auto("MERCEDES", 1995);
            Auto auto3 = new Auto("BMW", 2000);
            Auto auto4 = new Auto("FIAT", 1989);
            Auto auto5 = new Auto("SKODA", 2015);

            List<Auto> autoList = new List<Auto>();
            autoList.Add(auto1);
            autoList.Add(auto2);
            autoList.Add(auto3);
            autoList.Add(auto4);
            autoList.Add(auto5);

            autoList.Sort(new AutoCamparer());

            foreach (var auto in autoList)
            {
                Console.WriteLine(auto.Rocznik+ " - "+auto.Model);
            }

        }

        // porównywanie 2 obiektów
        class AutoCamparer : IComparer<Auto> // porównywanie obiektów które dziedziczą IComparer typ generyczny Auto
        {
            public int Compare(Auto x, Auto y)
            {
                if (x.Rocznik < y.Rocznik) return 1;  //zmiana znaku < / > powoduje zmiane sortowana jak reserve
                else if (x.Rocznik == y.Rocznik) return 0;
                else return -1;
            }
        }

        class Auto : IComparable
        {
            public string Model { get; set; }
            public int Rocznik { get; set; }

            public Auto(string model, int rocznik)
            {
                Model = model;
                Rocznik = rocznik;
            }
            // Do Sortowanka
            public int CompareTo(object? obj) // zaimpelemntowane do IComparable
            {
                var arg = (Auto)obj;    // rzutowanie przez nawiasy okrągłem ponieważ mamy 100% pewności, że jest to od klasy Auto

                if (Rocznik < arg.Rocznik) return 1;
                else if (Rocznik == arg.Rocznik) return 0;
                else return -1;
            }
        }
    }
}