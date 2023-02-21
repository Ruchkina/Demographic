using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class AgeGroup
    {
        public string Age { get; }

        public int Meaning { get; }

        public AgeGroup(string age, int meaning)
        {
            Age = age;
            Meaning = meaning;
        }
    }
}
