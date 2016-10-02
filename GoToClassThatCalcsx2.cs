using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleProj
{
    class GoToClassThatCalcsx2
    {
        private int theNumThatWasPassedIn;

        // Constructor with 1 parameter
        public GoToClassThatCalcsx2(int num)
        {
            theNumThatWasPassedIn = num;
        }

        // Method - to do the work
        public int MultipleByTwo()
        {
            return (theNumThatWasPassedIn * 2);
        }
    }
}
