using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class DemographiceFacade
    {
        private IEngine _engine;
        private IDataExtractor _dataExtractor;

        public DemographiceFacade(IEngine engine, IDataExtractor dataExtractor)
        {
            _engine = engine;
            _dataExtractor = dataExtractor;
        }

        public void CalculatePopulation()
        {
            _engine.DoYearTick();
        }
        public void InitStartPopulation()
        {
            _engine.InitStartPopulation(_dataExtractor);
        }


    }
}
