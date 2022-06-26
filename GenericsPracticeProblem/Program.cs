using System;

namespace GenericsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Float Number is- ");
            double answer = MaximumNumberCheck.MaximumFloatNumber(120.34, 225.67, 80.32);
            Console.WriteLine(answer);
        }
    }
}
