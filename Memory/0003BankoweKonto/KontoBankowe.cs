using System.Transactions;
using System.Xml.Linq;

namespace _0003BankoweKonto
{

    public class KontoBankowe
    {
        private static int s_numerkonta = 1234567890;
        public string Numer { get; }
        public string Wlasciciel { get; set; }
        public decimal Saldo
        {
            get
            {
                decimal saldo = 0;
                foreach (var item in _wszystkietransakcje)
                {
                    saldo += item.Kwota;
                }
                return saldo;
            }
        }

        public KontoBankowe(string imie, decimal saldo)
        {
            Wlasciciel = imie;
            DokonajWplaty(saldo, DateTime.Now, "Saldo początkowe");

            Numer = s_numerkonta.ToString();
            s_numerkonta++;
        }
        private List<Transakcja> _wszystkietransakcje = new List<Transakcja>();


        public void DokonajWplaty(decimal kwota, DateTime data, string notka) 
        {
            if ( kwota <= 0)
            {
                throw new ArgumentOutOfRangeException (nameof(kwota), "Kwota w depozycie musi być dodatnia");
            }
            var deposit = new Transakcja(kwota, data, notka);
            _wszystkietransakcje.Add(deposit);
        }

        public void DokonajWplaty2(decimal kwota, DateTime data, string notka)
        {
            if (kwota <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(kwota), "Kwota w depozycie musi być dodatnia");
            }
            if (Saldo - kwota < 0)
            {
                throw new InvalidOperationException("Niewystarczające środki na tę wypłatę");
            }
            var wplata2 = new Transakcja(-kwota, data, notka);
            _wszystkietransakcje .Add(wplata2);
        }
        
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder ();

            decimal saldo = 0;
            report.AppendLine("Date\t\tKwota\t\tSaldo\tNotka");
            foreach (var item in _wszystkietransakcje)
            {
                saldo += item.Kwota;
                report.AppendLine($"{item.Data.ToShortDateString()}\t{item.Kwota}\t{saldo}\t{item.Notka}");
            }
            return report.ToString();
        
        }
    }
}

