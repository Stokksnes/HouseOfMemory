using System;

namespace _0006Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.ReadKey();
        }
    }
}
#region Tlumaczonko
/*
    To co włożymy na samym koncu na stos musi pierwsze wyjsc

*/

#endregion