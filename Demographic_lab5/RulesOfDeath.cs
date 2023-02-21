using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class RulesOfDeath
    {
        List<ProbabilityDeathByAge> ProbabilityDeath = new List<ProbabilityDeathByAge>();

        public RulesOfDeath(List<ProbabilityDeathByAge> tableDeath)
        {
            this.ProbabilityDeath = tableDeath;
        }
        public double FindDeathProbability(int age, Person.Sex gender)
        {
            var selected = ProbabilityDeath.Where(x => x.LowerBound <= age && x.UpperBound >= age).First();
            if (gender == Person.Sex.man)
                return selected.DeathMan;
            else
                return selected.DeathWoman;
        }


    }

}
