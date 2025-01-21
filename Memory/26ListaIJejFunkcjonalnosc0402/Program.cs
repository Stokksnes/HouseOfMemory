using System;

namespace _26ListaIJejFunkcjonalnosc0402
{
    class Program
    {
#region Wyświetlanie elementu
        
        static void DisplayElements(List<int> list) //Jako parametr do wywołania jest lista, statyczna funkcja do wyświetlania wartości z listy, zeby zoabczyć elementy bezpośrednio w konsoli
        {
            Console.WriteLine("** Lista **");
            foreach (int element in list)  // co robi ta pętla
            {
                Console.Write($"{element}, "); 
            }
            Console.WriteLine();

        }
#endregion

#region Program główny
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2};
            DisplayElements(intList);   // wywołanie zmiennej 

            Console.WriteLine("New element");
            string userInput = Console.ReadLine();
            int intValue = int.Parse(userInput);
            intList.Add(intValue);
            DisplayElements(intList);

            Console.WriteLine("Remove range");
            intList.RemoveRange(1, 2); // w nawiasach podajemy indeksy do usunięcia
            DisplayElements(intList);
            Console.WriteLine("Sort");
            intList.Sort();
            DisplayElements(intList);

        }
#endregion
    }
}
#region Wskazówki
/* List<int> intList = new List<int>();
    intList.Add(6);
Lista intów bo List<int>, może być każdy inny typ ale nie mozna je ze sobą mieszać
intList to nazwa listy, moze być cokolwiek
za pomocą new tworzymy nową listę zamknięcie listy odbywa się List<int>
nazwa listy.Add(wartosc jaką dodajemy moze być string słownie itd, w zależności od zmiennej )*/


#endregion
#region Metody Usuwania z listy
//******************************************************
//Usuwa element o podanym indeksie z listy

//List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
//intList.RemoveAt(2); 

//******************************************************
//Usuwa wszystkie elementy spełniające warunki zdefiniowane przez określony predykat(funkcja zdadaniowa)

//bool IsGreaterThan5(int x)
//{
//    return x > 5;
//}

//List<int> intList2 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
//intList2.RemoveAll(IsGreaterThan5);

//******************************************************
//Usuwa pierwsze wystąpienie określonej wartości z listy

//List<int> intList3 = new List<int>() { 1, 2, 1 }; Tu by zostało 2, 1
//intList3.Remove(1);

//******************************************************
//Usuwa zakres elementów z listy i przyjmuje 2 parametry | liczony od zera indeks początkowy a 2 parametr od liczba elementów do usunięcia

//List<int> intList4 = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2 };
//intList4.RemoveRange(2, 3);

#endregion