using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0099Wygibaniec
{
    internal class TestKlasa
    {
        private string Imie {  get; set; }
        private string Nazwisko { get; set; }
        private int Wiek {  get; set; }

        public TestKlasa(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public string DaneLudzia()
        {
            return $"Imie: {Imie}\nNazwisko: {Nazwisko}\nWiek: {Wiek}";
        }
        
    }
}
