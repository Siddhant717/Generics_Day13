using System;

namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            GenericsMaximum<int> generic = new GenericsMaximum<int>(intArray);
            generic.PrintMaxValue();

            
        }
    }
}
