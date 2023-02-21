using System.Collections.Generic;

namespace Demographic
{
    public interface IDataExtractor
    {
        RulesOfDeath GetDeathRules();
        List<InitialDistributionPeople> GetAgeDistribution();
    }
}