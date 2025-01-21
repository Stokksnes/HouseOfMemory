using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TypyWbudowane0202// namespace ma być ten sam co nazwa projektu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Właściwy kod
        }
    }
}


string someText = "Some text"; // typ reprezentujący tekst string

char jChar = 'j';            // typ reprezentujacy pojedyńczy znak lub wartosć unicode, przechpwywanie zmiennej char
char jChar = '\u006A'       // unicode   np unicode utf8 polish CI

bool isUserReady = true;     // wynik/sprawdzenie jakiegoś warunku w c#, zmienna binarna true albo false /2 możlwiości
bool isUserReady = false;

DateTime now = DataSetDateTime.Now;  // dowolony punkt w czasie, znacznik czasu - bierzący czas sytemowy ta linijka
DataSetDateTime dateOfBirth = new DataTime(year: 1990, month: 6, day: 6); // zmienna okrreślonej daty np data urodzenia

byte bytenumber = 200;


float floatnumber = 1.5F;
decimal decimalNumbber = 1.5M;
double doubleNumber = 1.5;