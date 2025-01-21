using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _0005Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);  // dodawanie do queue( kolejka )
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine(queue.Dequeue()); //odczyt z kolejki, po odczytaniu nastepuje od razu jego usunięcie, odkryje się kolejny element
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(9);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek()); // odczyt tylko najwyższego elementu
            //zwraca nam początek naszej kolejki ale bez usuwania tego elementu, podgladamy obiekt na samej górze ale go z tamtąd nie zdejmujemy
            Console.ReadKey();
        }
    }
}
#region Tlumaczonko
/*

 To co pierwsze weszło do kolejki to jako pierwsze oczekuje na wyjście
 Aby odowłac się do kolejnej wartości z kolejki wszystkie nad nim musza opuścić kolejkę

 */
#endregion