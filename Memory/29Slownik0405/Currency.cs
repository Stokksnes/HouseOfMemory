using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Slownik0405
{
    public class Currency
    {
        public string Name;
        public string FullName;
        public double Rate;
        public Currency(string name, string fullname, double rate)
        {
            Name = name;
            FullName = fullname;
            Rate = rate;
        }

    }
}
