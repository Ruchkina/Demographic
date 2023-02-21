using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class BornPersonArgs : EventArgs
    {
        public int CurrentNumber { get; }
        public BornPersonArgs(int year)
        {
            CurrentNumber = year;
        }
    }
}
