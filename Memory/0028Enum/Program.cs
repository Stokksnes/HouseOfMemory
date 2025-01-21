using _0028Enum;
using System;

namespace _0028Enum
{
    enum PoryRoku
    {
        Wiosna =15, Lato = 25, Jesień = 5, Zima = -5
    }
    class Program
    {
        static void Main(string[] args) 
        {
            PoryRoku poraRoku = (PoryRoku)25;
            Console.WriteLine(poraRoku);

        }
    }
}
#region     TŁUMACZONKO

#endregion

//PoryRoku poraRoku = PoryRoku.Zima;
//Console.WriteLine((int)poraRoku);