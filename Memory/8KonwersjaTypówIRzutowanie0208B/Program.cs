using System;
using System.ComponentModel.Design;
using System.Text;

namespace KonwersjaTypówIRzutowanie0208
{
    class Class
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int yearOfBirth;
            if (int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;

                Console.WriteLine("Masz " + age + " lat ");
            }

            else
            {
                Console.WriteLine("Nieprawidlowa wartosc");
            }
        }
    }
}
/*  

byte byteValue = 100;  jawne rzutowanie            - przypisanie do inta, int na byte nie ma problemu
int intValue = (byte)byteValue;
byte byteValue2 = (byte)intValue; - Nie jawne rzutowan. jezeli intvalue jest poza zakresem byte to nastapi przepełnienie

double doubleValue = 3.5;
int intValue2 = (int)doubleValue;

string stringValue2 = intValue2.ToString(); string na int

*/