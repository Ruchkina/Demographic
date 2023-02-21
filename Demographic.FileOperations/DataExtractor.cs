using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic_lab5;

namespace Demographic.FileOperations
{

    public class DataExtractor : IDataExtractor
    {
        private readonly string _initialFilePath;
        private readonly string _deathRuleFilePath;

        public DataExtractor(string initialAgePath, string deathRulePath)
        {
            _initialFilePath = initialAgePath;
            _deathRuleFilePath = deathRulePath;
        }

        public RulesOfDeath GetDeathRules()
        {
            string[] data = File.ReadAllLines("C:/univer/labs/Demographic_lab5/DeathRules.csv"/*_deathRuleFilePath*/);

            var TableDeath = new List<ProbabilityDeathByAge>();

            for (int i = 1; i < data.Length; i++)
            {
                string[] splited = data[i].Split(',');

                TableDeath.Add(new ProbabilityDeathByAge(
                    int.Parse(splited[0]), int.Parse(splited[1]),
                    double.Parse(splited[2].Replace('.', ',')), double.Parse(splited[3].Replace('.', ',')))
                );
            }

            return new RulesOfDeath(TableDeath);
        }
        public List<InitialDistributionPeople> GetAgeDistribution()
        {
            string[] data = File.ReadAllLines("C:/univer/labs/Demographic_lab5/InitialAge.csv"/*_initialFilePath*/);

            List<InitialDistributionPeople> InitData = new List<InitialDistributionPeople>();

            for (int i = 1; i < data.Length; i++)
            {
                string[] splited = data[i].Split(',');
                InitialDistributionPeople x = new InitialDistributionPeople();
                InitData.Add(x);
                InitData[i - 1].Age = int.Parse(splited[0]);
                InitData[i - 1].Quantity = double.Parse(splited[1].Replace('.', ','));
            }
            return InitData;
        }
    }
}
