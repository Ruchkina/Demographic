using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class Person
    {
        public enum Sex { man, woman }
        public Sex Gender { get; }
        public int DateBirth { get; }
        public int DateDeath { get; set; }
        public int Age { get; set; }
        public bool Status { get; set; }
        public int Id { get; set; }

        private RulesOfDeath _deathRule;

        /*      public delegate void DeadHandler<T>(object sender, T e);
                public event void DeadHandler<int> PersonDead;*/

        public event EventHandler<DeadPersonArgs> PersonDead;
        public event EventHandler<BornPersonArgs> PersonBorn;


        public Person(int dateBirth, int age, Sex gender, RulesOfDeath deathRule, int id)
        {
            DateBirth = dateBirth;
            Age = age;
            Gender = gender;
            _deathRule = deathRule;
            Status = true;
            Id = id;
            DateDeath = -1;
        }

        public void YearTick(object sender, int year)
        {
            if (Status)
            {
                Age++;
                Status = !ProbabilityCalculator.IsEventHappened(_deathRule.FindDeathProbability(Age, Gender));
                if (!Status)
                    PersonDead?.Invoke(this, new DeadPersonArgs(year, this));
                
                else if (Status && Gender == Person.Sex.woman && Age >= 18 && Age <= 45)
                {
                    if (ProbabilityCalculator.IsEventHappened(0.151))
                        PersonBorn?.Invoke(this, new BornPersonArgs(year));
                }
            }
        }
    }
}
