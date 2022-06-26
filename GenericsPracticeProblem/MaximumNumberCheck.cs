using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    public class MaximumNumberCheck
    {
        /// <summary>
        /// This method is created for max float number
        /// </summary>

        public static double MaximumFloatNumber(double firstvalue, double secondvalue, double thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;                                                                              //UC2
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            throw new Exception("firstnumber,secondnumber,thirdnumber are same");

        }
    }
}
