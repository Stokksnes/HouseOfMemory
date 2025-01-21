using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejs0309Mono
{
    internal class PowerPointFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compresing PowerPointFile");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting...");
        }
    }
}
