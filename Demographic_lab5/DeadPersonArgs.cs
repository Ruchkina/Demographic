using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class DeadPersonArgs : EventArgs
    {
        public int CurrentYear { get; }
        public Person DeadPerson { get; }
        public int Id { get; set; }
        public DeadPersonArgs (int year, Person person)
        {
            CurrentYear = year;
            DeadPerson = person;
            Id = DeadPerson.Id;
        }
    }
}
