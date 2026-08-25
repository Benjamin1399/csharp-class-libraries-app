using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public static class PersonCalculations
    {
        public static int CalculateAge(int yearBorn)
        {
            int age = 0;

            int currentYear = DateTime.Now.Year;

            age = currentYear - yearBorn;

            return age;
        }
    }
}
