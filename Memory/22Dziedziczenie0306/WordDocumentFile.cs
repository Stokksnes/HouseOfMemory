using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Dziedziczenie0306B
{
    internal class WordDocumentFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Print()
        {
            Console.WriteLine($"{FileName} printing");
        }
    }
}
