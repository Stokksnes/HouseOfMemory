using System;

namespace _0031AsIs
{
    class Program
    {
        static void Main(string[] args)
        {
            Zwierze zwierze = new Kot();
            Kot kot = new Kot();

            Kot kot2 = zwierze as Kot;

            if (!(kot2 == null)) 
            {
                kot2.PijMleko();
                Console.WriteLine("Powiodło się");
            }
            else
            {
                Console.WriteLine("Nie powiodło się");
            }
        }
    }

    class Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("Domyślny głos");
        }
    }

    class Kot : Zwierze
    {
        public void PijMleko()
        {
            Console.WriteLine("Piję mleko");
        }
    }
}

#region
//  zwierze = (Zwierze)kot; // przygaszony zielony tutaj, oznacza, że rzutowanie jest zbędne

//class Program
//{
//    static void Main(string[] args)
//    {
//        Zwierze zwierze = new Zwierze();
//        Kot kot = new Kot();

//        zwierze = kot;

//        if (zwierze is Kot)
//        {
//            Console.WriteLine("Powiodło się");
//        }
//        else
//        {
//            Console.WriteLine("Nie powiodło się");
//        }
//    }
//}

//class Zwierze
//{
//    public void DajGlos()
//    {
//        Console.WriteLine("Domyślny głos");
//    }
//}

//class Kot : Zwierze
//{
//    public void PijMleko()
//    {
//        Console.WriteLine("Piję mleko");
//    }
//}
//}

#endregion

// dodaje zeby dodac do server anmjfjaebhnfliadshgf;iouos