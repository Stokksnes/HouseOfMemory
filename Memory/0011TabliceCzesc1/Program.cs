using System;

namespace _0011TabliceCzesc1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[365];
            string[] dniTygodnia = { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            tablica[0] = 22;
            tablica[364] = 23;
            
            for (int i = 0; i < dniTygodnia.Length; i++)
            {
                Console.WriteLine(dniTygodnia[i]);
            }
        }
    }
}