using System;

namespace Interfejs0309Mono
{
    class EcelFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compressing EcelFile");
        }
        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report...");
        }
    }
}