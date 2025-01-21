using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0017GetterSetter
{
    internal class Czlowiek
    {
        public string Imie;
        private int wiek;

        

        public int Wiek
        {
            get { return wiek; }
            set 
            {
                if (value >= 0 && value <= 200)
                    wiek = value;
                else
                    wiek = 0;
            }
        }
    }
}

#region 

// public int Wiek { get; set; } // get set oznacza ze z tej wartości będzie możliwy odczyt i zapis, get- odczyt

//public int getWiek()
//{
//    return Wiek;
//}

//public void setWiek(int w)
//{
//    if (w >= 0 && w <= 200)
//        Wiek = w;
//}

#endregion
