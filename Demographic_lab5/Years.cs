using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class Years
    {
        public int Year { get; }
        public double Meaning { get; }
        public Years(int year, double value)
        {
            Year = year;
            Meaning = value;
        }
    }
}
