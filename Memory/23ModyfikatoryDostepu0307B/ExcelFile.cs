using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23ModyfikatoryDostepu0307B
{
    internal class ExcelFile : File
    {
        public void GenerateReport()
        {
            string prop = ProtectedProp;

            Console.WriteLine($"{FileName} report...");
        }
    }
}
