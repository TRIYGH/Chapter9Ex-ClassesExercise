using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleProj
{
    class GoToClassThatCalcsx100
    {
        private int theNumThatWasPassedIn;

        // Constructor with 1 parameter
        public GoToClassThatCalcsx100(int num)
        {
            theNumThatWasPassedIn = num;
        }

        // Method - to do the work
        public int MultipleByHundred()
        {
            return (theNumThatWasPassedIn * 100);
        }
    }
}
