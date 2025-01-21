using _23ModyfikatoryDostepu0307B;
using _23ModyfikatoryDostepu0307B;
using System;
using System.Data;

namespace _23ModyfikatoryDostepu0307B   
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel file";
            excelFile.Size = 100;
            excelFile.GenerateReport();

            WordDocumentFile wordDocumentFile = new WordDocumentFile();
            wordDocumentFile.CreatedOn = DateTime.Now;
            wordDocumentFile.FileName = "word file";
            wordDocumentFile.Size = 67;
            wordDocumentFile.Print();
        }
    }
}