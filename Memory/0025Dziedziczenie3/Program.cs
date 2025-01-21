using System;
namespace _0025Dziedziczenie3
{
    class program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("Elf", 200, 50);
            Console.WriteLine(p1.imie + " " + p1.punktyHP);
            p1.Ruch();

            //p1 = new Zwiadowca("Krasnolud", 200);
            //Console.WriteLine(p1.imie + " " + p1.punktyHP);
            //p1.Ruch();

            //Mag m1 = new Mag("Elf", 150, 200);
            //Console.WriteLine($"Imie: {m1.imie}\nHP: {m1.punktyHP}\nMana: {m1.mana}");
            //m1.Ruch();
        }
    }

    abstract class Postac // klasa abstrakcyjna, abstrakcyjne metody mogą zawierac się tylko w abstrakcyjnej klasie
    {
        public string imie;
        public int punktyHP;
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public virtual void Ruch() // virtual czyli otwarta na dalsze modyfikacje, udoskonalania itd // metoda abstract nie moze deklarować żadnej treści, nie może mieć zadnego ciała
        {
            Console.WriteLine("Ruch postaci");
        }
    }

    class Mag : Postac
    {
        public int mana;
        public Mag(string imie, int punktyHP, int mana) : base("Elf", 200)
        {
            this.mana = mana;
        }
        public override void Ruch()
        {
            Console.WriteLine("Ruch Mag ");
        }
    }
    sealed class Zwiadowca : Postac //sealed zablokowanie opcji dalszego dziedziczenia z klasy
    {
        public int mana;
        public Zwiadowca(string imie, int punktyHP, int mana) : base("Elf", 300)
        {
            this.mana = mana;
        }
        public override void Ruch()
        {
            Console.WriteLine("Ruch Zwiadowcy ");
        }
    }
    
}