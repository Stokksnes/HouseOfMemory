using System;
using System.Diagnostics;
using System.Text;

namespace _0019StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();  
            int ile = 100000;
            stopwatch.Start();
            BudujString(ile);
            stopwatch.Stop();
            Console.WriteLine("Stardowy string: {0} tiketów procesora", stopwatch.ElapsedTicks);

            stopwatch.Reset();
            stopwatch.Start();
            BudujStringBuilder(ile);
            stopwatch.Stop();
            Console.WriteLine("Builder string: {0} tiketów procesora", stopwatch.ElapsedTicks);


        }

        public static string BudujString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }

        public static string BudujStringBuilder(int ile)
        {
            string tekst = "";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}