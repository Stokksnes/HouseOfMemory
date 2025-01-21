using System;

namespace _0027Struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt2d punkt1 = new Punkt2d(9,4);
            Punkt2d punkt2;
            punkt2 = punkt1;
            punkt2.x = 7;

            Punkt2d punkt3 = punkt1 + punkt2;

            Console.WriteLine(punkt1.x);
            Console.WriteLine(punkt1.y);
            Console.WriteLine(punkt1.OdlegloscOdSrodka());
        }
    }

    struct Punkt2d
    {

        public static Punkt2d operator + (Punkt2d a, Punkt2d b)
        {
            return new Punkt2d(a.x + b.x, a.y + b.y);
        }
        public Punkt2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        public double OdlegloscOdSrodka()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),1);
        }
    }
}


//    class Program
//{
//    static void Main(string[] args)
//    {
//        Punkt2d punkt1;
//        punkt1.x = 5;
//        punkt1.y = 10;

//        Punkt2d punkt2;
//        punkt2 = punkt1;
//        punkt2.x = 7;

//        Console.WriteLine(punkt2.x);
//        Console.WriteLine(punkt2.y);
//        Console.WriteLine(punkt2.OdlegloscOdSrodka());
//    }
//}

//struct Punkt2d
//{
//    public Punkt2d()
//    {

//    }
//    public int x;
//    public int y;
//    public double OdlegloscOdSrodka()
//    {
//        return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)), 1);
//    }
//}

#region TŁUMAZONKO

//***Na początku programu definiowana jest struktura Punkt2d, reprezentująca punkt w dwuwymiarowej przestrzeni. Struktura ta ma dwie zmienne typu int - x i y - które przechowują współrzędne punktu.

//***W metodzie Main tworzony jest obiekt punkt1 typu Punkt2d o współrzędnych (9, 4).

//***Następnie tworzona jest zmienna punkt2 typu Punkt2d, a wartość punkt1 przypisywana jest do punkt2. Ponieważ Punkt2d jest strukturą (a nie klasą), przypisanie to spowoduje skopiowanie wartości 
//punkt1 do punkt2, a nie utworzenie referencji do tego samego miejsca w pamięci.

//***Wartość x zmiennej punkt2 jest zmieniana na 7 (punkt2.x = 7;).

//***Następnie tworzona jest zmienna punkt3, która jest wynikiem dodania punkt1 i punkt2 za pomocą przeciążonego operatora +. W przeciążonym operatorze + struktury Punkt2d sumowane są ich odpowiadające sobie współrzędne x i y.

//***Wypisywane są na konsolę wartości współrzędnych x i y obiektu punkt1 oraz odległość tego punktu od środka układu współrzędnych wyliczona za pomocą metody OdlegloscOdSrodka().
//    Metoda ta oblicza odległość punktu od środka układu, wykorzystując twierdzenie Pitagorasa.

//***Ważne do zauważenia jest to, że w strukturze zmiennej Punkt2d, ponieważ jest ona typem wartościowym, operacje na punkt1 i punkt2 nie wpływają na siebie nawzajem. 
//Przypisanie punkt2 = punkt1; tworzy kopię wartości, dlatego zmiana punkt2 nie wpływa na punkt1.

#endregion 