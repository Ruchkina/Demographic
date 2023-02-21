using System;
using System.Collections.Generic;
using System.Linq;


namespace Demographic
{
    public class Engine : IEngine
    {
        public const int PEOPLE_RATIO = 1000;

        private List<Person> _population = new List<Person>();
        private RulesOfDeath _deathRules;

        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int StartPopulation { get; private set; }

        public event EventHandler<int> YearTick;

        public Engine(/*IDataExtractor dataExtractor,*/ int startYear, int endYear, int startPopulation)
        {
            StartPopulation = startPopulation;
            StartYear = startYear;
            EndYear = endYear;
/*            _deathRules = dataExtractor.GetDeathRules();
            InitPopulation(dataExtractor.GetAgeDistribution());*/
        }

        public void InitStartPopulation(IDataExtractor dataExtractor)
        {
            _deathRules = dataExtractor.GetDeathRules();
            InitPopulation(dataExtractor.GetAgeDistribution());
        }

        public void DoYearTick()
        {
            for (int i = StartYear; i <= EndYear; i++)
            {
                YearTick?.Invoke(this, i);
            }
        }

        public void OnPersonDead(object sender, DeadPersonArgs e)
        {
            e.DeadPerson.DateDeath = e.CurrentYear;
            e.DeadPerson.Status = false;
            YearTick -= _population[e.Id].YearTick;
            _population[e.Id].PersonBorn -= OnPersonBorn;
            _population[e.Id].PersonDead -= OnPersonDead;
        }

        public void OnPersonBorn(object sender, BornPersonArgs e)
        {
            if (ProbabilityCalculator.IsEventHappened(0.55))
            {
                _population.Add(new Person(e.CurrentNumber, 0, Person.Sex.woman, _deathRules, _population.Count));
                _population.Last().PersonBorn += OnPersonBorn;
            }
            else
                _population.Add(new Person(e.CurrentNumber, 0, Person.Sex.man, _deathRules, _population.Count));

            YearTick += _population.Last().YearTick;
            _population.Last().PersonDead += OnPersonDead;
        }

/*        public void ChangeStates()
        {
            YearTick += _population.Last().YearTick;
            _population.Last().PersonBorn += OnPersonBorn;
            _population.Last().PersonDead += OnPersonDead;
        }*/


        public Person InitPerson(int age, int id)
        {
            Person.Sex sex;
            if (ProbabilityCalculator.IsEventHappened(0.5))
                sex = Person.Sex.woman;
            else
                sex = Person.Sex.man;
            Person person = new Person(StartYear - age, age, sex, _deathRules, id);

            YearTick += person.YearTick;
            person.PersonBorn += OnPersonBorn;
            person.PersonDead += OnPersonDead;

            return person;
        }

        void InitPopulation(List<InitialDistributionPeople> InitData)
        {
            foreach (var dataAge in InitData)
            {
                int peoplCertainAge = (int)Math.Round((StartPopulation / PEOPLE_RATIO) / 1000 * dataAge.Quantity);
                for (int i = 0; i < peoplCertainAge; i++)
                    _population.Add(InitPerson(dataAge.Age, i));
            }
        }





        public List<Years> GetAllPopulation()
        {
            List<Years> result = new List<Years>();
            for (int year = StartYear; year <= EndYear; year++)
                result.Add(new Years(year, _population.Count(person => person.DateBirth <= year && (person.DateDeath > year || person.DateDeath == -1))));
            return result;
        }

        public List<Years> GetWomanPopulation()
        {
            List<Years> result = new List<Years>();
            for (int year = StartYear; year <= EndYear; year++)
                result.Add(new Years(year, _population.Count(person => person.DateBirth <= year && (person.DateDeath > year || person.DateDeath == -1) && person.Gender == Person.Sex.woman)));
            return result;
        }

        public List<Years> GetManPopulation()
        {
            List<Years> result = new List<Years>();
            for (int year = StartYear; year <= EndYear; year++)
                result.Add(new Years(year, _population.Count(person => person.DateBirth <= year && (person.DateDeath > year || person.DateDeath == -1) && person.Gender == Person.Sex.man)));
            return result;
        }

        public List<int> GetManAgePopulation()
        {
            List<int> AgeGroups = new List<int>();
            string[] ages = new string[] { "0,18", "19,44", "45,65", "66,100" };
            for (int i = 0; i < 4; i++)
            {
                string[] splited = ages[i].Split(',');
                int c = _population.Count(person => person.Gender == Person.Sex.man && person.Age >= int.Parse(splited[0]) && person.Age <= int.Parse(splited[1]) && person.Status);
                //AgeGroup gr = new AgeGroup(ages[i], c);
                AgeGroups.Add(c);
            }
            return AgeGroups;
        }
        
        public List<int> GetWomanAgePopulation()
        {
            List<int> AgeGroups = new List<int>();
            string[] ages = new string[] { "0,18", "19,44", "45,65", "66,100" };
            for (int i = 0; i < 4; i++)
            {
                string[] splited = ages[i].Split(',');
                int c = _population.Count(person => person.Gender == Person.Sex.woman && person.Age >= int.Parse(splited[0]) && person.Age <= int.Parse(splited[1]) && person.Status);
                //AgeGroup gr = new AgeGroup(ages[i], c);
                AgeGroups.Add(c);
            }
            return AgeGroups;
        }

    }
}
 