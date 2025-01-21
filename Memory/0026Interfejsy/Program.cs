using _0026Interfejsy;
using System;
using System.Security.Cryptography.X509Certificates;

namespace _0026Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac ("Elfka", 200);
            IAtakMagiczny atak = (IAtakMagiczny)p1;
            atak.Atak(25);
            IAtakMieczem ata2 = (IAtakMieczem)p1;
            atak.Atak(65);
        }
    }

    interface IAtakMagiczny //interfejs zawsze rozpoczynamy duża literą i, mogą zawierac tylko metody bez ciała, interfejsów możemy dziedziczyć bez ograniczenia (klase tylko jedną)
    {
        void Atak(int pkt);
    }
    interface IAtakMieczem
    {
        void Atak(int pkt);
    }

    class Postac : IAtakMagiczny, IAtakMieczem
    {
        public string imie;
        public int punktyHP;
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }

        public void Atak(int pkt)
        {
            throw new NotImplementedException();
        }
    }
}

#region TŁUMACZONKO
//*****************************
//Interfejsy używane są do definiowania kontraktów, czyli zestawu metod, które musza być zaimplementowane przez
//klasy, które muszą być zaimpelementowane przez klasy, które implementują interjefsy
//*****************************

//W tym kodzie istnieją dwa interfejsy: IAtakMagiczny i IAtakMieczem. Oba interfejsy zawierają jedną metodę o tej samej sygnaturze (void Atak(int pkt)), ale są to oddzielne interfejsy, które reprezentują różne sposoby ataku.

//Klasa Postac implementuje oba interfejsy IAtakMagiczny i IAtakMieczem. W klasie Program, w metodzie Main, tworzony jest obiekt typu Postac o nazwie p1 i wywoływane są interfejsy IAtakMagiczny i IAtakMieczem.

//***Tworzony jest obiekt p1 typu Postac o nazwie "Elfka" z 200 punktami HP.
//***Następnie następuje rzutowanie p1 na interfejs IAtakMagiczny przy użyciu IAtakMagiczny atak = (IAtakMagiczny)p1; i wywołanie metody Atak(25). Jednakże zauważ, że w rzeczywistości metoda Atak w klasie Postac nie została 
//zaimplementowana, więc wywołanie tej metody rzuci wyjątek NotImplementedException.
//***Kolejne rzutowanie p1 na IAtakMieczem jest błędne, powinno być IAtakMieczem ata2 = (IAtakMieczem)p1;. Potem następuje ponowne wywołanie metody Atak(65) na interfejsie IAtakMagiczny, co również rzuci wyjątek 
//NotImplementedException.
//***Generalnie rzutowanie obiektu p1 na interfejsy IAtakMagiczny i IAtakMieczem nie pozwala wywołać metody Atak, ponieważ sama klasa Postac nie zaimplementowała tych metod. Aby użyć tych interfejsów, klasa Postac
//musi zaimplementować metody zdefiniowane w interfejsach IAtakMagiczny i IAtakMieczem.
#endregion  q