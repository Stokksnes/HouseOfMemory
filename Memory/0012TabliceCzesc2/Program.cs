using System;
using System.Dynamic;
using System.Net.WebSockets;

namespace _0012TabliceCzesc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // tablica tablic
            int[][] tab = new int[2][]; // jedna tablica w której siedzi kolejna nowa tablica, w pierwszym indeksie trzeba podać ilośc elementów w 2 moze być dowolna liczba
            tab[0] = new int[3]; // 3 to ilość elementów w 2 wymiarze na 0 indeksie w pierwszym indeksie czyli 0 siedzi 3 dane
            tab[1] = new int[2]; // a w tym siedzi sobie 2 dane 
            tab[0][0] = 2; // czyli, że z pierwszej tablicy wyświetlany jest 3 indeks czyli 2 bo od zera i  nadana jest wartość dwa temu indeksowi
            tab[0][1] = 5;
            tab[0][2] = 3;
            tab[1][0] = 32;     
            tab[1][1] = 42;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j <tab[i].Length; j++) // wstawione i bo najpierw chcemy się dostac do zerowego czyli do pierwszego a następnie 1 czyli do drugiego
                {
                    Console.Write(tab[i][j] + " ");
                } 
                Console.WriteLine();

            }
        } 
    }
}
#region Reszta

//int[,] tab = new int[2, 3];
//tab[0, 0] = 1;
//tab[0, 1] = 2;
//tab[0, 2] = 5;
//tab[1, 0] = 22;
//tab[1, 1] = 33;
//tab[1, 2] = 44;


//for (int i = 0; i < tab.GetLength(0); i++)
//{
//    for (int j = 0; j < tab.GetLength(1); j++)  
//    {
//        Console.Write(tab[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

//GetLength() - wyświetlanie tablicy i w nawiasach indeks itemu wyświetlanego


//int[] tab = new int[4];

//tab[0] = 5;
//tab[1] = 3;
//tab[2] = 10;
//tab[3] = 1;

////Console.WriteLine(tab.Sum());

//for (int i = 0; i < tab.Length; i++)
//{
//    Console.WriteLine(tab[i]);
//}

//Array.Sort[tab];

//for (int i = 0; i < tab.Length; i++)
//{
//    Console.WriteLine(tab[1]);
//}

//Array.Reverse(tab);

//for (int i = 0; i < tab.Length; i++)
//{
//    Console.WriteLine(tab[i]);
//}
#endregion