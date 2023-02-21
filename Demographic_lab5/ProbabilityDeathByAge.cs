using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class ProbabilityDeathByAge
    {
        public int LowerBound { get; }
        public int UpperBound { get; }
        public double DeathWoman { get; }
        public double DeathMan { get; }
        public ProbabilityDeathByAge(int lowerBound, int upperBound, double deathMan, double deathWoman)
        {
            LowerBound = lowerBound;
            UpperBound = upperBound;
            DeathMan = deathMan;
            DeathWoman = deathWoman;
        }
    }
}
