using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0003BankoweKonto
{
    internal class Transakcja
    {
        public decimal Kwota {  get; set; }
        public DateTime Data {  get; set; }
        public string Notka { get; set; }

        public Transakcja(decimal kwota, DateTime data,string notka)
        {
            Kwota = kwota;
            Data = data;
            Notka = notka;
        }
    }
}
