using System;

namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Number- ");
            int[] intArray = { 120, 140, 200, 500 };
            GenericsMaximum<int> generic = new GenericsMaximum<int>(intArray);
            generic.PrintMaxValue();

            Console.WriteLine("Float Number- ");
            double[] doubleArray = { 10.34, 15.65, 2.34, 12.22 };
            GenericsMaximum<double> genericDouble = new GenericsMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            Console.WriteLine("String- ");
            string[] stringArray = { "15", "65", "30", "10" };
            GenericsMaximum<string> genericString = new GenericsMaximum<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
