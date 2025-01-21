using System;

namespace _0024Dziedziczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac("Elf", 200);
            Console.WriteLine(p1.imie + " " + p1.punktyHP);

            Mag m1 = new Mag("Elf", 200, 50);
            Console.WriteLine(m1.imie + " " + m1.punktyHP + " " + m1.mana);
        }  
    }

    class Postac
    {
        public string imie;
        public int punktyHP;
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
    }
    class Mag : Postac
    {
        public Mag(string imie, int punktyHP, int mana) : base(imie,punktyHP) // dziedziczenie metody/ konstruktora  bez ctor domyślnego musi być base
        {
            this.mana = mana;
        }

        public int mana;
    }

}