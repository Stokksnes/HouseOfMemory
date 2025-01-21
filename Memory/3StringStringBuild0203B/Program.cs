using System;

namespace StringStringBuild0203 // namespace ma być ten sam co nazwa projektu
{
    class Program
    {
        static void Main(string[] args)
        {


            string message1; // bez inicjalizacji, żadna wartośc nie jest do niej przypisana, nie mogą być używane w programie c#
            message1 = "some text";
            Console.WriteLine(message1);


            string message2 = null;  // nie odnosi się do żadnego obiektu
            Console.WrileLine(message2);



            string message3 = string.Empty;  //wartosc braku znaków



            string text = "He said Hi";
            string text = "He said \"Hi\"";


            string windowsLocation = "c:\\windows";

            string fontsFolder = @"c:\windows\fonts";

            string concatenated = string.Connect(text, "to", "me");   // łączenie stringów
            string concatenated2 = text + "to" + "me";



        }
    }
}