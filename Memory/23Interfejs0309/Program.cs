using _23Interfejs0309;
using System;

namespace Interfejs0309Mono
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();

            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "ecel file";

            ecelFile.GenerateReport();

            WordDocumentFile wrodDocumetFile = new WordDocumentFile();

            wordDocumentFile.CreatedOn = DateTime.Now;
            wordDocumentFile.FileName = "word file";
            WordDocumentFile.Print();

        }
    }
}