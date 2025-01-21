using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0007KonstruktorDestruktorObiekty
{
    public class Czlowiek
    {
        public string Imie = "BRAK";
        public string Nazwisko = "BRAK";

        public Czlowiek() // pusty tak jak domyślny
        {

        }

        public Czlowiek(string imiekonstruktora) // konstruktor bez parametrów
        {
            Imie = imiekonstruktora;
        }

        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)
        {
            Imie = imieKonstruktora;
            Nazwisko = nazwiskoKonstruktora;
        }

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imie " + Imie);
        }

        ~Czlowiek() // destruktor
        {
            System.Diagnostics.Trace.WriteLine("Jestem destruktorem"); // linijka udowadniajaca, że jest (w logach jest)
        }
    }
}
