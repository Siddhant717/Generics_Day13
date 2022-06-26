using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    public class GenericsMaximum<T> where T : IComparable
    {
        public T[] value;

        /// <summary>
        /// This method is created for initialize the constructor of instance variable
        /// </summary>
        /// <param name="value"></param>
        public GenericsMaximum(T[] value)
        {
            this.value = value;
        }
        /// <summary>
        /// This method is created for sorting the values
        /// </summary>
        /// <param name="value"></param>
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        
        /// <summary>
        /// This method created for finding max for given type
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        /// <summary>
        /// This method created calling maxvalue method
        /// </summary>
        /// <returns></returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        
        /// <summary>
        /// This method is printing max generic value
        /// </summary>
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}