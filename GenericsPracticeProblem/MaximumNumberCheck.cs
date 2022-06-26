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
        /// This method is created for max string number
        /// </summary>

        public static string MaximumString(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            {
                return firststring;                                                                              //UC3
            }
            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0)
            {
                return secondstring;
            }
            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0)
            {
                return thirdstring;
            }
            throw new Exception("firstnumber,secondnumber,thirdnumber are same");

        }
    }
}
