using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public interface IEngine
    {
        //List<Person> Persons { get; set; }
        int StartYear { get; set; }
        int EndYear { get; set; }

        void DoYearTick();
        void InitStartPopulation(IDataExtractor dataExtractor);
        List<Years> GetAllPopulation();
        List<Years> GetWomanPopulation();

        List<Years> GetManPopulation();

        List<int> GetManAgePopulation();
        List<int> GetWomanAgePopulation();
    }
}
